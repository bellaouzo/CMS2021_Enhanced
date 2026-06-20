using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class MiniJsonExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_toJson_Public_Static_String_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_arrayListFromJson_Public_Static_ArrayList_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hashtableFromJson_Public_Static_Hashtable_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108420, XrefRangeEnd = 108424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string toJson(this Hashtable obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toJson_Public_Static_String_Hashtable_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108424, XrefRangeEnd = 108428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string toJson(this Dictionary<string, string> obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108428, XrefRangeEnd = 108433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArrayList arrayListFromJson(this string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_arrayListFromJson_Public_Static_ArrayList_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ArrayList(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108433, XrefRangeEnd = 108438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hashtable hashtableFromJson(this string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hashtableFromJson_Public_Static_Hashtable_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Hashtable(intPtr) : null;
	}

	static MiniJsonExtensions()
	{
		Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MiniJsonExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_toJson_Public_Static_String_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100670024);
		NativeMethodInfoPtr_toJson_Public_Static_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100670025);
		NativeMethodInfoPtr_arrayListFromJson_Public_Static_ArrayList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100670026);
		NativeMethodInfoPtr_hashtableFromJson_Public_Static_Hashtable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJsonExtensions>.NativeClassPtr, 100670027);
	}

	public MiniJsonExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
