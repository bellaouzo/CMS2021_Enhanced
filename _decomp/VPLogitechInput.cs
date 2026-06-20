using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPLogitechInput : MonoBehaviour
{
	public enum G27Buttons
	{
		PaddleShifterLeft = 5,
		PaddleShifterRight = 4,
		WheelButtonLeft1 = 7,
		WheelButtonLeft2 = 20,
		WheelButtonLeft3 = 22,
		WheelButtonRight1 = 6,
		WheelButtonRight2 = 19,
		WheelButtonRight3 = 21,
		ShifterButtonUp = 15,
		ShifterButtonDown = 17,
		ShifterButtonLeft = 16,
		ShifterButtonRight = 18,
		ShifterButton1 = 0,
		ShifterButton2 = 1,
		ShifterButton3 = 2,
		ShifterButton4 = 3,
		ShifterDpadNorth = 100,
		ShifterDpadSouth = 101,
		ShifterDpadEast = 102,
		ShifterDpadWest = 103,
		ShifterDpadAnyNorth = 104,
		ShifterDpadAnySouth = 105,
		ShifterDpadAnyEast = 106,
		ShifterDpadAnyWest = 107,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G27Buttons>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static G27Buttons()
		{
			Il2CppClassPointerStore<G27Buttons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "G27Buttons");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_digitalHandbrakeRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringNonLinearBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearShiftDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_automaticGearPrev;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionKeyOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeLockToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_logicalTireWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_weightIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonLinearBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_damperCoefficient;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugGizmos;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableTestEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_force;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableSpring;

	private static readonly System.IntPtr NativeFieldInfoPtr_springCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_springSaturation;

	private static readonly System.IntPtr NativeFieldInfoPtr_springSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDamper;

	private static readonly System.IntPtr NativeFieldInfoPtr_damperSlope;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr));

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

	public unsafe float steeringNonLinearBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringNonLinearBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringNonLinearBias)) = num;
		}
	}

	public unsafe G27Buttons gearShiftUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftUp);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftUp)) = g27Buttons;
		}
	}

	public unsafe G27Buttons gearShiftDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftDown);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearShiftDown)) = g27Buttons;
		}
	}

	public unsafe G27Buttons automaticGearNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearNext);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearNext)) = g27Buttons;
		}
	}

	public unsafe G27Buttons automaticGearPrev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPrev);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_automaticGearPrev)) = g27Buttons;
		}
	}

	public unsafe G27Buttons ignitionKeyOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOn);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOn)) = g27Buttons;
		}
	}

	public unsafe G27Buttons ignitionKeyOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOff);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionKeyOff)) = g27Buttons;
		}
	}

	public unsafe G27Buttons handbrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrake);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrake)) = g27Buttons;
		}
	}

	public unsafe G27Buttons brakeLockToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLockToggle);
			return *(G27Buttons*)num;
		}
		set
		{
			*(G27Buttons*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLockToggle)) = g27Buttons;
		}
	}

	public unsafe float logicalTireWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalTireWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logicalTireWidth)) = num;
		}
	}

	public unsafe float forceIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIntensity)) = num;
		}
	}

	public unsafe float weightIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightIntensity)) = num;
		}
	}

	public unsafe float nonLinearBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonLinearBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonLinearBias)) = num;
		}
	}

	public unsafe float damperCoefficient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperCoefficient);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperCoefficient)) = num;
		}
	}

	public unsafe bool debugLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLog);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLog)) = flag;
		}
	}

	public unsafe bool debugGizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugGizmos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugGizmos)) = flag;
		}
	}

	public unsafe bool enableTestEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTestEffects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTestEffects)) = flag;
		}
	}

	public unsafe bool enableForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableForce)) = flag;
		}
	}

	public unsafe int force
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force)) = num;
		}
	}

	public unsafe bool enableSpring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSpring);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSpring)) = flag;
		}
	}

	public unsafe int springCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springCenter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springCenter)) = num;
		}
	}

	public unsafe int springSaturation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSaturation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSaturation)) = num;
		}
	}

	public unsafe int springSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSlope);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springSlope)) = num;
		}
	}

	public unsafe bool enableDamper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDamper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDamper)) = flag;
		}
	}

	public unsafe int damperSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperSlope);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperSlope)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109993, XrefRangeEnd = 109996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPLogitechInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPLogitechInput()
	{
		Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPLogitechInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr);
		NativeFieldInfoPtr_digitalHandbrakeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "digitalHandbrakeRate");
		NativeFieldInfoPtr_steeringNonLinearBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "steeringNonLinearBias");
		NativeFieldInfoPtr_gearShiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "gearShiftUp");
		NativeFieldInfoPtr_gearShiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "gearShiftDown");
		NativeFieldInfoPtr_automaticGearNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "automaticGearNext");
		NativeFieldInfoPtr_automaticGearPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "automaticGearPrev");
		NativeFieldInfoPtr_ignitionKeyOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "ignitionKeyOn");
		NativeFieldInfoPtr_ignitionKeyOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "ignitionKeyOff");
		NativeFieldInfoPtr_handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "handbrake");
		NativeFieldInfoPtr_brakeLockToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "brakeLockToggle");
		NativeFieldInfoPtr_logicalTireWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "logicalTireWidth");
		NativeFieldInfoPtr_forceIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "forceIntensity");
		NativeFieldInfoPtr_weightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "weightIntensity");
		NativeFieldInfoPtr_nonLinearBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "nonLinearBias");
		NativeFieldInfoPtr_damperCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "damperCoefficient");
		NativeFieldInfoPtr_debugLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "debugLog");
		NativeFieldInfoPtr_debugGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "debugGizmos");
		NativeFieldInfoPtr_enableTestEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "enableTestEffects");
		NativeFieldInfoPtr_enableForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "enableForce");
		NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "force");
		NativeFieldInfoPtr_enableSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "enableSpring");
		NativeFieldInfoPtr_springCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "springCenter");
		NativeFieldInfoPtr_springSaturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "springSaturation");
		NativeFieldInfoPtr_springSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "springSlope");
		NativeFieldInfoPtr_enableDamper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "enableDamper");
		NativeFieldInfoPtr_damperSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, "damperSlope");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLogitechInput>.NativeClassPtr, 100670252);
	}

	public VPLogitechInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
