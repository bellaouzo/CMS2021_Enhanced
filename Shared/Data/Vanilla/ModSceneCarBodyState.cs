using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModSceneCarBodyState
{
	public string name;
	public float condition;
	public float conditionStructure;
	public float conditionPaint;
	public bool unmounted;
	public bool switched;
	public float dent;
	public float dust;

	public ModSceneCarBodyState() { }

	public ModSceneCarBodyState(string name, float condition, float conditionStructure, float conditionPaint,
		bool unmounted, bool switched, float dent, float dust)
	{
		this.name = name;
		this.condition = condition;
		this.conditionStructure = conditionStructure;
		this.conditionPaint = conditionPaint;
		this.unmounted = unmounted;
		this.switched = switched;
		this.dent = dent;
		this.dust = dust;
	}
}
