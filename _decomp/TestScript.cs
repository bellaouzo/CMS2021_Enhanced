using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class TestScript : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stressLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsInputController;

	private static readonly System.IntPtr NativeFieldInfoPtr_calcValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_FlyCamEnabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMoney_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMoney_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddExp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddScraps_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBarn_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchConsoleMode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogMissingKeys_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugLevelCap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameSettingsDebug_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItemsToRepair_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBodyItemsToRepair_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLastItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearInventory_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastMountMode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAllUpgrades_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockAllUpgrades_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAllParkingLevels_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillParkingPlaces_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllCarsFromParking_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockAllParkingLevels_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunInBackground_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowPartsID_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipMissionCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Teleport_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lock_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementStat_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearStat_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleFlyCam_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAllTuningParts_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAllTuningBodyParts_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreePlacesCount_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TestScript>.NativeClassPtr));

	public unsafe int stressLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stressLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stressLevel)) = num;
		}
	}

	public unsafe int itemsAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsAmount)) = num;
		}
	}

	public unsafe FPSInputController fpsInputController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsInputController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new FPSInputController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsInputController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float calcValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcValue)) = num;
		}
	}

	public unsafe static bool FlyCamEnabled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FlyCamEnabled, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FlyCamEnabled, &flag);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85666, XrefRangeEnd = 85670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMoney()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMoney_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85670, XrefRangeEnd = 85674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveMoney()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMoney_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85674, XrefRangeEnd = 85678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddExp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85678, XrefRangeEnd = 85682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddScraps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddScraps_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85682, XrefRangeEnd = 85687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBarn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBarn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85687, XrefRangeEnd = 85691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchConsoleMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchConsoleMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85691, XrefRangeEnd = 85695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogMissingKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogMissingKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85695, XrefRangeEnd = 85721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugLevelCap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugLevelCap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85721, XrefRangeEnd = 85729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameSettingsDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameSettingsDebug_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85729, XrefRangeEnd = 85742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85742, XrefRangeEnd = 85755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddItemsToRepair()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItemsToRepair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85755, XrefRangeEnd = 85768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBodyItemsToRepair()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBodyItemsToRepair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85768, XrefRangeEnd = 85789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLastItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLastItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85789, XrefRangeEnd = 85797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85797, XrefRangeEnd = 85810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FastMountMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastMountMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85810, XrefRangeEnd = 85819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAllUpgrades()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAllUpgrades_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85819, XrefRangeEnd = 85828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockAllUpgrades()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockAllUpgrades_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85828, XrefRangeEnd = 85832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAllParkingLevels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAllParkingLevels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85832, XrefRangeEnd = 85841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillParkingPlaces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillParkingPlaces_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85841, XrefRangeEnd = 85852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllCarsFromParking()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllCarsFromParking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85852, XrefRangeEnd = 85856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockAllParkingLevels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockAllParkingLevels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85856, XrefRangeEnd = 85864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunInBackground()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunInBackground_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85864, XrefRangeEnd = 85868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowPartsID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPartsID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85868, XrefRangeEnd = 85872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipMissionCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipMissionCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85872, XrefRangeEnd = 85888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Teleport(string destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(destination);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Teleport_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85888, XrefRangeEnd = 85914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unlock(string achievementID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unlock_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85914, XrefRangeEnd = 85922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Lock(string achievementID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lock_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85922, XrefRangeEnd = 85930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementStat(string statID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementStat_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85930, XrefRangeEnd = 85938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearStat(string statID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(statID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearStat_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85938, XrefRangeEnd = 85946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85946, XrefRangeEnd = 86029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleFlyCam()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleFlyCam_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86029, XrefRangeEnd = 86059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAllTuningParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAllTuningParts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86059, XrefRangeEnd = 86089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAllTuningBodyParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAllTuningBodyParts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86089, XrefRangeEnd = 86100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetFreePlacesCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFreePlacesCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86100, XrefRangeEnd = 86103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TestScript()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestScript>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TestScript()
	{
		Il2CppClassPointerStore<TestScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TestScript");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestScript>.NativeClassPtr);
		NativeFieldInfoPtr_stressLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestScript>.NativeClassPtr, "stressLevel");
		NativeFieldInfoPtr_itemsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestScript>.NativeClassPtr, "itemsAmount");
		NativeFieldInfoPtr_fpsInputController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestScript>.NativeClassPtr, "fpsInputController");
		NativeFieldInfoPtr_calcValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestScript>.NativeClassPtr, "calcValue");
		NativeFieldInfoPtr_FlyCamEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestScript>.NativeClassPtr, "FlyCamEnabled");
		NativeMethodInfoPtr_AddMoney_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668172);
		NativeMethodInfoPtr_RemoveMoney_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668173);
		NativeMethodInfoPtr_AddExp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668174);
		NativeMethodInfoPtr_AddScraps_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668175);
		NativeMethodInfoPtr_AddBarn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668176);
		NativeMethodInfoPtr_SwitchConsoleMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668177);
		NativeMethodInfoPtr_LogMissingKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668178);
		NativeMethodInfoPtr_DebugLevelCap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668179);
		NativeMethodInfoPtr_GameSettingsDebug_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668180);
		NativeMethodInfoPtr_AddItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668181);
		NativeMethodInfoPtr_AddItemsToRepair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668182);
		NativeMethodInfoPtr_AddBodyItemsToRepair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668183);
		NativeMethodInfoPtr_AddLastItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668184);
		NativeMethodInfoPtr_ClearInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668185);
		NativeMethodInfoPtr_FastMountMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668186);
		NativeMethodInfoPtr_UnlockAllUpgrades_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668187);
		NativeMethodInfoPtr_LockAllUpgrades_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668188);
		NativeMethodInfoPtr_UnlockAllParkingLevels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668189);
		NativeMethodInfoPtr_FillParkingPlaces_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668190);
		NativeMethodInfoPtr_RemoveAllCarsFromParking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668191);
		NativeMethodInfoPtr_LockAllParkingLevels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668192);
		NativeMethodInfoPtr_RunInBackground_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668193);
		NativeMethodInfoPtr_ShowPartsID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668194);
		NativeMethodInfoPtr_SkipMissionCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668195);
		NativeMethodInfoPtr_Teleport_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668196);
		NativeMethodInfoPtr_Unlock_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668197);
		NativeMethodInfoPtr_Lock_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668198);
		NativeMethodInfoPtr_IncrementStat_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668199);
		NativeMethodInfoPtr_ClearStat_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668200);
		NativeMethodInfoPtr_ClearAllStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668201);
		NativeMethodInfoPtr_ToggleFlyCam_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668202);
		NativeMethodInfoPtr_AddAllTuningParts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668203);
		NativeMethodInfoPtr_AddAllTuningBodyParts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668204);
		NativeMethodInfoPtr_GetFreePlacesCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668205);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestScript>.NativeClassPtr, 100668206);
	}

	public TestScript(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
