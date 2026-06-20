using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraOrbitPaintshop : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSpeedMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoomAsFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoomAsDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_fov;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_ySpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_distSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftTargetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftTargetZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftTargetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMinLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMaxLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLimitDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_distMinLimitZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_distMaxLimitZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_orbitDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_distDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_dist;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovSmooth;

	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	private static readonly System.IntPtr NativeFieldInfoPtr_rot;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovBackup;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_downOnUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetCenter;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Focus_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr));

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

	public unsafe float xSpeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSpeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSpeedMultiplier)) = num;
		}
	}

	public unsafe bool zoomAsFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomAsFov);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomAsFov)) = flag;
		}
	}

	public unsafe bool zoomAsDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomAsDistance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomAsDistance)) = flag;
		}
	}

	public unsafe float fov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fov)) = num;
		}
	}

	public unsafe float fovMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovMin)) = num;
		}
	}

	public unsafe float fovMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovMax)) = num;
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

	public unsafe float xSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSpeed)) = num;
		}
	}

	public unsafe float ySpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySpeed)) = num;
		}
	}

	public unsafe float distSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distSpeed)) = num;
		}
	}

	public unsafe float shiftTargetX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTargetX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTargetX)) = num;
		}
	}

	public unsafe float shiftTargetZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTargetZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTargetZ)) = num;
		}
	}

	public unsafe float shiftTargetY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTargetY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTargetY)) = num;
		}
	}

	public unsafe float yMinLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMinLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMinLimit)) = num;
		}
	}

	public unsafe float yMaxLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMaxLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMaxLimit)) = num;
		}
	}

	public unsafe float maxLimitDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLimitDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLimitDistance)) = num;
		}
	}

	public unsafe float distMinLimitZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMinLimitZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMinLimitZ)) = num;
		}
	}

	public unsafe float distMaxLimitZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMaxLimitZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMaxLimitZ)) = num;
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

	public unsafe float distDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distDamping)) = num;
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

	public unsafe float x
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
		}
	}

	public unsafe float y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
		}
	}

	public unsafe float dist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dist)) = num;
		}
	}

	public unsafe float fovSmooth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovSmooth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovSmooth)) = num;
		}
	}

	public unsafe Vector3 pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
		}
	}

	public unsafe Vector3 rot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot)) = vector;
		}
	}

	public unsafe float fovBackup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovBackup);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovBackup)) = num;
		}
	}

	public unsafe InputManager inputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool downOnUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downOnUI);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downOnUI)) = flag;
		}
	}

	public unsafe Vector3 targetCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCenter);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCenter)) = vector;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100523, XrefRangeEnd = 100525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100525, XrefRangeEnd = 100563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100563, XrefRangeEnd = 100572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100572, XrefRangeEnd = 100719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100751, RefRangeEnd = 100752, XrefRangeStart = 100719, XrefRangeEnd = 100751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTarget(GameObject targetPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPoint);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTarget_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void Focus(GameObject window)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(window);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Focus_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float ClampAngle(float a, float min, float max)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100752, XrefRangeEnd = 100755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraOrbitPaintshop()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraOrbitPaintshop()
	{
		Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraOrbitPaintshop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr);
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "target");
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_xSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "xSpeedMultiplier");
		NativeFieldInfoPtr_zoomAsFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "zoomAsFov");
		NativeFieldInfoPtr_zoomAsDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "zoomAsDistance");
		NativeFieldInfoPtr_fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fov");
		NativeFieldInfoPtr_fovMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fovMin");
		NativeFieldInfoPtr_fovMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fovMax");
		NativeFieldInfoPtr_fovSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fovSpeed");
		NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "xSpeed");
		NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "ySpeed");
		NativeFieldInfoPtr_distSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "distSpeed");
		NativeFieldInfoPtr_shiftTargetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "shiftTargetX");
		NativeFieldInfoPtr_shiftTargetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "shiftTargetZ");
		NativeFieldInfoPtr_shiftTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "shiftTargetY");
		NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "yMinLimit");
		NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "yMaxLimit");
		NativeFieldInfoPtr_maxLimitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "maxLimitDistance");
		NativeFieldInfoPtr_distMinLimitZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "distMinLimitZ");
		NativeFieldInfoPtr_distMaxLimitZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "distMaxLimitZ");
		NativeFieldInfoPtr_orbitDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "orbitDamping");
		NativeFieldInfoPtr_distDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "distDamping");
		NativeFieldInfoPtr_fovDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fovDamping");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "y");
		NativeFieldInfoPtr_dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "dist");
		NativeFieldInfoPtr_fovSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fovSmooth");
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "rot");
		NativeFieldInfoPtr_fovBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "fovBackup");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "inputManager");
		NativeFieldInfoPtr_downOnUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "downOnUI");
		NativeFieldInfoPtr_targetCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, "targetCenter");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669182);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669183);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669184);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669185);
		NativeMethodInfoPtr_SetTarget_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669186);
		NativeMethodInfoPtr_Focus_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669187);
		NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669188);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitPaintshop>.NativeClassPtr, 100669189);
	}

	public CameraOrbitPaintshop(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
