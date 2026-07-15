using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModSceneCarPart
{
	public SceneCarType sceneType;
	public int slotIndex;
	public string partName;
	public bool switched;
	public bool hasSwitched;

	public ModSceneCarPart() { }

	public ModSceneCarPart(SceneCarType sceneType, int slotIndex, string partName, bool switched = false, bool hasSwitched = false)
	{
		this.sceneType = sceneType;
		this.slotIndex = slotIndex;
		this.partName = partName;
		this.switched = switched;
		this.hasSwitched = hasSwitched;
	}
}
