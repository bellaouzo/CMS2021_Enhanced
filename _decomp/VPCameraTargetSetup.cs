using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPCameraTargetSetup : MonoBehaviour
{
	[System.Serializable]
	public class CustomCamera : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_reference;

		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_onEnableMessage;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr));

		public unsafe VPCameraController.Mode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(VPCameraController.Mode*)num;
			}
			set
			{
				*(VPCameraController.Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
			}
		}

		public unsafe Transform reference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe bool enabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
			}
		}

		public unsafe string onEnableMessage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnableMessage);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnableMessage), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(0)]
		public unsafe CustomCamera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CustomCamera()
		{
			Il2CppClassPointerStore<CustomCamera>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "CustomCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr);
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr, "reference");
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_onEnableMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr, "onEnableMessage");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCamera>.NativeClassPtr, 100670248);
		}

		public CustomCamera(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAtPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_attachToPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewDamping;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewMinDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCustomCameras;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCustomCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_customCameras;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomCamera_Public_CustomCamera_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindEnabledCamera_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr));

	public unsafe Transform lookAtPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform attachToPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachToPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachToPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float viewDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewDistance)) = num;
		}
	}

	public unsafe float viewHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewHeight)) = num;
		}
	}

	public unsafe float viewDamping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewDamping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewDamping)) = num;
		}
	}

	public unsafe float viewMinDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMinDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMinDistance)) = num;
		}
	}

	public unsafe float viewMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMinAngle)) = num;
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

	public unsafe bool useCustomCameras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomCameras);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomCameras)) = flag;
		}
	}

	public unsafe int currentCustomCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCustomCamera);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCustomCamera)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<CustomCamera> customCameras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameras);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CustomCamera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customCameras), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe CustomCamera GetCustomCamera(ref int targetCamIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref targetCamIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomCamera_Public_CustomCamera_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CustomCamera(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe int FindEnabledCamera(int cameraIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindEnabledCamera_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109960, XrefRangeEnd = 109966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPCameraTargetSetup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPCameraTargetSetup()
	{
		Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPCameraTargetSetup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr);
		NativeFieldInfoPtr_lookAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "lookAtPoint");
		NativeFieldInfoPtr_attachToPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "attachToPoint");
		NativeFieldInfoPtr_viewDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "viewDistance");
		NativeFieldInfoPtr_viewHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "viewHeight");
		NativeFieldInfoPtr_viewDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "viewDamping");
		NativeFieldInfoPtr_viewMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "viewMinDistance");
		NativeFieldInfoPtr_viewMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "viewMinAngle");
		NativeFieldInfoPtr_targetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "targetRadius");
		NativeFieldInfoPtr_useCustomCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "useCustomCameras");
		NativeFieldInfoPtr_currentCustomCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "currentCustomCamera");
		NativeFieldInfoPtr_customCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, "customCameras");
		NativeMethodInfoPtr_GetCustomCamera_Public_CustomCamera_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, 100670245);
		NativeMethodInfoPtr_FindEnabledCamera_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, 100670246);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPCameraTargetSetup>.NativeClassPtr, 100670247);
	}

	public VPCameraTargetSetup(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
