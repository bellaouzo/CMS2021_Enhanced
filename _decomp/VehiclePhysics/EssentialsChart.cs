using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class EssentialsChart : PerformanceChart
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_rpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_gear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_throttle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brake;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_clutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steering;

	private static readonly System.IntPtr NativeMethodInfoPtr_Title_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetView_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupChannels_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordData_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr));

	public unsafe DataLogger.Channel m_rpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rpm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rpm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_gear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gear);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gear), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_throttle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_throttle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_throttle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_brake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brake);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brake), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_clutch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_clutch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_clutch), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_steering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steering);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steering), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126306, XrefRangeEnd = 126308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe string Title()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Title_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126308, XrefRangeEnd = 126309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ResetView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ResetView_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126309, XrefRangeEnd = 126351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetupChannels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupChannels_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126351, XrefRangeEnd = 126373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RecordData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RecordData_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126373, XrefRangeEnd = 126376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EssentialsChart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EssentialsChart()
	{
		Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "EssentialsChart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr);
		NativeFieldInfoPtr_m_rpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_rpm");
		NativeFieldInfoPtr_m_gear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_gear");
		NativeFieldInfoPtr_m_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_speed");
		NativeFieldInfoPtr_m_throttle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_throttle");
		NativeFieldInfoPtr_m_brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_brake");
		NativeFieldInfoPtr_m_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_clutch");
		NativeFieldInfoPtr_m_steering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, "m_steering");
		NativeMethodInfoPtr_Title_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, 100671755);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, 100671756);
		NativeMethodInfoPtr_ResetView_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, 100671757);
		NativeMethodInfoPtr_SetupChannels_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, 100671758);
		NativeMethodInfoPtr_RecordData_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, 100671759);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EssentialsChart>.NativeClassPtr, 100671760);
	}

	public EssentialsChart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
