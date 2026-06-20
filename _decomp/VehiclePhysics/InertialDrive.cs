using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class InertialDrive : Block
{
	private static readonly System.IntPtr NativeFieldInfoPtr_motorInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMotorTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutchInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_inertia;

	private static readonly System.IntPtr NativeFieldInfoPtr_u1;

	private static readonly System.IntPtr NativeFieldInfoPtr_u2;

	private static readonly System.IntPtr NativeFieldInfoPtr_u3;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output;

	private static readonly System.IntPtr NativeFieldInfoPtr_L;

	private static readonly System.IntPtr NativeFieldInfoPtr_I;

	private static readonly System.IntPtr NativeFieldInfoPtr_T;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rpm_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeInertia_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr));

	public unsafe float motorInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorInput)) = num;
		}
	}

	public unsafe float maxMotorTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMotorTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMotorTorque)) = num;
		}
	}

	public unsafe float clutchInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchInput)) = num;
		}
	}

	public unsafe float inertia
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertia);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertia)) = num;
		}
	}

	public unsafe float u1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u1)) = num;
		}
	}

	public unsafe float u2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u2)) = num;
		}
	}

	public unsafe float u3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u3);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u3)) = num;
		}
	}

	public unsafe float maxRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpm)) = num;
		}
	}

	public unsafe float damping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping)) = num;
		}
	}

	public unsafe Connection m_output
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float L
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L)) = num;
		}
	}

	public unsafe float I
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_I);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_I)) = num;
		}
	}

	public unsafe float T
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_T);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_T)) = num;
		}
	}

	public unsafe float rpm
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124694, XrefRangeEnd = 124698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rpm_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe bool CheckConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float ComputeInertia()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeInertia_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public new unsafe void GetState(ref State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void SetSubstepState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124698, XrefRangeEnd = 124709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void EvaluateTorqueDownstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void GetSubstepDerivative(ref Derivative D)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void SetState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124709, XrefRangeEnd = 124712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InertialDrive()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InertialDrive()
	{
		Il2CppClassPointerStore<InertialDrive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "InertialDrive");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr);
		NativeFieldInfoPtr_motorInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "motorInput");
		NativeFieldInfoPtr_maxMotorTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "maxMotorTorque");
		NativeFieldInfoPtr_clutchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "clutchInput");
		NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "inertia");
		NativeFieldInfoPtr_u1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "u1");
		NativeFieldInfoPtr_u2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "u2");
		NativeFieldInfoPtr_u3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "u3");
		NativeFieldInfoPtr_maxRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "maxRpm");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_m_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "m_output");
		NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "L");
		NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "I");
		NativeFieldInfoPtr_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, "T");
		NativeMethodInfoPtr_get_rpm_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671509);
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671510);
		NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671511);
		NativeMethodInfoPtr_ComputeInertia_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671512);
		NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671513);
		NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671514);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671515);
		NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671516);
		NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671517);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671518);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InertialDrive>.NativeClassPtr, 100671519);
	}

	public InertialDrive(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
