using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ClientSide.Data.Player;
using HarmonyLib;
using MelonLoader;

namespace CMS21Together.ClientSide.Data.Player;

[HarmonyPatch]
public static class CrouchSync
{
	private static bool lastCrouchState;

	[HarmonyPatch(typeof(FPSCamera), nameof(FPSCamera.UpdateCrouchingState))]
	[HarmonyPostfix]
	public static void UpdateCrouchingStateHook()
	{
		if (!Client.Instance.isConnected || !ClientData.GameReady) return;

		bool isCrouching = FPSCamera.isCrouching;
		if (isCrouching == lastCrouchState) return;

		lastCrouchState = isCrouching;
		Movement.SendPosition(true);
	}

	public static void Reset() => lastCrouchState = false;
}
