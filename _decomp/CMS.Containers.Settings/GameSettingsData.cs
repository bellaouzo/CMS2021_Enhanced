using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers.Settings;

[StructLayout(LayoutKind.Explicit)]
public struct GameSettingsData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CameraSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_CursorSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvertInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoZoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnrealisticWheelsSizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_TravelHaveCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_MetricUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_ControllerAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarSteeringSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConsoleGraphicsPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarsSpawnEverywhere;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseFadeForDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearboxMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShowFriends;

	private static readonly System.IntPtr NativeFieldInfoPtr_FieldOfView;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	[FieldOffset(0)]
	public float CameraSensitivity;

	[FieldOffset(4)]
	public float CursorSensitivity;

	[FieldOffset(8)]
	public bool InvertInput;

	[FieldOffset(9)]
	public bool AutoZoom;

	[FieldOffset(10)]
	public bool UnrealisticWheelsSizes;

	[FieldOffset(11)]
	public bool TravelHaveCost;

	[FieldOffset(12)]
	public bool MetricUnits;

	[FieldOffset(13)]
	public bool ControllerAcceleration;

	[FieldOffset(16)]
	public float CarSteeringSensitivity;

	[FieldOffset(20)]
	public ConsoleGraphicsPreset ConsoleGraphicsPreset;

	[FieldOffset(24)]
	public bool CarsSpawnEverywhere;

	[FieldOffset(25)]
	public bool UseFadeForDoors;

	[FieldOffset(26)]
	public bool EnableEvents;

	[FieldOffset(27)]
	public GearboxMode GearboxMode;

	[FieldOffset(28)]
	public bool ShowFriends;

	[FieldOffset(29)]
	public byte FieldOfView;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe void Init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameSettingsData()
	{
		Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers.Settings", "GameSettingsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr);
		NativeFieldInfoPtr_CameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "CameraSensitivity");
		NativeFieldInfoPtr_CursorSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "CursorSensitivity");
		NativeFieldInfoPtr_InvertInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "InvertInput");
		NativeFieldInfoPtr_AutoZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "AutoZoom");
		NativeFieldInfoPtr_UnrealisticWheelsSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "UnrealisticWheelsSizes");
		NativeFieldInfoPtr_TravelHaveCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "TravelHaveCost");
		NativeFieldInfoPtr_MetricUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "MetricUnits");
		NativeFieldInfoPtr_ControllerAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "ControllerAcceleration");
		NativeFieldInfoPtr_CarSteeringSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "CarSteeringSensitivity");
		NativeFieldInfoPtr_ConsoleGraphicsPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "ConsoleGraphicsPreset");
		NativeFieldInfoPtr_CarsSpawnEverywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "CarsSpawnEverywhere");
		NativeFieldInfoPtr_UseFadeForDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "UseFadeForDoors");
		NativeFieldInfoPtr_EnableEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "EnableEvents");
		NativeFieldInfoPtr_GearboxMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "GearboxMode");
		NativeFieldInfoPtr_ShowFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "ShowFriends");
		NativeFieldInfoPtr_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, "FieldOfView");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, 100679817);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameSettingsData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
