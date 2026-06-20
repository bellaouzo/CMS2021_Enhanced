using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Difficulty;

[System.Serializable]
public class DifficultyManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseDifficulty;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDifficultyLevel_Public_Void_DifficultyLevel_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDifficultyLevel_Public_DifficultyLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEasyMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNormalMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSandboxMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExpertMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSettingActive_Public_Boolean_DifficultySetting_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSettings_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateDifficultyLevel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateForTutorial_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NeedsGarageRefresh_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentDifficultyLevelToString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr));

	public unsafe DifficultyLevel currentDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDifficulty);
			return *(DifficultyLevel*)num;
		}
		set
		{
			*(DifficultyLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDifficulty)) = difficultyLevel;
		}
	}

	public unsafe BaseDifficulty baseDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseDifficulty);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseDifficulty(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseDifficulty), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 218665, RefRangeEnd = 218668, XrefRangeStart = 218626, XrefRangeEnd = 218665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDifficultyLevel(DifficultyLevel difficultyLevel, bool onlyPrepare = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&difficultyLevel);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &onlyPrepare;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDifficultyLevel_Public_Void_DifficultyLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe DifficultyLevel GetDifficultyLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDifficultyLevel_Public_DifficultyLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DifficultyLevel*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsEasyMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEasyMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsNormalMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNormalMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsSandboxMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSandboxMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsExpertMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExpertMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218668, XrefRangeEnd = 218671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe void ResetSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218673, RefRangeEnd = 218674, XrefRangeStart = 218671, XrefRangeEnd = 218673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateDifficultyLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateDifficultyLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218674, XrefRangeEnd = 218680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateForTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateForTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool NeedsGarageRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedsGarageRefresh_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218680, XrefRangeEnd = 218681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CurrentDifficultyLevelToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentDifficultyLevelToString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218681, XrefRangeEnd = 218688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DifficultyManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DifficultyManager()
	{
		Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Difficulty", "DifficultyManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr);
		NativeFieldInfoPtr_currentDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, "currentDifficulty");
		NativeFieldInfoPtr_baseDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, "baseDifficulty");
		NativeMethodInfoPtr_SetDifficultyLevel_Public_Void_DifficultyLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679863);
		NativeMethodInfoPtr_GetDifficultyLevel_Public_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679864);
		NativeMethodInfoPtr_IsEasyMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679865);
		NativeMethodInfoPtr_IsNormalMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679866);
		NativeMethodInfoPtr_IsSandboxMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679867);
		NativeMethodInfoPtr_IsExpertMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679868);
		NativeMethodInfoPtr_IsSettingActive_Public_Boolean_DifficultySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679869);
		NativeMethodInfoPtr_ResetSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679870);
		NativeMethodInfoPtr_ActivateDifficultyLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679871);
		NativeMethodInfoPtr_ActivateForTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679872);
		NativeMethodInfoPtr_NeedsGarageRefresh_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679873);
		NativeMethodInfoPtr_CurrentDifficultyLevelToString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679874);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100679875);
	}

	public DifficultyManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
