using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Parking;

public class ParkingCarPanel : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_showroomCarItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_mileage;

	private static readonly System.IntPtr NativeFieldInfoPtr_weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_measuredPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_measuredTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_powerText;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueText;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForCar_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEngine_Private_Void_NewCarData_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupMeasuredPowerAndTorque_Private_Void_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTires_Private_Void_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarVersion_Private_Void_NewCarData_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupColor_Private_Void_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr));

	public unsafe ShowroomCarItem showroomCarItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showroomCarItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ShowroomCarItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showroomCarItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text mileage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mileage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mileage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text measuredPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredPower);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredPower), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text measuredTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredTorque);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredTorque), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text tireSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text powerText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text torqueText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 192455, RefRangeEnd = 192458, XrefRangeStart = 192411, XrefRangeEnd = 192455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForCar(string carID, int saveIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForCar_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192458, XrefRangeEnd = 192471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupEngine(NewCarData carData, CarBundleLoader carBundleLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEngine_Private_Void_NewCarData_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 192525, RefRangeEnd = 192526, XrefRangeStart = 192471, XrefRangeEnd = 192525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupMeasuredPowerAndTorque(NewCarData carData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupMeasuredPowerAndTorque_Private_Void_NewCarData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192526, XrefRangeEnd = 192543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTires(NewCarData carData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTires_Private_Void_NewCarData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192543, XrefRangeEnd = 192550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCarVersion(NewCarData carData, CarBundleLoader carBundleLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarVersion_Private_Void_NewCarData_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192550, XrefRangeEnd = 192551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupColor(NewCarData carData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupColor_Private_Void_NewCarData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ParkingCarPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ParkingCarPanel()
	{
		Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Parking", "ParkingCarPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr);
		NativeFieldInfoPtr_showroomCarItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "showroomCarItem");
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_mileage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "mileage");
		NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "weight");
		NativeFieldInfoPtr_measuredPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "measuredPower");
		NativeFieldInfoPtr_measuredTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "measuredTorque");
		NativeFieldInfoPtr_tireSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "tireSize");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "version");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "color");
		NativeFieldInfoPtr_powerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "powerText");
		NativeFieldInfoPtr_torqueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, "torqueText");
		NativeMethodInfoPtr_PrepareForCar_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677580);
		NativeMethodInfoPtr_SetupEngine_Private_Void_NewCarData_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677581);
		NativeMethodInfoPtr_SetupMeasuredPowerAndTorque_Private_Void_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677582);
		NativeMethodInfoPtr_SetupTires_Private_Void_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677583);
		NativeMethodInfoPtr_SetupCarVersion_Private_Void_NewCarData_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677584);
		NativeMethodInfoPtr_SetupColor_Private_Void_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677585);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPanel>.NativeClassPtr, 100677586);
	}

	public ParkingCarPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
