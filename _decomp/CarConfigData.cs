using System;
using System.Runtime.CompilerServices;
using INI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class CarConfigData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AmountOfConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_AmountOfBodyConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarBodyConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_FileType;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLC;

	private static readonly System.IntPtr NativeFieldInfoPtr_PathToFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpecialFile;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr));

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

	public unsafe string CarName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int AmountOfConfigs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmountOfConfigs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmountOfConfigs)) = num;
		}
	}

	public unsafe int AmountOfBodyConfigs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmountOfBodyConfigs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmountOfBodyConfigs)) = num;
		}
	}

	public unsafe List<INIUnity> CarConfigs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarConfigs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<INIUnity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarConfigs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<INIUnity> CarBodyConfigs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarBodyConfigs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<INIUnity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarBodyConfigs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> UIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIds), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarFileType FileType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileType);
			return *(CarFileType*)num;
		}
		set
		{
			*(CarFileType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileType)) = carFileType;
		}
	}

	public unsafe int DLC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC)) = num;
		}
	}

	public unsafe string PathToFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToFile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToFile), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe INIUnity SpecialFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpecialFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new INIUnity(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpecialFile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92648, RefRangeEnd = 92650, XrefRangeStart = 92646, XrefRangeEnd = 92648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarConfigData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarConfigData()
	{
		Il2CppClassPointerStore<CarConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarConfigData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr);
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_CarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "CarName");
		NativeFieldInfoPtr_AmountOfConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "AmountOfConfigs");
		NativeFieldInfoPtr_AmountOfBodyConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "AmountOfBodyConfigs");
		NativeFieldInfoPtr_CarConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "CarConfigs");
		NativeFieldInfoPtr_CarBodyConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "CarBodyConfigs");
		NativeFieldInfoPtr_UIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "UIds");
		NativeFieldInfoPtr_FileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "FileType");
		NativeFieldInfoPtr_DLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "DLC");
		NativeFieldInfoPtr_PathToFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "PathToFile");
		NativeFieldInfoPtr_SpecialFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, "SpecialFile");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarConfigData>.NativeClassPtr, 100668592);
	}

	public CarConfigData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
