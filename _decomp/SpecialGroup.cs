using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum SpecialGroup : byte
{
	OilDrainCheckFill = 1,
	Tire = 6,
	Rim = 7,
	Absorber = 8,
	Seat = 9,
	SteeringWheel = 10,
	Engine = 11,
	Bench = 12,
	SpecialCase = 13,
	SpecialMap = 14,
	Gearbox = 15,
	BonusHood = 16,
	BonusRoof = 17,
	BonusTrunk = 18,
	Ecu = 19,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SpecialGroup>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static SpecialGroup()
	{
		Il2CppClassPointerStore<SpecialGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SpecialGroup");
	}

}
