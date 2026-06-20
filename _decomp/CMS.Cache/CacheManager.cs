using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Cache;

public class CacheManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stringBoolCache;

	private static readonly System.IntPtr NativeFieldInfoPtr__StringBoolCacheExists_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_stringIntCache;

	private static readonly System.IntPtr NativeFieldInfoPtr__StringIntCacheExists_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StringBoolCacheExists_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_StringBoolCacheExists_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStringBoolCache_Public_ConcurrentDictionary_2_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearStringBoolCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StringIntCacheExists_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_StringIntCacheExists_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStringIntCache_Public_ConcurrentDictionary_2_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearStringIntCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CacheManager>.NativeClassPtr));

	public unsafe ConcurrentDictionary<string, bool> stringBoolCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringBoolCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, bool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringBoolCache), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _StringBoolCacheExists_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StringBoolCacheExists_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StringBoolCacheExists_k__BackingField)) = flag;
		}
	}

	public unsafe ConcurrentDictionary<string, int> stringIntCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringIntCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringIntCache), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _StringIntCacheExists_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StringIntCacheExists_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StringIntCacheExists_k__BackingField)) = flag;
		}
	}

	public unsafe bool StringBoolCacheExists
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StringBoolCacheExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StringBoolCacheExists_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool StringIntCacheExists
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StringIntCacheExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StringIntCacheExists_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218584, XrefRangeEnd = 218593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConcurrentDictionary<string, bool> CreateStringBoolCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStringBoolCache_Public_ConcurrentDictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, bool>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void ClearStringBoolCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearStringBoolCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 218602, RefRangeEnd = 218604, XrefRangeStart = 218593, XrefRangeEnd = 218602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConcurrentDictionary<string, int> CreateStringIntCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStringIntCache_Public_ConcurrentDictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, int>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void ClearStringIntCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearStringIntCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CacheManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CacheManager()
	{
		Il2CppClassPointerStore<CacheManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Cache", "CacheManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheManager>.NativeClassPtr);
		NativeFieldInfoPtr_stringBoolCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, "stringBoolCache");
		NativeFieldInfoPtr__StringBoolCacheExists_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, "<StringBoolCacheExists>k__BackingField");
		NativeFieldInfoPtr_stringIntCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, "stringIntCache");
		NativeFieldInfoPtr__StringIntCacheExists_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, "<StringIntCacheExists>k__BackingField");
		NativeMethodInfoPtr_get_StringBoolCacheExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679836);
		NativeMethodInfoPtr_set_StringBoolCacheExists_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679837);
		NativeMethodInfoPtr_CreateStringBoolCache_Public_ConcurrentDictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679838);
		NativeMethodInfoPtr_ClearStringBoolCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679839);
		NativeMethodInfoPtr_get_StringIntCacheExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679840);
		NativeMethodInfoPtr_set_StringIntCacheExists_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679841);
		NativeMethodInfoPtr_CreateStringIntCache_Public_ConcurrentDictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679842);
		NativeMethodInfoPtr_ClearStringIntCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679843);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheManager>.NativeClassPtr, 100679844);
	}

	public CacheManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
