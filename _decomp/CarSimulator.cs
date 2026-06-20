using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class CarSimulator : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalPressing;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRPM;

	private static readonly System.IntPtr NativeFieldInfoPtr_idle;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_accelerationSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_decelerationSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_accelSlider;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onPointerDownRaceButton_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onPointerUpRaceButton_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr));

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

	public unsafe float maxRPM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPM);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRPM)) = num;
		}
	}

	public unsafe float idle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idle)) = num;
		}
	}

	public unsafe float rpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpm)) = num;
		}
	}

	public unsafe float accelerationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accelerationSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accelerationSpeed)) = num;
		}
	}

	public unsafe float decelerationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decelerationSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decelerationSpeed)) = num;
		}
	}

	public unsafe Slider accelSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accelSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accelSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10588, XrefRangeEnd = 10591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void onPointerDownRaceButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onPointerDownRaceButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void onPointerUpRaceButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onPointerUpRaceButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10591, XrefRangeEnd = 10594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarSimulator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarSimulator()
	{
		Il2CppClassPointerStore<CarSimulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarSimulator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr);
		NativeFieldInfoPtr_gasPedalPressing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "gasPedalPressing");
		NativeFieldInfoPtr_maxRPM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "maxRPM");
		NativeFieldInfoPtr_idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "idle");
		NativeFieldInfoPtr_rpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "rpm");
		NativeFieldInfoPtr_accelerationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "accelerationSpeed");
		NativeFieldInfoPtr_decelerationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "decelerationSpeed");
		NativeFieldInfoPtr_accelSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, "accelSlider");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_onPointerDownRaceButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_onPointerUpRaceButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSimulator>.NativeClassPtr, 100664190);
	}

	public CarSimulator(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
