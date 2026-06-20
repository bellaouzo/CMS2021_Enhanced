using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class SpeedTest : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vpVehicleConroller;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimerMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_textTopSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpeedStage1;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpeedStage2;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpeedStage3;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpeedStage4;

	private static readonly System.IntPtr NativeFieldInfoPtr_countFotStage1;

	private static readonly System.IntPtr NativeFieldInfoPtr_countFotStage2;

	private static readonly System.IntPtr NativeFieldInfoPtr_countFotStage3;

	private static readonly System.IntPtr NativeFieldInfoPtr_countFotStage4;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopwatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_topSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage1Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage2Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage3Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage4Speed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartCountTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr));

	public unsafe VPVehicleController vpVehicleConroller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpVehicleConroller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpVehicleConroller), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform TimerMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimerMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimerMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text textTopSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textTopSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textTopSpeed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text textSpeedStage1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text textSpeedStage2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text textSpeedStage3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text textSpeedStage4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage4);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeedStage4), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool countFotStage1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage1);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage1)) = flag;
		}
	}

	public unsafe bool countFotStage2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage2);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage2)) = flag;
		}
	}

	public unsafe bool countFotStage3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage3);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage3)) = flag;
		}
	}

	public unsafe bool countFotStage4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage4);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFotStage4)) = flag;
		}
	}

	public unsafe Stopwatch stopwatch
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopwatch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((Stopwatch)null) : new Stopwatch(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe float topSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topSpeed)) = num;
		}
	}

	public unsafe float stage1Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1Speed)) = num;
		}
	}

	public unsafe float stage2Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2Speed)) = num;
		}
	}

	public unsafe float stage3Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3Speed)) = num;
		}
	}

	public unsafe float stage4Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage4Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage4Speed)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41982, XrefRangeEnd = 41983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42095, RefRangeEnd = 42096, XrefRangeStart = 41983, XrefRangeEnd = 42095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42096, XrefRangeEnd = 42103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartCountTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCountTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42103, XrefRangeEnd = 42191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42191, XrefRangeEnd = 42194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpeedTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SpeedTest()
	{
		Il2CppClassPointerStore<SpeedTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SpeedTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr);
		NativeFieldInfoPtr_vpVehicleConroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "vpVehicleConroller");
		NativeFieldInfoPtr_TimerMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "TimerMenu");
		NativeFieldInfoPtr_textTopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "textTopSpeed");
		NativeFieldInfoPtr_textSpeedStage1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "textSpeedStage1");
		NativeFieldInfoPtr_textSpeedStage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "textSpeedStage2");
		NativeFieldInfoPtr_textSpeedStage3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "textSpeedStage3");
		NativeFieldInfoPtr_textSpeedStage4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "textSpeedStage4");
		NativeFieldInfoPtr_countFotStage1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "countFotStage1");
		NativeFieldInfoPtr_countFotStage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "countFotStage2");
		NativeFieldInfoPtr_countFotStage3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "countFotStage3");
		NativeFieldInfoPtr_countFotStage4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "countFotStage4");
		NativeFieldInfoPtr_stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "stopwatch");
		NativeFieldInfoPtr_topSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "topSpeed");
		NativeFieldInfoPtr_stage1Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "stage1Speed");
		NativeFieldInfoPtr_stage2Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "stage2Speed");
		NativeFieldInfoPtr_stage3Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "stage3Speed");
		NativeFieldInfoPtr_stage4Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, "stage4Speed");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, 100665794);
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, 100665795);
		NativeMethodInfoPtr_StartCountTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, 100665796);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedTest>.NativeClassPtr, 100665798);
	}

	public SpeedTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
