using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Logic;
using CMS.UI.Logic.Shop;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Windows;

public class ShopLicenseBuyWindow : Window
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_preview;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_amountShopOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_licensePlateLetterSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_discountInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_customLicensePlate;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDiscount;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareLetterSection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupLetterSection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForLicensePlate_Public_Void_ShopItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillLicensePlateInfo_Private_Void_ShopItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLetterChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActivate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePriceText_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePriceText_Private_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDiscountInfo_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyItem_Private_Void_Boolean_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyBlankAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CustomizeAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcceptAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomizeDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetClearDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareOptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterOptionsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterOptionsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AmountChanged_Private_Void_ShopOptionType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleAmountChangeInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr));

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

	public unsafe Image preview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preview);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preview), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe ShopOption amountShopOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountShopOption);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ShopOption(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountShopOption), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LicensePlateLetterSection licensePlateLetterSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensePlateLetterSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LicensePlateLetterSection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensePlateLetterSection), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe bool customLicensePlate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customLicensePlate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customLicensePlate)) = flag;
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172618, XrefRangeEnd = 172624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172624, XrefRangeEnd = 172632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172632, XrefRangeEnd = 172642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172642, XrefRangeEnd = 172660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172674, RefRangeEnd = 172675, XrefRangeStart = 172660, XrefRangeEnd = 172674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareLetterSection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareLetterSection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172688, RefRangeEnd = 172689, XrefRangeStart = 172675, XrefRangeEnd = 172688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupLetterSection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupLetterSection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 172734, RefRangeEnd = 172737, XrefRangeStart = 172689, XrefRangeEnd = 172734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForLicensePlate(ShopItem licensePlate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(licensePlate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForLicensePlate_Public_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172743, RefRangeEnd = 172744, XrefRangeStart = 172737, XrefRangeEnd = 172743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillLicensePlateInfo(ShopItem licensePlate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(licensePlate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillLicensePlateInfo_Private_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172744, XrefRangeEnd = 172747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLetterChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLetterChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172747, XrefRangeEnd = 172755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActivate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172755, XrefRangeEnd = 172756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePriceText(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePriceText_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 172759, RefRangeEnd = 172763, XrefRangeStart = 172756, XrefRangeEnd = 172759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePriceText(int amount, bool custom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&amount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &custom;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePriceText_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172763, XrefRangeEnd = 172773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDiscountInfo(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDiscountInfo_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 172827, RefRangeEnd = 172829, XrefRangeStart = 172773, XrefRangeEnd = 172827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyItem(bool custom, bool blank, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&custom);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blank;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyItem_Private_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172829, XrefRangeEnd = 172839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172839, XrefRangeEnd = 172842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyBlankAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyBlankAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172842, XrefRangeEnd = 172844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CustomizeAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CustomizeAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172844, XrefRangeEnd = 172852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172852, XrefRangeEnd = 172861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcceptAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172861, XrefRangeEnd = 172870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
	[CachedScanResults(RefRangeStart = 172919, RefRangeEnd = 172920, XrefRangeStart = 172870, XrefRangeEnd = 172919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172950, RefRangeEnd = 172951, XrefRangeStart = 172920, XrefRangeEnd = 172950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDescriptionActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 172966, RefRangeEnd = 172968, XrefRangeStart = 172951, XrefRangeEnd = 172966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 172982, RefRangeEnd = 172985, XrefRangeStart = 172968, XrefRangeEnd = 172982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetCustomizeDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomizeDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172985, XrefRangeEnd = 172996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetClearDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetClearDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172996, XrefRangeEnd = 173009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173009, XrefRangeEnd = 173020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterOptionsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterOptionsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173020, XrefRangeEnd = 173029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterOptionsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterOptionsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173029, XrefRangeEnd = 173030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AmountChanged(ShopOptionType type, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AmountChanged_Private_Void_ShopOptionType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173030, XrefRangeEnd = 173031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleAmountChangeInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleAmountChangeInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173031, XrefRangeEnd = 173032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173032, XrefRangeEnd = 173035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShopLicenseBuyWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShopLicenseBuyWindow()
	{
		Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "ShopLicenseBuyWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr);
		NativeFieldInfoPtr_itemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "itemName");
		NativeFieldInfoPtr_preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "preview");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "price");
		NativeFieldInfoPtr_amountShopOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "amountShopOption");
		NativeFieldInfoPtr_licensePlateLetterSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "licensePlateLetterSection");
		NativeFieldInfoPtr_discountInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "discountInfo");
		NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "itemID");
		NativeFieldInfoPtr_currentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "currentAmount");
		NativeFieldInfoPtr_currentPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "currentPrice");
		NativeFieldInfoPtr_customLicensePlate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "customLicensePlate");
		NativeFieldInfoPtr_currentDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "currentDiscount");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "uiDescription");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, "inputManager");
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675641);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675642);
		NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675643);
		NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675644);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675645);
		NativeMethodInfoPtr_PrepareLetterSection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675646);
		NativeMethodInfoPtr_CleanupLetterSection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675647);
		NativeMethodInfoPtr_PrepareForLicensePlate_Public_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675648);
		NativeMethodInfoPtr_FillLicensePlateInfo_Private_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675649);
		NativeMethodInfoPtr_OnLetterChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675650);
		NativeMethodInfoPtr_OnActivate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675651);
		NativeMethodInfoPtr_UpdatePriceText_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675652);
		NativeMethodInfoPtr_UpdatePriceText_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675653);
		NativeMethodInfoPtr_UpdateDiscountInfo_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675654);
		NativeMethodInfoPtr_BuyItem_Private_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675655);
		NativeMethodInfoPtr_BuyAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675656);
		NativeMethodInfoPtr_BuyBlankAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675657);
		NativeMethodInfoPtr_CustomizeAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675658);
		NativeMethodInfoPtr_ClearAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675659);
		NativeMethodInfoPtr_AcceptAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675660);
		NativeMethodInfoPtr_CancelAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675661);
		NativeMethodInfoPtr_HideAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675662);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675663);
		NativeMethodInfoPtr_RemoveDescriptionActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675664);
		NativeMethodInfoPtr_SetDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675665);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675666);
		NativeMethodInfoPtr_SetCustomizeDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675667);
		NativeMethodInfoPtr_SetClearDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675668);
		NativeMethodInfoPtr_PrepareOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675669);
		NativeMethodInfoPtr_RegisterOptionsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675670);
		NativeMethodInfoPtr_UnregisterOptionsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675671);
		NativeMethodInfoPtr_AmountChanged_Private_Void_ShopOptionType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675672);
		NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675673);
		NativeMethodInfoPtr_HandleAmountChangeInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675674);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675675);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLicenseBuyWindow>.NativeClassPtr, 100675676);
	}

	public ShopLicenseBuyWindow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
