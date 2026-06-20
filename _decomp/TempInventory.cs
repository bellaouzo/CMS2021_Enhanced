using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class TempInventory : Il2CppSystem.Object
{
	[ObfuscatedName("TempInventory/<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_itemUID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveItem_b__0_Internal_Boolean_BaseItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr));

		public unsafe long itemUID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemUID);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemUID)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _RemoveItem_b__0(BaseItem inventoryItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inventoryItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveItem_b__0_Internal_Boolean_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
			NativeFieldInfoPtr_itemUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "itemUID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100668135);
			NativeMethodInfoPtr__RemoveItem_b__0_Internal_Boolean_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100668136);
		}

		public __c__DisplayClass4_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_items;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListOfItems_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Void_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearListOfItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsPrice_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemPrice_Public_Int32_Item_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseItems_Private_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchItems_Public_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TempInventory>.NativeClassPtr));

	public unsafe List<BaseItem> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 84742, RefRangeEnd = 84745, XrefRangeStart = 84736, XrefRangeEnd = 84742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetListOfItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListOfItems_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84745, XrefRangeEnd = 84755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddItem(BaseItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItem_Public_Void_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84755, XrefRangeEnd = 84763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveItem(BaseItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Void_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 84779, RefRangeEnd = 84781, XrefRangeStart = 84763, XrefRangeEnd = 84779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveItem(long itemUID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemUID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItem_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 84788, RefRangeEnd = 84792, XrefRangeStart = 84781, XrefRangeEnd = 84788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearListOfItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearListOfItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84792, XrefRangeEnd = 84799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemsPrice(float mod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mod);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsPrice_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84806, RefRangeEnd = 84807, XrefRangeStart = 84799, XrefRangeEnd = 84806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84807, XrefRangeEnd = 84811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemPrice(Item item, float mod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mod;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemPrice_Public_Int32_Item_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 84819, RefRangeEnd = 84824, XrefRangeStart = 84811, XrefRangeEnd = 84819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetBaseItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseItems_Private_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84824, XrefRangeEnd = 84826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SearchItems(string searchText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchItems_Public_List_1_BaseItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84847, RefRangeEnd = 84848, XrefRangeStart = 84826, XrefRangeEnd = 84847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItemsForCategory(List<BaseItem> itemsList, InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemsList);
		*(InventoryCategories**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 84852, RefRangeEnd = 84857, XrefRangeStart = 84848, XrefRangeEnd = 84852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SearchAndSortItemsForCategory(string searchText, SortType sortType, InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		*(SortType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortType;
		*(InventoryCategories**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84857, XrefRangeEnd = 84859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SortItemsForCategory(SortType sortType, InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sortType);
		*(InventoryCategories**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84859, XrefRangeEnd = 84865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TempInventory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempInventory>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TempInventory()
	{
		Il2CppClassPointerStore<TempInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TempInventory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempInventory>.NativeClassPtr);
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, "items");
		NativeMethodInfoPtr_GetListOfItems_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668121);
		NativeMethodInfoPtr_AddItem_Public_Void_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668122);
		NativeMethodInfoPtr_RemoveItem_Public_Void_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668123);
		NativeMethodInfoPtr_RemoveItem_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668124);
		NativeMethodInfoPtr_ClearListOfItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668125);
		NativeMethodInfoPtr_GetItemsPrice_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668126);
		NativeMethodInfoPtr_GetItemsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668127);
		NativeMethodInfoPtr_GetItemPrice_Public_Int32_Item_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668128);
		NativeMethodInfoPtr_GetBaseItems_Private_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668129);
		NativeMethodInfoPtr_SearchItems_Public_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668130);
		NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668131);
		NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668132);
		NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668133);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempInventory>.NativeClassPtr, 100668134);
	}

	public TempInventory(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
