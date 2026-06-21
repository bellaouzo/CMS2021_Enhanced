using CMS21Together.ClientSide.Data.Handle;
using HarmonyLib;
using MelonLoader;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class DynoLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(DynoManager), nameof(DynoManager.RunDyno))]
    [HarmonyPostfix]
    public static void RunDynoHook()
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        var dyno = DynoManager.m_instance;
        if (dyno == null || dyno.CarLoader == null)
        {
            MelonLogger.Warning("[DynoLogic->RunDynoHook] DynoManager or CarLoader is null.");
            return;
        }

        var cl = dyno.CarLoader;
        if (cl.gameObject == null || cl.gameObject.name.Length < 11)
        {
            MelonLogger.Warning("[DynoLogic->RunDynoHook] Invalid CarLoader gameObject name.");
            return;
        }

        int carLoaderID = cl.gameObject.name[10] - '0' - 1;
        if (carLoaderID < 0 || carLoaderID >= 5)
        {
            MelonLogger.Warning($"[DynoLogic->RunDynoHook] Invalid carLoaderID: {carLoaderID}");
            return;
        }

        ClientSend.DynoRunPacket(carLoaderID);
        MelonLogger.Msg($"[DynoLogic->RunDynoHook] Dyno run sent for carLoaderID: {carLoaderID}");
    }

    public static System.Collections.IEnumerator ApplyDynoRun(int carLoaderID)
    {
        while (!ClientData.GameReady)
            yield return new UnityEngine.WaitForSeconds(0.25f);
        yield return new UnityEngine.WaitForEndOfFrame();

        var dyno = DynoManager.m_instance;
        if (dyno == null)
        {
            MelonLogger.Warning("[DynoLogic->ApplyDynoRun] DynoManager is null.");
            yield break;
        }

        listen = false;
        dyno.canRunDyno = true;
        dyno.RunDyno();
        MelonLogger.Msg($"[DynoLogic->ApplyDynoRun] Applied dyno run for carLoaderID: {carLoaderID}");
    }
}
