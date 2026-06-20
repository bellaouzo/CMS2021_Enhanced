using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fullRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationYawLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationPitchLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	private static readonly System.IntPtr NativeFieldInfoPtr_noSmooth;

	private static readonly System.IntPtr NativeFieldInfoPtr_camShift;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotShift;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_VerticalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookSmoothSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookSmoothWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookAccelerationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookInvert;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseLookSmoothMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseLookSmoothBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastMouseLookFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentMouseLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_MousePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Yaw;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Roll;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCorrectYaw;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCorrectPitch;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_Vector3_Vector3_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationLimit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationLimit_Public_Void_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationFromOther_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shift_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraLook_Private_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr));

	public unsafe Vector2 fullRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullRotation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullRotation)) = vector;
		}
	}

	public unsafe Vector2 rotationYawLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationYawLimit);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationYawLimit)) = vector;
		}
	}

	public unsafe Vector2 rotationPitchLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationPitchLimit);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationPitchLimit)) = vector;
		}
	}

	public unsafe Transform pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool noSmooth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noSmooth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noSmooth)) = flag;
		}
	}

	public unsafe Vector3 camShift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camShift);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camShift)) = vector;
		}
	}

	public unsafe Vector2 rotShift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotShift);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotShift)) = vector;
		}
	}

	public unsafe float HorizontalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalSpeed)) = num;
		}
	}

	public unsafe float VerticalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalSpeed)) = num;
		}
	}

	public unsafe Vector2 MouseLookSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSensitivity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSensitivity)) = vector;
		}
	}

	public unsafe int MouseLookSmoothSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothSteps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothSteps)) = num;
		}
	}

	public unsafe float MouseLookSmoothWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothWeight)) = num;
		}
	}

	public unsafe bool MouseLookAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAcceleration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAcceleration)) = flag;
		}
	}

	public unsafe float MouseLookAccelerationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAccelerationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAccelerationThreshold)) = num;
		}
	}

	public unsafe bool MouseLookInvert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookInvert);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookInvert)) = flag;
		}
	}

	public unsafe Vector2 m_MouseLookSmoothMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothMove);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothMove)) = vector;
		}
	}

	public unsafe List<Vector2> m_MouseLookSmoothBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothBuffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_LastMouseLookFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastMouseLookFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastMouseLookFrame)) = num;
		}
	}

	public unsafe Vector2 m_CurrentMouseLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMouseLook);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMouseLook)) = vector;
		}
	}

	public unsafe Vector2 MousePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MousePos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MousePos)) = vector;
		}
	}

	public unsafe float m_Yaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Yaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Yaw)) = num;
		}
	}

	public unsafe float m_Pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pitch)) = num;
		}
	}

	public unsafe float m_Roll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Roll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Roll)) = num;
		}
	}

	public unsafe float lastCorrectYaw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCorrectYaw);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCorrectYaw)) = num;
		}
	}

	public unsafe float lastCorrectPitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCorrectPitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCorrectPitch)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17828, XrefRangeEnd = 17829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17829, XrefRangeEnd = 17830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17830, XrefRangeEnd = 17838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17849, RefRangeEnd = 17850, XrefRangeStart = 17838, XrefRangeEnd = 17849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Prepare(Vector3 newPosition, Vector3 newRotation, Vector4 limit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&newPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newRotation;
		*(Vector4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &limit;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_Vector3_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17850, XrefRangeEnd = 17866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotationLimit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationLimit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetRotationLimit(Vector4 limit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&limit);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationLimit_Public_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17866, XrefRangeEnd = 17881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17881, XrefRangeEnd = 17933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotationFromOther(Transform OtherTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(OtherTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationFromOther_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 17937, RefRangeEnd = 17940, XrefRangeStart = 17933, XrefRangeEnd = 17937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(Vector3 newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17940, XrefRangeEnd = 17955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(Transform otherTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17955, XrefRangeEnd = 17979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Shift()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shift_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18031, RefRangeEnd = 18032, XrefRangeStart = 17979, XrefRangeEnd = 18031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetCameraLook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraLook_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18032, XrefRangeEnd = 18037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 NaNSafeVector2(Vector2 vector, Vector2 prevVector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vector);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prevVector;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float ClampAngle(float angle, float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&angle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 18048, RefRangeEnd = 18050, XrefRangeStart = 18037, XrefRangeEnd = 18048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18050, XrefRangeEnd = 18064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FixedCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FixedCamera()
	{
		Il2CppClassPointerStore<FixedCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FixedCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr);
		NativeFieldInfoPtr_fullRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "fullRotation");
		NativeFieldInfoPtr_rotationYawLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "rotationYawLimit");
		NativeFieldInfoPtr_rotationPitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "rotationPitchLimit");
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_noSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "noSmooth");
		NativeFieldInfoPtr_camShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "camShift");
		NativeFieldInfoPtr_rotShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "rotShift");
		NativeFieldInfoPtr_HorizontalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "HorizontalSpeed");
		NativeFieldInfoPtr_VerticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "VerticalSpeed");
		NativeFieldInfoPtr_MouseLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MouseLookSensitivity");
		NativeFieldInfoPtr_MouseLookSmoothSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MouseLookSmoothSteps");
		NativeFieldInfoPtr_MouseLookSmoothWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MouseLookSmoothWeight");
		NativeFieldInfoPtr_MouseLookAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MouseLookAcceleration");
		NativeFieldInfoPtr_MouseLookAccelerationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MouseLookAccelerationThreshold");
		NativeFieldInfoPtr_MouseLookInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MouseLookInvert");
		NativeFieldInfoPtr_m_MouseLookSmoothMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_MouseLookSmoothMove");
		NativeFieldInfoPtr_m_MouseLookSmoothBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_MouseLookSmoothBuffer");
		NativeFieldInfoPtr_m_LastMouseLookFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_LastMouseLookFrame");
		NativeFieldInfoPtr_m_CurrentMouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_CurrentMouseLook");
		NativeFieldInfoPtr_MousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "MousePos");
		NativeFieldInfoPtr_m_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_Yaw");
		NativeFieldInfoPtr_m_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_Pitch");
		NativeFieldInfoPtr_m_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "m_Roll");
		NativeFieldInfoPtr_lastCorrectYaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "lastCorrectYaw");
		NativeFieldInfoPtr_lastCorrectPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, "lastCorrectPitch");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_Prepare_Public_Void_Vector3_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_SetRotationLimit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_SetRotationLimit_Public_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr_SetRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_SetRotationFromOther_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_SetPosition_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_Shift_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_GetCameraLook_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_LoadData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedCamera>.NativeClassPtr, 100664623);
	}

	public FixedCamera(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
