using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LeanAudioOptions : Il2CppSystem.Object
{
	public enum LeanAudioWaveStyle
	{
		Sine,
		Square,
		Sawtooth,
		Noise,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanAudioWaveStyle>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static LeanAudioWaveStyle()
		{
			Il2CppClassPointerStore<LeanAudioWaveStyle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "LeanAudioWaveStyle");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_waveStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_vibrato;

	private static readonly System.IntPtr NativeFieldInfoPtr_modulation;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequencyRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_waveNoiseScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_waveNoiseInfluence;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSetData;

	private static readonly System.IntPtr NativeFieldInfoPtr_stream;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr));

	public unsafe LeanAudioWaveStyle waveStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveStyle);
			return *(LeanAudioWaveStyle*)num;
		}
		set
		{
			*(LeanAudioWaveStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveStyle)) = leanAudioWaveStyle;
		}
	}

	public unsafe Il2CppStructArray<Vector3> vibrato
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vibrato);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vibrato), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector3> modulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modulation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modulation), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int frequencyRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyRate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyRate)) = num;
		}
	}

	public unsafe float waveNoiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveNoiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveNoiseScale)) = num;
		}
	}

	public unsafe float waveNoiseInfluence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveNoiseInfluence);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waveNoiseInfluence)) = num;
		}
	}

	public unsafe bool useSetData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSetData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSetData)) = flag;
		}
	}

	public unsafe LeanAudioStream stream
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stream);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LeanAudioStream(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setFrequency(int frequencyRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frequencyRate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setVibrato(Il2CppStructArray<Vector3> vibrato)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vibrato);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_ArrayOf_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveSquare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveSawtooth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveNoise()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&waveScale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&influence);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LeanAudioOptions(intPtr) : null;
	}

	static LeanAudioOptions()
	{
		Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanAudioOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr);
		NativeFieldInfoPtr_waveStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "waveStyle");
		NativeFieldInfoPtr_vibrato = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "vibrato");
		NativeFieldInfoPtr_modulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "modulation");
		NativeFieldInfoPtr_frequencyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "frequencyRate");
		NativeFieldInfoPtr_waveNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "waveNoiseScale");
		NativeFieldInfoPtr_waveNoiseInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "waveNoiseInfluence");
		NativeFieldInfoPtr_useSetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "useSetData");
		NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, "stream");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_setFrequency_Public_LeanAudioOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_setVibrato_Public_LeanAudioOptions_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_setWaveSine_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_setWaveSquare_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_setWaveSawtooth_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_setWaveNoise_Public_LeanAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_setWaveStyle_Public_LeanAudioOptions_LeanAudioWaveStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_setWaveNoiseScale_Public_LeanAudioOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_setWaveNoiseInfluence_Public_LeanAudioOptions_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioOptions>.NativeClassPtr, 100663890);
	}

	public LeanAudioOptions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
