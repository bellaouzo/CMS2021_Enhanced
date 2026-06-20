using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class MobileSetRPMToSlider : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_res_mob;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerGameobject;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitchSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitchText;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReversingCheckbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_simulated;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_carSimulator;

	private static readonly System.IntPtr NativeFieldInfoPtr__rpm;

	private static readonly System.IntPtr NativeFieldInfoPtr__pitch;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRPM_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReverseGearCheckbox_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reversing_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RPMLimit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr));

	public unsafe RealisticEngineSound_mobile res_mob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res_mob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RealisticEngineSound_mobile(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res_mob), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject controllerGameobject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerGameobject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerGameobject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider rpmSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider pitchSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitchSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitchSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text pitchText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitchText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitchText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text rpmText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle ReversingCheckbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReversingCheckbox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReversingCheckbox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool simulated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulated)) = flag;
		}
	}

	public unsafe GameObject gasPedalButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarSimulator carSimulator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carSimulator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarSimulator(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carSimulator), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _rpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rpm);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rpm)) = num;
		}
	}

	public unsafe float _pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pitch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pitch)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10639, XrefRangeEnd = 10647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10647, XrefRangeEnd = 10659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRPM()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRPM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10659, XrefRangeEnd = 10676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10676, XrefRangeEnd = 10691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReverseGearCheckbox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReverseGearCheckbox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10691, XrefRangeEnd = 10703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reversing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reversing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10703, XrefRangeEnd = 10715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RPMLimit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RPMLimit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10715, XrefRangeEnd = 10718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobileSetRPMToSlider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MobileSetRPMToSlider()
	{
		Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MobileSetRPMToSlider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr);
		NativeFieldInfoPtr_res_mob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "res_mob");
		NativeFieldInfoPtr_controllerGameobject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "controllerGameobject");
		NativeFieldInfoPtr_rpmSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "rpmSlider");
		NativeFieldInfoPtr_pitchSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "pitchSlider");
		NativeFieldInfoPtr_pitchText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "pitchText");
		NativeFieldInfoPtr_rpmText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "rpmText");
		NativeFieldInfoPtr_ReversingCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "ReversingCheckbox");
		NativeFieldInfoPtr_simulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "simulated");
		NativeFieldInfoPtr_gasPedalButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "gasPedalButton");
		NativeFieldInfoPtr_carSimulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "carSimulator");
		NativeFieldInfoPtr__rpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "_rpm");
		NativeFieldInfoPtr__pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, "_pitch");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_SetRPM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr_ReverseGearCheckbox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_Reversing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_RPMLimit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileSetRPMToSlider>.NativeClassPtr, 100664201);
	}

	public MobileSetRPMToSlider(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
