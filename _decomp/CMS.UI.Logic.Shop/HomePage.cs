using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Shop;

public class HomePage : ShopPage
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gridNavigationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopAvatars;

	private static readonly System.IntPtr NativeFieldInfoPtr_gridIsPrepared;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBeClosed_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareGrid_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGridItemsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnItemMouseClick_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirst_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableGrid_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemFromGrid_Private_ShopAvatar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitSelectedGridItem_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitGridItem_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenShop_Private_Void_ShopAvatar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentItemNeedDLC_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitItemAction_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDescription_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnItemSelect_Protected_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleGridInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HomePage>.NativeClassPtr));

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

	public unsafe Il2CppReferenceArray<ShopAvatar> shopAvatars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopAvatars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ShopAvatar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopAvatars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool gridIsPrepared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridIsPrepared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridIsPrepared)) = flag;
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188010, XrefRangeEnd = 188052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Open()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188052, XrefRangeEnd = 188066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
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
	[CachedScanResults(RefRangeStart = 188095, RefRangeEnd = 188096, XrefRangeStart = 188066, XrefRangeEnd = 188095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PrepareGrid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareGrid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 188109, RefRangeEnd = 188110, XrefRangeStart = 188096, XrefRangeEnd = 188109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterGridItemsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGridItemsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188110, XrefRangeEnd = 188118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterGridEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188118, XrefRangeEnd = 188126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterGridEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188126, XrefRangeEnd = 188127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188127, XrefRangeEnd = 188128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectFirst()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectFirst_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 188144, RefRangeEnd = 188147, XrefRangeStart = 188128, XrefRangeEnd = 188144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShopAvatar GetItemFromGrid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemFromGrid_Private_ShopAvatar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ShopAvatar(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188147, XrefRangeEnd = 188161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitSelectedGridItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitSelectedGridItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 188196, RefRangeEnd = 188197, XrefRangeStart = 188161, XrefRangeEnd = 188196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitGridItem(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitGridItem_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 188209, RefRangeEnd = 188211, XrefRangeStart = 188197, XrefRangeEnd = 188209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenShop(ShopAvatar item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenShop_Private_Void_ShopAvatar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 188224, RefRangeEnd = 188226, XrefRangeStart = 188211, XrefRangeEnd = 188224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CurrentItemNeedDLC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentItemNeedDLC_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
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
	[CachedScanResults(RefRangeStart = 188245, RefRangeEnd = 188246, XrefRangeStart = 188226, XrefRangeEnd = 188245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void SubmitItemAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SubmitItemAction_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188246, XrefRangeEnd = 188267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188267, XrefRangeEnd = 188274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshDescription(bool haveToBuyDLC)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&haveToBuyDLC);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshDescription_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188274, XrefRangeEnd = 188282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnItemSelect(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnItemSelect_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe bool HandleGridInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleGridInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188282, XrefRangeEnd = 188285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HomePage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomePage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HomePage()
	{
		Il2CppClassPointerStore<HomePage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Shop", "HomePage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomePage>.NativeClassPtr);
		NativeFieldInfoPtr_gridNavigationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomePage>.NativeClassPtr, "gridNavigationManager");
		NativeFieldInfoPtr_shopAvatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomePage>.NativeClassPtr, "shopAvatars");
		NativeFieldInfoPtr_gridIsPrepared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomePage>.NativeClassPtr, "gridIsPrepared");
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomePage>.NativeClassPtr, "isEnabled");
		NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677119);
		NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677120);
		NativeMethodInfoPtr_CanBeClosed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677121);
		NativeMethodInfoPtr_PrepareGrid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677122);
		NativeMethodInfoPtr_RegisterGridItemsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677123);
		NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677124);
		NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677125);
		NativeMethodInfoPtr_OnItemMouseClick_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677126);
		NativeMethodInfoPtr_SelectFirst_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677127);
		NativeMethodInfoPtr_EnableGrid_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677128);
		NativeMethodInfoPtr_GetItemFromGrid_Private_ShopAvatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677129);
		NativeMethodInfoPtr_SubmitSelectedGridItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677130);
		NativeMethodInfoPtr_SubmitGridItem_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677131);
		NativeMethodInfoPtr_OpenShop_Private_Void_ShopAvatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677132);
		NativeMethodInfoPtr_CurrentItemNeedDLC_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677133);
		NativeMethodInfoPtr_Enable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677134);
		NativeMethodInfoPtr_Prepare_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677135);
		NativeMethodInfoPtr_SubmitItemAction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677136);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677137);
		NativeMethodInfoPtr_RefreshDescription_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677138);
		NativeMethodInfoPtr_OnItemSelect_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677139);
		NativeMethodInfoPtr_HandleGridInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677140);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677141);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomePage>.NativeClassPtr, 100677142);
	}

	public HomePage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
