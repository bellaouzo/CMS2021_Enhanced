using System;
using System.Collections;
using System.Collections.Generic;
using CMS.Salon;
using CMS.SceneLoaders;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ServerSide;
using CMS21Together.ServerSide.Data;
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
	private static readonly HashSet<int> purchasedSlots = new();
	private static readonly Dictionary<int, ModSalonCar> localCatalog = new();

	public static void Reset()
	{
		listen = true;
		pendingSalon.Clear();
		processRoutineRunning = false;
		// Keep purchasedSlots + localCatalog across scene hops so leave/return stays consistent.
	}

	public static void FullReset()
	{
		Reset();
		purchasedSlots.Clear();
		localCatalog.Clear();
	}

	public static void QueueSalonCar(ModSalonCar data)
	{
		if (data.slotIndex >= 0)
		{
			if (data.purchased)
			{
				purchasedSlots.Add(data.slotIndex);
				localCatalog.Remove(data.slotIndex);
			}
			else if (!purchasedSlots.Contains(data.slotIndex))
				localCatalog[data.slotIndex] = data;
		}

		pendingSalon.Enqueue(data);
		if (!processRoutineRunning)
			MelonCoroutines.Start(ProcessSalonQueue());
	}

	public static IEnumerator ScanSalonCatalog()
	{
		if (!Client.Instance.isConnected || !Server.Instance.isRunning) yield break;

		yield return LoadWait.WaitForComponent<SalonManager>(30f);
		if (LoadWait.LastResult != LoadWaitResult.Success) yield break;

		yield return LoadWait.WaitForPredicate(() =>
		{
			var sm = SalonManager.instance;
			if (sm?.carLoaders == null) return false;
			for (int i = 0; i < sm.carLoaders.Length; i++)
			{
				var loader = sm.carLoaders[i];
				if (loader != null && !string.IsNullOrEmpty(loader.carToLoad) && !loader.IsCarLoaded())
					return false;
			}
			return true;
		}, 30f, "salon catalog load");
		if (LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		var sm2 = SalonManager.instance;
		if (sm2?.carLoaders == null) yield break;

		// Re-entering salon: re-apply the authoritative server catalog instead of broadcasting
		// freshly regenerated random cars (which desyncs everyone).
		bool hasServerState = ServerData.Instance.salonCatalog.Count > 0
		                      || ServerData.Instance.salonPurchasedSlots.Count > 0;
		if (hasServerState)
		{
			yield return ApplyAuthoritativeSalonState(sm2);
			ClientSend.SceneCarsReady(SceneCarType.Salon,
				ServerData.Instance.salonCatalog.Count);
			yield break;
		}

		for (int i = 0; i < sm2.carLoaders.Length; i++)
		{
			if (purchasedSlots.Contains(i)) continue;
			var loader = sm2.carLoaders[i];
			if (loader == null || !loader.IsCarLoaded()) continue;
			if (string.IsNullOrEmpty(loader.carToLoad)) continue;

			var color = CarAppearanceHelper.CaptureColor(loader);
			var data = new ModSalonCar(loader.carToLoad, loader.ConfigVersion, i, color);
			localCatalog[i] = data;
			ClientSend.SalonCarPacket(loader.carToLoad, loader.ConfigVersion, i, color);
			MelonLogger.Msg($"[SalonSyncLogic] Sent catalog slot {i}: {loader.carToLoad} v{loader.ConfigVersion}");
		}

		ClientSend.SceneCarsReady(SceneCarType.Salon, sm2.carLoaders.Length - purchasedSlots.Count);
	}

	private static IEnumerator ApplyAuthoritativeSalonState(SalonManager sm)
	{
		// Restore purchased markers from server.
		foreach (int slot in ServerData.Instance.salonPurchasedSlots)
			purchasedSlots.Add(slot);

		for (int i = 0; i < sm.carLoaders.Length; i++)
		{
			var loader = sm.carLoaders[i];
			if (loader == null) continue;

			if (purchasedSlots.Contains(i) || ServerData.Instance.salonPurchasedSlots.Contains(i))
			{
				listen = false;
				try
				{
					if (loader.IsCarLoaded() || !string.IsNullOrEmpty(loader.carToLoad))
						loader.DeleteCar();
					loader.gameObject.SetActive(false);
				}
				catch { loader.gameObject.SetActive(false); }
				listen = true;
				MelonLogger.Msg($"[SalonSyncLogic] Re-applied purchased empty slot {i}.");
				continue;
			}

			if (!ServerData.Instance.salonCatalog.TryGetValue(i, out var data) || data == null)
				continue;

			localCatalog[i] = data;
			loader.gameObject.SetActive(true);

			bool needsReload = loader.carToLoad != data.carId || loader.ConfigVersion != data.version;
			if (needsReload)
			{
				var cfg = new CarsIdWithConfig { CarID = data.carId, ConfigVersion = data.version };
				listen = false;
				MainMod.StartCoroutine(sm.LoadCar(loader, cfg));
				listen = true;
				yield return LoadWait.WaitForPredicate(
					() => loader != null && loader.IsCarLoaded() && loader.carToLoad == data.carId,
					20f, $"salon reapply slot {i}");
			}

			if (data.color != null)
				yield return CarAppearanceHelper.ApplyColorAfterLoad(loader, data.color);

			MelonLogger.Msg($"[SalonSyncLogic] Re-applied catalog slot {i}: {data.carId} v{data.version}");
		}
	}

	[HarmonyPatch(typeof(GameScript), nameof(GameScript.BuyCar), typeof(CarLoader), typeof(int))]
	[HarmonyPostfix]
	public static void BuyCarHook(CarLoader carLoader)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (SceneManager.CurrentScene() != GameScene.auto_salon) return;
		if (carLoader == null) return;

		var sm = SalonManager.instance;
		if (sm?.carLoaders == null) return;

		for (int i = 0; i < sm.carLoaders.Length; i++)
		{
			if (sm.carLoaders[i] != carLoader) continue;
			purchasedSlots.Add(i);
			localCatalog.Remove(i);
			ClientSend.SalonCarPacket(carLoader.carToLoad, carLoader.ConfigVersion, i, null, purchased: true);
			MelonLogger.Msg($"[SalonSyncLogic] Car {carLoader.carToLoad} purchased from slot {i}, broadcasting removal.");
			return;
		}
	}

	[HarmonyPatch(typeof(Configurator), nameof(Configurator.LoadCar))]
	[HarmonyPostfix]
	public static void LoadCarHook(string carToLoad, int version)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (SceneManager.CurrentScene() != GameScene.auto_salon) return;
		MelonCoroutines.Start(SendConfiguratorCar(carToLoad, version));
	}

	[HarmonyPatch(typeof(Configurator), nameof(Configurator.SetCarColor))]
	[HarmonyPostfix]
	public static void SetCarColorHook(Color32 color)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (SceneManager.CurrentScene() != GameScene.auto_salon) return;

		var configurator = UnityEngine.Object.FindObjectOfType<Configurator>();
		if (configurator == null || !configurator.CarIsLoaded) return;

		var loader = GetConfiguratorLoader(configurator);
		if (loader == null || string.IsNullOrEmpty(loader.carToLoad)) return;

		ClientSend.SalonCarPacket(
			loader.carToLoad,
			loader.ConfigVersion,
			-1,
			new ModColor(new Color(color.r / 255f, color.g / 255f, color.b / 255f, color.a / 255f)));
	}

	private static CarLoader GetConfiguratorLoader(Configurator configurator)
	{
		if (configurator == null) return null;
		var customCar = configurator.CustomCar ?? configurator.customCar;
		return customCar?.CarLoader ?? customCar?.carLoader;
	}

	private static IEnumerator SendConfiguratorCar(string carToLoad, int version)
	{
		yield return LoadWait.WaitForComponent<Configurator>(10f);
		if (LoadWait.LastResult != LoadWaitResult.Success) yield break;

		var configurator = UnityEngine.Object.FindObjectOfType<Configurator>();
		if (configurator == null) yield break;

		yield return LoadWait.WaitForPredicate(
			() => configurator != null && configurator.CarIsLoaded,
			20f, "configurator car load");
		if (LoadWait.LastResult != LoadWaitResult.Success) yield break;

		var color = CarAppearanceHelper.CaptureColor(GetConfiguratorLoader(configurator));
		ClientSend.SalonCarPacket(carToLoad, version, -1, color);
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
				if (data.purchased)
				{
					purchasedSlots.Add(data.slotIndex);
					localCatalog.Remove(data.slotIndex);
					var smP = SalonManager.instance;
					if (smP?.carLoaders != null && data.slotIndex < smP.carLoaders.Length)
					{
						var cl = smP.carLoaders[data.slotIndex];
						if (cl != null)
						{
							listen = false;
							try
							{
								if (cl.IsCarLoaded() || !string.IsNullOrEmpty(cl.carToLoad))
									cl.DeleteCar();
								cl.gameObject.SetActive(false);
							}
							catch (Exception ex)
							{
								MelonLogger.Warning($"[SalonSyncLogic] Failed to unload purchased slot {data.slotIndex}: {ex.Message}");
								cl.gameObject.SetActive(false);
							}
							listen = true;
							MelonLogger.Msg($"[SalonSyncLogic] Removed purchased salon slot {data.slotIndex}.");
						}
					}
					continue;
				}

				if (purchasedSlots.Contains(data.slotIndex))
					continue;

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
						return loader != null && (loader.IsCarLoaded() || string.IsNullOrEmpty(loader.carToLoad));
					},
					30f, $"salon slot {slot} initial load");
				if (LoadWait.LastResult == LoadWaitResult.Disconnected)
					break;

				var sm2 = SalonManager.instance;
				if (sm2?.carLoaders == null || slot >= sm2.carLoaders.Length)
					continue;

				var carLoader = sm2.carLoaders[slot];
				if (carLoader == null)
					continue;

				carLoader.gameObject.SetActive(true);

				bool needsReload = carLoader.carToLoad != data.carId
				                   || carLoader.ConfigVersion != data.version;

				if (needsReload)
				{
					var randomCar = new CarsIdWithConfig { CarID = data.carId, ConfigVersion = data.version };
					listen = false;
					MainMod.StartCoroutine(sm2.LoadCar(carLoader, randomCar));
					listen = true;
				}

				if (data.color != null)
					yield return CarAppearanceHelper.ApplyColorAfterLoad(carLoader, data.color);

				MelonLogger.Msg($"[SalonSyncLogic] Applied catalog slot {slot}: {data.carId} v{data.version}");
			}
			else
			{
				yield return LoadWait.WaitForComponent<Configurator>(30f);
				if (LoadWait.LastResult != LoadWaitResult.Success)
					continue;

				var configurator = UnityEngine.Object.FindObjectOfType<Configurator>();
				if (configurator == null)
					continue;

				var currentLoader = GetConfiguratorLoader(configurator);
				bool needsReload = currentLoader == null
				                   || currentLoader.carToLoad != data.carId
				                   || currentLoader.ConfigVersion != data.version;

				if (needsReload)
				{
					listen = false;
					configurator.LoadCar(data.carId, data.version);
					listen = true;

					yield return LoadWait.WaitForPredicate(
						() => configurator != null && configurator.CarIsLoaded,
						20f, "configurator remote load");
				}

				if (data.color != null)
				{
					var loader = GetConfiguratorLoader(configurator);
					if (loader != null)
						CarAppearanceHelper.ApplyColor(loader, data.color);

					listen = false;
					try
					{
						var c = data.color.ToGame();
						configurator.SetCarColor(new Color32(
							(byte)Mathf.Clamp(Mathf.RoundToInt(c.r * 255f), 0, 255),
							(byte)Mathf.Clamp(Mathf.RoundToInt(c.g * 255f), 0, 255),
							(byte)Mathf.Clamp(Mathf.RoundToInt(c.b * 255f), 0, 255),
							(byte)Mathf.Clamp(Mathf.RoundToInt(c.a * 255f), 0, 255)));
					}
					finally
					{
						listen = true;
					}
				}
			}
		}

		processRoutineRunning = false;
	}
}
