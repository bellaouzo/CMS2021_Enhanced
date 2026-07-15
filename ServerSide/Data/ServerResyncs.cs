using System;
using System.Collections.Generic;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using CMS21Together.Shared.Data.Vanilla.Cars;
using CMS21Together.Shared.Data.Vanilla.GarageTool;
using MelonLoader;

namespace CMS21Together.ServerSide.Data;

public static class ServerResyncs
{
	public static void ResyncCar(int playerID, int carLoaderID)
	{
		if (!ServerData.Instance.CarSpawnDatas.TryGetValue(carLoaderID, out ModNewCarData carToResync)
		    || carToResync == null)
		{
			MelonLogger.Warning($"[ServerResyncs->ResyncCar] No spawn data for loader {carLoaderID}.");
			return;
		}

		ServerData.Instance.CarPartInfo.TryGetValue(carLoaderID, out ModCarInfo carInfo);

		MelonLogger.Msg($"Sent a resync car from: {carLoaderID}");
		
		ServerSend.LoadCarPacket(playerID, carToResync, carLoaderID, true);

		if (carInfo == null)
		{
			MelonLogger.Msg("[ServerResyncs->ResyncCar] Sent spawn only (no part info).");
			return;
		}

		foreach (KeyValuePair<int, ModCarPart> partsReference in carInfo.BodyPartsReferences)
		{
			ServerSend.BodyPartPacket(playerID, partsReference.Value, carLoaderID, true);
		}
		
		foreach (KeyValuePair<int,Dictionary<int,ModPartScript>> partsReference in carInfo.OtherPartsReferences)
		{
			foreach (KeyValuePair<int,ModPartScript> modPartScript in partsReference.Value)
			{
				ServerSend.PartScriptPacket(playerID, modPartScript.Value, carLoaderID, true);
			}
		}
		
		foreach (KeyValuePair<int, ModPartScript> partsReference in carInfo.DriveshaftPartsReferences)
		{
			ServerSend.PartScriptPacket(playerID, partsReference.Value, carLoaderID, true);
		}
		
		foreach (KeyValuePair<int, ModPartScript> partsReference in carInfo.EnginePartsReferences)
		{
			ServerSend.PartScriptPacket(playerID, partsReference.Value, carLoaderID, true);
		}
		
		foreach (KeyValuePair<int,Dictionary<int,ModPartScript>> partsReference in carInfo.SuspensionPartsReferences)
		{
			foreach (KeyValuePair<int,ModPartScript> modPartScript in partsReference.Value)
			{
				ServerSend.PartScriptPacket(playerID, modPartScript.Value, carLoaderID, true);
			}
		}
		MelonLogger.Msg("[ServerResyncs->ResyncCar] Resent car info to client!");
	}

	public static void ResyncAllCars(int playerID)
	{
		foreach (var kvp in ServerData.Instance.CarSpawnDatas)
			ResyncCar(playerID, kvp.Key);

		MelonLogger.Msg($"[ServerResyncs] Sent full garage car catalog ({ServerData.Instance.CarSpawnDatas.Count} cars).");
	}
	
	public static void ResyncEngineStand(int fromClient, bool alt)
	{
		MelonLogger.Msg($"Client asked for es resync!");
		if (alt)
		{
			if (ServerData.Instance.engineStand2 != null && ServerData.Instance.engineStand2.engineGroupItem != null)
			{
				ServerSend.EngineStandSetGroupPacket(fromClient, ServerData.Instance.engineStand2.engineGroupItem,  ServerData.Instance.engineStand2.position, true, true);
				foreach (KeyValuePair<int,ModPartScript> part in ServerData.Instance.engineStand2.parts)
				{
					ServerSend.PartScriptPacket(fromClient, part.Value, -2, true);
					MelonLogger.Msg($"Sent Engine Stand part {part.Value.id}!");
				}
				MelonLogger.Msg($"Sent Engine Stand Resync!");
			}
		}
		else
		{
			if (ServerData.Instance.engineStand != null && ServerData.Instance.engineStand.engineGroupItem != null)
			{
				ServerSend.EngineStandSetGroupPacket(fromClient, ServerData.Instance.engineStand.engineGroupItem, ServerData.Instance.engineStand.position, false, true);
				foreach (KeyValuePair<int, ModPartScript> part in ServerData.Instance.engineStand.parts)
				{
					ServerSend.PartScriptPacket(fromClient, part.Value, -1, true);
				}
				MelonLogger.Msg($"Sent Engine Stand Resync!");
			}
		}
		
	}

	public static void ResyncTools(int fromClient)
	{
		foreach (KeyValuePair<ModIOSpecialType, ModCarPlace> tool in ServerData.Instance.toolsPosition)
		{
			ServerSend.ToolsMovePacket(fromClient, tool.Key, tool.Value, false, true);
		}
	}
	
	public static void ResyncPark(int fromClient)
	{
		foreach (KeyValuePair<int, ModNewCarData> car in ServerData.Instance.CarOnPark)
		{
			ServerSend.AddCarToParkPacket(fromClient, car.Value, car.Key, true);
		}
	}

	public static void ResyncUpgrade(int fromClient)
	{
		foreach (KeyValuePair<string,GarageUpgrade> upgrade in ServerData.Instance.garageUpgrades)
		{
			ServerSend.GarageUpgradePacket(fromClient, upgrade.Value, true);
		}
	}

	public static void ResyncGarageLook(int fromClient)
	{
		foreach (var kvp in ServerData.Instance.garageLook)
			ServerSend.GarageCustomizationPacket(fromClient, kvp.Key, kvp.Value, resync: true);

		MelonLogger.Msg("[ServerResyncs] Sent garage look resync.");
	}

	public static void ResyncDoors(int fromClient)
	{
		foreach (var kvp in ServerData.Instance.doorStates)
			ServerSend.DoorStatePacket(fromClient, kvp.Value, resync: true);

		MelonLogger.Msg("[ServerResyncs] Sent door state resync.");
	}

	public static void ResyncSalon(int fromClient)
	{
		if (ServerData.Instance.salonCar != null && !string.IsNullOrEmpty(ServerData.Instance.salonCar.carId))
			ServerSend.SalonCarPacket(fromClient, ServerData.Instance.salonCar, resync: true);

		foreach (var kvp in ServerData.Instance.salonCatalog)
			ServerSend.SalonCarPacket(fromClient, kvp.Value, resync: true);

		foreach (int slot in ServerData.Instance.salonPurchasedSlots)
		{
			ServerSend.SalonCarPacket(fromClient,
				new ModSalonCar(string.Empty, 0, slot, null, purchased: true),
				resync: true);
		}

		MelonLogger.Msg($"[ServerResyncs] Sent salon resync ({ServerData.Instance.salonCatalog.Count} cars, {ServerData.Instance.salonPurchasedSlots.Count} purchased).");
	}

	public static void ResyncWheelBalancer(int fromClient)
	{
		var balancer = ServerData.Instance.wheelBalancer;
		if (!balancer.isMounted || balancer.groupItem == null)
			ServerSend.WheelBalancerPacket(fromClient, ModWheelBalancerActionType.remove, resync: true);
		else if (balancer.additionalState)
			ServerSend.WheelBalancerPacket(fromClient, ModWheelBalancerActionType.start, balancer.groupItem, resync: true);
		else
			ServerSend.WheelBalancerPacket(fromClient, ModWheelBalancerActionType.setGroup, balancer.groupItem, resync: true);

		MelonLogger.Msg("[ServerResyncs] Sent wheel balancer resync.");
	}

	public static void ResyncSkills(int fromClient)
	{
		foreach (var kvp in ServerData.Instance.sharedSkills)
			ServerSend.SkillChangePacket(fromClient, kvp.Key, kvp.Value, resync: true);

		MelonLogger.Msg("[ServerResyncs] Sent skills resync.");
	}

	public static void ResyncSceneCars(int fromClient, SceneCarType sceneType)
	{
		if (sceneType == SceneCarType.Barn && ServerData.Instance.barnLayoutSeed.HasValue)
			ServerSend.SceneLayoutSeedPacket(fromClient, SceneCarType.Barn, ServerData.Instance.barnLayoutSeed.Value, resync: true);
		else if (sceneType == SceneCarType.Junkyard && ServerData.Instance.junkyardLayoutSeed.HasValue)
			ServerSend.SceneLayoutSeedPacket(fromClient, SceneCarType.Junkyard, ServerData.Instance.junkyardLayoutSeed.Value, resync: true);

		// Tell peers which slots were already bought so they don't respawn them.
		var purchased = sceneType == SceneCarType.Barn ? ServerData.Instance.barnPurchasedSlots
			: sceneType == SceneCarType.Junkyard ? ServerData.Instance.junkyardPurchasedSlots
			: null;
		if (purchased != null)
		{
			foreach (int slot in purchased)
			{
				ServerSend.SceneCarPacket(fromClient, new ModSceneCar(sceneType, slot, string.Empty, 0)
				{
					purchased = true,
				}, resync: true);
			}
		}

		var catalog = sceneType switch
		{
			SceneCarType.Auction => ServerData.Instance.auctionCatalog,
			SceneCarType.Barn    => ServerData.Instance.barnCatalog,
			_                    => ServerData.Instance.junkyardCatalog,
		};
		foreach (var kvp in catalog)
			ServerSend.SceneCarPacket(fromClient, kvp.Value, resync: true);

		ServerSend.SceneCarsReadyPacket(fromClient, sceneType, catalog.Count, resync: true);
		MelonLogger.Msg($"[ServerResyncs] Sent {sceneType} catalog resync ({catalog.Count} entries).");
	}
}