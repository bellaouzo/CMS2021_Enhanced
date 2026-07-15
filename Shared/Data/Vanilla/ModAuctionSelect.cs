using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModAuctionSelect
{
	public int auctionType; // 0 = Normal, 1 = Salvage
	public int slotIndex;
	public string carId;
	public int version;
	public int seed;
	public int rating;
	public int value;
	public int startingPrice;

	public ModAuctionSelect() { }

	public ModAuctionSelect(int auctionType, int slotIndex, string carId, int version, int seed,
		int rating, int value, int startingPrice)
	{
		this.auctionType = auctionType;
		this.slotIndex = slotIndex;
		this.carId = carId;
		this.version = version;
		this.seed = seed;
		this.rating = rating;
		this.value = value;
		this.startingPrice = startingPrice;
	}
}
