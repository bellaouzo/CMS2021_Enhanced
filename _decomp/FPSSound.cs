using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FPSSound : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MINVelocityToMoveSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_FootStepNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_FootStepAlternative;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterController;

	private static readonly System.IntPtr NativeFieldInfoPtr_motor;

	private static readonly System.IntPtr NativeFieldInfoPtr_FPSAudioSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_FPSAudioSourceAlternative;

	private static readonly System.IntPtr NativeFieldInfoPtr_FootStepNormalVol;

	private static readonly System.IntPtr NativeFieldInfoPtr_FootStepAlternativeVol;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVol;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlaying;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FPSSound>.NativeClassPtr));

	public unsafe static float MINVelocityToMoveSound
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINVelocityToMoveSound, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINVelocityToMoveSound, &num);
		}
	}

	public unsafe AudioClip FootStepNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepNormal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepNormal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip FootStepAlternative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepAlternative);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepAlternative), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterController characterController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterController), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe AudioSource FPSAudioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSAudioSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource FPSAudioSourceAlternative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSAudioSourceAlternative);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FPSAudioSourceAlternative), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float FootStepNormalVol
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepNormalVol);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepNormalVol)) = num;
		}
	}

	public unsafe float FootStepAlternativeVol
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepAlternativeVol);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootStepAlternativeVol)) = num;
		}
	}

	public unsafe float maxVol
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVol);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVol)) = num;
		}
	}

	public unsafe bool isPlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlaying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlaying)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43997, XrefRangeEnd = 44009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44009, XrefRangeEnd = 44018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44018, XrefRangeEnd = 44035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44035, XrefRangeEnd = 44059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44059, XrefRangeEnd = 44062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPSSound()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPSSound>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FPSSound()
	{
		Il2CppClassPointerStore<FPSSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FPSSound");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPSSound>.NativeClassPtr);
		NativeFieldInfoPtr_MINVelocityToMoveSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "MINVelocityToMoveSound");
		NativeFieldInfoPtr_FootStepNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "FootStepNormal");
		NativeFieldInfoPtr_FootStepAlternative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "FootStepAlternative");
		NativeFieldInfoPtr_characterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "characterController");
		NativeFieldInfoPtr_motor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "motor");
		NativeFieldInfoPtr_FPSAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "FPSAudioSource");
		NativeFieldInfoPtr_FPSAudioSourceAlternative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "FPSAudioSourceAlternative");
		NativeFieldInfoPtr_FootStepNormalVol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "FootStepNormalVol");
		NativeFieldInfoPtr_FootStepAlternativeVol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "FootStepAlternativeVol");
		NativeFieldInfoPtr_maxVol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "maxVol");
		NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, "isPlaying");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, 100665975);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, 100665976);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, 100665977);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, 100665978);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSSound>.NativeClassPtr, 100665979);
	}

	public FPSSound(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
