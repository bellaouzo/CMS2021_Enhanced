using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace RuntimeSceneGizmo;

public enum GizmoComponent
{
	None = -1,
	Center,
	XNegative,
	XPositive,
	YNegative,
	YPositive,
	ZNegative,
	ZPositive,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GizmoComponent>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static GizmoComponent()
	{
		Il2CppClassPointerStore<GizmoComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "RuntimeSceneGizmo", "GizmoComponent");
	}

}
