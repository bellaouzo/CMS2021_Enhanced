using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPSuspensionModifier : VehicleBehaviour
{
	public enum Wheel
	{
		Left,
		Right,
		Both,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Wheel>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Wheel()
		{
			Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "Wheel");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_axle;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_springRateOffsetAtMinDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_springRateOffsetAtMaxDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_leftState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_leftCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rightState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rightCollider;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr));

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

	public unsafe Wheel wheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheel);
			return *(Wheel*)num;
		}
		set
		{
			*(Wheel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheel)) = wheel;
		}
	}

	public unsafe float springRateOffsetAtMinDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRateOffsetAtMinDepth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRateOffsetAtMinDepth)) = num;
		}
	}

	public unsafe float springRateOffsetAtMaxDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRateOffsetAtMaxDepth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRateOffsetAtMaxDepth)) = num;
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110827, XrefRangeEnd = 110829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110829, XrefRangeEnd = 110833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110833, XrefRangeEnd = 110836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPSuspensionModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPSuspensionModifier()
	{
		Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPSuspensionModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr);
		NativeFieldInfoPtr_axle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "axle");
		NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "wheel");
		NativeFieldInfoPtr_springRateOffsetAtMinDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "springRateOffsetAtMinDepth");
		NativeFieldInfoPtr_springRateOffsetAtMaxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "springRateOffsetAtMaxDepth");
		NativeFieldInfoPtr_m_leftState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "m_leftState");
		NativeFieldInfoPtr_m_leftCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "m_leftCollider");
		NativeFieldInfoPtr_m_rightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "m_rightState");
		NativeFieldInfoPtr_m_rightCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, "m_rightCollider");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, 100670291);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, 100670292);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionModifier>.NativeClassPtr, 100670293);
	}

	public VPSuspensionModifier(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
