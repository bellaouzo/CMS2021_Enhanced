using System;
using System.Runtime.CompilerServices;
using CMS.Platforms.Base;
using CMS.UI.Description;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Shop;

public class CarSelectPage : ShopPage
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carsPageManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_gridNavigationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_topMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopName;

	private static readonly System.IntPtr NativeFieldInfoPtr_backButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_homeIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_backIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_cars;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_canHandleInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchLocalization;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearSearchLocalization;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchField;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchFieldFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSearchText;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldHasFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyboard;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_ShopConfig_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBeClosed_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterSearchFieldEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterSearchFieldEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSearch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSearchFieldEndEdit_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSearchFieldFocus_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSearchField_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSearchFieldFocused_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateSearch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateSearch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreSearchFieldValue_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitSearchField_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableCategoryChange_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableInput_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableGrid_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareTopMenu_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareShopBackButton_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupShopBackButton_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHomePageButtonClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockHomePageButton_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGridItemsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnItemMouseClick_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitItem_Private_Void_ShowroomCarItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_ShopConfig_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemFromGrid_Private_ShowroomCarItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitSelectedGridItem_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitItemAction_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateSearchAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitSearchAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelSearchAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescriptionBasedOnItemsCount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEmptyDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSearchDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareLocalizations_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSearchDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandlePageManagerInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareVirtualKeyboard_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupVirtualKeyboard_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowVirtualKeyboard_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnKeyboardFinished_Private_Void_VirtualKeyboardResult_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr));

	public unsafe CarsPageManager carsPageManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsPageManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarsPageManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsPageManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GridNavigationManager gridNavigationManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridNavigationManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GridNavigationManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridNavigationManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TopMenu topMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TopMenu(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text shopName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Button backButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Button(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject homeIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject backIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ShopConfig shopConfig
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopConfig);
			return new ShopConfig(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopConfig), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe List<string> cars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled)) = flag;
		}
	}

	public unsafe bool canHandleInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canHandleInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canHandleInput)) = flag;
		}
	}

	public unsafe ControlDescription searchDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string searchLocalization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchLocalization);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchLocalization), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string clearSearchLocalization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearSearchLocalization);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearSearchLocalization), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe InputField searchField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputFieldFocus searchFieldFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchFieldFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputFieldFocus(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchFieldFocus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string currentSearchText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSearchText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSearchText), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool inputFieldHasFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldHasFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldHasFocus)) = flag;
		}
	}

	public unsafe BaseKeyboard keyboard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboard);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseKeyboard(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboard), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187203, XrefRangeEnd = 187241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Open(ShopConfig config, bool setItems = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(config));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setItems;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Open_Public_Virtual_Void_ShopConfig_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187241, XrefRangeEnd = 187258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe bool CanBeClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CanBeClosed_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187280, RefRangeEnd = 187281, XrefRangeStart = 187258, XrefRangeEnd = 187280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterSearchFieldEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterSearchFieldEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187299, RefRangeEnd = 187300, XrefRangeStart = 187281, XrefRangeEnd = 187299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegisterSearchFieldEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterSearchFieldEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187300, XrefRangeEnd = 187305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetSearch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 187308, RefRangeEnd = 187312, XrefRangeStart = 187305, XrefRangeEnd = 187308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSearchFieldEndEdit(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSearchFieldEndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187354, RefRangeEnd = 187355, XrefRangeStart = 187312, XrefRangeEnd = 187354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSearchFieldFocus(bool gotFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gotFocus);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSearchFieldFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187355, XrefRangeEnd = 187379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSearchField(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSearchField_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsSearchFieldFocused()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSearchFieldFocused_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void ActivateSearch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 187386, RefRangeEnd = 187390, XrefRangeStart = 187379, XrefRangeEnd = 187386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeactivateSearch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeactivateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void RestoreSearchFieldValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreSearchFieldValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187390, XrefRangeEnd = 187393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitSearchField()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitSearchField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187393, XrefRangeEnd = 187395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableCategoryChange(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableCategoryChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void EnableInput(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableInput_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void EnableGrid(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableGrid_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187395, XrefRangeEnd = 187424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Enable(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Enable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187436, RefRangeEnd = 187437, XrefRangeStart = 187424, XrefRangeEnd = 187436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187437, XrefRangeEnd = 187440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareTopMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareTopMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187463, RefRangeEnd = 187464, XrefRangeStart = 187440, XrefRangeEnd = 187463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareShopBackButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareShopBackButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187482, RefRangeEnd = 187483, XrefRangeStart = 187464, XrefRangeEnd = 187482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupShopBackButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupShopBackButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187483, XrefRangeEnd = 187492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHomePageButtonClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHomePageButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187492, XrefRangeEnd = 187494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockHomePageButton(bool @lock = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&@lock);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockHomePageButton_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187502, RefRangeEnd = 187503, XrefRangeStart = 187494, XrefRangeEnd = 187502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterGridEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187517, RefRangeEnd = 187518, XrefRangeStart = 187503, XrefRangeEnd = 187517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterGridItemsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGridItemsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187518, XrefRangeEnd = 187523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnItemMouseClick(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnItemMouseClick_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187533, RefRangeEnd = 187536, XrefRangeStart = 187523, XrefRangeEnd = 187533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitItem(ShowroomCarItem carItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitItem_Private_Void_ShowroomCarItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187544, RefRangeEnd = 187545, XrefRangeStart = 187536, XrefRangeEnd = 187544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterGridEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187581, RefRangeEnd = 187583, XrefRangeStart = 187545, XrefRangeEnd = 187581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187583, XrefRangeEnd = 187592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateName(ShopConfig config)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(config));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateName_Private_Void_ShopConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 187609, RefRangeEnd = 187611, XrefRangeStart = 187592, XrefRangeEnd = 187609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowroomCarItem GetItemFromGrid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemFromGrid_Private_ShowroomCarItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ShowroomCarItem(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187611, XrefRangeEnd = 187625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SubmitSelectedGridItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitSelectedGridItem_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187625, XrefRangeEnd = 187639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SubmitItemAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SubmitItemAction_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187639, XrefRangeEnd = 187653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateSearchAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateSearchAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187653, XrefRangeEnd = 187655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitSearchAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitSearchAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187655, XrefRangeEnd = 187657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelSearchAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelSearchAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187657, XrefRangeEnd = 187699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_PrepareDescriptions_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187699, XrefRangeEnd = 187721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RemoveDescriptionsActions_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187745, RefRangeEnd = 187748, XrefRangeStart = 187721, XrefRangeEnd = 187745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDescriptionBasedOnItemsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescriptionBasedOnItemsCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187748, XrefRangeEnd = 187766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187766, XrefRangeEnd = 187781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEmptyDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEmptyDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187781, XrefRangeEnd = 187789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSearchDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSearchDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187789, XrefRangeEnd = 187795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareLocalizations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareLocalizations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187801, RefRangeEnd = 187804, XrefRangeStart = 187795, XrefRangeEnd = 187801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSearchDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSearchDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187804, XrefRangeEnd = 187810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandlePageManagerInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandlePageManagerInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187810, XrefRangeEnd = 187816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187816, XrefRangeEnd = 187823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareVirtualKeyboard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareVirtualKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CleanupVirtualKeyboard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupVirtualKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187833, RefRangeEnd = 187834, XrefRangeStart = 187823, XrefRangeEnd = 187833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowVirtualKeyboard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowVirtualKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187834, XrefRangeEnd = 187837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnKeyboardFinished(VirtualKeyboardResult result, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnKeyboardFinished_Private_Void_VirtualKeyboardResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187837, XrefRangeEnd = 187842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarSelectPage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarSelectPage()
	{
		Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Shop", "CarSelectPage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr);
		NativeFieldInfoPtr_carsPageManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "carsPageManager");
		NativeFieldInfoPtr_gridNavigationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "gridNavigationManager");
		NativeFieldInfoPtr_topMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "topMenu");
		NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "shopName");
		NativeFieldInfoPtr_backButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "backButton");
		NativeFieldInfoPtr_homeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "homeIcon");
		NativeFieldInfoPtr_backIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "backIcon");
		NativeFieldInfoPtr_shopConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "shopConfig");
		NativeFieldInfoPtr_cars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "cars");
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "isEnabled");
		NativeFieldInfoPtr_canHandleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "canHandleInput");
		NativeFieldInfoPtr_searchDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "searchDescription");
		NativeFieldInfoPtr_searchLocalization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "searchLocalization");
		NativeFieldInfoPtr_clearSearchLocalization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "clearSearchLocalization");
		NativeFieldInfoPtr_searchField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "searchField");
		NativeFieldInfoPtr_searchFieldFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "searchFieldFocus");
		NativeFieldInfoPtr_currentSearchText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "currentSearchText");
		NativeFieldInfoPtr_inputFieldHasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "inputFieldHasFocus");
		NativeFieldInfoPtr_keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, "keyboard");
		NativeMethodInfoPtr_Open_Public_Virtual_Void_ShopConfig_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677041);
		NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677042);
		NativeMethodInfoPtr_CanBeClosed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677043);
		NativeMethodInfoPtr_RegisterSearchFieldEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677044);
		NativeMethodInfoPtr_UnRegisterSearchFieldEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677045);
		NativeMethodInfoPtr_ResetSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677046);
		NativeMethodInfoPtr_OnSearchFieldEndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677047);
		NativeMethodInfoPtr_OnSearchFieldFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677048);
		NativeMethodInfoPtr_EnableSearchField_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677049);
		NativeMethodInfoPtr_IsSearchFieldFocused_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677050);
		NativeMethodInfoPtr_ActivateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677051);
		NativeMethodInfoPtr_DeactivateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677052);
		NativeMethodInfoPtr_RestoreSearchFieldValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677053);
		NativeMethodInfoPtr_SubmitSearchField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677054);
		NativeMethodInfoPtr_EnableCategoryChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677055);
		NativeMethodInfoPtr_EnableInput_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677056);
		NativeMethodInfoPtr_EnableGrid_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677057);
		NativeMethodInfoPtr_Enable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677058);
		NativeMethodInfoPtr_Prepare_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677059);
		NativeMethodInfoPtr_PrepareTopMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677060);
		NativeMethodInfoPtr_PrepareShopBackButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677061);
		NativeMethodInfoPtr_CleanupShopBackButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677062);
		NativeMethodInfoPtr_OnHomePageButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677063);
		NativeMethodInfoPtr_ResetPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677064);
		NativeMethodInfoPtr_LockHomePageButton_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677065);
		NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677066);
		NativeMethodInfoPtr_RegisterGridItemsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677067);
		NativeMethodInfoPtr_OnItemMouseClick_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677068);
		NativeMethodInfoPtr_SubmitItem_Private_Void_ShowroomCarItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677069);
		NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677070);
		NativeMethodInfoPtr_SetItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677071);
		NativeMethodInfoPtr_UpdateName_Private_Void_ShopConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677072);
		NativeMethodInfoPtr_GetItemFromGrid_Private_ShowroomCarItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677073);
		NativeMethodInfoPtr_SubmitSelectedGridItem_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677074);
		NativeMethodInfoPtr_SubmitItemAction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677075);
		NativeMethodInfoPtr_ActivateSearchAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677076);
		NativeMethodInfoPtr_SubmitSearchAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677077);
		NativeMethodInfoPtr_CancelSearchAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677078);
		NativeMethodInfoPtr_PrepareDescriptions_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677079);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677080);
		NativeMethodInfoPtr_SetDescriptionBasedOnItemsCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677081);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677082);
		NativeMethodInfoPtr_SetEmptyDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677083);
		NativeMethodInfoPtr_SetSearchDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677084);
		NativeMethodInfoPtr_PrepareLocalizations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677085);
		NativeMethodInfoPtr_RefreshSearchDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677086);
		NativeMethodInfoPtr_HandlePageManagerInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677087);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677088);
		NativeMethodInfoPtr_PrepareVirtualKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677089);
		NativeMethodInfoPtr_CleanupVirtualKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677090);
		NativeMethodInfoPtr_ShowVirtualKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677091);
		NativeMethodInfoPtr_OnKeyboardFinished_Private_Void_VirtualKeyboardResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677092);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSelectPage>.NativeClassPtr, 100677093);
	}

	public CarSelectPage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
