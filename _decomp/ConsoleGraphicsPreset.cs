using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum ConsoleGraphicsPreset
{
	Unspecified = -1,
	Quality = 1,
	Performance = 2,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ConsoleGraphicsPreset>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static ConsoleGraphicsPreset()
	{
		Il2CppClassPointerStore<ConsoleGraphicsPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ConsoleGraphicsPreset");
	}

}
