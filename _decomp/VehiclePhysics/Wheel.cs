using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class Wheel : Block
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tireFriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_mass;

	private static readonly System.IntPtr NativeFieldInfoPtr_I;

	private static readonly System.IntPtr NativeFieldInfoPtr_invI;

	private static readonly System.IntPtr NativeFieldInfoPtr_load;

	private static readonly System.IntPtr NativeFieldInfoPtr_grip;

	private static readonly System.IntPtr NativeFieldInfoPtr_V;

	private static readonly System.IntPtr NativeFieldInfoPtr_Fext;

	private static readonly System.IntPtr NativeFieldInfoPtr_Treact;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brakeTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_L;

	private static readonly System.IntPtr NativeFieldInfoPtr_P;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_T;

	private static readonly System.IntPtr NativeFieldInfoPtr_F;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tr;

	private static readonly System.IntPtr NativeFieldInfoPtr_isResting;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_forwardSlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_tireForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isAdherent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_adherentSlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_adherentForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_inTd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_inTb;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_contact;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug1;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug2;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug3;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateConstants_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inertia_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBrakeTorque_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBrakeTorque_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateVars_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_driveTorque_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_brakeTorque_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_contactPatch_Public_get_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SolveSymmetricConstraint_Private_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Wheel>.NativeClassPtr));

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

	public unsafe float radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
		}
	}

	public unsafe float mass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass)) = num;
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

	public unsafe float invI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invI);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invI)) = num;
		}
	}

	public unsafe float load
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_load);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_load)) = num;
		}
	}

	public unsafe float grip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grip)) = num;
		}
	}

	public unsafe Vector2 V
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_V);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_V)) = vector;
		}
	}

	public unsafe Vector2 Fext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fext);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fext)) = vector;
		}
	}

	public unsafe float Treact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Treact);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Treact)) = num;
		}
	}

	public unsafe float m_brakeTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakeTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakeTorque)) = num;
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

	public unsafe Vector2 P
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_P);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_P)) = vector;
		}
	}

	public unsafe float w
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w)) = num;
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

	public unsafe Vector2 F
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_F);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_F)) = vector;
		}
	}

	public unsafe float Tr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tr);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tr)) = num;
		}
	}

	public unsafe bool isResting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isResting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isResting)) = flag;
		}
	}

	public unsafe float m_forwardSlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_forwardSlip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_forwardSlip)) = num;
		}
	}

	public unsafe Vector2 m_tireForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tireForce);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tireForce)) = vector;
		}
	}

	public unsafe float m_Ty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ty);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ty)) = num;
		}
	}

	public unsafe bool m_isAdherent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isAdherent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isAdherent)) = flag;
		}
	}

	public unsafe Vector2 m_adherentSlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_adherentSlip);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_adherentSlip)) = vector;
		}
	}

	public unsafe Vector2 m_adherentForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_adherentForce);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_adherentForce)) = vector;
		}
	}

	public unsafe float m_inTd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inTd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inTd)) = num;
		}
	}

	public unsafe float m_inTb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inTb);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inTb)) = num;
		}
	}

	public unsafe TireFriction.ContactPatch m_contact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_contact);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TireFriction.ContactPatch(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_contact), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float debug1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug1)) = num;
		}
	}

	public unsafe float debug2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug2)) = num;
		}
	}

	public unsafe float debug3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug3);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug3)) = num;
		}
	}

	public unsafe float inertia
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inertia_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float angularVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float driveTorque
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_driveTorque_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float brakeTorque
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_brakeTorque_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe TireFriction.ContactPatch contactPatch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_contactPatch_Public_get_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new TireFriction.ContactPatch(intPtr) : null;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124246, RefRangeEnd = 124247, XrefRangeStart = 124246, XrefRangeEnd = 124246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecalculateConstants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateConstants_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float AddBrakeTorque(float brakeTorque)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&brakeTorque);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBrakeTorque_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void ResetBrakeTorque()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBrakeTorque_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void RecalculateVars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateVars_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124247, XrefRangeEnd = 124257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124257, XrefRangeEnd = 124259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124259, XrefRangeEnd = 124281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ComputeStateUpstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124281, XrefRangeEnd = 124313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124313, XrefRangeEnd = 124318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 124322, RefRangeEnd = 124325, XrefRangeStart = 124318, XrefRangeEnd = 124322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SolveSymmetricConstraint(float Tsum, float T, float Tmax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&Tsum);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &T;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &Tmax;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SolveSymmetricConstraint_Private_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124325, XrefRangeEnd = 124333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Wheel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Wheel()
	{
		Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Wheel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheel>.NativeClassPtr);
		NativeFieldInfoPtr_tireFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "tireFriction");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "mass");
		NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "I");
		NativeFieldInfoPtr_invI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "invI");
		NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "load");
		NativeFieldInfoPtr_grip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "grip");
		NativeFieldInfoPtr_V = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "V");
		NativeFieldInfoPtr_Fext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Fext");
		NativeFieldInfoPtr_Treact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Treact");
		NativeFieldInfoPtr_m_brakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_brakeTorque");
		NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "L");
		NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "P");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "w");
		NativeFieldInfoPtr_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "T");
		NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "F");
		NativeFieldInfoPtr_Tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Tr");
		NativeFieldInfoPtr_isResting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "isResting");
		NativeFieldInfoPtr_m_forwardSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_forwardSlip");
		NativeFieldInfoPtr_m_tireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_tireForce");
		NativeFieldInfoPtr_m_Ty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_Ty");
		NativeFieldInfoPtr_m_isAdherent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_isAdherent");
		NativeFieldInfoPtr_m_adherentSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_adherentSlip");
		NativeFieldInfoPtr_m_adherentForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_adherentForce");
		NativeFieldInfoPtr_m_inTd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_inTd");
		NativeFieldInfoPtr_m_inTb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_inTb");
		NativeFieldInfoPtr_m_contact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "m_contact");
		NativeFieldInfoPtr_debug1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "debug1");
		NativeFieldInfoPtr_debug2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "debug2");
		NativeFieldInfoPtr_debug3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "debug3");
		NativeMethodInfoPtr_RecalculateConstants_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671387);
		NativeMethodInfoPtr_get_inertia_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671388);
		NativeMethodInfoPtr_AddBrakeTorque_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671389);
		NativeMethodInfoPtr_ResetBrakeTorque_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671390);
		NativeMethodInfoPtr_get_angularVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671391);
		NativeMethodInfoPtr_RecalculateVars_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671392);
		NativeMethodInfoPtr_get_driveTorque_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671393);
		NativeMethodInfoPtr_get_brakeTorque_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671394);
		NativeMethodInfoPtr_get_contactPatch_Public_get_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671395);
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671396);
		NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671397);
		NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671398);
		NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671399);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671400);
		NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671401);
		NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671402);
		NativeMethodInfoPtr_SolveSymmetricConstraint_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671403);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100671404);
	}

	public Wheel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
