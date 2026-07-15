using System;

namespace CMS21Together.Shared.Data.Vanilla;

/// <summary>
/// Compact PartScript snapshot for scene cars (tires/wheels/etc. that are not CarParts).
/// </summary>
[Serializable]
public class ModSceneCarPartScriptState
{
	public string id;
	public bool unmounted;
	public float condition;
	public float dust;

	public ModSceneCarPartScriptState() { }

	public ModSceneCarPartScriptState(string id, bool unmounted, float condition, float dust)
	{
		this.id = id;
		this.unmounted = unmounted;
		this.condition = condition;
		this.dust = dust;
	}
}
