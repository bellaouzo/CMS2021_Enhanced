using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.ScriptableObjects;

[System.Flags]
public enum VisibilityFlags
{
	None = 0,
	PC = 1,
	Xbox = 2,
	Playstation = 4,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VisibilityFlags>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static VisibilityFlags()
	{
		Il2CppClassPointerStore<VisibilityFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ScriptableObjects", "VisibilityFlags");
	}

}
