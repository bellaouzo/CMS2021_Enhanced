using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public static class CLZF2 : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HLOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_HSIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_LIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_OFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_REF;

	private static readonly System.IntPtr NativeFieldInfoPtr_HashTable;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compress_Public_Static_ArrayOf_Byte_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decompress_Public_Static_ArrayOf_Byte_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lzf_compress_Public_Static_Int32_ArrayOf_Byte_byref_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lzf_decompress_Public_Static_Int32_ArrayOf_Byte_byref_ArrayOf_Byte_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CLZF2>.NativeClassPtr));

	public unsafe static uint HLOG
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HLOG, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HLOG, &num);
		}
	}

	public unsafe static uint HSIZE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HSIZE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HSIZE, &num);
		}
	}

	public unsafe static uint MAX_LIT
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_LIT, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_LIT, &num);
		}
	}

	public unsafe static uint MAX_OFF
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_OFF, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_OFF, &num);
		}
	}

	public unsafe static uint MAX_REF
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_REF, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_REF, &num);
		}
	}

	public unsafe static Il2CppStructArray<long> HashTable
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HashTable, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<long>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HashTable, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120386, XrefRangeEnd = 120401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Compress(Il2CppStructArray<byte> inputBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compress_Public_Static_ArrayOf_Byte_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120401, XrefRangeEnd = 120416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Decompress(Il2CppStructArray<byte> inputBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decompress_Public_Static_ArrayOf_Byte_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120444, RefRangeEnd = 120446, XrefRangeStart = 120416, XrefRangeEnd = 120444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int lzf_compress(Il2CppStructArray<byte> input, ref Il2CppStructArray<byte> output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(output);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lzf_compress_Public_Static_Int32_ArrayOf_Byte_byref_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120447, RefRangeEnd = 120449, XrefRangeStart = 120446, XrefRangeEnd = 120447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int lzf_decompress(Il2CppStructArray<byte> input, ref Il2CppStructArray<byte> output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(output);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lzf_decompress_Public_Static_Int32_ArrayOf_Byte_byref_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static CLZF2()
	{
		Il2CppClassPointerStore<CLZF2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "CLZF2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLZF2>.NativeClassPtr);
		NativeFieldInfoPtr_HLOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, "HLOG");
		NativeFieldInfoPtr_HSIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, "HSIZE");
		NativeFieldInfoPtr_MAX_LIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, "MAX_LIT");
		NativeFieldInfoPtr_MAX_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, "MAX_OFF");
		NativeFieldInfoPtr_MAX_REF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, "MAX_REF");
		NativeFieldInfoPtr_HashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, "HashTable");
		NativeMethodInfoPtr_Compress_Public_Static_ArrayOf_Byte_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, 100670961);
		NativeMethodInfoPtr_Decompress_Public_Static_ArrayOf_Byte_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, 100670962);
		NativeMethodInfoPtr_lzf_compress_Public_Static_Int32_ArrayOf_Byte_byref_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, 100670963);
		NativeMethodInfoPtr_lzf_decompress_Public_Static_Int32_ArrayOf_Byte_byref_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLZF2>.NativeClassPtr, 100670964);
	}

	public CLZF2(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
