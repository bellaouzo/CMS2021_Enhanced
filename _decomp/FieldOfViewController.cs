using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FieldOfViewController : MonoBehaviour
{
	public enum Mode
	{
		Free,
		AdjustToTarget,
		AdjustSizeToTargetDistance,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_fieldOfView;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetSizeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_damped;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_clampedFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_minFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_clampedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cam;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_trans;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_firstRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_targetRenderer;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetFieldOfView_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFovAngleBySize_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr));

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

	public unsafe float fieldOfView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldOfView);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldOfView)) = num;
		}
	}

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

	public unsafe float targetSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSize)) = num;
		}
	}

	public unsafe float targetSizeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSizeOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSizeOffset)) = num;
		}
	}

	public unsafe bool damped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damped)) = flag;
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

	public unsafe bool clampedFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedFov);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedFov)) = flag;
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

	public unsafe bool clampedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedSize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedSize)) = flag;
		}
	}

	public unsafe float minSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSize)) = num;
		}
	}

	public unsafe float maxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSize)) = num;
		}
	}

	public unsafe Camera m_cam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cam), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_trans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_trans);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_trans), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_currentFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentFov)) = num;
		}
	}

	public unsafe bool m_firstRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstRun)) = flag;
		}
	}

	public unsafe Transform m_cachedTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer m_targetRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Renderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe void ResetFieldOfView(float fovAngle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fovAngle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFieldOfView_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106998, XrefRangeEnd = 107006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 107008, RefRangeEnd = 107009, XrefRangeStart = 107006, XrefRangeEnd = 107008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFovAngleBySize(float size, float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&size);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFovAngleBySize_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107009, XrefRangeEnd = 107105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107105, XrefRangeEnd = 107108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FieldOfViewController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FieldOfViewController()
	{
		Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FieldOfViewController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "target");
		NativeFieldInfoPtr_fieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "fieldOfView");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_targetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "targetSize");
		NativeFieldInfoPtr_targetSizeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "targetSizeOffset");
		NativeFieldInfoPtr_damped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "damped");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_clampedFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "clampedFov");
		NativeFieldInfoPtr_minFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "minFov");
		NativeFieldInfoPtr_maxFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "maxFov");
		NativeFieldInfoPtr_clampedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "clampedSize");
		NativeFieldInfoPtr_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "minSize");
		NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "maxSize");
		NativeFieldInfoPtr_m_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "m_cam");
		NativeFieldInfoPtr_m_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "m_trans");
		NativeFieldInfoPtr_m_currentFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "m_currentFov");
		NativeFieldInfoPtr_m_firstRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "m_firstRun");
		NativeFieldInfoPtr_m_cachedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "m_cachedTarget");
		NativeFieldInfoPtr_m_targetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, "m_targetRenderer");
		NativeMethodInfoPtr_ResetFieldOfView_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, 100669789);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, 100669790);
		NativeMethodInfoPtr_GetFovAngleBySize_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, 100669791);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, 100669792);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewController>.NativeClassPtr, 100669793);
	}

	public FieldOfViewController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
