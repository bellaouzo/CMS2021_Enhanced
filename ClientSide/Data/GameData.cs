using System.Collections;
using CMS.Managers;
using CMS.UI.Logic.Upgrades;
using CMS.UI.Windows;
using CMS21Together.ClientSide.Data.Garage;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.ServerSide;
using CMS21Together.Shared;
using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CMS21Together.ClientSide.Data;

public class GameData
{
	public static GameData Instance;
	public static bool isReady;
	private static bool isInitializing;
	public CarLoader[] carLoaders;
	public Inventory localInventory;

	public GameObject localPlayer;
	public OrderGenerator orderGenerator;
	public SpringClampLogic springClampLogic;
	public EngineStandLogic engineStandLogic;
	public EngineStandLogic engineStandLogic2;
	public TireChangerLogic tireChanger;
	public GarageAndToolsTab upgradeTools;
	public ToolsMoveManager toolsMoveManager;
	public WheelBalancerLogic wheelBalancer;
	public WelderLogic welderLogic;
	public PaintshopManager paintshopManager;

	private GameData() { }

	public static void ResetState()
	{
		isReady = false;
		isInitializing = false;
		Instance = null;
	}

	public static IEnumerator Initialize()
	{
		if (Instance != null && Instance.engineStandLogic2 != null)
		{
			yield return Refresh();
			yield break;
		}

		while (isInitializing)
			yield return new WaitForSeconds(0.1f);

		isInitializing = true;
		isReady = false;
		Instance = new GameData();

		yield return LoadWait.WaitForNotificationReady();
		if (LoadWait.LastResult != LoadWaitResult.Success)
		{
			isInitializing = false;
			yield break;
		}

		yield return PopulateReferences();
		if (LoadWait.LastResult != LoadWaitResult.Success)
		{
			isInitializing = false;
			yield break;
		}

		Instance.EnsureEngineStand2();
		isReady = true;
		isInitializing = false;

		if (!Server.Instance.isRunning)
			MelonCoroutines.Start(GarageResync.ResyncGarage());

		MelonLogger.Msg("[GameData->Initialize] GameData ready.");
	}

	public static IEnumerator Refresh()
	{
		isReady = false;

		yield return LoadWait.WaitForNotificationReady();
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		if (Instance == null)
			Instance = new GameData();

		yield return PopulateReferences();
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		isReady = true;
		MelonLogger.Msg("[GameData->Refresh] GameData references refreshed.");
	}

	private static bool HasEngineStandLogic()
	{
		if (Object.FindObjectOfType<EngineStandLogic>() != null)
			return true;

		var tools = ToolsManager.Get();
		return tools != null && tools.EngineStandLogic != null;
	}

	private static bool HasWheelBalancerLogic()
	{
		if (Object.FindObjectOfType<WheelBalancerLogic>() != null)
			return true;

		var tools = ToolsManager.Get();
		return tools != null && tools.WheelBalancerLogic != null;
	}

	private static IEnumerator PopulateReferences()
	{
		yield return LoadWait.WaitForPredicate(() => Object.FindObjectOfType<FPSInputController>() != null, 30f, "FPSInputController");
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		yield return LoadWait.WaitForPredicate(() => GameScript.Get() != null, 30f, "GameScript");
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		// Engine stand and wheel balancer are optional upgrades — not present in all saves.
		// Wait briefly for loading lag but don't fail init if they're absent.
		yield return LoadWait.WaitForPredicate(HasEngineStandLogic, 5f, "EngineStandLogic");
		if (LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		yield return LoadWait.WaitForPredicate(HasWheelBalancerLogic, 5f, "WheelBalancerLogic");
		if (LoadWait.LastResult == LoadWaitResult.Disconnected) yield break;

		var fps = Object.FindObjectOfType<FPSInputController>();
		Instance.localPlayer = fps.gameObject;
		Instance.localInventory = GameScript.Get().GetComponent<Inventory>();

		var garageLevelManager = Object.FindObjectOfType<GarageLevelManager>();
		Instance.upgradeTools = garageLevelManager?.garageAndToolsTab;

		Instance.toolsMoveManager = Object.FindObjectOfType<ToolsMoveManager>();
		Instance.orderGenerator = Object.FindObjectOfType<OrderGenerator>();
		var toolsManager = ToolsManager.Get();
		Instance.springClampLogic = Object.FindObjectOfType<SpringClampLogic>() ?? toolsManager?.SpringClampLogic;
		Instance.tireChanger = Object.FindObjectOfType<TireChangerLogic>() ?? toolsManager?.TireChangerLogic;
		Instance.wheelBalancer = Object.FindObjectOfType<WheelBalancerLogic>() ?? toolsManager?.WheelBalancerLogic;
		Instance.welderLogic = Object.FindObjectOfType<WelderLogic>();
		Instance.paintshopManager = Object.FindObjectOfType<PaintshopManager>();

		Instance.BindEngineStandReferences();

		if (Instance.welderLogic == null)
			MelonLogger.Warning("[GameData->PopulateReferences] WelderLogic not found.");
		if (Instance.paintshopManager == null)
			MelonLogger.Warning("[GameData->PopulateReferences] PaintshopManager not found.");

		var gameScript = GameScript.Get();
		Instance.carLoaders = new[]
		{
			gameScript.carOnScene[0],
			gameScript.carOnScene[3],
			gameScript.carOnScene[4],
			gameScript.carOnScene[1],
			gameScript.carOnScene[2]
		};
	}

	private void BindEngineStandReferences()
	{
		engineStandLogic = null;
		engineStandLogic2 = null;

		foreach (var stand in Object.FindObjectsOfType<EngineStandLogic>())
		{
			if (stand.gameObject.name == "Engine_stand_2")
				engineStandLogic2 = stand;
			else
				engineStandLogic = stand;
		}

		if (engineStandLogic == null)
		{
			var tools = ToolsManager.Get();
			if (tools?.EngineStandLogic != null)
				engineStandLogic = tools.EngineStandLogic;
		}
	}

	private void EnsureEngineStand2()
	{
		if (engineStandLogic2 != null)
			return;

		if (engineStandLogic == null)
		{
			MelonLogger.Warning("[GameData->EnsureEngineStand2] Primary engine stand not found.");
			return;
		}

		LoadEngineStand();
	}

	public void LoadEngineStand()
	{
		var existing = GameObject.Find("Engine_stand_2");
		if (existing != null)
		{
			engineStandLogic2 = existing.GetComponent<EngineStandLogic>();
			if (engineStandLogic2 != null)
				return;
		}

		engineStandLogic2 = Object.Instantiate(engineStandLogic.gameObject,
			new Vector3(-13.7864f, 0, -3.23f), Quaternion.identity).GetComponent<EngineStandLogic>();
		engineStandLogic2.gameObject.name = "Engine_stand_2";
		engineStandLogic2.EngineStand = engineStandLogic2.transform.GetChild(1).transform.GetChild(3).transform;

		var bundle = AssetBundle.LoadFromStream(DataHelper.DeepCopy(DataHelper.LoadContent("CMS21Together.Assets.engineStand.assets")));
		if (bundle == null)
		{
			MelonLogger.Warning("Impossible de charger l'AssetBundle !");
			return;
		}

		GameObject newObj = null;
		Mesh mesh = bundle.LoadAsset<Mesh>("assets/assetbundles/enginestand.fbx");
		if (mesh == null)
		{
			MelonLogger.Warning("Impossible de charger le Mesh !");
		}
		else
		{
			newObj = new GameObject("EngineStand_A");
			MeshFilter mf = newObj.AddComponent<MeshFilter>();
			MeshRenderer mr = newObj.AddComponent<MeshRenderer>();
			newObj.transform.position = new Vector3(3.5745f, 0, 0);

			mf.sharedMesh = mesh;
			mr.material = engineStandLogic.transform.GetChild(2).GetComponent<MeshRenderer>().material;
		}

		if (newObj != null) newObj.transform.SetParent(engineStandLogic2.transform, true);

		bundle.Unload(false);
		MelonLogger.Msg("Loaded stand successfully !");
	}

	public static IEnumerator GameReady()
	{
		yield return LoadWait.WaitForGameDataReady();
	}
}
