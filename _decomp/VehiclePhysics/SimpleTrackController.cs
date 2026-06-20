using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class SimpleTrackController : VehicleBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LeftTrack0;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftTrack1;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftTrack2;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftTrack3;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightTrack0;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightTrack1;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightTrack2;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightTrack3;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackBrakeTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTrackInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTrackInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_leftDrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rightDrive;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureWheelData_Private_Void_WheelState_Wheel_VPWheelCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewLockedDifferential_Private_Differential_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTrackTransmission_Private_Void_Block_Wheel_Wheel_Wheel_Wheel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendInputToTrack_Private_Void_Int32_DirectDrive_Wheel_Wheel_Wheel_Wheel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr));

	public unsafe VPWheelCollider LeftTrack0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack0), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider LeftTrack1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider LeftTrack2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider LeftTrack3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftTrack3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider RightTrack0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack0), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider RightTrack1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider RightTrack2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider RightTrack3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightTrack3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TireFriction trackFriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackFriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TireFriction(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackFriction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float trackRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackRpm)) = num;
		}
	}

	public unsafe float trackTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackTorque)) = num;
		}
	}

	public unsafe float trackBrakeTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackBrakeTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackBrakeTorque)) = num;
		}
	}

	public unsafe int leftTrackInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTrackInput);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTrackInput)) = num;
		}
	}

	public unsafe int rightTrackInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightTrackInput);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightTrackInput)) = num;
		}
	}

	public unsafe DirectDrive m_leftDrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leftDrive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DirectDrive(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leftDrive), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DirectDrive m_rightDrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rightDrive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DirectDrive(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rightDrive), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122268, XrefRangeEnd = 122384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122384, XrefRangeEnd = 122386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DoUpdateBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 122386, RefRangeEnd = 122394, XrefRangeStart = 122386, XrefRangeEnd = 122386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureWheelData(WheelState ws, Wheel wheel, VPWheelCollider wheelCol)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelCol);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureWheelData_Private_Void_WheelState_Wheel_VPWheelCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 122398, RefRangeEnd = 122401, XrefRangeStart = 122394, XrefRangeEnd = 122398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Differential NewLockedDifferential()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewLockedDifferential_Private_Differential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Differential(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122414, RefRangeEnd = 122416, XrefRangeStart = 122401, XrefRangeEnd = 122414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTrackTransmission(Block powerTrainOutput, Wheel w0, Wheel w1, Wheel w2, Wheel w3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(powerTrainOutput);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTrackTransmission_Private_Void_Block_Wheel_Wheel_Wheel_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SendInputToTrack(int input, DirectDrive track, Wheel w0, Wheel w1, Wheel w2, Wheel w3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(track);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(w3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendInputToTrack_Private_Void_Int32_DirectDrive_Wheel_Wheel_Wheel_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122416, XrefRangeEnd = 122424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleTrackController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SimpleTrackController()
	{
		Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "SimpleTrackController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr);
		NativeFieldInfoPtr_LeftTrack0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "LeftTrack0");
		NativeFieldInfoPtr_LeftTrack1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "LeftTrack1");
		NativeFieldInfoPtr_LeftTrack2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "LeftTrack2");
		NativeFieldInfoPtr_LeftTrack3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "LeftTrack3");
		NativeFieldInfoPtr_RightTrack0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "RightTrack0");
		NativeFieldInfoPtr_RightTrack1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "RightTrack1");
		NativeFieldInfoPtr_RightTrack2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "RightTrack2");
		NativeFieldInfoPtr_RightTrack3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "RightTrack3");
		NativeFieldInfoPtr_trackFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "trackFriction");
		NativeFieldInfoPtr_trackRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "trackRpm");
		NativeFieldInfoPtr_trackTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "trackTorque");
		NativeFieldInfoPtr_trackBrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "trackBrakeTorque");
		NativeFieldInfoPtr_leftTrackInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "leftTrackInput");
		NativeFieldInfoPtr_rightTrackInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "rightTrackInput");
		NativeFieldInfoPtr_m_leftDrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "m_leftDrive");
		NativeFieldInfoPtr_m_rightDrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, "m_rightDrive");
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671134);
		NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671135);
		NativeMethodInfoPtr_ConfigureWheelData_Private_Void_WheelState_Wheel_VPWheelCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671136);
		NativeMethodInfoPtr_NewLockedDifferential_Private_Differential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671137);
		NativeMethodInfoPtr_SetupTrackTransmission_Private_Void_Block_Wheel_Wheel_Wheel_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671138);
		NativeMethodInfoPtr_SendInputToTrack_Private_Void_Int32_DirectDrive_Wheel_Wheel_Wheel_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671139);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleTrackController>.NativeClassPtr, 100671140);
	}

	public SimpleTrackController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
