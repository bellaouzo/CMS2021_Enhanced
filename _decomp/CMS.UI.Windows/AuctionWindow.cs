using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.SceneLoaders;
using CMS.UI.Description;
using CMS.UI.Logic;
using CMS.UI.Logic.Auction;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Windows;

public class AuctionWindow : Window
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BGMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_chooseAuctionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_auctionSelectCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_auctionBidding;

	private static readonly System.IntPtr NativeFieldInfoPtr_logo;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalAuctionsLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_salvageAuctionsLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_auctionManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_auctionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAuctionManagerFromArgs_Private_Boolean_byref_AuctionManager_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAuctionScreenFromArgs_Private_AuctionScreen_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareScreens_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenScreen_Public_Boolean_AuctionScreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseActiveScreens_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BackToAuctionTypeSelect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLogoForScreen_Private_Void_AuctionScreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteForCurrentAuctionType_Private_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCars_Public_Void_List_1_AuctionCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetType_Public_Void_AuctionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupScreensDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterScreensDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleChooseAuctionTypeInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleSelectCarInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr));

	public unsafe GameObject BGMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BGMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BGMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChooseAuctionType chooseAuctionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chooseAuctionType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChooseAuctionType(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chooseAuctionType), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AuctionSelectCar auctionSelectCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionSelectCar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AuctionSelectCar(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionSelectCar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AuctionBidding auctionBidding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionBidding);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AuctionBidding(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionBidding), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image logo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite normalAuctionsLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalAuctionsLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalAuctionsLogo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite salvageAuctionsLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salvageAuctionsLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salvageAuctionsLogo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AuctionManager auctionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AuctionManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe AuctionType auctionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionType);
			return *(AuctionType*)num;
		}
		set
		{
			*(AuctionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionType)) = auctionType;
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

	public unsafe InputManager InputManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153018, XrefRangeEnd = 153024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153024, XrefRangeEnd = 153032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153032, XrefRangeEnd = 153072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Show(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153072, XrefRangeEnd = 153083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 153096, RefRangeEnd = 153121, XrefRangeStart = 153083, XrefRangeEnd = 153096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableUI(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153121, XrefRangeEnd = 153124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetAuctionManagerFromArgs(out AuctionManager manager, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(manager);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAuctionManagerFromArgs_Private_Boolean_byref_AuctionManager_ArrayOf_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		manager = ((intPtr2 == (System.IntPtr)0) ? null : new AuctionManager(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153124, XrefRangeEnd = 153126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AuctionScreen GetAuctionScreenFromArgs(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAuctionScreenFromArgs_Private_AuctionScreen_ArrayOf_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(AuctionScreen*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 153126, RefRangeEnd = 153127, XrefRangeStart = 153126, XrefRangeEnd = 153126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareScreens()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareScreens_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 153150, RefRangeEnd = 153159, XrefRangeStart = 153127, XrefRangeEnd = 153150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool OpenScreen(AuctionScreen screen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&screen);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenScreen_Public_Boolean_AuctionScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 153165, RefRangeEnd = 153168, XrefRangeStart = 153159, XrefRangeEnd = 153165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseActiveScreens()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseActiveScreens_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153168, XrefRangeEnd = 153170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BackToAuctionTypeSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BackToAuctionTypeSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153170, XrefRangeEnd = 153174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLogoForScreen(AuctionScreen screen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&screen);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLogoForScreen_Private_Void_AuctionScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Sprite GetSpriteForCurrentAuctionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteForCurrentAuctionType_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 153174, RefRangeEnd = 153176, XrefRangeStart = 153174, XrefRangeEnd = 153174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCars(List<AuctionCarData> cars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCars_Public_Void_List_1_AuctionCarData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetType(AuctionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetType_Public_Void_AuctionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153176, XrefRangeEnd = 153177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetupScreensDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupScreensDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 153249, RefRangeEnd = 153250, XrefRangeStart = 153177, XrefRangeEnd = 153249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterScreensDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterScreensDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(41)]
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
	public unsafe bool HandleChooseAuctionTypeInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleChooseAuctionTypeInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool HandleSelectCarInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleSelectCarInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153250, XrefRangeEnd = 153258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe AuctionWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AuctionWindow()
	{
		Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "AuctionWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr);
		NativeFieldInfoPtr_BGMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "BGMenu");
		NativeFieldInfoPtr_chooseAuctionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "chooseAuctionType");
		NativeFieldInfoPtr_auctionSelectCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "auctionSelectCar");
		NativeFieldInfoPtr_auctionBidding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "auctionBidding");
		NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "logo");
		NativeFieldInfoPtr_normalAuctionsLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "normalAuctionsLogo");
		NativeFieldInfoPtr_salvageAuctionsLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "salvageAuctionsLogo");
		NativeFieldInfoPtr_auctionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "auctionManager");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "inputManager");
		NativeFieldInfoPtr_auctionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "auctionType");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, "uiDescription");
		NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673978);
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673979);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673980);
		NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673981);
		NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673982);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673983);
		NativeMethodInfoPtr_GetAuctionManagerFromArgs_Private_Boolean_byref_AuctionManager_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673984);
		NativeMethodInfoPtr_GetAuctionScreenFromArgs_Private_AuctionScreen_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673985);
		NativeMethodInfoPtr_PrepareScreens_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673986);
		NativeMethodInfoPtr_OpenScreen_Public_Boolean_AuctionScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673987);
		NativeMethodInfoPtr_CloseActiveScreens_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673988);
		NativeMethodInfoPtr_BackToAuctionTypeSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673989);
		NativeMethodInfoPtr_SetLogoForScreen_Private_Void_AuctionScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673990);
		NativeMethodInfoPtr_GetSpriteForCurrentAuctionType_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673991);
		NativeMethodInfoPtr_SetCars_Public_Void_List_1_AuctionCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673992);
		NativeMethodInfoPtr_SetType_Public_Void_AuctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673993);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673994);
		NativeMethodInfoPtr_SetupScreensDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673995);
		NativeMethodInfoPtr_UnregisterScreensDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673996);
		NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673997);
		NativeMethodInfoPtr_HandleChooseAuctionTypeInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673998);
		NativeMethodInfoPtr_HandleSelectCarInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100673999);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100674000);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionWindow>.NativeClassPtr, 100674001);
	}

	public AuctionWindow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
