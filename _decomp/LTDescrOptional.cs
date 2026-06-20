using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LTDescrOptional : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__toTrans_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__point_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__axis_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__origPosition_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__origRotation_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__path_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__spline_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_animationCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr__ltRect_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateFloat_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateVector2_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateVector3_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateColor_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateColorObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onComplete_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onCompleteObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onCompleteParam_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onUpdateParam_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__onStart_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_axis_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_origPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_origPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onComplete_Public_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onStart_Public_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr));

	public unsafe Transform _toTrans_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__toTrans_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__toTrans_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 _point_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__point_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__point_k__BackingField)) = vector;
		}
	}

	public unsafe Vector3 _axis_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axis_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axis_k__BackingField)) = vector;
		}
	}

	public unsafe Vector3 _origPosition_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__origPosition_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__origPosition_k__BackingField)) = vector;
		}
	}

	public unsafe Quaternion _origRotation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__origRotation_k__BackingField);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__origRotation_k__BackingField)) = quaternion;
		}
	}

	public unsafe LTBezierPath _path_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__path_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LTBezierPath(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__path_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LTSpline _spline_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spline_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LTSpline(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spline_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve animationCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LTRect _ltRect_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ltRect_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ltRect_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<float> _onUpdateFloat_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateFloat_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateFloat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<float, float> _onUpdateFloatRatio_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<float, float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<float, Il2CppSystem.Object> _onUpdateFloatObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<float, Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<Vector2> _onUpdateVector2_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateVector2_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateVector2_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<Vector3> _onUpdateVector3_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateVector3_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateVector3_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<Vector3, Il2CppSystem.Object> _onUpdateVector3Object_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Vector3, Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<Color> _onUpdateColor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateColor_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Color>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<Color, Il2CppSystem.Object> _onUpdateColorObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateColorObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Color, Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateColorObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action _onComplete_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onComplete_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onComplete_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<Il2CppSystem.Object> _onCompleteObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onCompleteObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onCompleteObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Object _onCompleteParam_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onCompleteParam_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onCompleteParam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Object _onUpdateParam_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateParam_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onUpdateParam_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action _onStart_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onStart_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform toTrans
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5623, RefRangeEnd = 5624, XrefRangeStart = 5623, XrefRangeEnd = 5623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 5624, RefRangeEnd = 5701, XrefRangeStart = 5624, XrefRangeEnd = 5624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Vector3 point
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_point_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Vector3 axis
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Vector3 origPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_origPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_origPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Quaternion origRotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe LTBezierPath path
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new LTBezierPath(intPtr) : null;
		}
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 5701, RefRangeEnd = 5728, XrefRangeStart = 5701, XrefRangeEnd = 5701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe LTSpline spline
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new LTSpline(intPtr) : null;
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 5728, RefRangeEnd = 5741, XrefRangeStart = 5728, XrefRangeEnd = 5728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe LTRect ltRect
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
		}
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 5741, RefRangeEnd = 5758, XrefRangeStart = 5741, XrefRangeEnd = 5741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<float> onUpdateFloat
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 5758, RefRangeEnd = 5788, XrefRangeStart = 5758, XrefRangeEnd = 5758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<float>(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 5788, RefRangeEnd = 5820, XrefRangeStart = 5788, XrefRangeEnd = 5788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<float, float> onUpdateFloatRatio
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<float, float>(intPtr) : null;
		}
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 5820, RefRangeEnd = 5843, XrefRangeStart = 5820, XrefRangeEnd = 5820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<float, Il2CppSystem.Object> onUpdateFloatObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<float, Il2CppSystem.Object>(intPtr) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 5843, RefRangeEnd = 5853, XrefRangeStart = 5843, XrefRangeEnd = 5843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<Vector2> onUpdateVector2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Vector2>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 5853, RefRangeEnd = 5861, XrefRangeStart = 5853, XrefRangeEnd = 5853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<Vector3> onUpdateVector3
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Vector3>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5861, RefRangeEnd = 5868, XrefRangeStart = 5861, XrefRangeEnd = 5861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<Vector3, Il2CppSystem.Object> onUpdateVector3Object
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Vector3, Il2CppSystem.Object>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 5868, RefRangeEnd = 5876, XrefRangeStart = 5868, XrefRangeEnd = 5868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<Color> onUpdateColor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Color>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 5876, RefRangeEnd = 5879, XrefRangeStart = 5876, XrefRangeEnd = 5876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<Color, Il2CppSystem.Object> onUpdateColorObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Color, Il2CppSystem.Object>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 5879, RefRangeEnd = 5881, XrefRangeStart = 5879, XrefRangeEnd = 5879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action onComplete
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onComplete_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action<Il2CppSystem.Object> onCompleteObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Il2CppSystem.Object>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Object onCompleteParam
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 5881, RefRangeEnd = 5884, XrefRangeStart = 5881, XrefRangeEnd = 5881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Object onUpdateParam
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action onStart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onStart_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 5884, RefRangeEnd = 5897, XrefRangeStart = 5884, XrefRangeEnd = 5884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5899, RefRangeEnd = 5900, XrefRangeStart = 5897, XrefRangeEnd = 5899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5914, RefRangeEnd = 5915, XrefRangeStart = 5900, XrefRangeEnd = 5914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callOnUpdate(float val, float ratioPassed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LTDescrOptional()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LTDescrOptional()
	{
		Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTDescrOptional");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr);
		NativeFieldInfoPtr__toTrans_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<toTrans>k__BackingField");
		NativeFieldInfoPtr__point_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<point>k__BackingField");
		NativeFieldInfoPtr__axis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<axis>k__BackingField");
		NativeFieldInfoPtr__origPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<origPosition>k__BackingField");
		NativeFieldInfoPtr__origRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<origRotation>k__BackingField");
		NativeFieldInfoPtr__path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<path>k__BackingField");
		NativeFieldInfoPtr__spline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<spline>k__BackingField");
		NativeFieldInfoPtr_animationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "animationCurve");
		NativeFieldInfoPtr__ltRect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<ltRect>k__BackingField");
		NativeFieldInfoPtr__onUpdateFloat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloat>k__BackingField");
		NativeFieldInfoPtr__onUpdateFloatRatio_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloatRatio>k__BackingField");
		NativeFieldInfoPtr__onUpdateFloatObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateFloatObject>k__BackingField");
		NativeFieldInfoPtr__onUpdateVector2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector2>k__BackingField");
		NativeFieldInfoPtr__onUpdateVector3_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector3>k__BackingField");
		NativeFieldInfoPtr__onUpdateVector3Object_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateVector3Object>k__BackingField");
		NativeFieldInfoPtr__onUpdateColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateColor>k__BackingField");
		NativeFieldInfoPtr__onUpdateColorObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateColorObject>k__BackingField");
		NativeFieldInfoPtr__onComplete_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onComplete>k__BackingField");
		NativeFieldInfoPtr__onCompleteObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onCompleteObject>k__BackingField");
		NativeFieldInfoPtr__onCompleteParam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onCompleteParam>k__BackingField");
		NativeFieldInfoPtr__onUpdateParam_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onUpdateParam>k__BackingField");
		NativeFieldInfoPtr__onStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, "<onStart>k__BackingField");
		NativeMethodInfoPtr_get_toTrans_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_set_toTrans_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663820);
		NativeMethodInfoPtr_set_point_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663821);
		NativeMethodInfoPtr_get_axis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_set_axis_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_get_origPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_set_origPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_get_origRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_set_origRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_get_path_Public_get_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_set_path_Public_set_Void_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_get_spline_Public_get_LTSpline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_set_spline_Public_set_Void_LTSpline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_get_ltRect_Public_get_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_set_ltRect_Public_set_Void_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_get_onUpdateFloat_Public_get_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_set_onUpdateFloat_Public_set_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_get_onUpdateFloatRatio_Public_get_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_set_onUpdateFloatRatio_Public_set_Void_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_get_onUpdateFloatObject_Public_get_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_set_onUpdateFloatObject_Public_set_Void_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_get_onUpdateVector2_Public_get_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_set_onUpdateVector2_Public_set_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_get_onUpdateVector3_Public_get_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_set_onUpdateVector3_Public_set_Void_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_get_onUpdateVector3Object_Public_get_Action_2_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_set_onUpdateVector3Object_Public_set_Void_Action_2_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_get_onUpdateColor_Public_get_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_set_onUpdateColor_Public_set_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_get_onUpdateColorObject_Public_get_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_set_onUpdateColorObject_Public_set_Void_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_get_onComplete_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_set_onComplete_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_get_onCompleteObject_Public_get_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_set_onCompleteObject_Public_set_Void_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_get_onCompleteParam_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_set_onCompleteParam_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_get_onUpdateParam_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_set_onUpdateParam_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_get_onStart_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_set_onStart_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_callOnUpdate_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescrOptional>.NativeClassPtr, 100663862);
	}

	public LTDescrOptional(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
