using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class NewCarData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_UId;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_factoryColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_factoryPaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_customerCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderConnection;

	private static readonly System.IntPtr NativeFieldInfoPtr_TooolsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_FluidsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineSwap;

	private static readonly System.IntPtr NativeFieldInfoPtr_BodyPartsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartData;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiresET;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelsWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_rimsSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiresSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_configVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlatesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineData;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalDriveRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarInfoData;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeadlampLeftAlignmentData;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeadlampRightAlignmentData;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelsAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightsOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusPartsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasCustomPaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalCarRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_ecuData;

	private static readonly System.IntPtr NativeFieldInfoPtr_measuredDragIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBodyPartsData_Private_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPartsData_Private_Void_BinaryReader_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefault_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFactoryColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFactoryColor_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFactoryPaintType_Public_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBodyPartsData_Public_Void_CarLoader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewCarData>.NativeClassPtr));

	public unsafe string carToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carToLoad);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carToLoad), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string UId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UId), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> factoryColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factoryColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factoryColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PaintType factoryPaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factoryPaintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factoryPaintType)) = paintType;
		}
	}

	public unsafe bool customerCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customerCar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customerCar)) = flag;
		}
	}

	public unsafe int orderConnection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderConnection);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderConnection)) = num;
		}
	}

	public unsafe ToolsData TooolsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TooolsData);
			return *(ToolsData*)num;
		}
		set
		{
			*(ToolsData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TooolsData)) = toolsData;
		}
	}

	public unsafe FluidsData FluidsData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FluidsData);
			return new FluidsData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FluidsData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string engineSwap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSwap);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSwap), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe List<BodyPartData> BodyPartsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyPartsData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<BodyPartData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyPartsData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<PartData> PartData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<PartData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> tiresET
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresET);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresET), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> wheelsWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelsWidth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelsWidth), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> rimsSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rimsSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rimsSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> tiresSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int configVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configVersion)) = num;
		}
	}

	public unsafe LicensePlatesData LicensePlatesData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlatesData);
			return new LicensePlatesData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlatesData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe EngineData EngineData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineData);
			return *(EngineData*)num;
		}
		set
		{
			*(EngineData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineData)) = engineData;
		}
	}

	public unsafe Il2CppStructArray<float> gearRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearRatio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearRatio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float finalDriveRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalDriveRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalDriveRatio)) = num;
		}
	}

	public unsafe CarInfoData CarInfoData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarInfoData);
			return *(CarInfoData*)num;
		}
		set
		{
			*(CarInfoData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarInfoData)) = carInfoData;
		}
	}

	public unsafe HeadlampAlignmentData HeadlampLeftAlignmentData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadlampLeftAlignmentData);
			return *(HeadlampAlignmentData*)num;
		}
		set
		{
			*(HeadlampAlignmentData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadlampLeftAlignmentData)) = headlampAlignmentData;
		}
	}

	public unsafe HeadlampAlignmentData HeadlampRightAlignmentData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadlampRightAlignmentData);
			return *(HeadlampAlignmentData*)num;
		}
		set
		{
			*(HeadlampAlignmentData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadlampRightAlignmentData)) = headlampAlignmentData;
		}
	}

	public unsafe WheelsAlignmentData WheelsAlignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelsAlignment);
			return *(WheelsAlignmentData*)num;
		}
		set
		{
			*(WheelsAlignmentData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelsAlignment)) = wheelsAlignmentData;
		}
	}

	public unsafe bool LightsOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightsOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightsOn)) = flag;
		}
	}

	public unsafe BonusPartsData BonusPartsData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusPartsData);
			return new BonusPartsData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BonusPartsData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusPartsData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BonusPartsData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe PaintData PaintData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData);
			return *(PaintData*)num;
		}
		set
		{
			*(PaintData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData)) = paintData;
		}
	}

	public unsafe bool HasCustomPaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasCustomPaintType);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasCustomPaintType)) = flag;
		}
	}

	public unsafe float AdditionalCarRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdditionalCarRot);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdditionalCarRot)) = num;
		}
	}

	public unsafe TuningData ecuData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecuData);
			return new TuningData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TuningData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecuData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TuningData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int measuredDragIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredDragIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredDragIndex)) = num;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 64970, RefRangeEnd = 64972, XrefRangeStart = 64941, XrefRangeEnd = 64970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 64992, RefRangeEnd = 64994, XrefRangeStart = 64972, XrefRangeEnd = 64992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65012, RefRangeEnd = 65013, XrefRangeStart = 64994, XrefRangeEnd = 65012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadBodyPartsData(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBodyPartsData_Private_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65031, RefRangeEnd = 65032, XrefRangeStart = 65013, XrefRangeEnd = 65031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadPartsData(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPartsData_Private_Void_BinaryReader_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsDefault()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDefault_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 65037, RefRangeEnd = 65041, XrefRangeStart = 65032, XrefRangeEnd = 65037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewCarData Clone()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_NewCarData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new NewCarData(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65044, RefRangeEnd = 65045, XrefRangeStart = 65041, XrefRangeEnd = 65044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65048, RefRangeEnd = 65050, XrefRangeStart = 65045, XrefRangeEnd = 65048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65053, RefRangeEnd = 65054, XrefRangeStart = 65050, XrefRangeEnd = 65053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFactoryColor(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFactoryColor_Public_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Color GetFactoryColor()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFactoryColor_Public_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe PaintType GetFactoryPaintType()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFactoryPaintType_Public_PaintType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65060, RefRangeEnd = 65061, XrefRangeStart = 65054, XrefRangeEnd = 65060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBodyPartsData(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBodyPartsData_Public_Void_CarLoader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewCarData()
	{
		Il2CppClassPointerStore<NewCarData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewCarData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewCarData>.NativeClassPtr);
		NativeFieldInfoPtr_carToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "carToLoad");
		NativeFieldInfoPtr_UId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "UId");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "index");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "color");
		NativeFieldInfoPtr_factoryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "factoryColor");
		NativeFieldInfoPtr_factoryPaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "factoryPaintType");
		NativeFieldInfoPtr_customerCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "customerCar");
		NativeFieldInfoPtr_orderConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "orderConnection");
		NativeFieldInfoPtr_TooolsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "TooolsData");
		NativeFieldInfoPtr_FluidsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "FluidsData");
		NativeFieldInfoPtr_engineSwap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "engineSwap");
		NativeFieldInfoPtr_BodyPartsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "BodyPartsData");
		NativeFieldInfoPtr_PartData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "PartData");
		NativeFieldInfoPtr_tiresET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "tiresET");
		NativeFieldInfoPtr_wheelsWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "wheelsWidth");
		NativeFieldInfoPtr_rimsSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "rimsSize");
		NativeFieldInfoPtr_tiresSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "tiresSize");
		NativeFieldInfoPtr_configVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "configVersion");
		NativeFieldInfoPtr_LicensePlatesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "LicensePlatesData");
		NativeFieldInfoPtr_EngineData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "EngineData");
		NativeFieldInfoPtr_gearRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "gearRatio");
		NativeFieldInfoPtr_finalDriveRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "finalDriveRatio");
		NativeFieldInfoPtr_CarInfoData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "CarInfoData");
		NativeFieldInfoPtr_HeadlampLeftAlignmentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "HeadlampLeftAlignmentData");
		NativeFieldInfoPtr_HeadlampRightAlignmentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "HeadlampRightAlignmentData");
		NativeFieldInfoPtr_WheelsAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "WheelsAlignment");
		NativeFieldInfoPtr_LightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "LightsOn");
		NativeFieldInfoPtr_BonusPartsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "BonusPartsData");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_HasCustomPaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "HasCustomPaintType");
		NativeFieldInfoPtr_AdditionalCarRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "AdditionalCarRot");
		NativeFieldInfoPtr_ecuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "ecuData");
		NativeFieldInfoPtr_measuredDragIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, "measuredDragIndex");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_ReadBodyPartsData_Private_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_ReadPartsData_Private_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_IsDefault_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_Clone_Public_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_GetColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr_SetFactoryColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667250);
		NativeMethodInfoPtr_GetFactoryColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667251);
		NativeMethodInfoPtr_GetFactoryPaintType_Public_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667252);
		NativeMethodInfoPtr_UpdateBodyPartsData_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, 100667253);
	}

	public NewCarData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe NewCarData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NewCarData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<NewCarData>.NativeClassPtr))
	{
	}
}
