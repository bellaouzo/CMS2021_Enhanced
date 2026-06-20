using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum InventoryCategories
{
	All,
	Engine,
	Suspension,
	Brakes,
	Exhaust,
	Gearbox,
	Body,
	Rims,
	Group,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InventoryCategories>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static InventoryCategories()
	{
		Il2CppClassPointerStore<InventoryCategories>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "InventoryCategories");
	}

}
