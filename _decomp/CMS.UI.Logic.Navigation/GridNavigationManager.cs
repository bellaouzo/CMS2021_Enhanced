using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Logic.Navigation;

public class GridNavigationManager : NavigationManager
{
	private static readonly System.IntPtr NativeFieldInfoPtr_elements;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelectedColumn;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchForRightItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPageEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnItemSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_temp;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_areEventsRegistered;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSearchForRightItem_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirst_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrent_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentWithoutSound_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectCurrent_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectAll_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsItemSelected_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentItemSelected_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSelect_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstItemInRow_Public_Vector2Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLastItemInRow_Public_Vector2Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentColumn_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentRow_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPos_Public_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentGridItem_Public_GridItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridItem_Public_GridItem_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfItemExists_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Private_Boolean_byref_Player_byref_Vector2Int_Direction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNextItem_Private_Vector2Int_Direction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNextItem_Public_GridItem_GridItem_Direction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindDownItem_Private_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindDownItem_Private_Vector2Int_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUpItem_Private_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUpItem_Private_Vector2Int_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRightItem_Private_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRightItem_Private_Vector2Int_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLeftItem_Private_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLeftItem_Private_Vector2Int_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstSelectableItem_Private_Vector2Int_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AreEventsRegistered_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeItems_Public_Static_Void_byref_ArrayOf_GridItems_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillGridItems_Public_Static_Void_byref_ArrayOf_GridItems_ArrayOf_GridItem_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItemsEvents_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGridItems_Public_ArrayOf_GridItems_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGridItems_Public_Void_ArrayOf_GridItems_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnItemMouseHover_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<GridItems> elements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GridItems>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentSelectedColumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedColumn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedColumn)) = num;
		}
	}

	public unsafe bool searchForRightItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchForRightItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchForRightItem)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<byte, byte, byte> OnPageEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPageEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<byte, byte, byte>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPageEvent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<int, int> OnItemSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnItemSelect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int, int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnItemSelect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2Int temp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temp);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temp)) = vector2Int;
		}
	}

	public unsafe float holdTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdTime)) = num;
		}
	}

	public unsafe bool areEventsRegistered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areEventsRegistered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areEventsRegistered)) = flag;
		}
	}

	public unsafe bool AreEventsRegistered
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AreEventsRegistered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	public unsafe void EnableSearchForRightItem(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSearchForRightItem_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSelected(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelected_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194979, XrefRangeEnd = 194995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SelectFirst()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SelectFirst_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194995, XrefRangeEnd = 195019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SelectCurrent(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SelectCurrent_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 195043, RefRangeEnd = 195055, XrefRangeStart = 195019, XrefRangeEnd = 195043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectCurrentWithoutSound(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectCurrentWithoutSound_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195055, XrefRangeEnd = 195056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DeselectCurrent(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DeselectCurrent_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 195059, RefRangeEnd = 195060, XrefRangeStart = 195056, XrefRangeEnd = 195059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeselectAll(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeselectAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 195076, RefRangeEnd = 195106, XrefRangeStart = 195060, XrefRangeEnd = 195076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Select(int column, int row, bool runOnItemSelect = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &runOnItemSelect;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Select_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 195119, RefRangeEnd = 195124, XrefRangeStart = 195106, XrefRangeEnd = 195119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deselect(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deselect_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195124, XrefRangeEnd = 195137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsItemSelected(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsItemSelected_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195137, XrefRangeEnd = 195150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool IsCurrentItemSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsCurrentItemSelected_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195150, XrefRangeEnd = 195163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanSelect(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSelect_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 195181, RefRangeEnd = 195184, XrefRangeStart = 195163, XrefRangeEnd = 195181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindFirstItemInRow(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstItemInRow_Public_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 195204, RefRangeEnd = 195207, XrefRangeStart = 195184, XrefRangeEnd = 195204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindLastItemInRow(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLastItemInRow_Public_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetCurrentColumn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentColumn_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetCurrentRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentRow_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector2Int GetCurrentPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentPos_Public_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 195207, RefRangeEnd = 195246, XrefRangeStart = 195207, XrefRangeEnd = 195207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridItem GetCurrentGridItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentGridItem_Public_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GridItem(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 195246, RefRangeEnd = 195261, XrefRangeStart = 195246, XrefRangeEnd = 195246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridItem GetGridItem(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridItem_Public_GridItem_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GridItem(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195261, XrefRangeEnd = 195273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIfItemExists(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfItemExists_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195273, XrefRangeEnd = 195349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 195421, RefRangeEnd = 195430, XrefRangeStart = 195349, XrefRangeEnd = 195421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 195455, RefRangeEnd = 195457, XrefRangeStart = 195430, XrefRangeEnd = 195455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput(ref Player player, out Vector2Int position, Direction direction)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref position);
		*(Direction**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Private_Boolean_byref_Player_byref_Vector2Int_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		player = ((intPtr2 == (System.IntPtr)0) ? ((Player)null) : new Player(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 195461, RefRangeEnd = 195464, XrefRangeStart = 195457, XrefRangeEnd = 195461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindNextItem(Direction direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direction);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNextItem_Private_Vector2Int_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe GridItem FindNextItem(GridItem gridItem, Direction direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridItem);
		*(Direction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNextItem_Public_GridItem_GridItem_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GridItem(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195464, XrefRangeEnd = 195470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindDownItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDownItem_Private_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 195486, RefRangeEnd = 195489, XrefRangeStart = 195470, XrefRangeEnd = 195486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindDownItem(int column, int row, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDownItem_Private_Vector2Int_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195489, XrefRangeEnd = 195490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindUpItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUpItem_Private_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 195510, RefRangeEnd = 195515, XrefRangeStart = 195490, XrefRangeEnd = 195510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindUpItem(int column, int row, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUpItem_Private_Vector2Int_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195515, XrefRangeEnd = 195517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindRightItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRightItem_Private_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 195533, RefRangeEnd = 195536, XrefRangeStart = 195517, XrefRangeEnd = 195533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindRightItem(int column, int row, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRightItem_Private_Vector2Int_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195536, XrefRangeEnd = 195537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindLeftItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLeftItem_Private_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 195557, RefRangeEnd = 195564, XrefRangeStart = 195537, XrefRangeEnd = 195557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindLeftItem(int column, int row, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLeftItem_Private_Vector2Int_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 195575, RefRangeEnd = 195577, XrefRangeStart = 195564, XrefRangeEnd = 195575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int FindFirstSelectableItem(int column, int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&column);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstSelectableItem_Private_Vector2Int_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195577, XrefRangeEnd = 195578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195578, XrefRangeEnd = 195585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeItems(out Il2CppReferenceArray<GridItems> gridItems, int rows, int columns)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(gridItems);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rows;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &columns;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeItems_Public_Static_Void_byref_ArrayOf_GridItems_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195585, XrefRangeEnd = 195586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillGridItems(ref Il2CppReferenceArray<GridItems> elements, Il2CppReferenceArray<GridItem> children, int rows, int columns)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(elements);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(children);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rows;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &columns;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillGridItems_Public_Static_Void_byref_ArrayOf_GridItems_ArrayOf_GridItem_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 195610, RefRangeEnd = 195617, XrefRangeStart = 195586, XrefRangeEnd = 195610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterItemsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterItemsEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Il2CppReferenceArray<GridItems> GetGridItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGridItems_Public_ArrayOf_GridItems_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GridItems>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 195620, RefRangeEnd = 195622, XrefRangeStart = 195617, XrefRangeEnd = 195620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGridItems(Il2CppReferenceArray<GridItems> items)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGridItems_Public_Void_ArrayOf_GridItems_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195622, XrefRangeEnd = 195623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnItemMouseHover(int X, int Y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&X);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &Y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnItemMouseHover_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195623, XrefRangeEnd = 195626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GridNavigationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GridNavigationManager()
	{
		Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Navigation", "GridNavigationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr);
		NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "elements");
		NativeFieldInfoPtr_currentSelectedColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "currentSelectedColumn");
		NativeFieldInfoPtr_searchForRightItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "searchForRightItem");
		NativeFieldInfoPtr_OnPageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "OnPageEvent");
		NativeFieldInfoPtr_OnItemSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "OnItemSelect");
		NativeFieldInfoPtr_temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "temp");
		NativeFieldInfoPtr_holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "holdTime");
		NativeFieldInfoPtr_areEventsRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, "areEventsRegistered");
		NativeMethodInfoPtr_EnableSearchForRightItem_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677854);
		NativeMethodInfoPtr_SetSelected_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677855);
		NativeMethodInfoPtr_SelectFirst_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677856);
		NativeMethodInfoPtr_SelectCurrent_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677857);
		NativeMethodInfoPtr_SelectCurrentWithoutSound_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677858);
		NativeMethodInfoPtr_DeselectCurrent_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677859);
		NativeMethodInfoPtr_DeselectAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677860);
		NativeMethodInfoPtr_Select_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677861);
		NativeMethodInfoPtr_Deselect_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677862);
		NativeMethodInfoPtr_IsItemSelected_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677863);
		NativeMethodInfoPtr_IsCurrentItemSelected_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677864);
		NativeMethodInfoPtr_CanSelect_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677865);
		NativeMethodInfoPtr_FindFirstItemInRow_Public_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677866);
		NativeMethodInfoPtr_FindLastItemInRow_Public_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677867);
		NativeMethodInfoPtr_GetCurrentColumn_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677868);
		NativeMethodInfoPtr_GetCurrentRow_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677869);
		NativeMethodInfoPtr_GetCurrentPos_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677870);
		NativeMethodInfoPtr_GetCurrentGridItem_Public_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677871);
		NativeMethodInfoPtr_GetGridItem_Public_GridItem_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677872);
		NativeMethodInfoPtr_CheckIfItemExists_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677873);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677874);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677875);
		NativeMethodInfoPtr_HandleInput_Private_Boolean_byref_Player_byref_Vector2Int_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677876);
		NativeMethodInfoPtr_FindNextItem_Private_Vector2Int_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677877);
		NativeMethodInfoPtr_FindNextItem_Public_GridItem_GridItem_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677878);
		NativeMethodInfoPtr_FindDownItem_Private_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677879);
		NativeMethodInfoPtr_FindDownItem_Private_Vector2Int_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677880);
		NativeMethodInfoPtr_FindUpItem_Private_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677881);
		NativeMethodInfoPtr_FindUpItem_Private_Vector2Int_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677882);
		NativeMethodInfoPtr_FindRightItem_Private_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677883);
		NativeMethodInfoPtr_FindRightItem_Private_Vector2Int_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677884);
		NativeMethodInfoPtr_FindLeftItem_Private_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677885);
		NativeMethodInfoPtr_FindLeftItem_Private_Vector2Int_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677886);
		NativeMethodInfoPtr_FindFirstSelectableItem_Private_Vector2Int_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677887);
		NativeMethodInfoPtr_get_AreEventsRegistered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677888);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677889);
		NativeMethodInfoPtr_InitializeItems_Public_Static_Void_byref_ArrayOf_GridItems_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677890);
		NativeMethodInfoPtr_FillGridItems_Public_Static_Void_byref_ArrayOf_GridItems_ArrayOf_GridItem_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677891);
		NativeMethodInfoPtr_RegisterItemsEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677892);
		NativeMethodInfoPtr_GetGridItems_Public_ArrayOf_GridItems_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677893);
		NativeMethodInfoPtr_SetGridItems_Public_Void_ArrayOf_GridItems_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677894);
		NativeMethodInfoPtr_OnItemMouseHover_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677895);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridNavigationManager>.NativeClassPtr, 100677896);
	}

	public GridNavigationManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
