using System;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Serializable]
public enum GraphicsQuality
{
	Low,
	Medium,
	High,
	Ultra,
	Custom,
	Playstation,
	Xbox,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphicsQuality>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static GraphicsQuality()
	{
		Il2CppClassPointerStore<GraphicsQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GraphicsQuality");
	}

}
