using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class RigidbodyForce : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_forceInputAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueInputAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_linealForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_linealImpulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_linealVelocityChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_linealAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularImpulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularVelocityChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbody;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr));

	public unsafe string forceInputAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceInputAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceInputAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string torqueInputAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueInputAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueInputAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe ForceMode forceMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode);
			return *(ForceMode*)num;
		}
		set
		{
			*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMode)) = forceMode;
		}
	}

	public unsafe ForceMode torqueMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueMode);
			return *(ForceMode*)num;
		}
		set
		{
			*(ForceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueMode)) = forceMode;
		}
	}

	public unsafe float linealForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealForce)) = num;
		}
	}

	public unsafe float linealImpulse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealImpulse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealImpulse)) = num;
		}
	}

	public unsafe float linealVelocityChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealVelocityChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealVelocityChange)) = num;
		}
	}

	public unsafe float linealAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealAcceleration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linealAcceleration)) = num;
		}
	}

	public unsafe float angularTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularTorque)) = num;
		}
	}

	public unsafe float angularImpulse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularImpulse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularImpulse)) = num;
		}
	}

	public unsafe float angularVelocityChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularVelocityChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularVelocityChange)) = num;
		}
	}

	public unsafe float angularAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularAcceleration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularAcceleration)) = num;
		}
	}

	public unsafe Rigidbody m_rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117282, XrefRangeEnd = 117285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117285, XrefRangeEnd = 117307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117307, XrefRangeEnd = 117314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RigidbodyForce()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RigidbodyForce()
	{
		Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RigidbodyForce");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr);
		NativeFieldInfoPtr_forceInputAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "forceInputAxis");
		NativeFieldInfoPtr_torqueInputAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "torqueInputAxis");
		NativeFieldInfoPtr_forceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "forceMode");
		NativeFieldInfoPtr_torqueMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "torqueMode");
		NativeFieldInfoPtr_linealForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "linealForce");
		NativeFieldInfoPtr_linealImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "linealImpulse");
		NativeFieldInfoPtr_linealVelocityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "linealVelocityChange");
		NativeFieldInfoPtr_linealAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "linealAcceleration");
		NativeFieldInfoPtr_angularTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "angularTorque");
		NativeFieldInfoPtr_angularImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "angularImpulse");
		NativeFieldInfoPtr_angularVelocityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "angularVelocityChange");
		NativeFieldInfoPtr_angularAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "angularAcceleration");
		NativeFieldInfoPtr_m_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, "m_rigidbody");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, 100670719);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, 100670720);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyForce>.NativeClassPtr, 100670721);
	}

	public RigidbodyForce(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
