using System.Collections;
using System.Collections.Generic;
using CMS.Garage.Customization;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ServerSide;
using CMS21Together.Shared;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage;

[HarmonyPatch]
public static class GarageCustomizationLogic
{
    public static bool listen = true;
    public static bool sentInitial;
    public static bool applyingRemote;

    private static readonly Queue<(int section, int material)> pendingApplies = new();
    private static bool applyRoutineRunning;

    public static void Reset()
    {
        listen = true;
        sentInitial = false;
        applyingRemote = false;
        pendingApplies.Clear();
        applyRoutineRunning = false;
    }

    [HarmonyPatch(typeof(GarageLookManager), nameof(GarageLookManager.SetMaterialIndexForSection))]
    [HarmonyPostfix]
    public static void SetMaterialIndexForSectionHook(int sectionIndex, int materialIndex)
    {
        if (!Client.Instance.isConnected || !listen || applyingRemote)
        {
            listen = true;
            return;
        }

        if (materialIndex < 0) return;

        ClientSend.GarageCustomizationPacket(sectionIndex, materialIndex);
        MelonLogger.Msg($"[GarageCustomizationLogic] Section {sectionIndex} material {materialIndex} sent.");
    }

    public static void QueueGarageLook(int sectionIndex, int materialIndex)
    {
        pendingApplies.Enqueue((sectionIndex, materialIndex));
        if (!applyRoutineRunning)
            MelonCoroutines.Start(ProcessGarageLookQueue());
    }

    public static IEnumerator SendInitial()
    {
        if (sentInitial || !Server.Instance.isRunning) yield break;

        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.2f);
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        listen = false;
        applyingRemote = true;

        var mgr = GarageLookManager.Instance;
        if (mgr != null)
        {
            var sections = mgr.GetSections();
            if (sections != null)
            {
                for (int i = 0; i < sections.Length; i++)
                {
                    int materialIndex = sections[i].SelectedMaterialIndex;
                    if (materialIndex < 0) continue;
                    ClientSend.GarageCustomizationPacket(i, materialIndex);
                    yield return new WaitForEndOfFrame();
                }
            }
        }
        else if (SavesManager.currentSave != null)
        {
            var indexes = SavesManager.currentSave.garageCustomizationData.MaterialIndexes;
            if (indexes != null)
            {
                for (int i = 0; i < indexes.Length; i++)
                {
                    int materialIndex = indexes[i];
                    if (materialIndex < 0) continue;
                    ClientSend.GarageCustomizationPacket(i, materialIndex);
                    yield return new WaitForEndOfFrame();
                }
            }
        }

        sentInitial = true;
        applyingRemote = false;
        listen = true;
        MelonLogger.Msg("[GarageCustomizationLogic] Sent initial garage look to server.");
    }

    private static IEnumerator ProcessGarageLookQueue()
    {
        applyRoutineRunning = true;
        applyingRemote = true;

        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);

        while (GarageLookManager.Instance == null)
        {
            if (!Client.Instance.isConnected)
            {
                applyRoutineRunning = false;
                applyingRemote = false;
                listen = true;
                yield break;
            }
            yield return new WaitForSeconds(0.25f);
        }

        yield return new WaitForEndOfFrame();

        var mgr = GarageLookManager.Instance;
        listen = false;

        while (pendingApplies.Count > 0)
        {
            var (sectionIndex, materialIndex) = pendingApplies.Dequeue();
            if (materialIndex < 0) continue;

            mgr.SetMaterialIndexForSection(sectionIndex, materialIndex);
            MelonLogger.Msg($"[GarageCustomizationLogic] Applied section {sectionIndex} material {materialIndex}.");
            yield return new WaitForEndOfFrame();
        }

        listen = true;
        applyingRemote = false;
        applyRoutineRunning = false;
    }
}
