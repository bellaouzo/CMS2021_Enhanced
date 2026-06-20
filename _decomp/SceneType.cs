using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum SceneType
{
	None,
	Junkyard,
	Barn,
	Showroom,
	Garage,
	Auction,
	TestTrack,
	RaceTrack,
	Salon,
	Parking,
	Menu,
	FunTrack,
	OffroadTrack,
	DragStrip,
	CustomTrack,
	Tutorial,
	PhotoLocation,
	SpeedTrack,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SceneType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static SceneType()
	{
		Il2CppClassPointerStore<SceneType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SceneType");
	}

}
