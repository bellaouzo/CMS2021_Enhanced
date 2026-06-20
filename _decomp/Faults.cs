using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum Faults
{
	engineGeneral,
	enginePower,
	engineNoise,
	engineOil,
	engineFilters,
	engineTiming,
	engineDontStart,
	suspGeneral,
	suspControl,
	suspKnocking,
	brakesGeneral,
	exhaustGeneral,
	gearboxGeneral,
	gearboxUnit,
	gearboxClutch,
	e_starter,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Faults>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static Faults()
	{
		Il2CppClassPointerStore<Faults>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Faults");
	}

}
