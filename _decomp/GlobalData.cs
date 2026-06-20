using System;
using System.Runtime.CompilerServices;
using CMS.Containers.Settings;
using CMS.UI;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class GlobalData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSaveVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_ValueNotExists;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExpertMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCarLightsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultLicensePlate;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_DemoMissionsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_StreamingInstallProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_XrayBodyNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_XrayBodyHide;

	private static readonly System.IntPtr NativeFieldInfoPtr_XrayPartNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_XrayPartHide;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempVideoSettingsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempGameSettingsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempAudioSettingsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempLanguageSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempConsoleMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_TempLegacyConsoleMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpdateGraphicsPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedResolutions;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedCarLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_TestToShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_TutorialToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_DestinationParkingLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_NewMileage;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanOpenPieMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomTrackPathToFolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomPhotoLocationPathToFolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhotoLocationToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameRunType;

	private static readonly System.IntPtr NativeFieldInfoPtr_JunkCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_EasyModeMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_SandboxModeMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCultureInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_SettingsManagedByPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_SettingsToDisableOnConsole;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinTabIconSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxTabIconSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinArrowSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxArrowSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinDotSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxDotSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinSmallArrowSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxSmallArrowSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinShopOptionArrowSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxShopOptionArrowSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinWheelDotSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxWheelDotSize;

	private static readonly System.IntPtr NativeFieldInfoPtr__xray;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ITEM_COLOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_PARTS_COLOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_3;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_4;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT;

	private static readonly System.IntPtr NativeFieldInfoPtr_COLOR_ORANGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_COLOR_GRAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPTION_UNLOCKED;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPTION_LOCKED;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostPaintPart;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostPaintCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostZeroOil;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostZeroFluid;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostWashCarInPaintshopAndTinting;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostTintWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_UseWelder;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_UseInteriorDetailingToolkit;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_BaseParkingLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_TravelBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_TravelJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_TravelAuction;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cost_DragDyno;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedParkingLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_WashFactorLvlToClean;

	private static readonly System.IntPtr NativeFieldInfoPtr_CommissionSalon;

	private static readonly System.IntPtr NativeFieldInfoPtr_CommissionJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_CommissionBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentCarJunkyardChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentCarBarnChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentCarAuctionChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentCarSalvageChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentCarOrderChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentPartJunkyardChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentPartBarnChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentPartAuctionChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentPartSalvageChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentPartOrderChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentValueJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentValueBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentValueAuction;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentValueSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentValueOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_DustCarSalvageChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DustValueSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionChanceToCompleteJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionChanceToCompleteBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionChanceToCompleteSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionMissingChanceJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionMissingChanceBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionMissingChanceSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionMissingPartsChanceJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionMissingPartsChanceBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionMissingPartsChanceSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissingPartsChanceSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissingPartsAmountSalvage;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityChanceBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality3ChanceBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityChanceJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality3ChanceJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxQualityBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxQualityJunkyard;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultScrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusScrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_BigBonusScrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevPlayerMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddMoneyAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerScraps;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevPlayerScraps;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddPlayerScrapsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevPlayerExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddExpAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentAddExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartingLevelInDemo;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartingLevelInPrologue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinLevelToBarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevPlayerLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_LevelCap;

	private static readonly System.IntPtr NativeFieldInfoPtr_Jobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevJobsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddJobsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionsFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMissionDone;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsStoryMissionInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr__barnsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality1BaseCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality2BaseCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality3BaseCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality1CostMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality2CostMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality3CostMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_TrackInteriorVolumeMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinEcuBarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxEcuBarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxEcuTuningValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinCarbBarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCarbBarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragBetValuesStage1;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragBetValuesStage2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragBetValuesStage3;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragBetValuesStage4;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragExceptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragEntryFeeA;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragEntryFeeB;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragEntryFeeC;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragEntryFeeD;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragEntryFeeE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDragConfigVersion;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetXray_Public_Static_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockedPositions_Public_Static_ArrayOf_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUnlockedPositions_Public_Static_Void_ArrayOf_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCommissionForScene_Public_Static_Int32_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScrapFromItem_Public_Static_Int32_Item_ScrapType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerMoney_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerMoney_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStartingMoney_Public_Static_Int32_DifficultyLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerScraps_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerScraps_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RealPlayerLevel_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerExp_Public_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentExp_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentExpToNextLevel_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCapToNextLvl_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiffToNextLvl_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddJob_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionID_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanRegenerateMission_Public_Static_Boolean_byref_List_1_Job_byref_List_1_Job_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BarnsAmount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BarnsAmount_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxParkingPlacesAmount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxOrdersAmount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOrderSlotUnlocked_Public_Static_Boolean_Int32_byref_OrderSlotLockReason_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettingsFor_Public_Static_ArrayOf_SettingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRebindKey_Public_Static_String_SettingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRebindKey_Public_Static_String_SettingType_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedResolution_Public_Static_Int32_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedSettingsFor_Public_Static_Int32_SettingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCostForScrapUpgrade_Public_Static_Int32_Int32_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GlobalData>.NativeClassPtr));

	public unsafe static byte CurrentSaveVersion
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentSaveVersion, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentSaveVersion, &b);
		}
	}

	public unsafe static int ValueNotExists
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ValueNotExists, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ValueNotExists, &num);
		}
	}

	public unsafe static bool ExpertMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpertMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpertMode, &flag);
		}
	}

	public unsafe static int MaxCarLightsAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxCarLightsAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxCarLightsAmount, &num);
		}
	}

	public unsafe static string DefaultLicensePlate
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultLicensePlate, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultLicensePlate, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static int CurrentYear
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentYear, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentYear, &num);
		}
	}

	public unsafe static int DemoMissionsCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DemoMissionsCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DemoMissionsCount, &num);
		}
	}

	public unsafe static uint StreamingInstallProgress
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StreamingInstallProgress, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StreamingInstallProgress, &num);
		}
	}

	public unsafe static float XrayBodyNormal
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XrayBodyNormal, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XrayBodyNormal, &num);
		}
	}

	public unsafe static float XrayBodyHide
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XrayBodyHide, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XrayBodyHide, &num);
		}
	}

	public unsafe static float XrayPartNormal
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XrayPartNormal, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XrayPartNormal, &num);
		}
	}

	public unsafe static float XrayPartHide
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XrayPartHide, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XrayPartHide, &num);
		}
	}

	public unsafe static VideoSettingsData TempVideoSettingsData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out VideoSettingsData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempVideoSettingsData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempVideoSettingsData, &videoSettingsData);
		}
	}

	public unsafe static GameSettingsData TempGameSettingsData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out GameSettingsData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempGameSettingsData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempGameSettingsData, &gameSettingsData);
		}
	}

	public unsafe static AudioSettingsData TempAudioSettingsData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out AudioSettingsData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempAudioSettingsData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempAudioSettingsData, &audioSettingsData);
		}
	}

	public unsafe static string TempLanguageSettings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempLanguageSettings, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempLanguageSettings, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static bool TempConsoleMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempConsoleMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempConsoleMode, &flag);
		}
	}

	public unsafe static bool TempLegacyConsoleMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempLegacyConsoleMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempLegacyConsoleMode, &flag);
		}
	}

	public unsafe static bool UpdateGraphicsPreset
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpdateGraphicsPreset, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpdateGraphicsPreset, &flag);
		}
	}

	public unsafe static List<string> cachedResolutions
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cachedResolutions, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new List<string>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cachedResolutions, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static string SelectedCarLoader
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelectedCarLoader, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelectedCarLoader, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string TestToShow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TestToShow, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TestToShow, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static int TutorialToLoad
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TutorialToLoad, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TutorialToLoad, &num);
		}
	}

	public unsafe static int DestinationParkingLevel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DestinationParkingLevel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DestinationParkingLevel, &num);
		}
	}

	public unsafe static int NewMileage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NewMileage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NewMileage, &num);
		}
	}

	public unsafe static bool CanOpenPieMenu
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CanOpenPieMenu, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CanOpenPieMenu, &flag);
		}
	}

	public unsafe static string CustomTrackPathToFolder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CustomTrackPathToFolder, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CustomTrackPathToFolder, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string CustomPhotoLocationPathToFolder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CustomPhotoLocationPathToFolder, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CustomPhotoLocationPathToFolder, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string PhotoLocationToLoad
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PhotoLocationToLoad, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PhotoLocationToLoad, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static GameRunType GameRunType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out GameRunType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameRunType, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameRunType, &gameRunType);
		}
	}

	public unsafe static float JunkCondition
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JunkCondition, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JunkCondition, &num);
		}
	}

	public unsafe static int EasyModeMoney
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EasyModeMoney, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EasyModeMoney, &num);
		}
	}

	public unsafe static int SandboxModeMoney
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SandboxModeMoney, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SandboxModeMoney, &num);
		}
	}

	public unsafe static CultureInfo DefaultCultureInfo
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultCultureInfo, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new CultureInfo(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultCultureInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<SettingType> SettingsManagedByPreset
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SettingsManagedByPreset, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<SettingType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SettingsManagedByPreset, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<SettingType> SettingsToDisableOnConsole
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SettingsToDisableOnConsole, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<SettingType>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SettingsToDisableOnConsole, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Vector2 MinTabIconSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinTabIconSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinTabIconSize, &vector);
		}
	}

	public unsafe static Vector2 MaxTabIconSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxTabIconSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxTabIconSize, &vector);
		}
	}

	public unsafe static Vector2 MinArrowSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinArrowSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinArrowSize, &vector);
		}
	}

	public unsafe static Vector2 MaxArrowSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxArrowSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxArrowSize, &vector);
		}
	}

	public unsafe static Vector2 MinDotSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinDotSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinDotSize, &vector);
		}
	}

	public unsafe static Vector2 MaxDotSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxDotSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxDotSize, &vector);
		}
	}

	public unsafe static Vector2 MinSmallArrowSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinSmallArrowSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinSmallArrowSize, &vector);
		}
	}

	public unsafe static Vector2 MaxSmallArrowSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxSmallArrowSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxSmallArrowSize, &vector);
		}
	}

	public unsafe static Vector2 MinShopOptionArrowSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinShopOptionArrowSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinShopOptionArrowSize, &vector);
		}
	}

	public unsafe static Vector2 MaxShopOptionArrowSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxShopOptionArrowSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxShopOptionArrowSize, &vector);
		}
	}

	public unsafe static Vector2 MinWheelDotSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinWheelDotSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinWheelDotSize, &vector);
		}
	}

	public unsafe static Vector2 MaxWheelDotSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxWheelDotSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxWheelDotSize, &vector);
		}
	}

	public unsafe static Material _xray
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__xray, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Material(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__xray, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<bool> unlockedPositions
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unlockedPositions, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unlockedPositions, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Color DEFAULT_ITEM_COLOR
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ITEM_COLOR, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ITEM_COLOR, &color);
		}
	}

	public unsafe static Color DEFAULT_PARTS_COLOR
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_PARTS_COLOR, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_PARTS_COLOR, &color);
		}
	}

	public unsafe static Color S_HIGHLIGHTCOLOR_1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_1, &color);
		}
	}

	public unsafe static Color S_HIGHLIGHTCOLOR_2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_2, &color);
		}
	}

	public unsafe static Color S_HIGHLIGHTCOLOR_3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_3, &color);
		}
	}

	public unsafe static Color S_HIGHLIGHTCOLOR_4
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_4, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_4, &color);
		}
	}

	public unsafe static Color DEFAULT
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT, &color);
		}
	}

	public unsafe static Color32 COLOR_ORANGE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color32 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COLOR_ORANGE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COLOR_ORANGE, &color);
		}
	}

	public unsafe static Color32 COLOR_GRAY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color32 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COLOR_GRAY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COLOR_GRAY, &color);
		}
	}

	public unsafe static Color32 OPTION_UNLOCKED
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color32 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPTION_UNLOCKED, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPTION_UNLOCKED, &color);
		}
	}

	public unsafe static Color32 OPTION_LOCKED
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color32 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPTION_LOCKED, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPTION_LOCKED, &color);
		}
	}

	public unsafe static ushort CostPaintPart
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostPaintPart, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostPaintPart, &num);
		}
	}

	public unsafe static ushort CostPaintCar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostPaintCar, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostPaintCar, &num);
		}
	}

	public unsafe static ushort CostZeroOil
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostZeroOil, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostZeroOil, &num);
		}
	}

	public unsafe static ushort CostZeroFluid
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostZeroFluid, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostZeroFluid, &num);
		}
	}

	public unsafe static ushort CostWashCarInPaintshopAndTinting
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostWashCarInPaintshopAndTinting, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostWashCarInPaintshopAndTinting, &num);
		}
	}

	public unsafe static ushort CostTintWindow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostTintWindow, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostTintWindow, &num);
		}
	}

	public unsafe static ushort Cost_UseWelder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_UseWelder, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_UseWelder, &num);
		}
	}

	public unsafe static ushort Cost_UseInteriorDetailingToolkit
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_UseInteriorDetailingToolkit, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_UseInteriorDetailingToolkit, &num);
		}
	}

	public unsafe static ushort Cost_BaseParkingLevel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_BaseParkingLevel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_BaseParkingLevel, &num);
		}
	}

	public unsafe static ushort Cost_TravelBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_TravelBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_TravelBarn, &num);
		}
	}

	public unsafe static ushort Cost_TravelJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_TravelJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_TravelJunkyard, &num);
		}
	}

	public unsafe static ushort Cost_TravelAuction
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_TravelAuction, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_TravelAuction, &num);
		}
	}

	public unsafe static ushort Cost_DragDyno
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cost_DragDyno, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cost_DragDyno, &num);
		}
	}

	public unsafe static int UnlockedParkingLevels
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnlockedParkingLevels, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnlockedParkingLevels, &num);
		}
	}

	public unsafe static float WashFactorLvlToClean
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WashFactorLvlToClean, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WashFactorLvlToClean, &num);
		}
	}

	public unsafe static int CommissionSalon
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CommissionSalon, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CommissionSalon, &num);
		}
	}

	public unsafe static int CommissionJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CommissionJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CommissionJunkyard, &num);
		}
	}

	public unsafe static int CommissionBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CommissionBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CommissionBarn, &num);
		}
	}

	public unsafe static Vector2 DentCarJunkyardChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentCarJunkyardChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentCarJunkyardChance, &vector);
		}
	}

	public unsafe static Vector2 DentCarBarnChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentCarBarnChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentCarBarnChance, &vector);
		}
	}

	public unsafe static Vector2 DentCarAuctionChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentCarAuctionChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentCarAuctionChance, &vector);
		}
	}

	public unsafe static Vector2 DentCarSalvageChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentCarSalvageChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentCarSalvageChance, &vector);
		}
	}

	public unsafe static Vector2 DentCarOrderChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentCarOrderChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentCarOrderChance, &vector);
		}
	}

	public unsafe static Vector2 DentPartJunkyardChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentPartJunkyardChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentPartJunkyardChance, &vector);
		}
	}

	public unsafe static Vector2 DentPartBarnChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentPartBarnChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentPartBarnChance, &vector);
		}
	}

	public unsafe static Vector2 DentPartAuctionChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentPartAuctionChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentPartAuctionChance, &vector);
		}
	}

	public unsafe static Vector2 DentPartSalvageChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentPartSalvageChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentPartSalvageChance, &vector);
		}
	}

	public unsafe static Vector2 DentPartOrderChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentPartOrderChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentPartOrderChance, &vector);
		}
	}

	public unsafe static Vector2 DentValueJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentValueJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentValueJunkyard, &vector);
		}
	}

	public unsafe static Vector2 DentValueBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentValueBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentValueBarn, &vector);
		}
	}

	public unsafe static Vector2 DentValueAuction
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentValueAuction, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentValueAuction, &vector);
		}
	}

	public unsafe static Vector2 DentValueSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentValueSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentValueSalvage, &vector);
		}
	}

	public unsafe static Vector2 DentValueOrder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DentValueOrder, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DentValueOrder, &vector);
		}
	}

	public unsafe static Vector2 DustCarSalvageChance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DustCarSalvageChance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DustCarSalvageChance, &vector);
		}
	}

	public unsafe static Vector2 DustValueSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DustValueSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DustValueSalvage, &vector);
		}
	}

	public unsafe static int SuspensionChanceToCompleteJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionChanceToCompleteJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionChanceToCompleteJunkyard, &num);
		}
	}

	public unsafe static int SuspensionChanceToCompleteBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionChanceToCompleteBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionChanceToCompleteBarn, &num);
		}
	}

	public unsafe static int SuspensionChanceToCompleteSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionChanceToCompleteSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionChanceToCompleteSalvage, &num);
		}
	}

	public unsafe static int SuspensionMissingChanceJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionMissingChanceJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionMissingChanceJunkyard, &num);
		}
	}

	public unsafe static int SuspensionMissingChanceBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionMissingChanceBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionMissingChanceBarn, &num);
		}
	}

	public unsafe static int SuspensionMissingChanceSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionMissingChanceSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionMissingChanceSalvage, &num);
		}
	}

	public unsafe static Vector2 SuspensionMissingPartsChanceJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionMissingPartsChanceJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionMissingPartsChanceJunkyard, &vector);
		}
	}

	public unsafe static Vector2 SuspensionMissingPartsChanceBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionMissingPartsChanceBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionMissingPartsChanceBarn, &vector);
		}
	}

	public unsafe static Vector2 SuspensionMissingPartsChanceSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuspensionMissingPartsChanceSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuspensionMissingPartsChanceSalvage, &vector);
		}
	}

	public unsafe static Vector2 MissingPartsChanceSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissingPartsChanceSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissingPartsChanceSalvage, &vector);
		}
	}

	public unsafe static Vector2 MissingPartsAmountSalvage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissingPartsAmountSalvage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissingPartsAmountSalvage, &vector);
		}
	}

	public unsafe static int QualityChanceBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityChanceBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityChanceBarn, &num);
		}
	}

	public unsafe static int Quality3ChanceBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality3ChanceBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality3ChanceBarn, &num);
		}
	}

	public unsafe static int QualityChanceJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityChanceJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityChanceJunkyard, &num);
		}
	}

	public unsafe static int Quality3ChanceJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality3ChanceJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality3ChanceJunkyard, &num);
		}
	}

	public unsafe static int MaxQualityBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxQualityBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxQualityBarn, &num);
		}
	}

	public unsafe static int MaxQualityJunkyard
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxQualityJunkyard, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxQualityJunkyard, &num);
		}
	}

	public unsafe static int DefaultScrap
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultScrap, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultScrap, &num);
		}
	}

	public unsafe static int BonusScrap
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BonusScrap, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BonusScrap, &num);
		}
	}

	public unsafe static int BigBonusScrap
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BigBonusScrap, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BigBonusScrap, &num);
		}
	}

	public unsafe static int PlayerMoney
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerMoney, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerMoney, &num);
		}
	}

	public unsafe static int PrevPlayerMoney
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrevPlayerMoney, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrevPlayerMoney, &num);
		}
	}

	public unsafe static int AddMoneyAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddMoneyAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddMoneyAmount, &num);
		}
	}

	public unsafe static int PlayerScraps
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerScraps, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerScraps, &num);
		}
	}

	public unsafe static int PrevPlayerScraps
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrevPlayerScraps, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrevPlayerScraps, &num);
		}
	}

	public unsafe static int AddPlayerScrapsAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddPlayerScrapsAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddPlayerScrapsAmount, &num);
		}
	}

	public unsafe static int PlayerExp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerExp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerExp, &num);
		}
	}

	public unsafe static int PrevPlayerExp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrevPlayerExp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrevPlayerExp, &num);
		}
	}

	public unsafe static int AddExpAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddExpAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddExpAmount, &num);
		}
	}

	public unsafe static int CurrentAddExp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentAddExp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentAddExp, &num);
		}
	}

	public unsafe static int PlayerLevel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerLevel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerLevel, &num);
		}
	}

	public unsafe static int StartingLevelInDemo
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartingLevelInDemo, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartingLevelInDemo, &num);
		}
	}

	public unsafe static int StartingLevelInPrologue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartingLevelInPrologue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartingLevelInPrologue, &num);
		}
	}

	public unsafe static int MinLevelToBarn
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinLevelToBarn, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinLevelToBarn, &num);
		}
	}

	public unsafe static int PrevPlayerLevel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrevPlayerLevel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrevPlayerLevel, &num);
		}
	}

	public unsafe static int LevelCap
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LevelCap, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LevelCap, &num);
		}
	}

	public unsafe static int Jobs
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Jobs, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Jobs, &num);
		}
	}

	public unsafe static int PrevJobsAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PrevJobsAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PrevJobsAmount, &num);
		}
	}

	public unsafe static int AddJobsAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddJobsAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddJobsAmount, &num);
		}
	}

	public unsafe static int MissionsFinished
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionsFinished, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionsFinished, &num);
		}
	}

	public unsafe static bool CurrentMissionDone
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentMissionDone, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentMissionDone, &flag);
		}
	}

	public unsafe static bool IsStoryMissionInProgress
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsStoryMissionInProgress, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsStoryMissionInProgress, &flag);
		}
	}

	public unsafe static int MissionsAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionsAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionsAmount, &num);
		}
	}

	public unsafe static int _barnsAmount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__barnsAmount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__barnsAmount, &num);
		}
	}

	public unsafe static int Quality1BaseCost
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality1BaseCost, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality1BaseCost, &num);
		}
	}

	public unsafe static int Quality2BaseCost
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality2BaseCost, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality2BaseCost, &num);
		}
	}

	public unsafe static int Quality3BaseCost
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality3BaseCost, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality3BaseCost, &num);
		}
	}

	public unsafe static int Quality1CostMultiplier
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality1CostMultiplier, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality1CostMultiplier, &num);
		}
	}

	public unsafe static int Quality2CostMultiplier
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality2CostMultiplier, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality2CostMultiplier, &num);
		}
	}

	public unsafe static int Quality3CostMultiplier
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Quality3CostMultiplier, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Quality3CostMultiplier, &num);
		}
	}

	public unsafe static float TrackInteriorVolumeMod
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TrackInteriorVolumeMod, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TrackInteriorVolumeMod, &num);
		}
	}

	public unsafe static short MinEcuBarValue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinEcuBarValue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinEcuBarValue, &num);
		}
	}

	public unsafe static short MaxEcuBarValue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxEcuBarValue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxEcuBarValue, &num);
		}
	}

	public unsafe static byte MaxEcuTuningValue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxEcuTuningValue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxEcuTuningValue, &b);
		}
	}

	public unsafe static short MinCarbBarValue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinCarbBarValue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinCarbBarValue, &num);
		}
	}

	public unsafe static short MaxCarbBarValue
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxCarbBarValue, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxCarbBarValue, &num);
		}
	}

	public unsafe static Il2CppStructArray<ushort> DragBetValuesStage1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragBetValuesStage1, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<ushort>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragBetValuesStage1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<ushort> DragBetValuesStage2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragBetValuesStage2, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<ushort>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragBetValuesStage2, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<ushort> DragBetValuesStage3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragBetValuesStage3, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<ushort>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragBetValuesStage3, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<ushort> DragBetValuesStage4
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragBetValuesStage4, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<ushort>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragBetValuesStage4, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<WindowID> DragExceptions
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragExceptions, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<WindowID>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragExceptions, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int DragEntryFeeA
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragEntryFeeA, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragEntryFeeA, &num);
		}
	}

	public unsafe static int DragEntryFeeB
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragEntryFeeB, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragEntryFeeB, &num);
		}
	}

	public unsafe static int DragEntryFeeC
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragEntryFeeC, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragEntryFeeC, &num);
		}
	}

	public unsafe static int DragEntryFeeD
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragEntryFeeD, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragEntryFeeD, &num);
		}
	}

	public unsafe static int DragEntryFeeE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragEntryFeeE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragEntryFeeE, &num);
		}
	}

	public unsafe static byte CurrentDragConfigVersion
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentDragConfigVersion, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentDragConfigVersion, &b);
		}
	}

	public unsafe static int RealPlayerLevel
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 51622, RefRangeEnd = 51627, XrefRangeStart = 51618, XrefRangeEnd = 51622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RealPlayerLevel_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static int BarnsAmount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51774, XrefRangeEnd = 51778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BarnsAmount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51788, RefRangeEnd = 51791, XrefRangeStart = 51778, XrefRangeEnd = 51788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BarnsAmount_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51460, RefRangeEnd = 51461, XrefRangeStart = 51433, XrefRangeEnd = 51460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material GetXray()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetXray_Public_Static_Material_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51461, XrefRangeEnd = 51476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<bool> GetUnlockedPositions()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnlockedPositions_Public_Static_ArrayOf_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51476, XrefRangeEnd = 51480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUnlockedPositions(Il2CppStructArray<bool> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUnlockedPositions_Public_Static_Void_ArrayOf_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static int GetCommissionForScene(SceneType sceneType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sceneType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCommissionForScene_Public_Static_Int32_SceneType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 51483, RefRangeEnd = 51486, XrefRangeStart = 51480, XrefRangeEnd = 51483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetScrapFromItem(Item item, ScrapType scrapType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(ScrapType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scrapType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScrapFromItem_Public_Static_Int32_Item_ScrapType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 51527, RefRangeEnd = 51555, XrefRangeStart = 51486, XrefRangeEnd = 51527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddPlayerMoney(int money)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&money);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerMoney_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51564, RefRangeEnd = 51568, XrefRangeStart = 51555, XrefRangeEnd = 51564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlayerMoney(int money)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&money);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerMoney_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static int GetStartingMoney(DifficultyLevel difficultyLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficultyLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStartingMoney_Public_Static_Int32_DifficultyLevel_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51605, RefRangeEnd = 51609, XrefRangeStart = 51568, XrefRangeEnd = 51605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddPlayerScraps(int amount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerScraps_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51609, XrefRangeEnd = 51618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlayerScraps(int scraps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scraps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerScraps_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 51702, RefRangeEnd = 51710, XrefRangeStart = 51627, XrefRangeEnd = 51702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddPlayerExp(int exp, bool instant = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&exp);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instant;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerExp_Public_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51710, XrefRangeEnd = 51714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCurrentExp(int level, int exp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exp;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentExp_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 51719, RefRangeEnd = 51722, XrefRangeStart = 51714, XrefRangeEnd = 51719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCurrentExpToNextLevel(int level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentExpToNextLevel_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51722, XrefRangeEnd = 51723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCapToNextLvl(int lvl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lvl);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCapToNextLvl_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51728, RefRangeEnd = 51729, XrefRangeStart = 51723, XrefRangeEnd = 51728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDiffToNextLvl(int lvl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lvl);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiffToNextLvl_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 51735, RefRangeEnd = 51738, XrefRangeStart = 51729, XrefRangeEnd = 51735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddJob(int amount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddJob_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 51750, RefRangeEnd = 51757, XrefRangeStart = 51738, XrefRangeEnd = 51750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMissionID()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionID_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51773, RefRangeEnd = 51774, XrefRangeStart = 51757, XrefRangeEnd = 51773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanRegenerateMission(ref List<Job> jobs, ref List<Job> selectedJob)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobs);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(selectedJob);
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanRegenerateMission_Public_Static_Boolean_byref_List_1_Job_byref_List_1_Job_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		jobs = (List<Job>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
		System.IntPtr intPtr4 = intPtr2;
		selectedJob = (List<Job>)(object)((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 51795, RefRangeEnd = 51798, XrefRangeStart = 51791, XrefRangeEnd = 51795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxParkingPlacesAmount()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxParkingPlacesAmount_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51821, RefRangeEnd = 51823, XrefRangeStart = 51798, XrefRangeEnd = 51821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Save()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51843, RefRangeEnd = 51847, XrefRangeStart = 51823, XrefRangeEnd = 51843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Load()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51855, RefRangeEnd = 51857, XrefRangeStart = 51847, XrefRangeEnd = 51855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxOrdersAmount()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxOrdersAmount_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51865, RefRangeEnd = 51866, XrefRangeStart = 51857, XrefRangeEnd = 51865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOrderSlotUnlocked(int orderIndex, out OrderSlotLockReason lockReason, out int levelCap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&orderIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref lockReason);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref levelCap);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOrderSlotUnlocked_Public_Static_Boolean_Int32_byref_OrderSlotLockReason_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 52202, RefRangeEnd = 52212, XrefRangeStart = 51866, XrefRangeEnd = 52202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetSettingsFor(SettingType settingType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settingType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSettingsFor_Public_Static_ArrayOf_SettingType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52212, XrefRangeEnd = 52224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRebindKey(SettingType settingType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settingType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRebindKey_Public_Static_String_SettingType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52251, RefRangeEnd = 52253, XrefRangeStart = 52224, XrefRangeEnd = 52251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRebindKey(SettingType settingType, InputManager inputManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&settingType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inputManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRebindKey_Public_Static_String_SettingType_InputManager_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52253, XrefRangeEnd = 52268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSelectedResolution(Il2CppStringArray resolutions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolutions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedResolution_Public_Static_Int32_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52547, RefRangeEnd = 52549, XrefRangeStart = 52268, XrefRangeEnd = 52547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSelectedSettingsFor(SettingType settingType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settingType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedSettingsFor_Public_Static_Int32_SettingType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52549, XrefRangeEnd = 52550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCostForScrapUpgrade(int targetQuality, int itemValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetQuality);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCostForScrapUpgrade_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static GlobalData()
	{
		Il2CppClassPointerStore<GlobalData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GlobalData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalData>.NativeClassPtr);
		NativeFieldInfoPtr_CurrentSaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CurrentSaveVersion");
		NativeFieldInfoPtr_ValueNotExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ValueNotExists");
		NativeFieldInfoPtr_ExpertMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "ExpertMode");
		NativeFieldInfoPtr_MaxCarLightsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxCarLightsAmount");
		NativeFieldInfoPtr_DefaultLicensePlate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DefaultLicensePlate");
		NativeFieldInfoPtr_CurrentYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CurrentYear");
		NativeFieldInfoPtr_DemoMissionsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DemoMissionsCount");
		NativeFieldInfoPtr_StreamingInstallProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "StreamingInstallProgress");
		NativeFieldInfoPtr_XrayBodyNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "XrayBodyNormal");
		NativeFieldInfoPtr_XrayBodyHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "XrayBodyHide");
		NativeFieldInfoPtr_XrayPartNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "XrayPartNormal");
		NativeFieldInfoPtr_XrayPartHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "XrayPartHide");
		NativeFieldInfoPtr_TempVideoSettingsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempVideoSettingsData");
		NativeFieldInfoPtr_TempGameSettingsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempGameSettingsData");
		NativeFieldInfoPtr_TempAudioSettingsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempAudioSettingsData");
		NativeFieldInfoPtr_TempLanguageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempLanguageSettings");
		NativeFieldInfoPtr_TempConsoleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempConsoleMode");
		NativeFieldInfoPtr_TempLegacyConsoleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TempLegacyConsoleMode");
		NativeFieldInfoPtr_UpdateGraphicsPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "UpdateGraphicsPreset");
		NativeFieldInfoPtr_cachedResolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "cachedResolutions");
		NativeFieldInfoPtr_SelectedCarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SelectedCarLoader");
		NativeFieldInfoPtr_TestToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TestToShow");
		NativeFieldInfoPtr_TutorialToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TutorialToLoad");
		NativeFieldInfoPtr_DestinationParkingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DestinationParkingLevel");
		NativeFieldInfoPtr_NewMileage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "NewMileage");
		NativeFieldInfoPtr_CanOpenPieMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CanOpenPieMenu");
		NativeFieldInfoPtr_CustomTrackPathToFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CustomTrackPathToFolder");
		NativeFieldInfoPtr_CustomPhotoLocationPathToFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CustomPhotoLocationPathToFolder");
		NativeFieldInfoPtr_PhotoLocationToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PhotoLocationToLoad");
		NativeFieldInfoPtr_GameRunType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "GameRunType");
		NativeFieldInfoPtr_JunkCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "JunkCondition");
		NativeFieldInfoPtr_EasyModeMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "EasyModeMoney");
		NativeFieldInfoPtr_SandboxModeMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SandboxModeMoney");
		NativeFieldInfoPtr_DefaultCultureInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DefaultCultureInfo");
		NativeFieldInfoPtr_SettingsManagedByPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SettingsManagedByPreset");
		NativeFieldInfoPtr_SettingsToDisableOnConsole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SettingsToDisableOnConsole");
		NativeFieldInfoPtr_MinTabIconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinTabIconSize");
		NativeFieldInfoPtr_MaxTabIconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxTabIconSize");
		NativeFieldInfoPtr_MinArrowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinArrowSize");
		NativeFieldInfoPtr_MaxArrowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxArrowSize");
		NativeFieldInfoPtr_MinDotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinDotSize");
		NativeFieldInfoPtr_MaxDotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxDotSize");
		NativeFieldInfoPtr_MinSmallArrowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinSmallArrowSize");
		NativeFieldInfoPtr_MaxSmallArrowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxSmallArrowSize");
		NativeFieldInfoPtr_MinShopOptionArrowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinShopOptionArrowSize");
		NativeFieldInfoPtr_MaxShopOptionArrowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxShopOptionArrowSize");
		NativeFieldInfoPtr_MinWheelDotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinWheelDotSize");
		NativeFieldInfoPtr_MaxWheelDotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxWheelDotSize");
		NativeFieldInfoPtr__xray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "_xray");
		NativeFieldInfoPtr_unlockedPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "unlockedPositions");
		NativeFieldInfoPtr_DEFAULT_ITEM_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DEFAULT_ITEM_COLOR");
		NativeFieldInfoPtr_DEFAULT_PARTS_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DEFAULT_PARTS_COLOR");
		NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "S_HIGHLIGHTCOLOR_1");
		NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "S_HIGHLIGHTCOLOR_2");
		NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "S_HIGHLIGHTCOLOR_3");
		NativeFieldInfoPtr_S_HIGHLIGHTCOLOR_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "S_HIGHLIGHTCOLOR_4");
		NativeFieldInfoPtr_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DEFAULT");
		NativeFieldInfoPtr_COLOR_ORANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "COLOR_ORANGE");
		NativeFieldInfoPtr_COLOR_GRAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "COLOR_GRAY");
		NativeFieldInfoPtr_OPTION_UNLOCKED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "OPTION_UNLOCKED");
		NativeFieldInfoPtr_OPTION_LOCKED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "OPTION_LOCKED");
		NativeFieldInfoPtr_CostPaintPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CostPaintPart");
		NativeFieldInfoPtr_CostPaintCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CostPaintCar");
		NativeFieldInfoPtr_CostZeroOil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CostZeroOil");
		NativeFieldInfoPtr_CostZeroFluid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CostZeroFluid");
		NativeFieldInfoPtr_CostWashCarInPaintshopAndTinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CostWashCarInPaintshopAndTinting");
		NativeFieldInfoPtr_CostTintWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CostTintWindow");
		NativeFieldInfoPtr_Cost_UseWelder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_UseWelder");
		NativeFieldInfoPtr_Cost_UseInteriorDetailingToolkit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_UseInteriorDetailingToolkit");
		NativeFieldInfoPtr_Cost_BaseParkingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_BaseParkingLevel");
		NativeFieldInfoPtr_Cost_TravelBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_TravelBarn");
		NativeFieldInfoPtr_Cost_TravelJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_TravelJunkyard");
		NativeFieldInfoPtr_Cost_TravelAuction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_TravelAuction");
		NativeFieldInfoPtr_Cost_DragDyno = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Cost_DragDyno");
		NativeFieldInfoPtr_UnlockedParkingLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "UnlockedParkingLevels");
		NativeFieldInfoPtr_WashFactorLvlToClean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "WashFactorLvlToClean");
		NativeFieldInfoPtr_CommissionSalon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CommissionSalon");
		NativeFieldInfoPtr_CommissionJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CommissionJunkyard");
		NativeFieldInfoPtr_CommissionBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CommissionBarn");
		NativeFieldInfoPtr_DentCarJunkyardChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentCarJunkyardChance");
		NativeFieldInfoPtr_DentCarBarnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentCarBarnChance");
		NativeFieldInfoPtr_DentCarAuctionChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentCarAuctionChance");
		NativeFieldInfoPtr_DentCarSalvageChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentCarSalvageChance");
		NativeFieldInfoPtr_DentCarOrderChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentCarOrderChance");
		NativeFieldInfoPtr_DentPartJunkyardChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentPartJunkyardChance");
		NativeFieldInfoPtr_DentPartBarnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentPartBarnChance");
		NativeFieldInfoPtr_DentPartAuctionChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentPartAuctionChance");
		NativeFieldInfoPtr_DentPartSalvageChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentPartSalvageChance");
		NativeFieldInfoPtr_DentPartOrderChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentPartOrderChance");
		NativeFieldInfoPtr_DentValueJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentValueJunkyard");
		NativeFieldInfoPtr_DentValueBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentValueBarn");
		NativeFieldInfoPtr_DentValueAuction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentValueAuction");
		NativeFieldInfoPtr_DentValueSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentValueSalvage");
		NativeFieldInfoPtr_DentValueOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DentValueOrder");
		NativeFieldInfoPtr_DustCarSalvageChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DustCarSalvageChance");
		NativeFieldInfoPtr_DustValueSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DustValueSalvage");
		NativeFieldInfoPtr_SuspensionChanceToCompleteJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionChanceToCompleteJunkyard");
		NativeFieldInfoPtr_SuspensionChanceToCompleteBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionChanceToCompleteBarn");
		NativeFieldInfoPtr_SuspensionChanceToCompleteSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionChanceToCompleteSalvage");
		NativeFieldInfoPtr_SuspensionMissingChanceJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionMissingChanceJunkyard");
		NativeFieldInfoPtr_SuspensionMissingChanceBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionMissingChanceBarn");
		NativeFieldInfoPtr_SuspensionMissingChanceSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionMissingChanceSalvage");
		NativeFieldInfoPtr_SuspensionMissingPartsChanceJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionMissingPartsChanceJunkyard");
		NativeFieldInfoPtr_SuspensionMissingPartsChanceBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionMissingPartsChanceBarn");
		NativeFieldInfoPtr_SuspensionMissingPartsChanceSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "SuspensionMissingPartsChanceSalvage");
		NativeFieldInfoPtr_MissingPartsChanceSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MissingPartsChanceSalvage");
		NativeFieldInfoPtr_MissingPartsAmountSalvage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MissingPartsAmountSalvage");
		NativeFieldInfoPtr_QualityChanceBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "QualityChanceBarn");
		NativeFieldInfoPtr_Quality3ChanceBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality3ChanceBarn");
		NativeFieldInfoPtr_QualityChanceJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "QualityChanceJunkyard");
		NativeFieldInfoPtr_Quality3ChanceJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality3ChanceJunkyard");
		NativeFieldInfoPtr_MaxQualityBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxQualityBarn");
		NativeFieldInfoPtr_MaxQualityJunkyard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxQualityJunkyard");
		NativeFieldInfoPtr_DefaultScrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DefaultScrap");
		NativeFieldInfoPtr_BonusScrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BonusScrap");
		NativeFieldInfoPtr_BigBonusScrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "BigBonusScrap");
		NativeFieldInfoPtr_PlayerMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayerMoney");
		NativeFieldInfoPtr_PrevPlayerMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PrevPlayerMoney");
		NativeFieldInfoPtr_AddMoneyAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AddMoneyAmount");
		NativeFieldInfoPtr_PlayerScraps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayerScraps");
		NativeFieldInfoPtr_PrevPlayerScraps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PrevPlayerScraps");
		NativeFieldInfoPtr_AddPlayerScrapsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AddPlayerScrapsAmount");
		NativeFieldInfoPtr_PlayerExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayerExp");
		NativeFieldInfoPtr_PrevPlayerExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PrevPlayerExp");
		NativeFieldInfoPtr_AddExpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AddExpAmount");
		NativeFieldInfoPtr_CurrentAddExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CurrentAddExp");
		NativeFieldInfoPtr_PlayerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PlayerLevel");
		NativeFieldInfoPtr_StartingLevelInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "StartingLevelInDemo");
		NativeFieldInfoPtr_StartingLevelInPrologue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "StartingLevelInPrologue");
		NativeFieldInfoPtr_MinLevelToBarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinLevelToBarn");
		NativeFieldInfoPtr_PrevPlayerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PrevPlayerLevel");
		NativeFieldInfoPtr_LevelCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "LevelCap");
		NativeFieldInfoPtr_Jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Jobs");
		NativeFieldInfoPtr_PrevJobsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "PrevJobsAmount");
		NativeFieldInfoPtr_AddJobsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "AddJobsAmount");
		NativeFieldInfoPtr_MissionsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MissionsFinished");
		NativeFieldInfoPtr_CurrentMissionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CurrentMissionDone");
		NativeFieldInfoPtr_IsStoryMissionInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "IsStoryMissionInProgress");
		NativeFieldInfoPtr_MissionsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MissionsAmount");
		NativeFieldInfoPtr__barnsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "_barnsAmount");
		NativeFieldInfoPtr_Quality1BaseCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality1BaseCost");
		NativeFieldInfoPtr_Quality2BaseCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality2BaseCost");
		NativeFieldInfoPtr_Quality3BaseCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality3BaseCost");
		NativeFieldInfoPtr_Quality1CostMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality1CostMultiplier");
		NativeFieldInfoPtr_Quality2CostMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality2CostMultiplier");
		NativeFieldInfoPtr_Quality3CostMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "Quality3CostMultiplier");
		NativeFieldInfoPtr_TrackInteriorVolumeMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "TrackInteriorVolumeMod");
		NativeFieldInfoPtr_MinEcuBarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinEcuBarValue");
		NativeFieldInfoPtr_MaxEcuBarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxEcuBarValue");
		NativeFieldInfoPtr_MaxEcuTuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxEcuTuningValue");
		NativeFieldInfoPtr_MinCarbBarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MinCarbBarValue");
		NativeFieldInfoPtr_MaxCarbBarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "MaxCarbBarValue");
		NativeFieldInfoPtr_DragBetValuesStage1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragBetValuesStage1");
		NativeFieldInfoPtr_DragBetValuesStage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragBetValuesStage2");
		NativeFieldInfoPtr_DragBetValuesStage3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragBetValuesStage3");
		NativeFieldInfoPtr_DragBetValuesStage4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragBetValuesStage4");
		NativeFieldInfoPtr_DragExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragExceptions");
		NativeFieldInfoPtr_DragEntryFeeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragEntryFeeA");
		NativeFieldInfoPtr_DragEntryFeeB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragEntryFeeB");
		NativeFieldInfoPtr_DragEntryFeeC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragEntryFeeC");
		NativeFieldInfoPtr_DragEntryFeeD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragEntryFeeD");
		NativeFieldInfoPtr_DragEntryFeeE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "DragEntryFeeE");
		NativeFieldInfoPtr_CurrentDragConfigVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, "CurrentDragConfigVersion");
		NativeMethodInfoPtr_GetXray_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666322);
		NativeMethodInfoPtr_GetUnlockedPositions_Public_Static_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666323);
		NativeMethodInfoPtr_SetUnlockedPositions_Public_Static_Void_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666324);
		NativeMethodInfoPtr_GetCommissionForScene_Public_Static_Int32_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666325);
		NativeMethodInfoPtr_GetScrapFromItem_Public_Static_Int32_Item_ScrapType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666326);
		NativeMethodInfoPtr_AddPlayerMoney_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666327);
		NativeMethodInfoPtr_SetPlayerMoney_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666328);
		NativeMethodInfoPtr_GetStartingMoney_Public_Static_Int32_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666329);
		NativeMethodInfoPtr_AddPlayerScraps_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666330);
		NativeMethodInfoPtr_SetPlayerScraps_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666331);
		NativeMethodInfoPtr_get_RealPlayerLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666332);
		NativeMethodInfoPtr_AddPlayerExp_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666333);
		NativeMethodInfoPtr_GetCurrentExp_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666334);
		NativeMethodInfoPtr_GetCurrentExpToNextLevel_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666335);
		NativeMethodInfoPtr_GetCapToNextLvl_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666336);
		NativeMethodInfoPtr_GetDiffToNextLvl_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666337);
		NativeMethodInfoPtr_AddJob_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666338);
		NativeMethodInfoPtr_GetMissionID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666339);
		NativeMethodInfoPtr_CanRegenerateMission_Public_Static_Boolean_byref_List_1_Job_byref_List_1_Job_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666340);
		NativeMethodInfoPtr_get_BarnsAmount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_set_BarnsAmount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_GetMaxParkingPlacesAmount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666343);
		NativeMethodInfoPtr_Save_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_Load_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr_GetMaxOrdersAmount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr_IsOrderSlotUnlocked_Public_Static_Boolean_Int32_byref_OrderSlotLockReason_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr_GetSettingsFor_Public_Static_ArrayOf_SettingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_GetRebindKey_Public_Static_String_SettingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr_GetRebindKey_Public_Static_String_SettingType_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_GetSelectedResolution_Public_Static_Int32_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_GetSelectedSettingsFor_Public_Static_Int32_SettingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_GetCostForScrapUpgrade_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalData>.NativeClassPtr, 100666353);
	}

	public GlobalData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
