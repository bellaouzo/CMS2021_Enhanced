using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Audio;

public class RealisticEngineSound_mobile : MonoBehaviour
{
	[ObfuscatedName("RealisticEngineSound_mobile/<WaitForStart>d__52")]
	public sealed class _WaitForStart_d__52 : Il2CppSystem.Object
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
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr));

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

		public unsafe RealisticEngineSound_mobile __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new RealisticEngineSound_mobile(intPtr) : null;
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
		public unsafe _WaitForStart_d__52(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12222, XrefRangeEnd = 12223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12223, XrefRangeEnd = 12228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _WaitForStart_d__52()
		{
			Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "<WaitForStart>d__52");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, 100664314);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, 100664315);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, 100664316);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, 100664317);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, 100664318);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_WaitForStart_d__52>.NativeClassPtr, 100664319);
		}

		public _WaitForStart_d__52(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_masterVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioMixer;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineCurrentRPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPMLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_dopplerLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatialBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitchMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_optimisationLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioRolloffMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReversing;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRPMLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableReverseGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_carCurrentSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_carMaxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShifting;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalPressing;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_idlePitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowOnClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_medOnClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_medVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_medPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_highOnClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_highVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_highPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPMClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPMVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversingClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversingVolCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversingPitchCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineIdle;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_medOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_highOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_reversing;

	private static readonly System.IntPtr NativeFieldInfoPtr_clipsValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCameraNear;

	private static readonly System.IntPtr NativeFieldInfoPtr__wait;

	private static readonly System.IntPtr NativeFieldInfoPtr_alreadyDestroyed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAll_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitForStart_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateIdle_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLowOn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMedOn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHighOn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMaxRPM_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateReverse_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr));

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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12228, XrefRangeEnd = 12352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12352, XrefRangeEnd = 12354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12354, XrefRangeEnd = 12408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12408, XrefRangeEnd = 12412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12412, XrefRangeEnd = 12413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12504, RefRangeEnd = 12506, XrefRangeStart = 12413, XrefRangeEnd = 12504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12506, XrefRangeEnd = 12509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator WaitForStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitForStart_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12554, RefRangeEnd = 12555, XrefRangeStart = 12509, XrefRangeEnd = 12554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateIdle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateIdle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12600, RefRangeEnd = 12601, XrefRangeStart = 12555, XrefRangeEnd = 12600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateLowOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLowOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12646, RefRangeEnd = 12647, XrefRangeStart = 12601, XrefRangeEnd = 12646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMedOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMedOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12692, RefRangeEnd = 12693, XrefRangeStart = 12647, XrefRangeEnd = 12692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateHighOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHighOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12738, RefRangeEnd = 12739, XrefRangeStart = 12693, XrefRangeEnd = 12738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMaxRPM()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMaxRPM_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12739, XrefRangeEnd = 12784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateReverse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateReverse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12784, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RealisticEngineSound_mobile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RealisticEngineSound_mobile()
	{
		Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RealisticEngineSound_mobile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr);
		NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "masterVolume");
		NativeFieldInfoPtr_audioMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "audioMixer");
		NativeFieldInfoPtr_engineCurrentRPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "engineCurrentRPM");
		NativeFieldInfoPtr_maxRPMLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "maxRPMLimit");
		NativeFieldInfoPtr_dopplerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "dopplerLevel");
		NativeFieldInfoPtr_spatialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "spatialBlend");
		NativeFieldInfoPtr_pitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "pitchMultiplier");
		NativeFieldInfoPtr_optimisationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "optimisationLevel");
		NativeFieldInfoPtr_audioRolloffMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "audioRolloffMode");
		NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "minDistance");
		NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "maxDistance");
		NativeFieldInfoPtr_isReversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "isReversing");
		NativeFieldInfoPtr_useRPMLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "useRPMLimit");
		NativeFieldInfoPtr_enableReverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "enableReverseGear");
		NativeFieldInfoPtr_carCurrentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "carCurrentSpeed");
		NativeFieldInfoPtr_carMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "carMaxSpeed");
		NativeFieldInfoPtr_isShifting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "isShifting");
		NativeFieldInfoPtr_gasPedalPressing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "gasPedalPressing");
		NativeFieldInfoPtr_idleClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "idleClip");
		NativeFieldInfoPtr_idleVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "idleVolCurve");
		NativeFieldInfoPtr_idlePitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "idlePitchCurve");
		NativeFieldInfoPtr_lowOnClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "lowOnClip");
		NativeFieldInfoPtr_lowVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "lowVolCurve");
		NativeFieldInfoPtr_lowPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "lowPitchCurve");
		NativeFieldInfoPtr_medOnClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "medOnClip");
		NativeFieldInfoPtr_medVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "medVolCurve");
		NativeFieldInfoPtr_medPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "medPitchCurve");
		NativeFieldInfoPtr_highOnClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "highOnClip");
		NativeFieldInfoPtr_highVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "highVolCurve");
		NativeFieldInfoPtr_highPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "highPitchCurve");
		NativeFieldInfoPtr_maxRPMClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "maxRPMClip");
		NativeFieldInfoPtr_maxRPMVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "maxRPMVolCurve");
		NativeFieldInfoPtr_reversingClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "reversingClip");
		NativeFieldInfoPtr_reversingVolCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "reversingVolCurve");
		NativeFieldInfoPtr_reversingPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "reversingPitchCurve");
		NativeFieldInfoPtr_engineIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "engineIdle");
		NativeFieldInfoPtr_lowOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "lowOn");
		NativeFieldInfoPtr_medOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "medOn");
		NativeFieldInfoPtr_highOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "highOn");
		NativeFieldInfoPtr_maxRPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "maxRPM");
		NativeFieldInfoPtr_reversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "reversing");
		NativeFieldInfoPtr_clipsValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "clipsValue");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_isCameraNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "isCameraNear");
		NativeFieldInfoPtr__wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "_wait");
		NativeFieldInfoPtr_alreadyDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, "alreadyDestroyed");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664304);
		NativeMethodInfoPtr_DestroyAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664305);
		NativeMethodInfoPtr_WaitForStart_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_CreateIdle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_CreateLowOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664308);
		NativeMethodInfoPtr_CreateMedOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_CreateHighOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_CreateMaxRPM_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr_CreateReverse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664312);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealisticEngineSound_mobile>.NativeClassPtr, 100664313);
	}

	public RealisticEngineSound_mobile(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
