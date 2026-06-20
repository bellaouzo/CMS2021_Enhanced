using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPVisualEffects : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_steeringWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_degreesOfRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeLightsGlow;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeLightsOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_reverseLightsGlow;

	private static readonly System.IntPtr NativeFieldInfoPtr_reverseLightsOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_headLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_headLightsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_headLightsToggleKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMaxKph;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_dashboardOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_dashboardOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_stalledLightsOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_stalledLightsOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeLightsOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeLightsOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steerInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_speedMs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_engineRpm;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameObjectsActive_Private_Void_ArrayOf_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr));

	public unsafe Transform steeringWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringWheel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringWheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float degreesOfRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_degreesOfRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_degreesOfRotation)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> brakeLightsGlow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLightsGlow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLightsGlow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> brakeLightsOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLightsOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeLightsOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> reverseLightsGlow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseLightsGlow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseLightsGlow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> reverseLightsOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseLightsOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverseLightsOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> headLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLights), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool headLightsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLightsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLightsEnabled)) = flag;
		}
	}

	public unsafe KeyCode headLightsToggleKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLightsToggleKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLightsToggleKey)) = keyCode;
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

	public unsafe float speedMaxKph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxKph);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxKph)) = num;
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

	public unsafe Il2CppReferenceArray<GameObject> dashboardOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dashboardOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dashboardOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> dashboardOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dashboardOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dashboardOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stalledLightsOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stalledLightsOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stalledLightsOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stalledLightsOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stalledLightsOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stalledLightsOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject handbrakeLightsOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeLightsOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeLightsOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject handbrakeLightsOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeLightsOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbrakeLightsOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat m_steerInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat m_speedMs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speedMs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speedMs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat m_engineRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineRpm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_engineRpm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116202, XrefRangeEnd = 116335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 116352, RefRangeEnd = 116359, XrefRangeStart = 116335, XrefRangeEnd = 116352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameObjectsActive(Il2CppReferenceArray<GameObject> gameObjects, bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &active;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameObjectsActive_Private_Void_ArrayOf_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116359, XrefRangeEnd = 116369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPVisualEffects()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPVisualEffects()
	{
		Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPVisualEffects");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr);
		NativeFieldInfoPtr_steeringWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "steeringWheel");
		NativeFieldInfoPtr_degreesOfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "degreesOfRotation");
		NativeFieldInfoPtr_brakeLightsGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "brakeLightsGlow");
		NativeFieldInfoPtr_brakeLightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "brakeLightsOff");
		NativeFieldInfoPtr_reverseLightsGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "reverseLightsGlow");
		NativeFieldInfoPtr_reverseLightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "reverseLightsOff");
		NativeFieldInfoPtr_headLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "headLights");
		NativeFieldInfoPtr_headLightsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "headLightsEnabled");
		NativeFieldInfoPtr_headLightsToggleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "headLightsToggleKey");
		NativeFieldInfoPtr_rpmGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "rpmGauge");
		NativeFieldInfoPtr_rpmMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "rpmMax");
		NativeFieldInfoPtr_rpmMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "rpmMinAngle");
		NativeFieldInfoPtr_rpmMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "rpmMaxAngle");
		NativeFieldInfoPtr_speedGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "speedGauge");
		NativeFieldInfoPtr_speedMaxKph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "speedMaxKph");
		NativeFieldInfoPtr_speedMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "speedMinAngle");
		NativeFieldInfoPtr_speedMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "speedMaxAngle");
		NativeFieldInfoPtr_dashboardOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "dashboardOn");
		NativeFieldInfoPtr_dashboardOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "dashboardOff");
		NativeFieldInfoPtr_stalledLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "stalledLightsOn");
		NativeFieldInfoPtr_stalledLightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "stalledLightsOff");
		NativeFieldInfoPtr_handbrakeLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "handbrakeLightsOn");
		NativeFieldInfoPtr_handbrakeLightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "handbrakeLightsOff");
		NativeFieldInfoPtr_m_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "m_steerInput");
		NativeFieldInfoPtr_m_speedMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "m_speedMs");
		NativeFieldInfoPtr_m_engineRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, "m_engineRpm");
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, 100670627);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, 100670628);
		NativeMethodInfoPtr_SetGameObjectsActive_Private_Void_ArrayOf_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, 100670629);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects>.NativeClassPtr, 100670630);
	}

	public VPVisualEffects(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
