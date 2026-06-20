using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

[System.Serializable]
public class VPAxle : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_leftWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeCircuit;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringRatio;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPAxle>.NativeClassPtr));

	public unsafe VPWheelCollider leftWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftWheel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftWheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPWheelCollider rightWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightWheel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightWheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Brakes.BrakeCircuit brakeCircuit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeCircuit);
			return *(Brakes.BrakeCircuit*)num;
		}
		set
		{
			*(Brakes.BrakeCircuit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeCircuit)) = brakeCircuit;
		}
	}

	public unsafe Steering.SteeringMode steeringMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringMode);
			return *(Steering.SteeringMode*)num;
		}
		set
		{
			*(Steering.SteeringMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringMode)) = steeringMode;
		}
	}

	public unsafe float steeringRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringRatio)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe VPAxle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPAxle>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPAxle()
	{
		Il2CppClassPointerStore<VPAxle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPAxle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPAxle>.NativeClassPtr);
		NativeFieldInfoPtr_leftWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAxle>.NativeClassPtr, "leftWheel");
		NativeFieldInfoPtr_rightWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAxle>.NativeClassPtr, "rightWheel");
		NativeFieldInfoPtr_brakeCircuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAxle>.NativeClassPtr, "brakeCircuit");
		NativeFieldInfoPtr_steeringMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAxle>.NativeClassPtr, "steeringMode");
		NativeFieldInfoPtr_steeringRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAxle>.NativeClassPtr, "steeringRatio");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAxle>.NativeClassPtr, 100670604);
	}

	public VPAxle(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
