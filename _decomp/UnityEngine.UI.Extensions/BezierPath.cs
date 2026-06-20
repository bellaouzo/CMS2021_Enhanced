using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class BezierPath : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SegmentsPerCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_MINIMUM_SQR_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIVISION_THRESHOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_curveCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControlPoints_Public_Void_List_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControlPoints_Public_Void_ArrayOf_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControlPoints_Public_List_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Interpolate_Public_Void_List_1_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SamplePoints_Public_Void_List_1_Vector2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBezierPoint_Public_Vector2_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDrawingPoints0_Public_List_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDrawingPoints1_Public_List_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDrawingPoints2_Public_List_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindDrawingPoints_Private_List_1_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindDrawingPoints_Private_Int32_Int32_Single_Single_List_1_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBezierPoint_Private_Vector2_Single_Vector2_Vector2_Vector2_Vector2_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BezierPath>.NativeClassPtr));

	public unsafe int SegmentsPerCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SegmentsPerCurve);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SegmentsPerCurve)) = num;
		}
	}

	public unsafe float MINIMUM_SQR_DISTANCE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MINIMUM_SQR_DISTANCE);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MINIMUM_SQR_DISTANCE)) = num;
		}
	}

	public unsafe float DIVISION_THRESHOLD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DIVISION_THRESHOLD);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DIVISION_THRESHOLD)) = num;
		}
	}

	public unsafe List<Vector2> controlPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int curveCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curveCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curveCount)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120223, XrefRangeEnd = 120228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BezierPath()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BezierPath>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120228, XrefRangeEnd = 120233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetControlPoints(List<Vector2> newControlPoints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newControlPoints);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControlPoints_Public_Void_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120233, XrefRangeEnd = 120238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetControlPoints(Il2CppStructArray<Vector2> newControlPoints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newControlPoints);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControlPoints_Public_Void_ArrayOf_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe List<Vector2> GetControlPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlPoints_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120263, RefRangeEnd = 120264, XrefRangeStart = 120238, XrefRangeEnd = 120263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Interpolate(List<Vector2> segmentPoints, float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(segmentPoints);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Interpolate_Public_Void_List_1_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120264, XrefRangeEnd = 120303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourcePoints);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minSqrDistance;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSqrDistance;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SamplePoints_Public_Void_List_1_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 120305, RefRangeEnd = 120314, XrefRangeStart = 120303, XrefRangeEnd = 120305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 CalculateBezierPoint(int curveIndex, float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&curveIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBezierPoint_Public_Vector2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120314, XrefRangeEnd = 120324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector2> GetDrawingPoints0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDrawingPoints0_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120324, XrefRangeEnd = 120337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector2> GetDrawingPoints1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDrawingPoints1_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120337, XrefRangeEnd = 120357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector2> GetDrawingPoints2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDrawingPoints2_Public_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120357, XrefRangeEnd = 120368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Vector2> FindDrawingPoints(int curveIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&curveIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDrawingPoints_Private_List_1_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 120379, RefRangeEnd = 120383, XrefRangeStart = 120368, XrefRangeEnd = 120379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&curveIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(pointList);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &insertionIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDrawingPoints_Private_Int32_Int32_Single_Single_List_1_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120383, RefRangeEnd = 120386, XrefRangeStart = 120383, XrefRangeEnd = 120383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&t);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p0;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBezierPoint_Private_Vector2_Single_Vector2_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static BezierPath()
	{
		Il2CppClassPointerStore<BezierPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "BezierPath");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BezierPath>.NativeClassPtr);
		NativeFieldInfoPtr_SegmentsPerCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, "SegmentsPerCurve");
		NativeFieldInfoPtr_MINIMUM_SQR_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, "MINIMUM_SQR_DISTANCE");
		NativeFieldInfoPtr_DIVISION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, "DIVISION_THRESHOLD");
		NativeFieldInfoPtr_controlPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, "controlPoints");
		NativeFieldInfoPtr_curveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, "curveCount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670948);
		NativeMethodInfoPtr_SetControlPoints_Public_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670949);
		NativeMethodInfoPtr_SetControlPoints_Public_Void_ArrayOf_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670950);
		NativeMethodInfoPtr_GetControlPoints_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670951);
		NativeMethodInfoPtr_Interpolate_Public_Void_List_1_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670952);
		NativeMethodInfoPtr_SamplePoints_Public_Void_List_1_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670953);
		NativeMethodInfoPtr_CalculateBezierPoint_Public_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670954);
		NativeMethodInfoPtr_GetDrawingPoints0_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670955);
		NativeMethodInfoPtr_GetDrawingPoints1_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670956);
		NativeMethodInfoPtr_GetDrawingPoints2_Public_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670957);
		NativeMethodInfoPtr_FindDrawingPoints_Private_List_1_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670958);
		NativeMethodInfoPtr_FindDrawingPoints_Private_Int32_Int32_Single_Single_List_1_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670959);
		NativeMethodInfoPtr_CalculateBezierPoint_Private_Vector2_Single_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierPath>.NativeClassPtr, 100670960);
	}

	public BezierPath(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
