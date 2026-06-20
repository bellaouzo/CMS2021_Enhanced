using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum IOSpecialType : byte
{
	None,
	MainGate,
	WheelBalancer,
	TireChanger,
	SpringClamp,
	EngineStand,
	CarBatteryCharger,
	RepairTable,
	Junk,
	Paintshop,
	Jukebox,
	Welder,
	InteriorDetailingToolkit,
	Oilbin,
	EngineCrane,
	EngineCraneMount,
	GarageLook,
	HeadlampAlignmentSystem,
	WheelsAlignmentSystem,
	BrakeLathe,
	BonusPart,
	PathTest,
	CarWash,
	InteriorDetailingToolkitStationary,
	WindowTint,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IOSpecialType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static IOSpecialType()
	{
		Il2CppClassPointerStore<IOSpecialType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "IOSpecialType");
	}

}
