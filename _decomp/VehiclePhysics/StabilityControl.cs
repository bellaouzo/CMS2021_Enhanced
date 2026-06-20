using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class StabilityControl : Il2CppSystem.Object
{
	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_understeerMinRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_understeerMaxRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_understeerMinSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_oversteerMinAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_oversteerMaxAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_oversteerMinSpeed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

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

		public unsafe float minSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed)) = num;
			}
		}

		public unsafe float understeerMinRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_understeerMinRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_understeerMinRate)) = num;
			}
		}

		public unsafe float understeerMaxRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_understeerMaxRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_understeerMaxRate)) = num;
			}
		}

		public unsafe float understeerMinSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_understeerMinSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_understeerMinSpeed)) = num;
			}
		}

		public unsafe float oversteerMinAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oversteerMinAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oversteerMinAngle)) = num;
			}
		}

		public unsafe float oversteerMaxAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oversteerMaxAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oversteerMaxAngle)) = num;
			}
		}

		public unsafe float oversteerMinSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oversteerMinSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oversteerMinSpeed)) = num;
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "minSpeed");
			NativeFieldInfoPtr_understeerMinRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "understeerMinRate");
			NativeFieldInfoPtr_understeerMaxRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "understeerMaxRate");
			NativeFieldInfoPtr_understeerMinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "understeerMinSpeed");
			NativeFieldInfoPtr_oversteerMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "oversteerMinAngle");
			NativeFieldInfoPtr_oversteerMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "oversteerMaxAngle");
			NativeFieldInfoPtr_oversteerMinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "oversteerMinSpeed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671460);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelbase;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleSpeedAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleRotationRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleSteeringAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr__ecsOverride_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorEngaged_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorUndersteerL_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorUndersteerR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorOversteerL_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorOversteerR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorBrakeFL_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorBrakeFR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorBrakeRL_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorBrakeRR_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_espBrakeFL;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_espBrakeFR;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_espBrakeRL;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_espBrakeRR;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ecsOverride_Public_get_VehicleSettingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ecsOverride_Public_set_Void_VehicleSettingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorEngaged_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorEngaged_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorUndersteerL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorUndersteerL_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorUndersteerR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorUndersteerR_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorOversteerL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorOversteerL_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorOversteerR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorOversteerR_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorBrakeFL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorBrakeFL_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorBrakeFR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorBrakeFR_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorBrakeRL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorBrakeRL_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorBrakeRR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorBrakeRR_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr));

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

	public unsafe float wheelbase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelbase);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelbase)) = num;
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

	public unsafe float stateVehicleSpeedAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleSpeedAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleSpeedAngle)) = num;
		}
	}

	public unsafe float stateVehicleRotationRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleRotationRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleRotationRate)) = num;
		}
	}

	public unsafe float stateVehicleSteeringAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleSteeringAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateVehicleSteeringAngle)) = num;
		}
	}

	public unsafe VehicleSettingMode _ecsOverride_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ecsOverride_k__BackingField);
			return *(VehicleSettingMode*)num;
		}
		set
		{
			*(VehicleSettingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ecsOverride_k__BackingField)) = vehicleSettingMode;
		}
	}

	public unsafe bool _sensorEngaged_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorEngaged_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorEngaged_k__BackingField)) = flag;
		}
	}

	public unsafe float _sensorUndersteerL_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorUndersteerL_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorUndersteerL_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorUndersteerR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorUndersteerR_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorUndersteerR_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorOversteerL_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorOversteerL_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorOversteerL_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorOversteerR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorOversteerR_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorOversteerR_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorBrakeFL_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeFL_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeFL_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorBrakeFR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeFR_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeFR_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorBrakeRL_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeRL_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeRL_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorBrakeRR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeRR_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeRR_k__BackingField)) = num;
		}
	}

	public unsafe float m_espBrakeFL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeFL);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeFL)) = num;
		}
	}

	public unsafe float m_espBrakeFR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeFR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeFR)) = num;
		}
	}

	public unsafe float m_espBrakeRL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeRL);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeRL)) = num;
		}
	}

	public unsafe float m_espBrakeRR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeRR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_espBrakeRR)) = num;
		}
	}

	public unsafe VehicleSettingMode ecsOverride
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ecsOverride_Public_get_VehicleSettingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VehicleSettingMode*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ecsOverride_Public_set_Void_VehicleSettingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool sensorEngaged
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorEngaged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorEngaged_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorUndersteerL
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorUndersteerL_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorUndersteerL_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorUndersteerR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorUndersteerR_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorUndersteerR_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorOversteerL
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorOversteerL_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorOversteerL_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorOversteerR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorOversteerR_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorOversteerR_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorBrakeFL
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorBrakeFL_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorBrakeFL_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorBrakeFR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorBrakeFR_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorBrakeFR_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorBrakeRL
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorBrakeRL_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorBrakeRL_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorBrakeRR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorBrakeRR_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorBrakeRR_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124448, RefRangeEnd = 124449, XrefRangeStart = 124441, XrefRangeEnd = 124448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124449, XrefRangeEnd = 124452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StabilityControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StabilityControl()
	{
		Il2CppClassPointerStore<StabilityControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "StabilityControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_wheelbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "wheelbase");
		NativeFieldInfoPtr_stateVehicleSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "stateVehicleSpeed");
		NativeFieldInfoPtr_stateVehicleSpeedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "stateVehicleSpeedAngle");
		NativeFieldInfoPtr_stateVehicleRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "stateVehicleRotationRate");
		NativeFieldInfoPtr_stateVehicleSteeringAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "stateVehicleSteeringAngle");
		NativeFieldInfoPtr__ecsOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<ecsOverride>k__BackingField");
		NativeFieldInfoPtr__sensorEngaged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorEngaged>k__BackingField");
		NativeFieldInfoPtr__sensorUndersteerL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorUndersteerL>k__BackingField");
		NativeFieldInfoPtr__sensorUndersteerR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorUndersteerR>k__BackingField");
		NativeFieldInfoPtr__sensorOversteerL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorOversteerL>k__BackingField");
		NativeFieldInfoPtr__sensorOversteerR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorOversteerR>k__BackingField");
		NativeFieldInfoPtr__sensorBrakeFL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorBrakeFL>k__BackingField");
		NativeFieldInfoPtr__sensorBrakeFR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorBrakeFR>k__BackingField");
		NativeFieldInfoPtr__sensorBrakeRL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorBrakeRL>k__BackingField");
		NativeFieldInfoPtr__sensorBrakeRR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "<sensorBrakeRR>k__BackingField");
		NativeFieldInfoPtr_m_espBrakeFL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "m_espBrakeFL");
		NativeFieldInfoPtr_m_espBrakeFR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "m_espBrakeFR");
		NativeFieldInfoPtr_m_espBrakeRL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "m_espBrakeRL");
		NativeFieldInfoPtr_m_espBrakeRR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, "m_espBrakeRR");
		NativeMethodInfoPtr_get_ecsOverride_Public_get_VehicleSettingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671438);
		NativeMethodInfoPtr_set_ecsOverride_Public_set_Void_VehicleSettingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671439);
		NativeMethodInfoPtr_get_sensorEngaged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671440);
		NativeMethodInfoPtr_set_sensorEngaged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671441);
		NativeMethodInfoPtr_get_sensorUndersteerL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671442);
		NativeMethodInfoPtr_set_sensorUndersteerL_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671443);
		NativeMethodInfoPtr_get_sensorUndersteerR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671444);
		NativeMethodInfoPtr_set_sensorUndersteerR_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671445);
		NativeMethodInfoPtr_get_sensorOversteerL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671446);
		NativeMethodInfoPtr_set_sensorOversteerL_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671447);
		NativeMethodInfoPtr_get_sensorOversteerR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671448);
		NativeMethodInfoPtr_set_sensorOversteerR_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671449);
		NativeMethodInfoPtr_get_sensorBrakeFL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671450);
		NativeMethodInfoPtr_set_sensorBrakeFL_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671451);
		NativeMethodInfoPtr_get_sensorBrakeFR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671452);
		NativeMethodInfoPtr_set_sensorBrakeFR_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671453);
		NativeMethodInfoPtr_get_sensorBrakeRL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671454);
		NativeMethodInfoPtr_set_sensorBrakeRL_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671455);
		NativeMethodInfoPtr_get_sensorBrakeRR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671456);
		NativeMethodInfoPtr_set_sensorBrakeRR_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671457);
		NativeMethodInfoPtr_DoUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671458);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StabilityControl>.NativeClassPtr, 100671459);
	}

	public StabilityControl(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
