using System.Collections;
using System.Collections.Generic;
using CMS.Managers;
using CMS.Parking;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage;

[HarmonyPatch]
public static class DoorSyncLogic
{
	public const string PaintshopCloseAllId = "paintshop_close_all";

	public static bool listen = true;

	private static readonly Dictionary<string, GarageTeleport> teleportCache = new();

	public static void Reset()
	{
		listen = true;
		teleportCache.Clear();
	}

	public static string CarDoorId(int carLoaderID) => $"car_{carLoaderID}";

	[HarmonyPatch(typeof(GarageTeleport), nameof(GarageTeleport.Use))]
	[HarmonyPostfix]
	public static void GarageTeleportUseHook(GarageTeleport __instance)
	{
		if (!Client.Instance.isConnected || !listen) { listen = true; return; }

		ClientSend.DoorStatePacket(__instance.gameObject.name, __instance.isOpen);
	}

	[HarmonyPatch(typeof(PaintshopManager), nameof(PaintshopManager.CloseDoors))]
	[HarmonyPostfix]
	public static void PaintshopCloseDoorsHook()
	{
		if (!Client.Instance.isConnected || !listen) { listen = true; return; }

		ClientSend.DoorStatePacket(PaintshopCloseAllId, false);
	}

	[HarmonyPatch(typeof(ParkingSpace), nameof(ParkingSpace.OpenDoor))]
	[HarmonyPostfix]
	public static void ParkingOpenDoorHook(ParkingSpace __instance)
	{
		if (!Client.Instance.isConnected || !listen) { listen = true; return; }

		ClientSend.DoorStatePacket(__instance.gameObject.name, true);
	}

	[HarmonyPatch(typeof(ParkingSpace), nameof(ParkingSpace.CloseDoor))]
	[HarmonyPostfix]
	public static void ParkingCloseDoorHook(ParkingSpace __instance)
	{
		if (!Client.Instance.isConnected || !listen) { listen = true; return; }

		ClientSend.DoorStatePacket(__instance.gameObject.name, false);
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.CloseCarAnimated))]
	[HarmonyPrefix]
	public static void CarCloseAnimatedHook(CarLoader __instance)
	{
		if (!Client.Instance.isConnected || !listen) { listen = true; return; }

		int carLoaderID = GetCarLoaderID(__instance);
		if (carLoaderID < 0) return;

		ClientSend.DoorStatePacket(CarDoorId(carLoaderID), false, carLoaderID);
	}

	[HarmonyPatch(typeof(GameScript), "OpenDoorsBeforeExitFromInterior")]
	[HarmonyPrefix]
	public static void CarOpenDoorsHook(CarLoader carLoader)
	{
		if (!Client.Instance.isConnected || !listen) { listen = true; return; }
		if (carLoader == null) return;

		int carLoaderID = GetCarLoaderID(carLoader);
		if (carLoaderID < 0) return;

		ClientSend.DoorStatePacket(CarDoorId(carLoaderID), true, carLoaderID);
	}

	public static IEnumerator ApplyDoorState(ModDoorState state)
	{
		while (!ClientData.GameReady)
			yield return new WaitForSeconds(0.25f);
		while (SceneManager.CurrentScene() != GameScene.garage)
			yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();

		listen = false;

		if (state.doorId == PaintshopCloseAllId)
		{
			var paintshop = Object.FindObjectOfType<PaintshopManager>();
			if (paintshop != null)
				paintshop.CloseDoors();
			listen = true;
			yield break;
		}

		if (state.carLoaderID >= 0 && state.doorId.StartsWith("car_"))
		{
			if (GameData.Instance?.carLoaders == null || state.carLoaderID >= GameData.Instance.carLoaders.Length)
			{
				listen = true;
				yield break;
			}

			var carLoader = GameData.Instance.carLoaders[state.carLoaderID];
			if (carLoader == null)
			{
				listen = true;
				yield break;
			}

			if (state.isOpen)
			{
				var gameScript = Object.FindObjectOfType<GameScript>();
				if (gameScript != null)
				{
					var routine = gameScript.OpenDoorsBeforeExitFromInterior(carLoader);
					if (routine != null)
					{
						while (routine.MoveNext())
							yield return routine.Current;
					}
				}
			}
			else
			{
				var routine = carLoader.CloseCarAnimated();
				if (routine != null)
				{
					while (routine.MoveNext())
						yield return routine.Current;
				}
			}

			listen = true;
			yield break;
		}

		var parking = FindParkingSpace(state.doorId);
		if (parking != null)
		{
			if (state.isOpen)
				parking.OpenDoor(false, true);
			else
				parking.CloseDoor(true);
			listen = true;
			yield break;
		}

		var teleport = FindGarageTeleport(state.doorId);
		if (teleport != null)
		{
			if (teleport.isOpen != state.isOpen)
			{
				var routine = teleport.Switch(true);
				if (routine != null)
				{
					while (routine.MoveNext())
						yield return routine.Current;
				}
			}
		}

		listen = true;
	}

	private static GarageTeleport FindGarageTeleport(string doorId)
	{
		if (teleportCache.TryGetValue(doorId, out var cached) && cached != null)
			return cached;

		foreach (var teleport in Object.FindObjectsOfType<GarageTeleport>())
		{
			if (teleport.gameObject.name == doorId)
			{
				teleportCache[doorId] = teleport;
				return teleport;
			}
		}

		return null;
	}

	private static ParkingSpace FindParkingSpace(string doorId)
	{
		foreach (var space in Object.FindObjectsOfType<ParkingSpace>())
		{
			if (space.gameObject.name == doorId)
				return space;
		}

		return null;
	}

	private static int GetCarLoaderID(CarLoader carLoader)
	{
		if (carLoader?.gameObject == null || carLoader.gameObject.name.Length < 11)
			return -1;

		int id = carLoader.gameObject.name[10] - '0' - 1;
		return id >= 0 && id < 5 ? id : -1;
	}
}
