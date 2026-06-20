using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

[System.Serializable]
public class CameraOrbit : CameraMode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_minVerticalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVerticalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_orbitDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_orbitX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_orbitY;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_orbitDistance;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr));

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

	public unsafe float minVerticalAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVerticalAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVerticalAngle)) = num;
		}
	}

	public unsafe float maxVerticalAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVerticalAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVerticalAngle)) = num;
		}
	}

	public unsafe float horizontalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSpeed)) = num;
		}
	}

	public unsafe float verticalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalSpeed)) = num;
		}
	}

	public unsafe float orbitDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orbitDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orbitDamping)) = num;
		}
	}

	public unsafe float minDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance)) = num;
		}
	}

	public unsafe float maxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance)) = num;
		}
	}

	public unsafe float distanceSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceSpeed)) = num;
		}
	}

	public unsafe float distanceDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceDamping)) = num;
		}
	}

	public unsafe string horizontalAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string verticalAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string distanceAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float m_orbitX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_orbitX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_orbitX)) = num;
		}
	}

	public unsafe float m_orbitY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_orbitY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_orbitY)) = num;
		}
	}

	public unsafe float m_orbitDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_orbitDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_orbitDistance)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125377, XrefRangeEnd = 125380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125380, XrefRangeEnd = 125383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Initialize(Transform self)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125383, XrefRangeEnd = 125440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125440, XrefRangeEnd = 125446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraOrbit()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraOrbit()
	{
		Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "CameraOrbit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr);
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_minVerticalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "minVerticalAngle");
		NativeFieldInfoPtr_maxVerticalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "maxVerticalAngle");
		NativeFieldInfoPtr_horizontalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "horizontalSpeed");
		NativeFieldInfoPtr_verticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "verticalSpeed");
		NativeFieldInfoPtr_orbitDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "orbitDamping");
		NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "minDistance");
		NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "maxDistance");
		NativeFieldInfoPtr_distanceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceSpeed");
		NativeFieldInfoPtr_distanceDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceDamping");
		NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "horizontalAxis");
		NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "verticalAxis");
		NativeFieldInfoPtr_distanceAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceAxis");
		NativeFieldInfoPtr_m_orbitX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "m_orbitX");
		NativeFieldInfoPtr_m_orbitY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "m_orbitY");
		NativeFieldInfoPtr_m_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "m_orbitDistance");
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100671661);
		NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100671662);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100671663);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100671664);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100671665);
	}

	public CameraOrbit(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
