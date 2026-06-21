using System.Collections;
using CMS.UI.Windows;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared.Data.Vanilla.Cars;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class WheelAlignmentLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(WheelsAlignmentWindow), nameof(WheelsAlignmentWindow.UpdateCarWheelAlignment))]
    [HarmonyPostfix]
    public static void UpdateCarWheelAlignmentHook(WheelsAlignmentWindow __instance)
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        var cl = __instance?.carLoader;
        if (cl == null || cl.gameObject == null || cl.gameObject.name.Length < 11)
        {
            MelonLogger.Warning("[WheelAlignmentLogic] Invalid CarLoader.");
            return;
        }

        int carLoaderID = cl.gameObject.name[10] - '0' - 1;
        if (carLoaderID < 0 || carLoaderID >= 5)
        {
            MelonLogger.Warning($"[WheelAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            return;
        }

        var wa = cl.WheelsAlignment;
        var modData = new ModWheelsAlignmentData { FL = wa.FL, FR = wa.FR, RL = wa.RL, RR = wa.RR };

        ClientSend.WheelAlignmentPacket(carLoaderID, modData);
        MelonLogger.Msg($"[WheelAlignmentLogic] Alignment sent for carLoaderID: {carLoaderID}");
    }

    public static IEnumerator ApplyWheelAlignment(int carLoaderID, ModWheelsAlignmentData modData)
    {
        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);
        yield return new WaitForEndOfFrame();

        if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length)
        {
            MelonLogger.Warning($"[WheelAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            yield break;
        }

        var cl = GameData.Instance.carLoaders[carLoaderID];
        if (cl == null) yield break;

        listen = false;
        var alignData = modData.ToGame(modData);
        cl.WheelsAlignment = new WheelsAlignment(alignData);

        MelonLogger.Msg($"[WheelAlignmentLogic] Applied alignment for carLoaderID: {carLoaderID}");
    }
}
