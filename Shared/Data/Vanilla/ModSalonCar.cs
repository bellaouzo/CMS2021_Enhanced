using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModSalonCar
{
	public string carId;
	public int version;
	public int slotIndex = -1;

	public ModSalonCar() { }

	public ModSalonCar(string carId, int version)
	{
		this.carId = carId;
		this.version = version;
		this.slotIndex = -1;
	}

	public ModSalonCar(string carId, int version, int slotIndex)
	{
		this.carId = carId;
		this.version = version;
		this.slotIndex = slotIndex;
	}
}
