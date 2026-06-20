using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum SettingsTabs
{
	Video,
	Controls,
	Audio,
	Language,
	Game,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SettingsTabs>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static SettingsTabs()
	{
		Il2CppClassPointerStore<SettingsTabs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "SettingsTabs");
	}

}
