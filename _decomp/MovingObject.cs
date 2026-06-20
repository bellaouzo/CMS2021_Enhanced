using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_play;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_baseRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_angle;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MovingObject>.NativeClassPtr));

	public unsafe bool play
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_play);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_play)) = flag;
		}
	}

	public unsafe float rotationRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationRate)) = num;
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

	public unsafe Transform m_transform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Quaternion m_baseRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_baseRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_baseRot)) = quaternion;
		}
	}

	public unsafe float m_angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angle)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117212, XrefRangeEnd = 117241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117241, XrefRangeEnd = 117250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MovingObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovingObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MovingObject()
	{
		Il2CppClassPointerStore<MovingObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MovingObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovingObject>.NativeClassPtr);
		NativeFieldInfoPtr_play = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, "play");
		NativeFieldInfoPtr_rotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, "rotationRate");
		NativeFieldInfoPtr_m_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, "m_rigidbody");
		NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, "m_transform");
		NativeFieldInfoPtr_m_baseRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, "m_baseRot");
		NativeFieldInfoPtr_m_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, "m_angle");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, 100670709);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, 100670710);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovingObject>.NativeClassPtr, 100670711);
	}

	public MovingObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
