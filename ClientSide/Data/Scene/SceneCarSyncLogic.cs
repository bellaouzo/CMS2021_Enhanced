using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CMS.Containers;
using CMS.SceneLoaders;
using CMS.UI.Logic.Auction;
using CMS.UI.Windows;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data;
using CMS21Together.ClientSide.Data.Garage.Car;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ServerSide;
using CMS21Together.ServerSide.Data;
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

	// Authoritative host catalogs (survive until FullReset)
	private static readonly Dictionary<int, ModSceneCar> hostBarnCatalog = new();
	private static readonly Dictionary<int, ModSceneCar> hostJunkyardCatalog = new();
	private static readonly Dictionary<int, ModSceneCar> hostAuctionNormal = new();
	private static readonly Dictionary<int, ModSceneCar> hostAuctionSalvage = new();

	private static bool auctionRoutineRunning;
	private static bool auctionCatalogReady;
	private static bool applyingAuctionSelect;

	internal static readonly Dictionary<int, (GameObject carSupport, Transform transform)> barnParams = new();
	internal static readonly Dictionary<int, (GameObject carSupport, Transform transform)> junkyardParams = new();
	// CarLoader is often NOT a child of carSupport — keep an explicit slot→loader map.
	private static readonly Dictionary<int, CarLoader> barnSlotLoaders = new();
	private static readonly Dictionary<int, CarLoader> junkyardSlotLoaders = new();
	private static readonly HashSet<int> purchasedBarnSlots = new();
	private static readonly HashSet<int> purchasedJunkyardSlots = new();

	private static int? barnLayoutSeed;
	private static int? junkyardLayoutSeed;
	private static bool barnCatalogReady;
	private static bool junkyardCatalogReady;
	private static bool barnGenerateDeferred;
	private static bool junkyardGenerateDeferred;
	private static int syncGeneration;
	private static int hostBarnSlotsSent;
	private static int hostJunkyardSlotsSent;

	public static void Reset()
	{
		// Soft reset: cancel in-flight applies, keep catalogs/seeds for re-entry.
		syncGeneration++;
		listen = true;
		pendingScene.Clear();
		processRoutineRunning = false;
		auctionRoutineRunning = false;
		applyingAuctionSelect = false;
		barnParams.Clear();
		junkyardParams.Clear();
		barnSlotLoaders.Clear();
		junkyardSlotLoaders.Clear();
		barnGenerateDeferred = false;
		junkyardGenerateDeferred = false;
		hostBarnSlotsSent = 0;
		hostJunkyardSlotsSent = 0;
	}

	public static void FullReset()
	{
		Reset();
		hostBarnCatalog.Clear();
		hostJunkyardCatalog.Clear();
		hostAuctionNormal.Clear();
		hostAuctionSalvage.Clear();
		purchasedBarnSlots.Clear();
		purchasedJunkyardSlots.Clear();
		auctionCatalogReady = false;
		barnLayoutSeed = null;
		junkyardLayoutSeed = null;
		barnCatalogReady = false;
		junkyardCatalogReady = false;
	}

	public static void ReceiveLayoutSeed(SceneCarType sceneType, int seed)
	{
		if (sceneType == SceneCarType.Barn)
			barnLayoutSeed = seed;
		else if (sceneType == SceneCarType.Junkyard)
			junkyardLayoutSeed = seed;
		MelonLogger.Msg($"[SceneCarSyncLogic] Received {sceneType} layout seed: {seed}");
	}

	public static void ReceiveCarsReady(SceneCarType sceneType, int count)
	{
		if (sceneType == SceneCarType.Barn) barnCatalogReady = true;
		else if (sceneType == SceneCarType.Junkyard) junkyardCatalogReady = true;
		else if (sceneType == SceneCarType.Auction) auctionCatalogReady = true;
		MelonLogger.Msg($"[SceneCarSyncLogic] {sceneType} catalog ready ({count} entries).");
	}

	public static void QueueSceneCar(ModSceneCar data)
	{
		if (data == null) return;

		if (data.sceneType == SceneCarType.Auction)
		{
			bool isSalvage = data.slotIndex >= 100;
			int realIndex = isSalvage ? data.slotIndex - 100 : data.slotIndex;
			if (isSalvage) hostAuctionSalvage[realIndex] = data;
			else hostAuctionNormal[realIndex] = data;

			if (!auctionRoutineRunning)
				MelonCoroutines.Start(InjectAuctionCatalog());
			return;
		}

		if (data.purchased)
		{
			if (data.sceneType == SceneCarType.Barn)
			{
				purchasedBarnSlots.Add(data.slotIndex);
				hostBarnCatalog.Remove(data.slotIndex);
			}
			else if (data.sceneType == SceneCarType.Junkyard)
			{
				purchasedJunkyardSlots.Add(data.slotIndex);
				hostJunkyardCatalog.Remove(data.slotIndex);
			}
			pendingScene.Enqueue(data);
			if (!processRoutineRunning)
				MelonCoroutines.Start(ProcessSceneQueue());
			return;
		}

		if (data.sceneType == SceneCarType.Barn)
		{
			if (purchasedBarnSlots.Contains(data.slotIndex)) return;
			MergeCatalog(hostBarnCatalog, data);
		}
		else if (data.sceneType == SceneCarType.Junkyard)
		{
			if (purchasedJunkyardSlots.Contains(data.slotIndex)) return;
			MergeCatalog(hostJunkyardCatalog, data);
		}

		pendingScene.Enqueue(data);
		if (!processRoutineRunning)
			MelonCoroutines.Start(ProcessSceneQueue());
	}

	private static void MergeCatalog(Dictionary<int, ModSceneCar> catalog, ModSceneCar data)
	{
		if (catalog.TryGetValue(data.slotIndex, out var existing) && existing != null)
		{
			if (data.color != null) existing.color = data.color;
			if (data.bodyParts != null) existing.bodyParts = data.bodyParts;
			if (data.partScripts != null) existing.partScripts = data.partScripts;
			if (data.position != null) existing.position = data.position;
			if (data.rotation != null) existing.rotation = data.rotation;
			if (!string.IsNullOrEmpty(data.carId))
			{
				existing.carId = data.carId;
				existing.version = data.version;
			}
			catalog[data.slotIndex] = existing;
		}
		else
			catalog[data.slotIndex] = data;
	}

	public static void ApplySceneCarPart(ModSceneCarPart data)
	{
		if (!listen || string.IsNullOrEmpty(data.partName)) return;
		var loader = FindSlotLoader(data.sceneType, data.slotIndex);
		if (loader == null) return;

		CarSyncHooks.listen = false;
		listen = false;
		try
		{
			if (data.hasSwitched)
			{
				var part = loader.GetCarPart(data.partName);
				if (part != null)
				{
					// Absolute state — skip if already matching (prevents invert from duplicate/toggle).
					if (part.Switched != data.switched)
						loader.SwitchCarPart(part, false, data.switched);
				}
				else
					loader.SwitchCarPart(data.partName);
			}
			else
				loader.SwitchCarPart(data.partName);
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[SceneCarSyncLogic] ApplySceneCarPart failed: {ex.Message}");
		}
		listen = true;
		CarSyncHooks.listen = true;
	}

	public static void ApplyAuctionSelect(ModAuctionSelect data)
	{
		if (data == null || applyingAuctionSelect) return;
		MelonCoroutines.Start(ApplyAuctionSelectCoroutine(data));
	}

	public static bool TryGetSceneCarSlot(CarLoader loader, out SceneCarType sceneType, out int slotIndex)
	{
		if (loader == null)
		{
			sceneType = default;
			slotIndex = -1;
			return false;
		}

		foreach (var kvp in barnSlotLoaders)
		{
			if (kvp.Value == loader)
			{
				sceneType = SceneCarType.Barn;
				slotIndex = kvp.Key;
				return true;
			}
		}
		foreach (var kvp in junkyardSlotLoaders)
		{
			if (kvp.Value == loader)
			{
				sceneType = SceneCarType.Junkyard;
				slotIndex = kvp.Key;
				return true;
			}
		}

		// Proximity / hierarchy fallback (also registers into slot maps).
		if (TryResolveSlotByProximity(SceneCarType.Barn, loader, out slotIndex))
		{
			sceneType = SceneCarType.Barn;
			return true;
		}
		if (TryResolveSlotByProximity(SceneCarType.Junkyard, loader, out slotIndex))
		{
			sceneType = SceneCarType.Junkyard;
			return true;
		}

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

		// Auction loaded car (single active loader).
		var am = UnityEngine.Object.FindObjectOfType<AuctionManager>();
		if (am != null)
		{
			var auctionLoader = am.CarLoader ?? am.playerCarLoader;
			if (auctionLoader != null && (auctionLoader == loader
			    || loader.transform.IsChildOf(auctionLoader.transform)
			    || auctionLoader.transform.IsChildOf(loader.transform)))
			{
				sceneType = SceneCarType.Auction;
				slotIndex = 0;
				return true;
			}
		}

		sceneType = default;
		slotIndex = -1;
		return false;
	}

	// --- Auction ---

	[HarmonyPatch(typeof(AuctionManager), "GenerateCars", typeof(AuctionType))]
	[HarmonyPrefix]
	public static bool GenerateCarsClientPrefixHook(AuctionType auctionType, ref Il2CppSystem.Collections.Generic.List<AuctionCarData> __result)
	{
		if (!Client.Instance.isConnected || !listen) return true;
		if (Server.Instance.isRunning) return true;

		bool isSalvage = auctionType == AuctionType.Salvage;
		var pending = isSalvage ? hostAuctionSalvage : hostAuctionNormal;

		if (pending.Count > 0)
		{
			__result = BuildAuctionList(pending);
			MelonLogger.Msg($"[SceneCarSyncLogic] Replaced {(isSalvage ? "salvage" : "normal")} auction generation with {__result.Count} server cars.");
			return false;
		}

		// Never generate a local random list — wait for host catalog injection.
		__result = new Il2CppSystem.Collections.Generic.List<AuctionCarData>();
		if (!auctionRoutineRunning)
			MelonCoroutines.Start(InjectAuctionCatalog());
		MelonLogger.Msg("[SceneCarSyncLogic] Blocked local auction generation; waiting for host catalog.");
		return false;
	}

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
				rating = car.Rating,
				seed = car.Seed,
				value = car.Value,
				startingPrice = car.StartingPrice,
				sold = car.Sold,
			};
			if (auctionType == AuctionType.Salvage) hostAuctionSalvage[i] = data;
			else hostAuctionNormal[i] = data;
			ClientSend.SceneCarPacket(data);
		}
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent {__result.Count} auction cars (type={auctionType}).");

		int total = hostAuctionNormal.Count + hostAuctionSalvage.Count;
		ClientSend.SceneCarsReady(SceneCarType.Auction, total);
	}

	[HarmonyPatch(typeof(AuctionManager), nameof(AuctionManager.LoadCar), typeof(AuctionCarData), typeof(AuctionType))]
	[HarmonyPostfix]
	public static void AuctionLoadCarHook(AuctionCarData auctionCarData, AuctionType auctionType)
	{
		if (!Client.Instance.isConnected || !listen || applyingAuctionSelect) return;
		if (auctionCarData == null) return;

		int slotIndex = FindAuctionSlotIndex(auctionCarData, auctionType);
		ClientSend.AuctionSelectPacket(new ModAuctionSelect(
			(int)auctionType, slotIndex, auctionCarData.Car, auctionCarData.Version, auctionCarData.Seed,
			auctionCarData.Rating, auctionCarData.Value, auctionCarData.StartingPrice));
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent auction LoadCar select: {auctionCarData.Car}");
	}

	// --- Barn / Junkyard ---

	[HarmonyPatch(typeof(ShedManager), nameof(ShedManager.Generate))]
	[HarmonyPrefix]
	public static bool ShedGeneratePrefix(ShedManager __instance)
	{
		if (!Client.Instance.isConnected || !listen) return true;

		if (Server.Instance.isRunning)
		{
			int seed = ServerData.Instance.barnLayoutSeed ?? Environment.TickCount;
			barnLayoutSeed = seed;
			ServerData.Instance.barnLayoutSeed = seed;
			UnityEngine.Random.InitState(seed);
			ClientSend.SceneLayoutSeedPacket(SceneCarType.Barn, seed);
			hostBarnSlotsSent = 0;
			barnCatalogReady = ServerData.Instance.barnCatalog.Count > 0;
			MelonLogger.Msg($"[SceneCarSyncLogic] Host barn layout seed: {seed} (catalog={ServerData.Instance.barnCatalog.Count})");
			return true;
		}

		if (barnLayoutSeed.HasValue && barnCatalogReady)
		{
			UnityEngine.Random.InitState(barnLayoutSeed.Value);
			return true;
		}

		if (!barnGenerateDeferred)
		{
			barnGenerateDeferred = true;
			MelonCoroutines.Start(DeferredGenerateBarn(__instance));
		}
		return false;
	}

	[HarmonyPatch(typeof(JunkyardGenerator), nameof(JunkyardGenerator.Generate))]
	[HarmonyPrefix]
	public static bool JunkyardGeneratePrefix(JunkyardGenerator __instance)
	{
		if (!Client.Instance.isConnected || !listen) return true;

		if (Server.Instance.isRunning)
		{
			int seed = ServerData.Instance.junkyardLayoutSeed ?? (Environment.TickCount ^ 0x5A5A5A5A);
			junkyardLayoutSeed = seed;
			ServerData.Instance.junkyardLayoutSeed = seed;
			UnityEngine.Random.InitState(seed);
			// Force every spawn pad so host/client slot counts match under the same seed.
			try { __instance.CarsPercentage = new Vector2(1f, 1f); } catch { }
			ClientSend.SceneLayoutSeedPacket(SceneCarType.Junkyard, seed);
			hostJunkyardSlotsSent = 0;
			junkyardCatalogReady = ServerData.Instance.junkyardCatalog.Count > 0;
			MelonLogger.Msg($"[SceneCarSyncLogic] Host junkyard layout seed: {seed} (catalog={ServerData.Instance.junkyardCatalog.Count})");
			return true;
		}

		if (junkyardLayoutSeed.HasValue && junkyardCatalogReady)
		{
			UnityEngine.Random.InitState(junkyardLayoutSeed.Value);
			try { __instance.CarsPercentage = new Vector2(1f, 1f); } catch { }
			MelonCoroutines.Start(EnsureMissingJunkyardSlots(syncGeneration));
			return true;
		}

		if (!junkyardGenerateDeferred)
		{
			junkyardGenerateDeferred = true;
			MelonCoroutines.Start(DeferredGenerateJunkyard(__instance));
		}
		return false;
	}

	[HarmonyPatch(typeof(ShedManager), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPrefix]
	public static void ShedCreateCarPrefix(int index, GameObject carSupport, Transform t, CarsIdWithConfig carIdWithConfig)
	{
		if (!Client.Instance.isConnected || !listen) return;
		barnParams[index] = (carSupport, t);
		TryInjectHostCar(SceneCarType.Barn, index, carIdWithConfig);
	}

	[HarmonyPatch(typeof(ShedManager), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPostfix]
	public static void ShedCreateCarPostfix(int index, CarsIdWithConfig carIdWithConfig)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (!Server.Instance.isRunning) return;
		ClientSend.SceneCarPacket(new ModSceneCar(SceneCarType.Barn, index, carIdWithConfig.CarID, carIdWithConfig.ConfigVersion));
		hostBarnSlotsSent++;
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent barn slot {index}: {carIdWithConfig.CarID} v{carIdWithConfig.ConfigVersion}");
		MelonCoroutines.Start(SendSceneDetailsWhenReady(SceneCarType.Barn, index, carIdWithConfig));
	}

	[HarmonyPatch(typeof(JunkyardGenerator), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPrefix]
	public static void JunkyardCreateCarPrefix(int index, GameObject carSupport, Transform t, CarsIdWithConfig randomCar)
	{
		if (!Client.Instance.isConnected || !listen) return;
		junkyardParams[index] = (carSupport, t);
		TryInjectHostCar(SceneCarType.Junkyard, index, randomCar);
	}

	[HarmonyPatch(typeof(JunkyardGenerator), "CreateCar", typeof(int), typeof(GameObject), typeof(Transform), typeof(CarsIdWithConfig))]
	[HarmonyPostfix]
	public static void JunkyardCreateCarPostfix(int index, CarsIdWithConfig randomCar)
	{
		if (!Client.Instance.isConnected || !listen) return;
		if (!Server.Instance.isRunning) return;
		ClientSend.SceneCarPacket(new ModSceneCar(SceneCarType.Junkyard, index, randomCar.CarID, randomCar.ConfigVersion));
		hostJunkyardSlotsSent++;
		MelonLogger.Msg($"[SceneCarSyncLogic] Sent junkyard slot {index}: {randomCar.CarID} v{randomCar.ConfigVersion}");
		MelonCoroutines.Start(SendSceneDetailsWhenReady(SceneCarType.Junkyard, index, randomCar));
	}

	[HarmonyPatch(typeof(ShedManager), nameof(ShedManager.Generate))]
	[HarmonyPostfix]
	public static void ShedGeneratePostfix()
	{
		if (!Client.Instance.isConnected || !listen || !Server.Instance.isRunning) return;
		MelonCoroutines.Start(SendBarnReadyWhenSlotsDone());
	}

	[HarmonyPatch(typeof(JunkyardGenerator), nameof(JunkyardGenerator.Generate))]
	[HarmonyPostfix]
	public static void JunkyardGeneratePostfix()
	{
		if (!Client.Instance.isConnected || !listen || !Server.Instance.isRunning) return;
		MelonCoroutines.Start(SendJunkyardReadyWhenSlotsDone());
	}

	private static void TryInjectHostCar(SceneCarType sceneType, int index, CarsIdWithConfig cfg)
	{
		if (cfg == null) return;

		ModSceneCar data = null;
		if (Server.Instance.isRunning)
		{
			var serverCat = sceneType == SceneCarType.Barn
				? ServerData.Instance.barnCatalog
				: ServerData.Instance.junkyardCatalog;
			serverCat.TryGetValue(index, out data);
		}
		else
		{
			var local = sceneType == SceneCarType.Barn ? hostBarnCatalog : hostJunkyardCatalog;
			local.TryGetValue(index, out data);
		}

		if (data == null || string.IsNullOrEmpty(data.carId)) return;
		cfg.CarID = data.carId;
		cfg.ConfigVersion = data.version;
		MelonLogger.Msg($"[SceneCarSyncLogic] Injected host {sceneType} slot {index}: {data.carId} v{data.version}");
	}

	private static IEnumerator DeferredGenerateBarn(ShedManager shed)
	{
		int generation = syncGeneration;
		yield return LoadWait.WaitForPredicate(
			() => generation != syncGeneration || (barnLayoutSeed.HasValue && barnCatalogReady),
			60f, "barn seed+catalog");
		barnGenerateDeferred = false;
		if (generation != syncGeneration || !barnLayoutSeed.HasValue || shed == null) yield break;

		UnityEngine.Random.InitState(barnLayoutSeed.Value);
		MainMod.StartCoroutine(shed.Generate());
	}

	private static IEnumerator DeferredGenerateJunkyard(JunkyardGenerator junkyard)
	{
		int generation = syncGeneration;
		yield return LoadWait.WaitForPredicate(
			() => generation != syncGeneration || (junkyardLayoutSeed.HasValue && junkyardCatalogReady),
			60f, "junkyard seed+catalog");
		junkyardGenerateDeferred = false;
		if (generation != syncGeneration || !junkyardLayoutSeed.HasValue || junkyard == null) yield break;

		UnityEngine.Random.InitState(junkyardLayoutSeed.Value);
		try { junkyard.CarsPercentage = new Vector2(1f, 1f); } catch { }
		MainMod.StartCoroutine(junkyard.Generate());
		MelonCoroutines.Start(EnsureMissingJunkyardSlots(generation));
	}

	private static IEnumerator SendBarnReadyWhenSlotsDone()
	{
		int generation = syncGeneration;
		yield return new WaitForSeconds(2f);
		float waited = 0f;
		while (waited < 25f && generation == syncGeneration)
		{
			if (barnParams.Count > 0 && hostBarnSlotsSent >= barnParams.Count)
				break;
			waited += 0.5f;
			yield return new WaitForSeconds(0.5f);
		}
		if (generation != syncGeneration) yield break;
		barnCatalogReady = true;
		ClientSend.SceneCarsReady(SceneCarType.Barn, hostBarnSlotsSent);
	}

	private static IEnumerator SendJunkyardReadyWhenSlotsDone()
	{
		int generation = syncGeneration;
		yield return new WaitForSeconds(2f);
		float waited = 0f;
		while (waited < 25f && generation == syncGeneration)
		{
			if (junkyardParams.Count > 0 && hostJunkyardSlotsSent >= junkyardParams.Count)
				break;
			waited += 0.5f;
			yield return new WaitForSeconds(0.5f);
		}
		if (generation != syncGeneration) yield break;
		junkyardCatalogReady = true;
		ClientSend.SceneCarsReady(SceneCarType.Junkyard, hostJunkyardSlotsSent);
	}

	private static IEnumerator EnsureMissingJunkyardSlots(int generation)
	{
		// Wait for local Generate CreateCar calls to finish (CreateCar is slow).
		yield return new WaitForSeconds(12f);
		if (generation != syncGeneration) yield break;

		var jg = UnityEngine.Object.FindObjectOfType<JunkyardGenerator>();
		if (jg == null) yield break;

		foreach (var kvp in hostJunkyardCatalog.ToList())
		{
			if (generation != syncGeneration) yield break;
			int slot = kvp.Key;
			var data = kvp.Value;
			if (data == null || string.IsNullOrEmpty(data.carId)) continue;
			if (FindSlotLoader(SceneCarType.Junkyard, slot) != null) continue;

			MelonLogger.Msg($"[SceneCarSyncLogic] Spawning missing junkyard slot {slot}: {data.carId}");
			yield return SpawnMissingJunkyardCar(jg, slot, data);
		}
	}

	private static IEnumerator SpawnMissingJunkyardCar(JunkyardGenerator jg, int slot, ModSceneCar data)
	{
		Transform spawnT = null;
		if (jg.CarSpawnPositions != null && slot >= 0 && slot < jg.CarSpawnPositions.Length)
			spawnT = jg.CarSpawnPositions[slot];

		GameObject carSupport = null;
		// Prefer cloning an existing support so CreateCar has the expected hierarchy.
		foreach (var p in junkyardParams.Values)
		{
			if (p.carSupport != null)
			{
				Vector3 pos = data.position != null ? data.position.toVector3()
					: (spawnT != null ? spawnT.position : p.carSupport.transform.position);
				Quaternion rot = data.rotation != null ? data.rotation.toQuaternion()
					: (spawnT != null ? spawnT.rotation : p.carSupport.transform.rotation);
				carSupport = UnityEngine.Object.Instantiate(p.carSupport, pos, rot);
				spawnT = carSupport.transform;
				break;
			}
		}

		if (carSupport == null)
		{
			if (spawnT == null)
			{
				var go = new GameObject($"SyncedJunkyardSlot_{slot}");
				if (data.position != null) go.transform.position = data.position.toVector3();
				if (data.rotation != null) go.transform.rotation = data.rotation.toQuaternion();
				spawnT = go.transform;
			}
			carSupport = spawnT.gameObject;
		}

		var cfg = new CarsIdWithConfig { CarID = data.carId, ConfigVersion = data.version };
		junkyardParams[slot] = (carSupport, spawnT);
		listen = false;
		MainMod.StartCoroutine(jg.CreateCar(slot, carSupport, spawnT, cfg));
		listen = true;

		yield return LoadWait.WaitForPredicate(() =>
		{
			var loader = FindSlotLoader(SceneCarType.Junkyard, slot);
			return loader != null && loader.IsCarLoaded();
		}, 30f, $"junkyard missing slot {slot}");

		var loaded = FindSlotLoader(SceneCarType.Junkyard, slot);
		if (loaded == null) yield break;
		ApplyPose(loaded, data);
		if (data.color != null) CarAppearanceHelper.ApplyColor(loaded, data.color);
		if (data.bodyParts != null) ApplyBodyStates(loaded, data.bodyParts);
		if (data.partScripts != null) ApplyPartScriptStates(loaded, data.partScripts);
		MelonLogger.Msg($"[SceneCarSyncLogic] Spawned missing junkyard slot {slot}.");
	}

	private static Dictionary<int, CarLoader> SlotLoaderMap(SceneCarType sceneType)
		=> sceneType == SceneCarType.Barn ? barnSlotLoaders : junkyardSlotLoaders;

	private static Dictionary<int, (GameObject carSupport, Transform transform)> ParamMap(SceneCarType sceneType)
		=> sceneType == SceneCarType.Barn ? barnParams : junkyardParams;

	private static void RegisterSlotLoader(SceneCarType sceneType, int index, CarLoader loader)
	{
		if (loader == null || index < 0) return;
		if (sceneType == SceneCarType.Barn) barnSlotLoaders[index] = loader;
		else if (sceneType == SceneCarType.Junkyard) junkyardSlotLoaders[index] = loader;
	}

	private static bool IsLoaderAlive(CarLoader loader)
	{
		try { return loader != null && loader.gameObject != null; }
		catch { return false; }
	}

	private static bool TryResolveSlotByProximity(SceneCarType sceneType, CarLoader loader, out int slotIndex)
	{
		slotIndex = -1;
		if (loader == null) return false;
		var paramDict = ParamMap(sceneType);
		if (paramDict.Count == 0) return false;

		float best = float.MaxValue;
		int bestSlot = -1;
		Vector3 loaderPos = loader.transform.position;

		foreach (var kvp in paramDict)
		{
			var p = kvp.Value;
			Transform anchor = p.transform != null ? p.transform
				: (p.carSupport != null ? p.carSupport.transform : null);
			if (anchor == null) continue;

			// Hierarchy match
			if ((p.carSupport != null && (loader.transform == p.carSupport.transform
			                             || loader.transform.IsChildOf(p.carSupport.transform)
			                             || p.carSupport.transform.IsChildOf(loader.transform)))
			    || (p.transform != null && (loader.transform == p.transform
			                               || loader.transform.IsChildOf(p.transform)
			                               || p.transform.IsChildOf(loader.transform))))
			{
				slotIndex = kvp.Key;
				RegisterSlotLoader(sceneType, slotIndex, loader);
				return true;
			}

			float dist = Vector3.Distance(loaderPos, anchor.position);
			if (dist < best)
			{
				best = dist;
				bestSlot = kvp.Key;
			}
		}

		// Barn/junkyard cars sit on/near their spawn anchors; 8m covers layout drift.
		if (bestSlot >= 0 && best < 8f)
		{
			slotIndex = bestSlot;
			RegisterSlotLoader(sceneType, slotIndex, loader);
			return true;
		}
		return false;
	}

	private static CarLoader FindNearestLoaderForSlot(SceneCarType sceneType, int index)
	{
		var paramDict = ParamMap(sceneType);
		if (!paramDict.TryGetValue(index, out var p)) return null;

		Transform anchor = p.transform != null ? p.transform
			: (p.carSupport != null ? p.carSupport.transform : null);

		CarLoader best = null;
		float bestDist = float.MaxValue;
		CarLoader[] all;
		try { all = UnityEngine.Object.FindObjectsOfType<CarLoader>(); }
		catch { return null; }
		if (all == null) return null;

		foreach (var loader in all)
		{
			if (!IsLoaderAlive(loader)) continue;

			if (p.carSupport != null)
			{
				try
				{
					var under = p.carSupport.GetComponentInChildren<CarLoader>(true);
					if (under == loader) { RegisterSlotLoader(sceneType, index, loader); return loader; }
				}
				catch { /* ignore */ }
			}

			if (anchor == null) continue;
			float dist = Vector3.Distance(loader.transform.position, anchor.position);
			if (dist < bestDist)
			{
				bestDist = dist;
				best = loader;
			}
		}

		if (best != null && bestDist < 8f)
		{
			RegisterSlotLoader(sceneType, index, best);
			return best;
		}
		return null;
	}

	private static CarLoader FindSlotLoader(SceneCarType sceneType, int index, string expectedCarId = null)
	{
		if (sceneType == SceneCarType.Salon)
		{
			var sm = SalonManager.instance;
			if (sm?.carLoaders == null || index >= sm.carLoaders.Length) return null;
			return sm.carLoaders[index];
		}

		if (sceneType == SceneCarType.Auction)
		{
			var am = UnityEngine.Object.FindObjectOfType<AuctionManager>();
			return am?.CarLoader ?? am?.playerCarLoader;
		}

		var map = SlotLoaderMap(sceneType);
		if (map.TryGetValue(index, out var cached) && IsLoaderAlive(cached))
		{
			if (expectedCarId == null || string.IsNullOrEmpty(expectedCarId)
			    || string.IsNullOrEmpty(cached.carToLoad)
			    || cached.carToLoad == expectedCarId)
				return cached;
		}
		else if (cached != null)
			map.Remove(index);

		CarLoader found = null;
		var paramDict = ParamMap(sceneType);
		if (paramDict.TryGetValue(index, out var p))
		{
			try
			{
				if (p.carSupport != null)
					found = p.carSupport.GetComponentInChildren<CarLoader>(true);
				if (found == null && p.transform != null)
					found = p.transform.GetComponentInChildren<CarLoader>(true);
				if (found == null && p.transform != null && p.transform.parent != null)
					found = p.transform.parent.GetComponentInChildren<CarLoader>(true);
			}
			catch { found = null; }
		}

		if (found == null)
			found = FindNearestLoaderForSlot(sceneType, index);

		if (found != null)
			RegisterSlotLoader(sceneType, index, found);

		if (found != null && expectedCarId != null && !string.IsNullOrEmpty(expectedCarId)
		    && !string.IsNullOrEmpty(found.carToLoad) && found.carToLoad != expectedCarId)
			return null;

		return found;
	}

	private static bool IsSceneActive(SceneCarType sceneType)
	{
		return sceneType switch
		{
			SceneCarType.Barn => SceneManager.CurrentScene() == GameScene.barn,
			SceneCarType.Junkyard => SceneManager.CurrentScene() == GameScene.junkyard,
			_ => false,
		};
	}

	private static IEnumerator SendSceneDetailsWhenReady(SceneCarType sceneType, int index, CarsIdWithConfig config)
	{
		int generation = syncGeneration;
		float waited = 0f;
		const float timeout = 45f;
		const float poll = 0.25f;
		string expectedId = config?.CarID;

		while (waited < timeout)
		{
			if (generation != syncGeneration) yield break;
			// Don't abort just because CurrentScene lags — only abort if we left for a different playable scene.
			if (!IsSceneActive(sceneType) && waited > 2f
			    && SceneManager.CurrentScene() != GameScene.unknow
			    && SceneManager.CurrentScene() != GameScene.barn
			    && SceneManager.CurrentScene() != GameScene.junkyard)
				yield break;

			var loader = FindSlotLoader(sceneType, index);
			bool ready = loader != null && loader.IsCarLoaded()
			             && (string.IsNullOrEmpty(expectedId)
			                 || string.IsNullOrEmpty(loader.carToLoad)
			                 || loader.carToLoad == expectedId);

			if (ready)
			{
				// Let body/PartScripts finish mounting before snapshot.
				yield return new WaitForSeconds(0.75f);
				if (generation != syncGeneration) yield break;
				loader = FindSlotLoader(sceneType, index);
				if (loader == null || !loader.IsCarLoaded()) continue;

				ModColor color = null;
				List<ModSceneCarBodyState> bodyParts = null;
				List<ModSceneCarPartScriptState> partScripts = null;
				Vector3Serializable pos = null;
				QuaternionSerializable rot = null;
				try { color = CarAppearanceHelper.CaptureColor(loader); }
				catch (Exception ex) { MelonLogger.Warning($"[SceneCarSyncLogic] Capture color failed slot {index}: {ex.Message}"); }
				try { bodyParts = CaptureBodyStates(loader); }
				catch (Exception ex) { MelonLogger.Warning($"[SceneCarSyncLogic] Capture body failed slot {index}: {ex.Message}"); }
				try { partScripts = CapturePartScriptStates(loader); }
				catch (Exception ex) { MelonLogger.Warning($"[SceneCarSyncLogic] Capture scripts failed slot {index}: {ex.Message}"); }
				try
				{
					pos = new Vector3Serializable(loader.transform.position);
					rot = new QuaternionSerializable(loader.transform.rotation);
				}
				catch { /* pose optional */ }

				if (generation != syncGeneration) yield break;

				string carId = !string.IsNullOrEmpty(loader.carToLoad) ? loader.carToLoad : expectedId;
				ClientSend.SceneCarPacket(new ModSceneCar(sceneType, index, carId, config?.ConfigVersion ?? loader.ConfigVersion, color)
				{
					bodyParts = bodyParts,
					partScripts = partScripts,
					position = pos,
					rotation = rot,
				});
				MelonLogger.Msg($"[SceneCarSyncLogic] Sent {sceneType} slot {index} details (body={bodyParts?.Count ?? 0}, scripts={partScripts?.Count ?? 0}).");
				yield break;
			}

			waited += poll;
			yield return new WaitForSeconds(poll);
		}

		MelonLogger.Warning($"[SceneCarSyncLogic] Timed out sending {sceneType} slot {index} details.");
	}

	private static List<ModSceneCarBodyState> CaptureBodyStates(CarLoader loader)
	{
		var result = new List<ModSceneCarBodyState>();
		if (loader?.carParts == null) return result;

		foreach (var part in loader.carParts)
		{
			if (part == null || string.IsNullOrEmpty(part.name)) continue;
			result.Add(new ModSceneCarBodyState(
				part.name,
				part.Condition,
				part.StructureCondition,
				part.ConditionPaint,
				part.Unmounted,
				part.Switched,
				part.Dent,
				part.Dust));
		}
		return result;
	}

	private static List<ModSceneCarPartScriptState> CapturePartScriptStates(CarLoader loader)
	{
		var result = new List<ModSceneCarPartScriptState>();
		if (loader == null) return result;

		PartScript[] scripts;
		try { scripts = loader.GetComponentsInChildren<PartScript>(true); }
		catch { return result; }
		if (scripts == null) return result;

		foreach (var ps in scripts)
		{
			if (ps == null || string.IsNullOrEmpty(ps.id)) continue;
			// Prefer missing/damaged, but always include wheel/tire-like ids so peers match.
			bool interesting = ps.IsUnmounted || ps.Condition < 0.999f || ps.Dust > 0.001f;
			string id = ps.id;
			if (!interesting)
			{
				string lower = id.ToLowerInvariant();
				if (!lower.Contains("wheel") && !lower.Contains("tire") && !lower.Contains("rim")
				    && !lower.Contains("tyre"))
					continue;
			}
			result.Add(new ModSceneCarPartScriptState(ps.id, ps.IsUnmounted, ps.Condition, ps.Dust));
		}
		return result;
	}

	private static void ApplyBodyStates(CarLoader loader, List<ModSceneCarBodyState> bodyParts)
	{
		if (loader == null || bodyParts == null || bodyParts.Count == 0) return;

		foreach (var state in bodyParts)
		{
			if (state == null || string.IsNullOrEmpty(state.name)) continue;
			CarPart part;
			try { part = loader.GetCarPart(state.name); }
			catch { continue; }
			if (part == null) continue;

			try
			{
				loader.SetCondition(part, state.condition);
				loader.SetDent(part, state.dent);
				loader.EnableDust(part, state.dust);
				part.StructureCondition = state.conditionStructure;
				part.ConditionPaint = state.conditionPaint;

				if (!part.Unmounted && state.unmounted)
					loader.TakeOffCarPartFromSave(part.name);
				else if (part.Unmounted && !state.unmounted)
					loader.TakeOnCarPartFromSave(part.name);

				if (part.Switched != state.switched)
					loader.SwitchCarPart(part, false, state.switched);
			}
			catch (Exception ex)
			{
				MelonLogger.Warning($"[SceneCarSyncLogic] Apply body '{state.name}' failed: {ex.Message}");
			}
		}
	}

	private static void ApplyPartScriptStates(CarLoader loader, List<ModSceneCarPartScriptState> partScripts)
	{
		if (loader == null || partScripts == null || partScripts.Count == 0) return;

		PartScript[] scripts;
		try { scripts = loader.GetComponentsInChildren<PartScript>(true); }
		catch { return; }
		if (scripts == null) return;

		var byId = new Dictionary<string, PartScript>();
		foreach (var ps in scripts)
		{
			if (ps == null || string.IsNullOrEmpty(ps.id)) continue;
			byId[ps.id] = ps;
		}

		foreach (var state in partScripts)
		{
			if (state == null || string.IsNullOrEmpty(state.id)) continue;
			if (!byId.TryGetValue(state.id, out var ps) || ps == null) continue;

			try
			{
				ps.Condition = state.condition;
				ps.Dust = state.dust;
				if (state.unmounted && !ps.IsUnmounted)
					ps.HideBySavegame(false, loader);
				else if (!state.unmounted && ps.IsUnmounted)
					ps.ShowBySaveGame();
			}
			catch (Exception ex)
			{
				MelonLogger.Warning($"[SceneCarSyncLogic] Apply PartScript '{state.id}' failed: {ex.Message}");
			}
		}
	}

	private static void ApplyPose(CarLoader loader, ModSceneCar data)
	{
		if (loader == null || data?.position == null) return;
		try
		{
			loader.transform.position = data.position.toVector3();
			if (data.rotation != null)
				loader.transform.rotation = data.rotation.toQuaternion();
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[SceneCarSyncLogic] Apply pose failed: {ex.Message}");
		}
	}

	private static Il2CppSystem.Collections.Generic.List<AuctionCarData> BuildAuctionList(Dictionary<int, ModSceneCar> pending)
	{
		var list = new Il2CppSystem.Collections.Generic.List<AuctionCarData>();
		if (pending.Count == 0) return list;
		int max = pending.Keys.Max();
		for (int i = 0; i <= max; i++)
		{
			if (!pending.TryGetValue(i, out var d) || d == null) continue;
			list.Add(new AuctionCarData
			{
				Car = d.carId,
				Version = d.version,
				Rating = d.rating,
				Seed = d.seed,
				Value = d.value,
				StartingPrice = d.startingPrice,
				Sold = d.sold,
			});
		}
		return list;
	}

	private static void RefreshAuctionUI(Il2CppSystem.Collections.Generic.List<AuctionCarData> list, AuctionType type)
	{
		try
		{
			var selects = UnityEngine.Object.FindObjectsOfType<AuctionSelectCar>();
			foreach (var select in selects)
			{
				if (select == null) continue;
				if (select.auctionType != type) continue;
				select.SetCars(list);
				try { select.DrawPage(); } catch { /* older UI states */ }
				MelonLogger.Msg($"[SceneCarSyncLogic] Refreshed AuctionSelectCar UI ({list.Count} cars, type={type}).");
			}

			var window = UnityEngine.Object.FindObjectOfType<AuctionWindow>();
			if (window?.auctionSelectCar != null && window.auctionSelectCar.auctionType == type)
			{
				window.auctionSelectCar.SetCars(list);
				try { window.auctionSelectCar.DrawPage(); } catch { }
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[SceneCarSyncLogic] Auction UI refresh failed: {ex.Message}");
		}
	}

	private static int FindAuctionSlotIndex(AuctionCarData data, AuctionType type)
	{
		var dict = type == AuctionType.Salvage ? hostAuctionSalvage : hostAuctionNormal;
		foreach (var kvp in dict)
		{
			var d = kvp.Value;
			if (d != null && d.carId == data.Car && d.version == data.Version && d.seed == data.Seed)
				return kvp.Key;
		}
		return -1;
	}

	private static IEnumerator ApplyAuctionSelectCoroutine(ModAuctionSelect data)
	{
		applyingAuctionSelect = true;
		listen = false;
		try
		{
			yield return LoadWait.WaitForScene(GameScene.auctions);
			if (LoadWait.LastResult != LoadWaitResult.Success) yield break;

			yield return LoadWait.WaitForComponent<AuctionManager>(20f);
			if (LoadWait.LastResult != LoadWaitResult.Success) yield break;

			var am = UnityEngine.Object.FindObjectOfType<AuctionManager>();
			if (am == null) yield break;

			foreach (var select in UnityEngine.Object.FindObjectsOfType<AuctionSelectCar>())
			{
				try { select.Hide(true); } catch { }
			}
			var window = UnityEngine.Object.FindObjectOfType<AuctionWindow>();
			if (window?.auctionSelectCar != null)
			{
				try { window.auctionSelectCar.Hide(true); } catch { }
			}

			yield return new WaitForEndOfFrame();

			var carData = new AuctionCarData
			{
				Car = data.carId,
				Version = data.version,
				Seed = data.seed,
				Rating = data.rating,
				Value = data.value,
				StartingPrice = data.startingPrice,
			};
			var auctionType = data.auctionType == (int)AuctionType.Salvage ? AuctionType.Salvage : AuctionType.Normal;
			am.LoadCar(carData, auctionType);
			MelonLogger.Msg($"[SceneCarSyncLogic] Applied remote auction select: {data.carId}");
		}
		finally
		{
			listen = true;
			applyingAuctionSelect = false;
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
			auctionCatalogReady || hostAuctionNormal.Count > 0 || hostAuctionSalvage.Count > 0,
			60f, "host auction catalog");
		if (LoadWait.LastResult == LoadWaitResult.Disconnected)
		{
			auctionRoutineRunning = false;
			yield break;
		}

		// Allow remaining packets to arrive after first car / ready flag.
		yield return new WaitForSeconds(0.75f);

		var am2 = UnityEngine.Object.FindObjectOfType<AuctionManager>();
		if (am2 == null) { auctionRoutineRunning = false; yield break; }

		if (hostAuctionNormal.Count > 0)
		{
			var list = BuildAuctionList(hostAuctionNormal);
			listen = false;
			am2.normalCars = list;
			am2.normalCarsGenerated = true;
			listen = true;
			RefreshAuctionUI(list, AuctionType.Normal);
			MelonLogger.Msg($"[SceneCarSyncLogic] Injected {list.Count} normal auction cars.");
		}

		if (hostAuctionSalvage.Count > 0)
		{
			var list = BuildAuctionList(hostAuctionSalvage);
			listen = false;
			am2.salvageCars = list;
			am2.salvageCarsGenerated = true;
			listen = true;
			RefreshAuctionUI(list, AuctionType.Salvage);
			MelonLogger.Msg($"[SceneCarSyncLogic] Injected {list.Count} salvage auction cars.");
		}

		// Keep refreshing briefly in case the select UI opens after inject.
		float refreshFor = 0f;
		while (refreshFor < 8f && (hostAuctionNormal.Count > 0 || hostAuctionSalvage.Count > 0))
		{
			if (hostAuctionNormal.Count > 0)
				RefreshAuctionUI(BuildAuctionList(hostAuctionNormal), AuctionType.Normal);
			if (hostAuctionSalvage.Count > 0)
				RefreshAuctionUI(BuildAuctionList(hostAuctionSalvage), AuctionType.Salvage);
			refreshFor += 1f;
			yield return new WaitForSeconds(1f);
		}

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

	private static IEnumerator ApplySceneSlot(ModSceneCar data, int generation, GameScene scene)
	{
		yield return LoadWait.WaitForScene(scene);
		if (LoadWait.LastResult != LoadWaitResult.Success || generation != syncGeneration) yield break;

		int slot = data.slotIndex;

		if (data.purchased)
		{
			yield return LoadWait.WaitForPredicate(() =>
			{
				if (generation != syncGeneration) return true;
				return FindSlotLoader(data.sceneType, slot) != null
				       || ParamMap(data.sceneType).ContainsKey(slot);
			}, 20f, $"{data.sceneType} slot {slot} purchase unload");
			if (generation != syncGeneration) yield break;

			var purchasedLoader = FindSlotLoader(data.sceneType, slot);
			if (purchasedLoader != null)
			{
				listen = false;
				try
				{
					if (purchasedLoader.IsCarLoaded() || !string.IsNullOrEmpty(purchasedLoader.carToLoad))
						purchasedLoader.DeleteCar();
					purchasedLoader.gameObject.SetActive(false);
				}
				catch (Exception ex)
				{
					MelonLogger.Warning($"[SceneCarSyncLogic] Purchase unload failed slot {slot}: {ex.Message}");
				}
				listen = true;
			}
			SlotLoaderMap(data.sceneType).Remove(slot);
			ParamMap(data.sceneType).Remove(slot);
			MelonLogger.Msg($"[SceneCarSyncLogic] Removed purchased {data.sceneType} slot {slot}.");
			yield break;
		}

		// Prefer merged catalog entry (may include later color/damage/pose updates).
		var catalog = data.sceneType == SceneCarType.Barn ? hostBarnCatalog : hostJunkyardCatalog;
		if (catalog.TryGetValue(data.slotIndex, out var merged) && merged != null)
			data = merged;

		// Wait until CreateCar Prefix registered the spawn anchor OR a loader appears nearby.
		yield return LoadWait.WaitForPredicate(() =>
		{
			if (generation != syncGeneration) return true;
			return ParamMap(data.sceneType).ContainsKey(slot)
			       || FindSlotLoader(data.sceneType, slot) != null;
		}, 60f, $"{data.sceneType} slot {slot} params");
		if (generation != syncGeneration || LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		yield return LoadWait.WaitForPredicate(() =>
		{
			if (generation != syncGeneration) return true;
			var loader = FindSlotLoader(data.sceneType, slot);
			return loader != null && loader.IsCarLoaded();
		}, 45f, $"{data.sceneType} slot {slot} local load");
		if (generation != syncGeneration || LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		yield return LoadWait.WaitForNotificationReady(60f);
		if (generation != syncGeneration || LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		var existing = FindSlotLoader(data.sceneType, slot);
		if (existing == null)
		{
			MelonLogger.Warning($"[SceneCarSyncLogic] No CarLoader found for {data.sceneType} slot {slot}.");
			yield break;
		}

		bool needsReload = existing.carToLoad != data.carId || existing.ConfigVersion != data.version;
		if (needsReload && !string.IsNullOrEmpty(data.carId))
		{
			listen = false;
			existing.ConfigVersion = data.version;
			MainMod.StartCoroutine(existing.LoadCar(data.carId));
			listen = true;

			yield return LoadWait.WaitForPredicate(() =>
			{
				if (generation != syncGeneration) return true;
				var loader = FindSlotLoader(data.sceneType, slot);
				return loader != null && loader.IsCarLoaded() && loader.carToLoad == data.carId;
			}, 30f, $"{data.sceneType} slot {slot} host car load");
		}

		if (generation != syncGeneration) yield break;
		existing = FindSlotLoader(data.sceneType, slot);
		if (existing == null) yield break;

		ApplyPose(existing, data);

		if (data.color != null)
			CarAppearanceHelper.ApplyColor(existing, data.color);

		if (data.bodyParts != null && data.bodyParts.Count > 0)
		{
			ApplyBodyStates(existing, data.bodyParts);
			yield return new WaitForEndOfFrame();
			ApplyBodyStates(existing, data.bodyParts);
		}

		if (data.partScripts != null && data.partScripts.Count > 0)
		{
			ApplyPartScriptStates(existing, data.partScripts);
			yield return new WaitForEndOfFrame();
			ApplyPartScriptStates(existing, data.partScripts);
		}

		if (generation == syncGeneration)
			MelonLogger.Msg($"[SceneCarSyncLogic] Applied {data.sceneType} slot {slot}: {data.carId} v{data.version} (body={data.bodyParts?.Count ?? 0}, scripts={data.partScripts?.Count ?? 0})");
	}

	[HarmonyPatch(typeof(GameScript), nameof(GameScript.BuyCar), typeof(CarLoader), typeof(int))]
	[HarmonyPostfix]
	public static void SceneBuyCarHook(CarLoader carLoader)
	{
		if (!Client.Instance.isConnected || !listen || carLoader == null) return;
		var scene = SceneManager.CurrentScene();
		if (scene != GameScene.barn && scene != GameScene.junkyard) return;
		if (!TryGetSceneCarSlot(carLoader, out var sceneType, out var slotIndex)) return;

		if (sceneType == SceneCarType.Barn) purchasedBarnSlots.Add(slotIndex);
		else if (sceneType == SceneCarType.Junkyard) purchasedJunkyardSlots.Add(slotIndex);

		var catalog = sceneType == SceneCarType.Barn ? hostBarnCatalog : hostJunkyardCatalog;
		catalog.Remove(slotIndex);

		ClientSend.SceneCarPacket(new ModSceneCar(sceneType, slotIndex, carLoader.carToLoad, carLoader.ConfigVersion)
		{
			purchased = true,
		});
		MelonLogger.Msg($"[SceneCarSyncLogic] Purchased {sceneType} slot {slotIndex} ({carLoader.carToLoad}), broadcasting removal.");
	}

	[HarmonyPatch(typeof(CarLoader), nameof(CarLoader.LoadCar), typeof(string))]
	[HarmonyPostfix]
	public static void SceneLoadCarRegisterHook(string carToLoad, CarLoader __instance)
	{
		if (!Client.Instance.isConnected || __instance == null) return;
		var scene = SceneManager.CurrentScene();
		if (scene == GameScene.barn)
			TryResolveSlotByProximity(SceneCarType.Barn, __instance, out _);
		else if (scene == GameScene.junkyard)
			TryResolveSlotByProximity(SceneCarType.Junkyard, __instance, out _);
	}
}
