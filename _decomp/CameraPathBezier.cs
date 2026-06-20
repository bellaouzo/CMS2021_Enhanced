using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraPathBezier : MonoBehaviour
{
	public enum viewmodes
	{
		usercontrolled,
		target,
		mouselook,
		followpath,
		reverseFollowpath,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<viewmodes>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static viewmodes()
		{
			Il2CppClassPointerStore<viewmodes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "viewmodes");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_loop;

	private static readonly System.IntPtr NativeFieldInfoPtr__controlPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr__storedTotalArcLength;

	private static readonly System.IntPtr NativeFieldInfoPtr__storedArcLengths;

	private static readonly System.IntPtr NativeFieldInfoPtr__storedArcLengthsFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_storedArcLengthArraySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_overRotate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numberOfControlPoints_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numberOfCurves_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlPoints_Public_get_ArrayOf_CameraPathBezierControlPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_storedTotalArcLength_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_storedArcLengths_Public_get_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateStoredValues_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeletePoint_Public_Void_CameraPathBezierControlPoint_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeletePoint_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewPoint_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewPoint_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalisedT_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPathPosition_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPathRotation_Public_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPathFOV_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPathPercentageAtPoint_Public_Single_CameraPathBezierControlPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoint_Private_CameraPathBezierControlPoint_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numberOfUseablePoints_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBezierPoint_Private_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCubicRotation_Private_Quaternion_Quaternion_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SquadTangent_Private_Quaternion_Quaternion_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lnDif_Private_Quaternion_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Private_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_exp_Private_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_log_Private_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Private_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Nlerp_Private_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuatConjugate_Private_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr));

	public unsafe viewmodes mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(viewmodes*)num;
		}
		set
		{
			*(viewmodes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = viewmodes2;
		}
	}

	public unsafe Transform target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Color lineColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineColour)) = color;
		}
	}

	public unsafe bool loop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<CameraPathBezierControlPoint> _controlPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controlPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CameraPathBezierControlPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controlPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float _storedTotalArcLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedTotalArcLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedTotalArcLength)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> _storedArcLengths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedArcLengths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedArcLengths), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> _storedArcLengthsFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedArcLengthsFull);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storedArcLengthsFull), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int storedArcLengthArraySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedArcLengthArraySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedArcLengthArraySize)) = num;
		}
	}

	public unsafe Quaternion lastRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRotation)) = quaternion;
		}
	}

	public unsafe int overRotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overRotate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overRotate)) = num;
		}
	}

	public unsafe int numberOfControlPoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numberOfControlPoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int numberOfCurves
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numberOfCurves_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Il2CppReferenceArray<CameraPathBezierControlPoint> controlPoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlPoints_Public_get_ArrayOf_CameraPathBezierControlPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CameraPathBezierControlPoint>(intPtr) : null;
		}
	}

	public unsafe float storedTotalArcLength
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_storedTotalArcLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Il2CppStructArray<float> storedArcLengths
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 986, RefRangeEnd = 987, XrefRangeStart = 986, XrefRangeEnd = 986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_storedArcLengths_Public_get_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
	}

	public unsafe int numberOfUseablePoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numberOfUseablePoints_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1006, RefRangeEnd = 1012, XrefRangeStart = 987, XrefRangeEnd = 1006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecalculateStoredValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateStoredValues_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012, XrefRangeEnd = 1016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037, RefRangeEnd = 1038, XrefRangeStart = 1016, XrefRangeEnd = 1037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePoint(CameraPathBezierControlPoint deletePoint, bool destroy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(deletePoint);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destroy;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeletePoint_Public_Void_CameraPathBezierControlPoint_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1076, RefRangeEnd = 1077, XrefRangeStart = 1038, XrefRangeEnd = 1076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePoint(int index, bool destroy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destroy;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeletePoint_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077, XrefRangeEnd = 1079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewPoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1256, RefRangeEnd = 1257, XrefRangeStart = 1079, XrefRangeEnd = 1256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewPoint(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewPoint_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1257, RefRangeEnd = 1258, XrefRangeStart = 1257, XrefRangeEnd = 1257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetNormalisedT(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormalisedT_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1282, RefRangeEnd = 1300, XrefRangeStart = 1258, XrefRangeEnd = 1282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPathPosition(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPathPosition_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1339, RefRangeEnd = 1340, XrefRangeStart = 1300, XrefRangeEnd = 1339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetPathRotation(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPathRotation_Public_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1351, RefRangeEnd = 1352, XrefRangeStart = 1340, XrefRangeEnd = 1351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPathFOV(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPathFOV_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352, XrefRangeEnd = 1361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPathPercentageAtPoint(CameraPathBezierControlPoint point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPathPercentageAtPoint_Public_Single_CameraPathBezierControlPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361, XrefRangeEnd = 1368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368, XrefRangeEnd = 1369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1371, RefRangeEnd = 1374, XrefRangeStart = 1369, XrefRangeEnd = 1371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraPathBezierControlPoint GetPoint(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoint_Private_CameraPathBezierControlPoint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CameraPathBezierControlPoint(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&t);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p0;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBezierPoint_Private_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374, XrefRangeEnd = 1379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion CalculateCubicRotation(Quaternion p, Quaternion a, Quaternion b, Quaternion q, float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&p);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateCubicRotation_Private_Quaternion_Quaternion_Quaternion_Quaternion_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1397, RefRangeEnd = 1403, XrefRangeStart = 1379, XrefRangeEnd = 1397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion SquadTangent(Quaternion before, Quaternion center, Quaternion after)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&before);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &after;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SquadTangent_Private_Quaternion_Quaternion_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1409, RefRangeEnd = 1411, XrefRangeStart = 1403, XrefRangeEnd = 1409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion lnDif(Quaternion a, Quaternion b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lnDif_Private_Quaternion_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411, XrefRangeEnd = 1414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion Normalize(Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalize_Private_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414, XrefRangeEnd = 1418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion exp(Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_exp_Private_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418, XrefRangeEnd = 1421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion log(Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_log_Private_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1430, RefRangeEnd = 1439, XrefRangeStart = 1421, XrefRangeEnd = 1430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion Slerp(Quaternion p, Quaternion q, float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Slerp_Private_Quaternion_Quaternion_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Quaternion Nlerp(Quaternion p, Quaternion q, float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Nlerp_Private_Quaternion_Quaternion_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Quaternion GetQuatConjugate(Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuatConjugate_Private_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1439, XrefRangeEnd = 1447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraPathBezier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraPathBezier()
	{
		Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraPathBezier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "target");
		NativeFieldInfoPtr_lineColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "lineColour");
		NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "loop");
		NativeFieldInfoPtr__controlPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "_controlPoints");
		NativeFieldInfoPtr__storedTotalArcLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "_storedTotalArcLength");
		NativeFieldInfoPtr__storedArcLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "_storedArcLengths");
		NativeFieldInfoPtr__storedArcLengthsFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "_storedArcLengthsFull");
		NativeFieldInfoPtr_storedArcLengthArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "storedArcLengthArraySize");
		NativeFieldInfoPtr_lastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "lastRotation");
		NativeFieldInfoPtr_overRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, "overRotate");
		NativeMethodInfoPtr_get_numberOfControlPoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_get_numberOfCurves_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_get_controlPoints_Public_get_ArrayOf_CameraPathBezierControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_get_storedTotalArcLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_get_storedArcLengths_Public_get_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_RecalculateStoredValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_DeletePoint_Public_Void_CameraPathBezierControlPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_DeletePoint_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_AddNewPoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_AddNewPoint_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_GetNormalisedT_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_GetPathPosition_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_GetPathRotation_Public_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_GetPathFOV_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_GetPathPercentageAtPoint_Public_Single_CameraPathBezierControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_GetPoint_Private_CameraPathBezierControlPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_get_numberOfUseablePoints_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_CalculateBezierPoint_Private_Vector3_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_CalculateCubicRotation_Private_Quaternion_Quaternion_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_SquadTangent_Private_Quaternion_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_lnDif_Private_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_Normalize_Private_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_exp_Private_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_log_Private_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_Slerp_Private_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_Nlerp_Private_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_GetQuatConjugate_Private_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezier>.NativeClassPtr, 100663368);
	}

	public CameraPathBezier(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
