using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPWheelCollider : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mass;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_center;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspensionDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspensionAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_springRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_damperRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspensionTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_caliperTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_groundPenetration;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSteerAngleFix;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableWheelReferenceFrameFix;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSuspensionDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbodyTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_visualHit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steerAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_angularPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_contactDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_suspensionPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_visualSteerAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isCaliperChildOfSuspension;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isWheelChildOfSuspension;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isWheelChildOfCaliper;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_2PI;

	private static readonly System.IntPtr NativeFieldInfoPtr__visualGrounded_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__angularVelocity_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__canSleep_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__runtimeSpringRate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__runtimeDamperRate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__runtimeSuspensionTravel_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastRuntimeSpringRate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastRuntimeDamperRate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastRuntimeSuspensionTravel_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cachedTransform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visualGrounded_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_visualGrounded_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visualHit_Public_get_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_steerAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_steerAngle_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_angularPosition_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_angularPosition_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canSleep_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_canSleep_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_effectiveSpringRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeSpringRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_runtimeSpringRate_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeDamperRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_runtimeDamperRate_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeSuspensionTravel_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_runtimeSuspensionTravel_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastRuntimeSpringRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lastRuntimeSpringRate_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastRuntimeDamperRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lastRuntimeDamperRate_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastRuntimeSuspensionTravel_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lastRuntimeSuspensionTravel_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVisualWheel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSuspensionForceOffset_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroundHit_Public_Boolean_byref_WheelHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContactDepth_Public_Single_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupWheelCollider_Private_WheelCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWheelCollider_Private_Void_WheelCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixSteerAngle_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustToWheelMesh_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaledBounds_Private_Bounds_MeshFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr));

	public unsafe float mass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass)) = num;
		}
	}

	public unsafe float radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
		}
	}

	public unsafe Vector3 center
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_center);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_center)) = vector;
		}
	}

	public unsafe float suspensionDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionDistance)) = num;
		}
	}

	public unsafe float suspensionAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionAnchor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionAnchor)) = num;
		}
	}

	public unsafe float springRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRate)) = num;
		}
	}

	public unsafe float damperRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperRate)) = num;
		}
	}

	public unsafe Transform suspensionTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform caliperTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caliperTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caliperTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform wheelTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float groundPenetration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundPenetration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundPenetration)) = num;
		}
	}

	public unsafe static bool disableSteerAngleFix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disableSteerAngleFix, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disableSteerAngleFix, &flag);
		}
	}

	public unsafe static bool disableWheelReferenceFrameFix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disableWheelReferenceFrameFix, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disableWheelReferenceFrameFix, &flag);
		}
	}

	public unsafe static float minSuspensionDistance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minSuspensionDistance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minSuspensionDistance, &num);
		}
	}

	public unsafe static float scaleFactor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scaleFactor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scaleFactor, &num);
		}
	}

	public unsafe Transform m_transform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_rigidbodyTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbodyTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbodyTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RaycastHit m_visualHit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_visualHit);
			return *(RaycastHit*)num;
		}
		set
		{
			*(RaycastHit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_visualHit)) = raycastHit;
		}
	}

	public unsafe WheelCollider m_wheelCollider
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((WheelCollider)null) : new WheelCollider(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe float m_steerAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerAngle)) = num;
		}
	}

	public unsafe float m_angularPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angularPosition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angularPosition)) = num;
		}
	}

	public unsafe float m_contactDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_contactDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_contactDistance)) = num;
		}
	}

	public unsafe Vector3 m_suspensionPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_suspensionPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_suspensionPosition)) = vector;
		}
	}

	public unsafe InterpolatedFloat m_visualSteerAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_visualSteerAngle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_visualSteerAngle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_isCaliperChildOfSuspension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isCaliperChildOfSuspension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isCaliperChildOfSuspension)) = flag;
		}
	}

	public unsafe bool m_isWheelChildOfSuspension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isWheelChildOfSuspension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isWheelChildOfSuspension)) = flag;
		}
	}

	public unsafe bool m_isWheelChildOfCaliper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isWheelChildOfCaliper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isWheelChildOfCaliper)) = flag;
		}
	}

	public unsafe float m_2PI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_2PI);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_2PI)) = num;
		}
	}

	public unsafe bool _visualGrounded_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__visualGrounded_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__visualGrounded_k__BackingField)) = flag;
		}
	}

	public unsafe float _angularVelocity_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__angularVelocity_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__angularVelocity_k__BackingField)) = num;
		}
	}

	public unsafe bool _canSleep_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canSleep_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canSleep_k__BackingField)) = flag;
		}
	}

	public unsafe float _runtimeSpringRate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeSpringRate_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeSpringRate_k__BackingField)) = num;
		}
	}

	public unsafe float _runtimeDamperRate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeDamperRate_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeDamperRate_k__BackingField)) = num;
		}
	}

	public unsafe float _runtimeSuspensionTravel_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeSuspensionTravel_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeSuspensionTravel_k__BackingField)) = num;
		}
	}

	public unsafe float _lastRuntimeSpringRate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRuntimeSpringRate_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRuntimeSpringRate_k__BackingField)) = num;
		}
	}

	public unsafe float _lastRuntimeDamperRate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRuntimeDamperRate_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRuntimeDamperRate_k__BackingField)) = num;
		}
	}

	public unsafe float _lastRuntimeSuspensionTravel_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRuntimeSuspensionTravel_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastRuntimeSuspensionTravel_k__BackingField)) = num;
		}
	}

	public unsafe Transform cachedTransform
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 116608, RefRangeEnd = 116614, XrefRangeStart = 116596, XrefRangeEnd = 116608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cachedTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
	}

	public unsafe bool visualGrounded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visualGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_visualGrounded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RaycastHit visualHit
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visualHit_Public_get_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(RaycastHit*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float steerAngle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_steerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116614, XrefRangeEnd = 116622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_steerAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float angularVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float angularPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_angularPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_angularPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool canSleep
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canSleep_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_canSleep_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float effectiveSpringRate
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116622, XrefRangeEnd = 116624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_effectiveSpringRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float runtimeSpringRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runtimeSpringRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_runtimeSpringRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float runtimeDamperRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runtimeDamperRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_runtimeDamperRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float runtimeSuspensionTravel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runtimeSuspensionTravel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_runtimeSuspensionTravel_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float lastRuntimeSpringRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastRuntimeSpringRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastRuntimeSpringRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float lastRuntimeDamperRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastRuntimeDamperRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastRuntimeDamperRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float lastRuntimeSuspensionTravel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastRuntimeSuspensionTravel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastRuntimeSuspensionTravel_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116590, XrefRangeEnd = 116596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116624, XrefRangeEnd = 116625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116625, XrefRangeEnd = 116715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe int GetUpdateOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116715, XrefRangeEnd = 116716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116842, RefRangeEnd = 116843, XrefRangeStart = 116716, XrefRangeEnd = 116842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateVisualWheel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVisualWheel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116843, XrefRangeEnd = 116847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSuspensionForceOffset(float offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSuspensionForceOffset_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116885, RefRangeEnd = 116888, XrefRangeStart = 116847, XrefRangeEnd = 116885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetGroundHit(out WheelHit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)hit);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroundHit_Public_Boolean_byref_WheelHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116888, XrefRangeEnd = 116896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetContactDepth(Vector3 contactPoint, float suspensionTravel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&contactPoint);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &suspensionTravel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContactDepth_Public_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116926, RefRangeEnd = 116927, XrefRangeStart = 116896, XrefRangeEnd = 116926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WheelCollider SetupWheelCollider()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupWheelCollider_Private_WheelCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr == (System.IntPtr)0) ? ((WheelCollider)null) : new WheelCollider(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116987, RefRangeEnd = 116988, XrefRangeStart = 116927, XrefRangeEnd = 116987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWheelCollider(WheelCollider wheelCol)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)wheelCol);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWheelCollider_Private_Void_WheelCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116999, RefRangeEnd = 117001, XrefRangeStart = 116988, XrefRangeEnd = 116999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FixSteerAngle(float inputSteerAngle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputSteerAngle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixSteerAngle_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117001, XrefRangeEnd = 117079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustToWheelMesh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustToWheelMesh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117088, RefRangeEnd = 117090, XrefRangeStart = 117079, XrefRangeEnd = 117088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Bounds GetScaledBounds(MeshFilter meshFilter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(meshFilter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaledBounds_Private_Bounds_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117090, XrefRangeEnd = 117098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPWheelCollider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPWheelCollider()
	{
		Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPWheelCollider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr);
		NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "mass");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "center");
		NativeFieldInfoPtr_suspensionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "suspensionDistance");
		NativeFieldInfoPtr_suspensionAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "suspensionAnchor");
		NativeFieldInfoPtr_springRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "springRate");
		NativeFieldInfoPtr_damperRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "damperRate");
		NativeFieldInfoPtr_suspensionTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "suspensionTransform");
		NativeFieldInfoPtr_caliperTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "caliperTransform");
		NativeFieldInfoPtr_wheelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "wheelTransform");
		NativeFieldInfoPtr_groundPenetration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "groundPenetration");
		NativeFieldInfoPtr_disableSteerAngleFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "disableSteerAngleFix");
		NativeFieldInfoPtr_disableWheelReferenceFrameFix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "disableWheelReferenceFrameFix");
		NativeFieldInfoPtr_minSuspensionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "minSuspensionDistance");
		NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "scaleFactor");
		NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_transform");
		NativeFieldInfoPtr_m_rigidbodyTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_rigidbodyTransform");
		NativeFieldInfoPtr_m_visualHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_visualHit");
		NativeFieldInfoPtr_m_wheelCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_wheelCollider");
		NativeFieldInfoPtr_m_steerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_steerAngle");
		NativeFieldInfoPtr_m_angularPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_angularPosition");
		NativeFieldInfoPtr_m_contactDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_contactDistance");
		NativeFieldInfoPtr_m_suspensionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_suspensionPosition");
		NativeFieldInfoPtr_m_visualSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_visualSteerAngle");
		NativeFieldInfoPtr_m_isCaliperChildOfSuspension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_isCaliperChildOfSuspension");
		NativeFieldInfoPtr_m_isWheelChildOfSuspension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_isWheelChildOfSuspension");
		NativeFieldInfoPtr_m_isWheelChildOfCaliper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_isWheelChildOfCaliper");
		NativeFieldInfoPtr_m_2PI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "m_2PI");
		NativeFieldInfoPtr__visualGrounded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<visualGrounded>k__BackingField");
		NativeFieldInfoPtr__angularVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<angularVelocity>k__BackingField");
		NativeFieldInfoPtr__canSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<canSleep>k__BackingField");
		NativeFieldInfoPtr__runtimeSpringRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<runtimeSpringRate>k__BackingField");
		NativeFieldInfoPtr__runtimeDamperRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<runtimeDamperRate>k__BackingField");
		NativeFieldInfoPtr__runtimeSuspensionTravel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<runtimeSuspensionTravel>k__BackingField");
		NativeFieldInfoPtr__lastRuntimeSpringRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<lastRuntimeSpringRate>k__BackingField");
		NativeFieldInfoPtr__lastRuntimeDamperRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<lastRuntimeDamperRate>k__BackingField");
		NativeFieldInfoPtr__lastRuntimeSuspensionTravel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, "<lastRuntimeSuspensionTravel>k__BackingField");
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670642);
		NativeMethodInfoPtr_get_cachedTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670643);
		NativeMethodInfoPtr_get_visualGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670644);
		NativeMethodInfoPtr_set_visualGrounded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670645);
		NativeMethodInfoPtr_get_visualHit_Public_get_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670646);
		NativeMethodInfoPtr_get_steerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670647);
		NativeMethodInfoPtr_set_steerAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670648);
		NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670649);
		NativeMethodInfoPtr_set_angularVelocity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670650);
		NativeMethodInfoPtr_get_angularPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670651);
		NativeMethodInfoPtr_set_angularPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670652);
		NativeMethodInfoPtr_get_canSleep_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670653);
		NativeMethodInfoPtr_set_canSleep_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670654);
		NativeMethodInfoPtr_get_effectiveSpringRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670655);
		NativeMethodInfoPtr_get_runtimeSpringRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670656);
		NativeMethodInfoPtr_set_runtimeSpringRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670657);
		NativeMethodInfoPtr_get_runtimeDamperRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670658);
		NativeMethodInfoPtr_set_runtimeDamperRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670659);
		NativeMethodInfoPtr_get_runtimeSuspensionTravel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670660);
		NativeMethodInfoPtr_set_runtimeSuspensionTravel_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670661);
		NativeMethodInfoPtr_get_lastRuntimeSpringRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670662);
		NativeMethodInfoPtr_set_lastRuntimeSpringRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670663);
		NativeMethodInfoPtr_get_lastRuntimeDamperRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670664);
		NativeMethodInfoPtr_set_lastRuntimeDamperRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670665);
		NativeMethodInfoPtr_get_lastRuntimeSuspensionTravel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670666);
		NativeMethodInfoPtr_set_lastRuntimeSuspensionTravel_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670667);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670668);
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670669);
		NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670670);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670671);
		NativeMethodInfoPtr_UpdateVisualWheel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670672);
		NativeMethodInfoPtr_SetSuspensionForceOffset_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670673);
		NativeMethodInfoPtr_GetGroundHit_Public_Boolean_byref_WheelHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670674);
		NativeMethodInfoPtr_GetContactDepth_Public_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670675);
		NativeMethodInfoPtr_SetupWheelCollider_Private_WheelCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670676);
		NativeMethodInfoPtr_UpdateWheelCollider_Private_Void_WheelCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670677);
		NativeMethodInfoPtr_FixSteerAngle_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670678);
		NativeMethodInfoPtr_AdjustToWheelMesh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670679);
		NativeMethodInfoPtr_GetScaledBounds_Private_Bounds_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670680);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPWheelCollider>.NativeClassPtr, 100670681);
	}

	public VPWheelCollider(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
