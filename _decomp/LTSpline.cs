using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class LTSpline : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DISTANCE_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SUBLINE_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_constantSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_pts;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptsAdj;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptsAdjLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientToPath2d;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSections;

	private static readonly System.IntPtr NativeFieldInfoPtr_currPt;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Private_Void_ArrayOf_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_map_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_interp_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_point_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawGizmo_Public_Static_Void_ArrayOf_Transform_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawLine_Public_Static_Void_ArrayOf_Transform_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateVectors_Public_ArrayOf_Vector3_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTSpline>.NativeClassPtr));

	public unsafe static int DISTANCE_COUNT
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISTANCE_COUNT, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISTANCE_COUNT, &num);
		}
	}

	public unsafe static int SUBLINE_COUNT
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUBLINE_COUNT, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUBLINE_COUNT, &num);
		}
	}

	public unsafe float distance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance)) = num;
		}
	}

	public unsafe bool constantSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantSpeed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantSpeed)) = flag;
		}
	}

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

	public unsafe Il2CppStructArray<Vector3> ptsAdj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptsAdj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptsAdj), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ptsAdjLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptsAdjLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptsAdjLength)) = num;
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

	public unsafe int numSections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSections);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSections)) = num;
		}
	}

	public unsafe int currPt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currPt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currPt)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9363, XrefRangeEnd = 9364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSpline(Il2CppStructArray<Vector3> pts)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSpline>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9364, XrefRangeEnd = 9365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSpline(Il2CppStructArray<Vector3> pts, bool constantSpeed)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSpline>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &constantSpeed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 9393, RefRangeEnd = 9406, XrefRangeStart = 9365, XrefRangeEnd = 9393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(Il2CppStructArray<Vector3> pts, bool constantSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pts);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &constantSpeed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Private_Void_ArrayOf_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 9408, RefRangeEnd = 9422, XrefRangeStart = 9406, XrefRangeEnd = 9408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 map(float u)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_map_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 9426, RefRangeEnd = 9444, XrefRangeStart = 9422, XrefRangeEnd = 9426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 interp(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_interp_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9444, XrefRangeEnd = 9451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ratioAtPoint(Vector3 pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9451, XrefRangeEnd = 9454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9466, RefRangeEnd = 9467, XrefRangeStart = 9454, XrefRangeEnd = 9466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9467, XrefRangeEnd = 9483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 9495, RefRangeEnd = 9500, XrefRangeStart = 9483, XrefRangeEnd = 9495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9500, XrefRangeEnd = 9510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9510, XrefRangeEnd = 9513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 9527, RefRangeEnd = 9528, XrefRangeStart = 9513, XrefRangeEnd = 9527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9530, RefRangeEnd = 9533, XrefRangeStart = 9528, XrefRangeEnd = 9530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gizmoDraw([Optional] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9541, RefRangeEnd = 9542, XrefRangeStart = 9533, XrefRangeEnd = 9541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawGizmo(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9561, RefRangeEnd = 9562, XrefRangeStart = 9542, XrefRangeEnd = 9561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawGizmo(Il2CppReferenceArray<Transform> arr, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawGizmo_Public_Static_Void_ArrayOf_Transform_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static void drawLine(Il2CppReferenceArray<Transform> arr, float width, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawLine_Public_Static_Void_ArrayOf_Transform_Single_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9562, XrefRangeEnd = 9616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(outlineMaterial);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9616, XrefRangeEnd = 9627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Vector3> generateVectors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateVectors_Public_ArrayOf_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	static LTSpline()
	{
		Il2CppClassPointerStore<LTSpline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTSpline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTSpline>.NativeClassPtr);
		NativeFieldInfoPtr_DISTANCE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "DISTANCE_COUNT");
		NativeFieldInfoPtr_SUBLINE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "SUBLINE_COUNT");
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_constantSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "constantSpeed");
		NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "pts");
		NativeFieldInfoPtr_ptsAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "ptsAdj");
		NativeFieldInfoPtr_ptsAdjLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "ptsAdjLength");
		NativeFieldInfoPtr_orientToPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "orientToPath");
		NativeFieldInfoPtr_orientToPath2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "orientToPath2d");
		NativeFieldInfoPtr_numSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "numSections");
		NativeFieldInfoPtr_currPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, "currPt");
		NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664093);
		NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664094);
		NativeMethodInfoPtr_init_Private_Void_ArrayOf_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_map_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_interp_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_ratioAtPoint_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664098);
		NativeMethodInfoPtr_point_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_place2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_placeLocal2d_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_place_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_place_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_placeLocal_Public_Void_Transform_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_gizmoDraw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_drawGizmo_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_drawGizmo_Public_Static_Void_ArrayOf_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr_drawLine_Public_Static_Void_ArrayOf_Transform_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664109);
		NativeMethodInfoPtr_drawLinesGLLines_Public_Void_Material_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_generateVectors_Public_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSpline>.NativeClassPtr, 100664111);
	}

	public LTSpline(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
