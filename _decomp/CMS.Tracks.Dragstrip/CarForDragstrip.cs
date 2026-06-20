using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Tracks.Dragstrip;

[StructLayout(LayoutKind.Sequential)]
public sealed class CarForDragstrip : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tire;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexStock;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexPerPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxTuning;

	private static readonly System.IntPtr NativeFieldInfoPtr_Engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_TuningValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillFromBasicData_Public_Void_byref_BasicCarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillForCar_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillForDevCar_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForTests_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr));

	public unsafe string CarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int ConfigVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigVersion)) = num;
		}
	}

	public unsafe string Tire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float PerformanceIndexStock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexStock);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexStock)) = num;
		}
	}

	public unsafe float PerformanceIndexMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexMax)) = num;
		}
	}

	public unsafe float PerformanceIndexPerPercent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexPerPercent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexPerPercent)) = num;
		}
	}

	public unsafe float PerformanceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndex);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndex)) = num;
		}
	}

	public unsafe float MaxTuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxTuning);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxTuning)) = num;
		}
	}

	public unsafe string Engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Engine);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Engine), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float TuningValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningValue)) = num;
		}
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 131953, RefRangeEnd = 131960, XrefRangeStart = 131921, XrefRangeEnd = 131953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillFromBasicData(ref BasicCarForDragstrip basicData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(basicData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillFromBasicData_Public_Void_byref_BasicCarForDragstrip_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 131987, RefRangeEnd = 131989, XrefRangeStart = 131960, XrefRangeEnd = 131987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillForCar(string carID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillForCar_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131989, XrefRangeEnd = 132006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillForDevCar()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillForDevCar_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132006, XrefRangeEnd = 132009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForTests()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForTests_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarForDragstrip()
	{
		Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "CarForDragstrip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr);
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_ConfigVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "ConfigVersion");
		NativeFieldInfoPtr_Tire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "Tire");
		NativeFieldInfoPtr_PerformanceIndexStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "PerformanceIndexStock");
		NativeFieldInfoPtr_PerformanceIndexMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "PerformanceIndexMax");
		NativeFieldInfoPtr_PerformanceIndexPerPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "PerformanceIndexPerPercent");
		NativeFieldInfoPtr_PerformanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "PerformanceIndex");
		NativeFieldInfoPtr_MaxTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "MaxTuning");
		NativeFieldInfoPtr_Engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "Engine");
		NativeFieldInfoPtr_TuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, "TuningValue");
		NativeMethodInfoPtr_FillFromBasicData_Public_Void_byref_BasicCarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, 100672147);
		NativeMethodInfoPtr_FillForCar_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, 100672148);
		NativeMethodInfoPtr_FillForDevCar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, 100672149);
		NativeMethodInfoPtr_PrepareForTests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, 100672150);
	}

	public CarForDragstrip(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe CarForDragstrip()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr))
	{
	}
}
