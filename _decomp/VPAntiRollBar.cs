using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPAntiRollBar : VehicleBehaviour
{
	public enum Mode
	{
		Stiffness,
		SpringRate,
		Legacy,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_axle;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_stiffness;

	private static readonly System.IntPtr NativeFieldInfoPtr_rigidity;

	private static readonly System.IntPtr NativeFieldInfoPtr_springRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_antiRollRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_leftState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_leftCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rightState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rightCollider;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicleSuspension_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr));

	public unsafe int axle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axle)) = num;
		}
	}

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
		}
	}

	public unsafe float stiffness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stiffness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stiffness)) = num;
		}
	}

	public unsafe float rigidity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidity)) = num;
		}
	}

	public unsafe float springRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRate)) = num;
		}
	}

	public unsafe float antiRollRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiRollRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiRollRate)) = num;
		}
	}

	public unsafe VehicleBase.WheelState m_leftState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leftState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VehicleBase.WheelState(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leftState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider m_leftCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leftCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_leftCollider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VehicleBase.WheelState m_rightState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rightState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VehicleBase.WheelState(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rightState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider m_rightCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rightCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rightCollider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114286, XrefRangeEnd = 114288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114288, XrefRangeEnd = 114291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicleSuspension()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicleSuspension_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114291, XrefRangeEnd = 114294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPAntiRollBar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPAntiRollBar()
	{
		Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPAntiRollBar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr);
		NativeFieldInfoPtr_axle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "axle");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_stiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "stiffness");
		NativeFieldInfoPtr_rigidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "rigidity");
		NativeFieldInfoPtr_springRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "springRate");
		NativeFieldInfoPtr_antiRollRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "antiRollRate");
		NativeFieldInfoPtr_m_leftState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "m_leftState");
		NativeFieldInfoPtr_m_leftCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "m_leftCollider");
		NativeFieldInfoPtr_m_rightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "m_rightState");
		NativeFieldInfoPtr_m_rightCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, "m_rightCollider");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, 100670489);
		NativeMethodInfoPtr_UpdateVehicleSuspension_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, 100670490);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAntiRollBar>.NativeClassPtr, 100670491);
	}

	public VPAntiRollBar(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
