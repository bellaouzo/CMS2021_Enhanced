using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PaintshopCameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_WarehouseCameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCameraState;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreviousCameraState;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrbitCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixedCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraOrbitPaintshop;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastZoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterToOilRefill_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterToFluidRefill_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitFromFluidRefill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterToOilBayonet_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitFromOilBayonet_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterToPaintshop_Public_Void_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitFromPaintshop_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Focus_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCamera_Public_Void_CameraState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveZoom_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLastZoom_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableFixedCamera_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableOrbitCamera_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableFPSCamera_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshFPSCameraSettings_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_CameraManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraManager>.NativeClassPtr));

	public unsafe Transform PaintshopCameraPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintshopCameraPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintshopCameraPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform WarehouseCameraPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WarehouseCameraPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WarehouseCameraPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraState CurrentCameraState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentCameraState);
			return *(CameraState*)num;
		}
		set
		{
			*(CameraState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentCameraState)) = cameraState;
		}
	}

	public unsafe CameraState PreviousCameraState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousCameraState);
			return *(CameraState*)num;
		}
		set
		{
			*(CameraState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousCameraState)) = cameraState;
		}
	}

	public unsafe GameObject playerGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGameObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OrbitCamera OrbitCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrbitCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OrbitCamera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrbitCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FixedCamera FixedCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new FixedCamera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraOrbitPaintshop CameraOrbitPaintshop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraOrbitPaintshop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraOrbitPaintshop(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraOrbitPaintshop), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float lastZoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastZoom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastZoom)) = num;
		}
	}

	public unsafe static CameraManager m_instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new CameraManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18652, XrefRangeEnd = 18672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18672, XrefRangeEnd = 18678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18720, RefRangeEnd = 18721, XrefRangeStart = 18678, XrefRangeEnd = 18720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterToOilRefill(Transform t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterToOilRefill_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18763, RefRangeEnd = 18764, XrefRangeStart = 18721, XrefRangeEnd = 18763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterToFluidRefill(Transform t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterToFluidRefill_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18791, RefRangeEnd = 18792, XrefRangeStart = 18764, XrefRangeEnd = 18791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitFromFluidRefill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitFromFluidRefill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18792, XrefRangeEnd = 18793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterToOilBayonet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterToOilBayonet_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18793, XrefRangeEnd = 18794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitFromOilBayonet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitFromOilBayonet_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 18806, RefRangeEnd = 18809, XrefRangeStart = 18794, XrefRangeEnd = 18806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterToPaintshop(Transform cameraTarget, bool isPaintPart = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameraTarget);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPaintPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterToPaintshop_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18855, RefRangeEnd = 18857, XrefRangeStart = 18809, XrefRangeEnd = 18855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitFromPaintshop(CarLoader carLoader = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitFromPaintshop_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Focus(GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Focus_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 18869, RefRangeEnd = 18880, XrefRangeStart = 18857, XrefRangeEnd = 18869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeCamera(CameraState State)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&State);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeCamera_Public_Void_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18883, RefRangeEnd = 18884, XrefRangeStart = 18880, XrefRangeEnd = 18883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveZoom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveZoom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18884, XrefRangeEnd = 18887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLastZoom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLastZoom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 18929, RefRangeEnd = 18941, XrefRangeStart = 18887, XrefRangeEnd = 18929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableFixedCamera(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableFixedCamera_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 18960, RefRangeEnd = 18974, XrefRangeStart = 18941, XrefRangeEnd = 18960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableOrbitCamera(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableOrbitCamera_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 19086, RefRangeEnd = 19096, XrefRangeStart = 18974, XrefRangeEnd = 19086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableFPSCamera(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableFPSCamera_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19096, XrefRangeEnd = 19112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshFPSCameraSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshFPSCameraSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19112, XrefRangeEnd = 19116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CameraManager Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_CameraManager_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CameraManager(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19116, XrefRangeEnd = 19139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19139, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraManager()
	{
		Il2CppClassPointerStore<CameraManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraManager>.NativeClassPtr);
		NativeFieldInfoPtr_PaintshopCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "PaintshopCameraPosition");
		NativeFieldInfoPtr_WarehouseCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "WarehouseCameraPosition");
		NativeFieldInfoPtr_CurrentCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "CurrentCameraState");
		NativeFieldInfoPtr_PreviousCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "PreviousCameraState");
		NativeFieldInfoPtr_playerGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "playerGameObject");
		NativeFieldInfoPtr_OrbitCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "OrbitCamera");
		NativeFieldInfoPtr_FixedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "FixedCamera");
		NativeFieldInfoPtr_CameraOrbitPaintshop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "CameraOrbitPaintshop");
		NativeFieldInfoPtr_lastZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "lastZoom");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "m_instance");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_EnterToOilRefill_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_EnterToFluidRefill_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_ExitFromFluidRefill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr_EnterToOilBayonet_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_ExitFromOilBayonet_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_EnterToPaintshop_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr_ExitFromPaintshop_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr_Focus_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr_ChangeCamera_Public_Void_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664709);
		NativeMethodInfoPtr_SaveZoom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664710);
		NativeMethodInfoPtr_SetLastZoom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664711);
		NativeMethodInfoPtr_EnableFixedCamera_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664712);
		NativeMethodInfoPtr_EnableOrbitCamera_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664713);
		NativeMethodInfoPtr_EnableFPSCamera_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664714);
		NativeMethodInfoPtr_RefreshFPSCameraSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664715);
		NativeMethodInfoPtr_Get_Public_Static_CameraManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664716);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664717);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100664718);
	}

	public CameraManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
