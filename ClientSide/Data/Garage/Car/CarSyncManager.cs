using System.Collections;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Car;

public static class CarSyncManager
{
	public static IEnumerator ChangePosition(int carLoaderID, int placeNo)
	{
		while (!ClientData.GameReady)
			yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();

		if (GameData.Instance?.carLoaders == null) yield break;
		if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length) yield break;
		var loader = GameData.Instance.carLoaders[carLoaderID];
		if (loader == null) yield break;

		if (ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var car))
		{
			if (placeNo != car.carPosition)
			{
				MelonLogger.Msg($"Change {car.carID} position to {placeNo}.");
				car.carPosition = placeNo;
				CarSyncHooks.listenToChangePosition = false;
				loader.ChangePosition(placeNo);
			}
		}
	}

	public static IEnumerator DeleteCar(int carLoaderID)
	{
		while (!ClientData.GameReady)
			yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();

		if (ClientData.Instance.loadedCars.ContainsKey(carLoaderID))
			ClientData.Instance.loadedCars.Remove(carLoaderID);

		if (GameData.Instance?.carLoaders == null) yield break;
		if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length) yield break;
		var delLoader = GameData.Instance.carLoaders[carLoaderID];
		if (delLoader == null) yield break;

		CarSpawnHooks.listenToDelete = false;
		delLoader.DeleteCar();
	}
}