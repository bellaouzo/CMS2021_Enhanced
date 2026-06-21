using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModDoorState
{
	public string doorId;
	public bool isOpen;
	public int carLoaderID;

	public ModDoorState() { }

	public ModDoorState(string doorId, bool isOpen, int carLoaderID = -1)
	{
		this.doorId = doorId;
		this.isOpen = isOpen;
		this.carLoaderID = carLoaderID;
	}
}
