using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace CMS.UI.Controls;

public class StringSelector : ListItem
{
	[System.Serializable]
	public class ValueChangeEvent : UnityEvent<int>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ValueChangeEvent>.NativeClassPtr));

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211453, XrefRangeEnd = 211455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueChangeEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueChangeEvent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static ValueChangeEvent()
		{
			Il2CppClassPointerStore<ValueChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "ValueChangeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueChangeEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueChangeEvent>.NativeClassPtr, 100679182);
		}

		public ValueChangeEvent(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_optionText;

	private static readonly System.IntPtr NativeFieldInfoPtr_optionBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_options;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasCustomSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelectedOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_hideArrowsOnDeselect;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnMouseExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_ValueChangedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLeftButtonHolden;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftArrowHolden;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftButtonHoldTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRightButtonHolden;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightArrowHolden;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightButtonHoldTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasNextItem_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPreviousItem_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLoop_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecrementValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateText_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisabled_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RightArrowDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RightArrowUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeftArrowDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeftArrowUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableArrows_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLeftArrowEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRightArrowEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLeftArrowEnabled_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRightArrowEnabled_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableArrowInteractivity_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLeftArrowInteractivity_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableRightArrowInteractivity_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyArrowHovered_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshArrows_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleValueChangeInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RightButtonLogic_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RightButtonEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeftButtonLogic_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeftButtonEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<StringSelector>.NativeClassPtr));

	public unsafe Text optionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image optionBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionBackground), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AdvancedArrow leftArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AdvancedArrow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftArrow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AdvancedArrow rightArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AdvancedArrow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightArrow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

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

	public unsafe List<string> options
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool HasCustomSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasCustomSelection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasCustomSelection)) = flag;
		}
	}

	public unsafe int currentSelectedOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedOption);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedOption)) = num;
		}
	}

	public unsafe bool isDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisabled)) = flag;
		}
	}

	public unsafe bool loopValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopValues);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopValues)) = flag;
		}
	}

	public unsafe bool hideArrowsOnDeselect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideArrowsOnDeselect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideArrowsOnDeselect)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<int> OnMouseExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseExit), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ValueChangeEvent ValueChangedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueChangedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ValueChangeEvent(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueChangedEvent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isLeftButtonHolden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLeftButtonHolden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLeftButtonHolden)) = flag;
		}
	}

	public unsafe bool leftArrowHolden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftArrowHolden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftArrowHolden)) = flag;
		}
	}

	public unsafe float leftButtonHoldTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftButtonHoldTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftButtonHoldTime)) = num;
		}
	}

	public unsafe bool isRightButtonHolden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRightButtonHolden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRightButtonHolden)) = flag;
		}
	}

	public unsafe bool rightArrowHolden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightArrowHolden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightArrowHolden)) = flag;
		}
	}

	public unsafe float rightButtonHoldTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightButtonHoldTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightButtonHoldTime)) = num;
		}
	}

	public unsafe int Current
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211455, XrefRangeEnd = 211458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPointerEnter(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211458, XrefRangeEnd = 211461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPointerExit(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211461, XrefRangeEnd = 211464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211464, XrefRangeEnd = 211465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211465, XrefRangeEnd = 211466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool CanSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211466, XrefRangeEnd = 211467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 211508, RefRangeEnd = 211511, XrefRangeStart = 211467, XrefRangeEnd = 211508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSelection(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211511, XrefRangeEnd = 211512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasNextItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasNextItem_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool HasPreviousItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPreviousItem_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 211517, RefRangeEnd = 211538, XrefRangeStart = 211512, XrefRangeEnd = 211517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare(Vector2 minSize, Vector2 maxSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minSize);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void EnableLoop(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLoop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 211540, RefRangeEnd = 211544, XrefRangeStart = 211538, XrefRangeEnd = 211540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 211548, RefRangeEnd = 211550, XrefRangeStart = 211544, XrefRangeEnd = 211548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecrementValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecrementValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 211553, RefRangeEnd = 211563, XrefRangeStart = 211550, XrefRangeEnd = 211553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue(int index, bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEvent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 211567, RefRangeEnd = 211578, XrefRangeStart = 211563, XrefRangeEnd = 211567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateText(bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sendEvent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateText_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void UpdateText(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 211603, RefRangeEnd = 211620, XrefRangeStart = 211578, XrefRangeEnd = 211603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDisabled(bool disable = true, bool animate = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&disable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &animate;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisabled_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void RightArrowDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RightArrowDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211620, XrefRangeEnd = 211621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RightArrowUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RightArrowUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void LeftArrowDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeftArrowDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211621, XrefRangeEnd = 211622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeftArrowUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeftArrowUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 211630, RefRangeEnd = 211648, XrefRangeStart = 211622, XrefRangeEnd = 211630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableArrows(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableArrows_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 211665, RefRangeEnd = 211667, XrefRangeStart = 211648, XrefRangeEnd = 211665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLeftArrowEnabled(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLeftArrowEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 211684, RefRangeEnd = 211686, XrefRangeStart = 211667, XrefRangeEnd = 211684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRightArrowEnabled(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRightArrowEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211686, XrefRangeEnd = 211695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLeftArrowEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLeftArrowEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211695, XrefRangeEnd = 211704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRightArrowEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRightArrowEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211704, XrefRangeEnd = 211707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableArrowInteractivity(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableArrowInteractivity_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211707, XrefRangeEnd = 211709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableLeftArrowInteractivity(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLeftArrowInteractivity_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211709, XrefRangeEnd = 211711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableRightArrowInteractivity(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableRightArrowInteractivity_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsAnyArrowHovered()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyArrowHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 211719, RefRangeEnd = 211751, XrefRangeStart = 211711, XrefRangeEnd = 211719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshArrows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshArrows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211751, XrefRangeEnd = 211755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleValueChangeInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleValueChangeInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211755, XrefRangeEnd = 211759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RightButtonLogic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RightButtonLogic_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 211777, RefRangeEnd = 211780, XrefRangeStart = 211759, XrefRangeEnd = 211777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RightButtonEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RightButtonEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211780, XrefRangeEnd = 211784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LeftButtonLogic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeftButtonLogic_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 211801, RefRangeEnd = 211802, XrefRangeStart = 211784, XrefRangeEnd = 211801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeftButtonEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeftButtonEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 211806, RefRangeEnd = 211831, XrefRangeStart = 211802, XrefRangeEnd = 211806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211831, XrefRangeEnd = 211840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StringSelector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringSelector>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StringSelector()
	{
		Il2CppClassPointerStore<StringSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Controls", "StringSelector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringSelector>.NativeClassPtr);
		NativeFieldInfoPtr_optionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "optionText");
		NativeFieldInfoPtr_optionBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "optionBackground");
		NativeFieldInfoPtr_leftArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "leftArrow");
		NativeFieldInfoPtr_rightArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "rightArrow");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "options");
		NativeFieldInfoPtr_HasCustomSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "HasCustomSelection");
		NativeFieldInfoPtr_currentSelectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "currentSelectedOption");
		NativeFieldInfoPtr_isDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "isDisabled");
		NativeFieldInfoPtr_loopValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "loopValues");
		NativeFieldInfoPtr_hideArrowsOnDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "hideArrowsOnDeselect");
		NativeFieldInfoPtr_OnMouseExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "OnMouseExit");
		NativeFieldInfoPtr_ValueChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "ValueChangedEvent");
		NativeFieldInfoPtr_isLeftButtonHolden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "isLeftButtonHolden");
		NativeFieldInfoPtr_leftArrowHolden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "leftArrowHolden");
		NativeFieldInfoPtr_leftButtonHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "leftButtonHoldTime");
		NativeFieldInfoPtr_isRightButtonHolden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "isRightButtonHolden");
		NativeFieldInfoPtr_rightArrowHolden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "rightArrowHolden");
		NativeFieldInfoPtr_rightButtonHoldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, "rightButtonHoldTime");
		NativeMethodInfoPtr_get_Current_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679140);
		NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679141);
		NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679142);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679143);
		NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679144);
		NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679145);
		NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679146);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679147);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679148);
		NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679149);
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679150);
		NativeMethodInfoPtr_HasNextItem_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679151);
		NativeMethodInfoPtr_HasPreviousItem_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679152);
		NativeMethodInfoPtr_Prepare_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679153);
		NativeMethodInfoPtr_EnableLoop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679154);
		NativeMethodInfoPtr_IncrementValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679155);
		NativeMethodInfoPtr_DecrementValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679156);
		NativeMethodInfoPtr_SetValue_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679157);
		NativeMethodInfoPtr_UpdateText_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679158);
		NativeMethodInfoPtr_UpdateText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679159);
		NativeMethodInfoPtr_SetDisabled_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679160);
		NativeMethodInfoPtr_RightArrowDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679161);
		NativeMethodInfoPtr_RightArrowUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679162);
		NativeMethodInfoPtr_LeftArrowDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679163);
		NativeMethodInfoPtr_LeftArrowUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679164);
		NativeMethodInfoPtr_EnableArrows_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679165);
		NativeMethodInfoPtr_SetLeftArrowEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679166);
		NativeMethodInfoPtr_SetRightArrowEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679167);
		NativeMethodInfoPtr_IsLeftArrowEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679168);
		NativeMethodInfoPtr_IsRightArrowEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679169);
		NativeMethodInfoPtr_EnableArrowInteractivity_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679170);
		NativeMethodInfoPtr_EnableLeftArrowInteractivity_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679171);
		NativeMethodInfoPtr_EnableRightArrowInteractivity_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679172);
		NativeMethodInfoPtr_IsAnyArrowHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679173);
		NativeMethodInfoPtr_RefreshArrows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679174);
		NativeMethodInfoPtr_HandleValueChangeInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679175);
		NativeMethodInfoPtr_RightButtonLogic_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679176);
		NativeMethodInfoPtr_RightButtonEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679177);
		NativeMethodInfoPtr_LeftButtonLogic_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679178);
		NativeMethodInfoPtr_LeftButtonEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679179);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679180);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSelector>.NativeClassPtr, 100679181);
	}

	public StringSelector(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
