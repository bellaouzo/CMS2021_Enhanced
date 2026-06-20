using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.ContainersSave;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class ProfileData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_saveVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_BestRaceTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_TopSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuildVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_FinishedTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_Difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_carsInGarage;

	private static readonly System.IntPtr NativeFieldInfoPtr_carsOnParking;

	private static readonly System.IntPtr NativeFieldInfoPtr_jukeboxData;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageCustomizationData;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryData;

	private static readonly System.IntPtr NativeFieldInfoPtr_warehouseData;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLiftersData;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLoaderData;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeForPointsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeForMoneyData;

	private static readonly System.IntPtr NativeFieldInfoPtr_machines;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalDataWrapper;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerData;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShopListItemsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintshopData;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowTintData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitGarageCars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitParkingCars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitJukeboxData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitGarageCustomizationData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitInventoryData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitWarehouseData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCarLiftersData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCarLoaderData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitUnlockedPosition_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitUpgradesForPointsData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitUpgradesForMoneyData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitMachinesData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitJobsData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitGlobalData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryRecoverProfile_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverGarageCars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverParkingCars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverJobsData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverUpgradesData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverUnlockedPosition_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverWarehouseData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecoverCarLoaderData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteSaveHeader_Private_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAndVerifyHeader_Private_Boolean_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteSaveVersion_Private_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAndVerifySaveVersion_Private_Boolean_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeToBytes_Public_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeFromBytes_Public_Void_byref_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProfileData>.NativeClassPtr));

	public unsafe byte saveVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveVersion);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveVersion)) = b;
		}
	}

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe long LastSave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastSave);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastSave)) = num;
		}
	}

	public unsafe uint PlayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayTime);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayTime)) = num;
		}
	}

	public unsafe long BestRaceTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BestRaceTime);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BestRaceTime)) = num;
		}
	}

	public unsafe int TopSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TopSpeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TopSpeed)) = num;
		}
	}

	public unsafe long LastUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUID);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUID)) = num;
		}
	}

	public unsafe string BuildVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildVersion), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool FinishedTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FinishedTutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FinishedTutorial)) = flag;
		}
	}

	public unsafe DifficultyLevel Difficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Difficulty);
			return *(DifficultyLevel*)num;
		}
		set
		{
			*(DifficultyLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Difficulty)) = difficultyLevel;
		}
	}

	public unsafe Il2CppReferenceArray<NewCarData> carsInGarage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsInGarage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<NewCarData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsInGarage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<NewCarData> carsOnParking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsOnParking);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<NewCarData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsOnParking), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RadioData jukeboxData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jukeboxData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RadioData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jukeboxData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GarageCustomizationData garageCustomizationData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageCustomizationData);
			return new GarageCustomizationData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageCustomizationData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NewInventoryData inventoryData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewInventoryData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NewWarehouseData warehouseData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewWarehouseData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<NewCarLifterData> carLiftersData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLiftersData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<NewCarLifterData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLiftersData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NewCarLoaderData carLoaderData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewCarLoaderData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NewUnlockedPosition unlockedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewUnlockedPosition(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NewUpgradeSystemData upgradeForPointsData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeForPointsData);
			return new NewUpgradeSystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewUpgradeSystemData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeForPointsData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NewUpgradeSystemData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NewUpgradeSystemData upgradeForMoneyData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeForMoneyData);
			return new NewUpgradeSystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewUpgradeSystemData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeForMoneyData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NewUpgradeSystemData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NewMachines machines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewMachines(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_machines), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NewJobsData jobsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobsData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewJobsData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobsData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NewGlobalDataWrapper globalDataWrapper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalDataWrapper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new NewGlobalDataWrapper(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalDataWrapper), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerData PlayerData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerData);
			return new PlayerData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppReferenceArray<ShopListItemData> ShopListItemsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopListItemsData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ShopListItemData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopListItemsData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PaintshopData PaintshopData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintshopData);
			return new PaintshopData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintshopData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe WindowTintData WindowTintData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowTintData);
			return new WindowTintData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowTintData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 94141, RefRangeEnd = 94145, XrefRangeStart = 94121, XrefRangeEnd = 94141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 94161, RefRangeEnd = 94166, XrefRangeStart = 94145, XrefRangeEnd = 94161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitGarageCars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGarageCars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 94182, RefRangeEnd = 94187, XrefRangeStart = 94166, XrefRangeEnd = 94182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitParkingCars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitParkingCars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94190, RefRangeEnd = 94192, XrefRangeStart = 94187, XrefRangeEnd = 94190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitJukeboxData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitJukeboxData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94194, RefRangeEnd = 94195, XrefRangeStart = 94192, XrefRangeEnd = 94194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitGarageCustomizationData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGarageCustomizationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94205, RefRangeEnd = 94207, XrefRangeStart = 94195, XrefRangeEnd = 94205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitInventoryData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitInventoryData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94226, RefRangeEnd = 94228, XrefRangeStart = 94207, XrefRangeEnd = 94226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitWarehouseData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitWarehouseData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94238, RefRangeEnd = 94240, XrefRangeStart = 94228, XrefRangeEnd = 94238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitCarLiftersData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCarLiftersData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94249, RefRangeEnd = 94251, XrefRangeStart = 94240, XrefRangeEnd = 94249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitCarLoaderData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCarLoaderData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 94257, RefRangeEnd = 94260, XrefRangeStart = 94251, XrefRangeEnd = 94257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitUnlockedPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitUnlockedPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 94268, RefRangeEnd = 94271, XrefRangeStart = 94260, XrefRangeEnd = 94268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitUpgradesForPointsData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitUpgradesForPointsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 94279, RefRangeEnd = 94282, XrefRangeStart = 94271, XrefRangeEnd = 94279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitUpgradesForMoneyData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitUpgradesForMoneyData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94285, RefRangeEnd = 94287, XrefRangeStart = 94282, XrefRangeEnd = 94285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitMachinesData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitMachinesData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94301, RefRangeEnd = 94303, XrefRangeStart = 94287, XrefRangeEnd = 94301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitJobsData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitJobsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94306, RefRangeEnd = 94308, XrefRangeStart = 94303, XrefRangeEnd = 94306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitGlobalData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGlobalData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94308, XrefRangeEnd = 94361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryRecoverProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryRecoverProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94361, XrefRangeEnd = 94364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverGarageCars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverGarageCars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94364, XrefRangeEnd = 94367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverParkingCars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverParkingCars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94367, XrefRangeEnd = 94379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverJobsData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverJobsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94379, XrefRangeEnd = 94381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverUpgradesData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverUpgradesData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94381, XrefRangeEnd = 94384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverUnlockedPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverUnlockedPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94384, XrefRangeEnd = 94402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverWarehouseData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverWarehouseData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94412, RefRangeEnd = 94413, XrefRangeStart = 94402, XrefRangeEnd = 94412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecoverCarLoaderData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecoverCarLoaderData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void WriteSaveHeader(BinaryWriter binaryWriter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteSaveHeader_Private_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool ReadAndVerifyHeader(BinaryReader binaryReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAndVerifyHeader_Private_Boolean_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void WriteSaveVersion(BinaryWriter binaryWriter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteSaveVersion_Private_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool ReadAndVerifySaveVersion(BinaryReader binaryReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAndVerifySaveVersion_Private_Boolean_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94465, RefRangeEnd = 94466, XrefRangeStart = 94413, XrefRangeEnd = 94465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> SerializeToBytes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeToBytes_Public_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94541, RefRangeEnd = 94543, XrefRangeStart = 94466, XrefRangeEnd = 94541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeserializeFromBytes(ref Il2CppStructArray<byte> bytes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeFromBytes_Public_Void_byref_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ProfileData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfileData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ProfileData()
	{
		Il2CppClassPointerStore<ProfileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ProfileData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfileData>.NativeClassPtr);
		NativeFieldInfoPtr_saveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "saveVersion");
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_LastSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "LastSave");
		NativeFieldInfoPtr_PlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "PlayTime");
		NativeFieldInfoPtr_BestRaceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "BestRaceTime");
		NativeFieldInfoPtr_TopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "TopSpeed");
		NativeFieldInfoPtr_LastUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "LastUID");
		NativeFieldInfoPtr_BuildVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "BuildVersion");
		NativeFieldInfoPtr_FinishedTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "FinishedTutorial");
		NativeFieldInfoPtr_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "Difficulty");
		NativeFieldInfoPtr_carsInGarage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "carsInGarage");
		NativeFieldInfoPtr_carsOnParking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "carsOnParking");
		NativeFieldInfoPtr_jukeboxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "jukeboxData");
		NativeFieldInfoPtr_garageCustomizationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "garageCustomizationData");
		NativeFieldInfoPtr_inventoryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "inventoryData");
		NativeFieldInfoPtr_warehouseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "warehouseData");
		NativeFieldInfoPtr_carLiftersData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "carLiftersData");
		NativeFieldInfoPtr_carLoaderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "carLoaderData");
		NativeFieldInfoPtr_unlockedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "unlockedPosition");
		NativeFieldInfoPtr_upgradeForPointsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "upgradeForPointsData");
		NativeFieldInfoPtr_upgradeForMoneyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "upgradeForMoneyData");
		NativeFieldInfoPtr_machines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "machines");
		NativeFieldInfoPtr_jobsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "jobsData");
		NativeFieldInfoPtr_globalDataWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "globalDataWrapper");
		NativeFieldInfoPtr_PlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "PlayerData");
		NativeFieldInfoPtr_ShopListItemsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "ShopListItemsData");
		NativeFieldInfoPtr_PaintshopData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "PaintshopData");
		NativeFieldInfoPtr_WindowTintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, "WindowTintData");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668737);
		NativeMethodInfoPtr_InitGarageCars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668738);
		NativeMethodInfoPtr_InitParkingCars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668739);
		NativeMethodInfoPtr_InitJukeboxData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668740);
		NativeMethodInfoPtr_InitGarageCustomizationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668741);
		NativeMethodInfoPtr_InitInventoryData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668742);
		NativeMethodInfoPtr_InitWarehouseData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668743);
		NativeMethodInfoPtr_InitCarLiftersData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668744);
		NativeMethodInfoPtr_InitCarLoaderData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668745);
		NativeMethodInfoPtr_InitUnlockedPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668746);
		NativeMethodInfoPtr_InitUpgradesForPointsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668747);
		NativeMethodInfoPtr_InitUpgradesForMoneyData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668748);
		NativeMethodInfoPtr_InitMachinesData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668749);
		NativeMethodInfoPtr_InitJobsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668750);
		NativeMethodInfoPtr_InitGlobalData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668751);
		NativeMethodInfoPtr_TryRecoverProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668752);
		NativeMethodInfoPtr_RecoverGarageCars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668753);
		NativeMethodInfoPtr_RecoverParkingCars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668754);
		NativeMethodInfoPtr_RecoverJobsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668755);
		NativeMethodInfoPtr_RecoverUpgradesData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668756);
		NativeMethodInfoPtr_RecoverUnlockedPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668757);
		NativeMethodInfoPtr_RecoverWarehouseData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668758);
		NativeMethodInfoPtr_RecoverCarLoaderData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668759);
		NativeMethodInfoPtr_WriteSaveHeader_Private_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668760);
		NativeMethodInfoPtr_ReadAndVerifyHeader_Private_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668761);
		NativeMethodInfoPtr_WriteSaveVersion_Private_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668762);
		NativeMethodInfoPtr_ReadAndVerifySaveVersion_Private_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668763);
		NativeMethodInfoPtr_SerializeToBytes_Public_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668764);
		NativeMethodInfoPtr_DeserializeFromBytes_Public_Void_byref_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668765);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfileData>.NativeClassPtr, 100668766);
	}

	public ProfileData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
