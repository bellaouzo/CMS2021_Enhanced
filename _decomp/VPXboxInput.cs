using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPXboxInput : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_device;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringNonlinearity;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringDeadZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_digitalHandbrakeRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearPrev;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ignitionKeyReleased;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_handbrakeInput;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Private_Boolean_XboxButtons_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Private_Boolean_XboxButtons_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr));

	public unsafe XboxDevice device
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device);
			return *(XboxDevice*)num;
		}
		set
		{
			*(XboxDevice*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device)) = xboxDevice;
		}
	}

	public unsafe float steeringNonlinearity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringNonlinearity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringNonlinearity)) = num;
		}
	}

	public unsafe float steeringDeadZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringDeadZone);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringDeadZone)) = num;
		}
	}

	public unsafe float digitalHandbrakeRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digitalHandbrakeRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digitalHandbrakeRate)) = num;
		}
	}

	public unsafe XboxButtons gearShiftUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftUp);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftUp)) = xboxButtons;
		}
	}

	public unsafe XboxButtons gearShiftDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftDown);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftDown)) = xboxButtons;
		}
	}

	public unsafe XboxButtons automaticGearNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearNext);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearNext)) = xboxButtons;
		}
	}

	public unsafe XboxButtons automaticGearPrev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPrev);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPrev)) = xboxButtons;
		}
	}

	public unsafe XboxButtons ignitionKeyOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOn);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOn)) = xboxButtons;
		}
	}

	public unsafe XboxButtons ignitionKeyOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOff);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOff)) = xboxButtons;
		}
	}

	public unsafe XboxButtons handbrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrake);
			return *(XboxButtons*)num;
		}
		set
		{
			*(XboxButtons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrake)) = xboxButtons;
		}
	}

	public unsafe bool debugInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugInfo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugInfo)) = flag;
		}
	}

	public unsafe XINPUT_STATE m_state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state);
			return *(XINPUT_STATE*)num;
		}
		set
		{
			*(XINPUT_STATE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state)) = xINPUT_STATE;
		}
	}

	public unsafe XINPUT_STATE m_prevState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevState);
			return *(XINPUT_STATE*)num;
		}
		set
		{
			*(XINPUT_STATE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevState)) = xINPUT_STATE;
		}
	}

	public unsafe bool m_ignitionKeyReleased
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ignitionKeyReleased);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ignitionKeyReleased)) = flag;
		}
	}

	public unsafe float m_handbrakeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handbrakeInput)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111772, XrefRangeEnd = 111783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111783, XrefRangeEnd = 111801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool GetButton(XboxButtons button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButton_Private_Boolean_XboxButtons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetButtonDown(XboxButtons button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Private_Boolean_XboxButtons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111801, XrefRangeEnd = 111804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPXboxInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPXboxInput()
	{
		Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPXboxInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr);
		NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "device");
		NativeFieldInfoPtr_steeringNonlinearity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "steeringNonlinearity");
		NativeFieldInfoPtr_steeringDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "steeringDeadZone");
		NativeFieldInfoPtr_digitalHandbrakeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "digitalHandbrakeRate");
		NativeFieldInfoPtr_gearShiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "gearShiftUp");
		NativeFieldInfoPtr_gearShiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "gearShiftDown");
		NativeFieldInfoPtr_automaticGearNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "automaticGearNext");
		NativeFieldInfoPtr_automaticGearPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "automaticGearPrev");
		NativeFieldInfoPtr_ignitionKeyOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "ignitionKeyOn");
		NativeFieldInfoPtr_ignitionKeyOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "ignitionKeyOff");
		NativeFieldInfoPtr_handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "handbrake");
		NativeFieldInfoPtr_debugInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "debugInfo");
		NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "m_state");
		NativeFieldInfoPtr_m_prevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "m_prevState");
		NativeFieldInfoPtr_m_ignitionKeyReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "m_ignitionKeyReleased");
		NativeFieldInfoPtr_m_handbrakeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, "m_handbrakeInput");
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, 100670361);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, 100670362);
		NativeMethodInfoPtr_GetButton_Private_Boolean_XboxButtons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, 100670363);
		NativeMethodInfoPtr_GetButtonDown_Private_Boolean_XboxButtons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, 100670364);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPXboxInput>.NativeClassPtr, 100670365);
	}

	public VPXboxInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
