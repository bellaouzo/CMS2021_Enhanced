using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace CMS.UI.Description;

public class UIDescription : MonoBehaviour
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("CMS.UI.Description.UIDescription/<>c__DisplayClass46_0")]
	public struct __c__DisplayClass46_0
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_controllerType;

		private static readonly System.IntPtr NativeFieldInfoPtr_playstationControllerState;

		private static readonly System.IntPtr NativeFieldInfoPtr_isControllerUsed;

		[FieldOffset(0)]
		public ControllerType controllerType;

		[FieldOffset(4)]
		public PlaystationControllerState playstationControllerState;

		[FieldOffset(8)]
		public bool isControllerUsed;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr));

		static __c__DisplayClass46_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "<>c__DisplayClass46_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr);
			NativeFieldInfoPtr_controllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, "controllerType");
			NativeFieldInfoPtr_playstationControllerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, "playstationControllerState");
			NativeFieldInfoPtr_isControllerUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, "isControllerUsed");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_useAlternativeID;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_alternativeID;

	private static readonly System.IntPtr NativeFieldInfoPtr_descriptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_useActiveList;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeVariants;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentControlDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockOthers;

	private static readonly System.IntPtr NativeFieldInfoPtr_unblockAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableInput;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseAlternativeID_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ID_Public_get_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AlternativeID_Public_get_AlternativeDescriptionID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseActiveList_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UseActiveList_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_DescriptionVariant_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActive_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterFillActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_UnityAction_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterFillActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowVariant_Public_Void_DescriptionVariant_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowVariant_Public_Void_DescriptionVariant_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowVariantForAction_Public_Void_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideVariant_Public_Void_DescriptionVariant_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideVariantForAction_Public_Void_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActiveVariantForAction_Public_Boolean_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAllVariants_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceRefreshButtonsForKeyboard_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreDescriptions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TemporaryHideDescriptionsWithException_Public_Void_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFilling_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptionForAction_Public_ControlDescription_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptionVariantForAction_Public_ControlDescription_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateVariant_Private_Void_DescriptionVariant_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterRewiredEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterRewiredEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshController_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveControllerChanged_Private_Void_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveControllerChangedHelper_Private_Void_Controller_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DisableInput_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DisableInput_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableInputForAllControlDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_ControlDescription_byref___c__DisplayClass46_0_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIDescription>.NativeClassPtr));

	public unsafe bool useAlternativeID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAlternativeID);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAlternativeID)) = flag;
		}
	}

	public unsafe WindowID id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(WindowID*)num;
		}
		set
		{
			*(WindowID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = windowID;
		}
	}

	public unsafe AlternativeDescriptionID alternativeID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alternativeID);
			return *(AlternativeDescriptionID*)num;
		}
		set
		{
			*(AlternativeDescriptionID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alternativeID)) = alternativeDescriptionID;
		}
	}

	public unsafe Il2CppReferenceArray<ControlDescription> descriptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ControlDescription>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptions), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe bool useActiveList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useActiveList);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useActiveList)) = flag;
		}
	}

	public unsafe List<Description> activeVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeVariants);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Description>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeVariants), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ControlDescription currentControlDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentControlDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentControlDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool blockOthers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockOthers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockOthers)) = flag;
		}
	}

	public unsafe bool unblockAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unblockAll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unblockAll)) = flag;
		}
	}

	public unsafe bool disableInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableInput)) = flag;
		}
	}

	public unsafe bool UseAlternativeID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseAlternativeID_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe WindowID ID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ID_Public_get_WindowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(WindowID*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe AlternativeDescriptionID AlternativeID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AlternativeID_Public_get_AlternativeDescriptionID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(AlternativeDescriptionID*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool UseActiveList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseActiveList_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207962, RefRangeEnd = 207963, XrefRangeStart = 207952, XrefRangeEnd = 207962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UseActiveList_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool DisableInput
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisableInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209346, XrefRangeEnd = 209347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisableInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207969, RefRangeEnd = 207970, XrefRangeStart = 207963, XrefRangeEnd = 207969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterItself_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207970, XrefRangeEnd = 207979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterItself_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 207994, RefRangeEnd = 207997, XrefRangeStart = 207979, XrefRangeEnd = 207994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show(DescriptionVariant descriptionVariant, bool hideOtherVariants)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideOtherVariants;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_Void_DescriptionVariant_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 208008, RefRangeEnd = 208031, XrefRangeStart = 207997, XrefRangeEnd = 208008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 208041, RefRangeEnd = 208070, XrefRangeStart = 208031, XrefRangeEnd = 208041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208070, XrefRangeEnd = 208080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208080, XrefRangeEnd = 208096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RegisterActionForDescriptionVariant(DescriptionVariant variant, string actionName, UnityAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208096, XrefRangeEnd = 208113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RegisterFillActionForDescriptionVariant(DescriptionVariant variant, string actionName, UnityAction<float> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterFillActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208113, XrefRangeEnd = 208127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UnregisterActionForDescriptionVariant(DescriptionVariant variant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208127, XrefRangeEnd = 208141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UnregisterFillActionForDescriptionVariant(DescriptionVariant variant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterFillActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 208145, RefRangeEnd = 208177, XrefRangeStart = 208141, XrefRangeEnd = 208145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowVariant(DescriptionVariant descriptionVariant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&descriptionVariant);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowVariant_Public_Void_DescriptionVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 208181, RefRangeEnd = 208183, XrefRangeStart = 208177, XrefRangeEnd = 208181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowVariant(DescriptionVariant descriptionVariant, bool forceAddToActiveList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceAddToActiveList;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowVariant_Public_Void_DescriptionVariant_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(501)]
	[CachedScanResults(RefRangeStart = 208199, RefRangeEnd = 208700, XrefRangeStart = 208183, XrefRangeEnd = 208199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowVariantForAction(DescriptionVariant descriptionVariant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowVariantForAction_Public_Void_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 208704, RefRangeEnd = 208713, XrefRangeStart = 208700, XrefRangeEnd = 208704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideVariant(DescriptionVariant descriptionVariant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&descriptionVariant);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideVariant_Public_Void_DescriptionVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(228)]
	[CachedScanResults(RefRangeStart = 208729, RefRangeEnd = 208957, XrefRangeStart = 208713, XrefRangeEnd = 208729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideVariantForAction(DescriptionVariant descriptionVariant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideVariantForAction_Public_Void_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 208970, RefRangeEnd = 208993, XrefRangeStart = 208957, XrefRangeEnd = 208970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActiveVariantForAction(DescriptionVariant descriptionVariant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActiveVariantForAction_Public_Boolean_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(171)]
	[CachedScanResults(RefRangeStart = 208997, RefRangeEnd = 209168, XrefRangeStart = 208993, XrefRangeEnd = 208997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAllVariants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAllVariants_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209168, XrefRangeEnd = 209173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 209180, RefRangeEnd = 209183, XrefRangeStart = 209173, XrefRangeEnd = 209180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceRefreshButtonsForKeyboard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceRefreshButtonsForKeyboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209183, XrefRangeEnd = 209188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreDescriptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209188, XrefRangeEnd = 209190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TemporaryHideDescriptionsWithException(DescriptionVariant descriptionVariant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TemporaryHideDescriptionsWithException_Public_Void_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209190, XrefRangeEnd = 209197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFilling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFilling_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 209198, RefRangeEnd = 209204, XrefRangeStart = 209197, XrefRangeEnd = 209198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlDescription GetDescriptionForAction(string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescriptionForAction_Public_ControlDescription_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 209205, RefRangeEnd = 209248, XrefRangeStart = 209204, XrefRangeEnd = 209205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlDescription GetDescriptionVariantForAction(DescriptionVariant variant, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDescriptionVariantForAction_Public_ControlDescription_DescriptionVariant_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209248, XrefRangeEnd = 209252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateVariant(DescriptionVariant descriptionVariant, bool hideOtherVariants)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&descriptionVariant);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideOtherVariants;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateVariant_Private_Void_DescriptionVariant_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 209265, RefRangeEnd = 209267, XrefRangeStart = 209252, XrefRangeEnd = 209265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterRewiredEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterRewiredEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 209283, RefRangeEnd = 209285, XrefRangeStart = 209267, XrefRangeEnd = 209283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterRewiredEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterRewiredEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 209300, RefRangeEnd = 209303, XrefRangeStart = 209285, XrefRangeEnd = 209300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshController()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshController_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209303, XrefRangeEnd = 209317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActiveControllerChanged(Controller controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveControllerChanged_Private_Void_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 209343, RefRangeEnd = 209346, XrefRangeStart = 209317, XrefRangeEnd = 209343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActiveControllerChangedHelper(Controller controller, bool forceKeyboard = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceKeyboard;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveControllerChangedHelper_Private_Void_Controller_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 209348, RefRangeEnd = 209351, XrefRangeStart = 209347, XrefRangeEnd = 209348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableInputForAllControlDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableInputForAllControlDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 209375, RefRangeEnd = 209378, XrefRangeStart = 209351, XrefRangeEnd = 209375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe UIDescription()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDescription>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209412, RefRangeEnd = 209413, XrefRangeStart = 209378, XrefRangeEnd = 209412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_ControlDescription_byref___c__DisplayClass46_0_0(ControlDescription controlDescription, ref __c__DisplayClass46_0 P_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlDescription);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref P_1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_ControlDescription_byref___c__DisplayClass46_0_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UIDescription()
	{
		Il2CppClassPointerStore<UIDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Description", "UIDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDescription>.NativeClassPtr);
		NativeFieldInfoPtr_useAlternativeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "useAlternativeID");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "id");
		NativeFieldInfoPtr_alternativeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "alternativeID");
		NativeFieldInfoPtr_descriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "descriptions");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "isActive");
		NativeFieldInfoPtr_useActiveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "useActiveList");
		NativeFieldInfoPtr_activeVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "activeVariants");
		NativeFieldInfoPtr_currentControlDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "currentControlDescription");
		NativeFieldInfoPtr_blockOthers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "blockOthers");
		NativeFieldInfoPtr_unblockAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "unblockAll");
		NativeFieldInfoPtr_disableInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, "disableInput");
		NativeMethodInfoPtr_get_UseAlternativeID_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678851);
		NativeMethodInfoPtr_get_ID_Public_get_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678852);
		NativeMethodInfoPtr_get_AlternativeID_Public_get_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678853);
		NativeMethodInfoPtr_get_UseActiveList_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678854);
		NativeMethodInfoPtr_set_UseActiveList_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678855);
		NativeMethodInfoPtr_RegisterItself_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678856);
		NativeMethodInfoPtr_UnregisterItself_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678857);
		NativeMethodInfoPtr_Show_Public_Void_DescriptionVariant_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678858);
		NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678859);
		NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678860);
		NativeMethodInfoPtr_IsActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678861);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678862);
		NativeMethodInfoPtr_RegisterActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678863);
		NativeMethodInfoPtr_RegisterFillActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678864);
		NativeMethodInfoPtr_UnregisterActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678865);
		NativeMethodInfoPtr_UnregisterFillActionForDescriptionVariant_Public_Boolean_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678866);
		NativeMethodInfoPtr_ShowVariant_Public_Void_DescriptionVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678867);
		NativeMethodInfoPtr_ShowVariant_Public_Void_DescriptionVariant_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678868);
		NativeMethodInfoPtr_ShowVariantForAction_Public_Void_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678869);
		NativeMethodInfoPtr_HideVariant_Public_Void_DescriptionVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678870);
		NativeMethodInfoPtr_HideVariantForAction_Public_Void_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678871);
		NativeMethodInfoPtr_IsActiveVariantForAction_Public_Boolean_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678872);
		NativeMethodInfoPtr_HideAllVariants_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678873);
		NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678874);
		NativeMethodInfoPtr_ForceRefreshButtonsForKeyboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678875);
		NativeMethodInfoPtr_RestoreDescriptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678876);
		NativeMethodInfoPtr_TemporaryHideDescriptionsWithException_Public_Void_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678877);
		NativeMethodInfoPtr_IsFilling_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678878);
		NativeMethodInfoPtr_GetDescriptionForAction_Public_ControlDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678879);
		NativeMethodInfoPtr_GetDescriptionVariantForAction_Public_ControlDescription_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678880);
		NativeMethodInfoPtr_ActivateVariant_Private_Void_DescriptionVariant_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678881);
		NativeMethodInfoPtr_RegisterRewiredEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678882);
		NativeMethodInfoPtr_UnregisterRewiredEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678883);
		NativeMethodInfoPtr_RefreshController_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678884);
		NativeMethodInfoPtr_OnActiveControllerChanged_Private_Void_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678885);
		NativeMethodInfoPtr_OnActiveControllerChangedHelper_Private_Void_Controller_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678886);
		NativeMethodInfoPtr_get_DisableInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678887);
		NativeMethodInfoPtr_set_DisableInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678888);
		NativeMethodInfoPtr_EnableInputForAllControlDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678889);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678890);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678891);
		NativeMethodInfoPtr_Method_Internal_Static_Void_ControlDescription_byref___c__DisplayClass46_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescription>.NativeClassPtr, 100678892);
	}

	public UIDescription(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
