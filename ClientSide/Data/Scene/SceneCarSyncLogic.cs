using System.Collections;
using System.Collections.Generic;
using CMS.Containers;
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

	private static readonly Dictionary<int, (GameObject carSupport, Transform transform)> barnParams = new();
	private static readonly Dictionary<int, (GameObject carSupport, Transform transform)> junkyardParams = new();

	public static void Reset()
	{
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

		// Wait for the local AuctionManager to finish generating whichever catalogs we have pending data for.
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
		if (am2 == null)
		{
			auctionRoutineRunning = false;
			yield break;
		}

		if (pendingAuctionNormal.Count > 0)
		{
			var list = new Il2CppSystem.Collections.Generic.List<AuctionCarData>();
			for (int i = 0; i < pendingAuctionNormal.Count; i++)
			{
				if (!pendingAuctionNormal.TryGetValue(i, out var d)) continue;
				list.Add(new AuctionCarData
				{
					Car           = d.carId,
					Version       = d.version,
					Rating        = d.rating,
					Seed          = d.seed,
					Value         = d.value,
					StartingPrice = d.startingPrice,
					Sold          = d.sold,
				});
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
				list.Add(new AuctionCarData
				{
					Car           = d.carId,
					Version       = d.version,
					Rating        = d.rating,
					Seed          = d.seed,
					Value         = d.value,
					StartingPrice = d.startingPrice,
					Sold          = d.sold,
				});
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

		while (pendingScene.Count > 0)
		{
			var data = pendingScene.Dequeue();
			yield return new WaitForEndOfFrame();

			if (data.sceneType == SceneCarType.Barn)
			{
				yield return LoadWait.WaitForScene(GameScene.barn);
				if (LoadWait.LastResult != LoadWaitResult.Success) break;

				int slot = data.slotIndex;
				yield return LoadWait.WaitForPredicate(() =>
				{
					if (!barnParams.TryGetValue(slot, out var p)) return false;
					return p.carSupport != null && p.carSupport.transform.childCount > 0;
				}, 15f, $"barn slot {slot} local load");
				if (LoadWait.LastResult == LoadWaitResult.Disconnected) break;

				if (!barnParams.TryGetValue(slot, out var barnParam)) continue;
				var sm = Object.FindObjectOfType<ShedManager>();
				if (sm == null) continue;

				var carIdWithConfig = new CarsIdWithConfig { CarID = data.carId, ConfigVersion = data.version };
				listen = false;
				MainMod.StartCoroutine(sm.CreateCar(slot, barnParam.carSupport, barnParam.transform, carIdWithConfig));
				listen = true;
				MelonLogger.Msg($"[SceneCarSyncLogic] Applied barn slot {slot}: {data.carId} v{data.version}");
			}
			else if (data.sceneType == SceneCarType.Junkyard)
			{
				yield return LoadWait.WaitForScene(GameScene.junkyard);
				if (LoadWait.LastResult != LoadWaitResult.Success) break;

				int slot = data.slotIndex;
				yield return LoadWait.WaitForPredicate(() =>
				{
					if (!junkyardParams.TryGetValue(slot, out var p)) return false;
					return p.carSupport != null && p.carSupport.transform.childCount > 0;
				}, 15f, $"junkyard slot {slot} local load");
				if (LoadWait.LastResult == LoadWaitResult.Disconnected) break;

				if (!junkyardParams.TryGetValue(slot, out var junkParam)) continue;
				var jg = Object.FindObjectOfType<JunkyardGenerator>();
				if (jg == null) continue;

				var carIdWithConfig = new CarsIdWithConfig { CarID = data.carId, ConfigVersion = data.version };
				listen = false;
				MainMod.StartCoroutine(jg.CreateCar(slot, junkParam.carSupport, junkParam.transform, carIdWithConfig));
				listen = true;
				MelonLogger.Msg($"[SceneCarSyncLogic] Applied junkyard slot {slot}: {data.carId} v{data.version}");
			}
		}

		processRoutineRunning = false;
	}
}
