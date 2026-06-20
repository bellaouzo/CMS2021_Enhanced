using System;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Flags]
public enum MissingWheelTypes
{
	None = 0,
	FrontLeft = 1,
	FrontRight = 2,
	RearLeft = 4,
	RearRight = 8,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MissingWheelTypes>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static MissingWheelTypes()
	{
		Il2CppClassPointerStore<MissingWheelTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MissingWheelTypes");
	}

}
