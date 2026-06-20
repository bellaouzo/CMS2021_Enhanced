using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PartScriptCullerManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_partScriptCullers;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLevelFinishedLoading_Private_Void_Scene_LoadSceneMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_PartScriptCuller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_PartScriptCuller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PauseOneAndCullOther_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMountsLODLevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSettingsForAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr));

	public unsafe List<PartScriptCuller> partScriptCullers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partScriptCullers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<PartScriptCuller>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partScriptCullers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62277, XrefRangeEnd = 62289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62289, XrefRangeEnd = 62295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scene);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLevelFinishedLoading_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 62305, RefRangeEnd = 62307, XrefRangeStart = 62295, XrefRangeEnd = 62305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(PartScriptCuller partScriptCuller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(partScriptCuller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_PartScriptCuller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62307, XrefRangeEnd = 62309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(PartScriptCuller partScriptCuller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(partScriptCuller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_PartScriptCuller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62309, XrefRangeEnd = 62350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PauseOneAndCullOther(CarLoader toPause = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(toPause);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseOneAndCullOther_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62375, RefRangeEnd = 62376, XrefRangeStart = 62350, XrefRangeEnd = 62375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 62401, RefRangeEnd = 62404, XrefRangeStart = 62376, XrefRangeEnd = 62401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 62429, RefRangeEnd = 62432, XrefRangeStart = 62404, XrefRangeEnd = 62429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMountsLODLevel(int lvl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lvl);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMountsLODLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62432, XrefRangeEnd = 62451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSettingsForAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSettingsForAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PartScriptCullerManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PartScriptCullerManager()
	{
		Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PartScriptCullerManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr);
		NativeFieldInfoPtr_partScriptCullers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, "partScriptCullers");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667050);
		NativeMethodInfoPtr_OnLevelFinishedLoading_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667051);
		NativeMethodInfoPtr_Add_Public_Void_PartScriptCuller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667052);
		NativeMethodInfoPtr_Remove_Public_Void_PartScriptCuller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667053);
		NativeMethodInfoPtr_PauseOneAndCullOther_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667054);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667055);
		NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667056);
		NativeMethodInfoPtr_SetMountsLODLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667057);
		NativeMethodInfoPtr_UpdateSettingsForAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCullerManager>.NativeClassPtr, 100667059);
	}

	public PartScriptCullerManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
