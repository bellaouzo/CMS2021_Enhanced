using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class Item : BaseItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NormalID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dent;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsExamined;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_Livery;

	private static readonly System.IntPtr NativeFieldInfoPtr_LiveryStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPainted;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsTinted;

	private static readonly System.IntPtr NativeFieldInfoPtr_TintColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepairAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutsideRustEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_LPData;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelData;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearboxData;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_WashFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_MountObjectData;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_BinaryWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_BinaryReader_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Item_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalID_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConditionToShow_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCondition_Public_Virtual_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConditionToShow_Public_Virtual_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedName_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuning_Public_Boolean_byref_TuningPart_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Item>.NativeClassPtr));

	public unsafe string NormalID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float Condition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition)) = num;
		}
	}

	public unsafe float Dent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dent)) = num;
		}
	}

	public unsafe bool IsExamined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsExamined);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsExamined)) = flag;
		}
	}

	public unsafe int Quality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality)) = num;
		}
	}

	public unsafe string Livery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Livery);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Livery), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float LiveryStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LiveryStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LiveryStrength)) = num;
		}
	}

	public unsafe bool IsPainted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPainted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPainted)) = flag;
		}
	}

	public unsafe CustomColor Color
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color);
			return new CustomColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool IsTinted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTinted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTinted)) = flag;
		}
	}

	public unsafe CustomColor TintColor
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TintColor);
			return new CustomColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TintColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int RepairAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairAmount)) = num;
		}
	}

	public unsafe bool OutsideRustEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutsideRustEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutsideRustEnabled)) = flag;
		}
	}

	public unsafe LPData LPData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LPData);
			return new LPData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LPData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LPData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LPData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe WheelData WheelData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelData);
			return *(WheelData*)num;
		}
		set
		{
			*(WheelData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelData)) = wheelData;
		}
	}

	public unsafe GearboxData GearboxData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GearboxData);
			return new GearboxData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GearboxData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe float WashFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashFactor)) = num;
		}
	}

	public unsafe MountObjectData MountObjectData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MountObjectData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MountObjectData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MountObjectData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TuningData tuningData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningData);
			return new TuningData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TuningData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TuningData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float ConditionToShow
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConditionToShow_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 92972, RefRangeEnd = 92978, XrefRangeStart = 92951, XrefRangeEnd = 92972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_BinaryWriter_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92999, RefRangeEnd = 93001, XrefRangeStart = 92978, XrefRangeEnd = 92999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_BinaryReader_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93004, RefRangeEnd = 93006, XrefRangeStart = 93001, XrefRangeEnd = 93004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93017, RefRangeEnd = 93019, XrefRangeStart = 93006, XrefRangeEnd = 93017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item(Item item)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93030, RefRangeEnd = 93031, XrefRangeStart = 93019, XrefRangeEnd = 93030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item(Item item, long UID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &UID;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Item_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 93040, RefRangeEnd = 93062, XrefRangeStart = 93031, XrefRangeEnd = 93040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item(string id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 93067, RefRangeEnd = 93070, XrefRangeStart = 93062, XrefRangeEnd = 93067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item(string id, long newUID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newUID;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe string GetNormalID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormalID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93070, XrefRangeEnd = 93074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe float GetCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetCondition_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93074, XrefRangeEnd = 93078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe float GetConditionToShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetConditionToShow_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93078, XrefRangeEnd = 93081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe string GetLocalizedName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLocalizedName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 93095, RefRangeEnd = 93099, XrefRangeStart = 93081, XrefRangeEnd = 93095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTuning(out TuningPart tuningPart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(tuningPart);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuning_Public_Boolean_byref_TuningPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static Item()
	{
		Il2CppClassPointerStore<Item>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Item");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item>.NativeClassPtr);
		NativeFieldInfoPtr_NormalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "NormalID");
		NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "Condition");
		NativeFieldInfoPtr_Dent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "Dent");
		NativeFieldInfoPtr_IsExamined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "IsExamined");
		NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "Quality");
		NativeFieldInfoPtr_Livery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "Livery");
		NativeFieldInfoPtr_LiveryStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "LiveryStrength");
		NativeFieldInfoPtr_IsPainted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "IsPainted");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_IsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "IsTinted");
		NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TintColor");
		NativeFieldInfoPtr_RepairAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "RepairAmount");
		NativeFieldInfoPtr_OutsideRustEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OutsideRustEnabled");
		NativeFieldInfoPtr_LPData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "LPData");
		NativeFieldInfoPtr_WheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "WheelData");
		NativeFieldInfoPtr_GearboxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "GearboxData");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_WashFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "WashFactor");
		NativeFieldInfoPtr_MountObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "MountObjectData");
		NativeFieldInfoPtr_tuningData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "tuningData");
		NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_BinaryWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668623);
		NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668624);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668625);
		NativeMethodInfoPtr__ctor_Public_Void_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668626);
		NativeMethodInfoPtr__ctor_Public_Void_Item_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668627);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668628);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668629);
		NativeMethodInfoPtr_GetNormalID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668630);
		NativeMethodInfoPtr_get_ConditionToShow_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668631);
		NativeMethodInfoPtr_GetCondition_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668632);
		NativeMethodInfoPtr_GetConditionToShow_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668633);
		NativeMethodInfoPtr_GetLocalizedName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668634);
		NativeMethodInfoPtr_IsTuning_Public_Boolean_byref_TuningPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100668635);
	}

	public Item(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
