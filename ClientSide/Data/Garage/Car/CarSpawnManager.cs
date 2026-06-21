using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CMS;
using CMS.PartModules;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla.Cars;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Car;

public static class CarSpawnManager
{
	public static IEnumerator LoadCar(NewCarData carData, int carLoaderID, int placeNo)
	{
		// Skip only if the exact same car is already tracked; a different car in the same slot
		// means we returned from the salon (or a resync) and must re-send.
		if (ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var existing)
		    && existing.carID == carData.carToLoad)
			yield break;
		ClientData.Instance.loadedCars.Remove(carLoaderID);

		var car = new ModCar(carLoaderID, carData.carToLoad, carData.configVersion, placeNo, carData.customerCar);
		ClientSend.LoadCarPacket(new ModNewCarData(carData, placeNo), carLoaderID);
		
		while (GameData.Instance == null || GameData.Instance.carLoaders == null
		       || !GameData.Instance.carLoaders[carLoaderID].IsCarLoaded())
			yield return YieldInstructions.WaitForEndOfFrame;
		yield return YieldInstructions.WaitForEndOfFrame;
		yield return YieldInstructions.WaitForEndOfFrame;
		
		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID))
		{
			ClientData.Instance.loadedCars.Add(carLoaderID, car);
			MelonCoroutines.Start(PartsReferencer.GetPartReferences(ClientData.Instance.loadedCars[carLoaderID]));
		}
	}

	public static IEnumerator LoadJobCar(string name, int carLoaderID, CarLoader carLoader)
	{
		while (!ClientData.GameReady)
			yield return new WaitForSeconds(0.25f);

		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();

		if (ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var existingJob)
		    && existingJob.carID == name)
			yield break;
		ClientData.Instance.loadedCars.Remove(carLoaderID);
		yield return YieldInstructions.WaitForEndOfFrame;

		while (!carLoader.IsCarLoaded()) yield return YieldInstructions.WaitForEndOfFrame;
		yield return YieldInstructions.WaitForEndOfFrame;
		yield return YieldInstructions.WaitForEndOfFrame;
		
		var car = new ModCar(carLoaderID, name, carLoader.ConfigVersion, carLoader.placeNo, carLoader.customerCar);
		
		if (carLoader.customerCar)
			ClientSend.LoadJobCarPacket(car);

		yield return new WaitForEndOfFrame();
		if (!ClientData.Instance.loadedCars.ContainsKey(carLoaderID))
		{
			ClientData.Instance.loadedCars.Add(carLoaderID, car);
			MelonCoroutines.Start(PartsReferencer.GetPartReferences(ClientData.Instance.loadedCars[carLoaderID]));
			
			while (!ClientData.Instance.loadedCars[carLoaderID].isReady)
				yield return new WaitForSeconds(0.25f);
			yield return new WaitForEndOfFrame();
			carLoader.SaveCarToFile();
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();
			NewCarData carData = GameManager.Instance.GameDataManager.CurrentProfileData.carsInGarage[Helper.GetIndexFromCarLoaderName(carLoader.name)];
			ModNewCarData modCarData = new ModNewCarData(carData, carLoader.placeNo, carLoader.orderConnection);
			
			ClientSend.LoadCarPacket(modCarData, carLoaderID);
		}
	}

	public static IEnumerator LoadCarFromServer(ModNewCarData data, int carLoaderID)
	{
		yield return LoadWait.WaitForClientGameReady();
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		yield return LoadWait.WaitForGameDataReady();
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		yield return new WaitForEndOfFrame();

		var carLoader = GameData.Instance.carLoaders[carLoaderID];
		carLoader.placeNo = data.carPosition;
		carLoader.ConfigVersion = data.configVersion;
		var carData = data.ToGame();

		yield return new WaitForEndOfFrame();
		
		CarSpawnHooks.listenToSimpleLoad = false;
		if (data.jobID != -1)
			carLoader.SetCustomerCar(true, data.jobID);
		MainMod.StartCoroutine(carLoader.LoadCarFromFile(carData));
		var car = new ModCar(carLoaderID, data.carToLoad, data.configVersion);
		ClientData.Instance.loadedCars[carLoaderID] = car;

		yield return LoadWait.WaitForCarLoaded(carLoaderID);
		if (LoadWait.LastResult != LoadWaitResult.Success)
		{
			MelonLogger.Warning($"[CarSpawnManager->LoadCarFromServer] Car load timed out for loader {carLoaderID}. Requesting resync.");
			ClientData.Instance.loadedCars.Remove(carLoaderID);
			ClientSend.ResyncCar(carLoaderID);
			yield break;
		}

		MelonCoroutines.Start(PartsReferencer.GetPartReferences(ClientData.Instance.loadedCars[carLoaderID]));
		MelonLogger.Msg($"[CarSpawnManager->LoadCarFromServer] Loading {data.carToLoad} from server...");
	}
}
