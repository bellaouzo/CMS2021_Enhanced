using System;
using System.Runtime.CompilerServices;
using CMS.Containers.Settings;
using CMS.UI.Logic;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class GameSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_buildVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_AppIdDemo;

	private static readonly System.IntPtr NativeFieldInfoPtr_AppIdPrologue;

	private static readonly System.IntPtr NativeFieldInfoPtr_AppIDNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_AppID;

	private static readonly System.IntPtr NativeFieldInfoPtr_VideoSettingsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameSettingsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_AudioSettingsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_LanguageSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_gfx_noVideo;

	private static readonly System.IntPtr NativeFieldInfoPtr_WrongResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkipPartsAwake;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoNotUnloadAssets;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoNotClearPartsIDCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableMouseEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_MouseLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_MouseLookSmoothSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_MouseLookSmoothWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_MouseLookAccelerationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFPS_MouseLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFPS_MouseLookSmoothSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFPS_MouseLookSmoothWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFPS_MouseLookAccelerationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_KeyboardLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_KeyboardLookSmoothSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_KeyboardLookSmoothWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_KeyboardLookInvert;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConsoleMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_LegacyConsoleMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_RunningOnSteamDeck;

	private static readonly System.IntPtr NativeFieldInfoPtr_RunningInBigPictureMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionForceMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanShowCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanGenerateOrders;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanShowPopups;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlimitedBarns;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlimitedMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlimitedScraps;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCarsAmountInGarage;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCarsPerParkingFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxModCarsFromDirectory;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxParkingLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCarsAmountInParking;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLastColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxWarehouseNameLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCReleaseDayChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCReleaseDayPeriod;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragOpponentTimeout;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BuildVersion_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BuildVersion_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delta_Public_Static_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameSettings>.NativeClassPtr));

	public unsafe static string m_buildVersion
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_buildVersion, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_buildVersion, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static uint AppIdDemo
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppIdDemo, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppIdDemo, &num);
		}
	}

	public unsafe static uint AppIdPrologue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppIdPrologue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppIdPrologue, &num);
		}
	}

	public unsafe static uint AppIDNormal
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppIDNormal, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppIDNormal, &num);
		}
	}

	public unsafe static uint AppID
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppID, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppID, &num);
		}
	}

	public unsafe static VideoSettingsData VideoSettingsData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out VideoSettingsData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VideoSettingsData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VideoSettingsData, &videoSettingsData);
		}
	}

	public unsafe static GameSettingsData GameSettingsData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out GameSettingsData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameSettingsData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameSettingsData, &gameSettingsData);
		}
	}

	public unsafe static AudioSettingsData AudioSettingsData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out AudioSettingsData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AudioSettingsData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AudioSettingsData, &audioSettingsData);
		}
	}

	public unsafe static string LanguageSettings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LanguageSettings, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LanguageSettings, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static bool gfx_noVideo
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gfx_noVideo, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gfx_noVideo, &flag);
		}
	}

	public unsafe static bool WrongResolution
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WrongResolution, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WrongResolution, &flag);
		}
	}

	public unsafe static bool SkipPartsAwake
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkipPartsAwake, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkipPartsAwake, &flag);
		}
	}

	public unsafe static bool DoNotUnloadAssets
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoNotUnloadAssets, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoNotUnloadAssets, &flag);
		}
	}

	public unsafe static bool DoNotClearPartsIDCache
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DoNotClearPartsIDCache, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DoNotClearPartsIDCache, &flag);
		}
	}

	public unsafe static bool DisableMouseEvents
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisableMouseEvents, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisableMouseEvents, &flag);
		}
	}

	public unsafe static Vector2 input_MouseLookSensitivity
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_MouseLookSensitivity, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_MouseLookSensitivity, &vector);
		}
	}

	public unsafe static int input_MouseLookSmoothSteps
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_MouseLookSmoothSteps, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_MouseLookSmoothSteps, &num);
		}
	}

	public unsafe static float input_MouseLookSmoothWeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_MouseLookSmoothWeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_MouseLookSmoothWeight, &num);
		}
	}

	public unsafe static float input_MouseLookAccelerationThreshold
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_MouseLookAccelerationThreshold, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_MouseLookAccelerationThreshold, &num);
		}
	}

	public unsafe static Vector2 inputFPS_MouseLookSensitivity
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputFPS_MouseLookSensitivity, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputFPS_MouseLookSensitivity, &vector);
		}
	}

	public unsafe static int inputFPS_MouseLookSmoothSteps
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputFPS_MouseLookSmoothSteps, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputFPS_MouseLookSmoothSteps, &num);
		}
	}

	public unsafe static float inputFPS_MouseLookSmoothWeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputFPS_MouseLookSmoothWeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputFPS_MouseLookSmoothWeight, &num);
		}
	}

	public unsafe static float inputFPS_MouseLookAccelerationThreshold
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputFPS_MouseLookAccelerationThreshold, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputFPS_MouseLookAccelerationThreshold, &num);
		}
	}

	public unsafe static Vector2 input_KeyboardLookSensitivity
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_KeyboardLookSensitivity, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_KeyboardLookSensitivity, &vector);
		}
	}

	public unsafe static int input_KeyboardLookSmoothSteps
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_KeyboardLookSmoothSteps, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_KeyboardLookSmoothSteps, &num);
		}
	}

	public unsafe static float input_KeyboardLookSmoothWeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_KeyboardLookSmoothWeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_KeyboardLookSmoothWeight, &num);
		}
	}

	public unsafe static bool input_KeyboardLookInvert
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_KeyboardLookInvert, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_KeyboardLookInvert, &flag);
		}
	}

	public unsafe static bool ConsoleMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConsoleMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConsoleMode, &flag);
		}
	}

	public unsafe static bool LegacyConsoleMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LegacyConsoleMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LegacyConsoleMode, &flag);
		}
	}

	public unsafe static bool RunningOnSteamDeck
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RunningOnSteamDeck, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RunningOnSteamDeck, &flag);
		}
	}

	public unsafe static bool RunningInBigPictureMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RunningInBigPictureMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RunningInBigPictureMode, &flag);
		}
	}

	public unsafe static DescriptionForceMode DescriptionForceMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out DescriptionForceMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DescriptionForceMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DescriptionForceMode, &descriptionForceMode);
		}
	}

	public unsafe static bool CanShowCursor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CanShowCursor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CanShowCursor, &flag);
		}
	}

	public unsafe static bool CanHighlight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CanHighlight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CanHighlight, &flag);
		}
	}

	public unsafe static bool CanGenerateOrders
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CanGenerateOrders, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CanGenerateOrders, &flag);
		}
	}

	public unsafe static bool CanShowPopups
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CanShowPopups, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CanShowPopups, &flag);
		}
	}

	public unsafe static bool UnlimitedBarns
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnlimitedBarns, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnlimitedBarns, &flag);
		}
	}

	public unsafe static bool UnlimitedMoney
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnlimitedMoney, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnlimitedMoney, &flag);
		}
	}

	public unsafe static bool UnlimitedScraps
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnlimitedScraps, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnlimitedScraps, &flag);
		}
	}

	public unsafe static int MaxCarsAmountInGarage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxCarsAmountInGarage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxCarsAmountInGarage, &num);
		}
	}

	public unsafe static int MaxCarsPerParkingFloor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxCarsPerParkingFloor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxCarsPerParkingFloor, &num);
		}
	}

	public unsafe static int MaxModCarsFromDirectory
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxModCarsFromDirectory, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxModCarsFromDirectory, &num);
		}
	}

	public unsafe static int MaxParkingLevels
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxParkingLevels, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxParkingLevels, &num);
		}
	}

	public unsafe static int MaxCarsAmountInParking
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxCarsAmountInParking, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxCarsAmountInParking, &num);
		}
	}

	public unsafe static int MaxLastColors
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxLastColors, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxLastColors, &num);
		}
	}

	public unsafe static int MaxWarehouseNameLength
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxWarehouseNameLength, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxWarehouseNameLength, &num);
		}
	}

	public unsafe static int DLCReleaseDayChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DLCReleaseDayChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DLCReleaseDayChance, &num);
		}
	}

	public unsafe static byte DLCReleaseDayPeriod
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DLCReleaseDayPeriod, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DLCReleaseDayPeriod, &b);
		}
	}

	public unsafe static float DragOpponentTimeout
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragOpponentTimeout, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragOpponentTimeout, &num);
		}
	}

	public unsafe static string BuildVersion
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 51136, RefRangeEnd = 51146, XrefRangeStart = 51118, XrefRangeEnd = 51136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BuildVersion_Public_Static_get_String_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51146, XrefRangeEnd = 51150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BuildVersion_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51152, RefRangeEnd = 51154, XrefRangeStart = 51150, XrefRangeEnd = 51152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Delta()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delta_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static GameSettings()
	{
		Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GameSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_buildVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "m_buildVersion");
		NativeFieldInfoPtr_AppIdDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "AppIdDemo");
		NativeFieldInfoPtr_AppIdPrologue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "AppIdPrologue");
		NativeFieldInfoPtr_AppIDNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "AppIDNormal");
		NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "AppID");
		NativeFieldInfoPtr_VideoSettingsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "VideoSettingsData");
		NativeFieldInfoPtr_GameSettingsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "GameSettingsData");
		NativeFieldInfoPtr_AudioSettingsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "AudioSettingsData");
		NativeFieldInfoPtr_LanguageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "LanguageSettings");
		NativeFieldInfoPtr_gfx_noVideo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "gfx_noVideo");
		NativeFieldInfoPtr_WrongResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "WrongResolution");
		NativeFieldInfoPtr_SkipPartsAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "SkipPartsAwake");
		NativeFieldInfoPtr_DoNotUnloadAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DoNotUnloadAssets");
		NativeFieldInfoPtr_DoNotClearPartsIDCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DoNotClearPartsIDCache");
		NativeFieldInfoPtr_DisableMouseEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DisableMouseEvents");
		NativeFieldInfoPtr_input_MouseLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_MouseLookSensitivity");
		NativeFieldInfoPtr_input_MouseLookSmoothSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_MouseLookSmoothSteps");
		NativeFieldInfoPtr_input_MouseLookSmoothWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_MouseLookSmoothWeight");
		NativeFieldInfoPtr_input_MouseLookAccelerationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_MouseLookAccelerationThreshold");
		NativeFieldInfoPtr_inputFPS_MouseLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "inputFPS_MouseLookSensitivity");
		NativeFieldInfoPtr_inputFPS_MouseLookSmoothSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "inputFPS_MouseLookSmoothSteps");
		NativeFieldInfoPtr_inputFPS_MouseLookSmoothWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "inputFPS_MouseLookSmoothWeight");
		NativeFieldInfoPtr_inputFPS_MouseLookAccelerationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "inputFPS_MouseLookAccelerationThreshold");
		NativeFieldInfoPtr_input_KeyboardLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_KeyboardLookSensitivity");
		NativeFieldInfoPtr_input_KeyboardLookSmoothSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_KeyboardLookSmoothSteps");
		NativeFieldInfoPtr_input_KeyboardLookSmoothWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_KeyboardLookSmoothWeight");
		NativeFieldInfoPtr_input_KeyboardLookInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "input_KeyboardLookInvert");
		NativeFieldInfoPtr_ConsoleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "ConsoleMode");
		NativeFieldInfoPtr_LegacyConsoleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "LegacyConsoleMode");
		NativeFieldInfoPtr_RunningOnSteamDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "RunningOnSteamDeck");
		NativeFieldInfoPtr_RunningInBigPictureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "RunningInBigPictureMode");
		NativeFieldInfoPtr_DescriptionForceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DescriptionForceMode");
		NativeFieldInfoPtr_CanShowCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "CanShowCursor");
		NativeFieldInfoPtr_CanHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "CanHighlight");
		NativeFieldInfoPtr_CanGenerateOrders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "CanGenerateOrders");
		NativeFieldInfoPtr_CanShowPopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "CanShowPopups");
		NativeFieldInfoPtr_UnlimitedBarns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "UnlimitedBarns");
		NativeFieldInfoPtr_UnlimitedMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "UnlimitedMoney");
		NativeFieldInfoPtr_UnlimitedScraps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "UnlimitedScraps");
		NativeFieldInfoPtr_MaxCarsAmountInGarage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxCarsAmountInGarage");
		NativeFieldInfoPtr_MaxCarsPerParkingFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxCarsPerParkingFloor");
		NativeFieldInfoPtr_MaxModCarsFromDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxModCarsFromDirectory");
		NativeFieldInfoPtr_MaxParkingLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxParkingLevels");
		NativeFieldInfoPtr_MaxCarsAmountInParking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxCarsAmountInParking");
		NativeFieldInfoPtr_MaxLastColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxLastColors");
		NativeFieldInfoPtr_MaxWarehouseNameLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "MaxWarehouseNameLength");
		NativeFieldInfoPtr_DLCReleaseDayChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DLCReleaseDayChance");
		NativeFieldInfoPtr_DLCReleaseDayPeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DLCReleaseDayPeriod");
		NativeFieldInfoPtr_DragOpponentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "DragOpponentTimeout");
		NativeMethodInfoPtr_get_BuildVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100666288);
		NativeMethodInfoPtr_set_BuildVersion_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100666289);
		NativeMethodInfoPtr_Delta_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100666290);
	}

	public GameSettings(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
