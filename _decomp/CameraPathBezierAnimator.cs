using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CameraPathBezierAnimator : MonoBehaviour
{
	public enum modes
	{
		once,
		loop,
		reverse,
		reverseLoop,
		pingPong,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<modes>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static modes()
		{
			Il2CppClassPointerStore<modes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "modes");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_bezier;

	private static readonly System.IntPtr NativeFieldInfoPtr_playOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_animationTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_playing;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_pingPongDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalised;

	private static readonly System.IntPtr NativeFieldInfoPtr_editorTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_pathTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__percentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_sensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_minX;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationY;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextAnimation;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Seek_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_percentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pingPongGoingForward_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculatePercentage_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateAnimation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAniamtion_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAnimationTime_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseLook_Private_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr));

	public unsafe CameraPathBezier bezier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bezier);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraPathBezier(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bezier), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool playOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playOnStart)) = flag;
		}
	}

	public unsafe Transform animationTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCamera)) = flag;
		}
	}

	public unsafe bool playing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playing)) = flag;
		}
	}

	public unsafe modes mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(modes*)num;
		}
		set
		{
			*(modes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = modes2;
		}
	}

	public unsafe float pingPongDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pingPongDirection);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pingPongDirection)) = num;
		}
	}

	public unsafe bool normalised
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalised);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalised)) = flag;
		}
	}

	public unsafe float editorTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorTime)) = num;
		}
	}

	public unsafe float pathTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathTime)) = num;
		}
	}

	public unsafe float _percentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__percentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__percentage)) = num;
		}
	}

	public unsafe float sensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sensitivity)) = num;
		}
	}

	public unsafe float minX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minX)) = num;
		}
	}

	public unsafe float maxX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxX)) = num;
		}
	}

	public unsafe float rotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX)) = num;
		}
	}

	public unsafe float rotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY)) = num;
		}
	}

	public unsafe CameraPathBezierAnimator nextAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextAnimation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CameraPathBezierAnimator(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextAnimation), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isPlaying
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float percentage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_percentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool pingPongGoingForward
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pingPongGoingForward_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Seek(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Seek_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1459, RefRangeEnd = 1463, XrefRangeStart = 1447, XrefRangeEnd = 1459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float RecalculatePercentage(float percentage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&percentage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculatePercentage_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1463, XrefRangeEnd = 1483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483, XrefRangeEnd = 1495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1495, XrefRangeEnd = 1507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1507, XrefRangeEnd = 1550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1550, XrefRangeEnd = 1554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceUpdateAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceUpdateAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1554, XrefRangeEnd = 1595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAniamtion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAniamtion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1595, XrefRangeEnd = 1606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAnimationTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAnimationTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1606, XrefRangeEnd = 1628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetMouseLook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseLook_Private_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float ClampAngle(float angle, float min, float max)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&angle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1628, XrefRangeEnd = 1631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraPathBezierAnimator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraPathBezierAnimator()
	{
		Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraPathBezierAnimator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr);
		NativeFieldInfoPtr_bezier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "bezier");
		NativeFieldInfoPtr_playOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "playOnStart");
		NativeFieldInfoPtr_animationTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "animationTarget");
		NativeFieldInfoPtr_isCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "isCamera");
		NativeFieldInfoPtr_playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "playing");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_pingPongDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "pingPongDirection");
		NativeFieldInfoPtr_normalised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "normalised");
		NativeFieldInfoPtr_editorTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "editorTime");
		NativeFieldInfoPtr_pathTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "pathTime");
		NativeFieldInfoPtr__percentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "_percentage");
		NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "sensitivity");
		NativeFieldInfoPtr_minX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "minX");
		NativeFieldInfoPtr_maxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "maxX");
		NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "rotationX");
		NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "rotationY");
		NativeFieldInfoPtr_nextAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, "nextAnimation");
		NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_Seek_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_get_percentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_get_pingPongGoingForward_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_RecalculatePercentage_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_ForceUpdateAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_UpdateAniamtion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_UpdateAnimationTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_GetMouseLook_Private_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPathBezierAnimator>.NativeClassPtr, 100663386);
	}

	public CameraPathBezierAnimator(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
