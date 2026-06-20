using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class Brakes : Il2CppSystem.Object
{
	public enum BrakeCircuit
	{
		Neutral,
		Front,
		Rear,
		NoBrakes,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BrakeCircuit>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static BrakeCircuit()
		{
			Il2CppClassPointerStore<BrakeCircuit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "BrakeCircuit");
		}

	}

	public enum LateralPosition
	{
		Undefined,
		Left,
		Right,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LateralPosition>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static LateralPosition()
		{
			Il2CppClassPointerStore<LateralPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "LateralPosition");
		}

	}

	public enum AbsMode
	{
		Simple,
		MultiPosition,
		Continuous,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AbsMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AbsMode()
		{
			Il2CppClassPointerStore<AbsMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "AbsMode");
		}

	}

	public enum AbsTrigger
	{
		PeakSlipOffset,
		CustomSlip,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AbsTrigger>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AbsTrigger()
		{
			Il2CppClassPointerStore<AbsTrigger>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "AbsTrigger");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_maxBrakeTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_brakeBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeAxle;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe float maxBrakeTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBrakeTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBrakeTorque)) = num;
			}
		}

		public unsafe float brakeBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeBias)) = num;
			}
		}

		public unsafe float handbrakeTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeTorque)) = num;
			}
		}

		public unsafe float handbrakeAxle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeAxle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeAxle)) = num;
			}
		}

		[CallerCount(0)]
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_maxBrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxBrakeTorque");
			NativeFieldInfoPtr_brakeBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "brakeBias");
			NativeFieldInfoPtr_handbrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "handbrakeTorque");
			NativeFieldInfoPtr_handbrakeAxle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "handbrakeAxle");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671598);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class AbsSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_trigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSlipOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSlipOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSlip;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSlip;

		private static readonly System.IntPtr NativeFieldInfoPtr_minPressureRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_valvePositions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr));

		public unsafe bool enabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
			}
		}

		public unsafe AbsMode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(AbsMode*)num;
			}
			set
			{
				*(AbsMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = absMode;
			}
		}

		public unsafe AbsTrigger trigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trigger);
				return *(AbsTrigger*)num;
			}
			set
			{
				*(AbsTrigger*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trigger)) = absTrigger;
			}
		}

		public unsafe float minSlipOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlipOffset);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlipOffset)) = num;
			}
		}

		public unsafe float maxSlipOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlipOffset);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlipOffset)) = num;
			}
		}

		public unsafe float minSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlip)) = num;
			}
		}

		public unsafe float maxSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlip)) = num;
			}
		}

		public unsafe float minPressureRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPressureRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPressureRatio)) = num;
			}
		}

		public unsafe int valvePositions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valvePositions);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valvePositions)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe AbsSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static AbsSettings()
		{
			Il2CppClassPointerStore<AbsSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "AbsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr);
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "trigger");
			NativeFieldInfoPtr_minSlipOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "minSlipOffset");
			NativeFieldInfoPtr_maxSlipOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "maxSlipOffset");
			NativeFieldInfoPtr_minSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "minSlip");
			NativeFieldInfoPtr_maxSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "maxSlip");
			NativeFieldInfoPtr_minPressureRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "minPressureRatio");
			NativeFieldInfoPtr_valvePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, "valvePositions");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsSettings>.NativeClassPtr, 100671599);
		}

		public AbsSettings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public enum AbsOverride
	{
		None,
		ForceEnabled,
		ForceDisabled,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AbsOverride>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AbsOverride()
		{
			Il2CppClassPointerStore<AbsOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "AbsOverride");
		}

	}

	public class WheelData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_positionRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_wheel;

		private static readonly System.IntPtr NativeFieldInfoPtr_wheelState;

		private static readonly System.IntPtr NativeFieldInfoPtr_lateralPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_externalBrakeRatio;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelData>.NativeClassPtr));

		public unsafe float positionRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionRatio)) = num;
			}
		}

		public unsafe Wheel wheel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Wheel(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe VehicleBase.WheelState wheelState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelState);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new VehicleBase.WheelState(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelState), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe LateralPosition lateralPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lateralPosition);
				return *(LateralPosition*)num;
			}
			set
			{
				*(LateralPosition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lateralPosition)) = lateralPosition;
			}
		}

		public unsafe float externalBrakeRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalBrakeRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalBrakeRatio)) = num;
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
			Il2CppClassPointerStore<WheelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "WheelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelData>.NativeClassPtr);
			NativeFieldInfoPtr_positionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "positionRatio");
			NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "wheel");
			NativeFieldInfoPtr_wheelState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "wheelState");
			NativeFieldInfoPtr_lateralPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "lateralPosition");
			NativeFieldInfoPtr_externalBrakeRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "externalBrakeRatio");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelData>.NativeClassPtr, 100671600);
		}

		public WheelData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_absSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__absOverride_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_absActivationTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorAbsEngaged_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_absOverride_Public_get_AbsOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_absOverride_Public_set_Void_AbsOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Wheel_Single_LateralPosition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Wheel_BrakeCircuit_LateralPosition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBrakeRatio_Public_Void_Single_BrakeCircuit_LateralPosition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValvePressureRatio_Private_Single_WheelData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Brakes>.NativeClassPtr));

	public unsafe float brakeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeInput)) = num;
		}
	}

	public unsafe float handbrakeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeInput)) = num;
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

	public unsafe AbsSettings absSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_absSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AbsSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_absSettings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AbsOverride _absOverride_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__absOverride_k__BackingField);
			return *(AbsOverride*)num;
		}
		set
		{
			*(AbsOverride*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__absOverride_k__BackingField)) = absOverride;
		}
	}

	public unsafe List<WheelData> m_wheelData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<WheelData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_absActivationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_absActivationTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_absActivationTime)) = num;
		}
	}

	public unsafe bool sensorAbsEngaged
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124912, XrefRangeEnd = 124914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorAbsEngaged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe AbsOverride absOverride
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_absOverride_Public_get_AbsOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(AbsOverride*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_absOverride_Public_set_Void_AbsOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124914, XrefRangeEnd = 124922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWheel(VehicleBase.WheelState wheelState, Wheel wheel, [Optional] float relPosition, [Optional] LateralPosition lateralPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &relPosition;
		*(LateralPosition**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lateralPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Wheel_Single_LateralPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124930, RefRangeEnd = 124934, XrefRangeStart = 124922, XrefRangeEnd = 124930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWheel(VehicleBase.WheelState wheelState, Wheel wheel, BrakeCircuit circuit, [Optional] LateralPosition lateralPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		*(BrakeCircuit**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &circuit;
		*(LateralPosition**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lateralPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Wheel_BrakeCircuit_LateralPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124934, XrefRangeEnd = 124937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBrakeRatio(float ratio, BrakeCircuit circuit, LateralPosition lateralPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ratio);
		*(BrakeCircuit**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &circuit;
		*(LateralPosition**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lateralPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBrakeRatio_Public_Void_Single_BrakeCircuit_LateralPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124944, RefRangeEnd = 124946, XrefRangeStart = 124937, XrefRangeEnd = 124944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124950, RefRangeEnd = 124951, XrefRangeStart = 124946, XrefRangeEnd = 124950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetValvePressureRatio(WheelData wd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValvePressureRatio_Private_Single_WheelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124963, RefRangeEnd = 124965, XrefRangeStart = 124951, XrefRangeEnd = 124963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Brakes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Brakes>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Brakes()
	{
		Il2CppClassPointerStore<Brakes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Brakes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Brakes>.NativeClassPtr);
		NativeFieldInfoPtr_brakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "brakeInput");
		NativeFieldInfoPtr_handbrakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "handbrakeInput");
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_absSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "absSettings");
		NativeFieldInfoPtr__absOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "<absOverride>k__BackingField");
		NativeFieldInfoPtr_m_wheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "m_wheelData");
		NativeFieldInfoPtr_m_absActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Brakes>.NativeClassPtr, "m_absActivationTime");
		NativeMethodInfoPtr_get_sensorAbsEngaged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671589);
		NativeMethodInfoPtr_get_absOverride_Public_get_AbsOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671590);
		NativeMethodInfoPtr_set_absOverride_Public_set_Void_AbsOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671591);
		NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Wheel_Single_LateralPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671592);
		NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Wheel_BrakeCircuit_LateralPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671593);
		NativeMethodInfoPtr_AddBrakeRatio_Public_Void_Single_BrakeCircuit_LateralPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671594);
		NativeMethodInfoPtr_DoUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671595);
		NativeMethodInfoPtr_GetValvePressureRatio_Private_Single_WheelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671596);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Brakes>.NativeClassPtr, 100671597);
	}

	public Brakes(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
