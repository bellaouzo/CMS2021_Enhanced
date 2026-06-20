using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class SetRPMToSlider : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_res;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerGameobject;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitchSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitchText;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReversingCheckbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalCheckbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_simulated;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_carSimulator;

	private static readonly System.IntPtr NativeFieldInfoPtr__rpm;

	private static readonly System.IntPtr NativeFieldInfoPtr__pitch;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GasPedalCheckbox_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReverseGearCheckbox_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reversing_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RPMLimit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr));

	public unsafe RealisticEngineSound res
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RealisticEngineSound(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Toggle gasPedalCheckbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalCheckbox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalCheckbox), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10718, XrefRangeEnd = 10726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10726, XrefRangeEnd = 10744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10744, XrefRangeEnd = 10756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GasPedalCheckbox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GasPedalCheckbox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10756, XrefRangeEnd = 10771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReverseGearCheckbox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReverseGearCheckbox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10771, XrefRangeEnd = 10783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reversing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reversing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10783, XrefRangeEnd = 10795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RPMLimit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RPMLimit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10795, XrefRangeEnd = 10798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SetRPMToSlider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SetRPMToSlider()
	{
		Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SetRPMToSlider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr);
		NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "res");
		NativeFieldInfoPtr_controllerGameobject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "controllerGameobject");
		NativeFieldInfoPtr_rpmSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "rpmSlider");
		NativeFieldInfoPtr_pitchSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "pitchSlider");
		NativeFieldInfoPtr_pitchText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "pitchText");
		NativeFieldInfoPtr_rpmText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "rpmText");
		NativeFieldInfoPtr_ReversingCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "ReversingCheckbox");
		NativeFieldInfoPtr_gasPedalCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "gasPedalCheckbox");
		NativeFieldInfoPtr_simulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "simulated");
		NativeFieldInfoPtr_gasPedalButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "gasPedalButton");
		NativeFieldInfoPtr_carSimulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "carSimulator");
		NativeFieldInfoPtr__rpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "_rpm");
		NativeFieldInfoPtr__pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, "_pitch");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_GasPedalCheckbox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_ReverseGearCheckbox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_Reversing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_RPMLimit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRPMToSlider>.NativeClassPtr, 100664208);
	}

	public SetRPMToSlider(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
