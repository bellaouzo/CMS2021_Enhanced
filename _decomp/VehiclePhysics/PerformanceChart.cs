using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class PerformanceChart : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__vehicle_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__dataLogger_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__reference_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelChartColors;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vehicle_Public_get_VehicleBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_vehicle_Public_set_Void_VehicleBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dataLogger_Public_get_DataLogger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dataLogger_Public_set_Void_DataLogger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reference_Public_get_ReferenceSpecs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reference_Public_set_Void_ReferenceSpecs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Title_Public_Virtual_New_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetView_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupChannels_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordData_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr));

	public unsafe VehicleBase _vehicle_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__vehicle_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VehicleBase(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger _dataLogger_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dataLogger_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dataLogger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ReferenceSpecs _reference_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reference_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ReferenceSpecs(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reference_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<Color> wheelChartColors
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wheelChartColors, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wheelChartColors, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VehicleBase vehicle
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vehicle_Public_get_VehicleBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new VehicleBase(intPtr) : null;
		}
		[CallerCount(77)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_vehicle_Public_set_Void_VehicleBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe DataLogger dataLogger
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dataLogger_Public_get_DataLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new DataLogger(intPtr) : null;
		}
		[CallerCount(60)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dataLogger_Public_set_Void_DataLogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ReferenceSpecs reference
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reference_Public_get_ReferenceSpecs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ReferenceSpecs(intPtr) : null;
		}
		[CallerCount(38)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reference_Public_set_Void_ReferenceSpecs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126303, XrefRangeEnd = 126305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Title()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Title_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126305, XrefRangeEnd = 126306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ResetView_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetupChannels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupChannels_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void RecordData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RecordData_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PerformanceChart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PerformanceChart()
	{
		Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "PerformanceChart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr);
		NativeFieldInfoPtr__vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, "<vehicle>k__BackingField");
		NativeFieldInfoPtr__dataLogger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, "<dataLogger>k__BackingField");
		NativeFieldInfoPtr__reference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, "<reference>k__BackingField");
		NativeFieldInfoPtr_wheelChartColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, "wheelChartColors");
		NativeMethodInfoPtr_get_vehicle_Public_get_VehicleBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671742);
		NativeMethodInfoPtr_set_vehicle_Public_set_Void_VehicleBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671743);
		NativeMethodInfoPtr_get_dataLogger_Public_get_DataLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671744);
		NativeMethodInfoPtr_set_dataLogger_Public_set_Void_DataLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671745);
		NativeMethodInfoPtr_get_reference_Public_get_ReferenceSpecs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671746);
		NativeMethodInfoPtr_set_reference_Public_set_Void_ReferenceSpecs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671747);
		NativeMethodInfoPtr_Title_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671748);
		NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671749);
		NativeMethodInfoPtr_ResetView_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671750);
		NativeMethodInfoPtr_SetupChannels_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671751);
		NativeMethodInfoPtr_RecordData_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671752);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceChart>.NativeClassPtr, 100671753);
	}

	public PerformanceChart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
