using System;
using System.Runtime.CompilerServices;
using CMS.ContainersSave;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Warehouse : MonoBehaviour
{
	[ObfuscatedName("Warehouse/<>c__DisplayClass20_0")]
	public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Delete_b__0_Internal_Boolean_Item_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr));

		public unsafe Item item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass20_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _Delete_b__0(Item inventoryItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inventoryItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Delete_b__0_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass20_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "<>c__DisplayClass20_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr);
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, "item");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, 100668426);
			NativeMethodInfoPtr__Delete_b__0_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, 100668427);
		}

		public __c__DisplayClass20_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Warehouse/<>c__DisplayClass21_0")]
	public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_group;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Delete_b__0_Internal_Boolean_GroupItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr));

		public unsafe GroupItem group
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GroupItem(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass21_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _Delete_b__0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Delete_b__0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass21_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "<>c__DisplayClass21_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr);
			NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, "group");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100668428);
			NativeMethodInfoPtr__Delete_b__0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100668429);
		}

		public __c__DisplayClass21_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxWarehouses;

	private static readonly System.IntPtr NativeFieldInfoPtr_warehouseList;

	private static readonly System.IntPtr NativeFieldInfoPtr_warehouseGroupList;

	private static readonly System.IntPtr NativeFieldInfoPtr_warehouseNamesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_warehouseShelfLevelManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_amountOfUnlockedWarehouses;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedOption;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWarehouseShelfLevel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeWarehouse_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectWarehouse_Public_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshWarehouseName_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentWarehouseName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWarehouseName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWarehouseName_Public_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultWarehouseName_Private_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentSelectedWarehouseName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Void_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Void_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllItemsAndGroups_Private_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchItems_Private_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Warehouse>.NativeClassPtr));

	public unsafe static int MaxWarehouses
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxWarehouses, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxWarehouses, &num);
		}
	}

	public unsafe List<List<Item>> warehouseList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<List<Item>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<List<GroupItem>> warehouseGroupList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseGroupList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<List<GroupItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseGroupList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<WarehouseNameData> warehouseNamesData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseNamesData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WarehouseNameData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseNamesData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe WarehouseShelfLevelManager warehouseShelfLevelManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseShelfLevelManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new WarehouseShelfLevelManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warehouseShelfLevelManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int amountOfUnlockedWarehouses
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_amountOfUnlockedWarehouses, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_amountOfUnlockedWarehouses, &num);
		}
	}

	public unsafe int SelectedOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedOption);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedOption)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89075, XrefRangeEnd = 89081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89081, XrefRangeEnd = 89095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89110, RefRangeEnd = 89112, XrefRangeStart = 89095, XrefRangeEnd = 89110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWarehouseShelfLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWarehouseShelfLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89148, RefRangeEnd = 89149, XrefRangeStart = 89112, XrefRangeEnd = 89148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeWarehouse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpgradeWarehouse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89149, XrefRangeEnd = 89155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectWarehouse(int index, string newName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectWarehouse_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89155, XrefRangeEnd = 89162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshWarehouseName(string newName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshWarehouseName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89162, XrefRangeEnd = 89163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCurrentWarehouseName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentWarehouseName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 89164, RefRangeEnd = 89171, XrefRangeStart = 89163, XrefRangeEnd = 89164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetWarehouseName(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWarehouseName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89177, RefRangeEnd = 89178, XrefRangeStart = 89171, XrefRangeEnd = 89177, MetadataInitTokenRva = 42578096L, MetadataInitFlagRva = 42591525L)]
	public unsafe void SetWarehouseName(int index, string newName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWarehouseName_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89189, RefRangeEnd = 89190, XrefRangeStart = 89178, XrefRangeEnd = 89189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetDefaultWarehouseName(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultWarehouseName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe string GetCurrentSelectedWarehouseName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentSelectedWarehouseName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89190, XrefRangeEnd = 89196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(Item item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89196, XrefRangeEnd = 89202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(GroupItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89221, RefRangeEnd = 89222, XrefRangeStart = 89202, XrefRangeEnd = 89221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Delete(Item item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delete_Public_Void_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89241, RefRangeEnd = 89243, XrefRangeStart = 89222, XrefRangeEnd = 89241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Delete(GroupItem group)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delete_Public_Void_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 89258, RefRangeEnd = 89261, XrefRangeStart = 89243, XrefRangeEnd = 89258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetAllItemsAndGroups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllItemsAndGroups_Private_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89273, RefRangeEnd = 89274, XrefRangeStart = 89261, XrefRangeEnd = 89273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItemsForCategory(InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89286, RefRangeEnd = 89287, XrefRangeStart = 89274, XrefRangeEnd = 89286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89287, XrefRangeEnd = 89289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SearchItems(string searchText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchItems_Private_List_1_BaseItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 89293, RefRangeEnd = 89296, XrefRangeStart = 89289, XrefRangeEnd = 89293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89296, XrefRangeEnd = 89298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89393, RefRangeEnd = 89394, XrefRangeStart = 89298, XrefRangeEnd = 89393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89394, XrefRangeEnd = 89444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89444, XrefRangeEnd = 89462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Warehouse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Warehouse>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Warehouse()
	{
		Il2CppClassPointerStore<Warehouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Warehouse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Warehouse>.NativeClassPtr);
		NativeFieldInfoPtr_MaxWarehouses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "MaxWarehouses");
		NativeFieldInfoPtr_warehouseList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "warehouseList");
		NativeFieldInfoPtr_warehouseGroupList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "warehouseGroupList");
		NativeFieldInfoPtr_warehouseNamesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "warehouseNamesData");
		NativeFieldInfoPtr_warehouseShelfLevelManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "warehouseShelfLevelManager");
		NativeFieldInfoPtr_amountOfUnlockedWarehouses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "amountOfUnlockedWarehouses");
		NativeFieldInfoPtr_SelectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, "SelectedOption");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668401);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668402);
		NativeMethodInfoPtr_UpdateWarehouseShelfLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668403);
		NativeMethodInfoPtr_UpgradeWarehouse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668404);
		NativeMethodInfoPtr_SelectWarehouse_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668405);
		NativeMethodInfoPtr_RefreshWarehouseName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668406);
		NativeMethodInfoPtr_GetCurrentWarehouseName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668407);
		NativeMethodInfoPtr_GetWarehouseName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668408);
		NativeMethodInfoPtr_SetWarehouseName_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668409);
		NativeMethodInfoPtr_GetDefaultWarehouseName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668410);
		NativeMethodInfoPtr_GetCurrentSelectedWarehouseName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668411);
		NativeMethodInfoPtr_Add_Public_Void_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668412);
		NativeMethodInfoPtr_Add_Public_Void_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668413);
		NativeMethodInfoPtr_Delete_Public_Void_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668414);
		NativeMethodInfoPtr_Delete_Public_Void_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668415);
		NativeMethodInfoPtr_GetAllItemsAndGroups_Private_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668416);
		NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668417);
		NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668418);
		NativeMethodInfoPtr_SearchItems_Private_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668419);
		NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668420);
		NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668421);
		NativeMethodInfoPtr_Load_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668422);
		NativeMethodInfoPtr_Save_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668423);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Warehouse>.NativeClassPtr, 100668424);
	}

	public Warehouse(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
