using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewJobWrapper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLoaderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_carFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_configVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_carColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeToEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobType;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobPartsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mileage;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherPartsCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusToExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusToMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeEngine;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeTiming;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeSuspension;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeBrakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeExhaust;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeGearbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeOil;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeTuning;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr));

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe int carLoaderID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderID)) = num;
		}
	}

	public unsafe int forXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forXP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forXP)) = num;
		}
	}

	public unsafe string carFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFile), IL2CPP.ManagedStringToIl2Cpp(str));
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

	public unsafe Il2CppStructArray<float> carColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PaintType PaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType)) = paintType;
		}
	}

	public unsafe float timeToEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeToEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeToEnd)) = num;
		}
	}

	public unsafe Il2CppStructArray<bool> jobType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobType), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<NewJobTaskWrapper> jobTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobTasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<NewJobTaskWrapper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobTasks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int jobPartsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPartsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPartsCount)) = num;
		}
	}

	public unsafe int Mileage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mileage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mileage)) = num;
		}
	}

	public unsafe float globalCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCondition)) = num;
		}
	}

	public unsafe float otherPartsCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartsCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartsCondition)) = num;
		}
	}

	public unsafe bool BonusToExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToExp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToExp)) = flag;
		}
	}

	public unsafe bool BonusToMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToMoney);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToMoney)) = flag;
		}
	}

	public unsafe string LocalizationID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMission)) = flag;
		}
	}

	public unsafe int MissionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionID)) = num;
		}
	}

	public unsafe bool IconTypeEngine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeEngine);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeEngine)) = flag;
		}
	}

	public unsafe bool IconTypeTiming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTiming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTiming)) = flag;
		}
	}

	public unsafe bool IconTypeSuspension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeSuspension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeSuspension)) = flag;
		}
	}

	public unsafe bool IconTypeBrakes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBrakes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBrakes)) = flag;
		}
	}

	public unsafe bool IconTypeExhaust
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeExhaust);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeExhaust)) = flag;
		}
	}

	public unsafe bool IconTypeGearbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeGearbox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeGearbox)) = flag;
		}
	}

	public unsafe bool IconTypeOil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeOil);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeOil)) = flag;
		}
	}

	public unsafe bool IconTypeBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBody);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBody)) = flag;
		}
	}

	public unsafe bool IconTypeTuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTuning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTuning)) = flag;
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 65340, RefRangeEnd = 65343, XrefRangeStart = 65330, XrefRangeEnd = 65340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65362, RefRangeEnd = 65363, XrefRangeStart = 65343, XrefRangeEnd = 65362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 65369, RefRangeEnd = 65372, XrefRangeStart = 65363, XrefRangeEnd = 65369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewJobWrapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewJobWrapper()
	{
		Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewJobWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "id");
		NativeFieldInfoPtr_carLoaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "carLoaderID");
		NativeFieldInfoPtr_forXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "forXP");
		NativeFieldInfoPtr_carFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "carFile");
		NativeFieldInfoPtr_configVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "configVersion");
		NativeFieldInfoPtr_carColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "carColor");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_timeToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "timeToEnd");
		NativeFieldInfoPtr_jobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "jobType");
		NativeFieldInfoPtr_jobTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "jobTasks");
		NativeFieldInfoPtr_jobPartsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "jobPartsCount");
		NativeFieldInfoPtr_Mileage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "Mileage");
		NativeFieldInfoPtr_globalCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "globalCondition");
		NativeFieldInfoPtr_otherPartsCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "otherPartsCondition");
		NativeFieldInfoPtr_BonusToExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "BonusToExp");
		NativeFieldInfoPtr_BonusToMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "BonusToMoney");
		NativeFieldInfoPtr_LocalizationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "LocalizationID");
		NativeFieldInfoPtr_IsMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IsMission");
		NativeFieldInfoPtr_MissionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "MissionID");
		NativeFieldInfoPtr_IconTypeEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeEngine");
		NativeFieldInfoPtr_IconTypeTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeTiming");
		NativeFieldInfoPtr_IconTypeSuspension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeSuspension");
		NativeFieldInfoPtr_IconTypeBrakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeBrakes");
		NativeFieldInfoPtr_IconTypeExhaust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeExhaust");
		NativeFieldInfoPtr_IconTypeGearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeGearbox");
		NativeFieldInfoPtr_IconTypeOil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeOil");
		NativeFieldInfoPtr_IconTypeBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeBody");
		NativeFieldInfoPtr_IconTypeTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, "IconTypeTuning");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, 100667315);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, 100667316);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobWrapper>.NativeClassPtr, 100667317);
	}

	public NewJobWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
