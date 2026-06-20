using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.UI.Description;
using CMS.UI.Logic.RepairPart;
using CMS.UI.Windows;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Scrap;

public class ScrapProduction : MonoBehaviour
{
	[ObfuscatedName("CMS.UI.Logic.Scrap.ScrapProduction/<>c__DisplayClass75_0")]
	public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_player;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CurrentBarMovement_b__0_Internal_Void_Single_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr));

		public unsafe Player player
		{
			get
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr == (System.IntPtr)0) ? ((Player)null) : new Player(intPtr);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe ScrapProduction __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new ScrapProduction(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass75_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189767, XrefRangeEnd = 189781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CurrentBarMovement_b__0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CurrentBarMovement_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass75_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "<>c__DisplayClass75_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr);
			NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr, "player");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr, 100677378);
			NativeMethodInfoPtr__CurrentBarMovement_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass75_0>.NativeClassPtr, 100677379);
		}

		public __c__DisplayClass75_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryItemDetails;

	private static readonly System.IntPtr NativeFieldInfoPtr_onSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBigBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_bars;

	private static readonly System.IntPtr NativeFieldInfoPtr_startButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoBoxBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_noItemsPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_barsRectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_bonusCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigBonusCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBarDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBarIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGameInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAnimationInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrapWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_choosePartDownWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPrepared;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_InfoBoxFadeInAnimationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_InfoBoxWaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_InfoBoxFadeOutAnimationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentBarAnimationTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideNoItemsPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Public_Void_ScrapWindow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChoosePartDownWindow_Public_Void_ChoosePartDownWindow_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareScrapsData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopAnimations_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareStartButton_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCurrentBar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetCurrentBar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupStartButton_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartMiniGameButton_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartMiniGame_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopMiniGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessGameResult_Private_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeScrap_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateItems_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForScrap_Private_List_1_ChoosePartDownItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfThereAreItems_Private_Boolean_List_1_ChoosePartDownItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartMiniGameAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrapPerConditionAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeScrapAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelMiniGameAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUIDescription_Public_Void_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMiniGameDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCloseDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEmptyDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDownWindowEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterDownWindowEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDownWindowItemChange_Private_Void_ChoosePartDownItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDownMenuItems_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimateInfo_Private_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeInfoBoxBackground_Private_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeIndexes_Private_Void_Int32_byref_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomItems_Private_Void_Int32_byref_List_1_Int32_byref_ArrayOf_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBonus_Private_Void_byref_List_1_Int32_byref_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBars_Private_Void_byref_ArrayOf_Int32_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillAllBars_Private_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentBarMovement_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__AnimateInfo_b__67_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__AnimateInfo_b__67_1_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr));

	public unsafe InventoryItemDetails inventoryItemDetails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItemDetails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InventoryItemDetails(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItemDetails), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text onSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSuccess), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text onBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBonus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text onBigBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBigBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBigBonus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Bar> bars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Bar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Button startButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Button(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform currentBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InfoBox infoBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoBox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InfoBox(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoBox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject infoBoxBG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoBoxBG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoBoxBG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject noItemsPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noItemsPage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noItemsPage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform barsRectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barsRectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barsRectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int bonusCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusCount)) = num;
		}
	}

	public unsafe int bigBonusCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigBonusCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigBonusCount)) = num;
		}
	}

	public unsafe Vector3 currentBarDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBarDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBarDefaultPosition)) = vector;
		}
	}

	public unsafe Item currentItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentBarIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBarIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBarIndex)) = num;
		}
	}

	public unsafe bool isGameInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGameInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGameInProgress)) = flag;
		}
	}

	public unsafe bool isAnimationInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAnimationInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAnimationInProgress)) = flag;
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

	public unsafe ScrapWindow scrapWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrapWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScrapWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrapWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChoosePartDownWindow choosePartDownWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choosePartDownWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChoosePartDownWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choosePartDownWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isPrepared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrepared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrepared)) = flag;
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

	public unsafe static float InfoBoxFadeInAnimationTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InfoBoxFadeInAnimationTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InfoBoxFadeInAnimationTime, &num);
		}
	}

	public unsafe static float InfoBoxWaitTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InfoBoxWaitTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InfoBoxWaitTime, &num);
		}
	}

	public unsafe static float InfoBoxFadeOutAnimationTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InfoBoxFadeOutAnimationTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InfoBoxFadeOutAnimationTime, &num);
		}
	}

	public unsafe static float CurrentBarAnimationTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentBarAnimationTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentBarAnimationTime, &num);
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189781, XrefRangeEnd = 189783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 189793, RefRangeEnd = 189797, XrefRangeStart = 189783, XrefRangeEnd = 189793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189797, XrefRangeEnd = 189802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideNoItemsPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideNoItemsPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(55)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void EnableUI(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 189830, RefRangeEnd = 189833, XrefRangeStart = 189802, XrefRangeEnd = 189830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189833, XrefRangeEnd = 189843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetParent(ScrapWindow parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Public_Void_ScrapWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetChoosePartDownWindow(ChoosePartDownWindow window)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(window);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChoosePartDownWindow_Public_Void_ChoosePartDownWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 189874, RefRangeEnd = 189875, XrefRangeStart = 189843, XrefRangeEnd = 189874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareScrapsData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareScrapsData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 189900, RefRangeEnd = 189902, XrefRangeStart = 189875, XrefRangeEnd = 189900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopAnimations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopAnimations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189902, XrefRangeEnd = 189917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareStartButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareStartButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189917, XrefRangeEnd = 189919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareCurrentBar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCurrentBar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 189933, RefRangeEnd = 189936, XrefRangeStart = 189919, XrefRangeEnd = 189933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCurrentBar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCurrentBar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189936, XrefRangeEnd = 189943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupStartButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupStartButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 189965, RefRangeEnd = 189967, XrefRangeStart = 189943, XrefRangeEnd = 189965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189967, XrefRangeEnd = 189976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartMiniGameButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartMiniGameButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190019, RefRangeEnd = 190021, XrefRangeStart = 189976, XrefRangeEnd = 190019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartMiniGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartMiniGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190021, XrefRangeEnd = 190033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopMiniGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopMiniGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190064, RefRangeEnd = 190066, XrefRangeStart = 190033, XrefRangeEnd = 190064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessGameResult(BarType result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessGameResult_Private_Void_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190085, RefRangeEnd = 190087, XrefRangeStart = 190066, XrefRangeEnd = 190085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeScrap(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeScrap_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 190090, RefRangeEnd = 190093, XrefRangeStart = 190087, XrefRangeEnd = 190090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateItems(bool resetPage = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resetPage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateItems_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190117, RefRangeEnd = 190119, XrefRangeStart = 190093, XrefRangeEnd = 190117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ChoosePartDownItem> GetItemsForScrap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForScrap_Private_List_1_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<ChoosePartDownItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190119, XrefRangeEnd = 190120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIfThereAreItems(List<ChoosePartDownItem> items)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfThereAreItems_Private_Boolean_List_1_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190120, XrefRangeEnd = 190121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartMiniGameAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartMiniGameAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190121, XrefRangeEnd = 190124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrapPerConditionAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrapPerConditionAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190124, XrefRangeEnd = 190136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeScrapAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeScrapAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190136, XrefRangeEnd = 190150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelMiniGameAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelMiniGameAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 190192, RefRangeEnd = 190193, XrefRangeStart = 190150, XrefRangeEnd = 190192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190193, XrefRangeEnd = 190216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetUIDescription(UIDescription description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUIDescription_Public_Void_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 190233, RefRangeEnd = 190237, XrefRangeStart = 190216, XrefRangeEnd = 190233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190237, XrefRangeEnd = 190254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMiniGameDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMiniGameDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190254, XrefRangeEnd = 190271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCloseDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCloseDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190271, XrefRangeEnd = 190273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEmptyDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEmptyDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190273, XrefRangeEnd = 190284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDownWindowEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDownWindowEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190293, RefRangeEnd = 190295, XrefRangeStart = 190284, XrefRangeEnd = 190293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegisterDownWindowEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterDownWindowEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190295, XrefRangeEnd = 190301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDownWindowItemChange(ChoosePartDownItem baseItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDownWindowItemChange_Private_Void_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 190318, RefRangeEnd = 190319, XrefRangeStart = 190301, XrefRangeEnd = 190318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PrepareDownMenuItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDownMenuItems_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190319, XrefRangeEnd = 190332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimateInfo(BarType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimateInfo_Private_Void_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190341, RefRangeEnd = 190343, XrefRangeStart = 190332, XrefRangeEnd = 190341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeInfoBoxBackground(BarType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeInfoBoxBackground_Private_Void_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190343, XrefRangeEnd = 190345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RandomizeIndexes(int count, ref List<int> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomizeIndexes_Private_Void_Int32_byref_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		list = (List<int>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190363, RefRangeEnd = 190365, XrefRangeStart = 190345, XrefRangeEnd = 190363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRandomItems(int howMany, ref List<int> allItems, out Il2CppStructArray<int> result, bool allowEdges)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&howMany);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(allItems);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowEdges;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomItems_Private_Void_Int32_byref_List_1_Int32_byref_ArrayOf_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		allItems = (List<int>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 190392, RefRangeEnd = 190393, XrefRangeStart = 190365, XrefRangeEnd = 190392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetBonus(ref List<int> allItems, out Il2CppStructArray<int> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(allItems);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBonus_Private_Void_byref_List_1_Int32_byref_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		allItems = (List<int>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190393, XrefRangeEnd = 190395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBars(ref Il2CppStructArray<int> array, BarType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		*(BarType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBars_Private_Void_byref_ArrayOf_Int32_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 190397, RefRangeEnd = 190399, XrefRangeStart = 190395, XrefRangeEnd = 190397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillAllBars(BarType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillAllBars_Private_Void_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 190415, RefRangeEnd = 190416, XrefRangeStart = 190399, XrefRangeEnd = 190415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateBars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 190448, RefRangeEnd = 190449, XrefRangeStart = 190416, XrefRangeEnd = 190448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CurrentBarMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentBarMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190449, XrefRangeEnd = 190452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrapProduction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190452, XrefRangeEnd = 190466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _AnimateInfo_b__67_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AnimateInfo_b__67_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190466, XrefRangeEnd = 190472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _AnimateInfo_b__67_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AnimateInfo_b__67_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScrapProduction()
	{
		Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Scrap", "ScrapProduction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr);
		NativeFieldInfoPtr_inventoryItemDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "inventoryItemDetails");
		NativeFieldInfoPtr_onSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "onSuccess");
		NativeFieldInfoPtr_onBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "onBonus");
		NativeFieldInfoPtr_onBigBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "onBigBonus");
		NativeFieldInfoPtr_bars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "bars");
		NativeFieldInfoPtr_startButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "startButton");
		NativeFieldInfoPtr_currentBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "currentBar");
		NativeFieldInfoPtr_infoBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "infoBox");
		NativeFieldInfoPtr_infoBoxBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "infoBoxBG");
		NativeFieldInfoPtr_noItemsPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "noItemsPage");
		NativeFieldInfoPtr_barsRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "barsRectTransform");
		NativeFieldInfoPtr_bonusCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "bonusCount");
		NativeFieldInfoPtr_bigBonusCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "bigBonusCount");
		NativeFieldInfoPtr_currentBarDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "currentBarDefaultPosition");
		NativeFieldInfoPtr_currentItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "currentItem");
		NativeFieldInfoPtr_currentBarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "currentBarIndex");
		NativeFieldInfoPtr_isGameInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "isGameInProgress");
		NativeFieldInfoPtr_isAnimationInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "isAnimationInProgress");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "isActive");
		NativeFieldInfoPtr_scrapWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "scrapWindow");
		NativeFieldInfoPtr_choosePartDownWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "choosePartDownWindow");
		NativeFieldInfoPtr_isPrepared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "isPrepared");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "uiDescription");
		NativeFieldInfoPtr_InfoBoxFadeInAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "InfoBoxFadeInAnimationTime");
		NativeFieldInfoPtr_InfoBoxWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "InfoBoxWaitTime");
		NativeFieldInfoPtr_InfoBoxFadeOutAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "InfoBoxFadeOutAnimationTime");
		NativeFieldInfoPtr_CurrentBarAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, "CurrentBarAnimationTime");
		NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677327);
		NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677328);
		NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677329);
		NativeMethodInfoPtr_HideNoItemsPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677330);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677331);
		NativeMethodInfoPtr_Prepare_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677332);
		NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677333);
		NativeMethodInfoPtr_SetParent_Public_Void_ScrapWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677334);
		NativeMethodInfoPtr_SetChoosePartDownWindow_Public_Void_ChoosePartDownWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677335);
		NativeMethodInfoPtr_PrepareScrapsData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677336);
		NativeMethodInfoPtr_StopAnimations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677337);
		NativeMethodInfoPtr_PrepareStartButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677338);
		NativeMethodInfoPtr_PrepareCurrentBar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677339);
		NativeMethodInfoPtr_ResetCurrentBar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677340);
		NativeMethodInfoPtr_CleanupStartButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677341);
		NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677342);
		NativeMethodInfoPtr_StartMiniGameButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677343);
		NativeMethodInfoPtr_StartMiniGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677344);
		NativeMethodInfoPtr_StopMiniGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677345);
		NativeMethodInfoPtr_ProcessGameResult_Private_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677346);
		NativeMethodInfoPtr_MakeScrap_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677347);
		NativeMethodInfoPtr_UpdateItems_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677348);
		NativeMethodInfoPtr_GetItemsForScrap_Private_List_1_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677349);
		NativeMethodInfoPtr_CheckIfThereAreItems_Private_Boolean_List_1_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677350);
		NativeMethodInfoPtr_StartMiniGameAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677351);
		NativeMethodInfoPtr_ScrapPerConditionAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677352);
		NativeMethodInfoPtr_MakeScrapAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677353);
		NativeMethodInfoPtr_CancelMiniGameAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677354);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677355);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677356);
		NativeMethodInfoPtr_SetUIDescription_Public_Void_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677357);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677358);
		NativeMethodInfoPtr_SetMiniGameDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677359);
		NativeMethodInfoPtr_SetCloseDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677360);
		NativeMethodInfoPtr_SetEmptyDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677361);
		NativeMethodInfoPtr_RegisterDownWindowEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677362);
		NativeMethodInfoPtr_UnRegisterDownWindowEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677363);
		NativeMethodInfoPtr_OnDownWindowItemChange_Private_Void_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677364);
		NativeMethodInfoPtr_PrepareDownMenuItems_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677365);
		NativeMethodInfoPtr_AnimateInfo_Private_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677366);
		NativeMethodInfoPtr_ChangeInfoBoxBackground_Private_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677367);
		NativeMethodInfoPtr_RandomizeIndexes_Private_Void_Int32_byref_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677368);
		NativeMethodInfoPtr_GetRandomItems_Private_Void_Int32_byref_List_1_Int32_byref_ArrayOf_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677369);
		NativeMethodInfoPtr_GetBonus_Private_Void_byref_List_1_Int32_byref_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677370);
		NativeMethodInfoPtr_SetBars_Private_Void_byref_ArrayOf_Int32_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677371);
		NativeMethodInfoPtr_FillAllBars_Private_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677372);
		NativeMethodInfoPtr_GenerateBars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677373);
		NativeMethodInfoPtr_CurrentBarMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677374);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677375);
		NativeMethodInfoPtr__AnimateInfo_b__67_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677376);
		NativeMethodInfoPtr__AnimateInfo_b__67_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrapProduction>.NativeClassPtr, 100677377);
	}

	public ScrapProduction(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
