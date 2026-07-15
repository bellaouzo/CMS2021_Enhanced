using System.Collections;
using System.Collections.Generic;
using CMS.SceneLoaders;
using CMS.UI.Logic;
using CMS.UI.Logic.Auction;
using CMS.UI.Windows;
using CMS21Together.ClientSide;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using CMS21Together.Shared.Data.Vanilla;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Scene;

/// <summary>
/// Host-authoritative auction bidding spectating: remotes see the bid UI and events but cannot bid.
/// </summary>
[HarmonyPatch]
public static class AuctionBidSyncLogic
{
	public static bool listen = true;
	private static bool spectatorMode;
	private static bool applying;
	private static string lastAIBidderName = string.Empty;
	private static readonly Queue<ModAuctionBid> pending = new();
	private static bool drainRunning;

	public static void Reset()
	{
		listen = true;
		spectatorMode = false;
		applying = false;
		lastAIBidderName = string.Empty;
		pending.Clear();
		drainRunning = false;
	}

	public static void Apply(ModAuctionBid data)
	{
		if (data == null) return;
		pending.Enqueue(data);
		MelonLogger.Msg($"[AuctionBidSync] Queued {data.action} (pending={pending.Count}).");
		if (!drainRunning)
			MelonCoroutines.Start(DrainQueue());
	}

	private static void Send(ModAuctionBid data)
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		ClientSend.AuctionBidPacket(data);
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.Open))]
	[HarmonyPostfix]
	public static void OpenHook(AuctionType auctionType, bool __result)
	{
		if (!__result) return;
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		Send(new ModAuctionBid(AuctionBidAction.Open, (int)auctionType));
		MelonLogger.Msg($"[AuctionBidSync] Sent Open ({auctionType}).");
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.StartAuctionAction))]
	[HarmonyPostfix]
	public static void StartAuctionActionHook(AuctionBidding __instance)
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		Send(new ModAuctionBid(AuctionBidAction.Start, 0, __instance.currentBid, __instance.bidAmount));
		MelonLogger.Msg("[AuctionBidSync] Sent Start.");
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.PlayerBid))]
	[HarmonyPostfix]
	public static void PlayerBidHook(AuctionBidding __instance)
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		Send(new ModAuctionBid(AuctionBidAction.PlayerBid, 0, __instance.currentBid, __instance.bidAmount));
		MelonLogger.Msg($"[AuctionBidSync] Sent PlayerBid {__instance.currentBid}.");
	}

	[HarmonyPatch(typeof(BidCircle), nameof(BidCircle.AIBidAnimation))]
	[HarmonyPostfix]
	public static void AIBidAnimationHook(string bidder, int price)
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		lastAIBidderName = bidder ?? string.Empty;
		var bidding = UnityEngine.Object.FindObjectOfType<AuctionBidding>();
		int current = bidding != null ? bidding.currentBid : price;
		Send(new ModAuctionBid(AuctionBidAction.AIBid, 0, current, price, lastAIBidderName));
		MelonLogger.Msg($"[AuctionBidSync] Sent AIBid {bidder} @ {price}.");
	}

	[HarmonyPatch(typeof(BidCircle), nameof(BidCircle.SetFinishState))]
	[HarmonyPostfix]
	public static void SetFinishStateHook(bool win)
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		var bidding = UnityEngine.Object.FindObjectOfType<AuctionBidding>();
		Send(new ModAuctionBid(AuctionBidAction.Finish, 0,
			bidding != null ? bidding.currentBid : 0,
			bidding != null ? bidding.bidAmount : 0,
			null, win));
		MelonLogger.Msg($"[AuctionBidSync] Sent Finish won={win}.");
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.ReceiveCarAction))]
	[HarmonyPostfix]
	public static void ReceiveCarActionHook()
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		// Host won — ensure peers leave the car view even if ReturnToCarsSelect is delayed.
		MelonCoroutines.Start(SendReturnAfterWin());
	}

	private static IEnumerator SendReturnAfterWin()
	{
		yield return new WaitForSeconds(1.5f);
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) yield break;
		Send(new ModAuctionBid(AuctionBidAction.Return));
		MelonLogger.Msg("[AuctionBidSync] Sent Return (after ReceiveCar).");
	}

	[HarmonyPatch(typeof(AuctionManager), nameof(AuctionManager.ReturnToCarsSelect))]
	[HarmonyPostfix]
	public static void ReturnToCarsSelectHook()
	{
		if (!Client.Instance.isConnected || !listen || applying) return;
		if (spectatorMode)
		{
			spectatorMode = false;
			return;
		}
		Send(new ModAuctionBid(AuctionBidAction.Return));
		MelonLogger.Msg("[AuctionBidSync] Sent Return.");
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.GiveUpAction))]
	[HarmonyPostfix]
	public static void GiveUpActionHook()
	{
		if (!Client.Instance.isConnected || !listen || applying || spectatorMode) return;
		Send(new ModAuctionBid(AuctionBidAction.GiveUp));
		MelonLogger.Msg("[AuctionBidSync] Sent GiveUp.");
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.BidAction))]
	[HarmonyPrefix]
	public static bool BidActionPrefix()
	{
		if (spectatorMode && !applying) return false;
		return true;
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.StartAuctionAction))]
	[HarmonyPrefix]
	public static bool StartAuctionActionPrefix()
	{
		if (spectatorMode && !applying) return false;
		return true;
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.GiveUpAction))]
	[HarmonyPrefix]
	public static bool GiveUpActionPrefix()
	{
		if (spectatorMode && !applying) return false;
		return true;
	}

	[HarmonyPatch(typeof(AuctionBidding), nameof(AuctionBidding.OnBidButtonClick))]
	[HarmonyPrefix]
	public static bool OnBidButtonClickPrefix()
	{
		if (spectatorMode && !applying) return false;
		return true;
	}

	private static IEnumerator DrainQueue()
	{
		drainRunning = true;
		while (pending.Count > 0)
		{
			var data = pending.Dequeue();
			yield return ApplyOne(data);
		}
		drainRunning = false;
	}

	private static IEnumerator ApplyOne(ModAuctionBid data)
	{
		applying = true;
		listen = false;
		try
		{
			// Prefer AuctionManager presence over scene enum (avoids silent WaitForScene failures).
			yield return LoadWait.WaitForPredicate(() =>
			{
				if (SceneManager.CurrentScene() == GameScene.auctions) return true;
				return UnityEngine.Object.FindObjectOfType<AuctionManager>() != null;
			}, 30f, "auction scene/manager");
			if (LoadWait.LastResult != LoadWaitResult.Success)
			{
				MelonLogger.Warning($"[AuctionBidSync] Dropped {data.action}: auction not ready.");
				yield break;
			}

			var am = UnityEngine.Object.FindObjectOfType<AuctionManager>();
			var window = UnityEngine.Object.FindObjectOfType<AuctionWindow>();
			var bidding = window?.auctionBidding ?? UnityEngine.Object.FindObjectOfType<AuctionBidding>();
			if (am == null || bidding == null)
			{
				MelonLogger.Warning($"[AuctionBidSync] Dropped {data.action}: missing AuctionManager/Bidding.");
				yield break;
			}

			switch (data.action)
			{
				case AuctionBidAction.Open:
					spectatorMode = true;
					try { window?.OpenScreen(AuctionScreen.Bidding); } catch { /* ignore */ }
					yield return new WaitForEndOfFrame();
					bidding.Open((AuctionType)data.auctionType);
					try { bidding.UnregisterBidButtonEvents(); } catch { /* ignore */ }
					MelonLogger.Msg("[AuctionBidSync] Applied Open (spectator).");
					break;

				case AuctionBidAction.Start:
					spectatorMode = true;
					try { window?.OpenScreen(AuctionScreen.Bidding); } catch { /* ignore */ }
					try { bidding.UnregisterBidButtonEvents(); } catch { /* ignore */ }
					bidding.currentBid = data.currentBid;
					bidding.bidAmount = data.bidAmount;
					bidding.StartAuction();
					MelonLogger.Msg("[AuctionBidSync] Applied Start (spectator).");
					break;

				case AuctionBidAction.PlayerBid:
					spectatorMode = true;
					bidding.currentBid = data.currentBid;
					bidding.bidAmount = data.bidAmount;
					if (bidding.bidCircle != null)
						bidding.bidCircle.PlayerBidAnimation(data.currentBid);
					if (bidding.console != null)
						bidding.console.AddLine("Player", data.currentBid);
					MelonLogger.Msg($"[AuctionBidSync] Applied PlayerBid {data.currentBid}.");
					break;

				case AuctionBidAction.AIBid:
					spectatorMode = true;
					bidding.currentBid = data.currentBid;
					if (bidding.bidCircle != null)
						bidding.bidCircle.AIBidAnimation(data.bidderName ?? "AI", data.currentBid);
					if (bidding.console != null)
						bidding.console.AddLine(data.bidderName ?? "AI", data.currentBid);
					MelonLogger.Msg($"[AuctionBidSync] Applied AIBid {data.bidderName} @ {data.currentBid}.");
					break;

				case AuctionBidAction.Finish:
					spectatorMode = true;
					if (bidding.bidCircle != null)
						bidding.bidCircle.SetFinishState(data.won);
					try { bidding.FinishAuction(); } catch { /* ignore */ }
					MelonLogger.Msg($"[AuctionBidSync] Applied Finish won={data.won}.");
					// If host won, auto-return shortly so spectator isn't stuck on the car.
					if (data.won)
					{
						yield return new WaitForSeconds(2f);
						try { am.ReturnToCarsSelect(); } catch { /* ignore */ }
						spectatorMode = false;
						MelonLogger.Msg("[AuctionBidSync] Auto-returned to car list after host win.");
					}
					break;

				case AuctionBidAction.Return:
					try { am.ReturnToCarsSelect(); } catch { /* ignore */ }
					spectatorMode = false;
					MelonLogger.Msg("[AuctionBidSync] Applied Return.");
					break;

				case AuctionBidAction.GiveUp:
					try { bidding.GiveUpAction(); } catch { /* ignore */ }
					spectatorMode = false;
					MelonLogger.Msg("[AuctionBidSync] Applied GiveUp.");
					break;
			}
		}
		finally
		{
			listen = true;
			applying = false;
		}
	}
}
