using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum DescriptionVariant
{
	Default,
	Mission,
	Job,
	Paint,
	Livery,
	Select,
	Changelog,
	Back,
	Reset,
	Search,
	SelectPaint,
	Repair,
	Cancel,
	AlternativeAction,
	Unlock,
	AlternativeBack,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DescriptionVariant>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static DescriptionVariant()
	{
		Il2CppClassPointerStore<DescriptionVariant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "DescriptionVariant");
	}

}
