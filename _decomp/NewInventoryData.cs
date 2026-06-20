using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewInventoryData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_items;

	private static readonly System.IntPtr NativeFieldInfoPtr_groups;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUId;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr));

	public unsafe List<Item> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Item>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<GroupItem> groups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<GroupItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int lastUId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUId)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65124, XrefRangeEnd = 65129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65143, RefRangeEnd = 65144, XrefRangeStart = 65129, XrefRangeEnd = 65143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65156, RefRangeEnd = 65158, XrefRangeStart = 65144, XrefRangeEnd = 65156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewInventoryData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewInventoryData()
	{
		Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewInventoryData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr);
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr, "items");
		NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr, "groups");
		NativeFieldInfoPtr_lastUId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr, "lastUId");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr, 100667284);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr, 100667285);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInventoryData>.NativeClassPtr, 100667286);
	}

	public NewInventoryData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
