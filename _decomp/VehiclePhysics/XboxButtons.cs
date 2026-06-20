using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[System.Flags]
public enum XboxButtons
{
	NONE = 0,
	DPAD_UP = 1,
	DPAD_DOWN = 2,
	DPAD_LEFT = 4,
	DPAD_RIGHT = 8,
	START = 0x10,
	BACK = 0x20,
	LEFT_THUMB = 0x40,
	RIGHT_THUMB = 0x80,
	LEFT_SHOULDER = 0x100,
	RIGHT_SHOULDER = 0x200,
	A = 0x1000,
	B = 0x2000,
	X = 0x4000,
	Y = 0x8000,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XboxButtons>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static XboxButtons()
	{
		Il2CppClassPointerStore<XboxButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "XboxButtons");
	}

}
