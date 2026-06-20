using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Audio;

public class RealisticEngineSound : MonoBehaviour
{
	public enum GasPedalValue
	{
		Simulated,
		NotSimulated,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GasPedalValue>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static GasPedalValue()
		{
			Il2CppClassPointerStore<GasPedalValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "GasPedalValue");
		}

	}

	public enum EngineShake
	{
		Off,
		Random,
		AllwaysOn,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineShake>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static EngineShake()
		{
			Il2CppClassPointerStore<EngineShake>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "EngineShake");
		}

	}

	public enum ShakeLenghtType
	{
		Fix,
		Random,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShakeLenghtType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ShakeLenghtType()
		{
			Il2CppClassPointerStore<ShakeLenghtType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "ShakeLenghtType");
		}

	}

	[ObfuscatedName("RealisticEngineSound/<WaitForStart>d__83")]
	public sealed class _WaitForStart_d__83 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr));

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

		public unsafe RealisticEngineSound __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new RealisticEngineSound(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _WaitForStart_d__83(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11559, XrefRangeEnd = 11560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11560, XrefRangeEnd = 11565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _WaitForStart_d__83()
		{
			Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "<WaitForStart>d__83");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, 100664294);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, 100664295);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, 100664296);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, 100664297);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, 100664298);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__83>.NativeClassPtr, 100664299);
		}

		public _WaitForStart_d__83(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_masterVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioMixer;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineCurrentRPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalPressing;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalValueSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalSimSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPMLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_dopplerLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatialBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitchMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_reverbZoneSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_reverbZoneControll;

	private static readonly System.IntPtr NativeFieldInfoPtr_optimisationLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioRolloffMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReversing;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNeutral;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShiftedFromNeutral;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRPMLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableReverseGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_carCurrentSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_carMaxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShifting;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_idlePitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowOffClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowOnClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_medOffClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_medOnClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_medVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_medPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_highOffClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_highOnClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_highVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_highPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPMClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPMVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversingClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversingVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversingPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineIdle;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_medOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_medOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_highOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_highOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversing;

	private static readonly System.IntPtr NativeFieldInfoPtr_clipsValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_clipsValue2;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCameraNear;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineShakeSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_shakeLenghtSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_shakeLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_shakeVolumeChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomChance;

	private static readonly System.IntPtr NativeFieldInfoPtr__endRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_shakeVolumeChangeDetect;

	private static readonly System.IntPtr NativeFieldInfoPtr__oscillateRange;

	private static readonly System.IntPtr NativeFieldInfoPtr__oscillateOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_lenght;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomShakingValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomShakingValue2;

	private static readonly System.IntPtr NativeFieldInfoPtr__wait;

	private static readonly System.IntPtr NativeFieldInfoPtr_alreadyDestroyed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAll_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStartRange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReverbZone_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitForStart_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateIdle_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLowOff_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLowOn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMedOff_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMedOn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHighOff_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHighOn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRPMLimit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateReverse_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr));

	public unsafe float masterVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterVolume);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterVolume)) = num;
		}
	}

	public unsafe AudioMixerGroup audioMixer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioMixer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioMixerGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioMixer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float engineCurrentRPM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineCurrentRPM);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineCurrentRPM)) = num;
		}
	}

	public unsafe bool gasPedalPressing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalPressing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalPressing)) = flag;
		}
	}

	public unsafe float gasPedalValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalValue)) = num;
		}
	}

	public unsafe GasPedalValue gasPedalValueSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalValueSetting);
			return *(GasPedalValue*)num;
		}
		set
		{
			*(GasPedalValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalValueSetting)) = gasPedalValue;
		}
	}

	public unsafe float gasPedalSimSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalSimSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalSimSpeed)) = num;
		}
	}

	public unsafe float maxRPMLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPMLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPMLimit)) = num;
		}
	}

	public unsafe float dopplerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dopplerLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dopplerLevel)) = num;
		}
	}

	public unsafe float spatialBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatialBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatialBlend)) = num;
		}
	}

	public unsafe float pitchMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitchMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitchMultiplier)) = num;
		}
	}

	public unsafe AudioReverbPreset reverbZoneSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverbZoneSetting);
			return *(AudioReverbPreset*)num;
		}
		set
		{
			*(AudioReverbPreset*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverbZoneSetting)) = audioReverbPreset;
		}
	}

	public unsafe AudioReverbPreset reverbZoneControll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverbZoneControll);
			return *(AudioReverbPreset*)num;
		}
		set
		{
			*(AudioReverbPreset*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverbZoneControll)) = audioReverbPreset;
		}
	}

	public unsafe float optimisationLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optimisationLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optimisationLevel)) = num;
		}
	}

	public unsafe AudioRolloffMode audioRolloffMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioRolloffMode);
			return *(AudioRolloffMode*)num;
		}
		set
		{
			*(AudioRolloffMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioRolloffMode)) = audioRolloffMode;
		}
	}

	public unsafe float minDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance)) = num;
		}
	}

	public unsafe float maxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance)) = num;
		}
	}

	public unsafe bool isReversing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReversing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReversing)) = flag;
		}
	}

	public unsafe bool isNeutral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNeutral);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNeutral)) = flag;
		}
	}

	public unsafe bool isShiftedFromNeutral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShiftedFromNeutral);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShiftedFromNeutral)) = flag;
		}
	}

	public unsafe bool useRPMLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRPMLimit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRPMLimit)) = flag;
		}
	}

	public unsafe bool enableReverseGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableReverseGear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableReverseGear)) = flag;
		}
	}

	public unsafe float carCurrentSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carCurrentSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carCurrentSpeed)) = num;
		}
	}

	public unsafe float carMaxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carMaxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carMaxSpeed)) = num;
		}
	}

	public unsafe bool isShifting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShifting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShifting)) = flag;
		}
	}

	public unsafe AudioClip idleClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve idleVolCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleVolCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleVolCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve idlePitchCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idlePitchCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idlePitchCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip lowOffClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOffClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOffClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip lowOnClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOnClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOnClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve lowVolCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowVolCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowVolCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve lowPitchCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowPitchCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip medOffClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOffClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOffClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip medOnClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOnClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOnClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve medVolCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medVolCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medVolCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve medPitchCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medPitchCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip highOffClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOffClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOffClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip highOnClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOnClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOnClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve highVolCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highVolCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highVolCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve highPitchCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highPitchCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip maxRPMClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPMClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPMClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve maxRPMVolCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPMVolCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPMVolCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip reversingClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversingClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversingClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve reversingVolCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversingVolCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversingVolCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AnimationCurve reversingPitchCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversingPitchCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversingPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource engineIdle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineIdle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineIdle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource lowOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource lowOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource medOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource medOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource highOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource highOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource maxRPM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPM);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPM), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource reversing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversing);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reversing), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float clipsValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipsValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipsValue)) = num;
		}
	}

	public unsafe float clipsValue2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipsValue2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipsValue2)) = num;
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

	public unsafe bool isCameraNear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCameraNear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCameraNear)) = flag;
		}
	}

	public unsafe EngineShake engineShakeSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineShakeSetting);
			return *(EngineShake*)num;
		}
		set
		{
			*(EngineShake*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineShakeSetting)) = engineShake;
		}
	}

	public unsafe ShakeLenghtType shakeLenghtSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeLenghtSetting);
			return *(ShakeLenghtType*)num;
		}
		set
		{
			*(ShakeLenghtType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeLenghtSetting)) = shakeLenghtType;
		}
	}

	public unsafe float shakeLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeLength)) = num;
		}
	}

	public unsafe float shakeVolumeChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeVolumeChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeVolumeChange)) = num;
		}
	}

	public unsafe float randomChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomChance)) = num;
		}
	}

	public unsafe float _endRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__endRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__endRange)) = num;
		}
	}

	public unsafe float shakeVolumeChangeDetect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeVolumeChangeDetect);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shakeVolumeChangeDetect)) = num;
		}
	}

	public unsafe float _oscillateRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oscillateRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oscillateRange)) = num;
		}
	}

	public unsafe float _oscillateOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oscillateOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oscillateOffset)) = num;
		}
	}

	public unsafe float lenght
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lenght);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lenght)) = num;
		}
	}

	public unsafe float randomShakingValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomShakingValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomShakingValue)) = num;
		}
	}

	public unsafe float randomShakingValue2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomShakingValue2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomShakingValue2)) = num;
		}
	}

	public unsafe WaitForSeconds _wait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new WaitForSeconds(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wait), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool alreadyDestroyed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alreadyDestroyed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alreadyDestroyed)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11565, XrefRangeEnd = 11604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11604, XrefRangeEnd = 11607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11607, XrefRangeEnd = 11620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11620, XrefRangeEnd = 11625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11625, XrefRangeEnd = 11626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11785, RefRangeEnd = 11787, XrefRangeStart = 11626, XrefRangeEnd = 11785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void UpdateStartRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateStartRange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11810, RefRangeEnd = 11811, XrefRangeStart = 11787, XrefRangeEnd = 11810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetReverbZone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReverbZone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11811, XrefRangeEnd = 11814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator WaitForStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitForStart_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11814, XrefRangeEnd = 11859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateIdle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateIdle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11859, XrefRangeEnd = 11904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateLowOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLowOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11904, XrefRangeEnd = 11949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateLowOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLowOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11949, XrefRangeEnd = 11994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMedOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMedOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11994, XrefRangeEnd = 12039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMedOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMedOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12039, XrefRangeEnd = 12084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateHighOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHighOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12084, XrefRangeEnd = 12129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateHighOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHighOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12129, XrefRangeEnd = 12174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRPMLimit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRPMLimit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12174, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateReverse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateReverse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12219, XrefRangeEnd = 12222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RealisticEngineSound()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RealisticEngineSound()
	{
		Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RealisticEngineSound");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr);
		NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "masterVolume");
		NativeFieldInfoPtr_audioMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "audioMixer");
		NativeFieldInfoPtr_engineCurrentRPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "engineCurrentRPM");
		NativeFieldInfoPtr_gasPedalPressing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "gasPedalPressing");
		NativeFieldInfoPtr_gasPedalValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "gasPedalValue");
		NativeFieldInfoPtr_gasPedalValueSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "gasPedalValueSetting");
		NativeFieldInfoPtr_gasPedalSimSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "gasPedalSimSpeed");
		NativeFieldInfoPtr_maxRPMLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "maxRPMLimit");
		NativeFieldInfoPtr_dopplerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "dopplerLevel");
		NativeFieldInfoPtr_spatialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "spatialBlend");
		NativeFieldInfoPtr_pitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "pitchMultiplier");
		NativeFieldInfoPtr_reverbZoneSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "reverbZoneSetting");
		NativeFieldInfoPtr_reverbZoneControll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "reverbZoneControll");
		NativeFieldInfoPtr_optimisationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "optimisationLevel");
		NativeFieldInfoPtr_audioRolloffMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "audioRolloffMode");
		NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "minDistance");
		NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "maxDistance");
		NativeFieldInfoPtr_isReversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "isReversing");
		NativeFieldInfoPtr_isNeutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "isNeutral");
		NativeFieldInfoPtr_isShiftedFromNeutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "isShiftedFromNeutral");
		NativeFieldInfoPtr_useRPMLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "useRPMLimit");
		NativeFieldInfoPtr_enableReverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "enableReverseGear");
		NativeFieldInfoPtr_carCurrentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "carCurrentSpeed");
		NativeFieldInfoPtr_carMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "carMaxSpeed");
		NativeFieldInfoPtr_isShifting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "isShifting");
		NativeFieldInfoPtr_idleClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "idleClip");
		NativeFieldInfoPtr_idleVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "idleVolCurve");
		NativeFieldInfoPtr_idlePitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "idlePitchCurve");
		NativeFieldInfoPtr_lowOffClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lowOffClip");
		NativeFieldInfoPtr_lowOnClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lowOnClip");
		NativeFieldInfoPtr_lowVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lowVolCurve");
		NativeFieldInfoPtr_lowPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lowPitchCurve");
		NativeFieldInfoPtr_medOffClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "medOffClip");
		NativeFieldInfoPtr_medOnClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "medOnClip");
		NativeFieldInfoPtr_medVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "medVolCurve");
		NativeFieldInfoPtr_medPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "medPitchCurve");
		NativeFieldInfoPtr_highOffClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "highOffClip");
		NativeFieldInfoPtr_highOnClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "highOnClip");
		NativeFieldInfoPtr_highVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "highVolCurve");
		NativeFieldInfoPtr_highPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "highPitchCurve");
		NativeFieldInfoPtr_maxRPMClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "maxRPMClip");
		NativeFieldInfoPtr_maxRPMVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "maxRPMVolCurve");
		NativeFieldInfoPtr_reversingClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "reversingClip");
		NativeFieldInfoPtr_reversingVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "reversingVolCurve");
		NativeFieldInfoPtr_reversingPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "reversingPitchCurve");
		NativeFieldInfoPtr_engineIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "engineIdle");
		NativeFieldInfoPtr_lowOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lowOff");
		NativeFieldInfoPtr_lowOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lowOn");
		NativeFieldInfoPtr_medOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "medOff");
		NativeFieldInfoPtr_medOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "medOn");
		NativeFieldInfoPtr_highOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "highOff");
		NativeFieldInfoPtr_highOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "highOn");
		NativeFieldInfoPtr_maxRPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "maxRPM");
		NativeFieldInfoPtr_reversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "reversing");
		NativeFieldInfoPtr_clipsValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "clipsValue");
		NativeFieldInfoPtr_clipsValue2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "clipsValue2");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_isCameraNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "isCameraNear");
		NativeFieldInfoPtr_engineShakeSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "engineShakeSetting");
		NativeFieldInfoPtr_shakeLenghtSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "shakeLenghtSetting");
		NativeFieldInfoPtr_shakeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "shakeLength");
		NativeFieldInfoPtr_shakeVolumeChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "shakeVolumeChange");
		NativeFieldInfoPtr_randomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "randomChance");
		NativeFieldInfoPtr__endRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "_endRange");
		NativeFieldInfoPtr_shakeVolumeChangeDetect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "shakeVolumeChangeDetect");
		NativeFieldInfoPtr__oscillateRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "_oscillateRange");
		NativeFieldInfoPtr__oscillateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "_oscillateOffset");
		NativeFieldInfoPtr_lenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "lenght");
		NativeFieldInfoPtr_randomShakingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "randomShakingValue");
		NativeFieldInfoPtr_randomShakingValue2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "randomShakingValue2");
		NativeFieldInfoPtr__wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "_wait");
		NativeFieldInfoPtr_alreadyDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, "alreadyDestroyed");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_DestroyAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_UpdateStartRange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_SetReverbZone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_WaitForStart_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_CreateIdle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_CreateLowOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_CreateLowOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_CreateMedOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr_CreateMedOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_CreateHighOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_CreateHighOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr_CreateRPMLimit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr_CreateReverse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound>.NativeClassPtr, 100664293);
	}

	public RealisticEngineSound(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
