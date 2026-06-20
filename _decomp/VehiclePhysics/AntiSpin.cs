using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class AntiSpin : Il2CppSystem.Object
{
	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_minRotationDiffRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxRotationDiffRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxBrakeTorque;

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

		public unsafe float minRotationDiffRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRotationDiffRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minRotationDiffRpm)) = num;
			}
		}

		public unsafe float maxRotationDiffRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRotationDiffRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRotationDiffRpm)) = num;
			}
		}

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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxSpeed");
			NativeFieldInfoPtr_minRotationDiffRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "minRotationDiffRpm");
			NativeFieldInfoPtr_maxRotationDiffRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxRotationDiffRpm");
			NativeFieldInfoPtr_maxBrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxBrakeTorque");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671429);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateVehicleSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateAngularVelocityL;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateAngularVelocityR;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorEngaged_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorBrakeTorqueL_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sensorBrakeTorqueR_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorEngaged_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorEngaged_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorBrakeTorqueL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorBrakeTorqueL_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorBrakeTorqueR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sensorBrakeTorqueR_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr));

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

	public unsafe float stateAngularVelocityL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateAngularVelocityL);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateAngularVelocityL)) = num;
		}
	}

	public unsafe float stateAngularVelocityR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateAngularVelocityR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateAngularVelocityR)) = num;
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

	public unsafe float _sensorBrakeTorqueL_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeTorqueL_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeTorqueL_k__BackingField)) = num;
		}
	}

	public unsafe float _sensorBrakeTorqueR_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeTorqueR_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sensorBrakeTorqueR_k__BackingField)) = num;
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

	public unsafe float sensorBrakeTorqueL
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorBrakeTorqueL_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorBrakeTorqueL_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float sensorBrakeTorqueR
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorBrakeTorqueR_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sensorBrakeTorqueR_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124437, RefRangeEnd = 124438, XrefRangeStart = 124431, XrefRangeEnd = 124437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124438, XrefRangeEnd = 124441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AntiSpin()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AntiSpin()
	{
		Il2CppClassPointerStore<AntiSpin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "AntiSpin");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_stateVehicleSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "stateVehicleSpeed");
		NativeFieldInfoPtr_stateAngularVelocityL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "stateAngularVelocityL");
		NativeFieldInfoPtr_stateAngularVelocityR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "stateAngularVelocityR");
		NativeFieldInfoPtr__sensorEngaged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "<sensorEngaged>k__BackingField");
		NativeFieldInfoPtr__sensorBrakeTorqueL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "<sensorBrakeTorqueL>k__BackingField");
		NativeFieldInfoPtr__sensorBrakeTorqueR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, "<sensorBrakeTorqueR>k__BackingField");
		NativeMethodInfoPtr_get_sensorEngaged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671421);
		NativeMethodInfoPtr_set_sensorEngaged_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671422);
		NativeMethodInfoPtr_get_sensorBrakeTorqueL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671423);
		NativeMethodInfoPtr_set_sensorBrakeTorqueL_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671424);
		NativeMethodInfoPtr_get_sensorBrakeTorqueR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671425);
		NativeMethodInfoPtr_set_sensorBrakeTorqueR_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671426);
		NativeMethodInfoPtr_DoUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671427);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiSpin>.NativeClassPtr, 100671428);
	}

	public AntiSpin(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
