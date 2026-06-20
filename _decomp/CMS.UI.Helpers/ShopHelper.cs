using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Helpers;

public static class ShopHelper : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("CMS.UI.Helpers.ShopHelper/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SearchParts_b__4_0_Internal_Int32_PartProperty_PartProperty_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SearchParts_b__5_0_Internal_Int32_PartProperty_PartProperty_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SearchLicensePlates_b__8_0_Internal_Int32_LicensePlate_LicensePlate_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c>.NativeClassPtr));

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new __c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Comparison<PartProperty> __9__4_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__4_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Comparison<PartProperty>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__4_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Comparison<PartProperty> __9__5_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__5_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Comparison<PartProperty>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__5_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Comparison<LicensePlate> __9__8_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__8_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Comparison<LicensePlate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__8_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207362, XrefRangeEnd = 207366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SearchParts_b__4_0(PartProperty a, PartProperty b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SearchParts_b__4_0_Internal_Int32_PartProperty_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe int _SearchParts_b__5_0(PartProperty a, PartProperty b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SearchParts_b__5_0_Internal_Int32_PartProperty_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207366, XrefRangeEnd = 207370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SearchLicensePlates_b__8_0(LicensePlate a, LicensePlate b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SearchLicensePlates_b__8_0_Internal_Int32_LicensePlate_LicensePlate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__4_0");
			NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__5_0");
			NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__8_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678792);
			NativeMethodInfoPtr__SearchParts_b__4_0_Internal_Int32_PartProperty_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678793);
			NativeMethodInfoPtr__SearchParts_b__5_0_Internal_Int32_PartProperty_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678794);
			NativeMethodInfoPtr__SearchLicensePlates_b__8_0_Internal_Int32_LicensePlate_LicensePlate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678795);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ShopToShopName_Public_Static_String_ShopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShopCategoryToString_Public_Static_String_ShopCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PartsToShopItems_Public_Static_List_1_IShopItem_List_1_PartProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LicensePlatesToShopItems_Public_Static_List_1_IShopItem_List_1_LicensePlate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchParts_Public_Static_List_1_PartProperty_String_ShopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchParts_Public_Static_List_1_PartProperty_String_ShopType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchItemsInCategory_Public_Static_List_1_PartProperty_String_ShopType_ShopCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchItemsInCategory_Public_Static_List_1_PartProperty_String_ShopType_ShopCategories_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchLicensePlates_Public_Static_List_1_LicensePlate_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchCars_Public_Static_Void_String_byref_List_1_String_byref_List_1_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207370, XrefRangeEnd = 207384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ShopToShopName(ShopType shopType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shopType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShopToShopName_Public_Static_String_ShopType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 207391, RefRangeEnd = 207393, XrefRangeStart = 207384, XrefRangeEnd = 207391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ShopCategoryToString(ShopCategories category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShopCategoryToString_Public_Static_String_ShopCategories_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 207405, RefRangeEnd = 207411, XrefRangeStart = 207393, XrefRangeEnd = 207405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<IShopItem> PartsToShopItems(List<PartProperty> parts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PartsToShopItems_Public_Static_List_1_IShopItem_List_1_PartProperty_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<IShopItem>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 207426, RefRangeEnd = 207429, XrefRangeStart = 207411, XrefRangeEnd = 207426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<IShopItem> LicensePlatesToShopItems(List<LicensePlate> licensePlates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(licensePlates);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LicensePlatesToShopItems_Public_Static_List_1_IShopItem_List_1_LicensePlate_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<IShopItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 207463, RefRangeEnd = 207465, XrefRangeStart = 207429, XrefRangeEnd = 207463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PartProperty> SearchParts(string searchText, ShopType shopType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		*(ShopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shopType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchParts_Public_Static_List_1_PartProperty_String_ShopType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartProperty>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207498, RefRangeEnd = 207499, XrefRangeStart = 207465, XrefRangeEnd = 207498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PartProperty> SearchParts(string searchText, ShopType shopType, string carID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		*(ShopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shopType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchParts_Public_Static_List_1_PartProperty_String_ShopType_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartProperty>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 207505, RefRangeEnd = 207509, XrefRangeStart = 207499, XrefRangeEnd = 207505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PartProperty> SearchItemsInCategory(string searchText, ShopType shopType, ShopCategories category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		*(ShopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shopType;
		*(ShopCategories**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchItemsInCategory_Public_Static_List_1_PartProperty_String_ShopType_ShopCategories_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartProperty>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 207515, RefRangeEnd = 207517, XrefRangeStart = 207509, XrefRangeEnd = 207515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PartProperty> SearchItemsInCategory(string searchText, ShopType shopType, ShopCategories category, string carID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		*(ShopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shopType;
		*(ShopCategories**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchItemsInCategory_Public_Static_List_1_PartProperty_String_ShopType_ShopCategories_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartProperty>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 207566, RefRangeEnd = 207569, XrefRangeStart = 207517, XrefRangeEnd = 207566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<LicensePlate> SearchLicensePlates(string searchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchLicensePlates_Public_Static_List_1_LicensePlate_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<LicensePlate>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207621, RefRangeEnd = 207622, XrefRangeStart = 207569, XrefRangeEnd = 207621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SearchCars(string searchText, ref List<string> cars, out List<string> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(result);
		*(System.IntPtr**)num2 = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchCars_Public_Static_Void_String_byref_List_1_String_byref_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		cars = (List<string>)(object)((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		result = (List<string>)(object)((intPtr5 == (System.IntPtr)0) ? null : new List<T>(intPtr5));
	}

	static ShopHelper()
	{
		Il2CppClassPointerStore<ShopHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "ShopHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr);
		NativeMethodInfoPtr_ShopToShopName_Public_Static_String_ShopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678781);
		NativeMethodInfoPtr_ShopCategoryToString_Public_Static_String_ShopCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678782);
		NativeMethodInfoPtr_PartsToShopItems_Public_Static_List_1_IShopItem_List_1_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678783);
		NativeMethodInfoPtr_LicensePlatesToShopItems_Public_Static_List_1_IShopItem_List_1_LicensePlate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678784);
		NativeMethodInfoPtr_SearchParts_Public_Static_List_1_PartProperty_String_ShopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678785);
		NativeMethodInfoPtr_SearchParts_Public_Static_List_1_PartProperty_String_ShopType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678786);
		NativeMethodInfoPtr_SearchItemsInCategory_Public_Static_List_1_PartProperty_String_ShopType_ShopCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678787);
		NativeMethodInfoPtr_SearchItemsInCategory_Public_Static_List_1_PartProperty_String_ShopType_ShopCategories_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678788);
		NativeMethodInfoPtr_SearchLicensePlates_Public_Static_List_1_LicensePlate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678789);
		NativeMethodInfoPtr_SearchCars_Public_Static_Void_String_byref_List_1_String_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopHelper>.NativeClassPtr, 100678790);
	}

	public ShopHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
