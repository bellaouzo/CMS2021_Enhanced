using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPSelfDrive : VehicleBehaviour
{
	public enum Direction
	{
		Forward,
		Reverse,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Direction>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Direction()
		{
			Il2CppClassPointerStore<Direction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "Direction");
		}

	}

	public enum TargetApproachAction
	{
		SlowDown,
		KeepSpeed,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetApproachAction>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static TargetApproachAction()
		{
			Il2CppClassPointerStore<TargetApproachAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "TargetApproachAction");
		}

	}

	public enum TargetReachedAction
	{
		Stop,
		OvershootAndComeBack,
		RemoveTargetAndContinue,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TargetReachedAction>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static TargetReachedAction()
		{
			Il2CppClassPointerStore<TargetReachedAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "TargetReachedAction");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_targetPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetApproachAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetReachedAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowdownDistanceFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetReachedDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStop;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerMoveRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerReleaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxThrottleInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttlePressRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleReleaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBrakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakePressRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeReleaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_showDebugLogEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleRamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseSpeedThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowModeSlopeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_onStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_onTargetReached;

	private static readonly System.IntPtr NativeFieldInfoPtr_onTargetChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_throttleInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steerInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isMoving;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_targetRangeReached;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_carPhysics;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasPhysics;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPhysics_Public_Void_PrepareCarPhysics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugLog_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr));

	public unsafe Transform targetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float maxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
		}
	}

	public unsafe Direction direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
			return *(Direction*)num;
		}
		set
		{
			*(Direction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = direction2;
		}
	}

	public unsafe TargetApproachAction targetApproachAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetApproachAction);
			return *(TargetApproachAction*)num;
		}
		set
		{
			*(TargetApproachAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetApproachAction)) = targetApproachAction;
		}
	}

	public unsafe TargetReachedAction targetReachedAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetReachedAction);
			return *(TargetReachedAction*)num;
		}
		set
		{
			*(TargetReachedAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetReachedAction)) = targetReachedAction;
		}
	}

	public unsafe float slowdownDistanceFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowdownDistanceFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowdownDistanceFactor)) = num;
		}
	}

	public unsafe float targetReachedDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetReachedDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetReachedDistance)) = num;
		}
	}

	public unsafe bool forceStop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStop)) = flag;
		}
	}

	public unsafe float steerMoveRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerMoveRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerMoveRate)) = num;
		}
	}

	public unsafe float steerReleaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerReleaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerReleaseRate)) = num;
		}
	}

	public unsafe float maxThrottleInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxThrottleInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxThrottleInput)) = num;
		}
	}

	public unsafe float throttlePressRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttlePressRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttlePressRate)) = num;
		}
	}

	public unsafe float throttleReleaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleReleaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleReleaseRate)) = num;
		}
	}

	public unsafe float maxBrakeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBrakeInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBrakeInput)) = num;
		}
	}

	public unsafe float brakePressRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakePressRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakePressRate)) = num;
		}
	}

	public unsafe float brakeReleaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeReleaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeReleaseRate)) = num;
		}
	}

	public unsafe bool showDebugLogEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDebugLogEvents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDebugLogEvents)) = flag;
		}
	}

	public unsafe float throttleRamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleRamp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleRamp)) = num;
		}
	}

	public unsafe float brakeRamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRamp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRamp)) = num;
		}
	}

	public unsafe float inverseSpeedThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseSpeedThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverseSpeedThreshold)) = num;
		}
	}

	public unsafe float lowModeSlopeAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowModeSlopeAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowModeSlopeAngle)) = num;
		}
	}

	public unsafe Il2CppSystem.Action onStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action onTargetReached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTargetReached);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTargetReached), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action onTargetChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTargetChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTargetChanged), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_brakeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakeInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakeInput)) = num;
		}
	}

	public unsafe float m_throttleInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_throttleInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_throttleInput)) = num;
		}
	}

	public unsafe float m_steerInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerInput)) = num;
		}
	}

	public unsafe VPVehicleController m_vehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_isMoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isMoving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isMoving)) = flag;
		}
	}

	public unsafe bool m_targetRangeReached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetRangeReached);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetRangeReached)) = flag;
		}
	}

	public unsafe Transform m_prevTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PrepareCarPhysics carPhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPhysics);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PrepareCarPhysics(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPhysics), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool hasPhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasPhysics);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasPhysics)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe void SetPhysics(PrepareCarPhysics physics)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(physics);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPhysics_Public_Void_PrepareCarPhysics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110414, XrefRangeEnd = 110417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110417, XrefRangeEnd = 110597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 110605, RefRangeEnd = 110607, XrefRangeStart = 110597, XrefRangeEnd = 110605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugLog(string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugLog_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110607, XrefRangeEnd = 110610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPSelfDrive()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPSelfDrive()
	{
		Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPSelfDrive");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr);
		NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "targetPosition");
		NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "maxSpeed");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "direction");
		NativeFieldInfoPtr_targetApproachAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "targetApproachAction");
		NativeFieldInfoPtr_targetReachedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "targetReachedAction");
		NativeFieldInfoPtr_slowdownDistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "slowdownDistanceFactor");
		NativeFieldInfoPtr_targetReachedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "targetReachedDistance");
		NativeFieldInfoPtr_forceStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "forceStop");
		NativeFieldInfoPtr_steerMoveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "steerMoveRate");
		NativeFieldInfoPtr_steerReleaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "steerReleaseRate");
		NativeFieldInfoPtr_maxThrottleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "maxThrottleInput");
		NativeFieldInfoPtr_throttlePressRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "throttlePressRate");
		NativeFieldInfoPtr_throttleReleaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "throttleReleaseRate");
		NativeFieldInfoPtr_maxBrakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "maxBrakeInput");
		NativeFieldInfoPtr_brakePressRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "brakePressRate");
		NativeFieldInfoPtr_brakeReleaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "brakeReleaseRate");
		NativeFieldInfoPtr_showDebugLogEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "showDebugLogEvents");
		NativeFieldInfoPtr_throttleRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "throttleRamp");
		NativeFieldInfoPtr_brakeRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "brakeRamp");
		NativeFieldInfoPtr_inverseSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "inverseSpeedThreshold");
		NativeFieldInfoPtr_lowModeSlopeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "lowModeSlopeAngle");
		NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "onStart");
		NativeFieldInfoPtr_onTargetReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "onTargetReached");
		NativeFieldInfoPtr_onTargetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "onTargetChanged");
		NativeFieldInfoPtr_m_brakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_brakeInput");
		NativeFieldInfoPtr_m_throttleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_throttleInput");
		NativeFieldInfoPtr_m_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_steerInput");
		NativeFieldInfoPtr_m_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_vehicle");
		NativeFieldInfoPtr_m_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_isMoving");
		NativeFieldInfoPtr_m_targetRangeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_targetRangeReached");
		NativeFieldInfoPtr_m_prevTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "m_prevTarget");
		NativeFieldInfoPtr_carPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "carPhysics");
		NativeFieldInfoPtr_hasPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, "hasPhysics");
		NativeMethodInfoPtr_SetPhysics_Public_Void_PrepareCarPhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, 100670275);
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, 100670276);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, 100670277);
		NativeMethodInfoPtr_DebugLog_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, 100670278);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSelfDrive>.NativeClassPtr, 100670279);
	}

	public VPSelfDrive(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
