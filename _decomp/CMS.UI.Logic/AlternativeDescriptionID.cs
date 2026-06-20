using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

public enum AlternativeDescriptionID
{
	MainMenu,
	Dummy,
	ClickUse,
	ClickUseHoldTakeOff,
	HoldTakeOff,
	ClickSitDown,
	ClickExamine,
	ClickExamineConsole,
	HoldToSearch,
	ClickMoveHoldTakeOff,
	ClickWorkOn,
	HoldMove,
	ClickMoveHoldMount,
	ClickExit,
	ClickChangeCamera,
	ClickClose,
	ClickChangeCameraAcceptExit,
	HoldMount,
	HoldExamine,
	PartUnmount,
	PieMenu,
	BoltsUnscrew,
	BoltsTighten,
	OptionWindow,
	Parking,
	GarageDisassemble,
	FillOil,
	Bayonet,
	Interior,
	InteriorShowroom,
	PathTestBrake,
	PathTestThrottle,
	Showroom,
	RunDyno,
	Track,
	LowerLifter,
	HoldTakeOffTutorial,
	ClickMoveHoldTakeOffTutorial,
	ClickUseHoldTakeOffTutorial,
	ClickMoveHoldMountTutorial,
	Drain,
	Error,
	Drag,
	None,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AlternativeDescriptionID>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static AlternativeDescriptionID()
	{
		Il2CppClassPointerStore<AlternativeDescriptionID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "AlternativeDescriptionID");
	}

}
