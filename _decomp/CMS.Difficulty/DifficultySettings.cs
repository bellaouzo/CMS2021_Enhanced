using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Difficulty;

[System.Serializable]
public class DifficultySettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_disableHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableMissions;

	private static readonly System.IntPtr NativeFieldInfoPtr_disablePopups;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDevMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlimitedBarns;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlimitedMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_moreMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlimitedScraps;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableDescriptions;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSetting_Public_Void_DifficultySetting_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSettings_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSettingActive_Public_Boolean_DifficultySetting_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableHighlight_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableMissions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisablePopups_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableStats_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDevMode_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxXP_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlimitedMoney_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAll_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoreMoney_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlimitedScraps_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr));

	public unsafe bool disableHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableHighlight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableHighlight)) = flag;
		}
	}

	public unsafe bool disableMissions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMissions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMissions)) = flag;
		}
	}

	public unsafe bool disablePopups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disablePopups);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disablePopups)) = flag;
		}
	}

	public unsafe bool disableStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableStats)) = flag;
		}
	}

	public unsafe bool enableDevMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDevMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDevMode)) = flag;
		}
	}

	public unsafe bool maxXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxXP);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxXP)) = flag;
		}
	}

	public unsafe bool unlimitedBarns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedBarns);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedBarns)) = flag;
		}
	}

	public unsafe bool unlimitedMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedMoney);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedMoney)) = flag;
		}
	}

	public unsafe bool unlockAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockAll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockAll)) = flag;
		}
	}

	public unsafe bool moreMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreMoney);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreMoney)) = flag;
		}
	}

	public unsafe bool unlimitedScraps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedScraps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedScraps)) = flag;
		}
	}

	public unsafe bool disableDescriptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableDescriptions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableDescriptions)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218688, XrefRangeEnd = 218695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSetting(DifficultySetting setting, bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&setting);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enable;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSetting_Public_Void_DifficultySetting_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 218787, RefRangeEnd = 218790, XrefRangeStart = 218695, XrefRangeEnd = 218787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218790, XrefRangeEnd = 218793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSettingActive(DifficultySetting setting)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setting);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSettingActive_Public_Boolean_DifficultySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218793, XrefRangeEnd = 218797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableHighlight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableHighlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218797, XrefRangeEnd = 218801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableMissions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableMissions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218801, XrefRangeEnd = 218805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisablePopups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisablePopups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218805, XrefRangeEnd = 218814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218814, XrefRangeEnd = 218818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableDevMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDevMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218818, XrefRangeEnd = 218824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MaxXP()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxXP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218824, XrefRangeEnd = 218834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlimitedMoney()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlimitedMoney_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218834, XrefRangeEnd = 218854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218854, XrefRangeEnd = 218866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoreMoney()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoreMoney_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218866, XrefRangeEnd = 218885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlimitedScraps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlimitedScraps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DifficultySettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DifficultySettings()
	{
		Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Difficulty", "DifficultySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr);
		NativeFieldInfoPtr_disableHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "disableHighlight");
		NativeFieldInfoPtr_disableMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "disableMissions");
		NativeFieldInfoPtr_disablePopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "disablePopups");
		NativeFieldInfoPtr_disableStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "disableStats");
		NativeFieldInfoPtr_enableDevMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "enableDevMode");
		NativeFieldInfoPtr_maxXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "maxXP");
		NativeFieldInfoPtr_unlimitedBarns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "unlimitedBarns");
		NativeFieldInfoPtr_unlimitedMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "unlimitedMoney");
		NativeFieldInfoPtr_unlockAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "unlockAll");
		NativeFieldInfoPtr_moreMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "moreMoney");
		NativeFieldInfoPtr_unlimitedScraps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "unlimitedScraps");
		NativeFieldInfoPtr_disableDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, "disableDescriptions");
		NativeMethodInfoPtr_EnableSetting_Public_Void_DifficultySetting_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679876);
		NativeMethodInfoPtr_UpdateSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679877);
		NativeMethodInfoPtr_IsSettingActive_Public_Boolean_DifficultySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679878);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679879);
		NativeMethodInfoPtr_DisableHighlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679880);
		NativeMethodInfoPtr_DisableMissions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679881);
		NativeMethodInfoPtr_DisablePopups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679882);
		NativeMethodInfoPtr_DisableStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679883);
		NativeMethodInfoPtr_EnableDevMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679884);
		NativeMethodInfoPtr_MaxXP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679885);
		NativeMethodInfoPtr_UnlimitedMoney_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679886);
		NativeMethodInfoPtr_UnlockAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679887);
		NativeMethodInfoPtr_MoreMoney_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679888);
		NativeMethodInfoPtr_UnlimitedScraps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679889);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultySettings>.NativeClassPtr, 100679890);
	}

	public DifficultySettings(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
