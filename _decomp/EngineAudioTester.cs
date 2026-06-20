using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class EngineAudioTester : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_desireRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmLimiter;

	private static readonly System.IntPtr NativeFieldInfoPtr_setEngineVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmUpDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineSourceOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineSourceOff;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr));

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

	public unsafe AudioSource engineSourceOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSourceOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSourceOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource engineSourceOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSourceOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSourceOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84885, XrefRangeEnd = 84894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84894, XrefRangeEnd = 84929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe EngineAudioTester()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EngineAudioTester()
	{
		Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EngineAudioTester");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr);
		NativeFieldInfoPtr_desireRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "desireRpm");
		NativeFieldInfoPtr_engineLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "engineLoad");
		NativeFieldInfoPtr_currentRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "currentRpm");
		NativeFieldInfoPtr_rpmLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "rpmLimiter");
		NativeFieldInfoPtr_setEngineVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "setEngineVolume");
		NativeFieldInfoPtr_rpmUpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "rpmUpDown");
		NativeFieldInfoPtr_engineSourceOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "engineSourceOn");
		NativeFieldInfoPtr_engineSourceOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, "engineSourceOff");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, 100668142);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, 100668143);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineAudioTester>.NativeClassPtr, 100668144);
	}

	public EngineAudioTester(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
