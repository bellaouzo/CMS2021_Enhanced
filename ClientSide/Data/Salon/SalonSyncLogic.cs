using System.Collections;
using System.Collections.Generic;
using CMS.Salon;
using CMS.SceneLoaders;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ServerSide;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Salon;

[HarmonyPatch]
public static class SalonSyncLogic
{
	public static bool listen = true;

	private static readonly Queue<ModSalonCar> pendingSalon = new();
	private static bool processRoutineRunning;

	public static void Reset()
	{
		listen = true;
		pendingSalon.Clear();
		processRoutineRunning = false;
	}

	public static void QueueSalonCar(ModSalonCar data)
	{
		pendingSalon.Enqueue(data);
		if (!processRoutineRunning)
			MelonCoroutines.Start(ProcessSalonQueue());
	}

	// Fires when the host's SalonManager loads a car into a catalog display slot.
	[HarmonyPatch(typeof(SalonManager), "LoadCar", typeof(CarLoader), typeof(CarsIdWithConfig))]
	[HarmonyPostfix]
	public static void SalonLoadCarHook(SalonManager __instance, CarLoader carLoader, CarsIdWithConfig randomCar)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (!Server.Instance.isRunning) return;
		if (__instance?.carLoaders == null || carLoader == null || randomCar == null) return;
		if (SceneManager.CurrentScene() != GameScene.auto_salon) return;

		int slotIndex = -1;
		for (int i = 0; i < __instance.carLoaders.Length; i++)
		{
			if (__instance.carLoaders[i] == carLoader)
			{
				slotIndex = i;
				break;
			}
		}
		if (slotIndex < 0) return;

		ClientSend.SalonCarPacket(randomCar.CarID, randomCar.ConfigVersion, slotIndex);
		MelonLogger.Msg($"[SalonSyncLogic] Sent catalog slot {slotIndex}: {randomCar.CarID} v{randomCar.ConfigVersion}");
	}

	// Fires when the host switches which car is shown in the configurator detail view.
	[HarmonyPatch(typeof(Configurator), nameof(Configurator.LoadCar))]
	[HarmonyPostfix]
	public static void LoadCarHook(string carToLoad, int version)
	{
		if (!Client.Instance.isConnected || !listen)
			return;

		if (SceneManager.CurrentScene() != GameScene.auto_salon)
			return;

		ClientSend.SalonCarPacket(carToLoad, version);
	}

	private static IEnumerator ProcessSalonQueue()
	{
		processRoutineRunning = true;

		while (pendingSalon.Count > 0)
		{
			var data = pendingSalon.Dequeue();

			yield return LoadWait.WaitForScene(GameScene.auto_salon);
			if (LoadWait.LastResult != LoadWaitResult.Success)
				break;

			yield return new WaitForEndOfFrame();

			if (data.slotIndex >= 0)
			{
				// Catalog slot: wait for SalonManager and for the local car to finish loading
				// in that slot (avoids racing with the remote's own SalonManager.Generate()).
				yield return LoadWait.WaitForComponent<SalonManager>(30f);
				if (LoadWait.LastResult != LoadWaitResult.Success)
					continue;

				int slot = data.slotIndex;
				yield return LoadWait.WaitForPredicate(
					() => {
						var sm = SalonManager.instance;
						if (sm == null) return false;
						var loaders = sm.carLoaders;
						if (loaders == null || slot >= loaders.Length) return true;
						var loader = loaders[slot];
						return loader != null && loader.IsCarLoaded();
					},
					30f,
					$"salon slot {slot} initial load"
				);
				if (LoadWait.LastResult == LoadWaitResult.Disconnected)
					break;

				var sm2 = SalonManager.instance;
				if (sm2?.carLoaders == null || slot >= sm2.carLoaders.Length)
					continue;

				var carLoader = sm2.carLoaders[slot];
				if (carLoader == null)
					continue;

				var randomCar = new CarsIdWithConfig { CarID = data.carId, ConfigVersion = data.version };

				listen = false;
				MainMod.StartCoroutine(sm2.LoadCar(carLoader, randomCar));
				listen = true;
				MelonLogger.Msg($"[SalonSyncLogic] Applied catalog slot {slot}: {data.carId} v{data.version}");
			}
			else
			{
				// Configurator view sync.
				yield return LoadWait.WaitForComponent<Configurator>(30f);
				if (LoadWait.LastResult != LoadWaitResult.Success)
					continue;

				var configurator = Object.FindObjectOfType<Configurator>();
				if (configurator == null)
					continue;

				listen = false;
				configurator.LoadCar(data.carId, data.version);
				listen = true;
			}
		}

		processRoutineRunning = false;
	}
}
