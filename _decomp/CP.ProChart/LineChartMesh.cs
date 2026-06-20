using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CP.ProChart;

public class LineChartMesh : ChartMesh
{
	public enum ChartType
	{
		LINE,
		CURVE,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChartType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ChartType()
		{
			Il2CppClassPointerStore<ChartType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "ChartType");
		}

	}

	public enum PointType
	{
		NONE,
		CIRCLE,
		RECTANGLE,
		TRIANGLE,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PointType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static PointType()
		{
			Il2CppClassPointerStore<PointType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "PointType");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_chart;

	private static readonly System.IntPtr NativeFieldInfoPtr_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_thickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_z0;

	private static readonly System.IntPtr NativeFieldInfoPtr_z1;

	private static readonly System.IntPtr NativeFieldInfoPtr_values;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Chart_Public_get_ChartType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Chart_Public_set_Void_ChartType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Point_Public_get_PointType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Point_Public_set_Void_PointType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Thickness_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PointSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PointSize_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Void_byref_ChartData2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calcControlPoints_Private_Void_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calcLineSegments_Private_Void_Vector2_Vector2_Vector2_Vector2_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLineSegment_Private_Void_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lineSegmentIntersection_Private_Boolean_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_vectorIntersection_Private_Boolean_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lineIntersectionPoint_Private_Vector3_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseLine_Private_Void_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePoint_Private_Void_Vector3_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTriangle_Private_Void_Vector3_Vector3_Vector3_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr));

	public unsafe ChartType chart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chart);
			return *(ChartType*)num;
		}
		set
		{
			*(ChartType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chart)) = chartType;
		}
	}

	public unsafe PointType point
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_point);
			return *(PointType*)num;
		}
		set
		{
			*(PointType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_point)) = pointType;
		}
	}

	public unsafe float thickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickness)) = num;
		}
	}

	public unsafe float pointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize)) = num;
		}
	}

	public unsafe List<Vector3> vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float z0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z0);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z0)) = num;
		}
	}

	public unsafe float z1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z1)) = num;
		}
	}

	public unsafe ChartData2D values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_values);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChartType Chart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Chart_Public_get_ChartType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ChartType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Chart_Public_set_Void_ChartType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PointType Point
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Point_Public_get_PointType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(PointType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Point_Public_set_Void_PointType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Thickness
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Thickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float PointSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PointSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PointSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238503, XrefRangeEnd = 238519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238519, XrefRangeEnd = 238526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 238538, RefRangeEnd = 238545, XrefRangeStart = 238526, XrefRangeEnd = 238538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValues(ref ChartData2D values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(values);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValues_Public_Void_byref_ChartData2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		values = ((intPtr3 == (System.IntPtr)0) ? null : new ChartData2D(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238545, XrefRangeEnd = 238677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Create_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void calcControlPoints(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, out Vector2 c1, out Vector2 c2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&p0);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref c1);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref c2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calcControlPoints_Private_Void_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238681, RefRangeEnd = 238682, XrefRangeStart = 238677, XrefRangeEnd = 238681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void calcLineSegments(Vector2 p0, Vector2 c0, Vector2 c1, Vector2 p1, Color32 color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&p0);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c0;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c1;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calcLineSegments_Private_Void_Vector2_Vector2_Vector2_Vector2_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238694, RefRangeEnd = 238696, XrefRangeStart = 238682, XrefRangeEnd = 238694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLineSegment(float x1, float y1, float x2, float y2, Color32 color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x2;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y2;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLineSegment_Private_Void_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe bool lineSegmentIntersection(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&v0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &v3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lineSegmentIntersection_Private_Boolean_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe bool vectorIntersection(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&v0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &v3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_vectorIntersection_Private_Boolean_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238699, RefRangeEnd = 238701, XrefRangeStart = 238696, XrefRangeEnd = 238699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 lineIntersectionPoint(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&v0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &v3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lineIntersectionPoint_Private_Vector3_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238780, RefRangeEnd = 238782, XrefRangeStart = 238701, XrefRangeEnd = 238780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseLine(Color32 color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseLine_Private_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238794, RefRangeEnd = 238796, XrefRangeStart = 238782, XrefRangeEnd = 238794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreatePoint(Vector3 center, int row, int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&center);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePoint_Private_Void_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 238813, RefRangeEnd = 238821, XrefRangeStart = 238796, XrefRangeEnd = 238813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Color32 color1, Color32 color2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&p1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTriangle_Private_Void_Vector3_Vector3_Vector3_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238821, XrefRangeEnd = 238822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LineChartMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LineChartMesh()
	{
		Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CP.ProChart", "LineChartMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr);
		NativeFieldInfoPtr_chart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "chart");
		NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "point");
		NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "thickness");
		NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "pointSize");
		NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "vertices");
		NativeFieldInfoPtr_z0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "z0");
		NativeFieldInfoPtr_z1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "z1");
		NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, "values");
		NativeMethodInfoPtr_get_Chart_Public_get_ChartType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681248);
		NativeMethodInfoPtr_set_Chart_Public_set_Void_ChartType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681249);
		NativeMethodInfoPtr_get_Point_Public_get_PointType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681250);
		NativeMethodInfoPtr_set_Point_Public_set_Void_PointType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681251);
		NativeMethodInfoPtr_get_Thickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681252);
		NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681253);
		NativeMethodInfoPtr_get_PointSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681254);
		NativeMethodInfoPtr_set_PointSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681255);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681256);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681257);
		NativeMethodInfoPtr_SetValues_Public_Void_byref_ChartData2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681258);
		NativeMethodInfoPtr_Create_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681259);
		NativeMethodInfoPtr_calcControlPoints_Private_Void_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681260);
		NativeMethodInfoPtr_calcLineSegments_Private_Void_Vector2_Vector2_Vector2_Vector2_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681261);
		NativeMethodInfoPtr_AddLineSegment_Private_Void_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681262);
		NativeMethodInfoPtr_lineSegmentIntersection_Private_Boolean_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681263);
		NativeMethodInfoPtr_vectorIntersection_Private_Boolean_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681264);
		NativeMethodInfoPtr_lineIntersectionPoint_Private_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681265);
		NativeMethodInfoPtr_CloseLine_Private_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681266);
		NativeMethodInfoPtr_CreatePoint_Private_Void_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681267);
		NativeMethodInfoPtr_AddTriangle_Private_Void_Vector3_Vector3_Vector3_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681268);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineChartMesh>.NativeClassPtr, 100681269);
	}

	public LineChartMesh(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
