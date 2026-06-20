using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using CMS.UI;
using CMS.UI.Description;
using CMS.UI.Logic;
using CMS.UI.Windows;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	private sealed class MethodInfoStoreGeneric_ShowInfoWindow_Public_Void_String_T1_0<T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_T1_0, Il2CppClassPointerStore<UIManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PartsVariantsTextAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusTextDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevDescType;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAlternativeDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatsContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartInspector;

	private static readonly System.IntPtr NativeFieldInfoPtr_AskWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_InfoWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShopListWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrdersWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_PopupManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBonusDescriptionSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPartsVariants_Public_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterWindows_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowPopup_Public_Void_String_String_PopupType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HidePopup_Public_Void_Boolean_PopupType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPopupUIPosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPopupPosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToShopList_Public_Void_String_String_ShopListItemDataEx_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAskWindow_Public_Void_String_String_Action_1_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAskWindowAfterWindowClose_Public_Void_String_String_Action_1_Boolean_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowErrorAskWindow_Public_Void_String_String_Action_1_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAskWindowCanClearAction_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_WindowID_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowFullGarageInfo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshExpAddValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshStatsUICoroutine_Public_Void_StatType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshAllStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStatsUIActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameVersionActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePartInspector_Public_Void_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePartInspector_Public_Void_PartScript_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateJobs_Public_Void_List_1_Job_Job_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsActiveWindow_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentIODescription_Public_AlternativeDescriptionID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIODescription_Public_Void_String_AlternativeDescriptionID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableIODescriptionSegment_Public_Void_DescriptionVariant_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBonusTextDescription_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearBonusTextDescription_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCarLoaderOnCarLocationAskWindow_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanShowPieMenu_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_UIManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIManager>.NativeClassPtr));

	public unsafe TextAsset PartsVariantsTextAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartsVariantsTextAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartsVariantsTextAsset), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text BonusTextDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusTextDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusTextDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text TextDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AlternativeDescriptionID prevDescType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevDescType);
			return *(AlternativeDescriptionID*)num;
		}
		set
		{
			*(AlternativeDescriptionID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevDescType)) = alternativeDescriptionID;
		}
	}

	public unsafe UIDescription currentAlternativeDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAlternativeDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAlternativeDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StatsContainer StatsContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatsContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StatsContainer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatsContainer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PartInspectorWindow PartInspector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartInspector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PartInspectorWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartInspector), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AskWindow AskWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AskWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AskWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AskWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InfoWindow InfoWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InfoWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InfoWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InfoWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ShopListWindow ShopListWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopListWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ShopListWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopListWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OrdersWindow OrdersWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrdersWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OrdersWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrdersWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PopupManager PopupManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PopupManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PopupManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isBonusDescriptionSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBonusDescriptionSet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBonusDescriptionSet)) = flag;
		}
	}

	public unsafe static UIManager m_instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new UIManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86980, XrefRangeEnd = 87006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87006, XrefRangeEnd = 87053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87071, RefRangeEnd = 87073, XrefRangeStart = 87053, XrefRangeEnd = 87071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextAsset GetPartsVariants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPartsVariants_Public_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new TextAsset(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87086, RefRangeEnd = 87087, XrefRangeStart = 87073, XrefRangeEnd = 87086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterWindows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterWindows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(64)]
	[CachedScanResults(RefRangeStart = 87096, RefRangeEnd = 87160, XrefRangeStart = 87087, XrefRangeEnd = 87096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowPopup(string title, string text, PopupType popupType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(PopupType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &popupType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPopup_Public_Void_String_String_PopupType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 87166, RefRangeEnd = 87171, XrefRangeStart = 87160, XrefRangeEnd = 87166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HidePopup([Optional][DefaultParameterValue(false)] bool instant, [Optional] PopupType popupType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instant);
		*(PopupType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &popupType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HidePopup_Public_Void_Boolean_PopupType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87175, RefRangeEnd = 87177, XrefRangeStart = 87171, XrefRangeEnd = 87175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPopupUIPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPopupUIPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 87181, RefRangeEnd = 87184, XrefRangeStart = 87177, XrefRangeEnd = 87181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPopupPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPopupPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87205, RefRangeEnd = 87207, XrefRangeStart = 87184, XrefRangeEnd = 87205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToShopList(string ID, string bonusText, ShopListItemDataEx additionalData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(bonusText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(additionalData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToShopList_Public_Void_String_String_ShopListItemDataEx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 87230, RefRangeEnd = 87252, XrefRangeStart = 87207, XrefRangeEnd = 87230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAskWindow(string title, string description, Il2CppSystem.Action<bool> action, bool withSound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSound;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowAskWindow_Public_Void_String_String_Action_1_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87252, XrefRangeEnd = 87275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAskWindowAfterWindowClose(string title, string description, Il2CppSystem.Action<bool> action, WindowID windowToWaitForClosing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(WindowID**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &windowToWaitForClosing;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowAskWindowAfterWindowClose_Public_Void_String_String_Action_1_Boolean_WindowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87275, XrefRangeEnd = 87302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowErrorAskWindow(string title, string description, Il2CppSystem.Action<bool> action, bool withSound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSound;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowErrorAskWindow_Public_Void_String_String_Action_1_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87302, XrefRangeEnd = 87316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAskWindowCanClearAction(bool canClear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&canClear);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAskWindowCanClearAction_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87316, XrefRangeEnd = 87339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInfoWindow(string text, WindowID windowToClose, bool withSound = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(WindowID**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &windowToClose;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSound;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_WindowID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 87362, RefRangeEnd = 87395, XrefRangeStart = 87339, XrefRangeEnd = 87362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInfoWindow(string text, bool withSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSound;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 87418, RefRangeEnd = 87439, XrefRangeStart = 87395, XrefRangeEnd = 87418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInfoWindow(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87461, RefRangeEnd = 87462, XrefRangeStart = 87439, XrefRangeEnd = 87461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInfoWindow<T1>(string text, T1 arg1)
	{
		//IL_0088->IL008d: Incompatible stack types: I vs Ref
		//IL_0064->IL008d: Incompatible stack types: I vs Ref
		//IL_0071->IL008d: Incompatible stack types: I vs Ref
		//IL_007b->IL008d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T1 reference;
		if (!typeof(T1).IsValueType)
		{
			object obj = arg1;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ShowInfoWindow_Public_Void_String_T1_0<T1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87481, RefRangeEnd = 87483, XrefRangeStart = 87462, XrefRangeEnd = 87481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowFullGarageInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowFullGarageInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87483, XrefRangeEnd = 87496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshExpAddValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshExpAddValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 87509, RefRangeEnd = 87516, XrefRangeStart = 87496, XrefRangeEnd = 87509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshStatsUICoroutine(StatType statType, bool instant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&statType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instant;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshStatsUICoroutine_Public_Void_StatType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 87531, RefRangeEnd = 87536, XrefRangeStart = 87516, XrefRangeEnd = 87531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshAllStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshAllStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 87558, RefRangeEnd = 87563, XrefRangeStart = 87536, XrefRangeEnd = 87558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStatsUIActive(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&active);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStatsUIActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87585, RefRangeEnd = 87587, XrefRangeStart = 87563, XrefRangeEnd = 87585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameVersionActive(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&active);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameVersionActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87587, XrefRangeEnd = 87588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePartInspector(PartScript part)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(part);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePartInspector_Public_Void_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 87601, RefRangeEnd = 87604, XrefRangeStart = 87588, XrefRangeEnd = 87601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePartInspector(PartScript part, bool force)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(part);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePartInspector_Public_Void_PartScript_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 87617, RefRangeEnd = 87623, XrefRangeStart = 87604, XrefRangeEnd = 87617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateJobs(List<Job> jobs, Job job)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(jobs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(job);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateJobs_Public_Void_List_1_Job_Job_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87633, RefRangeEnd = 87635, XrefRangeStart = 87623, XrefRangeEnd = 87633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIsActiveWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsActiveWindow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe AlternativeDescriptionID GetCurrentIODescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentIODescription_Public_AlternativeDescriptionID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(AlternativeDescriptionID*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 87695, RefRangeEnd = 87725, XrefRangeStart = 87635, XrefRangeEnd = 87695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIODescription(string text, AlternativeDescriptionID type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(AlternativeDescriptionID**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIODescription_Public_Void_String_AlternativeDescriptionID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87738, RefRangeEnd = 87740, XrefRangeStart = 87725, XrefRangeEnd = 87738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableIODescriptionSegment(DescriptionVariant variant, string action, bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(action);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &enable;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableIODescriptionSegment_Public_Void_DescriptionVariant_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 87761, RefRangeEnd = 87769, XrefRangeStart = 87740, XrefRangeEnd = 87761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBonusTextDescription(string text1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBonusTextDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87769, XrefRangeEnd = 87783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearBonusTextDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearBonusTextDescription_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87790, RefRangeEnd = 87792, XrefRangeStart = 87783, XrefRangeEnd = 87790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCarLoaderOnCarLocationAskWindow(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCarLoaderOnCarLocationAskWindow_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87855, RefRangeEnd = 87856, XrefRangeStart = 87792, XrefRangeEnd = 87855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanShowPieMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanShowPieMenu_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(274)]
	[CachedScanResults(RefRangeStart = 87884, RefRangeEnd = 88158, XrefRangeStart = 87856, XrefRangeEnd = 87884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UIManager Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_UIManager_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UIManager(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88158, XrefRangeEnd = 88181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88181, XrefRangeEnd = 88184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UIManager()
	{
		Il2CppClassPointerStore<UIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UIManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager>.NativeClassPtr);
		NativeFieldInfoPtr_PartsVariantsTextAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "PartsVariantsTextAsset");
		NativeFieldInfoPtr_BonusTextDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "BonusTextDescription");
		NativeFieldInfoPtr_TextDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "TextDescription");
		NativeFieldInfoPtr_prevDescType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "prevDescType");
		NativeFieldInfoPtr_currentAlternativeDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "currentAlternativeDescription");
		NativeFieldInfoPtr_StatsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "StatsContainer");
		NativeFieldInfoPtr_PartInspector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "PartInspector");
		NativeFieldInfoPtr_AskWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "AskWindow");
		NativeFieldInfoPtr_InfoWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "InfoWindow");
		NativeFieldInfoPtr_ShopListWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "ShopListWindow");
		NativeFieldInfoPtr_OrdersWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "OrdersWindow");
		NativeFieldInfoPtr_PopupManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "PopupManager");
		NativeFieldInfoPtr_isBonusDescriptionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "isBonusDescriptionSet");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_instance");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668306);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668307);
		NativeMethodInfoPtr_GetPartsVariants_Public_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668308);
		NativeMethodInfoPtr_RegisterWindows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668309);
		NativeMethodInfoPtr_ShowPopup_Public_Void_String_String_PopupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668310);
		NativeMethodInfoPtr_HidePopup_Public_Void_Boolean_PopupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668311);
		NativeMethodInfoPtr_SetPopupUIPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668312);
		NativeMethodInfoPtr_ResetPopupPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668313);
		NativeMethodInfoPtr_AddToShopList_Public_Void_String_String_ShopListItemDataEx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668314);
		NativeMethodInfoPtr_ShowAskWindow_Public_Void_String_String_Action_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668315);
		NativeMethodInfoPtr_ShowAskWindowAfterWindowClose_Public_Void_String_String_Action_1_Boolean_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668316);
		NativeMethodInfoPtr_ShowErrorAskWindow_Public_Void_String_String_Action_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668317);
		NativeMethodInfoPtr_SetAskWindowCanClearAction_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668318);
		NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_WindowID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668319);
		NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668320);
		NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668321);
		NativeMethodInfoPtr_ShowInfoWindow_Public_Void_String_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668322);
		NativeMethodInfoPtr_ShowFullGarageInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668323);
		NativeMethodInfoPtr_RefreshExpAddValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668324);
		NativeMethodInfoPtr_RefreshStatsUICoroutine_Public_Void_StatType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668325);
		NativeMethodInfoPtr_RefreshAllStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668326);
		NativeMethodInfoPtr_SetStatsUIActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668327);
		NativeMethodInfoPtr_SetGameVersionActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668328);
		NativeMethodInfoPtr_UpdatePartInspector_Public_Void_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668329);
		NativeMethodInfoPtr_UpdatePartInspector_Public_Void_PartScript_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668330);
		NativeMethodInfoPtr_UpdateJobs_Public_Void_List_1_Job_Job_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668331);
		NativeMethodInfoPtr_CheckIsActiveWindow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668332);
		NativeMethodInfoPtr_GetCurrentIODescription_Public_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668333);
		NativeMethodInfoPtr_SetIODescription_Public_Void_String_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668334);
		NativeMethodInfoPtr_EnableIODescriptionSegment_Public_Void_DescriptionVariant_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668335);
		NativeMethodInfoPtr_SetBonusTextDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668336);
		NativeMethodInfoPtr_ClearBonusTextDescription_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668337);
		NativeMethodInfoPtr_SetCarLoaderOnCarLocationAskWindow_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668338);
		NativeMethodInfoPtr_CanShowPieMenu_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668339);
		NativeMethodInfoPtr_Get_Public_Static_UIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668340);
		NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668341);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100668342);
	}

	public UIManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
