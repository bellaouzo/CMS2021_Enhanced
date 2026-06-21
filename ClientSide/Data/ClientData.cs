using System.Collections;
using System.Collections.Generic;
using CMS21Together.ClientSide.Data.Garage;
using CMS21Together.ClientSide.Data.Garage.Campaign;
using CMS21Together.ClientSide.Data.Garage.Car;
using CMS21Together.ClientSide.Data.Garage.Tools;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ClientSide.Data.Player;
using CMS21Together.ServerSide;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using CMS21Together.Shared.Data.Vanilla.GarageTool;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data;

public class ClientData
{
	public static ClientData Instance;
	public static UserData UserData;
	public static bool GameReady;
	private bool initRoutine;

	public Dictionary<int, UserData> connectedClients = new();
	public Gamemode gamemode;
	public Dictionary<string, GarageUpgrade> garageUpgrades = new();
	public Dictionary<int, ModCar> loadedCars = new();
	public ModEngineStand engineStand;
	public ModEngineStand engineStand2;
	public GameObject playerPrefab;
	public int scrap, money ,exp, level;
	public static void DestroyAllRemotePlayers()
	{
		if (Instance == null) return;

		foreach (var client in Instance.connectedClients.Values)
		{
			if (client == null || client.playerID == UserData.playerID) continue;

			client.isInCar = false;
			client.isCrouching = false;
			client.carLoaderID = -1;
			client.DestroyPlayer();
		}
	}

	public ClientData()
	{
		GameReady = false;
		initRoutine = false;
		GameData.ResetState();
		
		Player.Inventory.Reset();
		CarSpawnHooks.Reset();
		JobManager.Reset();
		Stats.Reset();
		GarageUpgradeHooks.Reset();
		Garage.GarageCustomizationLogic.Reset();
		Garage.DoorSyncLogic.Reset();
		Salon.SalonSyncLogic.Reset();
		Player.CrouchSync.Reset();
		Garage.Tools.ToolsMoveManager.Reset();
		Garage.Tools.CarWashLogic.Reset();
		CarPaintLogic.Reset();
		engineStand = new(null);
		engineStand2 = new(null);
		garageUpgrades = new Dictionary<string, GarageUpgrade>();
	}

	private static float lastCarCheckTime = 0f;
	private static readonly float carCheckInterval = 0.5f; // Check every 0.5 seconds

	public void UpdateClient()
	{
		if (SceneManager.CurrentScene() == GameScene.garage)
		{
			if (GameData.isReady == false && !initRoutine)
				MelonCoroutines.Start(InitializeGameData());
		}

		if (!SceneManager.IsPlayerSyncScene())
			return;

		// In non-garage player-sync scenes (salon, barn, junkyard) the garage-set localPlayer
		// reference is destroyed. Refresh it from the scene's FPSInputController.
		if (SceneManager.CurrentScene() != GameScene.garage
		    && GameData.Instance != null
		    && (GameData.Instance.localPlayer == null || !GameData.Instance.localPlayer.activeInHierarchy))
		{
			var fps = Object.FindObjectOfType<FPSInputController>();
			if (fps != null)
				GameData.Instance.localPlayer = fps.gameObject;
		}

		bool canSync = SceneManager.CurrentScene() == GameScene.garage
			? GameReady
			: GameData.Instance?.localPlayer != null;

		if (!canSync)
			return;

		Movement.SendPosition();
		Movement.CheckForInactivity();
		Rotation.SendRotation();

		if (SceneManager.CurrentScene() == GameScene.garage && Time.time - lastCarCheckTime >= carCheckInterval)
		{
			lastCarCheckTime = Time.time;
			CarEnterExit.CheckCarState();
		}
	}

	private IEnumerator InitializeGameData()
	{
		initRoutine = true;
		bool wasGameReady = GameReady;

		while (SceneManager.CurrentScene() != GameScene.garage)
			yield return new WaitForEndOfFrame();

		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();

		yield return LoadWait.WaitForNotificationReady();
		if (LoadWait.LastResult != LoadWaitResult.Success)
		{
			initRoutine = false;
			yield break;
		}

		yield return GameData.Initialize();
		if (!GameData.isReady)
		{
			MelonLogger.Error("[ClientData->InitializeGameData] GameData initialization failed.");
			initRoutine = false;
			yield break;
		}

		if (!ClientData.GameReady)
		{
			MelonCoroutines.Start(Stats.SendInitialStats());
			MelonCoroutines.Start(GarageUpgradeHooks.SendInitial());
			MelonCoroutines.Start(Garage.GarageCustomizationLogic.SendInitial());
		}

		if (playerPrefab == null)
		{
			LoadPlayerPrefab();
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();
			yield return new WaitForEndOfFrame();

			if (playerPrefab == null)
			{
				MelonLogger.Error("[ClientData->InitializeGameData] Failed to load playerPrefab after multiple attempts. Retrying...");
				LoadPlayerPrefab();
				yield return new WaitForEndOfFrame();
				yield return new WaitForEndOfFrame();
			}
		}

		yield return new WaitForEndOfFrame();
		gamemode = SavesManager.GetGamemodeFromDifficulty(SavesManager.currentSave.Difficulty);

		if (playerPrefab != null)
		{
			GameReady = true;
			initRoutine = false;
			if (!wasGameReady && SavesManager.currentSaveIndex != MainMod.MAX_SAVE_COUNT)
				SavesManager.SaveModSave(SavesManager.currentSaveIndex);
			foreach (var client in connectedClients.Values)
			{
				if (client.scene == UserData.scene)
					client.SpawnPlayer();
			}
			MelonLogger.Msg("Game is ready.");
		}
		else
		{
			MelonLogger.Error("[ClientData->InitializeGameData] Cannot set GameReady: playerPrefab is still null!");
			initRoutine = false;
		}
	}

	public void LoadPlayerPrefab()
	{
		var playerBundle = AssetBundle.LoadFromStream(DataHelper.DeepCopy(DataHelper.LoadContent("CMS21Together.Assets.player.assets")));

		if (playerBundle)
		{
			GameObject player = playerBundle.LoadAsset<GameObject>("playerModel");
			if (player == null)
			{
				MelonLogger.Warning("Impossible de charger l'AssetBundle !");
				return;
			}

			var playerInstance = Object.Instantiate(player);

			Material material;
			Texture baseTexture = playerBundle.LoadAsset<Texture>("tex_base");
			if (baseTexture != null)
			{
				baseTexture.filterMode = FilterMode.Bilinear;
			}
			Texture normalTexture = playerBundle.LoadAsset<Texture>("tex_normal");
			if (normalTexture != null)
			{
				normalTexture.filterMode = FilterMode.Bilinear;
			}

			material = new Material(Shader.Find("HDRP/Unlit"));
			if (baseTexture != null)
				material.mainTexture = baseTexture;
			if (normalTexture != null)
				material.SetTexture("_BumpMap", normalTexture);

			var skinnedMesh = playerInstance.GetComponentInChildren<SkinnedMeshRenderer>();
			if (skinnedMesh != null)
			{
				skinnedMesh.material = material;
			}

			playerInstance.transform.localScale = new Vector3(0.095f, 0.095f, 0.095f);
			playerInstance.transform.position = new Vector3(0, -10, 0);
			playerInstance.transform.rotation = new Quaternion(0, 180, 0, 0);

			playerPrefab = playerInstance;
			Object.DontDestroyOnLoad(playerInstance);

			playerBundle.Unload(false);
			MelonLogger.Msg("[ClientData->LoadPlayerPrefab] Loaded player prefab successfully!");
		}
	}

	public IEnumerator SpawnPlayer(int _money, int _exp, int _level, Vector3 pos, Quaternion rot, int skillPoints, Dictionary<string,
		List<bool>> skills, long startItemUid, int missionFinished, bool missionInProgress)
	{
		while (!GameReady)
			yield return new WaitForSeconds(0.1f);
		
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();

		UIDManager.LastUID = startItemUid;

		MelonLogger.Msg("\nReceived Player info! : \n"
		                + $"MissionFinished : {missionFinished}\n"
		                + $"StoryInProgress : {missionInProgress}\n"
		                + $"StartItemUID : {startItemUid}\n"
		                + $"Exp : {_exp}\n"
		                + $"Money : {_money}\n"
		                + $"Level : {_level}\n"
		                + $"Exp : {_exp}\n"
		                + $"SkillPoints : {skillPoints}\n");
		if (GameManager.Instance.GameDataManager.CurrentProfileData.Difficulty != DifficultyLevel.Sandbox)
		{
			GlobalData.PlayerLevel = _level;
			UIManager.Get().StatsContainer.CurrentLevel = _level;
			UIManager.Get().StatsContainer.Refresh(StatType.Level, true);
			GlobalData.PlayerExp = _exp;
			UIManager.Get().StatsContainer.Refresh(StatType.Experience, true);
			GlobalData.PlayerMoney = _money;
			UIManager.Get().StatsContainer.Refresh(StatType.Money, true);
			
			Singleton<GameManager>.Instance.UpgradeSystem.availablePoints = skillPoints;
			if (skills != null)
			{
				GameData.Instance.upgradeTools.upgradeSystem.LockUpgradesForPoints();
				foreach (KeyValuePair<string, List<bool>> skill in skills)
				{
					int lvl = 0;
					foreach (bool unlocked in skill.Value)
					{
						if(unlocked)
							GameData.Instance.upgradeTools.upgradeSystem.UnlockUpgrade(skill.Key, lvl);
						lvl++;
					}
				}
			}
		}

		GlobalData.MissionsFinished = missionFinished;
		GlobalData.IsStoryMissionInProgress = missionInProgress;
		
		if (pos != Vector3.zero)
			GameData.Instance.localPlayer.transform.position = pos;
		if (rot != Quaternion.identity)
			GameData.Instance.localPlayer.transform.rotation = rot;

		while (SceneManager.CurrentScene() != GameScene.garage)
			yield return new WaitForSeconds(0.5f);
		while (!NotificationCenter.IsGameReady)
			yield return new WaitForSeconds(0.25f);
		while (!GameData.isReady)
			yield return new WaitForSeconds(0.5f);
		
		ClientSend.ResyncEngineStandPacket(true);
	}
}