using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	[ObfuscatedName("SoundManager/<>c__DisplayClass23_0")]
	public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_go;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StopLoopSFX_b__0_Internal_Boolean_LoopedObject_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr));

		public unsafe GameObject go
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass23_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83901, XrefRangeEnd = 83911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StopLoopSFX_b__0(LoopedObject x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StopLoopSFX_b__0_Internal_Boolean_LoopedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass23_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, "<>c__DisplayClass23_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr);
			NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, "go");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, 100668104);
			NativeMethodInfoPtr__StopLoopSFX_b__0_Internal_Boolean_LoopedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, 100668105);
		}

		public __c__DisplayClass23_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SFXList;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopedAudio;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_SoundManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSFXIndex_Private_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySFX_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySFXOnGamepad_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySFX_Public_Void_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySFXCopyProperties_Public_Void_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySFXOneShot_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySFXOneShot_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOneShotRandom_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayRandom_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayRandom_Private_Void_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayRandomOnGamepad_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayClipAtPointCopyProperties_Public_Static_AudioSource_AudioSource_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayLoopSFX_Public_Void_GameObject_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoopSFX_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopLoopSFX_Public_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSFX_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLooping_Public_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SoundManager>.NativeClassPtr));

	public unsafe List<SFXObject> SFXList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SFXList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SFXObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SFXList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)) = flag;
		}
	}

	public unsafe static SoundManager m_instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new SoundManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<LoopedObject> loopedAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopedAudio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<LoopedObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopedAudio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83911, XrefRangeEnd = 83915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83915, XrefRangeEnd = 83938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83938, XrefRangeEnd = 83942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundManager Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_SoundManager_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new SoundManager(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83942, XrefRangeEnd = 83991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 83994, RefRangeEnd = 84003, XrefRangeStart = 83991, XrefRangeEnd = 83994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindSFXIndex(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSFXIndex_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(123)]
	[CachedScanResults(RefRangeStart = 84020, RefRangeEnd = 84143, XrefRangeStart = 84003, XrefRangeEnd = 84020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySFX(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySFX_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84143, XrefRangeEnd = 84148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySFXOnGamepad(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySFXOnGamepad_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 84159, RefRangeEnd = 84174, XrefRangeStart = 84148, XrefRangeEnd = 84159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySFX(string soundName, Vector3 playPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySFX_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 84187, RefRangeEnd = 84189, XrefRangeStart = 84174, XrefRangeEnd = 84187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySFXCopyProperties(string soundName, Vector3 playPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySFXCopyProperties_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 84207, RefRangeEnd = 84238, XrefRangeStart = 84189, XrefRangeEnd = 84207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySFXOneShot(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySFXOneShot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84238, XrefRangeEnd = 84256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySFXOneShot(string soundName, float volumeScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeScale;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySFXOneShot_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 84275, RefRangeEnd = 84277, XrefRangeStart = 84256, XrefRangeEnd = 84275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayOneShotRandom(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOneShotRandom_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 84299, RefRangeEnd = 84301, XrefRangeStart = 84277, XrefRangeEnd = 84299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayRandom(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayRandom_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84301, XrefRangeEnd = 84329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayRandom(int index, Vector3 playPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayRandom_Private_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84329, XrefRangeEnd = 84334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayRandomOnGamepad(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayRandomOnGamepad_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84334, XrefRangeEnd = 84350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlaying(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlaying_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84450, RefRangeEnd = 84451, XrefRangeStart = 84350, XrefRangeEnd = 84450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource PlayClipAtPointCopyProperties(AudioSource audioSource, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioSource);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayClipAtPointCopyProperties_Public_Static_AudioSource_AudioSource_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 84507, RefRangeEnd = 84515, XrefRangeStart = 84451, XrefRangeEnd = 84507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayLoopSFX(GameObject go, string soundName, float loopStart, float loopEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(soundName);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopStart;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopEnd;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayLoopSFX_Public_Void_GameObject_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 84521, RefRangeEnd = 84525, XrefRangeStart = 84515, XrefRangeEnd = 84521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoopSFX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoopSFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 84542, RefRangeEnd = 84570, XrefRangeStart = 84525, XrefRangeEnd = 84542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopLoopSFX(GameObject go, bool playEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playEnd;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopLoopSFX_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84570, XrefRangeEnd = 84587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSFX(string soundName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSFX_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 84610, RefRangeEnd = 84629, XrefRangeStart = 84587, XrefRangeEnd = 84610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLooping(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLooping_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84629, XrefRangeEnd = 84630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84630, XrefRangeEnd = 84639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SoundManager()
	{
		Il2CppClassPointerStore<SoundManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SoundManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundManager>.NativeClassPtr);
		NativeFieldInfoPtr_SFXList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, "SFXList");
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, "debug");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, "m_instance");
		NativeFieldInfoPtr_loopedAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, "loopedAudio");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668079);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668080);
		NativeMethodInfoPtr_Get_Public_Static_SoundManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668081);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668082);
		NativeMethodInfoPtr_FindSFXIndex_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668083);
		NativeMethodInfoPtr_PlaySFX_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668084);
		NativeMethodInfoPtr_PlaySFXOnGamepad_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668085);
		NativeMethodInfoPtr_PlaySFX_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668086);
		NativeMethodInfoPtr_PlaySFXCopyProperties_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668087);
		NativeMethodInfoPtr_PlaySFXOneShot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668088);
		NativeMethodInfoPtr_PlaySFXOneShot_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668089);
		NativeMethodInfoPtr_PlayOneShotRandom_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668090);
		NativeMethodInfoPtr_PlayRandom_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668091);
		NativeMethodInfoPtr_PlayRandom_Private_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668092);
		NativeMethodInfoPtr_PlayRandomOnGamepad_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668093);
		NativeMethodInfoPtr_IsPlaying_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668094);
		NativeMethodInfoPtr_PlayClipAtPointCopyProperties_Public_Static_AudioSource_AudioSource_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668095);
		NativeMethodInfoPtr_PlayLoopSFX_Public_Void_GameObject_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668096);
		NativeMethodInfoPtr_LoopSFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668097);
		NativeMethodInfoPtr_StopLoopSFX_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668098);
		NativeMethodInfoPtr_StopSFX_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668099);
		NativeMethodInfoPtr_IsLooping_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668100);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668101);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManager>.NativeClassPtr, 100668102);
	}

	public SoundManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
