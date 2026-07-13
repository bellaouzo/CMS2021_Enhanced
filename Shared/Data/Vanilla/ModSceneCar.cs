using System;

namespace CMS21Together.Shared.Data.Vanilla;

public enum SceneCarType { Auction = 0, Barn = 1, Junkyard = 2 }

[Serializable]
public class ModSceneCar
{
    public SceneCarType sceneType;
    public int slotIndex;
    public string carId;
    public int version;

    // Auction-specific fields
    public int rating;
    public int seed;
    public int value;
    public int startingPrice;
    public bool sold;

    public ModSceneCar() { }

    public ModSceneCar(SceneCarType sceneType, int slotIndex, string carId, int version)
    {
        this.sceneType = sceneType;
        this.slotIndex = slotIndex;
        this.carId = carId;
        this.version = version;
    }
}
