using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LTBezier : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_aa;

	private static readonly System.IntPtr NativeFieldInfoPtr_bb;

	private static readonly System.IntPtr NativeFieldInfoPtr_cc;

	private static readonly System.IntPtr NativeFieldInfoPtr_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_arcLengths;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_map_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTBezier>.NativeClassPtr));

	public unsafe float length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length)) = num;
		}
	}

	public unsafe Vector3 a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = vector;
		}
	}

	public unsafe Vector3 aa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aa);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aa)) = vector;
		}
	}

	public unsafe Vector3 bb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bb);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bb)) = vector;
		}
	}

	public unsafe Vector3 cc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cc);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cc)) = vector;
		}
	}

	public unsafe float len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_len);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_len)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> arcLengths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arcLengths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arcLengths), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9239, RefRangeEnd = 9240, XrefRangeStart = 9230, XrefRangeEnd = 9239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezier>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &precision;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 9240, RefRangeEnd = 9242, XrefRangeStart = 9240, XrefRangeEnd = 9240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float map(float u)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_map_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9242, RefRangeEnd = 9245, XrefRangeStart = 9242, XrefRangeEnd = 9242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 bezierPoint(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9245, XrefRangeEnd = 9247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 point(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static LTBezier()
	{
		Il2CppClassPointerStore<LTBezier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTBezier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTBezier>.NativeClassPtr);
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "length");
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "a");
		NativeFieldInfoPtr_aa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "aa");
		NativeFieldInfoPtr_bb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "bb");
		NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "cc");
		NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "len");
		NativeFieldInfoPtr_arcLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, "arcLengths");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_map_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_bezierPoint_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezier>.NativeClassPtr, 100664079);
	}

	public LTBezier(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
