using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI;

public enum WindowID
{
	AskWindow,
	CarInfo,
	CarLocationWindow,
	CarVersion,
	CaseOpening,
	InfoWindow,
	Inventory,
	Orders,
	LampAlignment,
	PauseQuit,
	PieMenu,
	Radio,
	Map,
	Sorting,
	WheelsAlignment,
	BrakeLathe,
	ChoosePartUp,
	RepairPart,
	Shop,
	ShopBuy,
	Showroom,
	Paintshop,
	DLC,
	Settings,
	Extras,
	NewSaveWindow,
	SaveDetails,
	Warehouse,
	WarehouseChange,
	Tutorials,
	PartInspector,
	SellPerCondition,
	ExamineReport,
	InputWindow,
	DLCError,
	Changelog,
	Tutorial,
	Photo,
	PathTest,
	Dyno,
	ItemsExchange,
	Scrap,
	GarageCustomization,
	ShopList,
	Upgrades,
	ShopLicenseBuy,
	ParkingManagement,
	WheelBalance,
	CreateEngine,
	TakenItems,
	Benchmark,
	Parking,
	ChooseEngine,
	SalonSelectCar,
	SalonWizard,
	Auction,
	Tune,
	DemoIntro,
	DemoOutro,
	TutorialEnd,
	InstallingWindow,
	Intro,
	RevertBackup,
	ConsolePreset,
	Tinting,
	Drag,
	DragRaceInfo,
	DragResults,
	DragInfo,
	DragChampionshipLadder,
	ScrapPerCondition,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WindowID>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static WindowID()
	{
		Il2CppClassPointerStore<WindowID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI", "WindowID");
	}

}
