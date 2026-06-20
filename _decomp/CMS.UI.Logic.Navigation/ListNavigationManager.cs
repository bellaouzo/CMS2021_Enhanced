using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Navigation;

public class ListNavigationManager : NavigationManager
{
	private static readonly System.IntPtr NativeFieldInfoPtr_elements;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientation;

	private static readonly System.IntPtr NativeFieldInfoPtr_loop;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableMouseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnItemSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPageEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_temp;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_areEventsRegistered;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableMouseEvent_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirst_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirstAvailable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirstAvailableWithoutSound_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectLast_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectLastAvailable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentIfAvailable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrent_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentWithoutSound_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectCurrent_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectAll_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectAll_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectWithoutSound_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsItemSelected_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentItemSelected_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSelect_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstItemInRow_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLastItemInRow_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentRow_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentListItem_Public_ListItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListItem_Public_ListItem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfItemExists_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Private_Boolean_byref_Player_byref_Int32_Direction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNextItem_Private_Int32_Direction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindDownItem_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindDownItem_Private_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUpItem_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUpItem_Private_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstSelectableItem_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AreEventsRegistered_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItemsEvents_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListItems_Public_ArrayOf_ListItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetListItems_Public_Void_ArrayOf_ListItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnItemMouseHover_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<ListItem> elements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ListItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NavigationOrientation orientation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientation);
			return *(NavigationOrientation*)num;
		}
		set
		{
			*(NavigationOrientation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientation)) = navigationOrientation;
		}
	}

	public unsafe bool loop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loop)) = flag;
		}
	}

	public unsafe bool disableMouseEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMouseEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMouseEvent)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<int> OnItemSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnItemSelect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnItemSelect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<byte, byte> OnPageEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPageEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<byte, byte>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPageEvent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int temp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temp)) = num;
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

	public unsafe bool DisableMouseEvent
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisableMouseEvent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
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
	public unsafe void SetSelected(int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195709, XrefRangeEnd = 195725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SelectFirst()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SelectFirst_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 195727, RefRangeEnd = 195729, XrefRangeStart = 195725, XrefRangeEnd = 195727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectFirstAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectFirstAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SelectFirstAvailableWithoutSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectFirstAvailableWithoutSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 195745, RefRangeEnd = 195746, XrefRangeStart = 195729, XrefRangeEnd = 195745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectLast()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectLast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195746, XrefRangeEnd = 195749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectLastAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectLastAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195749, XrefRangeEnd = 195755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectCurrentIfAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectCurrentIfAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195755, XrefRangeEnd = 195775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SelectCurrent(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SelectCurrent_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 195795, RefRangeEnd = 195802, XrefRangeStart = 195775, XrefRangeEnd = 195795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195802, XrefRangeEnd = 195803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DeselectCurrent(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DeselectCurrent_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 195821, RefRangeEnd = 195823, XrefRangeStart = 195803, XrefRangeEnd = 195821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeselectAll(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeselectAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195823, XrefRangeEnd = 195825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeselectAll(int exception, bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&exception);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeselectAll_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 195841, RefRangeEnd = 195880, XrefRangeStart = 195825, XrefRangeEnd = 195841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Select(int row, bool mouseEvent = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mouseEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Select_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 195896, RefRangeEnd = 195904, XrefRangeStart = 195880, XrefRangeEnd = 195896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectWithoutSound(int row, bool mouseEvent = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mouseEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectWithoutSound_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 195917, RefRangeEnd = 195922, XrefRangeStart = 195904, XrefRangeEnd = 195917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deselect(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deselect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195922, XrefRangeEnd = 195935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsItemSelected(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsItemSelected_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195935, XrefRangeEnd = 195948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195948, XrefRangeEnd = 195961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanSelect(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSelect_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 195978, RefRangeEnd = 195985, XrefRangeStart = 195961, XrefRangeEnd = 195978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindFirstItemInRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstItemInRow_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 196001, RefRangeEnd = 196003, XrefRangeStart = 195985, XrefRangeEnd = 196001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindLastItemInRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLastItemInRow_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
	public unsafe ListItem GetCurrentListItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentListItem_Public_ListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ListItem(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 196003, RefRangeEnd = 196010, XrefRangeStart = 196003, XrefRangeEnd = 196003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ListItem GetListItem(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListItem_Public_ListItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ListItem(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196010, XrefRangeEnd = 196022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIfItemExists(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfItemExists_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196022, XrefRangeEnd = 196032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 196035, RefRangeEnd = 196044, XrefRangeStart = 196032, XrefRangeEnd = 196035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 196063, RefRangeEnd = 196067, XrefRangeStart = 196044, XrefRangeEnd = 196063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput(ref Player player, out int position, Direction direction)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref position);
		*(Direction**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Private_Boolean_byref_Player_byref_Int32_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		player = ((intPtr2 == (System.IntPtr)0) ? ((Player)null) : new Player(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196083, RefRangeEnd = 196084, XrefRangeStart = 196067, XrefRangeEnd = 196083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindNextItem(Direction direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direction);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNextItem_Private_Int32_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196084, XrefRangeEnd = 196085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindDownItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDownItem_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196100, RefRangeEnd = 196101, XrefRangeStart = 196085, XrefRangeEnd = 196100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindDownItem(int row, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDownItem_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196101, XrefRangeEnd = 196117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindUpItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUpItem_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196117, XrefRangeEnd = 196133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindUpItem(int row, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUpItem_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 196134, RefRangeEnd = 196136, XrefRangeStart = 196133, XrefRangeEnd = 196134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindFirstSelectableItem(int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstSelectableItem_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196136, XrefRangeEnd = 196137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 196161, RefRangeEnd = 196166, XrefRangeStart = 196137, XrefRangeEnd = 196161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe Il2CppReferenceArray<ListItem> GetListItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListItems_Public_ArrayOf_ListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ListItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 196171, RefRangeEnd = 196173, XrefRangeStart = 196166, XrefRangeEnd = 196171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetListItems(Il2CppReferenceArray<ListItem> items)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetListItems_Public_Void_ArrayOf_ListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196173, XrefRangeEnd = 196174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnItemMouseHover(int Y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnItemMouseHover_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ListNavigationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ListNavigationManager()
	{
		Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Navigation", "ListNavigationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr);
		NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "elements");
		NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "orientation");
		NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "loop");
		NativeFieldInfoPtr_disableMouseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "disableMouseEvent");
		NativeFieldInfoPtr_OnItemSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "OnItemSelect");
		NativeFieldInfoPtr_OnPageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "OnPageEvent");
		NativeFieldInfoPtr_temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "temp");
		NativeFieldInfoPtr_holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "holdTime");
		NativeFieldInfoPtr_areEventsRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, "areEventsRegistered");
		NativeMethodInfoPtr_set_DisableMouseEvent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677903);
		NativeMethodInfoPtr_SetSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677904);
		NativeMethodInfoPtr_SelectFirst_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677905);
		NativeMethodInfoPtr_SelectFirstAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677906);
		NativeMethodInfoPtr_SelectFirstAvailableWithoutSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677907);
		NativeMethodInfoPtr_SelectLast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677908);
		NativeMethodInfoPtr_SelectLastAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677909);
		NativeMethodInfoPtr_SelectCurrentIfAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677910);
		NativeMethodInfoPtr_SelectCurrent_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677911);
		NativeMethodInfoPtr_SelectCurrentWithoutSound_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677912);
		NativeMethodInfoPtr_DeselectCurrent_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677913);
		NativeMethodInfoPtr_DeselectAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677914);
		NativeMethodInfoPtr_DeselectAll_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677915);
		NativeMethodInfoPtr_Select_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677916);
		NativeMethodInfoPtr_SelectWithoutSound_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677917);
		NativeMethodInfoPtr_Deselect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677918);
		NativeMethodInfoPtr_IsItemSelected_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677919);
		NativeMethodInfoPtr_IsCurrentItemSelected_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677920);
		NativeMethodInfoPtr_CanSelect_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677921);
		NativeMethodInfoPtr_FindFirstItemInRow_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677922);
		NativeMethodInfoPtr_FindLastItemInRow_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677923);
		NativeMethodInfoPtr_GetCurrentRow_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677924);
		NativeMethodInfoPtr_GetCurrentListItem_Public_ListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677925);
		NativeMethodInfoPtr_GetListItem_Public_ListItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677926);
		NativeMethodInfoPtr_CheckIfItemExists_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677927);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677928);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677929);
		NativeMethodInfoPtr_HandleInput_Private_Boolean_byref_Player_byref_Int32_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677930);
		NativeMethodInfoPtr_FindNextItem_Private_Int32_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677931);
		NativeMethodInfoPtr_FindDownItem_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677932);
		NativeMethodInfoPtr_FindDownItem_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677933);
		NativeMethodInfoPtr_FindUpItem_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677934);
		NativeMethodInfoPtr_FindUpItem_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677935);
		NativeMethodInfoPtr_FindFirstSelectableItem_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677936);
		NativeMethodInfoPtr_get_AreEventsRegistered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677937);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677938);
		NativeMethodInfoPtr_RegisterItemsEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677939);
		NativeMethodInfoPtr_GetListItems_Public_ArrayOf_ListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677940);
		NativeMethodInfoPtr_SetListItems_Public_Void_ArrayOf_ListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677941);
		NativeMethodInfoPtr_OnItemMouseHover_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677942);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListNavigationManager>.NativeClassPtr, 100677943);
	}

	public ListNavigationManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
