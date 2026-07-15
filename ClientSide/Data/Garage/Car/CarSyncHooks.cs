using System.Collections;
using System.Collections.Generic;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ClientSide.Data.Scene;
using CMS21Together.Shared.Data.Vanilla;
using CMS21Together.Shared.Data.Vanilla.Cars;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Car;

[HarmonyPatch]
public static class CarSyncHooks
{
	public static bool listen = true;
	public static bool listenToChangePosition = true;

	// Debounce duplicate SwitchCarPart overloads: key by part only, send final state once.
	private static readonly Dictionary<string, object> pendingScenePartSends = new();

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(string))]
	[HarmonyPostfix]
	public static void SwitchCarPartNameHook(string name, CarLoader __instance)
	{
		QueueScenePartSwitch(__instance, name);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(string), typeof(bool))]
	[HarmonyPostfix]
	public static void SwitchCarPartNameInstantHook(string name, bool instant, CarLoader __instance)
	{
		QueueScenePartSwitch(__instance, name);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(CarPart), typeof(bool), typeof(bool))]
	[HarmonyPostfix]
	public static void SwitchCarPartStateHook(CarPart part, bool instant, bool switched, CarLoader __instance)
	{
		if (part == null) return;
		QueueScenePartSwitch(__instance, part.name);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(CarPart), typeof(bool))]
	[HarmonyPostfix]
	public static void SwitchCarPartAnimHook(CarPart part, bool instant, CarLoader __instance)
	{
		if (part == null) return;
		QueueScenePartSwitch(__instance, part.name);
	}

	private static void QueueScenePartSwitch(CarLoader loader, string partName)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (loader == null || string.IsNullOrEmpty(partName)) return;

		if (SceneCarSyncLogic.TryGetSceneCarSlot(loader, out var sceneType, out var slotIndex))
		{
			string key = $"{(int)sceneType}:{slotIndex}:{partName}";
			if (pendingScenePartSends.TryGetValue(key, out var existing) && existing != null)
			{
				try { MelonCoroutines.Stop(existing); } catch { /* ignore */ }
			}
			pendingScenePartSends[key] = MelonCoroutines.Start(SendScenePartDelayed(loader, sceneType, slotIndex, partName, key));
			return;
		}

		// Garage car
		if (loader.gameObject == null || loader.gameObject.name.Length < 11) return;
		int carLoaderID = loader.gameObject.name[10] - '0' - 1;
		if (carLoaderID < 0 || carLoaderID >= 5) return;
		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID)) return;

		MelonCoroutines.Start(SendPartSwitch(loader, partName, carLoaderID, delay: true));
	}

	private static IEnumerator SendScenePartDelayed(CarLoader loader, SceneCarType sceneType, int slotIndex,
		string partName, string key)
	{
		// Wait for all SwitchCarPart overloads to settle on the final Switched value.
		yield return new WaitForEndOfFrame();
		yield return new WaitForSeconds(0.08f);

		pendingScenePartSends.Remove(key);
		if (!Client.Instance.isConnected || !listen || loader == null) yield break;

		bool switched = false;
		bool hasSwitched = false;
		try
		{
			var p = loader.GetCarPart(partName);
			if (p != null)
			{
				switched = p.Switched;
				hasSwitched = true;
			}
		}
		catch { /* ignore */ }

		ClientSend.SceneCarPartPacket(new ModSceneCarPart(sceneType, slotIndex, partName, switched, hasSwitched));
		MelonLogger.Msg($"[CarSyncHooks] Synced scene part '{partName}' switched={switched} on {sceneType} slot {slotIndex}.");
	}

	private static IEnumerator SendPartSwitch(CarLoader loader, string partName, int carLoaderID, bool delay)
	{
		if (delay)
		{
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();
			yield return new WaitForSeconds(0.05f);
		}
		else
		{
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();
		}

		if (!Client.Instance.isConnected || !listen) yield break;
		if (!ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var car)) yield break;

		if (!PartUpdateHooks.FindBodyPartInDictionary(car, partName, out var key))
			yield break;

		var part = car.CarPartInfo.BodyPartsReferences[key];
		if (part == null) yield break;

		ClientSend.BodyPartPacket(new ModCarPart(part, key, carLoaderID), carLoaderID);
		MelonLogger.Msg($"[CarSyncHooks] Synced SwitchCarPart '{partName}' on car {carLoaderID} (switched={part.Switched}).");
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.ChangePosition), typeof(int))]
	[HarmonyPrefix]
	public static bool ChangePositionHook(int no, CarLoader __instance)
	{
		if (!Client.Instance.isConnected || !listenToChangePosition)
		{
			listenToChangePosition = true;
			return true;
		}

		var carLoaderID = __instance.gameObject.name[10] - '0' - 1;
		MelonLogger.Msg($"Move {__instance.carToLoad} to {no}.");
		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID))
			return true;
		if (no == -1)
			return false;

		var car = ClientData.Instance.loadedCars[carLoaderID];
		car.carPosition = no;

		ClientSend.CarPositionPacket(carLoaderID, no);
		return true;
	}
}
