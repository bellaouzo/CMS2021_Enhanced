using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewMachines : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GroupOnWheelBalancer;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelWasBalanced;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupOnTireChanger;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupOnTireChangerIsMounting;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupOnSpringClamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupOnSpringClampIsMounting;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupOnEngineStand;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineStandAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemOnBatteryCharger;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemOnBrakeLathe;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeItem_Private_Void_BinaryWriter_Item_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeGroup_Private_Void_BinaryWriter_GroupItem_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeItem_Private_Void_BinaryReader_byref_Item_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeGroupItem_Private_Void_BinaryReader_byref_GroupItem_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewMachines>.NativeClassPtr));

	public unsafe GroupItem GroupOnWheelBalancer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnWheelBalancer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroupItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnWheelBalancer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool WheelWasBalanced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelWasBalanced);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelWasBalanced)) = flag;
		}
	}

	public unsafe GroupItem GroupOnTireChanger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnTireChanger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroupItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnTireChanger), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool GroupOnTireChangerIsMounting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnTireChangerIsMounting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnTireChangerIsMounting)) = flag;
		}
	}

	public unsafe GroupItem GroupOnSpringClamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnSpringClamp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroupItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnSpringClamp), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool GroupOnSpringClampIsMounting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnSpringClampIsMounting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnSpringClampIsMounting)) = flag;
		}
	}

	public unsafe GroupItem GroupOnEngineStand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnEngineStand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroupItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupOnEngineStand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float EngineStandAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineStandAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineStandAngle)) = num;
		}
	}

	public unsafe Item ItemOnBatteryCharger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemOnBatteryCharger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemOnBatteryCharger), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Item ItemOnBrakeLathe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemOnBrakeLathe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemOnBrakeLathe), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65298, RefRangeEnd = 65299, XrefRangeStart = 65287, XrefRangeEnd = 65298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65299, XrefRangeEnd = 65305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65305, XrefRangeEnd = 65307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeItem(BinaryWriter binaryWriter, Item item, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeItem_Private_Void_BinaryWriter_Item_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65307, XrefRangeEnd = 65309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeGroup(BinaryWriter binaryWriter, GroupItem groupItem, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeGroup_Private_Void_BinaryWriter_GroupItem_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 65314, RefRangeEnd = 65318, XrefRangeStart = 65309, XrefRangeEnd = 65314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeserializeItem(BinaryReader binaryReader, ref Item item, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr**)num = &intPtr;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeItem_Private_Void_BinaryReader_byref_Item_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		item = ((intPtr3 == (System.IntPtr)0) ? null : new Item(intPtr3));
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 65322, RefRangeEnd = 65330, XrefRangeStart = 65318, XrefRangeEnd = 65322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeserializeGroupItem(BinaryReader binaryReader, ref GroupItem groupItem, byte saveVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
		*(System.IntPtr**)num = &intPtr;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeGroupItem_Private_Void_BinaryReader_byref_GroupItem_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		groupItem = ((intPtr3 == (System.IntPtr)0) ? null : new GroupItem(intPtr3));
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe NewMachines()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMachines>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewMachines()
	{
		Il2CppClassPointerStore<NewMachines>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewMachines");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMachines>.NativeClassPtr);
		NativeFieldInfoPtr_GroupOnWheelBalancer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "GroupOnWheelBalancer");
		NativeFieldInfoPtr_WheelWasBalanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "WheelWasBalanced");
		NativeFieldInfoPtr_GroupOnTireChanger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "GroupOnTireChanger");
		NativeFieldInfoPtr_GroupOnTireChangerIsMounting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "GroupOnTireChangerIsMounting");
		NativeFieldInfoPtr_GroupOnSpringClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "GroupOnSpringClamp");
		NativeFieldInfoPtr_GroupOnSpringClampIsMounting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "GroupOnSpringClampIsMounting");
		NativeFieldInfoPtr_GroupOnEngineStand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "GroupOnEngineStand");
		NativeFieldInfoPtr_EngineStandAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "EngineStandAngle");
		NativeFieldInfoPtr_ItemOnBatteryCharger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "ItemOnBatteryCharger");
		NativeFieldInfoPtr_ItemOnBrakeLathe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, "ItemOnBrakeLathe");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667308);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667309);
		NativeMethodInfoPtr_SerializeItem_Private_Void_BinaryWriter_Item_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667310);
		NativeMethodInfoPtr_SerializeGroup_Private_Void_BinaryWriter_GroupItem_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667311);
		NativeMethodInfoPtr_DeserializeItem_Private_Void_BinaryReader_byref_Item_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667312);
		NativeMethodInfoPtr_DeserializeGroupItem_Private_Void_BinaryReader_byref_GroupItem_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667313);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMachines>.NativeClassPtr, 100667314);
	}

	public NewMachines(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
