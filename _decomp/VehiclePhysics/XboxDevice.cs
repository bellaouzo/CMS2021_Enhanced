using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

public enum XboxDevice
{
	XboxController1,
	XboxController2,
	XboxController3,
	XboxController4,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XboxDevice>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static XboxDevice()
	{
		Il2CppClassPointerStore<XboxDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "XboxDevice");
	}

}
