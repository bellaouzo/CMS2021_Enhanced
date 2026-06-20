using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class SimpleWheelController : VehicleBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wheelCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBrakeTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSteerAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerInput;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr));

	public unsafe VPWheelCollider wheelCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelCollider), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117586, XrefRangeEnd = 117601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117601, XrefRangeEnd = 117605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DoUpdateBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117605, XrefRangeEnd = 117613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleWheelController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SimpleWheelController()
	{
		Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SimpleWheelController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr);
		NativeFieldInfoPtr_wheelCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, "wheelCollider");
		NativeFieldInfoPtr_tireFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, "tireFriction");
		NativeFieldInfoPtr_maxBrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, "maxBrakeTorque");
		NativeFieldInfoPtr_maxSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, "maxSteerAngle");
		NativeFieldInfoPtr_brakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, "brakeInput");
		NativeFieldInfoPtr_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, "steerInput");
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, 100670745);
		NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, 100670746);
		NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, 100670747);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleWheelController>.NativeClassPtr, 100670748);
	}

	public SimpleWheelController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
