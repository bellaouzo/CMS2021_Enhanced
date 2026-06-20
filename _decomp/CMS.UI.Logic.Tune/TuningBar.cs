using System;
using System.Runtime.CompilerServices;
using CMS.UI.Events;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CMS.UI.Logic.Tune;

public class TuningBar : ListItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_fill;

	private static readonly System.IntPtr NativeFieldInfoPtr_number;

	private static readonly System.IntPtr NativeFieldInfoPtr_upArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_downArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlusSign;

	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_carbTuning;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeFieldInfoPtr__Index_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMouseEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_TuningBarEvent;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Index_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Index_Public_set_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseMouseEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UseMouseEvents_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareArrows_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowArrows_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideArrows_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForCarbTuning_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecrementValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimulateIncrementValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimulateDecrementValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JustIncrement_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JustDecrement_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFillForCurrentValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFillForValue_Private_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinValue_Private_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxValue_Private_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TuningBar>.NativeClassPtr));

	public unsafe GameObject selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image fill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text number
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_number);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_number), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AdvancedArrow upArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AdvancedArrow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upArrow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AdvancedArrow downArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AdvancedArrow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downArrow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static string PlusSign
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlusSign, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlusSign, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe short value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
		}
	}

	public unsafe bool carbTuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carbTuning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carbTuning)) = flag;
		}
	}

	public unsafe bool isActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
		}
	}

	public unsafe byte _Index_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Index_k__BackingField);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Index_k__BackingField)) = b;
		}
	}

	public unsafe bool useMouseEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMouseEvents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMouseEvents)) = flag;
		}
	}

	public unsafe ButtonEvent<TuningBar> ButtonEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ButtonEvent<TuningBar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonEvent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TuningBarEvent TuningBarEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningBarEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TuningBarEvent(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningBarEvent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe short Value
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(short*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe byte Index
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Index_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Index_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool UseMouseEvents
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseMouseEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 185125, RefRangeEnd = 185133, XrefRangeStart = 185119, XrefRangeEnd = 185125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UseMouseEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185133, XrefRangeEnd = 185140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPointerClick(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185140, XrefRangeEnd = 185147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185147, XrefRangeEnd = 185153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe bool CanSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void EnableSelection(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 185165, RefRangeEnd = 185169, XrefRangeStart = 185153, XrefRangeEnd = 185165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareArrows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareArrows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185183, RefRangeEnd = 185184, XrefRangeStart = 185169, XrefRangeEnd = 185183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowArrows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowArrows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185208, RefRangeEnd = 185209, XrefRangeStart = 185184, XrefRangeEnd = 185208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideArrows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideArrows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185218, RefRangeEnd = 185221, XrefRangeStart = 185209, XrefRangeEnd = 185218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActive(bool active = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&active);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetForCarbTuning(bool set)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&set);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForCarbTuning_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185221, XrefRangeEnd = 185222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue(short newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185222, XrefRangeEnd = 185226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185226, XrefRangeEnd = 185230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecrementValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecrementValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185230, XrefRangeEnd = 185234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SimulateIncrementValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimulateIncrementValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185234, XrefRangeEnd = 185238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SimulateDecrementValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimulateDecrementValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185239, RefRangeEnd = 185241, XrefRangeStart = 185238, XrefRangeEnd = 185239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JustIncrement(bool updateFill = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateFill);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JustIncrement_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185242, RefRangeEnd = 185244, XrefRangeStart = 185241, XrefRangeEnd = 185242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JustDecrement(bool updateFill = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateFill);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JustDecrement_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185244, XrefRangeEnd = 185245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFillForCurrentValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFillForCurrentValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 185270, RefRangeEnd = 185288, XrefRangeStart = 185245, XrefRangeEnd = 185270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFillForValue(short newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFillForValue_Private_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe short GetMinValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinValue_Private_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(short*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe short GetMaxValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxValue_Private_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(short*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185294, RefRangeEnd = 185296, XrefRangeStart = 185288, XrefRangeEnd = 185294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TuningBar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TuningBar>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TuningBar()
	{
		Il2CppClassPointerStore<TuningBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Tune", "TuningBar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TuningBar>.NativeClassPtr);
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "fill");
		NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "number");
		NativeFieldInfoPtr_upArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "upArrow");
		NativeFieldInfoPtr_downArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "downArrow");
		NativeFieldInfoPtr_PlusSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "PlusSign");
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "value");
		NativeFieldInfoPtr_carbTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "carbTuning");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "isActive");
		NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "<Index>k__BackingField");
		NativeFieldInfoPtr_useMouseEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "useMouseEvents");
		NativeFieldInfoPtr_ButtonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "ButtonEvent");
		NativeFieldInfoPtr_TuningBarEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, "TuningBarEvent");
		NativeMethodInfoPtr_get_Value_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676849);
		NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676850);
		NativeMethodInfoPtr_get_Index_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676851);
		NativeMethodInfoPtr_set_Index_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676852);
		NativeMethodInfoPtr_get_UseMouseEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676853);
		NativeMethodInfoPtr_set_UseMouseEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676854);
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676855);
		NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676856);
		NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676857);
		NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676858);
		NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676859);
		NativeMethodInfoPtr_PrepareArrows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676860);
		NativeMethodInfoPtr_ShowArrows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676861);
		NativeMethodInfoPtr_HideArrows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676862);
		NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676863);
		NativeMethodInfoPtr_SetForCarbTuning_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676864);
		NativeMethodInfoPtr_SetValue_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676865);
		NativeMethodInfoPtr_IncrementValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676866);
		NativeMethodInfoPtr_DecrementValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676867);
		NativeMethodInfoPtr_SimulateIncrementValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676868);
		NativeMethodInfoPtr_SimulateDecrementValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676869);
		NativeMethodInfoPtr_JustIncrement_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676870);
		NativeMethodInfoPtr_JustDecrement_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676871);
		NativeMethodInfoPtr_UpdateFillForCurrentValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676872);
		NativeMethodInfoPtr_UpdateFillForValue_Private_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676873);
		NativeMethodInfoPtr_GetMinValue_Private_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676874);
		NativeMethodInfoPtr_GetMaxValue_Private_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676875);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676876);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningBar>.NativeClassPtr, 100676877);
	}

	public TuningBar(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
