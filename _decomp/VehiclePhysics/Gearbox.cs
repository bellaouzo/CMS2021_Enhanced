using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class Gearbox : Block
{
	public enum Type
	{
		Manual,
		Automatic,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Type()
		{
			Il2CppClassPointerStore<Type>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "Type");
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
		_Count,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutomaticGear>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AutomaticGear()
		{
			Il2CppClassPointerStore<AutomaticGear>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "AutomaticGear");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_forwardGearRatios;

		private static readonly System.IntPtr NativeFieldInfoPtr_reverseGearRatios;

		private static readonly System.IntPtr NativeFieldInfoPtr_auto2ndGearMinSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_parkRequiresStopAndBrakes;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowParkInManual;

		private static readonly System.IntPtr NativeFieldInfoPtr_manualShiftTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShift;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShiftNeutralRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShiftFirstGearRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShiftDownRevs;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShiftUpRevs;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShiftUpInterval;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoShiftDownInterval;

		private static readonly System.IntPtr NativeFieldInfoPtr_automaticTransitionTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_automaticShiftInterval;

		private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearDownRevs;

		private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearUpRevs;

		private static readonly System.IntPtr NativeFieldInfoPtr_automaticStartGear;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe Type type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(Type*)num;
			}
			set
			{
				*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = type;
			}
		}

		public unsafe Il2CppStructArray<float> forwardGearRatios
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardGearRatios);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardGearRatios), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStructArray<float> reverseGearRatios
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseGearRatios);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseGearRatios), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float auto2ndGearMinSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auto2ndGearMinSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auto2ndGearMinSpeed)) = num;
			}
		}

		public unsafe bool parkRequiresStopAndBrakes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parkRequiresStopAndBrakes);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parkRequiresStopAndBrakes)) = flag;
			}
		}

		public unsafe bool allowParkInManual
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowParkInManual);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowParkInManual)) = flag;
			}
		}

		public unsafe float manualShiftTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualShiftTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualShiftTime)) = num;
			}
		}

		public unsafe bool autoShift
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShift);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShift)) = flag;
			}
		}

		public unsafe float autoShiftNeutralRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftNeutralRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftNeutralRpm)) = num;
			}
		}

		public unsafe float autoShiftFirstGearRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftFirstGearRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftFirstGearRpm)) = num;
			}
		}

		public unsafe float autoShiftDownRevs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftDownRevs);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftDownRevs)) = num;
			}
		}

		public unsafe float autoShiftUpRevs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftUpRevs);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftUpRevs)) = num;
			}
		}

		public unsafe float autoShiftUpInterval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftUpInterval);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftUpInterval)) = num;
			}
		}

		public unsafe float autoShiftDownInterval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftDownInterval);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShiftDownInterval)) = num;
			}
		}

		public unsafe float automaticTransitionTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticTransitionTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticTransitionTime)) = num;
			}
		}

		public unsafe float automaticShiftInterval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticShiftInterval);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticShiftInterval)) = num;
			}
		}

		public unsafe float automaticGearDownRevs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearDownRevs);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearDownRevs)) = num;
			}
		}

		public unsafe float automaticGearUpRevs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearUpRevs);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearUpRevs)) = num;
			}
		}

		public unsafe int automaticStartGear
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticStartGear);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticStartGear)) = num;
			}
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124747, RefRangeEnd = 124750, XrefRangeStart = 124739, XrefRangeEnd = 124747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "type");
			NativeFieldInfoPtr_forwardGearRatios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "forwardGearRatios");
			NativeFieldInfoPtr_reverseGearRatios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "reverseGearRatios");
			NativeFieldInfoPtr_auto2ndGearMinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "auto2ndGearMinSpeed");
			NativeFieldInfoPtr_parkRequiresStopAndBrakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "parkRequiresStopAndBrakes");
			NativeFieldInfoPtr_allowParkInManual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "allowParkInManual");
			NativeFieldInfoPtr_manualShiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "manualShiftTime");
			NativeFieldInfoPtr_autoShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShift");
			NativeFieldInfoPtr_autoShiftNeutralRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShiftNeutralRpm");
			NativeFieldInfoPtr_autoShiftFirstGearRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShiftFirstGearRpm");
			NativeFieldInfoPtr_autoShiftDownRevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShiftDownRevs");
			NativeFieldInfoPtr_autoShiftUpRevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShiftUpRevs");
			NativeFieldInfoPtr_autoShiftUpInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShiftUpInterval");
			NativeFieldInfoPtr_autoShiftDownInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "autoShiftDownInterval");
			NativeFieldInfoPtr_automaticTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "automaticTransitionTime");
			NativeFieldInfoPtr_automaticShiftInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "automaticShiftInterval");
			NativeFieldInfoPtr_automaticGearDownRevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "automaticGearDownRevs");
			NativeFieldInfoPtr_automaticGearUpRevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "automaticGearUpRevs");
			NativeFieldInfoPtr_automaticStartGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "automaticStartGear");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671581);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public enum AutoShiftOverride
	{
		None,
		ForceAutoShift,
		ForceManualShift,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutoShiftOverride>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AutoShiftOverride()
		{
			Il2CppClassPointerStore<AutoShiftOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "AutoShiftOverride");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_manualGearInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_bypassAutoShift;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleBrakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleThrottle;

	private static readonly System.IntPtr NativeFieldInfoPtr_signalSwitchingGears;

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputToRpmRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_pedalSoftPressThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_pedalHardPressThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseSpeedThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr__autoShiftOverride_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_input;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output;

	private static readonly System.IntPtr NativeFieldInfoPtr_L;

	private static readonly System.IntPtr NativeFieldInfoPtr_I;

	private static readonly System.IntPtr NativeFieldInfoPtr_T;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_manualGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ratio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastEngagedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastAutoShiftTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_gearMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_automaticGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_automaticRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transitionStartedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fromGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_toGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fromRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_toRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transitionRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isSwitchingGears;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorGearMode_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorEngagedGear_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorSwitchingGears_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_autoShiftOverride_Public_get_AutoShiftOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autoShiftOverride_Public_set_Void_AutoShiftOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentGearRatio_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearRatio_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreStep_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanEngageParkMode_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanDisengageParkMode_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GearRatio_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampGear_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampReverseGear_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampForwardGear_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EngagedGear_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSwitchingGears_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShiftGearUp_Private_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShiftGearDown_Private_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAutoShiftLogic_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StandardProcessInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StandardComputeState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StandardEvaluateTorque_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoAutomaticGearSelection_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlanetaryProcessInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlanetaryComputeState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlanetaryEvaluateTorque_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StateTransitionFromZeroToGear_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StateTransitionFromGearToZero_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StateTransitionFromGearToGear_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TorqueTransitionFromZeroToGear_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TorqueTransitionFromGearToZero_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TorqueTransitionFromGearToGear_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Gearbox>.NativeClassPtr));

	public unsafe int manualGearInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualGearInput);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualGearInput)) = num;
		}
	}

	public unsafe int automaticGearInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearInput);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearInput)) = num;
		}
	}

	public unsafe int gearShiftInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftInput);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftInput)) = num;
		}
	}

	public unsafe bool bypassAutoShift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bypassAutoShift);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bypassAutoShift)) = flag;
		}
	}

	public unsafe float stateVehicleSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleSpeed)) = num;
		}
	}

	public unsafe float stateVehicleBrakes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleBrakes);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleBrakes)) = num;
		}
	}

	public unsafe float stateVehicleThrottle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleThrottle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleThrottle)) = num;
		}
	}

	public unsafe Il2CppSystem.Action signalSwitchingGears
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signalSwitchingGears);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signalSwitchingGears), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Settings settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float inputToRpmRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputToRpmRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputToRpmRatio)) = num;
		}
	}

	public unsafe float damping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping)) = num;
		}
	}

	public unsafe float pedalSoftPressThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pedalSoftPressThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pedalSoftPressThreshold)) = num;
		}
	}

	public unsafe float pedalHardPressThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pedalHardPressThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pedalHardPressThreshold)) = num;
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

	public unsafe AutoShiftOverride _autoShiftOverride_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__autoShiftOverride_k__BackingField);
			return *(AutoShiftOverride*)num;
		}
		set
		{
			*(AutoShiftOverride*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__autoShiftOverride_k__BackingField)) = autoShiftOverride;
		}
	}

	public unsafe Connection m_input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_input);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_input), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Connection m_output
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float L
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L)) = num;
		}
	}

	public unsafe float I
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_I);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_I)) = num;
		}
	}

	public unsafe float T
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_T);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_T)) = num;
		}
	}

	public unsafe int m_manualGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_manualGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_manualGear)) = num;
		}
	}

	public unsafe bool m_engaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engaged)) = flag;
		}
	}

	public unsafe float m_ratio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ratio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ratio)) = num;
		}
	}

	public unsafe float m_lastEngagedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastEngagedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastEngagedTime)) = num;
		}
	}

	public unsafe float m_lastAutoShiftTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastAutoShiftTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastAutoShiftTime)) = num;
		}
	}

	public unsafe AutomaticGear m_gearMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gearMode);
			return *(AutomaticGear*)num;
		}
		set
		{
			*(AutomaticGear*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gearMode)) = automaticGear;
		}
	}

	public unsafe int m_automaticGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_automaticGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_automaticGear)) = num;
		}
	}

	public unsafe float m_automaticRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_automaticRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_automaticRatio)) = num;
		}
	}

	public unsafe bool m_transition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transition)) = flag;
		}
	}

	public unsafe float m_transitionStartedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transitionStartedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transitionStartedTime)) = num;
		}
	}

	public unsafe int m_fromGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fromGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fromGear)) = num;
		}
	}

	public unsafe int m_toGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_toGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_toGear)) = num;
		}
	}

	public unsafe float m_fromRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fromRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fromRatio)) = num;
		}
	}

	public unsafe float m_toRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_toRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_toRatio)) = num;
		}
	}

	public unsafe float m_transitionRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transitionRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transitionRatio)) = num;
		}
	}

	public unsafe bool m_isSwitchingGears
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isSwitchingGears);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isSwitchingGears)) = flag;
		}
	}

	public unsafe int sensorGearMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorGearMode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int sensorEngagedGear
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorEngagedGear_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool sensorSwitchingGears
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorSwitchingGears_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe AutoShiftOverride autoShiftOverride
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_autoShiftOverride_Public_get_AutoShiftOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(AutoShiftOverride*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autoShiftOverride_Public_set_Void_AutoShiftOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124750, RefRangeEnd = 124752, XrefRangeStart = 124750, XrefRangeEnd = 124750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCurrentGearRatio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentGearRatio_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124754, RefRangeEnd = 124756, XrefRangeStart = 124752, XrefRangeEnd = 124754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGearRatio(int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearRatio_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe bool CheckConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124756, XrefRangeEnd = 124762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void PreStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_PreStep_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void GetState(ref State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void SetSubstepState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124762, XrefRangeEnd = 124763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ComputeStateUpstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124763, XrefRangeEnd = 124766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void EvaluateTorqueDownstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void GetSubstepDerivative(ref Derivative D)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void SetState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124766, RefRangeEnd = 124767, XrefRangeStart = 124766, XrefRangeEnd = 124766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanEngageParkMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanEngageParkMode_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool CanDisengageParkMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanDisengageParkMode_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 124767, RefRangeEnd = 124773, XrefRangeStart = 124767, XrefRangeEnd = 124767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GearRatio(int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GearRatio_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124773, RefRangeEnd = 124774, XrefRangeStart = 124773, XrefRangeEnd = 124773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ClampGear(int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampGear_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int ClampReverseGear(int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampReverseGear_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int ClampForwardGear(int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampForwardGear_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int EngagedGear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EngagedGear_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsSwitchingGears()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSwitchingGears_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void ShiftGearUp(float inRpm, float outRpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inRpm);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outRpm;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShiftGearUp_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ShiftGearDown(float inRpm, float outRpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inRpm);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outRpm;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShiftGearDown_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124785, RefRangeEnd = 124786, XrefRangeStart = 124774, XrefRangeEnd = 124785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoAutoShiftLogic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAutoShiftLogic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124800, RefRangeEnd = 124801, XrefRangeStart = 124786, XrefRangeEnd = 124800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StandardProcessInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StandardProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StandardComputeState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StandardComputeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124801, XrefRangeEnd = 124802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StandardEvaluateTorque()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StandardEvaluateTorque_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124808, RefRangeEnd = 124809, XrefRangeStart = 124802, XrefRangeEnd = 124808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int DoAutomaticGearSelection(int currentGear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentGear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAutomaticGearSelection_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124835, RefRangeEnd = 124836, XrefRangeStart = 124809, XrefRangeEnd = 124835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlanetaryProcessInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlanetaryProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124837, RefRangeEnd = 124838, XrefRangeStart = 124836, XrefRangeEnd = 124837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlanetaryComputeState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlanetaryComputeState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124856, RefRangeEnd = 124857, XrefRangeStart = 124838, XrefRangeEnd = 124856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlanetaryEvaluateTorque()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlanetaryEvaluateTorque_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124857, XrefRangeEnd = 124860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StateTransitionFromZeroToGear(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StateTransitionFromZeroToGear_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124860, XrefRangeEnd = 124863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StateTransitionFromGearToZero(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StateTransitionFromGearToZero_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124863, XrefRangeEnd = 124864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StateTransitionFromGearToGear(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StateTransitionFromGearToGear_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124871, RefRangeEnd = 124872, XrefRangeStart = 124864, XrefRangeEnd = 124871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TorqueTransitionFromZeroToGear(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TorqueTransitionFromZeroToGear_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124872, XrefRangeEnd = 124879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TorqueTransitionFromGearToZero(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TorqueTransitionFromGearToZero_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124879, XrefRangeEnd = 124886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TorqueTransitionFromGearToGear(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TorqueTransitionFromGearToGear_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124893, RefRangeEnd = 124894, XrefRangeStart = 124886, XrefRangeEnd = 124893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Gearbox()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gearbox>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Gearbox()
	{
		Il2CppClassPointerStore<Gearbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Gearbox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gearbox>.NativeClassPtr);
		NativeFieldInfoPtr_manualGearInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "manualGearInput");
		NativeFieldInfoPtr_automaticGearInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "automaticGearInput");
		NativeFieldInfoPtr_gearShiftInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "gearShiftInput");
		NativeFieldInfoPtr_bypassAutoShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "bypassAutoShift");
		NativeFieldInfoPtr_stateVehicleSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "stateVehicleSpeed");
		NativeFieldInfoPtr_stateVehicleBrakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "stateVehicleBrakes");
		NativeFieldInfoPtr_stateVehicleThrottle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "stateVehicleThrottle");
		NativeFieldInfoPtr_signalSwitchingGears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "signalSwitchingGears");
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_inputToRpmRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "inputToRpmRatio");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_pedalSoftPressThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "pedalSoftPressThreshold");
		NativeFieldInfoPtr_pedalHardPressThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "pedalHardPressThreshold");
		NativeFieldInfoPtr_inverseSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "inverseSpeedThreshold");
		NativeFieldInfoPtr__autoShiftOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "<autoShiftOverride>k__BackingField");
		NativeFieldInfoPtr_m_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_input");
		NativeFieldInfoPtr_m_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_output");
		NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "L");
		NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "I");
		NativeFieldInfoPtr_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "T");
		NativeFieldInfoPtr_m_manualGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_manualGear");
		NativeFieldInfoPtr_m_engaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_engaged");
		NativeFieldInfoPtr_m_ratio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_ratio");
		NativeFieldInfoPtr_m_lastEngagedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_lastEngagedTime");
		NativeFieldInfoPtr_m_lastAutoShiftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_lastAutoShiftTime");
		NativeFieldInfoPtr_m_gearMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_gearMode");
		NativeFieldInfoPtr_m_automaticGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_automaticGear");
		NativeFieldInfoPtr_m_automaticRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_automaticRatio");
		NativeFieldInfoPtr_m_transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_transition");
		NativeFieldInfoPtr_m_transitionStartedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_transitionStartedTime");
		NativeFieldInfoPtr_m_fromGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_fromGear");
		NativeFieldInfoPtr_m_toGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_toGear");
		NativeFieldInfoPtr_m_fromRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_fromRatio");
		NativeFieldInfoPtr_m_toRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_toRatio");
		NativeFieldInfoPtr_m_transitionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_transitionRatio");
		NativeFieldInfoPtr_m_isSwitchingGears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, "m_isSwitchingGears");
		NativeMethodInfoPtr_get_sensorGearMode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671539);
		NativeMethodInfoPtr_get_sensorEngagedGear_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671540);
		NativeMethodInfoPtr_get_sensorSwitchingGears_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671541);
		NativeMethodInfoPtr_get_autoShiftOverride_Public_get_AutoShiftOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671542);
		NativeMethodInfoPtr_set_autoShiftOverride_Public_set_Void_AutoShiftOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671543);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671544);
		NativeMethodInfoPtr_GetCurrentGearRatio_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671545);
		NativeMethodInfoPtr_GetGearRatio_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671546);
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671547);
		NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671548);
		NativeMethodInfoPtr_PreStep_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671549);
		NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671550);
		NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671551);
		NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671552);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671553);
		NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671554);
		NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671555);
		NativeMethodInfoPtr_CanEngageParkMode_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671556);
		NativeMethodInfoPtr_CanDisengageParkMode_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671557);
		NativeMethodInfoPtr_GearRatio_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671558);
		NativeMethodInfoPtr_ClampGear_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671559);
		NativeMethodInfoPtr_ClampReverseGear_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671560);
		NativeMethodInfoPtr_ClampForwardGear_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671561);
		NativeMethodInfoPtr_EngagedGear_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671562);
		NativeMethodInfoPtr_IsSwitchingGears_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671563);
		NativeMethodInfoPtr_ShiftGearUp_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671564);
		NativeMethodInfoPtr_ShiftGearDown_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671565);
		NativeMethodInfoPtr_DoAutoShiftLogic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671566);
		NativeMethodInfoPtr_StandardProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671567);
		NativeMethodInfoPtr_StandardComputeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671568);
		NativeMethodInfoPtr_StandardEvaluateTorque_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671569);
		NativeMethodInfoPtr_DoAutomaticGearSelection_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671570);
		NativeMethodInfoPtr_PlanetaryProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671571);
		NativeMethodInfoPtr_PlanetaryComputeState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671572);
		NativeMethodInfoPtr_PlanetaryEvaluateTorque_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671573);
		NativeMethodInfoPtr_StateTransitionFromZeroToGear_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671574);
		NativeMethodInfoPtr_StateTransitionFromGearToZero_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671575);
		NativeMethodInfoPtr_StateTransitionFromGearToGear_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671576);
		NativeMethodInfoPtr_TorqueTransitionFromZeroToGear_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671577);
		NativeMethodInfoPtr_TorqueTransitionFromGearToZero_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671578);
		NativeMethodInfoPtr_TorqueTransitionFromGearToGear_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671579);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gearbox>.NativeClassPtr, 100671580);
	}

	public Gearbox(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
