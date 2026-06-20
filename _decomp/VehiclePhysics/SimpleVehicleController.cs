using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class SimpleVehicleController : VehicleBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wheelFL;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelFR;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelRL;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelRR;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDriveTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBrakeTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSteerAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDriveRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_driveInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_directDrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_differential;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureWheelData_Private_Void_WheelState_Wheel_VPWheelCollider_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr));

	public unsafe VPWheelCollider wheelFL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFL);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFL), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider wheelFR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFR);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFR), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider wheelRL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRL);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRL), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider wheelRR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRR);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRR), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe float maxDriveTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDriveTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDriveTorque)) = num;
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

	public unsafe float maxSteerAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSteerAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSteerAngle)) = num;
		}
	}

	public unsafe float maxDriveRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDriveRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDriveRpm)) = num;
		}
	}

	public unsafe float driveInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveInput)) = num;
		}
	}

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

	public unsafe float steerInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerInput)) = num;
		}
	}

	public unsafe DirectDrive m_directDrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_directDrive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DirectDrive(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_directDrive), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Differential m_differential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_differential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_differential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122442, XrefRangeEnd = 122511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122511, RefRangeEnd = 122515, XrefRangeStart = 122511, XrefRangeEnd = 122511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureWheelData(WheelState ws, Wheel wheel, VPWheelCollider wheelCol, bool steerable = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelCol);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &steerable;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureWheelData_Private_Void_WheelState_Wheel_VPWheelCollider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void DoUpdateBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122515, XrefRangeEnd = 122523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleVehicleController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SimpleVehicleController()
	{
		Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "SimpleVehicleController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr);
		NativeFieldInfoPtr_wheelFL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "wheelFL");
		NativeFieldInfoPtr_wheelFR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "wheelFR");
		NativeFieldInfoPtr_wheelRL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "wheelRL");
		NativeFieldInfoPtr_wheelRR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "wheelRR");
		NativeFieldInfoPtr_tireFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "tireFriction");
		NativeFieldInfoPtr_maxDriveTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "maxDriveTorque");
		NativeFieldInfoPtr_maxBrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "maxBrakeTorque");
		NativeFieldInfoPtr_maxSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "maxSteerAngle");
		NativeFieldInfoPtr_maxDriveRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "maxDriveRpm");
		NativeFieldInfoPtr_driveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "driveInput");
		NativeFieldInfoPtr_brakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "brakeInput");
		NativeFieldInfoPtr_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "steerInput");
		NativeFieldInfoPtr_m_directDrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "m_directDrive");
		NativeFieldInfoPtr_m_differential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, "m_differential");
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, 100671144);
		NativeMethodInfoPtr_ConfigureWheelData_Private_Void_WheelState_Wheel_VPWheelCollider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, 100671145);
		NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, 100671146);
		NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, 100671147);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleVehicleController>.NativeClassPtr, 100671148);
	}

	public SimpleVehicleController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
