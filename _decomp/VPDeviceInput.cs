using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPDeviceInput : VehicleBehaviour
{
	public enum DeviceModel
	{
		LogitechG27,
		TrustmasterT500RS,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DeviceModel>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static DeviceModel()
		{
			Il2CppClassPointerStore<DeviceModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "DeviceModel");
		}

	}

	public enum IgnitionKey
	{
		Off = -1,
		Drive,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IgnitionKey>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static IgnitionKey()
		{
			Il2CppClassPointerStore<IgnitionKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "IgnitionKey");
		}

	}

	public enum AutomaticGear
	{
		M,
		P,
		R,
		N,
		D,
		L,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutomaticGear>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AutomaticGear()
		{
			Il2CppClassPointerStore<AutomaticGear>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "AutomaticGear");
		}

	}

	public enum G27Buttons
	{
		PaddleShifterLeft = 5,
		PaddleShifterRight = 4,
		WheelButtonLeft1 = 7,
		WheelButtonLeft2 = 20,
		WheelButtonLeft3 = 22,
		WheelButtonRight1 = 6,
		WheelButtonRight2 = 19,
		WheelButtonRight3 = 21,
		ShifterButtonUp = 15,
		ShifterButtonDown = 17,
		ShifterButtonLeft = 16,
		ShifterButtonRight = 18,
		ShifterButton1 = 0,
		ShifterButton2 = 1,
		ShifterButton3 = 2,
		ShifterButton4 = 3,
		ShifterDpadNorth = 100,
		ShifterDpadSouth = 101,
		ShifterDpadEast = 102,
		ShifterDpadWest = 103,
		ShifterDpadAnyNorth = 104,
		ShifterDpadAnySouth = 105,
		ShifterDpadAnyEast = 106,
		ShifterDpadAnyWest = 107,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G27Buttons>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static G27Buttons()
		{
			Il2CppClassPointerStore<G27Buttons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "G27Buttons");
		}

	}

	public class WheelData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_selfAlignmentTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_weightRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_gripRatio;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelData>.NativeClassPtr));

		public unsafe float selfAlignmentTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfAlignmentTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfAlignmentTorque)) = num;
			}
		}

		public unsafe float weightRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightRatio)) = num;
			}
		}

		public unsafe float gripRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gripRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gripRatio)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe WheelData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static WheelData()
		{
			Il2CppClassPointerStore<WheelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "WheelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelData>.NativeClassPtr);
			NativeFieldInfoPtr_selfAlignmentTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "selfAlignmentTorque");
			NativeFieldInfoPtr_weightRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "weightRatio");
			NativeFieldInfoPtr_gripRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "gripRatio");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelData>.NativeClassPtr, 100670353);
		}

		public WheelData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ControllerInput
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_steer;

		private static readonly System.IntPtr NativeFieldInfoPtr_throttle;

		private static readonly System.IntPtr NativeFieldInfoPtr_brake;

		private static readonly System.IntPtr NativeFieldInfoPtr_clutch;

		private static readonly System.IntPtr NativeFieldInfoPtr_handbrake;

		private static readonly System.IntPtr NativeFieldInfoPtr_parkingBrakeToggle;

		private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOn;

		private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOff;

		[FieldOffset(0)]
		public float steer;

		[FieldOffset(4)]
		public float throttle;

		[FieldOffset(8)]
		public float brake;

		[FieldOffset(12)]
		public float clutch;

		[FieldOffset(16)]
		public bool handbrake;

		[FieldOffset(17)]
		public bool parkingBrakeToggle;

		[FieldOffset(18)]
		public bool ignitionKeyOn;

		[FieldOffset(19)]
		public bool ignitionKeyOff;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr));

		static ControllerInput()
		{
			Il2CppClassPointerStore<ControllerInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "ControllerInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr);
			NativeFieldInfoPtr_steer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "steer");
			NativeFieldInfoPtr_throttle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "throttle");
			NativeFieldInfoPtr_brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "brake");
			NativeFieldInfoPtr_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "clutch");
			NativeFieldInfoPtr_handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "handbrake");
			NativeFieldInfoPtr_parkingBrakeToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "parkingBrakeToggle");
			NativeFieldInfoPtr_ignitionKeyOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "ignitionKeyOn");
			NativeFieldInfoPtr_ignitionKeyOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, "ignitionKeyOff");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerInput>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedDevice;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_digitalHandbrakeRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringNonLinearBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_axisCountForClutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackToStandardInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleRangeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleRangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRangeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutchRangeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutchRangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_manualGearPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeLocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_logicalTireWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_weightIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonLinearBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_damperCoefficient;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearPrev;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeLockToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFeedbackGui;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableTestEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_force;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableSpring;

	private static readonly System.IntPtr NativeFieldInfoPtr_springCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_springSaturation;

	private static readonly System.IntPtr NativeFieldInfoPtr_springSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDamper;

	private static readonly System.IntPtr NativeFieldInfoPtr_damperSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_frictionSaturation;

	private static readonly System.IntPtr NativeFieldInfoPtr_frictionCoefficient;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugGizmos;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ignitionKeyReleased;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_handbrakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_handbrakeLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_hasClutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_forceFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_damperFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_controller;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugLog_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeWheelData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFeedbackForce_Private_Boolean_WheelState_WheelData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessForceFeedback_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetG27ControllerInput_Private_Void_byref_ControllerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessG27Gears_Private_Void_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseG27ForceFeedback_Private_Void_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetG27ButtonDown_Private_Boolean_G27Buttons_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetG27Button_Private_Boolean_G27Buttons_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetG27DpadDirection_Private_Int32_G27Buttons_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetT300ControllerInput_Private_Void_byref_ControllerInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessT300Gears_Private_Void_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseT300ForceFeedback_Private_Void_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonUp_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPovDown_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPov_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPovDownNonStrict_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPovNonStrict_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelValue_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPedalValue_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EffectivePedalRange_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr));

	public unsafe int selectedDevice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedDevice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedDevice)) = num;
		}
	}

	public unsafe DeviceModel deviceModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceModel);
			return *(DeviceModel*)num;
		}
		set
		{
			*(DeviceModel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceModel)) = deviceModel;
		}
	}

	public unsafe float digitalHandbrakeRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digitalHandbrakeRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digitalHandbrakeRate)) = num;
		}
	}

	public unsafe float steeringNonLinearBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringNonLinearBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringNonLinearBias)) = num;
		}
	}

	public unsafe int axisCountForClutch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisCountForClutch);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisCountForClutch)) = num;
		}
	}

	public unsafe bool fallbackToStandardInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackToStandardInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackToStandardInput)) = flag;
		}
	}

	public unsafe float throttleRangeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleRangeMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleRangeMin)) = num;
		}
	}

	public unsafe float throttleRangeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleRangeMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleRangeMax)) = num;
		}
	}

	public unsafe float brakeRangeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRangeMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRangeMin)) = num;
		}
	}

	public unsafe float brakeRangeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRangeMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRangeMax)) = num;
		}
	}

	public unsafe float clutchRangeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchRangeMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchRangeMin)) = num;
		}
	}

	public unsafe float clutchRangeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchRangeMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchRangeMax)) = num;
		}
	}

	public unsafe IgnitionKey ignitionKeyPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyPosition);
			return *(IgnitionKey*)num;
		}
		set
		{
			*(IgnitionKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyPosition)) = ignitionKey;
		}
	}

	public unsafe AutomaticGear automaticGearPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPosition);
			return *(AutomaticGear*)num;
		}
		set
		{
			*(AutomaticGear*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPosition)) = automaticGear;
		}
	}

	public unsafe int manualGearPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualGearPosition);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualGearPosition)) = num;
		}
	}

	public unsafe bool handbrakeLocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeLocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeLocked)) = flag;
		}
	}

	public unsafe float logicalTireWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalTireWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalTireWidth)) = num;
		}
	}

	public unsafe float forceIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIntensity)) = num;
		}
	}

	public unsafe float weightIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightIntensity)) = num;
		}
	}

	public unsafe float nonLinearBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonLinearBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonLinearBias)) = num;
		}
	}

	public unsafe float damperCoefficient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperCoefficient);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperCoefficient)) = num;
		}
	}

	public unsafe G27Buttons gearShiftUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftUp);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftUp)) = g27Buttons;
		}
	}

	public unsafe G27Buttons gearShiftDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftDown);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftDown)) = g27Buttons;
		}
	}

	public unsafe G27Buttons automaticGearNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearNext);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearNext)) = g27Buttons;
		}
	}

	public unsafe G27Buttons automaticGearPrev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPrev);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPrev)) = g27Buttons;
		}
	}

	public unsafe G27Buttons ignitionKeyOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOn);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOn)) = g27Buttons;
		}
	}

	public unsafe G27Buttons ignitionKeyOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOff);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOff)) = g27Buttons;
		}
	}

	public unsafe G27Buttons handbrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrake);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrake)) = g27Buttons;
		}
	}

	public unsafe G27Buttons brakeLockToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLockToggle);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLockToggle)) = g27Buttons;
		}
	}

	public unsafe bool forceFeedbackGui
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFeedbackGui);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFeedbackGui)) = flag;
		}
	}

	public unsafe float positionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX)) = num;
		}
	}

	public unsafe float positionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionY)) = num;
		}
	}

	public unsafe Font font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Font(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool enableTestEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTestEffects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTestEffects)) = flag;
		}
	}

	public unsafe bool enableForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableForce)) = flag;
		}
	}

	public unsafe int force
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force)) = num;
		}
	}

	public unsafe bool enableSpring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSpring);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSpring)) = flag;
		}
	}

	public unsafe int springCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springCenter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springCenter)) = num;
		}
	}

	public unsafe int springSaturation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSaturation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSaturation)) = num;
		}
	}

	public unsafe int springSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSlope);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSlope)) = num;
		}
	}

	public unsafe bool enableDamper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDamper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDamper)) = flag;
		}
	}

	public unsafe int damperSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperSlope);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperSlope)) = num;
		}
	}

	public unsafe bool enableFriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFriction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFriction)) = flag;
		}
	}

	public unsafe int frictionSaturation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionSaturation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionSaturation)) = num;
		}
	}

	public unsafe int frictionCoefficient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionCoefficient);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionCoefficient)) = num;
		}
	}

	public unsafe bool debugGizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugGizmos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugGizmos)) = flag;
		}
	}

	public unsafe bool debugInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugInfo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugInfo)) = flag;
		}
	}

	public unsafe DIJOYSTATE2 m_state
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state);
			return new DIJOYSTATE2(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe DIJOYSTATE2 m_prevState
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevState);
			return new DIJOYSTATE2(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe float m_handbrakeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeInput)) = num;
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

	public unsafe bool m_hasClutch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_hasClutch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_hasClutch)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<WheelData> m_wheelData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WheelData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle m_style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_style);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_style), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_forceFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_forceFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_forceFactor)) = num;
		}
	}

	public unsafe float m_damperFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_damperFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_damperFactor)) = num;
		}
	}

	public unsafe ControllerInput m_controller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_controller);
			return *(ControllerInput*)num;
		}
		set
		{
			*(ControllerInput*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_controller)) = controllerInput;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111299, XrefRangeEnd = 111314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111314, XrefRangeEnd = 111377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111377, XrefRangeEnd = 111378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111378, XrefRangeEnd = 111382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111382, XrefRangeEnd = 111386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111386, XrefRangeEnd = 111399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111399, XrefRangeEnd = 111482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111489, RefRangeEnd = 111491, XrefRangeStart = 111482, XrefRangeEnd = 111489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111502, RefRangeEnd = 111503, XrefRangeStart = 111491, XrefRangeEnd = 111502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeWheelData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeWheelData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111539, RefRangeEnd = 111540, XrefRangeStart = 111503, XrefRangeEnd = 111539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ComputeFeedbackForce(VehicleBase.WheelState wheel, WheelData wheelData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFeedbackForce_Private_Boolean_WheelState_WheelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111564, RefRangeEnd = 111565, XrefRangeStart = 111540, XrefRangeEnd = 111564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111591, RefRangeEnd = 111592, XrefRangeStart = 111565, XrefRangeEnd = 111591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessForceFeedback(int steerableWheels)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&steerableWheels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessForceFeedback_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111592, XrefRangeEnd = 111596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetG27ControllerInput(ref ControllerInput controllerInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref controllerInput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetG27ControllerInput_Private_Void_byref_ControllerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111612, RefRangeEnd = 111613, XrefRangeStart = 111596, XrefRangeEnd = 111612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessG27Gears(Il2CppStructArray<int> inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessG27Gears_Private_Void_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void ParseG27ForceFeedback(ref float forceFactor, ref float damperFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref forceFactor);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref damperFactor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseG27ForceFeedback_Private_Void_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 111614, RefRangeEnd = 111620, XrefRangeStart = 111613, XrefRangeEnd = 111614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetG27ButtonDown(G27Buttons button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetG27ButtonDown_Private_Boolean_G27Buttons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 111621, RefRangeEnd = 111627, XrefRangeStart = 111620, XrefRangeEnd = 111621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetG27Button(G27Buttons button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetG27Button_Private_Boolean_G27Buttons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111627, RefRangeEnd = 111629, XrefRangeStart = 111627, XrefRangeEnd = 111627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetG27DpadDirection(G27Buttons button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetG27DpadDirection_Private_Int32_G27Buttons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111630, RefRangeEnd = 111631, XrefRangeStart = 111629, XrefRangeEnd = 111630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetT300ControllerInput(ref ControllerInput controllerInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref controllerInput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetT300ControllerInput_Private_Void_byref_ControllerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111634, RefRangeEnd = 111635, XrefRangeStart = 111631, XrefRangeEnd = 111634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessT300Gears(Il2CppStructArray<int> inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessT300Gears_Private_Void_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ParseT300ForceFeedback(ref float forceFactor, ref float damperFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref forceFactor);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref damperFactor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseT300ForceFeedback_Private_Void_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool GetButtonDown(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 111635, RefRangeEnd = 111641, XrefRangeStart = 111635, XrefRangeEnd = 111635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetButtonUp(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonUp_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetButton(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButton_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetPovDown(int directionDegrees)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&directionDegrees);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPovDown_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetPov(int directionDegrees)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&directionDegrees);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPov_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetPovDownNonStrict(int directionDegrees)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&directionDegrees);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPovDownNonStrict_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetPovNonStrict(int directionDegrees)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&directionDegrees);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPovNonStrict_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetWheelValue(int rawValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rawValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelValue_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetPedalValue(int rawValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rawValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPedalValue_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float EffectivePedalRange(float value, float rangeMin, float rangeMax)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeMin;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeMax;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EffectivePedalRange_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111641, XrefRangeEnd = 111651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPDeviceInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPDeviceInput()
	{
		Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPDeviceInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr);
		NativeFieldInfoPtr_selectedDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "selectedDevice");
		NativeFieldInfoPtr_deviceModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "deviceModel");
		NativeFieldInfoPtr_digitalHandbrakeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "digitalHandbrakeRate");
		NativeFieldInfoPtr_steeringNonLinearBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "steeringNonLinearBias");
		NativeFieldInfoPtr_axisCountForClutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "axisCountForClutch");
		NativeFieldInfoPtr_fallbackToStandardInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "fallbackToStandardInput");
		NativeFieldInfoPtr_throttleRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "throttleRangeMin");
		NativeFieldInfoPtr_throttleRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "throttleRangeMax");
		NativeFieldInfoPtr_brakeRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "brakeRangeMin");
		NativeFieldInfoPtr_brakeRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "brakeRangeMax");
		NativeFieldInfoPtr_clutchRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "clutchRangeMin");
		NativeFieldInfoPtr_clutchRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "clutchRangeMax");
		NativeFieldInfoPtr_ignitionKeyPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "ignitionKeyPosition");
		NativeFieldInfoPtr_automaticGearPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "automaticGearPosition");
		NativeFieldInfoPtr_manualGearPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "manualGearPosition");
		NativeFieldInfoPtr_handbrakeLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "handbrakeLocked");
		NativeFieldInfoPtr_logicalTireWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "logicalTireWidth");
		NativeFieldInfoPtr_forceIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "forceIntensity");
		NativeFieldInfoPtr_weightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "weightIntensity");
		NativeFieldInfoPtr_nonLinearBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "nonLinearBias");
		NativeFieldInfoPtr_damperCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "damperCoefficient");
		NativeFieldInfoPtr_gearShiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "gearShiftUp");
		NativeFieldInfoPtr_gearShiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "gearShiftDown");
		NativeFieldInfoPtr_automaticGearNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "automaticGearNext");
		NativeFieldInfoPtr_automaticGearPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "automaticGearPrev");
		NativeFieldInfoPtr_ignitionKeyOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "ignitionKeyOn");
		NativeFieldInfoPtr_ignitionKeyOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "ignitionKeyOff");
		NativeFieldInfoPtr_handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "handbrake");
		NativeFieldInfoPtr_brakeLockToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "brakeLockToggle");
		NativeFieldInfoPtr_forceFeedbackGui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "forceFeedbackGui");
		NativeFieldInfoPtr_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "positionX");
		NativeFieldInfoPtr_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "positionY");
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "font");
		NativeFieldInfoPtr_enableTestEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "enableTestEffects");
		NativeFieldInfoPtr_enableForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "enableForce");
		NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "force");
		NativeFieldInfoPtr_enableSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "enableSpring");
		NativeFieldInfoPtr_springCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "springCenter");
		NativeFieldInfoPtr_springSaturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "springSaturation");
		NativeFieldInfoPtr_springSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "springSlope");
		NativeFieldInfoPtr_enableDamper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "enableDamper");
		NativeFieldInfoPtr_damperSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "damperSlope");
		NativeFieldInfoPtr_enableFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "enableFriction");
		NativeFieldInfoPtr_frictionSaturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "frictionSaturation");
		NativeFieldInfoPtr_frictionCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "frictionCoefficient");
		NativeFieldInfoPtr_debugGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "debugGizmos");
		NativeFieldInfoPtr_debugInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "debugInfo");
		NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_state");
		NativeFieldInfoPtr_m_prevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_prevState");
		NativeFieldInfoPtr_m_ignitionKeyReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_ignitionKeyReleased");
		NativeFieldInfoPtr_m_handbrakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_handbrakeInput");
		NativeFieldInfoPtr_m_handbrakeLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_handbrakeLock");
		NativeFieldInfoPtr_m_hasClutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_hasClutch");
		NativeFieldInfoPtr_m_wheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_wheelData");
		NativeFieldInfoPtr_m_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_style");
		NativeFieldInfoPtr_m_forceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_forceFactor");
		NativeFieldInfoPtr_m_damperFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_damperFactor");
		NativeFieldInfoPtr_m_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, "m_controller");
		NativeMethodInfoPtr_DebugLog_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670320);
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670321);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670322);
		NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670323);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670324);
		NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670325);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670326);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670327);
		NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670328);
		NativeMethodInfoPtr_InitializeWheelData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670329);
		NativeMethodInfoPtr_ComputeFeedbackForce_Private_Boolean_WheelState_WheelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670330);
		NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670331);
		NativeMethodInfoPtr_ProcessForceFeedback_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670332);
		NativeMethodInfoPtr_GetG27ControllerInput_Private_Void_byref_ControllerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670333);
		NativeMethodInfoPtr_ProcessG27Gears_Private_Void_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670334);
		NativeMethodInfoPtr_ParseG27ForceFeedback_Private_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670335);
		NativeMethodInfoPtr_GetG27ButtonDown_Private_Boolean_G27Buttons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670336);
		NativeMethodInfoPtr_GetG27Button_Private_Boolean_G27Buttons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670337);
		NativeMethodInfoPtr_GetG27DpadDirection_Private_Int32_G27Buttons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670338);
		NativeMethodInfoPtr_GetT300ControllerInput_Private_Void_byref_ControllerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670339);
		NativeMethodInfoPtr_ProcessT300Gears_Private_Void_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670340);
		NativeMethodInfoPtr_ParseT300ForceFeedback_Private_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670341);
		NativeMethodInfoPtr_GetButtonDown_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670342);
		NativeMethodInfoPtr_GetButtonUp_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670343);
		NativeMethodInfoPtr_GetButton_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670344);
		NativeMethodInfoPtr_GetPovDown_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670345);
		NativeMethodInfoPtr_GetPov_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670346);
		NativeMethodInfoPtr_GetPovDownNonStrict_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670347);
		NativeMethodInfoPtr_GetPovNonStrict_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670348);
		NativeMethodInfoPtr_GetWheelValue_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670349);
		NativeMethodInfoPtr_GetPedalValue_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670350);
		NativeMethodInfoPtr_EffectivePedalRange_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670351);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDeviceInput>.NativeClassPtr, 100670352);
	}

	public VPDeviceInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
