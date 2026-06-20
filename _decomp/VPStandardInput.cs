using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPStandardInput : VehicleBehaviour
{
	public enum ThrottleAndBrakeMode
	{
		ThrottleAndBrake,
		AutoForwardAndReverse,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ThrottleAndBrakeMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ThrottleAndBrakeMode()
		{
			Il2CppClassPointerStore<ThrottleAndBrakeMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "ThrottleAndBrakeMode");
		}

	}

	public enum IgnitionKey
	{
		Off,
		Drive,
		Ignite,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IgnitionKey>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static IgnitionKey()
		{
			Il2CppClassPointerStore<IgnitionKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "IgnitionKey");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleAndBrakeMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeOnThrottleBackwards;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyClutchOnHandbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockDrivelineOnHandbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressiveSteerMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_SteerAngleCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_SteerCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoCenterRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleAndBrakeAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutchAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearModeSelectButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyboardNumbersSelectGears;

	private static readonly System.IntPtr NativeFieldInfoPtr_neutralGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_reverseGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableResetVehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetVehicleKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalThrottle;

	private static readonly System.IntPtr NativeFieldInfoPtr_reverse;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalBrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalHandbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalSteer;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalClutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalIgnition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_handbrakeLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ignitionKeyReleased;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_handbrakeButtonDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_doResetVehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steerValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr));

	public unsafe ThrottleAndBrakeMode throttleAndBrakeMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleAndBrakeMode);
			return *(ThrottleAndBrakeMode*)num;
		}
		set
		{
			*(ThrottleAndBrakeMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleAndBrakeMode)) = throttleAndBrakeMode;
		}
	}

	public unsafe bool brakeOnThrottleBackwards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeOnThrottleBackwards);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeOnThrottleBackwards)) = flag;
		}
	}

	public unsafe bool applyClutchOnHandbrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyClutchOnHandbrake);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyClutchOnHandbrake)) = flag;
		}
	}

	public unsafe bool unlockDrivelineOnHandbrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockDrivelineOnHandbrake);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockDrivelineOnHandbrake)) = flag;
		}
	}

	public unsafe bool progressiveSteerMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressiveSteerMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressiveSteerMode)) = flag;
		}
	}

	public unsafe AnimationCurve SteerAngleCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SteerAngleCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SteerAngleCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve SteerCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SteerCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SteerCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve AutoCenterRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoCenterRate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoCenterRate), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe KeyCode ignitionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKey)) = keyCode;
		}
	}

	public unsafe string steerAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string throttleAndBrakeAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleAndBrakeAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleAndBrakeAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string handbrakeAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string clutchAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string gearShiftButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftButton);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftButton), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string gearModeSelectButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearModeSelectButton);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearModeSelectButton), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool keyboardNumbersSelectGears
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardNumbersSelectGears);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardNumbersSelectGears)) = flag;
		}
	}

	public unsafe KeyCode neutralGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neutralGear);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neutralGear)) = keyCode;
		}
	}

	public unsafe KeyCode reverseGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseGear);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseGear)) = keyCode;
		}
	}

	public unsafe bool enableResetVehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableResetVehicle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableResetVehicle)) = flag;
		}
	}

	public unsafe KeyCode resetVehicleKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetVehicleKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetVehicleKey)) = keyCode;
		}
	}

	public unsafe float externalThrottle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalThrottle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalThrottle)) = num;
		}
	}

	public unsafe bool reverse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverse)) = flag;
		}
	}

	public unsafe float externalBrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalBrake);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalBrake)) = num;
		}
	}

	public unsafe float externalHandbrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalHandbrake);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalHandbrake)) = num;
		}
	}

	public unsafe float externalSteer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalSteer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalSteer)) = num;
		}
	}

	public unsafe float externalClutch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalClutch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalClutch)) = num;
		}
	}

	public unsafe IgnitionKey externalIgnition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalIgnition);
			return *(IgnitionKey*)num;
		}
		set
		{
			*(IgnitionKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalIgnition)) = ignitionKey;
		}
	}

	public unsafe bool m_handbrakeLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeLock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeLock)) = flag;
		}
	}

	public unsafe bool m_ignitionKeyReleased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ignitionKeyReleased);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ignitionKeyReleased)) = flag;
		}
	}

	public unsafe bool m_handbrakeButtonDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeButtonDown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeButtonDown)) = flag;
		}
	}

	public unsafe bool m_doResetVehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_doResetVehicle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_doResetVehicle)) = flag;
		}
	}

	public unsafe float m_steerValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerValue)) = num;
		}
	}

	[CallerCount(0)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111651, XrefRangeEnd = 111711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111711, XrefRangeEnd = 111747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111747, XrefRangeEnd = 111749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxis(string axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111749, XrefRangeEnd = 111751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxisRaw(string axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111751, XrefRangeEnd = 111753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButtonDown(string buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111771, RefRangeEnd = 111772, XrefRangeStart = 111753, XrefRangeEnd = 111771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPStandardInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPStandardInput()
	{
		Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPStandardInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr);
		NativeFieldInfoPtr_throttleAndBrakeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "throttleAndBrakeMode");
		NativeFieldInfoPtr_brakeOnThrottleBackwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "brakeOnThrottleBackwards");
		NativeFieldInfoPtr_applyClutchOnHandbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "applyClutchOnHandbrake");
		NativeFieldInfoPtr_unlockDrivelineOnHandbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "unlockDrivelineOnHandbrake");
		NativeFieldInfoPtr_progressiveSteerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "progressiveSteerMode");
		NativeFieldInfoPtr_SteerAngleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "SteerAngleCurve");
		NativeFieldInfoPtr_SteerCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "SteerCurve");
		NativeFieldInfoPtr_AutoCenterRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "AutoCenterRate");
		NativeFieldInfoPtr_ignitionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "ignitionKey");
		NativeFieldInfoPtr_steerAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "steerAxis");
		NativeFieldInfoPtr_throttleAndBrakeAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "throttleAndBrakeAxis");
		NativeFieldInfoPtr_handbrakeAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "handbrakeAxis");
		NativeFieldInfoPtr_clutchAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "clutchAxis");
		NativeFieldInfoPtr_gearShiftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "gearShiftButton");
		NativeFieldInfoPtr_gearModeSelectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "gearModeSelectButton");
		NativeFieldInfoPtr_keyboardNumbersSelectGears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "keyboardNumbersSelectGears");
		NativeFieldInfoPtr_neutralGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "neutralGear");
		NativeFieldInfoPtr_reverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "reverseGear");
		NativeFieldInfoPtr_enableResetVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "enableResetVehicle");
		NativeFieldInfoPtr_resetVehicleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "resetVehicleKey");
		NativeFieldInfoPtr_externalThrottle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "externalThrottle");
		NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "reverse");
		NativeFieldInfoPtr_externalBrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "externalBrake");
		NativeFieldInfoPtr_externalHandbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "externalHandbrake");
		NativeFieldInfoPtr_externalSteer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "externalSteer");
		NativeFieldInfoPtr_externalClutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "externalClutch");
		NativeFieldInfoPtr_externalIgnition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "externalIgnition");
		NativeFieldInfoPtr_m_handbrakeLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "m_handbrakeLock");
		NativeFieldInfoPtr_m_ignitionKeyReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "m_ignitionKeyReleased");
		NativeFieldInfoPtr_m_handbrakeButtonDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "m_handbrakeButtonDown");
		NativeFieldInfoPtr_m_doResetVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "m_doResetVehicle");
		NativeFieldInfoPtr_m_steerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, "m_steerValue");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670354);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670355);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670356);
		NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670357);
		NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670358);
		NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670359);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPStandardInput>.NativeClassPtr, 100670360);
	}

	public VPStandardInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
