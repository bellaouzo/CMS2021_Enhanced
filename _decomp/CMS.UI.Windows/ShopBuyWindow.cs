using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Logic;
using CMS.UI.Logic.Navigation;
using CMS.UI.Logic.Shop;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Windows;

public class ShopBuyWindow : Window
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemBrand;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_listNavigationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_discountInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopType;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentET;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDiscount;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForItem_Public_Void_ShopItem_ShopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillItemInfo_Private_Void_ShopItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyItem_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareOptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterOptionsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterOptionsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionForType_Private_ShopOption_ShopOptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OptionValueChanged_Private_Void_ShopOptionType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRange_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDiscountInfo_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareList_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleListInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentListItem_Private_ShopOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleCurrentOptionInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEventHandlers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterEventHandlers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWindowActiveStateChange_Private_Void_WindowID_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr));

	public unsafe Text itemName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image itemPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPreview);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPreview), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image itemBrand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemBrand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemBrand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject itemQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemQuality);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemQuality), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ListNavigationManager listNavigationManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listNavigationManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ListNavigationManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listNavigationManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ShopOption> shopOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ShopOption>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopOptions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text discountInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discountInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discountInfo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ShopType shopType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopType);
			return *(ShopType*)num;
		}
		set
		{
			*(ShopType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopType)) = shopType;
		}
	}

	public unsafe ShopBuyItemType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ShopBuyItemType*)num;
		}
		set
		{
			*(ShopBuyItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = shopBuyItemType;
		}
	}

	public unsafe string itemID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float currentPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPrice);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPrice)) = num;
		}
	}

	public unsafe int currentAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAmount)) = num;
		}
	}

	public unsafe int currentET
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentET);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentET)) = num;
		}
	}

	public unsafe int currentProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentProfile);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentProfile)) = num;
		}
	}

	public unsafe int currentSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSize)) = num;
		}
	}

	public unsafe int currentWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWidth)) = num;
		}
	}

	public unsafe float currentDiscount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDiscount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDiscount)) = num;
		}
	}

	public unsafe SpecialGroup specialGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGroup);
			return *(SpecialGroup*)num;
		}
		set
		{
			*(SpecialGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGroup)) = specialGroup;
		}
	}

	public unsafe InputManager inputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIDescription uiDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172035, XrefRangeEnd = 172042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172042, XrefRangeEnd = 172050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172050, XrefRangeEnd = 172071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172071, XrefRangeEnd = 172116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Hide(bool hiddenFromOutside)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hiddenFromOutside);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(55)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void EnableUI(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 172149, RefRangeEnd = 172152, XrefRangeStart = 172116, XrefRangeEnd = 172149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForItem(ShopItem item, ShopType shopType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(ShopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shopType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForItem_Public_Void_ShopItem_ShopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172189, RefRangeEnd = 172190, XrefRangeStart = 172152, XrefRangeEnd = 172189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillItemInfo(ShopItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillItemInfo_Private_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172264, RefRangeEnd = 172265, XrefRangeStart = 172190, XrefRangeEnd = 172264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172265, XrefRangeEnd = 172266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void HideAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172289, RefRangeEnd = 172290, XrefRangeStart = 172266, XrefRangeEnd = 172289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172290, XrefRangeEnd = 172308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDescriptionsActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172308, XrefRangeEnd = 172316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172432, RefRangeEnd = 172433, XrefRangeStart = 172316, XrefRangeEnd = 172432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172445, RefRangeEnd = 172446, XrefRangeStart = 172433, XrefRangeEnd = 172445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterOptionsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterOptionsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172446, XrefRangeEnd = 172455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterOptionsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterOptionsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 172456, RefRangeEnd = 172460, XrefRangeStart = 172455, XrefRangeEnd = 172456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShopOption GetOptionForType(ShopOptionType optionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&optionType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOptionForType_Private_ShopOption_ShopOptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ShopOption(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172460, XrefRangeEnd = 172475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OptionValueChanged(ShopOptionType optionType, int newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&optionType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OptionValueChanged_Private_Void_ShopOptionType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172475, XrefRangeEnd = 172484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRange(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRange_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 172500, RefRangeEnd = 172502, XrefRangeStart = 172484, XrefRangeEnd = 172500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePrice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172502, XrefRangeEnd = 172512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDiscountInfo(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDiscountInfo_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172540, RefRangeEnd = 172541, XrefRangeStart = 172512, XrefRangeEnd = 172540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe bool HandleListInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleListInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 172558, RefRangeEnd = 172560, XrefRangeStart = 172541, XrefRangeEnd = 172558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShopOption GetCurrentListItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentListItem_Private_ShopOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ShopOption(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetInputManager(InputManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172560, XrefRangeEnd = 172574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleCurrentOptionInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleCurrentOptionInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172574, XrefRangeEnd = 172588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172588, XrefRangeEnd = 172601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEventHandlers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterEventHandlers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172601, XrefRangeEnd = 172614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegisterEventHandlers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterEventHandlers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172614, XrefRangeEnd = 172618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWindowActiveStateChange(WindowID windowID, bool stateChange)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateChange;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWindowActiveStateChange_Private_Void_WindowID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ShopBuyWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShopBuyWindow()
	{
		Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "ShopBuyWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr);
		NativeFieldInfoPtr_itemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "itemName");
		NativeFieldInfoPtr_itemPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "itemPreview");
		NativeFieldInfoPtr_itemBrand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "itemBrand");
		NativeFieldInfoPtr_itemQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "itemQuality");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "price");
		NativeFieldInfoPtr_listNavigationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "listNavigationManager");
		NativeFieldInfoPtr_shopOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "shopOptions");
		NativeFieldInfoPtr_discountInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "discountInfo");
		NativeFieldInfoPtr_shopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "shopType");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "type");
		NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "itemID");
		NativeFieldInfoPtr_currentPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentPrice");
		NativeFieldInfoPtr_currentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentAmount");
		NativeFieldInfoPtr_currentET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentET");
		NativeFieldInfoPtr_currentProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentProfile");
		NativeFieldInfoPtr_currentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentSize");
		NativeFieldInfoPtr_currentWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentWidth");
		NativeFieldInfoPtr_currentDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "currentDiscount");
		NativeFieldInfoPtr_specialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "specialGroup");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "inputManager");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, "uiDescription");
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675610);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675611);
		NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675612);
		NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675613);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675614);
		NativeMethodInfoPtr_PrepareForItem_Public_Void_ShopItem_ShopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675615);
		NativeMethodInfoPtr_FillItemInfo_Private_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675616);
		NativeMethodInfoPtr_BuyItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675617);
		NativeMethodInfoPtr_BuyAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675618);
		NativeMethodInfoPtr_HideAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675619);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675620);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675621);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675622);
		NativeMethodInfoPtr_PrepareOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675623);
		NativeMethodInfoPtr_RegisterOptionsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675624);
		NativeMethodInfoPtr_UnregisterOptionsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675625);
		NativeMethodInfoPtr_GetOptionForType_Private_ShopOption_ShopOptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675626);
		NativeMethodInfoPtr_OptionValueChanged_Private_Void_ShopOptionType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675627);
		NativeMethodInfoPtr_UpdateRange_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675628);
		NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675629);
		NativeMethodInfoPtr_UpdateDiscountInfo_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675630);
		NativeMethodInfoPtr_PrepareList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675631);
		NativeMethodInfoPtr_HandleListInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675632);
		NativeMethodInfoPtr_GetCurrentListItem_Private_ShopOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675633);
		NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675634);
		NativeMethodInfoPtr_HandleCurrentOptionInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675635);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675636);
		NativeMethodInfoPtr_RegisterEventHandlers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675637);
		NativeMethodInfoPtr_UnRegisterEventHandlers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675638);
		NativeMethodInfoPtr_OnWindowActiveStateChange_Private_Void_WindowID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675639);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBuyWindow>.NativeClassPtr, 100675640);
	}

	public ShopBuyWindow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
