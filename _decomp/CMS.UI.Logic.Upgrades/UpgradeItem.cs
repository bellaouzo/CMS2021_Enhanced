using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CMS.UI.Logic.Upgrades;

public class UpgradeItem : GridItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeID;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockedBy;

	private static readonly System.IntPtr NativeFieldInfoPtr_needFader;

	private static readonly System.IntPtr NativeFieldInfoPtr_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_background;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_relatedUpgrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_HoverSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHovered;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpgradeID_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpgradeLevel_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedBy_Public_get_UpgradeItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Background_Public_get_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Icon_Public_get_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NeedFader_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpgradeState_Public_get_UpgradeState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UpgradeState_Public_set_Void_UpgradeState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RelatedUpgrade_Public_get_List_1_UpgradeItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleUp_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleDown_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStateForSkills_Public_Void_UpgradeSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStateForGarageAndTools_Public_Void_UpgradeSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRelatedUpgrade_Private_Void_UpgradeItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshFrameColor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshBackground_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr));

	public unsafe string upgradeID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int upgradeLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeLevel)) = num;
		}
	}

	public unsafe UpgradeItem lockedBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedBy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UpgradeItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedBy), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool needFader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needFader);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needFader)) = flag;
		}
	}

	public unsafe Image frame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image background
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image bgFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UpgradeState upgradeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeState);
			return *(UpgradeState*)num;
		}
		set
		{
			*(UpgradeState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeState)) = upgradeState;
		}
	}

	public unsafe List<UpgradeItem> relatedUpgrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedUpgrade);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<UpgradeItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedUpgrade), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 NormalSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalSize)) = vector;
		}
	}

	public unsafe Vector3 HoverSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoverSize)) = vector;
		}
	}

	public unsafe bool isHovered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHovered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHovered)) = flag;
		}
	}

	public unsafe string UpgradeID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpgradeID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	public unsafe int UpgradeLevel
	{
		[CallerCount(3)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpgradeLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe UpgradeItem LockedBy
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LockedBy_Public_get_UpgradeItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new UpgradeItem(intPtr) : null;
		}
	}

	public unsafe Image Background
	{
		[CallerCount(30)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Background_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
	}

	public unsafe Image Icon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Icon_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
	}

	public unsafe bool NeedFader
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NeedFader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe UpgradeState UpgradeState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpgradeState_Public_get_UpgradeState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(UpgradeState*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183565, XrefRangeEnd = 183566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpgradeState_Public_set_Void_UpgradeState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsUnlocked
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsAvailable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe List<UpgradeItem> RelatedUpgrade
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RelatedUpgrade_Public_get_List_1_UpgradeItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new List<UpgradeItem>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183566, XrefRangeEnd = 183567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183567, XrefRangeEnd = 183568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183568, XrefRangeEnd = 183572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183572, XrefRangeEnd = 183573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183573, XrefRangeEnd = 183576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183576, XrefRangeEnd = 183579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183603, RefRangeEnd = 183604, XrefRangeStart = 183579, XrefRangeEnd = 183603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScaleUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 183628, RefRangeEnd = 183632, XrefRangeStart = 183604, XrefRangeEnd = 183628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScaleDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183632, XrefRangeEnd = 183638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateStateForSkills(UpgradeSystem upgradeSystem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeSystem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateStateForSkills_Public_Void_UpgradeSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 183661, RefRangeEnd = 183663, XrefRangeStart = 183638, XrefRangeEnd = 183661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateStateForGarageAndTools(UpgradeSystem upgradeSystem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeSystem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateStateForGarageAndTools_Public_Void_UpgradeSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183663, XrefRangeEnd = 183667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRelatedUpgrade(UpgradeItem upgradeItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRelatedUpgrade_Private_Void_UpgradeItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 183679, RefRangeEnd = 183681, XrefRangeStart = 183667, XrefRangeEnd = 183679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshFrameColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshFrameColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 183697, RefRangeEnd = 183717, XrefRangeStart = 183681, XrefRangeEnd = 183697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshBackground()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshBackground_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183717, XrefRangeEnd = 183726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UpgradeItem()
	{
		Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Upgrades", "UpgradeItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr);
		NativeFieldInfoPtr_upgradeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "upgradeID");
		NativeFieldInfoPtr_upgradeLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "upgradeLevel");
		NativeFieldInfoPtr_lockedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "lockedBy");
		NativeFieldInfoPtr_needFader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "needFader");
		NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "frame");
		NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "icon");
		NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "background");
		NativeFieldInfoPtr_bgFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "bgFill");
		NativeFieldInfoPtr_upgradeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "upgradeState");
		NativeFieldInfoPtr_relatedUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "relatedUpgrade");
		NativeFieldInfoPtr_NormalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "NormalSize");
		NativeFieldInfoPtr_HoverSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "HoverSize");
		NativeFieldInfoPtr_isHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, "isHovered");
		NativeMethodInfoPtr_get_UpgradeID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676692);
		NativeMethodInfoPtr_get_UpgradeLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676693);
		NativeMethodInfoPtr_get_LockedBy_Public_get_UpgradeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676694);
		NativeMethodInfoPtr_get_Background_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676695);
		NativeMethodInfoPtr_get_Icon_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676696);
		NativeMethodInfoPtr_get_NeedFader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676697);
		NativeMethodInfoPtr_get_UpgradeState_Public_get_UpgradeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676698);
		NativeMethodInfoPtr_set_UpgradeState_Public_set_Void_UpgradeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676699);
		NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676700);
		NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676701);
		NativeMethodInfoPtr_get_RelatedUpgrade_Public_get_List_1_UpgradeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676702);
		NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676703);
		NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676704);
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676705);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676706);
		NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676707);
		NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676708);
		NativeMethodInfoPtr_ScaleUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676709);
		NativeMethodInfoPtr_ScaleDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676710);
		NativeMethodInfoPtr_UpdateStateForSkills_Public_Void_UpgradeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676711);
		NativeMethodInfoPtr_UpdateStateForGarageAndTools_Public_Void_UpgradeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676712);
		NativeMethodInfoPtr_SetRelatedUpgrade_Private_Void_UpgradeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676713);
		NativeMethodInfoPtr_RefreshFrameColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676714);
		NativeMethodInfoPtr_RefreshBackground_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676715);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeItem>.NativeClassPtr, 100676716);
	}

	public UpgradeItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
