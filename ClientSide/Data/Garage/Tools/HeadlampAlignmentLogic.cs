using System.Collections;
using CMS.UI.Windows;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared.Data.Vanilla.Cars;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class HeadlampAlignmentLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(LampAlignmentWindow), nameof(LampAlignmentWindow.ChangeLamp))]
    [HarmonyPostfix]
    public static void ChangeLampHook(LampAlignmentWindow __instance)
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        var cl = __instance?.carLoader;
        if (cl == null || cl.gameObject == null || cl.gameObject.name.Length < 11)
        {
            MelonLogger.Warning("[HeadlampAlignmentLogic] Invalid CarLoader.");
            return;
        }

        int carLoaderID = cl.gameObject.name[10] - '0' - 1;
        if (carLoaderID < 0 || carLoaderID >= 5)
        {
            MelonLogger.Warning($"[HeadlampAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            return;
        }

        var la = cl.HeadlampLeftAlignment;
        var ra = cl.HeadlampRightAlignment;
        var modLeft  = new ModHeadLampAlignmentData { Horizontal = la.Horizontal, Vertical = la.Vertical };
        var modRight = new ModHeadLampAlignmentData { Horizontal = ra.Horizontal, Vertical = ra.Vertical };

        ClientSend.HeadlampAlignmentPacket(carLoaderID, modLeft, modRight);
        MelonLogger.Msg($"[HeadlampAlignmentLogic] Headlamp alignment sent for carLoaderID: {carLoaderID}");
    }

    public static IEnumerator ApplyHeadlampAlignment(int carLoaderID, ModHeadLampAlignmentData modLeft, ModHeadLampAlignmentData modRight)
    {
        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);
        yield return new WaitForEndOfFrame();

        if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length)
        {
            MelonLogger.Warning($"[HeadlampAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            yield break;
        }

        var cl = GameData.Instance.carLoaders[carLoaderID];
        if (cl == null) yield break;

        listen = false;
        cl.HeadlampLeftAlignment  = new HeadlampAlignment(modLeft.ToGame());
        cl.HeadlampRightAlignment = new HeadlampAlignment(modRight.ToGame());

        MelonLogger.Msg($"[HeadlampAlignmentLogic] Applied headlamp alignment for carLoaderID: {carLoaderID}");
    }
}
