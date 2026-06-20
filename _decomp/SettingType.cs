using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum SettingType : ushort
{
	Resolution,
	Quality,
	Language,
	TextureResolution,
	Shadow,
	MeshDetails,
	Units,
	Vsync,
	Fullscreen,
	Zoom,
	AA,
	Bloom,
	SSR,
	MotionBlur,
	SSAO,
	Vignette,
	GameVolume,
	MusicVolume,
	AmbientSound,
	ChromaticAberration,
	RebindVerticalPositive,
	RebindVerticalNegative,
	RebindHorizontalPositive,
	RebindHorizontalNegative,
	RebindExitFromMechanic,
	RebindCrouch,
	RebindBackCameraMechanic,
	RebindForwardCameraMechanic,
	RebindShowTablet,
	RebindInventory,
	RebindUIEnter,
	RebindSpecial,
	RebindHandbrakeCar,
	CameraSensitivity,
	ControllerAcceleration,
	InvertInput,
	UnrealisticWheelsSizes,
	TravelHaveCost,
	CarSteeringSensitivity,
	ConsoleMode,
	VolumetricLighting,
	SubsurfaceScattering,
	ShadowMapResolution,
	VegetationDetails,
	ContactShadows,
	CloudShadows,
	RebindMap,
	RebindShoppingList,
	RebindFlashlight,
	RebindMinigames,
	RebindOrders,
	RebindOpenShopList,
	HeatHaze,
	CursorSensitivity,
	GraphicsPreset,
	CarsSpawnEverywhere,
	UseFadeForDoors,
	EnableEvents,
	FpsCap,
	GearboxMode,
	RebindGearUp,
	RebindGearDown,
	RebindToggleECS,
	RebindToggleTCS,
	ShowFriends,
	FieldOfView,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SettingType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static SettingType()
	{
		Il2CppClassPointerStore<SettingType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SettingType");
	}

}
