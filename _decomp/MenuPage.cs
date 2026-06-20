using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class MenuPage : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PageName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Items;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSelectedItemIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalState;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedState;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentValueON;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentValueOFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_prepared;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawNextPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawPreviousPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_pagePageIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalStateHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedStateHeight;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnPage_Public_MenuPage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunks_Public_ArrayOf_List_1_DebugMenuItem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePageSelectedIndex_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMenuItemAction_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPreviousPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextPageOnPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousPageOnPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarFromCarLoader_Private_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MenuPage>.NativeClassPtr));

	public unsafe string PageName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PageName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PageName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe List<DebugMenuItem> Items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<DebugMenuItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int CurrentSelectedItemIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentSelectedItemIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentSelectedItemIndex)) = num;
		}
	}

	public unsafe static GUIStyle normalState
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_normalState, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GUIStyle(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_normalState, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GUIStyle selectedState
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selectedState, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GUIStyle(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selectedState, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GUIStyle currentValueON
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentValueON, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GUIStyle(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentValueON, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GUIStyle currentValueOFF
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentValueOFF, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GUIStyle(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentValueOFF, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static bool prepared
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_prepared, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_prepared, &flag);
		}
	}

	public unsafe bool drawNextPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawNextPage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawNextPage)) = flag;
		}
	}

	public unsafe bool drawPreviousPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawPreviousPage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawPreviousPage)) = flag;
		}
	}

	public unsafe int pagePageIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pagePageIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pagePageIndex)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<List<DebugMenuItem>> chunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<List<DebugMenuItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static float normalStateHeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_normalStateHeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_normalStateHeight, &num);
		}
	}

	public unsafe static float selectedStateHeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selectedStateHeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selectedStateHeight, &num);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95002, XrefRangeEnd = 95085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95085, XrefRangeEnd = 95086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MenuPage ReturnPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnPage_Public_MenuPage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new MenuPage(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95086, XrefRangeEnd = 95235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95254, RefRangeEnd = 95255, XrefRangeStart = 95235, XrefRangeEnd = 95254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<List<DebugMenuItem>> GetChunks(int itemsInChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemsInChunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunks_Public_ArrayOf_List_1_DebugMenuItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<List<DebugMenuItem>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95255, XrefRangeEnd = 95259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePageSelectedIndex(int change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&change);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePageSelectedIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95259, XrefRangeEnd = 95261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeMenuItemAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeMenuItemAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95261, XrefRangeEnd = 95262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnToPreviousPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnToPreviousPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95262, XrefRangeEnd = 95264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextPageOnPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextPageOnPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95264, XrefRangeEnd = 95265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreviousPageOnPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousPageOnPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95294, RefRangeEnd = 95295, XrefRangeStart = 95265, XrefRangeEnd = 95294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCarFromCarLoader(string carloaderGameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carloaderGameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarFromCarLoader_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95296, RefRangeEnd = 95298, XrefRangeStart = 95295, XrefRangeEnd = 95296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MenuPage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuPage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MenuPage()
	{
		Il2CppClassPointerStore<MenuPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MenuPage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuPage>.NativeClassPtr);
		NativeFieldInfoPtr_PageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "PageName");
		NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "Items");
		NativeFieldInfoPtr_CurrentSelectedItemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "CurrentSelectedItemIndex");
		NativeFieldInfoPtr_normalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "normalState");
		NativeFieldInfoPtr_selectedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "selectedState");
		NativeFieldInfoPtr_currentValueON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "currentValueON");
		NativeFieldInfoPtr_currentValueOFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "currentValueOFF");
		NativeFieldInfoPtr_prepared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "prepared");
		NativeFieldInfoPtr_drawNextPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "drawNextPage");
		NativeFieldInfoPtr_drawPreviousPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "drawPreviousPage");
		NativeFieldInfoPtr_pagePageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "pagePageIndex");
		NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "chunks");
		NativeFieldInfoPtr_normalStateHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "normalStateHeight");
		NativeFieldInfoPtr_selectedStateHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, "selectedStateHeight");
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668811);
		NativeMethodInfoPtr_ReturnPage_Public_MenuPage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668812);
		NativeMethodInfoPtr_DrawPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668813);
		NativeMethodInfoPtr_GetChunks_Public_ArrayOf_List_1_DebugMenuItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668814);
		NativeMethodInfoPtr_UpdatePageSelectedIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668815);
		NativeMethodInfoPtr_InvokeMenuItemAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668816);
		NativeMethodInfoPtr_ReturnToPreviousPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668817);
		NativeMethodInfoPtr_NextPageOnPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668818);
		NativeMethodInfoPtr_PreviousPageOnPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668819);
		NativeMethodInfoPtr_GetCarFromCarLoader_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668820);
		NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668821);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuPage>.NativeClassPtr, 100668822);
	}

	public MenuPage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
