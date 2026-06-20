using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum CheckCarCanDriveState
{
	CanDrive,
	MissingWheels,
	MissingParts,
	EngineDontStart,
	MissingDriveshaft,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CheckCarCanDriveState>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static CheckCarCanDriveState()
	{
		Il2CppClassPointerStore<CheckCarCanDriveState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CheckCarCanDriveState");
	}

}
