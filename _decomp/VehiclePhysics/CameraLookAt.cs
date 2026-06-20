using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

[System.Serializable]
public class CameraLookAt : CameraMode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjustFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_minFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetRadiusSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjustNearPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearPlaneAtMinFov;

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

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr));

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

	public unsafe bool autoFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFov);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFov)) = flag;
		}
	}

	public unsafe float targetRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetRadius)) = num;
		}
	}

	public unsafe float targetRadiusSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetRadiusSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetRadiusSpeed)) = num;
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125446, XrefRangeEnd = 125464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125464, XrefRangeEnd = 125484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125484, XrefRangeEnd = 125603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125603, XrefRangeEnd = 125617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 125623, RefRangeEnd = 125624, XrefRangeStart = 125617, XrefRangeEnd = 125623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraLookAt()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraLookAt()
	{
		Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "CameraLookAt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr);
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_adjustFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "adjustFov");
		NativeFieldInfoPtr_minFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "minFov");
		NativeFieldInfoPtr_maxFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "maxFov");
		NativeFieldInfoPtr_fovSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "fovSpeed");
		NativeFieldInfoPtr_fovDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "fovDamping");
		NativeFieldInfoPtr_autoFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "autoFov");
		NativeFieldInfoPtr_targetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "targetRadius");
		NativeFieldInfoPtr_targetRadiusSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "targetRadiusSpeed");
		NativeFieldInfoPtr_adjustNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "adjustNearPlane");
		NativeFieldInfoPtr_nearPlaneAtMinFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "nearPlaneAtMinFov");
		NativeFieldInfoPtr_fovAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "fovAxis");
		NativeFieldInfoPtr_enableMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "enableMovement");
		NativeFieldInfoPtr_movementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "movementSpeed");
		NativeFieldInfoPtr_movementDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "movementDamping");
		NativeFieldInfoPtr_forwardAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "forwardAxis");
		NativeFieldInfoPtr_sidewaysAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "sidewaysAxis");
		NativeFieldInfoPtr_upwardsAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "upwardsAxis");
		NativeFieldInfoPtr_m_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "m_camera");
		NativeFieldInfoPtr_m_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "m_position");
		NativeFieldInfoPtr_m_fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "m_fov");
		NativeFieldInfoPtr_m_savedFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "m_savedFov");
		NativeFieldInfoPtr_m_savedNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, "m_savedNearPlane");
		NativeMethodInfoPtr_SetTargetConfig_Public_Virtual_Void_VPCameraTargetSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, 100671666);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, 100671667);
		NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, 100671668);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_Transform_Transform_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, 100671669);
		NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, 100671670);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraLookAt>.NativeClassPtr, 100671671);
	}

	public CameraLookAt(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
