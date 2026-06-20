using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FPSInputController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_motor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONST_MAX_LENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_running;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCharacterControllerPosition_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCrouchingState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionNextToCar_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraRotationToCar_Public_Vector3_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr));

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

	public unsafe CharacterMotor motor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterMotor(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float CONST_MAX_LENGTH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CONST_MAX_LENGTH);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CONST_MAX_LENGTH)) = num;
		}
	}

	public unsafe float speedAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedAdd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedAdd)) = num;
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

	public unsafe Vector3 originalPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalPosition)) = vector;
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

	public unsafe bool running
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_running);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_running)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43747, XrefRangeEnd = 43764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43764, XrefRangeEnd = 43772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43772, XrefRangeEnd = 43812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 43844, RefRangeEnd = 43848, XrefRangeStart = 43812, XrefRangeEnd = 43844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCharacterControllerPosition(bool setOriginal = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setOriginal);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCharacterControllerPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43848, XrefRangeEnd = 43853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCrouchingState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCrouchingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43955, RefRangeEnd = 43957, XrefRangeStart = 43853, XrefRangeEnd = 43955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPositionNextToCar(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionNextToCar_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43976, RefRangeEnd = 43978, XrefRangeStart = 43957, XrefRangeEnd = 43976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetCameraRotationToCar(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraRotationToCar_Public_Vector3_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43982, RefRangeEnd = 43984, XrefRangeStart = 43978, XrefRangeEnd = 43982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43994, RefRangeEnd = 43997, XrefRangeStart = 43984, XrefRangeEnd = 43994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe FPSInputController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FPSInputController()
	{
		Il2CppClassPointerStore<FPSInputController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FPSInputController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr);
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "IsReady");
		NativeFieldInfoPtr_motor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "motor");
		NativeFieldInfoPtr_CONST_MAX_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "CONST_MAX_LENGTH");
		NativeFieldInfoPtr_speedAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "speedAdd");
		NativeFieldInfoPtr_InputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "InputManager");
		NativeFieldInfoPtr_originalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "originalPosition");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, "running");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665965);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665967);
		NativeMethodInfoPtr_SetCharacterControllerPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665968);
		NativeMethodInfoPtr_UpdateCrouchingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665969);
		NativeMethodInfoPtr_SetPositionNextToCar_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665970);
		NativeMethodInfoPtr_GetCameraRotationToCar_Public_Vector3_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665971);
		NativeMethodInfoPtr_ResetPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665972);
		NativeMethodInfoPtr_UpdateSpeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665973);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInputController>.NativeClassPtr, 100665974);
	}

	public FPSInputController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
