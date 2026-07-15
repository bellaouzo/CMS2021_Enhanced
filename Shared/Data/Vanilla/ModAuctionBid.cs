using System;

namespace CMS21Together.Shared.Data.Vanilla;

public enum AuctionBidAction : byte
{
	Open = 0,
	Start = 1,
	PlayerBid = 2,
	AIBid = 3,
	Finish = 4,
	Return = 5,
	GiveUp = 6,
}

[Serializable]
public class ModAuctionBid
{
	public AuctionBidAction action;
	public int auctionType;
	public int currentBid;
	public int bidAmount;
	public string bidderName;
	public bool won;

	public ModAuctionBid() { }

	public ModAuctionBid(AuctionBidAction action, int auctionType = 0, int currentBid = 0,
		int bidAmount = 0, string bidderName = null, bool won = false)
	{
		this.action = action;
		this.auctionType = auctionType;
		this.currentBid = currentBid;
		this.bidAmount = bidAmount;
		this.bidderName = bidderName ?? string.Empty;
		this.won = won;
	}
}
