using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum DragSpeedType : byte
{
	Zero_50,
	Zero_100,
	Zero_150,
	Zero_200,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragSpeedType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static DragSpeedType()
	{
		Il2CppClassPointerStore<DragSpeedType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DragSpeedType");
	}

}
