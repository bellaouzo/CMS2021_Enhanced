using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPTwoWheelController : VehicleBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frontWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_rearWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSteerAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_primaryTransmissionRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalTransmissionRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_antiLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_tractionControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineReactionFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_equilibriumFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceKeepVertical;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_gearbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_primaryTransmission;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_finalTransmission;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalObject_Public_Virtual_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelIndex_Public_Virtual_Int32_Int32_WheelPos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GearboxSwitchingGears_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTractionControl_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySpeedControl_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelFinalRatio_Public_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr));

	public unsafe VPWheelCollider frontWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontWheel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontWheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider rearWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearWheel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearWheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe float primaryTransmissionRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryTransmissionRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryTransmissionRatio)) = num;
		}
	}

	public unsafe float finalTransmissionRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalTransmissionRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalTransmissionRatio)) = num;
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

	public unsafe float equilibriumFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equilibriumFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equilibriumFactor)) = num;
		}
	}

	public unsafe bool forceKeepVertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceKeepVertical);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceKeepVertical)) = flag;
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

	public unsafe Gear m_primaryTransmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_primaryTransmission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Gear(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_primaryTransmission), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Gear m_finalTransmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_finalTransmission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Gear(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_finalTransmission), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110848, XrefRangeEnd = 110918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110918, XrefRangeEnd = 110930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DoUpdateBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110930, XrefRangeEnd = 110938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DoUpdateData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110938, XrefRangeEnd = 110949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public new unsafe int GetWheelIndex(int axle, [Optional] WheelPos position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&axle);
		*(WheelPos**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetWheelIndex_Public_Virtual_Int32_Int32_WheelPos_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
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
	[CachedScanResults(RefRangeStart = 110960, RefRangeEnd = 110961, XrefRangeStart = 110949, XrefRangeEnd = 110960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTractionControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTractionControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110964, RefRangeEnd = 110965, XrefRangeStart = 110961, XrefRangeEnd = 110964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110965, XrefRangeEnd = 110966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110966, XrefRangeEnd = 110996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPTwoWheelController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPTwoWheelController()
	{
		Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPTwoWheelController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr);
		NativeFieldInfoPtr_frontWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "frontWheel");
		NativeFieldInfoPtr_rearWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "rearWheel");
		NativeFieldInfoPtr_maxSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "maxSteerAngle");
		NativeFieldInfoPtr_brakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "brakes");
		NativeFieldInfoPtr_tireFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "tireFriction");
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "clutch");
		NativeFieldInfoPtr_gearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "gearbox");
		NativeFieldInfoPtr_primaryTransmissionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "primaryTransmissionRatio");
		NativeFieldInfoPtr_finalTransmissionRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "finalTransmissionRatio");
		NativeFieldInfoPtr_speedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "speedControl");
		NativeFieldInfoPtr_antiLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "antiLock");
		NativeFieldInfoPtr_tractionControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "tractionControl");
		NativeFieldInfoPtr_engineReactionFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "engineReactionFactor");
		NativeFieldInfoPtr_equilibriumFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "equilibriumFactor");
		NativeFieldInfoPtr_forceKeepVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "forceKeepVertical");
		NativeFieldInfoPtr_m_brakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "m_brakes");
		NativeFieldInfoPtr_m_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "m_engine");
		NativeFieldInfoPtr_m_gearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "m_gearbox");
		NativeFieldInfoPtr_m_primaryTransmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "m_primaryTransmission");
		NativeFieldInfoPtr_m_finalTransmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, "m_finalTransmission");
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670297);
		NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670298);
		NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670299);
		NativeMethodInfoPtr_GetInternalObject_Public_Virtual_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670300);
		NativeMethodInfoPtr_GetWheelIndex_Public_Virtual_Int32_Int32_WheelPos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670301);
		NativeMethodInfoPtr_GearboxSwitchingGears_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670302);
		NativeMethodInfoPtr_ApplyTractionControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670303);
		NativeMethodInfoPtr_ApplySpeedControl_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670304);
		NativeMethodInfoPtr_GetWheelFinalRatio_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670305);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTwoWheelController>.NativeClassPtr, 100670306);
	}

	public VPTwoWheelController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
