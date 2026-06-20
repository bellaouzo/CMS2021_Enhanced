using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum CaseCardType
{
	CR,
	XP,
	Scrap,
	Case,
	Map,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CaseCardType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static CaseCardType()
	{
		Il2CppClassPointerStore<CaseCardType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CaseCardType");
	}

}
