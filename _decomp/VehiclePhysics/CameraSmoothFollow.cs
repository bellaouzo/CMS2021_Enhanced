using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

[System.Serializable]
public class CameraSmoothFollow : CameraMode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_followVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocityDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_smoothLastPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_smoothVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_smoothTargetAngle;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionWithoutLerp_Public_Void_Transform_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr));

	public unsafe float distance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance)) = num;
		}
	}

	public unsafe float height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
		}
	}

	public unsafe float heightMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMultiplier)) = num;
		}
	}

	public unsafe float heightDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightDamping)) = num;
		}
	}

	public unsafe float rotationDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationDamping)) = num;
		}
	}

	public unsafe bool followVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followVelocity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followVelocity)) = flag;
		}
	}

	public unsafe float velocityDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocityDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocityDamping)) = num;
		}
	}

	public unsafe Vector3 m_smoothLastPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothLastPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothLastPos)) = vector;
		}
	}

	public unsafe Vector3 m_smoothVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothVelocity)) = vector;
		}
	}

	public unsafe float m_smoothTargetAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothTargetAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothTargetAngle)) = num;
		}
	}

	[CallerCount(0)]
	public new unsafe void SetTargetConfig(VPCameraTargetSetup targetConfig)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetConfig);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125295, XrefRangeEnd = 125313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Reset(Transform self, Transform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_Transform_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetPositionWithoutLerp(Transform self, Transform target, Transform lookAtTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(lookAtTarget);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionWithoutLerp_Public_Void_Transform_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125313, XrefRangeEnd = 125373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Update(Transform self, Transform target, Transform lookAtTarget, [Optional] float forceLerpValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(lookAtTarget);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceLerpValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125373, XrefRangeEnd = 125377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraSmoothFollow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraSmoothFollow()
	{
		Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "CameraSmoothFollow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr);
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "height");
		NativeFieldInfoPtr_heightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "heightMultiplier");
		NativeFieldInfoPtr_heightDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "heightDamping");
		NativeFieldInfoPtr_rotationDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "rotationDamping");
		NativeFieldInfoPtr_followVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "followVelocity");
		NativeFieldInfoPtr_velocityDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "velocityDamping");
		NativeFieldInfoPtr_m_smoothLastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "m_smoothLastPos");
		NativeFieldInfoPtr_m_smoothVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "m_smoothVelocity");
		NativeFieldInfoPtr_m_smoothTargetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, "m_smoothTargetAngle");
		NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, 100671656);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, 100671657);
		NativeMethodInfoPtr_SetPositionWithoutLerp_Public_Void_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, 100671658);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, 100671659);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSmoothFollow>.NativeClassPtr, 100671660);
	}

	public CameraSmoothFollow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
