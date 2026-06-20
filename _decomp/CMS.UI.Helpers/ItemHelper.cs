using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using CMS.UI.Logic;
using CMS.UI.Logic.Shop;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Helpers;

public static class ItemHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FillInventoryItem_Public_Static_Void_Item_InventoryItem_ItemFillType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillInventoryItem_Public_Static_Void_GroupItem_InventoryItem_ItemFillType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillInventoryItemDetails_Public_Static_Void_Item_InventoryItemDetails_Boolean_ChoosePartUpWindowType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillInventoryItemDetails_Public_Static_Void_GroupItem_InventoryItemDetails_ChoosePartUpWindowType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillGhostInventoryItemDetails_Public_Static_Void_String_InventoryItemDetails_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillBasicInventoryItem_Public_Static_Void_Item_BasicInventoryItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillBasicInventoryItem_Public_Static_Void_GroupItem_BasicInventoryItem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillShopItem_Public_Static_Void_PartProperty_ShopItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillShopItem_Public_Static_Void_LicensePlate_ShopItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillChoosePartDownItem_Public_Static_Void_ChoosePartDownItem_InventoryItem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBrandImage_Public_Static_Sprite_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLicensePlate_Public_Static_Boolean_Item_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseLicensePlateName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPartNameWithoutCarName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedLicensePlateName_Public_Static_String_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 205840, RefRangeEnd = 205841, XrefRangeStart = 205419, XrefRangeEnd = 205840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillInventoryItem(Item item, InventoryItem inventoryItem, ItemFillType itemFillType, bool moveToWarehouse = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryItem);
		*(ItemFillType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemFillType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &moveToWarehouse;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillInventoryItem_Public_Static_Void_Item_InventoryItem_ItemFillType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 206188, RefRangeEnd = 206196, XrefRangeStart = 205841, XrefRangeEnd = 206188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillInventoryItem(GroupItem groupItem, InventoryItem inventoryItem, ItemFillType itemFillType, bool moveToWarehouse = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryItem);
		*(ItemFillType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemFillType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &moveToWarehouse;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillInventoryItem_Public_Static_Void_GroupItem_InventoryItem_ItemFillType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 206507, RefRangeEnd = 206512, XrefRangeStart = 206196, XrefRangeEnd = 206507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillInventoryItemDetails(Item item, InventoryItemDetails inventoryItemDetails, bool createGroup, [Optional] ChoosePartUpWindowType choosePartUpWindowType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryItemDetails);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &createGroup;
		*(ChoosePartUpWindowType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &choosePartUpWindowType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillInventoryItemDetails_Public_Static_Void_Item_InventoryItemDetails_Boolean_ChoosePartUpWindowType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206512, XrefRangeEnd = 206809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillInventoryItemDetails(GroupItem groupItem, InventoryItemDetails inventoryItemDetails, [Optional] ChoosePartUpWindowType choosePartUpWindowType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryItemDetails);
		*(ChoosePartUpWindowType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &choosePartUpWindowType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillInventoryItemDetails_Public_Static_Void_GroupItem_InventoryItemDetails_ChoosePartUpWindowType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 206885, RefRangeEnd = 206887, XrefRangeStart = 206809, XrefRangeEnd = 206885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillGhostInventoryItemDetails(string itemID, InventoryItemDetails inventoryItemDetails, string customCaption)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryItemDetails);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(customCaption);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillGhostInventoryItemDetails_Public_Static_Void_String_InventoryItemDetails_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206924, RefRangeEnd = 206925, XrefRangeStart = 206887, XrefRangeEnd = 206924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillBasicInventoryItem(Item item, BasicInventoryItem basicInventoryItem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(basicInventoryItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillBasicInventoryItem_Public_Static_Void_Item_BasicInventoryItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206984, RefRangeEnd = 206985, XrefRangeStart = 206925, XrefRangeEnd = 206984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillBasicInventoryItem(GroupItem groupItem, BasicInventoryItem basicInventoryItem, bool engineCrane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(basicInventoryItem);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &engineCrane;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillBasicInventoryItem_Public_Static_Void_GroupItem_BasicInventoryItem_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207092, RefRangeEnd = 207093, XrefRangeStart = 206985, XrefRangeEnd = 207092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillShopItem(PartProperty partProperty, ShopItem shopItem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(partProperty);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(shopItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillShopItem_Public_Static_Void_PartProperty_ShopItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207155, RefRangeEnd = 207156, XrefRangeStart = 207093, XrefRangeEnd = 207155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillShopItem(LicensePlate licensePlate, ShopItem shopItem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(licensePlate));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(shopItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillShopItem_Public_Static_Void_LicensePlate_ShopItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 207187, RefRangeEnd = 207189, XrefRangeStart = 207156, XrefRangeEnd = 207187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillChoosePartDownItem(ChoosePartDownItem choosePartDownItem, InventoryItem inventoryItem, bool moveToWarehouse = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(choosePartDownItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryItem);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &moveToWarehouse;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillChoosePartDownItem_Public_Static_Void_ChoosePartDownItem_InventoryItem_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207189, XrefRangeEnd = 207191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite GetBrandImage(string brand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(brand);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBrandImage_Public_Static_Sprite_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 207200, RefRangeEnd = 207207, XrefRangeStart = 207191, XrefRangeEnd = 207200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLicensePlate(Item item, out string licensePlateName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		*(System.IntPtr**)num = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLicensePlate_Public_Static_Boolean_Item_byref_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		licensePlateName = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207207, XrefRangeEnd = 207213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ParseLicensePlateName(string licensePlateName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseLicensePlateName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207213, XrefRangeEnd = 207218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPartNameWithoutCarName(string partName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPartNameWithoutCarName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 207224, RefRangeEnd = 207229, XrefRangeStart = 207218, XrefRangeEnd = 207224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedLicensePlateName(string licensePlateName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedLicensePlateName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static ItemHelper()
	{
		Il2CppClassPointerStore<ItemHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "ItemHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr);
		NativeMethodInfoPtr_FillInventoryItem_Public_Static_Void_Item_InventoryItem_ItemFillType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678754);
		NativeMethodInfoPtr_FillInventoryItem_Public_Static_Void_GroupItem_InventoryItem_ItemFillType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678755);
		NativeMethodInfoPtr_FillInventoryItemDetails_Public_Static_Void_Item_InventoryItemDetails_Boolean_ChoosePartUpWindowType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678756);
		NativeMethodInfoPtr_FillInventoryItemDetails_Public_Static_Void_GroupItem_InventoryItemDetails_ChoosePartUpWindowType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678757);
		NativeMethodInfoPtr_FillGhostInventoryItemDetails_Public_Static_Void_String_InventoryItemDetails_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678758);
		NativeMethodInfoPtr_FillBasicInventoryItem_Public_Static_Void_Item_BasicInventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678759);
		NativeMethodInfoPtr_FillBasicInventoryItem_Public_Static_Void_GroupItem_BasicInventoryItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678760);
		NativeMethodInfoPtr_FillShopItem_Public_Static_Void_PartProperty_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678761);
		NativeMethodInfoPtr_FillShopItem_Public_Static_Void_LicensePlate_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678762);
		NativeMethodInfoPtr_FillChoosePartDownItem_Public_Static_Void_ChoosePartDownItem_InventoryItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678763);
		NativeMethodInfoPtr_GetBrandImage_Public_Static_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678764);
		NativeMethodInfoPtr_IsLicensePlate_Public_Static_Boolean_Item_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678765);
		NativeMethodInfoPtr_ParseLicensePlateName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678766);
		NativeMethodInfoPtr_GetPartNameWithoutCarName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678767);
		NativeMethodInfoPtr_GetLocalizedLicensePlateName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemHelper>.NativeClassPtr, 100678768);
	}

	public ItemHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
