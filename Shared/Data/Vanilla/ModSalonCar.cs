using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModSalonCar
{
	public string carId;
	public int version;

	public ModSalonCar() { }

	public ModSalonCar(string carId, int version)
	{
		this.carId = carId;
		this.version = version;
	}
}
