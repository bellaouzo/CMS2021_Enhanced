using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPTireFrictionModifier : VehicleBehaviour
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
			Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, "Wheel");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_axle;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalLeftFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalRightFriction;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr));

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

	public unsafe TireFriction m_originalLeftFriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalLeftFriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TireFriction(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalLeftFriction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TireFriction m_originalRightFriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRightFriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TireFriction(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRightFriction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110836, XrefRangeEnd = 110839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110839, XrefRangeEnd = 110841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110841, XrefRangeEnd = 110848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPTireFrictionModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPTireFrictionModifier()
	{
		Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPTireFrictionModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr);
		NativeFieldInfoPtr_axle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, "axle");
		NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, "wheel");
		NativeFieldInfoPtr_tireFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, "tireFriction");
		NativeFieldInfoPtr_m_originalLeftFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, "m_originalLeftFriction");
		NativeFieldInfoPtr_m_originalRightFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, "m_originalRightFriction");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, 100670294);
		NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, 100670295);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireFrictionModifier>.NativeClassPtr, 100670296);
	}

	public VPTireFrictionModifier(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
