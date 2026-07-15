using System.Collections;
using System.Collections.Generic;
using CMS.Containers;
using CMS.SceneLoaders;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data.Garage.Car;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ServerSide;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Scene;

[HarmonyPatch]
public static class SceneCarSyncLogic
{
	public static bool listen = true;

	private static readonly Queue<ModSceneCar> pendingScene = new();
	private static bool processRoutineRunning;

	// Auction catalog pending data. slotIndex >= 100 = salvage; < 100 = normal.
	private static readonly Dictionary<int, ModSceneCar> pendingAuctionNormal = new();
	private static readonly Dictionary<int, ModSceneCar> pendingAuctionSalvage = new();
	private static bool auctionRoutineRunning;

	// Keyed by slot index; value is (carSupport, slotTransform) captured at CreateCar Prefix time.
	internal static readonly Dictionary<int, (GameObject carSupport, Transform transform)> barnParams    = new();
	internal static readonly Dictionary<int, (GameObject carSupport, Transform transform)> junkyardParams = new();

	private static int syncGeneration;

	public static void Reset()
	{
		syncGeneration++;
		listen = true;
		pendingScene.Clear();
		processRoutineRunning = false;
		pendingAuctionNormal.Clear();
		pendingAuctionSalvage.Clear();
		auctionRoutineRunning = false;
		barnParams.Clear();
		junkyardParams.Clear();
	}

	public static void QueueSceneCar(ModSceneCar data)
	{
		if (data.sceneType == SceneCarType.Auction)
		{
			bool isSalvage = data.slotIndex >= 100;
			int realIndex = isSalvage ? data.slotIndex - 100 : data.slotIndex;
			if (isSalvage) pendingAuctionSalvage[realIndex] = data;
			else pendingAuctionNormal[realIndex] = data;

			if (!auctionRoutineRunning)
				MelonCoroutines.Start(InjectAuctionCatalog());
			return;
		}
		pendingScene.Enqueue(data);
		if (!processRoutineRunning)
			MelonCoroutines.Start(ProcessSceneQueue());
	}

	// Called by ClientHandle when a scene car part-switch packet arrives.
	public static void ApplySceneCarPart(ModSceneCarPart data)
	{
		if (!listen || string.IsNullOrEmpty(data.partName)) return;
		var loader = FindSlotLoader(data.sceneType, data.slotIndex);
		if (loader == null) return;

		CarSyncHooks.listen = false;
		listen = false;
		loader.SwitchCarPart(data.partName);
		listen = true;
		CarSyncHooks.listen = true;
	}

	// Returns the (sceneType, slotIndex) for a CarLoader that belongs to a scene slot,
	// or false if it is a garage / unknown loader.
	public static bool TryGetSceneCarSlot(CarLoader loader, out SceneCarType sceneType, out int slotIndex)
	{
		// Barn: check if loader is under one of the captured carSupport hierarchies.
		foreach (var kvp in barnParams)
		{
			var p = kvp.Value;
			if ((p.carSupport != null && loader.transform.IsChildOf(p.carSupport.transform)) ||
			    (p.transform   != null && loader.transform.IsChildOf(p.transform)))
			{
				sceneType = SceneCarType.Barn;
				slotIndex = kvp.Key;
				return true;
			}
		}

		// Junkyard
		foreach (var kvp in junkyardParams)
		{
			var p = kvp.Value;
			if ((p.carSupport != null && loader.transform.IsChildOf(p.carSupport.transform)) ||
			    (p.transform   != null && loader.transform.IsChildOf(p.transform)))
			{
				sceneType = SceneCarType.Junkyard;
				slotIndex = kvp.Key;
				return true;
			}
		}

		// Salon: direct CarLoader array comparison.
		var sm = SalonManager.instance;
		if (sm?.carLoaders != null)
		{
			for (int i = 0; i < sm.carLoaders.Length; i++)
			{
				if (sm.carLoaders[i] == loader)
				{
					sceneType = SceneCarType.Salon;
					slotIndex = i;
					return true;
				}
			}
		}

		sceneType = default;
		slotIndex = -1;
		return false;
	}

	// Auction: CLIENT-only Prefix — if server data arrived before the scene generated cars,
	// substitute it directly so the UI sees the correct list on first render.
	[HarmonyPatch(typeof(AuctionManager), "GenerateCars", typeof(AuctionType))]
	[HarmonyPrefix]
	public static bool GenerateCarsClientPrefixHook(AuctionType auctionType, ref Il2CppSystem.Collections.Generic.List<AuctionCarData> __result)
	{
		if (!Client.Instance.isConnected || !listen) return true;
		if (Server.Instance.isRunning) return true; // host generates normally

		bool isSalvage = auctionType == AuctionType.Salvage;
		var pending = isSalvage ? pendingAuctionSalvage : pendingAuctionNormal;
		if (pending.Count == 0) return true; // no server data yet; fall through to random generation

		var list = new Il2CppSystem.Collections.Generic.List<AuctionCarData>();
		for (int i = 0; i < pending.Count; i++)
		{
			if (!pending.TryGetValue(i, out var d)) continue;
			list.Add(new AuctionCarData { Car = d.carId, Version = d.version, Rating = d.rating, Seed = d.seed, Value = d.value, StartingPrice = d.startingPrice, Sold = d.sold });
		}
		pending.Clear();

		__result = list;
		MelonLogger.Msg($"[SceneCarSyncLogic] Replaced {(isSalvage ? "salvage" : "normal")} auction generation with {list.Count} server cars.");
		return false;
	}

	// Auction: HOST-only Postfix — captures the generated car catalog and broadcasts it.
	// slotIndex < 100 = Normal auction; slotIndex >= 100 = Salvage auction.
	[HarmonyPatch(typeof(AuctionManager), "GenerateCars", typeof(AuctionType))]
	[HarmonyPostfix]
	public static void GenerateCarsHook(Il2CppSystem.Collections.Generic.List<AuctionCarData> __result, AuctionType auctionType)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (!Server.Instance.isRunning) return;
		if (__result == null || __result.Count == 0) return;

		int baseIndex = (auctionType == AuctionType.Salvage) ? 100 : 0;

		for (int i = 0; i < __result.Count; i++)
		{
			var car = __result[i];
			if (car == null) continue;
			var data = new ModSceneCar(SceneCarType.Auction, baseIndex + i, car.Car, car.Version)
			{
				rating        = car.Rating,
				seed          = car.Seed,
				value         = car.Value,
				startingPrice = car.StartingPrice,
				sold          = car.Sold,
			};
			ClientSend.SceneCarPacket(data);
		}
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent {__result.Count} auction cars (type={auctionType}).");
	}

	// Barn: Prefix saves carSupport + transform for later replay
	[HarmonyPatch(typeof(ShedManager), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPrefix]
	public static void ShedCreateCarPrefix(int index, GameObject carSupport, Transform t)
	{
		if (!Client.Instance.isConnected || !listen) return;
		barnParams[index] = (carSupport, t);
	}

	// Barn: HOST-only Postfix — broadcasts the randomly chosen car for this slot
	[HarmonyPatch(typeof(ShedManager), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPostfix]
	public static void ShedCreateCarPostfix(int index, CarsIdWithConfig carIdWithConfig)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (!Server.Instance.isRunning) return;
		ClientSend.SceneCarPacket(new ModSceneCar(SceneCarType.Barn, index, carIdWithConfig.CarID, carIdWithConfig.ConfigVersion));
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent barn slot {index}: {carIdWithConfig.CarID} v{carIdWithConfig.ConfigVersion}");
		MelonCoroutines.Start(SendSceneColorWhenReady(SceneCarType.Barn, index, carIdWithConfig));
	}

	// Junkyard: Prefix saves carSupport + transform for later replay
	[HarmonyPatch(typeof(JunkyardGenerator), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPrefix]
	public static void JunkyardCreateCarPrefix(int index, GameObject carSupport, Transform t)
	{
		if (!Client.Instance.isConnected || !listen) return;
		junkyardParams[index] = (carSupport, t);
	}

	// Junkyard: HOST-only Postfix — broadcasts the randomly chosen car for this slot
	[HarmonyPatch(typeof(JunkyardGenerator), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPostfix]
	public static void JunkyardCreateCarPostfix(int index, CarsIdWithConfig randomCar)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (!Server.Instance.isRunning) return;
		ClientSend.SceneCarPacket(new ModSceneCar(SceneCarType.Junkyard, index, randomCar.CarID, randomCar.ConfigVersion));
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent junkyard slot {index}: {randomCar.CarID} v{randomCar.ConfigVersion}");
		MelonCoroutines.Start(SendSceneColorWhenReady(SceneCarType.Junkyard, index, randomCar));
	}

	// Finds the CarLoader for a given scene slot. Searches by spatial proximity when slot params exist.
	// Pass null expectedCarId to match any loaded car.
	private static CarLoader FindSlotLoader(SceneCarType sceneType, int index, string expectedCarId = null)
	{
		if (sceneType == SceneCarType.Salon)
		{
			var sm = SalonManager.instance;
			if (sm?.carLoaders == null || index >= sm.carLoaders.Length) return null;
			return sm.carLoaders[index];
		}

		var paramDict = sceneType == SceneCarType.Barn ? barnParams : junkyardParams;
		Transform slotTransform = null;
		if (paramDict.TryGetValue(index, out var p))
		{
			slotTransform = p.transform;
			CarLoader loader = null;
			if (p.carSupport != null)
				loader = p.carSupport.GetComponentInChildren<CarLoader>(true);
			if (loader == null && p.transform != null)
				loader = p.transform.GetComponentInChildren<CarLoader>(true);
			if (loader == null && p.transform != null && p.transform.parent != null)
				loader = p.transform.parent.GetComponentInChildren<CarLoader>(true);
			if (loader != null && (expectedCarId == null || loader.carToLoad == expectedCarId))
				return loader;
		}

		// Fallback: scan all CarLoaders and pick the closest to the slot's transform.
		CarLoader best = null;
		float bestDist = float.MaxValue;
		foreach (var loader in Object.FindObjectsOfType<CarLoader>())
		{
			if (loader == null) continue;
			if (expectedCarId != null && !string.IsNullOrEmpty(loader.carToLoad) && loader.carToLoad != expectedCarId)
				continue;
			if (string.IsNullOrEmpty(loader.carToLoad) && !loader.IsCarLoaded())
				continue;

			if (slotTransform == null)
			{
				if (best == null) best = loader;
				continue;
			}

			float dist = Vector3.Distance(loader.transform.position, slotTransform.position);
			if (dist < bestDist) { bestDist = dist; best = loader; }
		}
		return best;
	}

	private static bool IsSceneActive(SceneCarType sceneType)
	{
		return sceneType switch
		{
			SceneCarType.Barn     => SceneManager.CurrentScene() == GameScene.barn,
			SceneCarType.Junkyard => SceneManager.CurrentScene() == GameScene.junkyard,
			_                     => false,
		};
	}

	private static IEnumerator SendSceneColorWhenReady(SceneCarType sceneType, int index, CarsIdWithConfig config)
	{
		int generation = syncGeneration;
		float waited = 0f;
		const float timeout = 15f;
		const float poll = 0.25f;

		while (waited < timeout)
		{
			if (generation != syncGeneration || !IsSceneActive(sceneType)) yield break;

			var loader = FindSlotLoader(sceneType, index, config.CarID);
			if (loader != null && (loader.IsCarLoaded() || !string.IsNullOrEmpty(loader.carToLoad)))
			{
				ModColor color = null;
				try
				{
					color = loader.IsCarLoaded() ? new ModColor(loader.GetCarColor()) : new ModColor(loader.color);
				}
				catch { yield break; }

				if (color == null || generation != syncGeneration || !IsSceneActive(sceneType)) yield break;

				ClientSend.SceneCarPacket(new ModSceneCar(sceneType, index, config.CarID, config.ConfigVersion, color));
				MelonLogger.Msg($"[SceneCarSyncLogic] Sent {sceneType} slot {index} color update.");
				yield break;
			}

			waited += poll;
			yield return new WaitForSeconds(poll);
		}
	}

	private static IEnumerator InjectAuctionCatalog()
	{
		auctionRoutineRunning = true;

		yield return LoadWait.WaitForComponent<AuctionManager>(30f);
		if (LoadWait.LastResult != LoadWaitResult.Success)
		{
			auctionRoutineRunning = false;
			yield break;
		}

		yield return LoadWait.WaitForPredicate(() =>
		{
			var am = Object.FindObjectOfType<AuctionManager>();
			if (am == null) return false;
			bool normalDone  = pendingAuctionNormal.Count  == 0 || am.normalCarsGenerated;
			bool salvageDone = pendingAuctionSalvage.Count == 0 || am.salvageCarsGenerated;
			return normalDone && salvageDone;
		}, 30f, "auction catalog generation");
		if (LoadWait.LastResult == LoadWaitResult.Disconnected)
		{
			auctionRoutineRunning = false;
			yield break;
		}

		var am2 = Object.FindObjectOfType<AuctionManager>();
		if (am2 == null) { auctionRoutineRunning = false; yield break; }

		if (pendingAuctionNormal.Count > 0)
		{
			var list = new Il2CppSystem.Collections.Generic.List<AuctionCarData>();
			for (int i = 0; i < pendingAuctionNormal.Count; i++)
			{
				if (!pendingAuctionNormal.TryGetValue(i, out var d)) continue;
				list.Add(new AuctionCarData { Car = d.carId, Version = d.version, Rating = d.rating, Seed = d.seed, Value = d.value, StartingPrice = d.startingPrice, Sold = d.sold });
			}
			listen = false;
			am2.normalCars = list;
			listen = true;
			MelonLogger.Msg($"[SceneCarSyncLogic] Injected {list.Count} normal auction cars.");
		}

		if (pendingAuctionSalvage.Count > 0)
		{
			var list = new Il2CppSystem.Collections.Generic.List<AuctionCarData>();
			for (int i = 0; i < pendingAuctionSalvage.Count; i++)
			{
				if (!pendingAuctionSalvage.TryGetValue(i, out var d)) continue;
				list.Add(new AuctionCarData { Car = d.carId, Version = d.version, Rating = d.rating, Seed = d.seed, Value = d.value, StartingPrice = d.startingPrice, Sold = d.sold });
			}
			listen = false;
			am2.salvageCars = list;
			listen = true;
			MelonLogger.Msg($"[SceneCarSyncLogic] Injected {list.Count} salvage auction cars.");
		}

		pendingAuctionNormal.Clear();
		pendingAuctionSalvage.Clear();
		auctionRoutineRunning = false;
	}

	private static IEnumerator ProcessSceneQueue()
	{
		processRoutineRunning = true;
		int generation = syncGeneration;

		while (pendingScene.Count > 0)
		{
			if (generation != syncGeneration) break;
			var data = pendingScene.Dequeue();
			yield return new WaitForEndOfFrame();
			if (generation != syncGeneration) break;

			if (data.sceneType == SceneCarType.Barn)
				yield return ApplySceneSlot(data, generation, GameScene.barn);
			else if (data.sceneType == SceneCarType.Junkyard)
				yield return ApplySceneSlot(data, generation, GameScene.junkyard);
		}

		processRoutineRunning = false;
	}

	// Shared slot-apply logic for Barn and Junkyard.
	// Waits for the scene to be loaded, then waits for a CarLoader in that slot to fully load
	// its locally-generated random car, then replaces it with the host's car via CarLoader.LoadCar.
	private static IEnumerator ApplySceneSlot(ModSceneCar data, int generation, GameScene scene)
	{
		yield return LoadWait.WaitForScene(scene);
		if (LoadWait.LastResult != LoadWaitResult.Success || generation != syncGeneration) yield break;

		int slot = data.slotIndex;

		// Wait for the local random car in this slot to finish loading so it is safe to replace.
		yield return LoadWait.WaitForPredicate(() =>
		{
			if (generation != syncGeneration) return true;
			var loader = FindSlotLoader(data.sceneType, slot);
			return loader != null && loader.IsCarLoaded();
		}, 25f, $"{data.sceneType} slot {slot} local load");
		if (generation != syncGeneration || LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		var existing = FindSlotLoader(data.sceneType, slot);
		if (existing == null)
		{
			MelonLogger.Warning($"[SceneCarSyncLogic] No CarLoader found for {data.sceneType} slot {slot}.");
			yield break;
		}

		// Wait for the scene to be fully initialized (loading screen dismissed) before
		// swapping the car. Calling LoadCar while the barn/junkyard completion system is
		// still tracking the original CarLoader resets IsCarLoaded() to false and keeps
		// the loading screen stuck at ~80%.
		yield return LoadWait.WaitForNotificationReady(60f);
		if (generation != syncGeneration || LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		// Re-fetch the loader in case the scene changed while we waited.
		existing = FindSlotLoader(data.sceneType, slot);
		if (existing == null) yield break;

		// Replace only if the loaded car is different from what the host has.
		if (existing.carToLoad != data.carId || existing.ConfigVersion != data.version)
		{
			listen = false;
			existing.ConfigVersion = data.version;
			MainMod.StartCoroutine(existing.LoadCar(data.carId));
			listen = true;
		}

		// Apply color once the new car is loaded.
		if (data.color != null)
		{
			yield return LoadWait.WaitForPredicate(() =>
			{
				if (generation != syncGeneration) return true;
				var loader = FindSlotLoader(data.sceneType, slot, data.carId);
				return loader != null && loader.IsCarLoaded();
			}, 15f, $"{data.sceneType} slot {slot} color apply");

			if (generation != syncGeneration) yield break;
			CarAppearanceHelper.ApplyColor(FindSlotLoader(data.sceneType, slot, data.carId), data.color);
		}

		if (generation == syncGeneration)
			MelonLogger.Msg($"[SceneCarSyncLogic] Applied {data.sceneType} slot {slot}: {data.carId} v{data.version}");
	}
}
