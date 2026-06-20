using System;
using System.Runtime.CompilerServices;
using CMS.UI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraOrbitShowroom : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowID;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoomAsFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoomAsDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialDistancePercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimalDistancePercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximalDistancePercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceLimiter;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_fov;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimulateInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimulateInputSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_ySpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_distSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_orbitDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_distDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMinLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMaxLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftTargetZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiftTargetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_distMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_distInit;

	private static readonly System.IntPtr NativeFieldInfoPtr_distMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_dist;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovSmooth;

	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	private static readonly System.IntPtr NativeFieldInfoPtr_rot;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_downOnUI;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_GameObject_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr));

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

	public unsafe WindowID windowID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowID);
			return *(WindowID*)num;
		}
		set
		{
			*(WindowID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowID)) = windowID;
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

	public unsafe bool limitDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitDistance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitDistance)) = flag;
		}
	}

	public unsafe Vector2 initialRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialRotation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialRotation)) = vector;
		}
	}

	public unsafe float distanceTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceTarget);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceTarget)) = num;
		}
	}

	public unsafe float initialDistancePercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialDistancePercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialDistancePercentage)) = num;
		}
	}

	public unsafe float minimalDistancePercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimalDistancePercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimalDistancePercentage)) = num;
		}
	}

	public unsafe float maximalDistancePercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximalDistancePercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximalDistancePercentage)) = num;
		}
	}

	public unsafe float distanceLimiter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceLimiter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceLimiter)) = num;
		}
	}

	public unsafe float initialFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialFov)) = num;
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

	public unsafe bool SimulateInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SimulateInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SimulateInput)) = flag;
		}
	}

	public unsafe float SimulateInputSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SimulateInputSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SimulateInputSpeed)) = num;
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

	public unsafe float distMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMin)) = num;
		}
	}

	public unsafe float distInit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distInit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distInit)) = num;
		}
	}

	public unsafe float distMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distMax)) = num;
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19142, XrefRangeEnd = 19144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19144, XrefRangeEnd = 19149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19149, XrefRangeEnd = 19154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 19180, RefRangeEnd = 19181, XrefRangeStart = 19154, XrefRangeEnd = 19180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 19254, RefRangeEnd = 19255, XrefRangeStart = 19181, XrefRangeEnd = 19254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19255, XrefRangeEnd = 19402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19402, XrefRangeEnd = 19405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTarget(GameObject targetPoint, float distan)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPoint);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distan;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTarget_Public_Void_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19405, XrefRangeEnd = 19408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraOrbitShowroom()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraOrbitShowroom()
	{
		Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraOrbitShowroom");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "target");
		NativeFieldInfoPtr_windowID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "windowID");
		NativeFieldInfoPtr_zoomAsFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "zoomAsFov");
		NativeFieldInfoPtr_zoomAsDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "zoomAsDistance");
		NativeFieldInfoPtr_limitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "limitDistance");
		NativeFieldInfoPtr_initialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "initialRotation");
		NativeFieldInfoPtr_distanceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distanceTarget");
		NativeFieldInfoPtr_initialDistancePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "initialDistancePercentage");
		NativeFieldInfoPtr_minimalDistancePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "minimalDistancePercentage");
		NativeFieldInfoPtr_maximalDistancePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "maximalDistancePercentage");
		NativeFieldInfoPtr_distanceLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distanceLimiter");
		NativeFieldInfoPtr_initialFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "initialFov");
		NativeFieldInfoPtr_fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "fov");
		NativeFieldInfoPtr_fovMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "fovMin");
		NativeFieldInfoPtr_fovMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "fovMax");
		NativeFieldInfoPtr_fovSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "fovSpeed");
		NativeFieldInfoPtr_SimulateInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "SimulateInput");
		NativeFieldInfoPtr_SimulateInputSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "SimulateInputSpeed");
		NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "xSpeed");
		NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "ySpeed");
		NativeFieldInfoPtr_distSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distSpeed");
		NativeFieldInfoPtr_orbitDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "orbitDamping");
		NativeFieldInfoPtr_distDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distDamping");
		NativeFieldInfoPtr_fovDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "fovDamping");
		NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "yMinLimit");
		NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "yMaxLimit");
		NativeFieldInfoPtr_shiftTargetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "shiftTargetZ");
		NativeFieldInfoPtr_shiftTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "shiftTargetY");
		NativeFieldInfoPtr_distMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distMin");
		NativeFieldInfoPtr_distInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distInit");
		NativeFieldInfoPtr_distMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "distMax");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "y");
		NativeFieldInfoPtr_dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "dist");
		NativeFieldInfoPtr_fovSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "fovSmooth");
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "rot");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_downOnUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, "downOnUI");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664720);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664721);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664722);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664723);
		NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664724);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_SetTarget_Public_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664727);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbitShowroom>.NativeClassPtr, 100664728);
	}

	public CameraOrbitShowroom(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
