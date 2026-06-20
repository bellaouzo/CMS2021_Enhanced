using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ItemFollowCamera : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemToFollow;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoSetAnchorOnAwake;

	private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SmoothFollow;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothMoveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothRotateSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_wasPaused;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_addRotation;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnModeChange_Private_Void_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOffObject_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOnObject_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Follow_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr));

	public unsafe Transform itemToFollow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemToFollow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemToFollow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool AutoSetAnchorOnAwake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSetAnchorOnAwake);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoSetAnchorOnAwake)) = flag;
		}
	}

	public unsafe Vector3 anchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor)) = vector;
		}
	}

	public unsafe bool SmoothFollow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmoothFollow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmoothFollow)) = flag;
		}
	}

	public unsafe float smoothMoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothMoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothMoveSpeed)) = num;
		}
	}

	public unsafe float smoothRotateSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothRotateSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothRotateSpeed)) = num;
		}
	}

	public unsafe bool wasPaused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasPaused);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasPaused)) = flag;
		}
	}

	public unsafe GameMode GameMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameMode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameMode(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameMode), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Quaternion addRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addRotation)) = quaternion;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60436, XrefRangeEnd = 60467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60467, XrefRangeEnd = 60479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60479, XrefRangeEnd = 60488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnModeChange(gameMode newGameMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newGameMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnModeChange_Private_Void_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60488, XrefRangeEnd = 60492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TurnOffObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOffObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60492, XrefRangeEnd = 60502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TurnOnObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOnObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 60515, RefRangeEnd = 60519, XrefRangeStart = 60502, XrefRangeEnd = 60515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Follow(bool smooth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&smooth);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Follow_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60519, XrefRangeEnd = 60520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60520, XrefRangeEnd = 60523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemFollowCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ItemFollowCamera()
	{
		Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ItemFollowCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr);
		NativeFieldInfoPtr_itemToFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "itemToFollow");
		NativeFieldInfoPtr_AutoSetAnchorOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "AutoSetAnchorOnAwake");
		NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "anchor");
		NativeFieldInfoPtr_SmoothFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "SmoothFollow");
		NativeFieldInfoPtr_smoothMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "smoothMoveSpeed");
		NativeFieldInfoPtr_smoothRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "smoothRotateSpeed");
		NativeFieldInfoPtr_wasPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "wasPaused");
		NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "GameMode");
		NativeFieldInfoPtr_addRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, "addRotation");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666920);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666921);
		NativeMethodInfoPtr_OnModeChange_Private_Void_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666922);
		NativeMethodInfoPtr_TurnOffObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666923);
		NativeMethodInfoPtr_TurnOnObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666924);
		NativeMethodInfoPtr_Follow_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666925);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666926);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFollowCamera>.NativeClassPtr, 100666927);
	}

	public ItemFollowCamera(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
