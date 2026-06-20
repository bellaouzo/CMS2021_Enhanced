using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum TuneWindowTabs
{
	Gearbox,
	Ecu,
	Carb1,
	Carb2,
	Carb3,
	Carb4,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TuneWindowTabs>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static TuneWindowTabs()
	{
		Il2CppClassPointerStore<TuneWindowTabs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "TuneWindowTabs");
	}

}
