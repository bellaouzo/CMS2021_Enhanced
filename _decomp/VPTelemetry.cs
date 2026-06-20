using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPTelemetry : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_showData;

	private static readonly System.IntPtr NativeFieldInfoPtr_contactDepthAsSuspension;

	private static readonly System.IntPtr NativeFieldInfoPtr_showLoadInKg;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableHotKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_hotKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_showGizmos;

	private static readonly System.IntPtr NativeFieldInfoPtr_showLocalFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_showContactPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_showTireSlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_showTireForces;

	private static readonly System.IntPtr NativeFieldInfoPtr_showSurfaceForces;

	private static readonly System.IntPtr NativeFieldInfoPtr_useLogScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmosAtPhysicPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelConsumptionCorrection;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_smallStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bigStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bigText;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lines;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_frameNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_angularVelocity;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearStr_Private_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearModeStr_Private_String_AutomaticGear_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelTelemetryStr_Private_String_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoWheelGizmos_Private_Void_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTelemetry_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr));

	public unsafe bool showData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showData)) = flag;
		}
	}

	public unsafe bool contactDepthAsSuspension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactDepthAsSuspension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactDepthAsSuspension)) = flag;
		}
	}

	public unsafe bool showLoadInKg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showLoadInKg);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showLoadInKg)) = flag;
		}
	}

	public unsafe Vector2 screenPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPosition)) = vector;
		}
	}

	public unsafe bool enableHotKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHotKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHotKey)) = flag;
		}
	}

	public unsafe KeyCode hotKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotKey)) = keyCode;
		}
	}

	public unsafe Font font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Font(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool showGizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGizmos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGizmos)) = flag;
		}
	}

	public unsafe bool showLocalFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showLocalFrame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showLocalFrame)) = flag;
		}
	}

	public unsafe bool showContactPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showContactPoints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showContactPoints)) = flag;
		}
	}

	public unsafe bool showTireSlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTireSlip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTireSlip)) = flag;
		}
	}

	public unsafe bool showTireForces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTireForces);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTireForces)) = flag;
		}
	}

	public unsafe bool showSurfaceForces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSurfaceForces);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSurfaceForces)) = flag;
		}
	}

	public unsafe bool useLogScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLogScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLogScale)) = flag;
		}
	}

	public unsafe bool gizmosAtPhysicPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmosAtPhysicPositions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmosAtPhysicPositions)) = flag;
		}
	}

	public unsafe float fuelConsumptionCorrection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelConsumptionCorrection);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelConsumptionCorrection)) = num;
		}
	}

	public unsafe float fuelDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelDensity)) = num;
		}
	}

	public unsafe GUIStyle m_smallStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smallStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smallStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle m_bigStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string m_text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string m_bigText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigText), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int m_lines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lines);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lines)) = num;
		}
	}

	public unsafe int m_frameNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameNum)) = num;
		}
	}

	public unsafe Vector3 m_velocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_velocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_velocity)) = vector;
		}
	}

	public unsafe Vector3 m_angularVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angularVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angularVelocity)) = vector;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113630, XrefRangeEnd = 113631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113631, XrefRangeEnd = 113635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113635, XrefRangeEnd = 113648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113648, XrefRangeEnd = 113667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113667, XrefRangeEnd = 113676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 113690, RefRangeEnd = 113692, XrefRangeStart = 113676, XrefRangeEnd = 113690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113692, XrefRangeEnd = 113695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetGearStr(int gear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearStr_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113695, XrefRangeEnd = 113703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetGearModeStr(Gearbox.AutomaticGear gearMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gearMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearModeStr_Private_String_AutomaticGear_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113918, RefRangeEnd = 113919, XrefRangeStart = 113703, XrefRangeEnd = 113918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetWheelTelemetryStr(VehicleBase.WheelState wheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelTelemetryStr_Private_String_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 113989, RefRangeEnd = 113991, XrefRangeStart = 113919, XrefRangeEnd = 113989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoWheelGizmos(VehicleBase.WheelState wheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoWheelGizmos_Private_Void_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114274, RefRangeEnd = 114275, XrefRangeStart = 113991, XrefRangeEnd = 114274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoTelemetry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTelemetry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114275, XrefRangeEnd = 114276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114276, XrefRangeEnd = 114286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPTelemetry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPTelemetry()
	{
		Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPTelemetry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr);
		NativeFieldInfoPtr_showData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showData");
		NativeFieldInfoPtr_contactDepthAsSuspension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "contactDepthAsSuspension");
		NativeFieldInfoPtr_showLoadInKg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showLoadInKg");
		NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "screenPosition");
		NativeFieldInfoPtr_enableHotKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "enableHotKey");
		NativeFieldInfoPtr_hotKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "hotKey");
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "font");
		NativeFieldInfoPtr_showGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showGizmos");
		NativeFieldInfoPtr_showLocalFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showLocalFrame");
		NativeFieldInfoPtr_showContactPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showContactPoints");
		NativeFieldInfoPtr_showTireSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showTireSlip");
		NativeFieldInfoPtr_showTireForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showTireForces");
		NativeFieldInfoPtr_showSurfaceForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "showSurfaceForces");
		NativeFieldInfoPtr_useLogScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "useLogScale");
		NativeFieldInfoPtr_gizmosAtPhysicPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "gizmosAtPhysicPositions");
		NativeFieldInfoPtr_fuelConsumptionCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "fuelConsumptionCorrection");
		NativeFieldInfoPtr_fuelDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "fuelDensity");
		NativeFieldInfoPtr_m_smallStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_smallStyle");
		NativeFieldInfoPtr_m_bigStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_bigStyle");
		NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_text");
		NativeFieldInfoPtr_m_bigText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_bigText");
		NativeFieldInfoPtr_m_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_lines");
		NativeFieldInfoPtr_m_frameNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_frameNum");
		NativeFieldInfoPtr_m_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_velocity");
		NativeFieldInfoPtr_m_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, "m_angularVelocity");
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670474);
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670475);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670476);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670477);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670478);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670479);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670480);
		NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670481);
		NativeMethodInfoPtr_GetGearStr_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670482);
		NativeMethodInfoPtr_GetGearModeStr_Private_String_AutomaticGear_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670483);
		NativeMethodInfoPtr_GetWheelTelemetryStr_Private_String_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670484);
		NativeMethodInfoPtr_DoWheelGizmos_Private_Void_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670485);
		NativeMethodInfoPtr_DoTelemetry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670486);
		NativeMethodInfoPtr_DoGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670487);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTelemetry>.NativeClassPtr, 100670488);
	}

	public VPTelemetry(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
