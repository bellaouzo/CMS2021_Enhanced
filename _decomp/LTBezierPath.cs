using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LTBezierPath : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pts;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath2d;

	private static readonly System.IntPtr NativeFieldInfoPtr_beziers;

	private static readonly System.IntPtr NativeFieldInfoPtr_lengthRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBezier;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousBezier;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPoints_Public_Void_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRationInOneRange_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr));

	public unsafe Il2CppStructArray<Vector3> pts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

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

	public unsafe bool orientToPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientToPath);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientToPath)) = flag;
		}
	}

	public unsafe bool orientToPath2d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientToPath2d);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientToPath2d)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<LTBezier> beziers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beziers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<LTBezier>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_beziers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> lengthRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lengthRatio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lengthRatio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentBezier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBezier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBezier)) = num;
		}
	}

	public unsafe int previousBezier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousBezier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousBezier)) = num;
		}
	}

	public unsafe float distance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LTBezierPath()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9247, XrefRangeEnd = 9248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTBezierPath(Il2CppStructArray<Vector3> pts_)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 9275, RefRangeEnd = 9282, XrefRangeStart = 9248, XrefRangeEnd = 9275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPoints(Il2CppStructArray<Vector3> pts_)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPoints_Public_Void_ArrayOf_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 9285, RefRangeEnd = 9301, XrefRangeStart = 9282, XrefRangeEnd = 9285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 point(float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ratio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_point_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9301, XrefRangeEnd = 9309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void place2d(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9309, XrefRangeEnd = 9321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeLocal2d(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9321, XrefRangeEnd = 9329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void place(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_place_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9329, XrefRangeEnd = 9335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void place(Transform transform, float ratio, Vector3 worldUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldUp;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9335, XrefRangeEnd = 9338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeLocal(Transform transform, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9354, RefRangeEnd = 9355, XrefRangeStart = 9338, XrefRangeEnd = 9354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldUp;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9355, XrefRangeEnd = 9356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getRationInOneRange(float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ratio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRationInOneRange_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9356, XrefRangeEnd = 9363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gizmoDraw([Optional] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LTBezierPath()
	{
		Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTBezierPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr);
		NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "pts");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "length");
		NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "orientToPath");
		NativeFieldInfoPtr_orientToPath2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "orientToPath2d");
		NativeFieldInfoPtr_beziers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "beziers");
		NativeFieldInfoPtr_lengthRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "lengthRatio");
		NativeFieldInfoPtr_currentBezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "currentBezier");
		NativeFieldInfoPtr_previousBezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, "previousBezier");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_setPoints_Public_Void_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_place_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_getRationInOneRange_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTBezierPath>.NativeClassPtr, 100664092);
	}

	public LTBezierPath(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
