using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CMS.UI.Windows;
using CMS21Together.ClientSide.Data.Garage.Car;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using CMS21Together.Shared.Data.Vanilla.Cars;
using CMS21Together.Shared.Data.Vanilla.GarageTool;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;


[HarmonyPatch]
public static class EngineStand
{
	public static bool listen = true;
	public static bool useAlt;
	
	[HarmonyPatch(typeof(GameScript), nameof(GameScript.SetIOMouseOver))]
	[HarmonyPrefix]
	public static void SetIOMouseOverHook(GameObject go, string type, InteractiveObject io)
	{
		if(!Client.Instance.isConnected)  return;
		
		if (type == "#enginestand")
			useAlt = go.name == "Engine_stand_2";
		else if (type == "#engine")
			useAlt = go.transform.parent?.parent?.parent.name == "Engine_stand_2";
	}
	
	[HarmonyPatch(typeof(CreateEngineWindow), nameof(CreateEngineWindow.CreateEngineAction))]
	[HarmonyPrefix]
	public static bool CreateEngineActionHook(CreateEngineWindow __instance)
	{
		if(!Client.Instance.isConnected) return true;
		if (useAlt)
		{
			GameData.Instance.engineStandLogic2.SetEngineOnEngineStand(__instance.currentEngine);
			__instance.Hide(false);
			return false;
		}
		GameData.Instance.engineStandLogic.SetEngineOnEngineStand(__instance.currentEngine);
		__instance.Hide(false);
		return false;
	}
	
	[HarmonyPatch(typeof(EngineStandLogic), nameof(EngineStandLogic.IncreaseEngineStandAngle))] 
	[HarmonyPrefix]
	public static bool IncreaseEngineStandAngleHook(float val, EngineStandLogic __instance)
	{
		if(!Client.Instance.isConnected || !listen) { listen = true; return true;}
		
		if (useAlt)
		{
			listen = false;
			GameData.Instance.engineStandLogic2.IncreaseEngineStandAngle(val);
			ClientSend.EngineStandAnglePacket(val, __instance.gameObject.name == "Engine_stand_2");
			return false;
		}
		ClientSend.EngineStandAnglePacket(val, __instance.gameObject.name == "Engine_stand_2");
		return true;

	}
	
	[HarmonyPatch(typeof(PieMenuController), "_GetOnClick_b__72_35")]
	[HarmonyPrefix]
	public static bool TakeOffEngineFromStandHook()
	{
		if(!Client.Instance.isConnected || !listen) { listen = true; return true;}
		
		if (useAlt)
		{
			Singleton<GameManager>.Instance.Inventory.AddGroup(GameData.Instance.engineStandLogic2.GetGroupOnEngineStand());
			GameData.Instance.engineStandLogic2.ClearEngineStand();
			ClientSend.TakeOffEnginePacket(useAlt);
			return false;
		}
		return true;
	}
	
	
	[HarmonyPatch(typeof(EngineStandLogic), nameof(EngineStandLogic.SetGroupOnEngineStand))] 
	[HarmonyPostfix]
	public static void SetGroupOnEngineStand(GroupItem groupItem, bool withFade, EngineStandLogic __instance)
	{
		try
		{
			if (Client.Instance == null || !Client.Instance.isConnected || ClientData.Instance == null) return;
			if (GameData.Instance == null || !GameData.isReady) return;
			if (__instance == null) return;
			if (groupItem == null) return;

			bool isAlt = __instance.gameObject.name == "Engine_stand_2";
			EngineStandLogic logic = isAlt ? GameData.Instance.engineStandLogic2 : GameData.Instance.engineStandLogic;
			if (logic == null) return;

			ModEngineStand stand;
			if (isAlt)
			{
				ClientData.Instance.engineStand2 = new ModEngineStand(logic);
				stand = ClientData.Instance.engineStand2;
				stand.engineGroupItem = new ModGroupItem(groupItem);
			}
			else
			{
				ClientData.Instance.engineStand = new ModEngineStand(logic);
				stand = ClientData.Instance.engineStand;
				stand.engineGroupItem = new ModGroupItem(groupItem);
			}

			MelonCoroutines.Start(HandleEngineStand(stand));
		}
		catch (Exception ex)
		{
			MelonLogger.Warning($"[EngineStand->SetGroupOnEngineStand] Skipped during load: {ex.Message}");
		}
	}

	private static IEnumerator HandleEngineStand(ModEngineStand stand)
	{
		yield return new WaitForEndOfFrame();
		int counter = 0;
		while (counter++ < 20 && stand.reference.engineGameObject == null)
			yield return new WaitForSeconds(0.25f);
		
		if (stand.reference.engineGameObject == null)
		{
			MelonLogger.Warning("[EngineStand->HandleEngineStand] EngineStand as no engineObject ! aborting...");
			yield break;
		}
		if (listen)
		{
			Vector3Serializable enginePos;
			enginePos = new Vector3Serializable(stand.reference.engineGameObject.transform.position);
			stand.position = enginePos;
			ClientSend.EngineStandSetGroupPacket(stand.engineGroupItem, enginePos, useAlt);
		}
		listen = true;
		
		yield return new WaitForEndOfFrame();
		List<PartScript> parts = stand.reference.engineGameObject.GetComponentsInChildren<PartScript>().ToList();
		yield return new WaitForEndOfFrame();
		for (int i = 0; i < parts.Count; i++)
		{
			if (!stand.partReferences.ContainsKey(i))
			{
				stand.partReferences.Add(i, parts[i]);
				stand.parts.Add(i, new ModPartScript(parts[i], i, -1, ModPartType.engineStand));
			}
		}
		yield return new WaitForEndOfFrame();
		stand.isHandled = true;
		MelonLogger.Msg("[EngineStand->GetReferences] Finished without error.");
	}

	public static IEnumerator TakeOnEngineFromStand(ModGroupItem engineGroup, Vector3Serializable position, bool alt)
	{
		MelonLogger.Msg($"Received engine from server! {alt}");
		yield return LoadWait.WaitForGameDataReady();
		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;
		yield return new WaitForEndOfFrame();

		EngineStandLogic logic = alt ? GameData.Instance.engineStandLogic2 : GameData.Instance.engineStandLogic;
		if (logic == null)
		{
			MelonLogger.Warning("[EngineStand->TakeOnEngineFromStand] Engine stand logic is null.");
			yield break;
		}

		ModEngineStand stand;
		if (alt)
		{
			ClientData.Instance.engineStand2 = new ModEngineStand(logic);
			stand = ClientData.Instance.engineStand2;
		}
		else
		{
			ClientData.Instance.engineStand = new ModEngineStand(logic);
			stand = ClientData.Instance.engineStand;
		}
		
		listen = false;
		MainMod.StartCoroutine(stand.reference.SetGroupOnEngineStand(engineGroup.ToGame(), false));
		
		int counter = 0;
		while (counter < 20 && stand.reference.engineGameObject == null)
		{
			yield return new WaitForSeconds(0.5f);
			counter++;
		}
		if (stand.reference.engineGameObject == null)
		{
			MelonLogger.Warning("[EngineStand->TakeOnEngineFromStand] EngineStand as no engineObject ! aborting...");
			yield break;
		}
		stand.reference.engineGameObject.transform.position = position.toVector3();
	}
	
	public static IEnumerator TakeOffEngineFromStand(bool alt)
	{
		while (!GameData.isReady)
			yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();

		ModEngineStand stand;
		if (alt)
			stand = ClientData.Instance.engineStand2;
		else
			stand = ClientData.Instance.engineStand;
		
		stand.reference.ClearEngineStand();
		SoundManager.Get().PlaySFX("PartTakeOff");
	}
	
	public static IEnumerator IncreaseEngineStandAngle(float angle, bool alt)
	{
		while (!GameData.isReady)
			yield return new WaitForSeconds(0.25f);
		yield return new WaitForEndOfFrame();
		
		listen = false;
		if (!alt)
			GameData.Instance.engineStandLogic.IncreaseEngineStandAngle(angle);
		else
			GameData.Instance.engineStandLogic2.IncreaseEngineStandAngle(angle);
	}
}