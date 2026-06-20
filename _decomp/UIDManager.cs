using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class UIDManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LastUID;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewUID_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataForSave_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDataFromSave_Public_Static_Void_Int64_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIDManager>.NativeClassPtr));

	public unsafe static long LastUID
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LastUID, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LastUID, &num);
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 94553, RefRangeEnd = 94557, XrefRangeStart = 94548, XrefRangeEnd = 94553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetNewUID()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewUID_Public_Static_Int64_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94557, XrefRangeEnd = 94561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetDataForSave()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataForSave_Public_Static_Int64_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94561, XrefRangeEnd = 94565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadDataFromSave(long lastUID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lastUID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDataFromSave_Public_Static_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UIDManager()
	{
		Il2CppClassPointerStore<UIDManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UIDManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDManager>.NativeClassPtr);
		NativeFieldInfoPtr_LastUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDManager>.NativeClassPtr, "LastUID");
		NativeMethodInfoPtr_GetNewUID_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDManager>.NativeClassPtr, 100668772);
		NativeMethodInfoPtr_GetDataForSave_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDManager>.NativeClassPtr, 100668773);
		NativeMethodInfoPtr_LoadDataFromSave_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDManager>.NativeClassPtr, 100668774);
	}

	public UIDManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
