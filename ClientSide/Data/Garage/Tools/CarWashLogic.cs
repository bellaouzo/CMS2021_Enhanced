using System.Collections;
using CMS;
using CMS21Together.ClientSide.Data.Handle;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class CarWashLogic
{
	public static bool listen = true;

	public static void Reset() => listen = true;
	
	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.TweenExteriorDustWash))]
	[HarmonyPostfix]
	public static void DTweenExteriorDustWashHook(float targetDust, float targetWash, float time, CarLoader __instance)
	{
		// Business Rule: Only sync if connected and listening flag is enabled
		if(!Client.Instance.isConnected || !listen) 
		{ 
			listen = true; 
			return;
		}

		// Observation: Extract carLoaderID from gameObject name (format: "CarLoader_X")
		// Security Rule: Validate name length before accessing character
		if (__instance == null || __instance.gameObject == null || __instance.gameObject.name.Length < 11)
		{
			MelonLogger.Warning("[CarWashLogic->DTweenExteriorDustWashHook] Invalid CarLoader gameObject name.");
			return;
		}

		int carLoaderID = __instance.gameObject.name[10] - '0' - 1;
		
		// Business Rule: Validate carLoaderID is within valid range
		if (carLoaderID < 0 || carLoaderID >= 5)
		{
			MelonLogger.Warning($"[CarWashLogic->DTweenExteriorDustWashHook] Invalid carLoaderID: {carLoaderID}");
			return;
		}

		ClientSend.CarWashPacket(carLoaderID);
	}
	
	[HarmonyPatch(typeof(InteriorDetailingToolkitLogic), nameof(InteriorDetailingToolkitLogic.DoWorkAnim))]
	[HarmonyPrefix]
	public static void DoWorkAnimHook(CarLoader carLoader)
	{
		// Business Rule: Only sync if connected and listening flag is enabled
		if(!Client.Instance.isConnected || !listen) 
		{ 
			listen = true; 
			return;
		}

		// Security Rule: Validate carLoader is not null
		if (carLoader == null || carLoader.gameObject == null || carLoader.gameObject.name.Length < 11)
		{
			MelonLogger.Warning("[CarWashLogic->DoWorkAnimHook] Invalid CarLoader reference.");
			return;
		}

		int carLoaderID = carLoader.gameObject.name[10] - '0' - 1;
		
		// Business Rule: Validate carLoaderID is within valid range
		if (carLoaderID < 0 || carLoaderID >= 5)
		{
			MelonLogger.Warning($"[CarWashLogic->DoWorkAnimHook] Invalid carLoaderID: {carLoaderID}");
			return;
		}

		ClientSend.CarWashPacket(carLoaderID, true);
		MelonLogger.Msg($"[CarWashLogic->DoWorkAnimHook] Interior wash requested for carLoaderID: {carLoaderID}");
	}

	[HarmonyPatch(typeof(global::CarWashLogic), nameof(global::CarWashLogic.DoWorkAnim))]
	[HarmonyPrefix]
	public static void OutdoorCarWashHook(CarLoader carLoader)
	{
		if (!Client.Instance.isConnected || !listen)
		{
			listen = true;
			return;
		}

		if (carLoader == null || carLoader.gameObject == null || carLoader.gameObject.name.Length < 11)
		{
			MelonLogger.Warning("[CarWashLogic->OutdoorCarWashHook] Invalid CarLoader reference.");
			return;
		}

		int carLoaderID = carLoader.gameObject.name[10] - '0' - 1;

		if (carLoaderID < 0 || carLoaderID >= 5)
		{
			MelonLogger.Warning($"[CarWashLogic->OutdoorCarWashHook] Invalid carLoaderID: {carLoaderID}");
			return;
		}

		ClientSend.CarWashPacket(carLoaderID, false);
		MelonLogger.Msg($"[CarWashLogic->OutdoorCarWashHook] Outdoor wash for carLoaderID: {carLoaderID}");
	}

	/// <summary>
	/// Handles car wash synchronization from server.
	/// Applies wash effect to the specified car loader.
	/// </summary>
	/// <param name="carLoaderID">The ID of the car loader to wash (0-4)</param>
	/// <param name="interior">Whether to wash interior (true) or exterior (false)</param>
	public static IEnumerator WashCar(int carLoaderID, bool interior)
	{
		// Business Rule: Wait for game to be ready before processing
		while (!ClientData.GameReady)
		{
			// Security Rule: Check if client disconnected during wait
			if (!Client.Instance.isConnected)
			{
				MelonLogger.Warning("[CarWashLogic->WashCar] Client disconnected while waiting for game ready.");
				yield break;
			}
			yield return new WaitForSeconds(0.25f);
		}

		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();

		// Security Rule: Validate GameData.Instance is initialized
		if (GameData.Instance == null)
		{
			MelonLogger.Error("[CarWashLogic->WashCar] GameData.Instance is null. Cannot wash car.");
			yield break;
		}

		// Security Rule: Validate carLoaders array is initialized
		if (GameData.Instance.carLoaders == null)
		{
			MelonLogger.Error("[CarWashLogic->WashCar] carLoaders array is null. Cannot wash car.");
			yield break;
		}

		// Business Rule: Validate carLoaderID is within array bounds
		if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length)
		{
			MelonLogger.Error($"[CarWashLogic->WashCar] Invalid carLoaderID: {carLoaderID}. Array length: {GameData.Instance.carLoaders.Length}");
			yield break;
		}

		// Security Rule: Validate carLoader at index is not null
		if (GameData.Instance.carLoaders[carLoaderID] == null)
		{
			MelonLogger.Warning($"[CarWashLogic->WashCar] CarLoader at index {carLoaderID} is null. Car may not be loaded.");
			yield break;
		}

		// Business Rule: Check if car is already loaded (if loaded, skip to avoid duplicate operations)
		// Note: Original logic was inverted - should check if NOT loaded, not if loaded
		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID))
		{
			MelonLogger.Warning($"[CarWashLogic->WashCar] Car at carLoaderID {carLoaderID} is not in loadedCars dictionary. Skipping wash.");
			yield break;
		}

		listen = false;

		if (!interior)
		{
			var outdoorWash = Object.FindObjectOfType<global::CarWashLogic>();
			if (outdoorWash != null)
			{
				var anim = outdoorWash.DoWorkAnim(GameData.Instance.carLoaders[carLoaderID]);
				if (anim != null)
				{
					while (anim.MoveNext())
						yield return anim.Current;
				}
			}

			GameData.Instance.carLoaders[carLoaderID].TweenExteriorDustWash(0f, 1f, 3f);
			MelonLogger.Msg($"[CarWashLogic->WashCar] Exterior wash applied to carLoaderID: {carLoaderID} with 3s duration.");
		}
		else
		{
			var interiorToolkit = Object.FindObjectOfType<InteriorDetailingToolkitLogic>();
			if (interiorToolkit != null)
			{
				var anim = interiorToolkit.DoWorkAnim(GameData.Instance.carLoaders[carLoaderID]);
				if (anim != null)
				{
					while (anim.MoveNext())
						yield return anim.Current;
				}
			}

			GameData.Instance.carLoaders[carLoaderID].TweenInteriorConditionAndDust(1f, 0f, 3f);
			MelonLogger.Msg($"[CarWashLogic->WashCar] Interior wash applied to carLoaderID: {carLoaderID}");
		}

		listen = true;
	}
}