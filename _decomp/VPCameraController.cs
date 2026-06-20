using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPCameraController : MonoBehaviour
{
	public enum Mode
	{
		AttachTo,
		SmoothFollow,
		Orbit,
		LookAt,
		Free,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeCameraKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_customCameraIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_attachTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothFollow;

	private static readonly System.IntPtr NativeFieldInfoPtr_orbit;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_free;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraModeIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cameraModes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevCustomCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_targetConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_viewTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowFovChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_LookAtTarget;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMe_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdateMe_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowFovChange_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFov_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextCameraMode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSmoothFollowCamera_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolume_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetCamera_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetConfig_Public_Void_VPCameraTargetSetup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonitorTargetChanges_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonitorCustomCameraChanges_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTarget_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCustomCamera_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCamera_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr));

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
		}
	}

	public unsafe Transform target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe KeyCode changeCameraKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeCameraKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeCameraKey)) = keyCode;
		}
	}

	public unsafe int customCameraIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameraIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameraIndex)) = num;
		}
	}

	public unsafe float multiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplier)) = num;
		}
	}

	public unsafe Camera mainCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraAttachTo attachTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachTo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraAttachTo(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachTo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraSmoothFollow smoothFollow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothFollow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraSmoothFollow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothFollow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraOrbit orbit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orbit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraOrbit(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orbit), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraLookAt lookAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraLookAt(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAt), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraFree free
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_free);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraFree(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_free), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe int cameraModeIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraModeIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraModeIndex)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<CameraMode> m_cameraModes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cameraModes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CameraMode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cameraModes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_currentTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Mode m_prevMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevMode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevMode)) = mode;
		}
	}

	public unsafe int m_prevCustomCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevCustomCamera);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevCustomCamera)) = num;
		}
	}

	public unsafe VPCameraTargetSetup m_targetConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPCameraTargetSetup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetConfig), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_viewTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_viewTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_viewTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool allowFovChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowFovChange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowFovChange)) = flag;
		}
	}

	public unsafe Transform LookAtTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LookAtTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LookAtTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109690, XrefRangeEnd = 109743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109743, XrefRangeEnd = 109758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109758, RefRangeEnd = 109759, XrefRangeStart = 109758, XrefRangeEnd = 109758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdateMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdateMe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109759, XrefRangeEnd = 109761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllowFovChange(bool allow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&allow);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllowFovChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109761, XrefRangeEnd = 109762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFov(float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFov_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 109782, RefRangeEnd = 109785, XrefRangeStart = 109762, XrefRangeEnd = 109782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextCameraMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextCameraMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109785, XrefRangeEnd = 109790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSmoothFollowCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSmoothFollowCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 109795, RefRangeEnd = 109799, XrefRangeStart = 109790, XrefRangeEnd = 109795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateVolume(bool forceMax = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceMax);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVolume_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 109801, RefRangeEnd = 109807, XrefRangeStart = 109799, XrefRangeEnd = 109801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109807, XrefRangeEnd = 109808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTargetConfig(VPCameraTargetSetup targetConfig)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetConfig);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTargetConfig_Public_Void_VPCameraTargetSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 109843, RefRangeEnd = 109846, XrefRangeStart = 109808, XrefRangeEnd = 109843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MonitorTargetChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonitorTargetChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 109885, RefRangeEnd = 109888, XrefRangeStart = 109846, XrefRangeEnd = 109885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MonitorCustomCameraChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonitorCustomCameraChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109904, RefRangeEnd = 109905, XrefRangeStart = 109888, XrefRangeEnd = 109904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109918, RefRangeEnd = 109919, XrefRangeStart = 109905, XrefRangeEnd = 109918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeCustomCamera(int cameraIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCustomCamera_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109929, RefRangeEnd = 109930, XrefRangeStart = 109919, XrefRangeEnd = 109929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeCamera(bool input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCamera_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109930, XrefRangeEnd = 109960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPCameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPCameraController()
	{
		Il2CppClassPointerStore<VPCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPCameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "target");
		NativeFieldInfoPtr_changeCameraKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "changeCameraKey");
		NativeFieldInfoPtr_customCameraIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "customCameraIndex");
		NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "multiplier");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_attachTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "attachTo");
		NativeFieldInfoPtr_smoothFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "smoothFollow");
		NativeFieldInfoPtr_orbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "orbit");
		NativeFieldInfoPtr_lookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "lookAt");
		NativeFieldInfoPtr_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "free");
		NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_transform");
		NativeFieldInfoPtr_cameraModeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "cameraModeIndex");
		NativeFieldInfoPtr_m_cameraModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_cameraModes");
		NativeFieldInfoPtr_m_currentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_currentTarget");
		NativeFieldInfoPtr_m_prevMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_prevMode");
		NativeFieldInfoPtr_m_prevCustomCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_prevCustomCamera");
		NativeFieldInfoPtr_m_targetConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_targetConfig");
		NativeFieldInfoPtr_m_viewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "m_viewTarget");
		NativeFieldInfoPtr_allowFovChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "allowFovChange");
		NativeFieldInfoPtr_LookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, "LookAtTarget");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670228);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670229);
		NativeMethodInfoPtr_UpdateMe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670230);
		NativeMethodInfoPtr_LateUpdateMe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670231);
		NativeMethodInfoPtr_AllowFovChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670232);
		NativeMethodInfoPtr_SetFov_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670233);
		NativeMethodInfoPtr_NextCameraMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670234);
		NativeMethodInfoPtr_SetSmoothFollowCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670235);
		NativeMethodInfoPtr_UpdateVolume_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670236);
		NativeMethodInfoPtr_ResetCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670237);
		NativeMethodInfoPtr_SetTargetConfig_Public_Void_VPCameraTargetSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670238);
		NativeMethodInfoPtr_MonitorTargetChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670239);
		NativeMethodInfoPtr_MonitorCustomCameraChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670240);
		NativeMethodInfoPtr_InitializeTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670241);
		NativeMethodInfoPtr_InitializeCustomCamera_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670242);
		NativeMethodInfoPtr_ChangeCamera_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670243);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraController>.NativeClassPtr, 100670244);
	}

	public VPCameraController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
