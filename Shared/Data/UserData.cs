using System;
using CMS21Together.ClientSide.Data;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ClientSide.Data.Player;
using MelonLoader;
using Newtonsoft.Json;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CMS21Together.Shared.Data;

[Serializable]
public class UserData
{
	public string username;
	public string ip;
	public string lobbyID;
	public string playerGUID;

	public NetworkType selectedNetworkType = NetworkType.TCP;

	[JsonIgnore] public int playerID;
	[JsonIgnore] public bool isReady;

	[JsonIgnore] public GameScene scene;
	[JsonIgnore] public Vector3Serializable position = new(Vector3.zero);
	[JsonIgnore] public QuaternionSerializable rotation = new(Quaternion.identity);
	[JsonIgnore] public int playerLevel;
	[JsonIgnore] public int playerExp;
	[JsonIgnore] public int playerSkillPoints;
	[JsonIgnore] [NonSerialized] public Vector3Serializable lastPosition;
	[JsonIgnore] [NonSerialized] public Animator userAnimator;

	[JsonIgnore] public bool isInCar = false;
	[JsonIgnore] public bool isCrouching;
	[JsonIgnore] public int carLoaderID = -1; // -1 means not in any car

	[JsonIgnore] [NonSerialized] public GameObject userObject;
	[JsonIgnore] [NonSerialized] public float lastUpdateTime;
	[JsonIgnore] [NonSerialized] public float baseScaleY = 0.095f;

	public UserData()
	{
		username = "player";
		ip = "127.0.0.1";
		lobbyID = "";
		playerID = 1;
		playerGUID = Guid.NewGuid().ToString();
		selectedNetworkType = NetworkType.TCP;
	}

	public UserData(string _username, int _playerID, string playerGuid)
	{
		username = _username;
		playerID = _playerID;
		playerGUID = playerGuid;
	}

	public void UpdateScene(string sceneName)
	{
		scene = SceneManager.UpdateScene(sceneName);
		ClientSend.SceneChangePacket(scene);
	}

	public void SpawnPlayer()
	{
		// Security Rule: Prevent duplicate player spawning
		if (userObject != null)
		{
			MelonLogger.Warning($"[UserData->SpawnPlayer] Player {username} (ID: {playerID}) already spawned. Skipping duplicate spawn.");
			return;
		}

		if (ClientData.Instance.playerPrefab == null)
		{
			MelonLogger.Warning("[CMS21-Together] Cannot spawn player: playerPrefab is null. Will retry.");
			return;
		}
		if (playerID == ClientData.UserData.playerID)
		{
			if (GameData.Instance?.localPlayer == null)
			{
				MelonLogger.Warning("[CMS21-Together] Cannot spawn local player: localPlayer is null.");
				return;
			}
			userObject = GameData.Instance.localPlayer;
		}
		else
		{
			userObject = Object.Instantiate(ClientData.Instance.playerPrefab, position.toVector3(), rotation.toQuaternion());
			userObject.AddComponent<InfoBillboard>();
			userAnimator = userObject.GetComponent<Animator>();
			userObject.name = username;
			baseScaleY = userObject.transform.localScale.y;

			// Collision ignore is best-effort — localPlayer may be null in non-garage scenes
			var localPlayerCollider = GameData.Instance?.localPlayer?.GetComponent<Collider>();
			var userObjectCollider = userObject.GetComponent<Collider>();
			if (localPlayerCollider != null && userObjectCollider != null)
				Physics.IgnoreCollision(localPlayerCollider, userObjectCollider);

			MelonLogger.Msg($"[UserData->SpawnPlayer] Spawned player {username} (ID: {playerID}) at position {position.toVector3()}");
		}

	}

	public void DestroyPlayer()
	{
		if (userObject == null) return;
		Object.Destroy(userObject);
		userObject = null;
	}
}