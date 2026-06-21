using System.Collections;
using System.Collections.Generic;
using CMS;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class CarWashLogic
{
	public static bool listen = true;

	private static readonly Dictionary<int, bool> pendingWashes = new();
	private static bool processRoutineRunning;

	public static void Reset()
	{
		listen = true;
		pendingWashes.Clear();
		processRoutineRunning = false;
	}

	public static void QueueWash(int carLoaderID, bool interior)
	{
		pendingWashes[carLoaderID] = interior;
		if (!processRoutineRunning)
			MelonCoroutines.Start(ProcessWashQueue());
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.TweenExteriorDustWash))]
	[HarmonyPostfix]
	public static void DTweenExteriorDustWashHook(float targetDust, float targetWash, float time, CarLoader __instance)
	{
		if(!Client.Instance.isConnected || !listen) 
		{ 
			listen = true; 
			return;
		}

		if (__instance == null || __instance.gameObject == null || __instance.gameObject.name.Length < 11)
		{
			MelonLogger.Warning("[CarWashLogic->DTweenExteriorDustWashHook] Invalid CarLoader gameObject name.");
			return;
		}

		int carLoaderID = __instance.gameObject.name[10] - '0' - 1;
		
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
		if(!Client.Instance.isConnected || !listen) 
		{ 
			listen = true; 
			return;
		}

		if (carLoader == null || carLoader.gameObject == null || carLoader.gameObject.name.Length < 11)
		{
			MelonLogger.Warning("[CarWashLogic->DoWorkAnimHook] Invalid CarLoader reference.");
			return;
		}

		int carLoaderID = carLoader.gameObject.name[10] - '0' - 1;
		
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

	private static IEnumerator ProcessWashQueue()
	{
		processRoutineRunning = true;

		while (pendingWashes.Count > 0)
		{
			yield return LoadWait.WaitForClientGameReady();
			if (LoadWait.LastResult != LoadWaitResult.Success)
				break;

			yield return LoadWait.WaitForGameDataReady();
			if (LoadWait.LastResult != LoadWaitResult.Success)
				break;

			var keys = new List<int>(pendingWashes.Keys);
			foreach (var carLoaderID in keys)
			{
				if (!pendingWashes.TryGetValue(carLoaderID, out var interior))
					continue;

				yield return LoadWait.WaitForCarLoaded(carLoaderID);
				if (LoadWait.LastResult != LoadWaitResult.Success)
				{
					pendingWashes.Remove(carLoaderID);
					continue;
				}

				yield return ApplyWash(carLoaderID, interior);
				pendingWashes.Remove(carLoaderID);
			}
		}

		processRoutineRunning = false;
	}

	private static IEnumerator ApplyWash(int carLoaderID, bool interior)
	{
		yield return new WaitForEndOfFrame();

		if (GameData.Instance == null || GameData.Instance.carLoaders == null)
			yield break;

		if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length)
			yield break;

		if (GameData.Instance.carLoaders[carLoaderID] == null)
			yield break;

		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID))
		{
			MelonLogger.Warning($"[CarWashLogic->ApplyWash] Car at carLoaderID {carLoaderID} is not in loadedCars. Skipping wash.");
			yield break;
		}

		if (ClientData.Instance.loadedCars[carLoaderID].needResync)
		{
			MelonLogger.Warning($"[CarWashLogic->ApplyWash] Car at carLoaderID {carLoaderID} is still resyncing. Skipping wash.");
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
			MelonLogger.Msg($"[CarWashLogic->ApplyWash] Exterior wash applied to carLoaderID: {carLoaderID}.");
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
			MelonLogger.Msg($"[CarWashLogic->ApplyWash] Interior wash applied to carLoaderID: {carLoaderID}.");
		}

		listen = true;
	}
}
