using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum TopMenuMode
{
	Inventory,
	CarInfo,
	Orders,
	LampAlignment,
	WheelsAlignment,
	RepairPart,
	ShopParts,
	ShopBody,
	Showroom,
	Paintshop,
	Settings,
	Radio,
	Warehouse,
	ShopCar,
	Tutorial,
	ExamineReport,
	Extras,
	Scrap,
	ItemsExchange,
	Dyno,
	Upgrades,
	WheelBalance,
	Parking,
	TakenItems,
	Salon,
	Tune,
	Tinting,
	None,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TopMenuMode>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static TopMenuMode()
	{
		Il2CppClassPointerStore<TopMenuMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "TopMenuMode");
	}

}
