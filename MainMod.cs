using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data;
using CMS21Together.ClientSide.Data.NewUI;
using CMS21Together.ClientSide.Data.Player;
using CMS21Together.ServerSide;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using Il2CppSystem.Collections;
using MelonLoader;
using Steamworks;
using Steamworks.Data;
using UnhollowerRuntimeLib;
using UnityEngine;

// ReSharper disable All

namespace CMS21Together
{
	public class MainMod : MelonMod
	{
		public const int MAX_SAVE_COUNT = 22;
		public const int MAX_PLAYER = 4;
		public const int PORT = 7777;
		public const string ASSEMBLY_MOD_VERSION = "0.4.16" + ASSEMBLY_HOTFIX_VERSION;
		public const string ASSEMBLY_HOTFIX_VERSION = "hf3";
		public const string MOD_VERSION = "Together " + ASSEMBLY_MOD_VERSION + ASSEMBLY_HOTFIX_VERSION;
		public bool isModInitialized;
		
		public static bool isClosing;
		private static string _pendingInviteServerID;

		public override void OnLateInitializeMelon()
		{
			Client.Instance = new Client();
			Server.Instance = new Server();
			ContentManager.Instance = new ContentManager();

			ClientData.UserData = TogetherModManager.LoadUserData();
			if (ApiCalls.useSteam)
			{
				SteamClient.Init(1190000);
				SteamNetworkingUtils.InitRelayNetworkAccess();
				SteamFriends.OnGameLobbyJoinRequested += OnSteamLobbyJoinRequested;
			}
			isModInitialized = true;
			LoggerInstance.Msg("Together Mod Initialized!");
		}

		public override void OnSceneWasLoaded(int buildindex, string sceneName)
		{
			if (!isModInitialized) return;
			
			if (sceneName == "Menu")
			{
				SavesManager.Initialize();
				ContentManager.Instance.Initialize();

				ClientData.UserData.scene = SceneManager.UpdateScene(sceneName);
				Application.runInBackground = false;
			}
			UICore.InitializeUI(sceneName);
			if (Client.Instance.isConnected)
			{
				ClientData.UserData.UpdateScene(sceneName);
				
				if (SceneManager.CurrentScene() == GameScene.garage && ClientData.Instance.playerPrefab == null)
					ClientData.Instance.LoadPlayerPrefab();

			}
		}

		public override void OnUpdate()
		{
			if (!isModInitialized) return;

			if (ApiCalls.useSteam)
				SteamClient.RunCallbacks();

			if (!string.IsNullOrEmpty(_pendingInviteServerID) && UICore.MP_Lobby != null && !Client.Instance.isConnected)
			{
				string id = _pendingInviteServerID;
				_pendingInviteServerID = null;
				ClientData.UserData.selectedNetworkType = NetworkType.Steam;
				UIActions.StartClient(SteamClient.Name, id);
			}

			if (!Client.Instance.isConnected) return;

			if (SceneManager.CurrentScene() == GameScene.garage)
				ClientData.Instance.UpdateClient();

			if (ApiCalls.useSteam)
			{
				if (Client.Instance.steam != null) Client.Instance.steam.Receive();
				if (Server.Instance.steam != null) Server.Instance.steam.Receive();
			}

			ThreadManager.UpdateThread();
		}

		private static async void OnSteamLobbyJoinRequested(Lobby lobby, SteamId friendId)
		{
			if (Client.Instance.isConnected) return;

			Lobby? joined = await SteamMatchmaking.JoinLobbyAsync(lobby.Id);
			if (!joined.HasValue)
			{
				MelonLogger.Error("[MainMod] Failed to join Steam lobby to retrieve server info.");
				return;
			}

			string serverID = SteamLobby.GetServerID(joined.Value);
			joined.Value.Leave();

			if (string.IsNullOrEmpty(serverID))
			{
				MelonLogger.Error("[MainMod] Steam lobby accepted but serverID is missing.");
				return;
			}

			_pendingInviteServerID = serverID;
		}


		public static void StartCoroutine(IEnumerator routine)
		{
			GameManager.Instance.StartCoroutine(routine);
		}

		public override void OnLateUpdate()
		{
			if (!isModInitialized)
			{
				return;
			}
		}
		
		public override void OnInitializeMelon()
		{
			ClassInjector.RegisterTypeInIl2Cpp<InfoBillboard>();
		}

		public override void OnApplicationQuit()
		{
			isClosing = true;
			TogetherModManager.SavePreferences();
			if (Server.Instance.isRunning)
			{
				MelonCoroutines.Start(Server.Instance.CloseServer());
				float deadline = Time.realtimeSinceStartup + 3f;
				while (!Server.CloseServerComplete && Time.realtimeSinceStartup < deadline)
					System.Threading.Thread.Sleep(50);
			}
		}
	}
}