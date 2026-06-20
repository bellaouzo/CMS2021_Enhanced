using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class AbsDiagnosticsChart : PerformanceChart
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brakePedal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_brakeTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelSpin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_longitudinalG;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_slip;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_monitoredWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maxBrakeTorque;

	private static readonly System.IntPtr NativeMethodInfoPtr_Title_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetView_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupChannels_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordData_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr));

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

	public unsafe DataLogger.Channel m_brakePedal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakePedal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakePedal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_brakeTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakeTorque);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_brakeTorque), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_wheelSpin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelSpin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelSpin), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_longitudinalG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_longitudinalG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_longitudinalG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.Channel m_slip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_slip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.Channel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_slip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_monitoredWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_monitoredWheel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_monitoredWheel)) = num;
		}
	}

	public unsafe float m_maxBrakeTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxBrakeTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxBrakeTorque)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126640, XrefRangeEnd = 126642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void ResetView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ResetView_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126642, XrefRangeEnd = 126682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetupChannels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupChannels_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126682, XrefRangeEnd = 126688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RecordData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RecordData_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126688, XrefRangeEnd = 126691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AbsDiagnosticsChart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AbsDiagnosticsChart()
	{
		Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "AbsDiagnosticsChart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr);
		NativeFieldInfoPtr_m_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_speed");
		NativeFieldInfoPtr_m_brakePedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_brakePedal");
		NativeFieldInfoPtr_m_brakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_brakeTorque");
		NativeFieldInfoPtr_m_wheelSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_wheelSpin");
		NativeFieldInfoPtr_m_longitudinalG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_longitudinalG");
		NativeFieldInfoPtr_m_slip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_slip");
		NativeFieldInfoPtr_m_monitoredWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_monitoredWheel");
		NativeFieldInfoPtr_m_maxBrakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, "m_maxBrakeTorque");
		NativeMethodInfoPtr_Title_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, 100671794);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, 100671795);
		NativeMethodInfoPtr_ResetView_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, 100671796);
		NativeMethodInfoPtr_SetupChannels_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, 100671797);
		NativeMethodInfoPtr_RecordData_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, 100671798);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsDiagnosticsChart>.NativeClassPtr, 100671799);
	}

	public AbsDiagnosticsChart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
