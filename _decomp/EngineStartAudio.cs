using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class EngineStartAudio : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmLimiter;

	private static readonly System.IntPtr NativeFieldInfoPtr_setEngineVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_setIgnitionVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmUpDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_working;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeOfIgnition;

	private static readonly System.IntPtr NativeFieldInfoPtr_average;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_canTry;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_loop;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineDontWork;

	private static readonly System.IntPtr NativeFieldInfoPtr_justStarterWork;

	private static readonly System.IntPtr NativeFieldInfoPtr_canPlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_inertia;

	private static readonly System.IntPtr NativeFieldInfoPtr_substract;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_desireRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_cutThrottle;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineLoad;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAudio_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCanPlay_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanPlay_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRpmUpDown_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoopInigtionEngine_Private_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRpmLimiter_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ignitionOFF_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_engineOFF_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_engineStart_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_engineNotWorking_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClickStartEngine_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClickStopEngine_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrottleUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrottleDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Throttle_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ignitionOFF_b__41_0_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__engineOFF_b__42_0_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__engineOFF_b__42_1_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__engineOFF_b__42_2_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__engineStart_b__43_0_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__engineStart_b__43_1_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__engineStart_b__43_2_Private_Void_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr));

	public unsafe float currentRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRpm)) = num;
		}
	}

	public unsafe float rpmLimiter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiter)) = num;
		}
	}

	public unsafe float setEngineVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setEngineVolume);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setEngineVolume)) = num;
		}
	}

	public unsafe float setIgnitionVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setIgnitionVolume);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setIgnitionVolume)) = num;
		}
	}

	public unsafe float idleRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpm)) = num;
		}
	}

	public unsafe Vector2 rpmUpDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmUpDown);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmUpDown)) = vector;
		}
	}

	public unsafe bool working
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_working);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_working)) = flag;
		}
	}

	public unsafe CarLoader carLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int typeOfIgnition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeOfIgnition);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeOfIgnition)) = num;
		}
	}

	public unsafe float average
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_average);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_average)) = num;
		}
	}

	public unsafe AudioClip engineOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip engineOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float currentPitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPitch)) = num;
		}
	}

	public unsafe AudioSource ignitionSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool canTry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTry);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTry)) = flag;
		}
	}

	public unsafe AudioSource engineSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isReady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReady)) = flag;
		}
	}

	public unsafe int loop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop)) = num;
		}
	}

	public unsafe bool engineDontWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineDontWork);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineDontWork)) = flag;
		}
	}

	public unsafe bool justStarterWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_justStarterWork);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_justStarterWork)) = flag;
		}
	}

	public unsafe bool canPlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPlay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPlay)) = flag;
		}
	}

	public unsafe Transform rpmGauge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmGauge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmGauge), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float rpmMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMinAngle)) = num;
		}
	}

	public unsafe float rpmMaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngle)) = num;
		}
	}

	public unsafe float rpmMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMax)) = num;
		}
	}

	public unsafe Transform speedGauge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedGauge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedGauge), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float speedMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMinAngle)) = num;
		}
	}

	public unsafe float speedMaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxAngle)) = num;
		}
	}

	public unsafe float speedMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMax)) = num;
		}
	}

	public unsafe float inertia
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertia);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertia)) = num;
		}
	}

	public unsafe float substract
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substract);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substract)) = num;
		}
	}

	public unsafe int multiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplier)) = num;
		}
	}

	public unsafe float desireRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireRpm)) = num;
		}
	}

	public unsafe bool cutThrottle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutThrottle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutThrottle)) = flag;
		}
	}

	public unsafe float engineLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineLoad);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineLoad)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54853, XrefRangeEnd = 54991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAudio(CarLoader cLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAudio_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCanPlay(bool m_canPlay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m_canPlay);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCanPlay_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool GetCanPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanPlay_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetRpmUpDown(float rpmUp, float rpmDown)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rpmUp);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmDown;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRpmUpDown_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54994, RefRangeEnd = 54996, XrefRangeStart = 54991, XrefRangeEnd = 54994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoopInigtionEngine(float begin, float end)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&begin);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoopInigtionEngine_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void setRpmLimiter(float r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&r);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRpmLimiter_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55016, RefRangeEnd = 55019, XrefRangeStart = 54996, XrefRangeEnd = 55016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ignitionOFF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ignitionOFF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55055, RefRangeEnd = 55056, XrefRangeStart = 55019, XrefRangeEnd = 55055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void engineOFF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_engineOFF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55124, RefRangeEnd = 55125, XrefRangeStart = 55056, XrefRangeEnd = 55124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void engineStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_engineStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55125, XrefRangeEnd = 55129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void engineNotWorking()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_engineNotWorking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55143, RefRangeEnd = 55144, XrefRangeStart = 55129, XrefRangeEnd = 55143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClickStartEngine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClickStartEngine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55144, XrefRangeEnd = 55154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClickStopEngine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClickStopEngine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55154, XrefRangeEnd = 55156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThrottleUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrottleUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55156, XrefRangeEnd = 55158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThrottleDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrottleDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55186, RefRangeEnd = 55187, XrefRangeStart = 55158, XrefRangeEnd = 55186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Throttle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Throttle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55187, XrefRangeEnd = 55259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55259, XrefRangeEnd = 55262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EngineStartAudio()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55262, XrefRangeEnd = 55267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ignitionOFF_b__41_0(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ignitionOFF_b__41_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55267, XrefRangeEnd = 55272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _engineOFF_b__42_0(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__engineOFF_b__42_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _engineOFF_b__42_1(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__engineOFF_b__42_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _engineOFF_b__42_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__engineOFF_b__42_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _engineStart_b__43_0(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__engineStart_b__43_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _engineStart_b__43_1(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__engineStart_b__43_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _engineStart_b__43_2(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__engineStart_b__43_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EngineStartAudio()
	{
		Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EngineStartAudio");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr);
		NativeFieldInfoPtr_currentRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "currentRpm");
		NativeFieldInfoPtr_rpmLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "rpmLimiter");
		NativeFieldInfoPtr_setEngineVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "setEngineVolume");
		NativeFieldInfoPtr_setIgnitionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "setIgnitionVolume");
		NativeFieldInfoPtr_idleRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "idleRpm");
		NativeFieldInfoPtr_rpmUpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "rpmUpDown");
		NativeFieldInfoPtr_working = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "working");
		NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "carLoader");
		NativeFieldInfoPtr_typeOfIgnition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "typeOfIgnition");
		NativeFieldInfoPtr_average = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "average");
		NativeFieldInfoPtr_engineOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "engineOn");
		NativeFieldInfoPtr_engineOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "engineOff");
		NativeFieldInfoPtr_currentPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "currentPitch");
		NativeFieldInfoPtr_ignitionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "ignitionSource");
		NativeFieldInfoPtr_canTry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "canTry");
		NativeFieldInfoPtr_engineSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "engineSource");
		NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "isReady");
		NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "loop");
		NativeFieldInfoPtr_engineDontWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "engineDontWork");
		NativeFieldInfoPtr_justStarterWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "justStarterWork");
		NativeFieldInfoPtr_canPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "canPlay");
		NativeFieldInfoPtr_rpmGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "rpmGauge");
		NativeFieldInfoPtr_rpmMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "rpmMinAngle");
		NativeFieldInfoPtr_rpmMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "rpmMaxAngle");
		NativeFieldInfoPtr_rpmMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "rpmMax");
		NativeFieldInfoPtr_speedGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "speedGauge");
		NativeFieldInfoPtr_speedMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "speedMinAngle");
		NativeFieldInfoPtr_speedMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "speedMaxAngle");
		NativeFieldInfoPtr_speedMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "speedMax");
		NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "inertia");
		NativeFieldInfoPtr_substract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "substract");
		NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "multiplier");
		NativeFieldInfoPtr_desireRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "desireRpm");
		NativeFieldInfoPtr_cutThrottle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "cutThrottle");
		NativeFieldInfoPtr_engineLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, "engineLoad");
		NativeMethodInfoPtr_StartAudio_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666497);
		NativeMethodInfoPtr_SetCanPlay_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666498);
		NativeMethodInfoPtr_GetCanPlay_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666499);
		NativeMethodInfoPtr_SetRpmUpDown_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666500);
		NativeMethodInfoPtr_LoopInigtionEngine_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666501);
		NativeMethodInfoPtr_setRpmLimiter_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666502);
		NativeMethodInfoPtr_ignitionOFF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666503);
		NativeMethodInfoPtr_engineOFF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666504);
		NativeMethodInfoPtr_engineStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666505);
		NativeMethodInfoPtr_engineNotWorking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666506);
		NativeMethodInfoPtr_ClickStartEngine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666507);
		NativeMethodInfoPtr_ClickStopEngine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666508);
		NativeMethodInfoPtr_ThrottleUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666509);
		NativeMethodInfoPtr_ThrottleDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666510);
		NativeMethodInfoPtr_Throttle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666511);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666512);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666513);
		NativeMethodInfoPtr__ignitionOFF_b__41_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666514);
		NativeMethodInfoPtr__engineOFF_b__42_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666515);
		NativeMethodInfoPtr__engineOFF_b__42_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666516);
		NativeMethodInfoPtr__engineOFF_b__42_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666517);
		NativeMethodInfoPtr__engineStart_b__43_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666518);
		NativeMethodInfoPtr__engineStart_b__43_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666519);
		NativeMethodInfoPtr__engineStart_b__43_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineStartAudio>.NativeClassPtr, 100666520);
	}

	public EngineStartAudio(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
