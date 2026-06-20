using System;
using System.Runtime.CompilerServices;
using CMS.UI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vpCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_customCameraPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAtOpponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanLookAtOpponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasWindowManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowLateUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_customCameraPosEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomCameraPos_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetCustomCameraPos_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSmoothFollowCamera_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookAtOpponent_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraController>.NativeClassPtr));

	public unsafe VPCameraController vpCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPCameraController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform customCameraPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameraPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameraPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform lookAtOpponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtOpponent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtOpponent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool CanLookAtOpponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanLookAtOpponent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanLookAtOpponent)) = flag;
		}
	}

	public unsafe WindowManager windowManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new WindowManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool hasWindowManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasWindowManager);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasWindowManager)) = flag;
		}
	}

	public unsafe bool allowLateUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLateUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLateUpdate)) = flag;
		}
	}

	public unsafe bool customCameraPosEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameraPosEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameraPosEnabled)) = flag;
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18541, XrefRangeEnd = 18574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18584, RefRangeEnd = 18586, XrefRangeStart = 18574, XrefRangeEnd = 18584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCustomCameraPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomCameraPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetCustomCameraPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCustomCameraPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18586, XrefRangeEnd = 18615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18615, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSmoothFollowCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSmoothFollowCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18643, RefRangeEnd = 18644, XrefRangeStart = 18620, XrefRangeEnd = 18643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookAtOpponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookAtOpponent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18644, XrefRangeEnd = 18652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraController()
	{
		Il2CppClassPointerStore<CameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraController>.NativeClassPtr);
		NativeFieldInfoPtr_vpCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "vpCamera");
		NativeFieldInfoPtr_customCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "customCameraPos");
		NativeFieldInfoPtr_lookAtOpponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "lookAtOpponent");
		NativeFieldInfoPtr_CanLookAtOpponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "CanLookAtOpponent");
		NativeFieldInfoPtr_windowManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "windowManager");
		NativeFieldInfoPtr_hasWindowManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "hasWindowManager");
		NativeFieldInfoPtr_allowLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "allowLateUpdate");
		NativeFieldInfoPtr_customCameraPosEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "customCameraPosEnabled");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "mainCamera");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_SetCustomCameraPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_ResetCustomCameraPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr_SetSmoothFollowCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr_LookAtOpponent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100664697);
	}

	public CameraController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
