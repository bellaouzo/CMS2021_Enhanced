using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace UnityEngine.UI.Extensions;

public enum GradientMode
{
	Global,
	Local,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GradientMode>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static GradientMode()
	{
		Il2CppClassPointerStore<GradientMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "GradientMode");
	}

}
