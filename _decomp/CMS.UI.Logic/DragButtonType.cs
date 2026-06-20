using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum DragButtonType : byte
{
	Practice,
	QuickRace,
	SingleRace,
	Championship,
	QuarterMile,
	HalfMile,
	OneMile,
	EightMile,
	ClassA,
	ClassB,
	ClassC,
	ClassD,
	ClassE,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragButtonType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static DragButtonType()
	{
		Il2CppClassPointerStore<DragButtonType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "DragButtonType");
	}

}
