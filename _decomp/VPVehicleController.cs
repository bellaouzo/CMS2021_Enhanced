using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPVehicleController : VehicleBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_axles;

	private static readonly System.IntPtr NativeFieldInfoPtr_driveline;

	private static readonly System.IntPtr NativeFieldInfoPtr_differential;

	private static readonly System.IntPtr NativeFieldInfoPtr_centerDifferential;

	private static readonly System.IntPtr NativeFieldInfoPtr_interAxleDifferential;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueSplitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_steering;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_retarder;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringAids;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_antiLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_tractionControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_stabilityControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_antiSpin;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineReactionFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steering;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_gearbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_retarder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_driveline;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_stabilityControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_antiSpin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_firstSteerableAxle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelbase;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcsOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_ecsOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_asrOverride;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalObject_Public_Virtual_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GearboxSwitchingGears_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTractionControl_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySteeringAids_Private_Void_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySteeringHelp_Private_Void_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySteeringLimit_Private_Void_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySpeedControl_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyStabilityControl_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAntiSpin_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelFinalRatio_Public_Single_Int32_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<VPAxle> axles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<VPAxle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Driveline.Settings driveline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveline);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Driveline.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveline), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Differential.Settings differential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_differential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_differential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Differential.Settings centerDifferential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerDifferential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerDifferential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Differential.Settings interAxleDifferential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interAxleDifferential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interAxleDifferential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TorqueSplitter.Settings torqueSplitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueSplitter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TorqueSplitter.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueSplitter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Steering.Settings steering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steering);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Steering.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steering), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Brakes.Settings brakes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Brakes.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TireFriction tireFriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireFriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TireFriction(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireFriction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Engine.Settings engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Engine.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Engine.ClutchSettings clutch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Engine.ClutchSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutch), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Gearbox.Settings gearbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearbox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Gearbox.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearbox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Retarder.Settings retarder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retarder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Retarder.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retarder), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SteeringAids.Settings steeringAids
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringAids);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SteeringAids.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringAids), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SpeedControl.Settings speedControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SpeedControl.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Brakes.AbsSettings antiLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiLock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Brakes.AbsSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiLock), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TractionControl.Settings tractionControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tractionControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TractionControl.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tractionControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StabilityControl.Settings stabilityControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stabilityControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StabilityControl.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stabilityControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AntiSpin.Settings antiSpin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiSpin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AntiSpin.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiSpin), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float engineReactionFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineReactionFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineReactionFactor)) = num;
		}
	}

	public unsafe Steering m_steering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steering);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Steering(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steering), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Brakes m_brakes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Brakes(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Engine m_engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Engine(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Gearbox m_gearbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gearbox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Gearbox(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gearbox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Retarder m_retarder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_retarder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Retarder(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_retarder), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Driveline m_driveline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_driveline);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Driveline(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_driveline), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StabilityControl m_stabilityControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_stabilityControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StabilityControl(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_stabilityControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AntiSpin m_antiSpin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_antiSpin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AntiSpin(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_antiSpin), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_firstSteerableAxle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstSteerableAxle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstSteerableAxle)) = num;
		}
	}

	public unsafe float m_wheelbase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelbase);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelbase)) = num;
		}
	}

	public unsafe VehicleSettingMode tcsOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsOverride);
			return *(VehicleSettingMode*)num;
		}
		set
		{
			*(VehicleSettingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsOverride)) = vehicleSettingMode;
		}
	}

	public unsafe VehicleSettingMode ecsOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsOverride);
			return *(VehicleSettingMode*)num;
		}
		set
		{
			*(VehicleSettingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsOverride)) = vehicleSettingMode;
		}
	}

	public unsafe VehicleSettingMode asrOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asrOverride);
			return *(VehicleSettingMode*)num;
		}
		set
		{
			*(VehicleSettingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asrOverride)) = vehicleSettingMode;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115804, XrefRangeEnd = 115874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPVehicleController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115874, XrefRangeEnd = 115944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115944, XrefRangeEnd = 115961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DoUpdateBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115961, XrefRangeEnd = 115969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DoUpdateData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115969, XrefRangeEnd = 115990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe Il2CppSystem.Object GetInternalObject(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetInternalObject_Public_Virtual_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void GearboxSwitchingGears()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GearboxSwitchingGears_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116005, RefRangeEnd = 116006, XrefRangeStart = 115990, XrefRangeEnd = 116005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTractionControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTractionControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116006, XrefRangeEnd = 116011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySteeringAids(ref float steerInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref steerInput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySteeringAids_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116013, RefRangeEnd = 116017, XrefRangeStart = 116011, XrefRangeEnd = 116013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySteeringHelp(ref float steerInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref steerInput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySteeringHelp_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116029, RefRangeEnd = 116033, XrefRangeStart = 116017, XrefRangeEnd = 116029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplySteeringLimit(ref float steerInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref steerInput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySteeringLimit_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116036, RefRangeEnd = 116037, XrefRangeStart = 116033, XrefRangeEnd = 116036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ApplySpeedControl(float throttleInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&throttleInput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySpeedControl_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116048, RefRangeEnd = 116049, XrefRangeStart = 116037, XrefRangeEnd = 116048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyStabilityControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyStabilityControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116050, RefRangeEnd = 116051, XrefRangeStart = 116049, XrefRangeEnd = 116050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyAntiSpin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyAntiSpin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116051, XrefRangeEnd = 116053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWheelFinalRatio(int wheelIndex, [Optional] int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&wheelIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gear;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelFinalRatio_Public_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static VPVehicleController()
	{
		Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPVehicleController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr);
		NativeFieldInfoPtr_axles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "axles");
		NativeFieldInfoPtr_driveline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "driveline");
		NativeFieldInfoPtr_differential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "differential");
		NativeFieldInfoPtr_centerDifferential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "centerDifferential");
		NativeFieldInfoPtr_interAxleDifferential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "interAxleDifferential");
		NativeFieldInfoPtr_torqueSplitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "torqueSplitter");
		NativeFieldInfoPtr_steering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "steering");
		NativeFieldInfoPtr_brakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "brakes");
		NativeFieldInfoPtr_tireFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "tireFriction");
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "clutch");
		NativeFieldInfoPtr_gearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "gearbox");
		NativeFieldInfoPtr_retarder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "retarder");
		NativeFieldInfoPtr_steeringAids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "steeringAids");
		NativeFieldInfoPtr_speedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "speedControl");
		NativeFieldInfoPtr_antiLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "antiLock");
		NativeFieldInfoPtr_tractionControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "tractionControl");
		NativeFieldInfoPtr_stabilityControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "stabilityControl");
		NativeFieldInfoPtr_antiSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "antiSpin");
		NativeFieldInfoPtr_engineReactionFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "engineReactionFactor");
		NativeFieldInfoPtr_m_steering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_steering");
		NativeFieldInfoPtr_m_brakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_brakes");
		NativeFieldInfoPtr_m_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_engine");
		NativeFieldInfoPtr_m_gearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_gearbox");
		NativeFieldInfoPtr_m_retarder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_retarder");
		NativeFieldInfoPtr_m_driveline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_driveline");
		NativeFieldInfoPtr_m_stabilityControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_stabilityControl");
		NativeFieldInfoPtr_m_antiSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_antiSpin");
		NativeFieldInfoPtr_m_firstSteerableAxle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_firstSteerableAxle");
		NativeFieldInfoPtr_m_wheelbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "m_wheelbase");
		NativeFieldInfoPtr_tcsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "tcsOverride");
		NativeFieldInfoPtr_ecsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "ecsOverride");
		NativeFieldInfoPtr_asrOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, "asrOverride");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670605);
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670606);
		NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670607);
		NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670608);
		NativeMethodInfoPtr_GetInternalObject_Public_Virtual_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670609);
		NativeMethodInfoPtr_GearboxSwitchingGears_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670610);
		NativeMethodInfoPtr_ApplyTractionControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670611);
		NativeMethodInfoPtr_ApplySteeringAids_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670612);
		NativeMethodInfoPtr_ApplySteeringHelp_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670613);
		NativeMethodInfoPtr_ApplySteeringLimit_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670614);
		NativeMethodInfoPtr_ApplySpeedControl_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670615);
		NativeMethodInfoPtr_ApplyStabilityControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670616);
		NativeMethodInfoPtr_ApplyAntiSpin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670617);
		NativeMethodInfoPtr_GetWheelFinalRatio_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleController>.NativeClassPtr, 100670618);
	}

	public VPVehicleController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
