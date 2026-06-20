using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic;

public class TopMenu : MonoBehaviour
{
	[System.Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Icons : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_IconsTransform;

		private static readonly System.IntPtr NativeFieldInfoPtr_MenuMode;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Icons>.NativeClassPtr));

		public unsafe Transform IconsTransform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconsTransform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconsTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe TopMenuMode MenuMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MenuMode);
				return *(TopMenuMode*)num;
			}
			set
			{
				*(TopMenuMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MenuMode)) = topMenuMode;
			}
		}

		static Icons()
		{
			Il2CppClassPointerStore<Icons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "Icons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Icons>.NativeClassPtr);
			NativeFieldInfoPtr_IconsTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Icons>.NativeClassPtr, "IconsTransform");
			NativeFieldInfoPtr_MenuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Icons>.NativeClassPtr, "MenuMode");
		}

		public Icons(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe Icons()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Icons>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Icons>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_icons;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_categoryLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_shopBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_blur;

	private static readonly System.IntPtr NativeFieldInfoPtr_topMenuSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabledBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectableIcons;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_behaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_enabledIconsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_onSelectedIconChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_onIconClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalLayoutGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconsEnabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_TopMenuMode_TopMenuBehaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTheme_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableBlur_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowDisabledBG_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareShopFeatures_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareIcons_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareButtons_Private_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterButtonsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterButtonsEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Private_Void_TopMenuButtonID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableIcon_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEnabledIconsCount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnIconClick_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableIcons_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedIcon_Public_Void_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentSelectedIcon_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectIcon_Public_Void_Int32_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSelected_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSelection_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HighlightCurrentIcon_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectOtherThanCurrent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModeToCategoryLabelType_Private_CategoryLabelType_TopMenuMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindCategoryLabelForCurrentMode_Private_CategoryLabel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCategoryTextIfNeeded_Private_Void_LabeledSelectableIcon_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCategoryText_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimateSelectionToPos_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnimationInProgress_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentSelectedIconImage_Public_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIconImage_Public_Image_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectIcon_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextIcon_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousIcon_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRightIcon_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstSelectableIcon_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLeftIcon_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLastSelectableIcon_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandlePreviousTabInput_Private_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleNextTabInput_Private_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TopMenu>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Icons> icons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Icons>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<CategoryLabel> categoryLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_categoryLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CategoryLabel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_categoryLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject shopBG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopBG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopBG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject blur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blur);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blur), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TopMenuSelected topMenuSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topMenuSelected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TopMenuSelected(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topMenuSelected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject disabledBG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledBG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledBG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<SelectableIcon> selectableIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectableIcons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<SelectableIcon>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectableIcons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelected);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelected)) = num;
		}
	}

	public unsafe TopMenuMode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(TopMenuMode*)num;
		}
		set
		{
			*(TopMenuMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = topMenuMode;
		}
	}

	public unsafe TopMenuBehaviour behaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviour);
			return *(TopMenuBehaviour*)num;
		}
		set
		{
			*(TopMenuBehaviour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviour)) = topMenuBehaviour;
		}
	}

	public unsafe int iconsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconsCount)) = num;
		}
	}

	public unsafe int enabledIconsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabledIconsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabledIconsCount)) = num;
		}
	}

	public unsafe bool IsInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsInitialized)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<int> onSelectedIconChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSelectedIconChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onSelectedIconChange), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<int> onIconClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onIconClick);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onIconClick), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe HorizontalLayoutGroup horizontalLayoutGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalLayoutGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new HorizontalLayoutGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TopMenuButton previousButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TopMenuButton(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TopMenuButton nextButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TopMenuButton(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool iconsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconsEnabled)) = flag;
		}
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 180504, RefRangeEnd = 180543, XrefRangeStart = 180459, XrefRangeEnd = 180504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(TopMenuMode topMenuMode, [Optional] TopMenuBehaviour topMenuBehaviour)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&topMenuMode);
		*(TopMenuBehaviour**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &topMenuBehaviour;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_TopMenuMode_TopMenuBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 180552, RefRangeEnd = 180556, XrefRangeStart = 180543, XrefRangeEnd = 180552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTheme()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTheme_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180556, XrefRangeEnd = 180561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableBlur(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableBlur_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180561, XrefRangeEnd = 180566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowDisabledBG(bool show = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&show);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowDisabledBG_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180589, RefRangeEnd = 180590, XrefRangeStart = 180566, XrefRangeEnd = 180589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareShopFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareShopFeatures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180590, XrefRangeEnd = 180597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareIcons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180604, RefRangeEnd = 180605, XrefRangeStart = 180597, XrefRangeEnd = 180604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareButtons(Transform iconsTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(iconsTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareButtons_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180639, RefRangeEnd = 180641, XrefRangeStart = 180605, XrefRangeEnd = 180639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterButtonsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterButtonsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180666, RefRangeEnd = 180668, XrefRangeStart = 180641, XrefRangeEnd = 180666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterButtonsEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterButtonsEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180668, XrefRangeEnd = 180670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonClick(TopMenuButtonID id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnButtonClick_Private_Void_TopMenuButtonID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 180672, RefRangeEnd = 180689, XrefRangeStart = 180670, XrefRangeEnd = 180672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableIcon(int index, bool disable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &disable;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableIcon_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180725, RefRangeEnd = 180726, XrefRangeStart = 180689, XrefRangeEnd = 180725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateEnabledIconsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateEnabledIconsCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180726, XrefRangeEnd = 180732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnIconClick(int iconID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&iconID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnIconClick_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 180733, RefRangeEnd = 180772, XrefRangeStart = 180732, XrefRangeEnd = 180733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableIcons(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableIcons_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180772, XrefRangeEnd = 180774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 180779, RefRangeEnd = 180828, XrefRangeStart = 180774, XrefRangeEnd = 180779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectedIcon(int index, bool withAnimation = true, bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAnimation;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedIcon_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int GetCurrentSelectedIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentSelectedIcon_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180884, RefRangeEnd = 180886, XrefRangeStart = 180828, XrefRangeEnd = 180884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectIcon(int iconIndex, bool withAnimation = true, bool force = false, bool deselectCurrent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&iconIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAnimation;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &deselectCurrent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectIcon_Public_Void_Int32_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 180895, RefRangeEnd = 180904, XrefRangeStart = 180886, XrefRangeEnd = 180895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSelected(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180904, XrefRangeEnd = 180919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 180921, RefRangeEnd = 180924, XrefRangeStart = 180919, XrefRangeEnd = 180921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HighlightCurrentIcon(bool playSound = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playSound);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HighlightCurrentIcon_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180924, XrefRangeEnd = 180925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeselectOtherThanCurrent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeselectOtherThanCurrent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe CategoryLabelType ModeToCategoryLabelType(TopMenuMode modeToConvert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&modeToConvert);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModeToCategoryLabelType_Private_CategoryLabelType_TopMenuMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(CategoryLabelType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180925, XrefRangeEnd = 180940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CategoryLabel FindCategoryLabelForCurrentMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCategoryLabelForCurrentMode_Private_CategoryLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CategoryLabel(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180940, XrefRangeEnd = 180955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCategoryTextIfNeeded(LabeledSelectableIcon selectableIcon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableIcon);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCategoryTextIfNeeded_Private_Void_LabeledSelectableIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 180981, RefRangeEnd = 180984, XrefRangeStart = 180955, XrefRangeEnd = 180981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCategoryText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCategoryText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180984, XrefRangeEnd = 181003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimateSelectionToPos(float xPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&xPos);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimateSelectionToPos_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181003, XrefRangeEnd = 181012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAnimationInProgress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnimationInProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Image GetCurrentSelectedIconImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentSelectedIconImage_Public_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Image GetIconImage(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIconImage_Public_Image_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 181024, RefRangeEnd = 181029, XrefRangeStart = 181012, XrefRangeEnd = 181024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeselectIcon(int iconIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&iconIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeselectIcon_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181040, RefRangeEnd = 181041, XrefRangeStart = 181029, XrefRangeEnd = 181040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181043, RefRangeEnd = 181045, XrefRangeStart = 181041, XrefRangeEnd = 181043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreviousIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181045, XrefRangeEnd = 181046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindRightIcon(int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&column);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRightIcon_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181047, RefRangeEnd = 181048, XrefRangeStart = 181046, XrefRangeEnd = 181047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindFirstSelectableIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstSelectableIcon_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181048, XrefRangeEnd = 181049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindLeftIcon(int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&column);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLeftIcon_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int FindLastSelectableIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLastSelectableIcon_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181049, XrefRangeEnd = 181052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandlePreviousTabInput(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandlePreviousTabInput_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181052, XrefRangeEnd = 181055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleNextTabInput(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleNextTabInput_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 181065, RefRangeEnd = 181093, XrefRangeStart = 181055, XrefRangeEnd = 181065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181093, XrefRangeEnd = 181096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TopMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TopMenu>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TopMenu()
	{
		Il2CppClassPointerStore<TopMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "TopMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopMenu>.NativeClassPtr);
		NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "icons");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_categoryLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "categoryLabels");
		NativeFieldInfoPtr_shopBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "shopBG");
		NativeFieldInfoPtr_blur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "blur");
		NativeFieldInfoPtr_topMenuSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "topMenuSelected");
		NativeFieldInfoPtr_disabledBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "disabledBG");
		NativeFieldInfoPtr_selectableIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "selectableIcons");
		NativeFieldInfoPtr_currentSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "currentSelected");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_behaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "behaviour");
		NativeFieldInfoPtr_iconsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "iconsCount");
		NativeFieldInfoPtr_enabledIconsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "enabledIconsCount");
		NativeFieldInfoPtr_IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "IsInitialized");
		NativeFieldInfoPtr_onSelectedIconChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "onSelectedIconChange");
		NativeFieldInfoPtr_onIconClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "onIconClick");
		NativeFieldInfoPtr_horizontalLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "horizontalLayoutGroup");
		NativeFieldInfoPtr_previousButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "previousButton");
		NativeFieldInfoPtr_nextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "nextButton");
		NativeFieldInfoPtr_iconsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, "iconsEnabled");
		NativeMethodInfoPtr_Init_Public_Void_TopMenuMode_TopMenuBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676436);
		NativeMethodInfoPtr_UpdateTheme_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676437);
		NativeMethodInfoPtr_EnableBlur_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676438);
		NativeMethodInfoPtr_ShowDisabledBG_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676439);
		NativeMethodInfoPtr_PrepareShopFeatures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676440);
		NativeMethodInfoPtr_PrepareIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676441);
		NativeMethodInfoPtr_PrepareButtons_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676442);
		NativeMethodInfoPtr_RegisterButtonsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676443);
		NativeMethodInfoPtr_UnregisterButtonsEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676444);
		NativeMethodInfoPtr_OnButtonClick_Private_Void_TopMenuButtonID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676445);
		NativeMethodInfoPtr_DisableIcon_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676446);
		NativeMethodInfoPtr_UpdateEnabledIconsCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676447);
		NativeMethodInfoPtr_OnIconClick_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676448);
		NativeMethodInfoPtr_EnableIcons_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676449);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676450);
		NativeMethodInfoPtr_SetSelectedIcon_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676451);
		NativeMethodInfoPtr_GetCurrentSelectedIcon_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676452);
		NativeMethodInfoPtr_SelectIcon_Public_Void_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676453);
		NativeMethodInfoPtr_EnableSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676454);
		NativeMethodInfoPtr_RefreshSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676455);
		NativeMethodInfoPtr_HighlightCurrentIcon_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676456);
		NativeMethodInfoPtr_DeselectOtherThanCurrent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676457);
		NativeMethodInfoPtr_ModeToCategoryLabelType_Private_CategoryLabelType_TopMenuMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676458);
		NativeMethodInfoPtr_FindCategoryLabelForCurrentMode_Private_CategoryLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676459);
		NativeMethodInfoPtr_SetCategoryTextIfNeeded_Private_Void_LabeledSelectableIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676460);
		NativeMethodInfoPtr_SetCategoryText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676461);
		NativeMethodInfoPtr_AnimateSelectionToPos_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676462);
		NativeMethodInfoPtr_IsAnimationInProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676463);
		NativeMethodInfoPtr_GetCurrentSelectedIconImage_Public_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676464);
		NativeMethodInfoPtr_GetIconImage_Public_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676465);
		NativeMethodInfoPtr_DeselectIcon_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676466);
		NativeMethodInfoPtr_NextIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676467);
		NativeMethodInfoPtr_PreviousIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676468);
		NativeMethodInfoPtr_FindRightIcon_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676469);
		NativeMethodInfoPtr_FindFirstSelectableIcon_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676470);
		NativeMethodInfoPtr_FindLeftIcon_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676471);
		NativeMethodInfoPtr_FindLastSelectableIcon_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676472);
		NativeMethodInfoPtr_HandlePreviousTabInput_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676473);
		NativeMethodInfoPtr_HandleNextTabInput_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676474);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676475);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenu>.NativeClassPtr, 100676476);
	}

	public TopMenu(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
