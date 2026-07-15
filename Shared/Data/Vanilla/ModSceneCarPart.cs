using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModSceneCarPart
{
    public SceneCarType sceneType;
    public int slotIndex;
    public string partName;

    public ModSceneCarPart() { }

    public ModSceneCarPart(SceneCarType sceneType, int slotIndex, string partName)
    {
        this.sceneType = sceneType;
        this.slotIndex = slotIndex;
        this.partName  = partName;
    }
}
