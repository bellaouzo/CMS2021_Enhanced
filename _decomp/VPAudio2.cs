using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPAudio2 : VehicleBehaviour
{
	[System.Serializable]
	public class Engine : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_audioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_audioSource2;

		private static readonly System.IntPtr NativeFieldInfoPtr_audioBaseRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_volumeAtRest;

		private static readonly System.IntPtr NativeFieldInfoPtr_volumeAtFullLoad;

		private static readonly System.IntPtr NativeFieldInfoPtr_volumeChangeRateUp;

		private static readonly System.IntPtr NativeFieldInfoPtr_volumeChangeRateDown;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Engine>.NativeClassPtr));

		public unsafe AudioSource audioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe AudioSource audioSource2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource2), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float audioBaseRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioBaseRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioBaseRpm)) = num;
			}
		}

		public unsafe float volumeAtRest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeAtRest);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeAtRest)) = num;
			}
		}

		public unsafe float volumeAtFullLoad
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeAtFullLoad);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeAtFullLoad)) = num;
			}
		}

		public unsafe float volumeChangeRateUp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeChangeRateUp);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeChangeRateUp)) = num;
			}
		}

		public unsafe float volumeChangeRateDown
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeChangeRateDown);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeChangeRateDown)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe Engine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Engine>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Engine()
		{
			Il2CppClassPointerStore<Engine>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "Engine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Engine>.NativeClassPtr);
			NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "audioSource");
			NativeFieldInfoPtr_audioSource2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "audioSource2");
			NativeFieldInfoPtr_audioBaseRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "audioBaseRpm");
			NativeFieldInfoPtr_volumeAtRest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "volumeAtRest");
			NativeFieldInfoPtr_volumeAtFullLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "volumeAtFullLoad");
			NativeFieldInfoPtr_volumeChangeRateUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "volumeChangeRateUp");
			NativeFieldInfoPtr_volumeChangeRateDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "volumeChangeRateDown");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100670545);
		}

		public Engine(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class EngineExtras : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_turboAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_turboMinRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_turboMaxRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_turboMinPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_turboMaxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_turboMaxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_transmissionAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_transmissionMaxRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_transmissionMinPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_transmissionMaxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_transmissionMinVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_transmissionMaxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_turboRatioChangeRate;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr));

		public unsafe AudioSource turboAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float turboMinRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMinRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMinRpm)) = num;
			}
		}

		public unsafe float turboMaxRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMaxRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMaxRpm)) = num;
			}
		}

		public unsafe float turboMinPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMinPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMinPitch)) = num;
			}
		}

		public unsafe float turboMaxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMaxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMaxPitch)) = num;
			}
		}

		public unsafe float turboMaxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMaxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboMaxVolume)) = num;
			}
		}

		public unsafe AudioSource transmissionAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float transmissionMaxRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMaxRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMaxRatio)) = num;
			}
		}

		public unsafe float transmissionMinPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMinPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMinPitch)) = num;
			}
		}

		public unsafe float transmissionMaxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMaxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMaxPitch)) = num;
			}
		}

		public unsafe float transmissionMinVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMinVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMinVolume)) = num;
			}
		}

		public unsafe float transmissionMaxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMaxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionMaxVolume)) = num;
			}
		}

		public unsafe float turboRatioChangeRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboRatioChangeRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboRatioChangeRate)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe EngineExtras()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static EngineExtras()
		{
			Il2CppClassPointerStore<EngineExtras>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "EngineExtras");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr);
			NativeFieldInfoPtr_turboAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboAudioSource");
			NativeFieldInfoPtr_turboMinRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboMinRpm");
			NativeFieldInfoPtr_turboMaxRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboMaxRpm");
			NativeFieldInfoPtr_turboMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboMinPitch");
			NativeFieldInfoPtr_turboMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboMaxPitch");
			NativeFieldInfoPtr_turboMaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboMaxVolume");
			NativeFieldInfoPtr_transmissionAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "transmissionAudioSource");
			NativeFieldInfoPtr_transmissionMaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "transmissionMaxRatio");
			NativeFieldInfoPtr_transmissionMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "transmissionMinPitch");
			NativeFieldInfoPtr_transmissionMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "transmissionMaxPitch");
			NativeFieldInfoPtr_transmissionMinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "transmissionMinVolume");
			NativeFieldInfoPtr_transmissionMaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "transmissionMaxVolume");
			NativeFieldInfoPtr_turboRatioChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, "turboRatioChangeRate");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineExtras>.NativeClassPtr, 100670546);
		}

		public EngineExtras(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class Wheels : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_skidAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidMinSlip;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidMaxSlip;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidMinPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidMaxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidMaxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadMinSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadMaxSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadMinPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadMaxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadMinVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadMaxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_bumpAudioClip;

		private static readonly System.IntPtr NativeFieldInfoPtr_bumpMinForceDelta;

		private static readonly System.IntPtr NativeFieldInfoPtr_bumpMaxForceDelta;

		private static readonly System.IntPtr NativeFieldInfoPtr_bumpMinVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_bumpMaxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_skidRatioChangeRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadSpeedChangeRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_offroadCutoutSpeed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Wheels>.NativeClassPtr));

		public unsafe AudioSource skidAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float skidMinSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMinSlip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMinSlip)) = num;
			}
		}

		public unsafe float skidMaxSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMaxSlip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMaxSlip)) = num;
			}
		}

		public unsafe float skidMinPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMinPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMinPitch)) = num;
			}
		}

		public unsafe float skidMaxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMaxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMaxPitch)) = num;
			}
		}

		public unsafe float skidMaxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMaxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidMaxVolume)) = num;
			}
		}

		public unsafe float skidIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidIntensity)) = num;
			}
		}

		public unsafe AudioSource offroadAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float offroadMinSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMinSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMinSpeed)) = num;
			}
		}

		public unsafe float offroadMaxSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMaxSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMaxSpeed)) = num;
			}
		}

		public unsafe float offroadMinPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMinPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMinPitch)) = num;
			}
		}

		public unsafe float offroadMaxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMaxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMaxPitch)) = num;
			}
		}

		public unsafe float offroadMinVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMinVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMinVolume)) = num;
			}
		}

		public unsafe float offroadMaxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMaxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadMaxVolume)) = num;
			}
		}

		public unsafe AudioClip bumpAudioClip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpAudioClip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpAudioClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float bumpMinForceDelta
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMinForceDelta);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMinForceDelta)) = num;
			}
		}

		public unsafe float bumpMaxForceDelta
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMaxForceDelta);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMaxForceDelta)) = num;
			}
		}

		public unsafe float bumpMinVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMinVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMinVolume)) = num;
			}
		}

		public unsafe float bumpMaxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMaxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpMaxVolume)) = num;
			}
		}

		public unsafe float skidRatioChangeRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidRatioChangeRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skidRatioChangeRate)) = num;
			}
		}

		public unsafe float offroadSpeedChangeRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadSpeedChangeRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadSpeedChangeRate)) = num;
			}
		}

		public unsafe float offroadCutoutSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadCutoutSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offroadCutoutSpeed)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe Wheels()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheels>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Wheels()
		{
			Il2CppClassPointerStore<Wheels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "Wheels");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheels>.NativeClassPtr);
			NativeFieldInfoPtr_skidAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidAudioSource");
			NativeFieldInfoPtr_skidMinSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidMinSlip");
			NativeFieldInfoPtr_skidMaxSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidMaxSlip");
			NativeFieldInfoPtr_skidMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidMinPitch");
			NativeFieldInfoPtr_skidMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidMaxPitch");
			NativeFieldInfoPtr_skidMaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidMaxVolume");
			NativeFieldInfoPtr_skidIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidIntensity");
			NativeFieldInfoPtr_offroadAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadAudioSource");
			NativeFieldInfoPtr_offroadMinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadMinSpeed");
			NativeFieldInfoPtr_offroadMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadMaxSpeed");
			NativeFieldInfoPtr_offroadMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadMinPitch");
			NativeFieldInfoPtr_offroadMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadMaxPitch");
			NativeFieldInfoPtr_offroadMinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadMinVolume");
			NativeFieldInfoPtr_offroadMaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadMaxVolume");
			NativeFieldInfoPtr_bumpAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "bumpAudioClip");
			NativeFieldInfoPtr_bumpMinForceDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "bumpMinForceDelta");
			NativeFieldInfoPtr_bumpMaxForceDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "bumpMaxForceDelta");
			NativeFieldInfoPtr_bumpMinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "bumpMinVolume");
			NativeFieldInfoPtr_bumpMaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "bumpMaxVolume");
			NativeFieldInfoPtr_skidRatioChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "skidRatioChangeRate");
			NativeFieldInfoPtr_offroadSpeedChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadSpeedChangeRate");
			NativeFieldInfoPtr_offroadCutoutSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheels>.NativeClassPtr, "offroadCutoutSpeed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheels>.NativeClassPtr, 100670547);
		}

		public Wheels(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class Impacts : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hardImpactAudioClip;

		private static readonly System.IntPtr NativeFieldInfoPtr_softImpactAudioClip;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_minPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_randomPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_minVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_randomVolume;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Impacts>.NativeClassPtr));

		public unsafe AudioClip hardImpactAudioClip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardImpactAudioClip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardImpactAudioClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe AudioClip softImpactAudioClip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_softImpactAudioClip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_softImpactAudioClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float minSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed)) = num;
			}
		}

		public unsafe float maxSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
			}
		}

		public unsafe float minPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPitch)) = num;
			}
		}

		public unsafe float maxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPitch)) = num;
			}
		}

		public unsafe float randomPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomPitch)) = num;
			}
		}

		public unsafe float minVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVolume)) = num;
			}
		}

		public unsafe float maxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolume)) = num;
			}
		}

		public unsafe float randomVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomVolume)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe Impacts()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impacts>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Impacts()
		{
			Il2CppClassPointerStore<Impacts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "Impacts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Impacts>.NativeClassPtr);
			NativeFieldInfoPtr_hardImpactAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "hardImpactAudioClip");
			NativeFieldInfoPtr_softImpactAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "softImpactAudioClip");
			NativeFieldInfoPtr_minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "minSpeed");
			NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "maxSpeed");
			NativeFieldInfoPtr_minPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "minPitch");
			NativeFieldInfoPtr_maxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "maxPitch");
			NativeFieldInfoPtr_randomPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "randomPitch");
			NativeFieldInfoPtr_minVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "minVolume");
			NativeFieldInfoPtr_maxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "maxVolume");
			NativeFieldInfoPtr_randomVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impacts>.NativeClassPtr, "randomVolume");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impacts>.NativeClassPtr, 100670548);
		}

		public Impacts(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class Drags : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hardDragAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_softDragAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_minPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_minVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchAudioClip;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchRandomThreshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchMinSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchMinInterval;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchMinPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchMaxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchMinVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_scratchMaxVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_cutoutSpeed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Drags>.NativeClassPtr));

		public unsafe AudioSource hardDragAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardDragAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardDragAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe AudioSource softDragAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_softDragAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_softDragAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float minSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed)) = num;
			}
		}

		public unsafe float maxSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
			}
		}

		public unsafe float minPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPitch)) = num;
			}
		}

		public unsafe float maxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPitch)) = num;
			}
		}

		public unsafe float minVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVolume)) = num;
			}
		}

		public unsafe float maxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolume)) = num;
			}
		}

		public unsafe AudioClip scratchAudioClip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchAudioClip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchAudioClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float scratchRandomThreshold
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchRandomThreshold);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchRandomThreshold)) = num;
			}
		}

		public unsafe float scratchMinSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinSpeed)) = num;
			}
		}

		public unsafe float scratchMinInterval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinInterval);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinInterval)) = num;
			}
		}

		public unsafe float scratchMinPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinPitch)) = num;
			}
		}

		public unsafe float scratchMaxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMaxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMaxPitch)) = num;
			}
		}

		public unsafe float scratchMinVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMinVolume)) = num;
			}
		}

		public unsafe float scratchMaxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMaxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scratchMaxVolume)) = num;
			}
		}

		public unsafe float cutoutSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutoutSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutoutSpeed)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe Drags()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Drags>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Drags()
		{
			Il2CppClassPointerStore<Drags>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "Drags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Drags>.NativeClassPtr);
			NativeFieldInfoPtr_hardDragAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "hardDragAudioSource");
			NativeFieldInfoPtr_softDragAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "softDragAudioSource");
			NativeFieldInfoPtr_minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "minSpeed");
			NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "maxSpeed");
			NativeFieldInfoPtr_minPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "minPitch");
			NativeFieldInfoPtr_maxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "maxPitch");
			NativeFieldInfoPtr_minVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "minVolume");
			NativeFieldInfoPtr_maxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "maxVolume");
			NativeFieldInfoPtr_scratchAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchAudioClip");
			NativeFieldInfoPtr_scratchRandomThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchRandomThreshold");
			NativeFieldInfoPtr_scratchMinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchMinSpeed");
			NativeFieldInfoPtr_scratchMinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchMinInterval");
			NativeFieldInfoPtr_scratchMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchMinPitch");
			NativeFieldInfoPtr_scratchMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchMaxPitch");
			NativeFieldInfoPtr_scratchMinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchMinVolume");
			NativeFieldInfoPtr_scratchMaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "scratchMaxVolume");
			NativeFieldInfoPtr_cutoutSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Drags>.NativeClassPtr, "cutoutSpeed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Drags>.NativeClassPtr, 100670549);
		}

		public Drags(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class Wind : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_windAudioSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_minPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxPitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxVolume;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Wind>.NativeClassPtr));

		public unsafe AudioSource windAudioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windAudioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float minSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpeed)) = num;
			}
		}

		public unsafe float maxSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
			}
		}

		public unsafe float minPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minPitch)) = num;
			}
		}

		public unsafe float maxPitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPitch)) = num;
			}
		}

		public unsafe float maxVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVolume)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe Wind()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wind>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Wind()
		{
			Il2CppClassPointerStore<Wind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "Wind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wind>.NativeClassPtr);
			NativeFieldInfoPtr_windAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wind>.NativeClassPtr, "windAudioSource");
			NativeFieldInfoPtr_minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wind>.NativeClassPtr, "minSpeed");
			NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wind>.NativeClassPtr, "maxSpeed");
			NativeFieldInfoPtr_minPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wind>.NativeClassPtr, "minPitch");
			NativeFieldInfoPtr_maxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wind>.NativeClassPtr, "maxPitch");
			NativeFieldInfoPtr_maxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wind>.NativeClassPtr, "maxVolume");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wind>.NativeClassPtr, 100670550);
		}

		public Wind(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class WheelAudioData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lastDownforce;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastWheelBumpTime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr));

		public unsafe float lastDownforce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDownforce);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDownforce)) = num;
			}
		}

		public unsafe float lastWheelBumpTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWheelBumpTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastWheelBumpTime)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe WheelAudioData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static WheelAudioData()
		{
			Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "WheelAudioData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr);
			NativeFieldInfoPtr_lastDownforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr, "lastDownforce");
			NativeFieldInfoPtr_lastWheelBumpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr, "lastWheelBumpTime");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelAudioData>.NativeClassPtr, 100670551);
		}

		public WheelAudioData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_audioClipTemplate;

	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineExtras;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheels;

	private static readonly System.IntPtr NativeFieldInfoPtr_impacts;

	private static readonly System.IntPtr NativeFieldInfoPtr_drags;

	private static readonly System.IntPtr NativeFieldInfoPtr_wind;

	private static readonly System.IntPtr NativeFieldInfoPtr_simulatedGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engineRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engineLoadRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevEngineLimiter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engineLimiterActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engineLimiterTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_skidRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_offroadSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastScratchTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_turboRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_audioData;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnterPause_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLeavePause_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessEngineAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessInterpolatedEngineAudio_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrcessEngineExtraAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTireAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessWheelBumpAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessWindAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessImpactsAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessBodyDragAudio_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayContinuousAudio_Private_Void_AudioSource_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayContinuousAudio_Private_Void_AudioSource_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustVolumeWithRatio_Private_Void_AudioSource_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySpeedBasedAudio_Private_Void_AudioSource_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopAudio_Private_Void_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayWheelBumpAudio_Private_Void_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOneTime_Private_Void_AudioClip_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOneTime_Private_Void_AudioClip_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr));

	public unsafe AudioSource audioClipTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClipTemplate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClipTemplate), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Engine engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Engine(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe EngineExtras engineExtras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineExtras);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EngineExtras(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineExtras), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Wheels wheels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Wheels(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Impacts impacts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impacts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Impacts(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impacts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Drags drags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Drags(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drags), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Wind wind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wind);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Wind(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wind), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int simulatedGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulatedGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulatedGear)) = num;
		}
	}

	public unsafe int lastGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGear)) = num;
		}
	}

	public unsafe InterpolatedFloat m_engineRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineRpm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineRpm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat m_engineLoadRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineLoadRatio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineLoadRatio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_prevEngineLimiter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevEngineLimiter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevEngineLimiter)) = flag;
		}
	}

	public unsafe bool m_engineLimiterActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineLimiterActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineLimiterActive)) = flag;
		}
	}

	public unsafe float m_engineLimiterTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineLimiterTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineLimiterTime)) = num;
		}
	}

	public unsafe float m_skidRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_skidRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_skidRatio)) = num;
		}
	}

	public unsafe float m_offroadSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_offroadSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_offroadSpeed)) = num;
		}
	}

	public unsafe float m_lastScratchTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastScratchTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastScratchTime)) = num;
		}
	}

	public unsafe float m_turboRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_turboRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_turboRatio)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<WheelAudioData> m_audioData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_audioData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WheelAudioData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_audioData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114769, XrefRangeEnd = 114789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114789, XrefRangeEnd = 114806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114806, XrefRangeEnd = 114816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114816, XrefRangeEnd = 114818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114818, XrefRangeEnd = 114833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnterPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnterPause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114833, XrefRangeEnd = 114840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnLeavePause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnLeavePause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114856, RefRangeEnd = 114857, XrefRangeStart = 114840, XrefRangeEnd = 114856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessEngineAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessEngineAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114879, RefRangeEnd = 114880, XrefRangeStart = 114857, XrefRangeEnd = 114879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessInterpolatedEngineAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessInterpolatedEngineAudio_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114880, XrefRangeEnd = 114881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrcessEngineExtraAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrcessEngineExtraAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114893, RefRangeEnd = 114894, XrefRangeStart = 114881, XrefRangeEnd = 114893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessTireAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessTireAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114912, RefRangeEnd = 114913, XrefRangeStart = 114894, XrefRangeEnd = 114912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessWheelBumpAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessWheelBumpAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114913, XrefRangeEnd = 114917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessWindAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessWindAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114917, XrefRangeEnd = 114976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessImpactsAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessImpactsAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115001, RefRangeEnd = 115002, XrefRangeStart = 114976, XrefRangeEnd = 115001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessBodyDragAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessBodyDragAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115021, RefRangeEnd = 115023, XrefRangeStart = 115002, XrefRangeEnd = 115021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayContinuousAudio(AudioSource audio, float baseValue, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseValue;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayContinuousAudio_Private_Void_AudioSource_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 115046, RefRangeEnd = 115051, XrefRangeStart = 115023, XrefRangeEnd = 115046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayContinuousAudio(AudioSource audio, float ratio, float minPitch, float maxPitch, float minVolume, float maxVolume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minPitch;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxPitch;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minVolume;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxVolume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayContinuousAudio_Private_Void_AudioSource_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void AdjustVolumeWithRatio(AudioSource audio, float minVolume, float maxVolume, float ratio, float changeRateUp, float changeRateDown)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minVolume;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxVolume;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratio;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeRateUp;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeRateDown;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustVolumeWithRatio_Private_Void_AudioSource_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115082, RefRangeEnd = 115085, XrefRangeStart = 115051, XrefRangeEnd = 115082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySpeedBasedAudio(AudioSource audio, float speed, float cutoutSpeed, float minSpeed, float maxSpeed, float cutoutPitch, float minPitch, float maxPitch, float minVolume, float maxVolume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cutoutSpeed;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minSpeed;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSpeed;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cutoutPitch;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &minPitch;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxPitch;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &minVolume;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxVolume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySpeedBasedAudio_Private_Void_AudioSource_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 115099, RefRangeEnd = 115115, XrefRangeStart = 115085, XrefRangeEnd = 115099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopAudio(AudioSource audio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopAudio_Private_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115118, RefRangeEnd = 115119, XrefRangeStart = 115115, XrefRangeEnd = 115118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayWheelBumpAudio(float suspensionForceDelta, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&suspensionForceDelta);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayWheelBumpAudio_Private_Void_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115119, XrefRangeEnd = 115120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayOneTime(AudioClip clip, Vector3 position, float volume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOneTime_Private_Void_AudioClip_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115198, RefRangeEnd = 115202, XrefRangeStart = 115120, XrefRangeEnd = 115198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayOneTime(AudioClip clip, Vector3 position, float volume, float pitch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pitch;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOneTime_Private_Void_AudioClip_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115202, XrefRangeEnd = 115231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPAudio2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPAudio2()
	{
		Il2CppClassPointerStore<VPAudio2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPAudio2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr);
		NativeFieldInfoPtr_audioClipTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "audioClipTemplate");
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_engineExtras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "engineExtras");
		NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "wheels");
		NativeFieldInfoPtr_impacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "impacts");
		NativeFieldInfoPtr_drags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "drags");
		NativeFieldInfoPtr_wind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "wind");
		NativeFieldInfoPtr_simulatedGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "simulatedGear");
		NativeFieldInfoPtr_lastGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "lastGear");
		NativeFieldInfoPtr_m_engineRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_engineRpm");
		NativeFieldInfoPtr_m_engineLoadRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_engineLoadRatio");
		NativeFieldInfoPtr_m_prevEngineLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_prevEngineLimiter");
		NativeFieldInfoPtr_m_engineLimiterActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_engineLimiterActive");
		NativeFieldInfoPtr_m_engineLimiterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_engineLimiterTime");
		NativeFieldInfoPtr_m_skidRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_skidRatio");
		NativeFieldInfoPtr_m_offroadSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_offroadSpeed");
		NativeFieldInfoPtr_m_lastScratchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_lastScratchTime");
		NativeFieldInfoPtr_m_turboRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_turboRatio");
		NativeFieldInfoPtr_m_audioData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, "m_audioData");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670522);
		NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670523);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670524);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670525);
		NativeMethodInfoPtr_OnEnterPause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670526);
		NativeMethodInfoPtr_OnLeavePause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670527);
		NativeMethodInfoPtr_ProcessEngineAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670528);
		NativeMethodInfoPtr_ProcessInterpolatedEngineAudio_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670529);
		NativeMethodInfoPtr_PrcessEngineExtraAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670530);
		NativeMethodInfoPtr_ProcessTireAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670531);
		NativeMethodInfoPtr_ProcessWheelBumpAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670532);
		NativeMethodInfoPtr_ProcessWindAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670533);
		NativeMethodInfoPtr_ProcessImpactsAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670534);
		NativeMethodInfoPtr_ProcessBodyDragAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670535);
		NativeMethodInfoPtr_PlayContinuousAudio_Private_Void_AudioSource_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670536);
		NativeMethodInfoPtr_PlayContinuousAudio_Private_Void_AudioSource_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670537);
		NativeMethodInfoPtr_AdjustVolumeWithRatio_Private_Void_AudioSource_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670538);
		NativeMethodInfoPtr_PlaySpeedBasedAudio_Private_Void_AudioSource_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670539);
		NativeMethodInfoPtr_StopAudio_Private_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670540);
		NativeMethodInfoPtr_PlayWheelBumpAudio_Private_Void_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670541);
		NativeMethodInfoPtr_PlayOneTime_Private_Void_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670542);
		NativeMethodInfoPtr_PlayOneTime_Private_Void_AudioClip_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670543);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAudio2>.NativeClassPtr, 100670544);
	}

	public VPAudio2(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
