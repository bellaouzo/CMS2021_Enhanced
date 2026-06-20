using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Windows;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Logic.Shop;

public class ShopPage : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_shop;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_chooseDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ShopConfig_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBeClosed_Public_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShop_Public_Void_ShopWindow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputManager_Public_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOpen_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPageType_Public_ShopPageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitItemAction_Protected_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenShopListAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BackAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideDescription_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChooseDescriptionText_Protected_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopPage>.NativeClassPtr));

	public unsafe ShopPageType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ShopPageType*)num;
		}
		set
		{
			*(ShopPageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = shopPageType;
		}
	}

	public unsafe ShopWindow shop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ShopWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOpen)) = flag;
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

	public unsafe ControlDescription chooseDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chooseDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chooseDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189643, XrefRangeEnd = 189649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Open()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189649, XrefRangeEnd = 189655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Open(ShopConfig config, bool setItems = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(config));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setItems;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ShopConfig_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool CanBeClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CanBeClosed_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 189661, RefRangeEnd = 189663, XrefRangeStart = 189655, XrefRangeEnd = 189661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_HandleInput_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void Enable(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Enable_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(38)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetShop(ShopWindow shopWindow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(shopWindow);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShop_Public_Void_ShopWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(36)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetInputManager(InputManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputManager_Public_Void_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe ShopPageType GetPageType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPageType_Public_ShopPageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ShopPageType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SubmitItemAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SubmitItemAction_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189663, XrefRangeEnd = 189667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenShopListAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenShopListAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189667, XrefRangeEnd = 189671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189671, XrefRangeEnd = 189673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BackAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BackAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189673, XrefRangeEnd = 189676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideDescription_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 189707, RefRangeEnd = 189709, XrefRangeStart = 189676, XrefRangeEnd = 189707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_PrepareDescriptions_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 189733, RefRangeEnd = 189735, XrefRangeStart = 189709, XrefRangeEnd = 189733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RemoveDescriptionsActions_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 189748, RefRangeEnd = 189753, XrefRangeStart = 189735, XrefRangeEnd = 189748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChooseDescriptionText(string localizedText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(localizedText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChooseDescriptionText_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 189757, RefRangeEnd = 189760, XrefRangeStart = 189753, XrefRangeEnd = 189757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 189764, RefRangeEnd = 189767, XrefRangeStart = 189760, XrefRangeEnd = 189764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deactivate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ShopPage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShopPage()
	{
		Il2CppClassPointerStore<ShopPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Shop", "ShopPage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPage>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "type");
		NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "shop");
		NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "isOpen");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "uiDescription");
		NativeFieldInfoPtr_chooseDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "chooseDescription");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "inputManager");
		NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677306);
		NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ShopConfig_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677307);
		NativeMethodInfoPtr_CanBeClosed_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677308);
		NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677309);
		NativeMethodInfoPtr_HandleInput_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677310);
		NativeMethodInfoPtr_Enable_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677311);
		NativeMethodInfoPtr_SetShop_Public_Void_ShopWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677312);
		NativeMethodInfoPtr_SetInputManager_Public_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677313);
		NativeMethodInfoPtr_IsOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677314);
		NativeMethodInfoPtr_GetPageType_Public_ShopPageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677315);
		NativeMethodInfoPtr_SubmitItemAction_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677316);
		NativeMethodInfoPtr_OpenShopListAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677317);
		NativeMethodInfoPtr_HideAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677318);
		NativeMethodInfoPtr_BackAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677319);
		NativeMethodInfoPtr_HideDescription_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677320);
		NativeMethodInfoPtr_PrepareDescriptions_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677321);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677322);
		NativeMethodInfoPtr_SetChooseDescriptionText_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677323);
		NativeMethodInfoPtr_Activate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677324);
		NativeMethodInfoPtr_Deactivate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677325);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100677326);
	}

	public ShopPage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
