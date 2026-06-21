using System;
using System.Collections;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data;
using CMS21Together.Shared.Data;
using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CMS21Together.Shared;

public enum LoadWaitResult
{
	Success,
	Timeout,
	Disconnected
}

public static class LoadWait
{
	public const float PollInterval = 0.25f;

	public static LoadWaitResult LastResult { get; private set; }

	private static bool IsConnected()
	{
		return Client.Instance != null && Client.Instance.isConnected;
	}

	public static IEnumerator WaitForConnected()
	{
		while (IsConnected())
			yield return new WaitForSeconds(PollInterval);

		LastResult = LoadWaitResult.Disconnected;
	}

	public static IEnumerator WaitForClientGameReady(float timeout = 60f)
	{
		float waited = 0f;
		while (!ClientData.GameReady)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning("[LoadWait] Timed out waiting for ClientData.GameReady.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}

		LastResult = LoadWaitResult.Success;
	}

	public static IEnumerator WaitForGameDataReady(float timeout = 60f)
	{
		float waited = 0f;
		while (!GameData.isReady)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning("[LoadWait] Timed out waiting for GameData.isReady.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}

		LastResult = LoadWaitResult.Success;
	}

	public static IEnumerator WaitForNotificationReady(float timeout = 60f)
	{
		float waited = 0f;
		while (!NotificationCenter.IsGameReady)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning("[LoadWait] Timed out waiting for NotificationCenter.IsGameReady.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}

		LastResult = LoadWaitResult.Success;
	}

	public static IEnumerator WaitForScene(GameScene scene, float timeout = 30f)
	{
		float waited = 0f;
		while (SceneManager.CurrentScene() != scene)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning($"[LoadWait] Timed out waiting for scene {scene}.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}

		LastResult = LoadWaitResult.Success;
	}

	public static IEnumerator WaitForComponent<T>(float timeout = 30f, string label = null) where T : Object
	{
		float waited = 0f;
		while (Object.FindObjectOfType<T>() == null)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning($"[LoadWait] Timed out waiting for component {label ?? typeof(T).Name}.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}

		LastResult = LoadWaitResult.Success;
	}

	public static IEnumerator WaitForPredicate(Func<bool> predicate, float timeout, string label)
	{
		float waited = 0f;
		while (!predicate())
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning($"[LoadWait] Timed out waiting for {label}.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}

		LastResult = LoadWaitResult.Success;
	}

	public static IEnumerator WaitForCarLoaded(int carLoaderID, float timeout = 60f)
	{
		float waited = 0f;
		while (true)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning($"[LoadWait] Timed out waiting for car load on loader {carLoaderID}.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			if (GameData.Instance?.carLoaders != null
			    && carLoaderID >= 0
			    && carLoaderID < GameData.Instance.carLoaders.Length
			    && GameData.Instance.carLoaders[carLoaderID] != null
			    && GameData.Instance.carLoaders[carLoaderID].IsCarLoaded())
			{
				LastResult = LoadWaitResult.Success;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}
	}

	public static IEnumerator WaitForCarReady(int carLoaderID, float timeout = 30f)
	{
		float waited = 0f;
		while (true)
		{
			if (!IsConnected())
			{
				LastResult = LoadWaitResult.Disconnected;
				yield break;
			}

			if (waited >= timeout)
			{
				MelonLogger.Warning($"[LoadWait] Timed out waiting for ModCar.isReady on loader {carLoaderID}.");
				LastResult = LoadWaitResult.Timeout;
				yield break;
			}

			if (ClientData.Instance?.loadedCars != null
			    && ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var car)
			    && car != null
			    && car.isReady)
			{
				LastResult = LoadWaitResult.Success;
				yield break;
			}

			waited += PollInterval;
			yield return new WaitForSeconds(PollInterval);
		}
	}
}
