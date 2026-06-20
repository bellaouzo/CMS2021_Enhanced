using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
	[ObfuscatedName("FPSCamera/<Prepare>d__55")]
	public sealed class _Prepare_d__55 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__fpsInputController_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe FPSCamera __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new FPSCamera(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe FPSInputController _fpsInputController_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fpsInputController_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new FPSInputController(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fpsInputController_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _Prepare_d__55(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17346, XrefRangeEnd = 17402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17402, XrefRangeEnd = 17407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Prepare_d__55()
		{
			Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "<Prepare>d__55");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__fpsInputController_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, "<fpsInputController>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, 100664601);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, 100664602);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, 100664603);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, 100664604);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, 100664605);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__55>.NativeClassPtr, 100664606);
		}

		public _Prepare_d__55(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_HeadHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_readInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCrouching;

	private static readonly System.IntPtr NativeFieldInfoPtr_timer1;

	private static readonly System.IntPtr NativeFieldInfoPtr_timer2;

	private static readonly System.IntPtr NativeFieldInfoPtr_bobbingSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_bobbingAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bobShift;

	private static readonly System.IntPtr NativeFieldInfoPtr_bobbingHorizontalSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_bobbingHorizontalAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FPSCharacterController;

	private static readonly System.IntPtr NativeFieldInfoPtr_FPSCharacterMotor;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookSmoothSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookSmoothWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookAccelerationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookInvert;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMouseLookSmoothMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_mMouseLookSmoothBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_mLastMouseLookFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentMouseLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Yaw;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Roll;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCorrectYaw;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCorrectPitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_RotationYawLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_RotationPitchLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_motorMaxForwardSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_motorMaxSidewaysSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_motorMaxBackwardsSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_crouchHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCrouchForwardSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCrouchSidewaysSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCrouchBackwardsSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_DiferenceInHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrouchOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_waveslice;

	private static readonly System.IntPtr NativeFieldInfoPtr_waveslice2;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCameraHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_headBobbingActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_crouchingActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalFOV;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalRoll;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalCrouchOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalIsCrouching;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraX;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAudioPlaying;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifier;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnablePhotoMode_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFOV_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRotation_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDoFDistance_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveCamera_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetCamera_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeadBobVertical_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeadBobHorizontal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationToCharacter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSavedRotation_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraLook_Private_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMotorValueIfCrunching_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMotorValueIfNotCrunching_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCharacterMotorSettings_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnUpdateCallBack_Private_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Crouch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCrouchingState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr));

	public unsafe float HeadHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadHeight)) = num;
		}
	}

	public unsafe bool readInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readInput)) = flag;
		}
	}

	public unsafe GameObject fpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static bool isCrouching
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isCrouching, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isCrouching, &flag);
		}
	}

	public unsafe float timer1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer1)) = num;
		}
	}

	public unsafe float timer2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer2)) = num;
		}
	}

	public unsafe float bobbingSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingSpeed)) = num;
		}
	}

	public unsafe float bobbingAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingAmount)) = num;
		}
	}

	public unsafe float bobShift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobShift);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobShift)) = num;
		}
	}

	public unsafe float bobbingHorizontalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingHorizontalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingHorizontalSpeed)) = num;
		}
	}

	public unsafe float bobbingHorizontalAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingHorizontalAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bobbingHorizontalAmount)) = num;
		}
	}

	public unsafe CharacterController FPSCharacterController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSCharacterController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSCharacterController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterMotor FPSCharacterMotor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSCharacterMotor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterMotor(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSCharacterMotor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Camera MainCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2 mouseLookSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookSensitivity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookSensitivity)) = vector;
		}
	}

	public unsafe int mouseLookSmoothSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookSmoothSteps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookSmoothSteps)) = num;
		}
	}

	public unsafe float mouseLookSmoothWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookSmoothWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookSmoothWeight)) = num;
		}
	}

	public unsafe bool mouseLookAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookAcceleration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookAcceleration)) = flag;
		}
	}

	public unsafe float mouseLookAccelerationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookAccelerationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookAccelerationThreshold)) = num;
		}
	}

	public unsafe bool mouseLookInvert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookInvert);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookInvert)) = flag;
		}
	}

	public unsafe Vector2 mMouseLookSmoothMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMouseLookSmoothMove);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMouseLookSmoothMove)) = vector;
		}
	}

	public unsafe List<Vector2> mMouseLookSmoothBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMouseLookSmoothBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mMouseLookSmoothBuffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int mLastMouseLookFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLastMouseLookFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mLastMouseLookFrame)) = num;
		}
	}

	public unsafe Vector2 mCurrentMouseLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCurrentMouseLook);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mCurrentMouseLook)) = vector;
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

	public unsafe Vector2 RotationYawLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationYawLimit);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationYawLimit)) = vector;
		}
	}

	public unsafe Vector2 RotationPitchLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationPitchLimit);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationPitchLimit)) = vector;
		}
	}

	public unsafe float motorMaxForwardSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorMaxForwardSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorMaxForwardSpeed)) = num;
		}
	}

	public unsafe float motorMaxSidewaysSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorMaxSidewaysSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorMaxSidewaysSpeed)) = num;
		}
	}

	public unsafe float motorMaxBackwardsSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorMaxBackwardsSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motorMaxBackwardsSpeed)) = num;
		}
	}

	public unsafe float crouchHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouchHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouchHeight)) = num;
		}
	}

	public unsafe float MaxCrouchForwardSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCrouchForwardSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCrouchForwardSpeed)) = num;
		}
	}

	public unsafe float MaxCrouchSidewaysSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCrouchSidewaysSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCrouchSidewaysSpeed)) = num;
		}
	}

	public unsafe float MaxCrouchBackwardsSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCrouchBackwardsSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCrouchBackwardsSpeed)) = num;
		}
	}

	public unsafe float DiferenceInHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiferenceInHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiferenceInHeight)) = num;
		}
	}

	public unsafe float CrouchOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrouchOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CrouchOffset)) = num;
		}
	}

	public unsafe float fpsVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsVelocity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsVelocity)) = num;
		}
	}

	public unsafe float waveslice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveslice);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveslice)) = num;
		}
	}

	public unsafe float waveslice2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveslice2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveslice2)) = num;
		}
	}

	public unsafe float maxCameraHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCameraHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCameraHeight)) = num;
		}
	}

	public unsafe float cameraOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraOffset)) = num;
		}
	}

	public unsafe bool headBobbingActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headBobbingActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headBobbingActive)) = flag;
		}
	}

	public unsafe bool crouchingActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouchingActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouchingActive)) = flag;
		}
	}

	public unsafe float originalFOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalFOV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalFOV)) = num;
		}
	}

	public unsafe float originalRoll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalRoll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalRoll)) = num;
		}
	}

	public unsafe float originalCrouchOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalCrouchOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalCrouchOffset)) = num;
		}
	}

	public unsafe bool originalIsCrouching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalIsCrouching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalIsCrouching)) = flag;
		}
	}

	public unsafe float cameraX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraX)) = num;
		}
	}

	public unsafe InputManager InputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsReady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady)) = flag;
		}
	}

	public unsafe bool isAudioPlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAudioPlaying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAudioPlaying)) = flag;
		}
	}

	public unsafe float modifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17407, XrefRangeEnd = 17418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17418, XrefRangeEnd = 17421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17421, XrefRangeEnd = 17499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17503, RefRangeEnd = 17505, XrefRangeStart = 17499, XrefRangeEnd = 17503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnablePhotoMode(bool enable, bool setCameraSettings = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&enable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setCameraSettings;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnablePhotoMode_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 17517, RefRangeEnd = 17520, XrefRangeStart = 17505, XrefRangeEnd = 17517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHeight(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 17525, RefRangeEnd = 17528, XrefRangeStart = 17520, XrefRangeEnd = 17525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFOV(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFOV_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 17547, RefRangeEnd = 17550, XrefRangeStart = 17528, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRotation(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 17564, RefRangeEnd = 17573, XrefRangeStart = 17550, XrefRangeEnd = 17564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDoFDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDoFDistance_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17573, XrefRangeEnd = 17575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17575, XrefRangeEnd = 17577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17577, XrefRangeEnd = 17604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17604, XrefRangeEnd = 17621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17621, XrefRangeEnd = 17628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeadBobVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeadBobVertical_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17628, XrefRangeEnd = 17635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HeadBobHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeadBobHorizontal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17657, RefRangeEnd = 17658, XrefRangeStart = 17635, XrefRangeEnd = 17657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17677, RefRangeEnd = 17678, XrefRangeStart = 17658, XrefRangeEnd = 17677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotationToCharacter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationToCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17678, XrefRangeEnd = 17694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookAt(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookAt_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSavedRotation(Vector3 newRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newRotation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSavedRotation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17736, RefRangeEnd = 17737, XrefRangeStart = 17694, XrefRangeEnd = 17736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17737, XrefRangeEnd = 17742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 17753, RefRangeEnd = 17756, XrefRangeStart = 17742, XrefRangeEnd = 17753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17756, XrefRangeEnd = 17757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17757, XrefRangeEnd = 17763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMotorValueIfCrunching()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMotorValueIfCrunching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17763, XrefRangeEnd = 17769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMotorValueIfNotCrunching()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMotorValueIfNotCrunching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void LoadCharacterMotorSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCharacterMotorSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void tweenOnUpdateCallBack(float newValue, float ratio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newValue);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tweenOnUpdateCallBack_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17791, RefRangeEnd = 17792, XrefRangeStart = 17769, XrefRangeEnd = 17791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Crouch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Crouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17814, RefRangeEnd = 17816, XrefRangeStart = 17792, XrefRangeEnd = 17814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCrouchingState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCrouchingState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17816, XrefRangeEnd = 17828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPSCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FPSCamera()
	{
		Il2CppClassPointerStore<FPSCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FPSCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr);
		NativeFieldInfoPtr_HeadHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "HeadHeight");
		NativeFieldInfoPtr_readInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "readInput");
		NativeFieldInfoPtr_fpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "fpc");
		NativeFieldInfoPtr_isCrouching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "isCrouching");
		NativeFieldInfoPtr_timer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "timer1");
		NativeFieldInfoPtr_timer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "timer2");
		NativeFieldInfoPtr_bobbingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "bobbingSpeed");
		NativeFieldInfoPtr_bobbingAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "bobbingAmount");
		NativeFieldInfoPtr_bobShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "bobShift");
		NativeFieldInfoPtr_bobbingHorizontalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "bobbingHorizontalSpeed");
		NativeFieldInfoPtr_bobbingHorizontalAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "bobbingHorizontalAmount");
		NativeFieldInfoPtr_FPSCharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "FPSCharacterController");
		NativeFieldInfoPtr_FPSCharacterMotor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "FPSCharacterMotor");
		NativeFieldInfoPtr_MainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "MainCamera");
		NativeFieldInfoPtr_mouseLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mouseLookSensitivity");
		NativeFieldInfoPtr_mouseLookSmoothSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mouseLookSmoothSteps");
		NativeFieldInfoPtr_mouseLookSmoothWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mouseLookSmoothWeight");
		NativeFieldInfoPtr_mouseLookAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mouseLookAcceleration");
		NativeFieldInfoPtr_mouseLookAccelerationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mouseLookAccelerationThreshold");
		NativeFieldInfoPtr_mouseLookInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mouseLookInvert");
		NativeFieldInfoPtr_mMouseLookSmoothMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mMouseLookSmoothMove");
		NativeFieldInfoPtr_mMouseLookSmoothBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mMouseLookSmoothBuffer");
		NativeFieldInfoPtr_mLastMouseLookFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mLastMouseLookFrame");
		NativeFieldInfoPtr_mCurrentMouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "mCurrentMouseLook");
		NativeFieldInfoPtr_m_Yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "m_Yaw");
		NativeFieldInfoPtr_m_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "m_Pitch");
		NativeFieldInfoPtr_m_Roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "m_Roll");
		NativeFieldInfoPtr_lastCorrectYaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "lastCorrectYaw");
		NativeFieldInfoPtr_lastCorrectPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "lastCorrectPitch");
		NativeFieldInfoPtr_RotationYawLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "RotationYawLimit");
		NativeFieldInfoPtr_RotationPitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "RotationPitchLimit");
		NativeFieldInfoPtr_motorMaxForwardSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "motorMaxForwardSpeed");
		NativeFieldInfoPtr_motorMaxSidewaysSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "motorMaxSidewaysSpeed");
		NativeFieldInfoPtr_motorMaxBackwardsSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "motorMaxBackwardsSpeed");
		NativeFieldInfoPtr_crouchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "crouchHeight");
		NativeFieldInfoPtr_MaxCrouchForwardSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "MaxCrouchForwardSpeed");
		NativeFieldInfoPtr_MaxCrouchSidewaysSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "MaxCrouchSidewaysSpeed");
		NativeFieldInfoPtr_MaxCrouchBackwardsSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "MaxCrouchBackwardsSpeed");
		NativeFieldInfoPtr_DiferenceInHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "DiferenceInHeight");
		NativeFieldInfoPtr_CrouchOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "CrouchOffset");
		NativeFieldInfoPtr_fpsVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "fpsVelocity");
		NativeFieldInfoPtr_waveslice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "waveslice");
		NativeFieldInfoPtr_waveslice2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "waveslice2");
		NativeFieldInfoPtr_maxCameraHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "maxCameraHeight");
		NativeFieldInfoPtr_cameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "cameraOffset");
		NativeFieldInfoPtr_headBobbingActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "headBobbingActive");
		NativeFieldInfoPtr_crouchingActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "crouchingActive");
		NativeFieldInfoPtr_originalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "originalFOV");
		NativeFieldInfoPtr_originalRoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "originalRoll");
		NativeFieldInfoPtr_originalCrouchOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "originalCrouchOffset");
		NativeFieldInfoPtr_originalIsCrouching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "originalIsCrouching");
		NativeFieldInfoPtr_cameraX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "cameraX");
		NativeFieldInfoPtr_InputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "InputManager");
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "IsReady");
		NativeFieldInfoPtr_isAudioPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "isAudioPlaying");
		NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, "modifier");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr_Prepare_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664573);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664574);
		NativeMethodInfoPtr_EnablePhotoMode_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664575);
		NativeMethodInfoPtr_UpdateHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr_SetFOV_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_UpdateRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_GetDoFDistance_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_SaveCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664580);
		NativeMethodInfoPtr_ResetCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_HeadBobVertical_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_HeadBobHorizontal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664585);
		NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664586);
		NativeMethodInfoPtr_SetRotationToCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664587);
		NativeMethodInfoPtr_LookAt_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_SetSavedRotation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_GetCameraLook_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_LoadData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_ClampAngle_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr_ChangeMotorValueIfCrunching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr_ChangeMotorValueIfNotCrunching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr_LoadCharacterMotorSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_tweenOnUpdateCallBack_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_Crouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_UpdateCrouchingState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSCamera>.NativeClassPtr, 100664600);
	}

	public FPSCamera(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
