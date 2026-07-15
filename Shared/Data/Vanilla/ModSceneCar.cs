using System;
using System.Collections.Generic;
using CMS21Together.Shared.Data;

namespace CMS21Together.Shared.Data.Vanilla;

public enum SceneCarType { Auction = 0, Barn = 1, Junkyard = 2, Salon = 3, Garage = 4 }

[Serializable]
public class ModSceneCar
{
	public SceneCarType sceneType;
	public int slotIndex;
	public string carId;
	public int version;
	public ModColor color;

	// Auction-specific fields
	public int rating;
	public int seed;
	public int value;
	public int startingPrice;
	public bool sold;
	/// <summary>True when a barn/junkyard/salon scene car was purchased and should be removed for peers.</summary>
	public bool purchased;

	// Barn/Junkyard damage + missing parts snapshot from host
	public List<ModSceneCarBodyState> bodyParts;
	// PartScript snapshot (tires/wheels/etc.)
	public List<ModSceneCarPartScriptState> partScripts;

	// World pose so clients match host placement even if layout RNG drifts
	public Vector3Serializable position;
	public QuaternionSerializable rotation;

	public ModSceneCar() { }

	public ModSceneCar(SceneCarType sceneType, int slotIndex, string carId, int version, ModColor color = null)
	{
		this.sceneType = sceneType;
		this.slotIndex = slotIndex;
		this.carId = carId;
		this.version = version;
		this.color = color;
	}
}
