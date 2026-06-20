using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CMS.UI.Logic.Orders;

public class OrderItem : ListItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_activeGameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_emptyGameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockedGameObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockedText;

	private static readonly System.IntPtr NativeFieldInfoPtr_icons;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_carName;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_hover;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_job;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEmpty;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_String_String_Boolean_OrderIconType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopTimer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTimer_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLockDetails_Public_Void_OrderSlotLockReason_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEmpty_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OrderItem>.NativeClassPtr));

	public unsafe GameObject activeGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeGameObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject emptyGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyGameObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject lockedGameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedGameObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedGameObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text lockedText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<OrderIcon> icons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<OrderIcon>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject specialBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialBackground), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe GameObject hover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hover), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<OrderItem> OnSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSelect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<OrderItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSelect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Job job
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Job(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isLocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLocked)) = flag;
		}
	}

	public unsafe bool isEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEmpty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEmpty)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194836, RefRangeEnd = 194837, XrefRangeStart = 194816, XrefRangeEnd = 194836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(string car, string engine, bool isMission, OrderIconType orderIconType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(car);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engine);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isMission;
		*(OrderIconType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &orderIconType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_String_String_Boolean_OrderIconType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194837, XrefRangeEnd = 194838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetupTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTimer_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194838, XrefRangeEnd = 194840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194840, XrefRangeEnd = 194841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194841, XrefRangeEnd = 194842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 194868, RefRangeEnd = 194871, XrefRangeStart = 194842, XrefRangeEnd = 194868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194871, XrefRangeEnd = 194894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194894, XrefRangeEnd = 194914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194914, XrefRangeEnd = 194928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194928, XrefRangeEnd = 194948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194948, XrefRangeEnd = 194949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 194954, RefRangeEnd = 194957, XrefRangeStart = 194949, XrefRangeEnd = 194954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocked(bool locked = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&locked);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194957, XrefRangeEnd = 194969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLockDetails(OrderSlotLockReason lockReason, int levelCap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lockReason);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelCap;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLockDetails_Public_Void_OrderSlotLockReason_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194974, RefRangeEnd = 194976, XrefRangeStart = 194969, XrefRangeEnd = 194974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEmpty(bool empty = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&empty);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEmpty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194976, XrefRangeEnd = 194979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrderItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OrderItem()
	{
		Il2CppClassPointerStore<OrderItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Orders", "OrderItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderItem>.NativeClassPtr);
		NativeFieldInfoPtr_activeGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "activeGameObject");
		NativeFieldInfoPtr_emptyGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "emptyGameObject");
		NativeFieldInfoPtr_lockedGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "lockedGameObject");
		NativeFieldInfoPtr_lockedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "lockedText");
		NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "icons");
		NativeFieldInfoPtr_specialBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "specialBackground");
		NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "carName");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "time");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "hover");
		NativeFieldInfoPtr_OnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "OnSelect");
		NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "job");
		NativeFieldInfoPtr_isLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "isLocked");
		NativeFieldInfoPtr_isEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, "isEmpty");
		NativeMethodInfoPtr_Setup_Public_Void_String_String_Boolean_OrderIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677836);
		NativeMethodInfoPtr_StopTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677837);
		NativeMethodInfoPtr_SetupTimer_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677838);
		NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677839);
		NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677840);
		NativeMethodInfoPtr_CanSelect_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677841);
		NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677842);
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677843);
		NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677844);
		NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677845);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677846);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677847);
		NativeMethodInfoPtr_SetLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677848);
		NativeMethodInfoPtr_SetLockDetails_Public_Void_OrderSlotLockReason_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677849);
		NativeMethodInfoPtr_SetEmpty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677850);
		NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677851);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderItem>.NativeClassPtr, 100677852);
	}

	public OrderItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
