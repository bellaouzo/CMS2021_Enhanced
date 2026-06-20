using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LeanAudio : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedWaveDistances;

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedWaveDistancesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_longList;

	private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr));

	public unsafe static float MIN_FREQEUNCY_PERIOD
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD, &num);
		}
	}

	public unsafe static int PROCESSING_ITERATIONS_MAX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX, &num);
		}
	}

	public unsafe static Il2CppStructArray<float> generatedWaveDistances
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_generatedWaveDistances, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_generatedWaveDistances, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int generatedWaveDistancesCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_generatedWaveDistancesCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_generatedWaveDistancesCount, &num);
		}
	}

	public unsafe static Il2CppStructArray<float> longList
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_longList, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_longList, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 5971, RefRangeEnd = 5977, XrefRangeStart = 5954, XrefRangeEnd = 5971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LeanAudioOptions options()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5977, XrefRangeEnd = 5985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(frequency);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(options);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioStream(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5993, RefRangeEnd = 5994, XrefRangeStart = 5985, XrefRangeEnd = 5993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(frequency);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(options);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 6034, RefRangeEnd = 6041, XrefRangeStart = 5994, XrefRangeEnd = 6034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(frequency);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(options);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 6088, RefRangeEnd = 6095, XrefRangeStart = 6041, XrefRangeEnd = 6088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&waveLength);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(options);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe static void OnAudioSetPosition(int newPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6095, XrefRangeEnd = 6112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip generateAudioFromCurve(AnimationCurve curve, [Optional] int frequencyRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frequencyRate;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6112, XrefRangeEnd = 6120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 6126, RefRangeEnd = 6130, XrefRangeStart = 6120, XrefRangeEnd = 6126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6130, XrefRangeEnd = 6134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6134, XrefRangeEnd = 6142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 6164, RefRangeEnd = 6169, XrefRangeStart = 6142, XrefRangeEnd = 6164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6169, XrefRangeEnd = 6186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, [Optional] float scaleX)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(curve);
		*(System.IntPtr**)num = &intPtr;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleX;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		curve = ((intPtr3 == (System.IntPtr)0) ? null : new AnimationCurve(intPtr3));
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LeanAudio()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LeanAudio()
	{
		Il2CppClassPointerStore<LeanAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanAudio");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr);
		NativeFieldInfoPtr_MIN_FREQEUNCY_PERIOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "MIN_FREQEUNCY_PERIOD");
		NativeFieldInfoPtr_PROCESSING_ITERATIONS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "PROCESSING_ITERATIONS_MAX");
		NativeFieldInfoPtr_generatedWaveDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "generatedWaveDistances");
		NativeFieldInfoPtr_generatedWaveDistancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "generatedWaveDistancesCount");
		NativeFieldInfoPtr_longList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, "longList");
		NativeMethodInfoPtr_options_Public_Static_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_createAudioStream_Public_Static_LeanAudioStream_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr_createAudio_Public_Static_AudioClip_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_createAudioWave_Private_Static_Int32_AnimationCurve_AnimationCurve_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_createAudioFromWave_Private_Static_AudioClip_Int32_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_OnAudioSetPosition_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_generateAudioFromCurve_Public_Static_AudioClip_AnimationCurve_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663875);
		NativeMethodInfoPtr_play_Public_Static_AudioSource_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_playClipAt_Public_Static_AudioSource_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_printOutAudioClip_Public_Static_Void_AudioClip_byref_AnimationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudio>.NativeClassPtr, 100663879);
	}

	public LeanAudio(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
