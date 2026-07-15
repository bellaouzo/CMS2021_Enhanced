using System.Collections;
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

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(string))]
	[HarmonyPostfix]
	public static void SwitchCarPartNameHook(string name, CarLoader __instance)
	{
		QueuePartSwitch(__instance, name);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(string), typeof(bool))]
	[HarmonyPostfix]
	public static void SwitchCarPartNameInstantHook(string name, bool instant, CarLoader __instance)
	{
		QueuePartSwitch(__instance, name);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(CarPart), typeof(bool), typeof(bool))]
	[HarmonyPostfix]
	public static void SwitchCarPartStateHook(CarPart part, bool instant, bool switched, CarLoader __instance)
	{
		if (part == null) return;
		QueuePartSwitch(__instance, part.name);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.SwitchCarPart), typeof(CarPart), typeof(bool))]
	[HarmonyPostfix]
	public static void SwitchCarPartAnimHook(CarPart part, bool instant, CarLoader __instance)
	{
		if (part == null) return;
		QueuePartSwitch(__instance, part.name, delay: true);
	}

	private static void QueuePartSwitch(CarLoader loader, string partName, bool delay = false)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (loader == null || string.IsNullOrEmpty(partName)) return;

		// Scene car (barn, junkyard, salon) — send a lightweight sceneCarPart packet.
		if (SceneCarSyncLogic.TryGetSceneCarSlot(loader, out var sceneType, out var slotIndex))
		{
			ClientSend.SceneCarPartPacket(new ModSceneCarPart(sceneType, slotIndex, partName));
			MelonLogger.Msg($"[CarSyncHooks] Synced scene part '{partName}' on {sceneType} slot {slotIndex}.");
			return;
		}

		// Garage car
		if (loader.gameObject == null || loader.gameObject.name.Length < 11) return;
		int carLoaderID = loader.gameObject.name[10] - '0' - 1;
		if (carLoaderID < 0 || carLoaderID >= 5) return;
		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID)) return;

		MelonCoroutines.Start(SendPartSwitch(loader, partName, carLoaderID, delay));
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
