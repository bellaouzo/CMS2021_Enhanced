using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ProfileManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_selectedProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedProfileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_createProfileFor;

	private static readonly System.IntPtr NativeFieldInfoPtr_profileLoadTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_RecoverBackupIsRuning;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfile_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfiles_Public_ArrayOf_ProfileData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateProfileName_Public_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfileData_Public_ProfileData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProfileHaveName_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfileName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfileDifficultyText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfileDifficulty_Public_DifficultyLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfileDifficulty_Public_DifficultyLevel_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfileName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfileLevel_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfileMoney_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfileLastSave_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfileLastSave_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfilePlayTimeAsString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfilePlayTimeAsString_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectedProfilePlayTime_Public_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfilePlayTime_Public_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedProfilePlayTime_Public_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProfilePlayTime_Private_Void_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNameForCurrentProfile_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDifficultyForCurrentProfile_Public_Void_DifficultyLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNameForProfile_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateProfileLoadTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLastSaveDate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStartingMoney_Public_Void_DifficultyLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteProfile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSelectedProfile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BackupSave_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BackupNewSave_Private_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCalendars_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr));

	public unsafe int selectedProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedProfile);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedProfile)) = num;
		}
	}

	public unsafe string selectedProfileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedProfileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedProfileName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int createProfileFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createProfileFor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createProfileFor)) = num;
		}
	}

	public unsafe long profileLoadTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_profileLoadTime);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_profileLoadTime)) = num;
		}
	}

	public unsafe bool RecoverBackupIsRuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RecoverBackupIsRuning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RecoverBackupIsRuning)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62451, XrefRangeEnd = 62452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62463, RefRangeEnd = 62465, XrefRangeStart = 62452, XrefRangeEnd = 62463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 62480, RefRangeEnd = 62483, XrefRangeStart = 62465, XrefRangeEnd = 62480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 62494, RefRangeEnd = 62506, XrefRangeStart = 62483, XrefRangeEnd = 62494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSelectedProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfile_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62506, XrefRangeEnd = 62513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<ProfileData> GetProfiles(bool update = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&update);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfiles_Public_ArrayOf_ProfileData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ProfileData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62513, XrefRangeEnd = 62520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateProfileName(int profileID, string profileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&profileID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(profileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateProfileName_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62520, XrefRangeEnd = 62528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileData GetSelectedProfileData(bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfileData_Public_ProfileData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ProfileData(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62528, XrefRangeEnd = 62537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProfileHaveName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProfileHaveName_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62537, XrefRangeEnd = 62544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSelectedProfileName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfileName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62544, XrefRangeEnd = 62554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSelectedProfileDifficultyText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfileDifficultyText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62554, XrefRangeEnd = 62561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DifficultyLevel GetSelectedProfileDifficulty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfileDifficulty_Public_DifficultyLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DifficultyLevel*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62561, XrefRangeEnd = 62568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DifficultyLevel GetProfileDifficulty(int profileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&profileID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfileDifficulty_Public_DifficultyLevel_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DifficultyLevel*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62575, RefRangeEnd = 62577, XrefRangeStart = 62568, XrefRangeEnd = 62575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProfileName(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfileName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62577, XrefRangeEnd = 62584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetProfileLevel(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfileLevel_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62584, XrefRangeEnd = 62591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetProfileMoney(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfileMoney_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62591, XrefRangeEnd = 62592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSelectedProfileLastSave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfileLastSave_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 62624, RefRangeEnd = 62627, XrefRangeStart = 62592, XrefRangeEnd = 62624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProfileLastSave(int profileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&profileID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfileLastSave_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62627, XrefRangeEnd = 62628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSelectedProfilePlayTimeAsString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfilePlayTimeAsString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62649, RefRangeEnd = 62651, XrefRangeStart = 62628, XrefRangeEnd = 62649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProfilePlayTimeAsString(int profileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&profileID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfilePlayTimeAsString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62651, XrefRangeEnd = 62658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetSelectedProfilePlayTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectedProfilePlayTime_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(uint*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62658, XrefRangeEnd = 62665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetProfilePlayTime(int profileID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&profileID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfilePlayTime_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(uint*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62665, XrefRangeEnd = 62672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectedProfilePlayTime(uint playTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedProfilePlayTime_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62672, XrefRangeEnd = 62679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProfilePlayTime(int profileID, uint playTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&profileID);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProfilePlayTime_Private_Void_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62679, XrefRangeEnd = 62686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNameForCurrentProfile(string newProfileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newProfileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNameForCurrentProfile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62686, XrefRangeEnd = 62693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDifficultyForCurrentProfile(DifficultyLevel newLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDifficultyForCurrentProfile_Public_Void_DifficultyLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62707, RefRangeEnd = 62709, XrefRangeStart = 62693, XrefRangeEnd = 62707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNameForProfile(string newProfileName, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newProfileName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNameForProfile_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 62721, RefRangeEnd = 62724, XrefRangeStart = 62709, XrefRangeEnd = 62721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateProfileLoadTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateProfileLoadTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 62759, RefRangeEnd = 62762, XrefRangeStart = 62724, XrefRangeEnd = 62759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLastSaveDate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLastSaveDate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62773, RefRangeEnd = 62775, XrefRangeStart = 62762, XrefRangeEnd = 62773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateStartingMoney(DifficultyLevel difficultyLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficultyLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateStartingMoney_Public_Void_DifficultyLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62800, RefRangeEnd = 62801, XrefRangeStart = 62775, XrefRangeEnd = 62800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62829, RefRangeEnd = 62830, XrefRangeStart = 62801, XrefRangeEnd = 62829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteSelectedProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteSelectedProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62830, XrefRangeEnd = 62867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BackupSave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BackupSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62893, RefRangeEnd = 62895, XrefRangeStart = 62867, XrefRangeEnd = 62893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BackupNewSave(string persistentDataPath, string fileName, string backupDirectory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(persistentDataPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(backupDirectory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BackupNewSave_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62895, XrefRangeEnd = 62967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCalendars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCalendars_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62967, XrefRangeEnd = 62972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfileManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ProfileManager()
	{
		Il2CppClassPointerStore<ProfileManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ProfileManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr);
		NativeFieldInfoPtr_selectedProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "selectedProfile");
		NativeFieldInfoPtr_selectedProfileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "selectedProfileName");
		NativeFieldInfoPtr_createProfileFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "createProfileFor");
		NativeFieldInfoPtr_profileLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "profileLoadTime");
		NativeFieldInfoPtr_RecoverBackupIsRuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, "RecoverBackupIsRuning");
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667060);
		NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667061);
		NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667062);
		NativeMethodInfoPtr_GetSelectedProfile_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667063);
		NativeMethodInfoPtr_GetProfiles_Public_ArrayOf_ProfileData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667064);
		NativeMethodInfoPtr_UpdateProfileName_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667065);
		NativeMethodInfoPtr_GetSelectedProfileData_Public_ProfileData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667066);
		NativeMethodInfoPtr_ProfileHaveName_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667067);
		NativeMethodInfoPtr_GetSelectedProfileName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667068);
		NativeMethodInfoPtr_GetSelectedProfileDifficultyText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667069);
		NativeMethodInfoPtr_GetSelectedProfileDifficulty_Public_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667070);
		NativeMethodInfoPtr_GetProfileDifficulty_Public_DifficultyLevel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667071);
		NativeMethodInfoPtr_GetProfileName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667072);
		NativeMethodInfoPtr_GetProfileLevel_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667073);
		NativeMethodInfoPtr_GetProfileMoney_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667074);
		NativeMethodInfoPtr_GetSelectedProfileLastSave_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667075);
		NativeMethodInfoPtr_GetProfileLastSave_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667076);
		NativeMethodInfoPtr_GetSelectedProfilePlayTimeAsString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_GetProfilePlayTimeAsString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr_GetSelectedProfilePlayTime_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr_GetProfilePlayTime_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667080);
		NativeMethodInfoPtr_SetSelectedProfilePlayTime_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr_SetProfilePlayTime_Private_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr_SetNameForCurrentProfile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667083);
		NativeMethodInfoPtr_SetDifficultyForCurrentProfile_Public_Void_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr_SetNameForProfile_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667085);
		NativeMethodInfoPtr_UpdateProfileLoadTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr_UpdateLastSaveDate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667087);
		NativeMethodInfoPtr_UpdateStartingMoney_Public_Void_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667088);
		NativeMethodInfoPtr_DeleteProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667089);
		NativeMethodInfoPtr_DeleteSelectedProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667090);
		NativeMethodInfoPtr_BackupSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667091);
		NativeMethodInfoPtr_BackupNewSave_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667092);
		NativeMethodInfoPtr_AddCalendars_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667093);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileManager>.NativeClassPtr, 100667094);
	}

	public ProfileManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
