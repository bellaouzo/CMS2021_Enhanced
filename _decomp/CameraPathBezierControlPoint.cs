using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraPathBezierControlPoint : MonoBehaviour
{
	public enum animationEase
	{
		flat,
		easein,
		easeout,
		easeinout,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<animationEase>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static animationEase()
		{
			Il2CppClassPointerStore<animationEase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "animationEase");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_controlPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_bezier;

	private static readonly System.IntPtr NativeFieldInfoPtr__ease;

	private static readonly System.IntPtr NativeFieldInfoPtr__curve;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOV;

	private static readonly System.IntPtr NativeFieldInfoPtr_directionLineLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusBoxLength;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldControlPoint_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reverseWorldControlPoint_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isLastPoint_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_curve_Public_get_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ease_Public_get_animationEase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ease_Public_set_Void_animationEase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationToCurve_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationCurve_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr));

	public unsafe Vector3 controlPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlPoint);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlPoint)) = vector;
		}
	}

	public unsafe CameraPathBezier bezier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bezier);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraPathBezier(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bezier), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe animationEase _ease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ease);
			return *(animationEase*)num;
		}
		set
		{
			*(animationEase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ease)) = animationEase2;
		}
	}

	public unsafe AnimationCurve _curve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__curve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float FOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FOV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FOV)) = num;
		}
	}

	public unsafe float directionLineLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionLineLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionLineLength)) = num;
		}
	}

	public unsafe float focusBoxLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusBoxLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusBoxLength)) = num;
		}
	}

	public unsafe Vector3 worldControlPoint
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1635, RefRangeEnd = 1638, XrefRangeStart = 1631, XrefRangeEnd = 1635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldControlPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 reverseWorldControlPoint
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638, XrefRangeEnd = 1642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reverseWorldControlPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool isLastPoint
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1642, XrefRangeEnd = 1664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isLastPoint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe AnimationCurve curve
	{
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 1664, RefRangeEnd = 1734, XrefRangeStart = 1664, XrefRangeEnd = 1664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_curve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
	}

	public unsafe animationEase ease
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ease_Public_get_animationEase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(animationEase*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1734, XrefRangeEnd = 1735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ease_Public_set_Void_animationEase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1735, XrefRangeEnd = 1755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotationToCurve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationToCurve_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1755, XrefRangeEnd = 1756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1756, XrefRangeEnd = 1769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1769, XrefRangeEnd = 1778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1795, RefRangeEnd = 1797, XrefRangeStart = 1778, XrefRangeEnd = 1795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimationCurve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimationCurve_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1797, XrefRangeEnd = 1802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraPathBezierControlPoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraPathBezierControlPoint()
	{
		Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraPathBezierControlPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr);
		NativeFieldInfoPtr_controlPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "controlPoint");
		NativeFieldInfoPtr_bezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "bezier");
		NativeFieldInfoPtr__ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "_ease");
		NativeFieldInfoPtr__curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "_curve");
		NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "FOV");
		NativeFieldInfoPtr_directionLineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "directionLineLength");
		NativeFieldInfoPtr_focusBoxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, "focusBoxLength");
		NativeMethodInfoPtr_get_worldControlPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_get_reverseWorldControlPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_isLastPoint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_get_curve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_ease_Public_get_animationEase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_set_ease_Public_set_Void_animationEase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_SetRotationToCurve_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_SetAnimationCurve_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierControlPoint>.NativeClassPtr, 100663398);
	}

	public CameraPathBezierControlPoint(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
