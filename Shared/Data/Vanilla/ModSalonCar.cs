using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModSalonCar
{
	public string carId;
	public int version;
	public int slotIndex = -1;
	public ModColor color;
	public bool purchased;

	public ModSalonCar() { }

	public ModSalonCar(string carId, int version)
	{
		this.carId = carId;
		this.version = version;
		this.slotIndex = -1;
	}

	public ModSalonCar(string carId, int version, int slotIndex, ModColor color = null, bool purchased = false)
	{
		this.carId = carId;
		this.version = version;
		this.slotIndex = slotIndex;
		this.color = color;
		this.purchased = purchased;
	}
}
