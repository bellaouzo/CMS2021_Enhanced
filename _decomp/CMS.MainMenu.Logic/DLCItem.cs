using System;
using System.Runtime.CompilerServices;
using CMS.UI.Events;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CMS.MainMenu.Logic;

public class DLCItem : GridItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCImageGameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconsParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_InstalledIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotOwnedIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedGrayscale;

	private static readonly System.IntPtr NativeFieldInfoPtr_notSelectedGrayscale;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownedAndNotSelectedGrayscale;

	private static readonly System.IntPtr NativeFieldInfoPtr_useAdditionalMouseEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalButtonEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_owned;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseAdditionalMouseEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UseAdditionalMouseEvents_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Owned_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleUp_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleDown_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForDLC_Public_Void_DLC_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeAction_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DLCItem>.NativeClassPtr));

	public unsafe GameObject Selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Selected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image DLCImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject DLCImageGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCImageGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCImageGameObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject IconsParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconsParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconsParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject InstalledIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstalledIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstalledIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject NotOwnedIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotOwnedIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NotOwnedIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float selectedGrayscale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedGrayscale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedGrayscale)) = num;
		}
	}

	public unsafe float notSelectedGrayscale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notSelectedGrayscale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notSelectedGrayscale)) = num;
		}
	}

	public unsafe float ownedAndNotSelectedGrayscale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownedAndNotSelectedGrayscale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownedAndNotSelectedGrayscale)) = num;
		}
	}

	public unsafe bool useAdditionalMouseEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAdditionalMouseEvents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAdditionalMouseEvents)) = flag;
		}
	}

	public unsafe ButtonEvent<DLCItem> AdditionalButtonEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdditionalButtonEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ButtonEvent<DLCItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdditionalButtonEvent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool owned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owned);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owned)) = flag;
		}
	}

	public unsafe int DLCIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCIndex)) = num;
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

	public unsafe Vector3 SelectedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedSize)) = vector;
		}
	}

	public unsafe bool UseAdditionalMouseEvents
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseAdditionalMouseEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149834, RefRangeEnd = 149837, XrefRangeStart = 149828, XrefRangeEnd = 149834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UseAdditionalMouseEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool Owned
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Owned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149837, XrefRangeEnd = 149844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149844, XrefRangeEnd = 149859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149859, XrefRangeEnd = 149869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 149893, RefRangeEnd = 149894, XrefRangeStart = 149869, XrefRangeEnd = 149893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScaleUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 149918, RefRangeEnd = 149919, XrefRangeStart = 149894, XrefRangeEnd = 149918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScaleDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 149967, RefRangeEnd = 149968, XrefRangeStart = 149919, XrefRangeEnd = 149967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForDLC(DLC dlc, Sprite sprite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(sprite);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForDLC_Public_Void_DLC_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 149975, RefRangeEnd = 149977, XrefRangeStart = 149968, XrefRangeEnd = 149975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149977, XrefRangeEnd = 149983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149983, XrefRangeEnd = 149986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149986, XrefRangeEnd = 149990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149990, XrefRangeEnd = 149993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLCItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLCItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DLCItem()
	{
		Il2CppClassPointerStore<DLCItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.MainMenu.Logic", "DLCItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLCItem>.NativeClassPtr);
		NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "Selected");
		NativeFieldInfoPtr_DLCImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "DLCImage");
		NativeFieldInfoPtr_DLCImageGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "DLCImageGameObject");
		NativeFieldInfoPtr_IconsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "IconsParent");
		NativeFieldInfoPtr_InstalledIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "InstalledIcon");
		NativeFieldInfoPtr_NotOwnedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "NotOwnedIcon");
		NativeFieldInfoPtr_selectedGrayscale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "selectedGrayscale");
		NativeFieldInfoPtr_notSelectedGrayscale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "notSelectedGrayscale");
		NativeFieldInfoPtr_ownedAndNotSelectedGrayscale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "ownedAndNotSelectedGrayscale");
		NativeFieldInfoPtr_useAdditionalMouseEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "useAdditionalMouseEvents");
		NativeFieldInfoPtr_AdditionalButtonEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "AdditionalButtonEvent");
		NativeFieldInfoPtr_owned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "owned");
		NativeFieldInfoPtr_DLCIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "DLCIndex");
		NativeFieldInfoPtr_NormalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "NormalSize");
		NativeFieldInfoPtr_SelectedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, "SelectedSize");
		NativeMethodInfoPtr_get_UseAdditionalMouseEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673632);
		NativeMethodInfoPtr_set_UseAdditionalMouseEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673633);
		NativeMethodInfoPtr_get_Owned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673634);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673635);
		NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673636);
		NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673637);
		NativeMethodInfoPtr_ScaleUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673638);
		NativeMethodInfoPtr_ScaleDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673639);
		NativeMethodInfoPtr_SetupForDLC_Public_Void_DLC_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673640);
		NativeMethodInfoPtr_InvokeAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673641);
		NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673642);
		NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673643);
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673644);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCItem>.NativeClassPtr, 100673645);
	}

	public DLCItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
