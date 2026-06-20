using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

[System.Flags]
public enum NavigationFeatures : byte
{
	None = 0,
	CanSelectItem = 1,
	CanDeselectItem = 2,
	CanHandleInput = 4,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavigationFeatures>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static NavigationFeatures()
	{
		Il2CppClassPointerStore<NavigationFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "NavigationFeatures");
	}

}
