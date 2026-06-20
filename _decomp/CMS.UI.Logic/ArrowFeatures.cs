using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

[System.Flags]
public enum ArrowFeatures : byte
{
	None = 0,
	ResizeOnHover = 1,
	Sounds = 2,
	Colors = 4,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrowFeatures>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static ArrowFeatures()
	{
		Il2CppClassPointerStore<ArrowFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "ArrowFeatures");
	}

}
