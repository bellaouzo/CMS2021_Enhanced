using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

[System.Serializable]
public class CameraFree : CameraMode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minVerticalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVerticalAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjustFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_minFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjustNearPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneAtMinFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_sidewaysAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_upwardsAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fov;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_savedFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_savedNearPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_horizontal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vertical;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraFree>.NativeClassPtr));

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

	public unsafe bool adjustFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustFov);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustFov)) = flag;
		}
	}

	public unsafe float minFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minFov)) = num;
		}
	}

	public unsafe float maxFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFov)) = num;
		}
	}

	public unsafe float fovSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovSpeed)) = num;
		}
	}

	public unsafe float fovDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovDamping)) = num;
		}
	}

	public unsafe bool adjustNearPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustNearPlane);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustNearPlane)) = flag;
		}
	}

	public unsafe float nearPlaneAtMinFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearPlaneAtMinFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearPlaneAtMinFov)) = num;
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

	public unsafe string fovAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool enableMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMovement)) = flag;
		}
	}

	public unsafe float movementSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeed)) = num;
		}
	}

	public unsafe float movementDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementDamping)) = num;
		}
	}

	public unsafe string forwardAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string sidewaysAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sidewaysAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sidewaysAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string upwardsAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upwardsAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upwardsAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Camera m_camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_camera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_position)) = vector;
		}
	}

	public unsafe float m_fov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fov)) = num;
		}
	}

	public unsafe float m_savedFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_savedFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_savedFov)) = num;
		}
	}

	public unsafe float m_savedNearPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_savedNearPlane);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_savedNearPlane)) = num;
		}
	}

	public unsafe float m_horizontal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_horizontal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_horizontal)) = num;
		}
	}

	public unsafe float m_vertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vertical);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vertical)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125624, XrefRangeEnd = 125642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125642, XrefRangeEnd = 125665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnable(Transform self)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125665, XrefRangeEnd = 125752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125752, XrefRangeEnd = 125766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisable(Transform self)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125776, RefRangeEnd = 125777, XrefRangeStart = 125766, XrefRangeEnd = 125776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraFree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraFree>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraFree()
	{
		Il2CppClassPointerStore<CameraFree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "CameraFree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraFree>.NativeClassPtr);
		NativeFieldInfoPtr_minVerticalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "minVerticalAngle");
		NativeFieldInfoPtr_maxVerticalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "maxVerticalAngle");
		NativeFieldInfoPtr_horizontalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "horizontalSpeed");
		NativeFieldInfoPtr_verticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "verticalSpeed");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_adjustFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "adjustFov");
		NativeFieldInfoPtr_minFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "minFov");
		NativeFieldInfoPtr_maxFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "maxFov");
		NativeFieldInfoPtr_fovSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "fovSpeed");
		NativeFieldInfoPtr_fovDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "fovDamping");
		NativeFieldInfoPtr_adjustNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "adjustNearPlane");
		NativeFieldInfoPtr_nearPlaneAtMinFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "nearPlaneAtMinFov");
		NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "horizontalAxis");
		NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "verticalAxis");
		NativeFieldInfoPtr_fovAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "fovAxis");
		NativeFieldInfoPtr_enableMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "enableMovement");
		NativeFieldInfoPtr_movementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "movementSpeed");
		NativeFieldInfoPtr_movementDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "movementDamping");
		NativeFieldInfoPtr_forwardAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "forwardAxis");
		NativeFieldInfoPtr_sidewaysAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "sidewaysAxis");
		NativeFieldInfoPtr_upwardsAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "upwardsAxis");
		NativeFieldInfoPtr_m_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_camera");
		NativeFieldInfoPtr_m_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_position");
		NativeFieldInfoPtr_m_fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_fov");
		NativeFieldInfoPtr_m_savedFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_savedFov");
		NativeFieldInfoPtr_m_savedNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_savedNearPlane");
		NativeFieldInfoPtr_m_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_horizontal");
		NativeFieldInfoPtr_m_vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, "m_vertical");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, 100671672);
		NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, 100671673);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, 100671674);
		NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, 100671675);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraFree>.NativeClassPtr, 100671676);
	}

	public CameraFree(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
