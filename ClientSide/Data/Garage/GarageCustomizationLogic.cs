using System.Collections;
using CMS.Garage.Customization;
using CMS21Together.ClientSide.Data.Handle;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage;

[HarmonyPatch]
public static class GarageCustomizationLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(GarageLookManager), nameof(GarageLookManager.SetMaterialIndexForSection))]
    [HarmonyPostfix]
    public static void SetMaterialIndexForSectionHook(int sectionIndex, int materialIndex)
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        if (materialIndex < 0) return;

        ClientSend.GarageCustomizationPacket(sectionIndex, materialIndex);
        MelonLogger.Msg($"[GarageCustomizationLogic] Section {sectionIndex} material {materialIndex} sent.");
    }

    public static IEnumerator ApplyGarageLook(int sectionIndex, int materialIndex)
    {
        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);
        yield return new WaitForEndOfFrame();

        var mgr = GarageLookManager.Instance;
        if (mgr == null)
        {
            MelonLogger.Warning("[GarageCustomizationLogic] GarageLookManager.instance is null.");
            yield break;
        }

        listen = false;
        mgr.SetMaterialIndexForSection(sectionIndex, materialIndex);
        MelonLogger.Msg($"[GarageCustomizationLogic] Applied section {sectionIndex} material {materialIndex}.");
    }
}
