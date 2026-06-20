using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.Events;
using CMS.SceneLoaders.Tracks;
using CMS.Tracks.Dragstrip;
using CMS.UI.Description;
using CMS.UI.Logic.Drag;
using CMS.UI.Logic.Paging;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Windows;

public class DragResultsWindow : Window
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BGMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragstrip;

	private static readonly System.IntPtr NativeFieldInfoPtr_dots;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedModes;

	private static readonly System.IntPtr NativeFieldInfoPtr_canvasGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelectedDot;

	private static readonly System.IntPtr NativeFieldInfoPtr_raceLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventsSubscribed;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrewarmUI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowUIWithAlpha_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideUIWithAlpha_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareSelectedModes_Private_Void_DragSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Private_Void_String_Int32_CarForDragstrip_Single_Boolean_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubscribeEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsubscribeEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOpponentHitCheckpoint_Private_Void_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOpponentHitSpeed_Private_Void_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOpponentFinished_Private_Void_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOpponentTimeout_Private_Void_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOpponentTimeoutTick_Private_Void_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNextPage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFirstPage_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDotClick_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextPageAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BackAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWaitingDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFirstPageDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSecondPageDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr));

	public unsafe GameObject BGMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BGMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BGMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragPlayerResultsPanel leftPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragPlayerResultsPanel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragOpponentResultsPanel rightPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragOpponentResultsPanel(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dragstrip dragstrip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragstrip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dragstrip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragstrip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Dot> dots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Dot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dots), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragSelectedModes selectedModes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedModes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragSelectedModes(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedModes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CanvasGroup canvasGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvasGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CanvasGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIDescription uiDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentSelectedDot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedDot);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedDot)) = num;
		}
	}

	public unsafe DragLength raceLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raceLength);
			return *(DragLength*)num;
		}
		set
		{
			*(DragLength*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raceLength)) = dragLength;
		}
	}

	public unsafe bool eventsSubscribed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventsSubscribed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventsSubscribed)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158476, XrefRangeEnd = 158482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158482, XrefRangeEnd = 158490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158490, XrefRangeEnd = 158549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Show(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158549, XrefRangeEnd = 158578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Hide(bool hiddenFromOutside)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hiddenFromOutside);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158597, RefRangeEnd = 158598, XrefRangeStart = 158578, XrefRangeEnd = 158597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableUI(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158598, XrefRangeEnd = 158609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrewarmUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrewarmUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158609, XrefRangeEnd = 158622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowUIWithAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowUIWithAlpha_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 158635, RefRangeEnd = 158638, XrefRangeStart = 158622, XrefRangeEnd = 158635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideUIWithAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideUIWithAlpha_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158638, XrefRangeEnd = 158645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareSelectedModes(DragSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareSelectedModes_Private_Void_DragSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158704, RefRangeEnd = 158705, XrefRangeStart = 158645, XrefRangeEnd = 158704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(string playerCarID, int playerCarConfig, CarForDragstrip opponentCar, float playerPI, bool opponentFinished, DragMember winner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCarID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerCarConfig;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(opponentCar));
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerPI;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opponentFinished;
		*(DragMember**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &winner;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Private_Void_String_Int32_CarForDragstrip_Single_Boolean_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158751, RefRangeEnd = 158752, XrefRangeStart = 158705, XrefRangeEnd = 158751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubscribeEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubscribeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158798, RefRangeEnd = 158799, XrefRangeStart = 158752, XrefRangeEnd = 158798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnsubscribeEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsubscribeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158799, XrefRangeEnd = 158808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOpponentHitCheckpoint(EventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOpponentHitCheckpoint_Private_Void_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158808, XrefRangeEnd = 158812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOpponentHitSpeed(EventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOpponentHitSpeed_Private_Void_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158812, XrefRangeEnd = 158817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOpponentFinished(EventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOpponentFinished_Private_Void_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158817, XrefRangeEnd = 158831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOpponentTimeout(EventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOpponentTimeout_Private_Void_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158831, XrefRangeEnd = 158839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOpponentTimeoutTick(EventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOpponentTimeoutTick_Private_Void_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 158854, RefRangeEnd = 158856, XrefRangeStart = 158839, XrefRangeEnd = 158854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNextPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNextPage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158861, RefRangeEnd = 158862, XrefRangeStart = 158856, XrefRangeEnd = 158861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFirstPage(bool withDescription = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&withDescription);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFirstPage_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158862, XrefRangeEnd = 158869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 158888, RefRangeEnd = 158890, XrefRangeStart = 158869, XrefRangeEnd = 158888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158890, XrefRangeEnd = 158909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158909, XrefRangeEnd = 158910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158910, XrefRangeEnd = 158916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDotClick(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDotClick_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 158931, RefRangeEnd = 158936, XrefRangeStart = 158916, XrefRangeEnd = 158931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158936, XrefRangeEnd = 158937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextPageAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextPageAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158937, XrefRangeEnd = 158942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BackAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BackAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158942, XrefRangeEnd = 158944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 158966, RefRangeEnd = 158967, XrefRangeStart = 158944, XrefRangeEnd = 158966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158967, XrefRangeEnd = 158987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDescriptionsActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158987, XrefRangeEnd = 158989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWaitingDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWaitingDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 159000, RefRangeEnd = 159006, XrefRangeStart = 158989, XrefRangeEnd = 159000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFirstPageDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFirstPageDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159006, XrefRangeEnd = 159017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSecondPageDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSecondPageDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragResultsWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragResultsWindow()
	{
		Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "DragResultsWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr);
		NativeFieldInfoPtr_BGMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "BGMenu");
		NativeFieldInfoPtr_leftPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "leftPanel");
		NativeFieldInfoPtr_rightPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "rightPanel");
		NativeFieldInfoPtr_dragstrip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "dragstrip");
		NativeFieldInfoPtr_dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "dots");
		NativeFieldInfoPtr_selectedModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "selectedModes");
		NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "canvasGroup");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "uiDescription");
		NativeFieldInfoPtr_currentSelectedDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "currentSelectedDot");
		NativeFieldInfoPtr_raceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "raceLength");
		NativeFieldInfoPtr_eventsSubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, "eventsSubscribed");
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674501);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674502);
		NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674503);
		NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674504);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674505);
		NativeMethodInfoPtr_PrewarmUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674506);
		NativeMethodInfoPtr_ShowUIWithAlpha_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674507);
		NativeMethodInfoPtr_HideUIWithAlpha_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674508);
		NativeMethodInfoPtr_PrepareSelectedModes_Private_Void_DragSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674509);
		NativeMethodInfoPtr_Setup_Private_Void_String_Int32_CarForDragstrip_Single_Boolean_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674510);
		NativeMethodInfoPtr_SubscribeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674511);
		NativeMethodInfoPtr_UnsubscribeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674512);
		NativeMethodInfoPtr_OnOpponentHitCheckpoint_Private_Void_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674513);
		NativeMethodInfoPtr_OnOpponentHitSpeed_Private_Void_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674514);
		NativeMethodInfoPtr_OnOpponentFinished_Private_Void_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674515);
		NativeMethodInfoPtr_OnOpponentTimeout_Private_Void_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674516);
		NativeMethodInfoPtr_OnOpponentTimeoutTick_Private_Void_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674517);
		NativeMethodInfoPtr_SetNextPage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674518);
		NativeMethodInfoPtr_SetFirstPage_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674519);
		NativeMethodInfoPtr_PrepareDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674520);
		NativeMethodInfoPtr_EnableDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674521);
		NativeMethodInfoPtr_DisableDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674522);
		NativeMethodInfoPtr_CleanupDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674523);
		NativeMethodInfoPtr_OnDotClick_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674524);
		NativeMethodInfoPtr_DrawDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674525);
		NativeMethodInfoPtr_NextPageAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674526);
		NativeMethodInfoPtr_BackAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674527);
		NativeMethodInfoPtr_CloseAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674528);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674529);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674530);
		NativeMethodInfoPtr_SetWaitingDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674531);
		NativeMethodInfoPtr_SetFirstPageDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674532);
		NativeMethodInfoPtr_SetSecondPageDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674533);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsWindow>.NativeClassPtr, 100674534);
	}

	public DragResultsWindow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
