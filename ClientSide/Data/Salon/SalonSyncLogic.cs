using System.Collections;
using CMS.Salon;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data.Handle;
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

	private static ModSalonCar pendingSalonCar;
	private static bool hasPendingSalonCar;
	private static bool processRoutineRunning;

	public static void Reset()
	{
		listen = true;
		hasPendingSalonCar = false;
		pendingSalonCar = null;
		processRoutineRunning = false;
	}

	public static void QueueSalonCar(ModSalonCar data)
	{
		pendingSalonCar = data;
		hasPendingSalonCar = true;
		if (!processRoutineRunning)
			MelonCoroutines.Start(ProcessSalonQueue());
	}

	[HarmonyPatch(typeof(Configurator), nameof(Configurator.LoadCar))]
	[HarmonyPostfix]
	public static void LoadCarHook(string carToLoad, int version)
	{
		if (!Client.Instance.isConnected || !listen)
		{
			listen = true;
			return;
		}

		if (SceneManager.CurrentScene() != GameScene.auto_salon)
			return;

		ClientSend.SalonCarPacket(carToLoad, version);
	}

	private static IEnumerator ProcessSalonQueue()
	{
		processRoutineRunning = true;

		while (hasPendingSalonCar)
		{
			yield return LoadWait.WaitForScene(GameScene.auto_salon);
			if (LoadWait.LastResult != LoadWaitResult.Success)
				break;

			yield return LoadWait.WaitForComponent<Configurator>(30f);
			if (LoadWait.LastResult != LoadWaitResult.Success)
				break;

			yield return new WaitForEndOfFrame();

			if (!hasPendingSalonCar)
				break;

			var configurator = Object.FindObjectOfType<Configurator>();
			if (configurator == null)
			{
				MelonLogger.Warning("[SalonSyncLogic] Configurator not found in Auto Salon.");
				break;
			}

			var data = pendingSalonCar;
			hasPendingSalonCar = false;

			listen = false;
			configurator.LoadCar(data.carId, data.version);
			listen = true;
		}

		processRoutineRunning = false;
	}
}
