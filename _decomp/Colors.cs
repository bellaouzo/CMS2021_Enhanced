using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

public static class Colors : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DotActiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DotNormalColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityStarActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityStarInActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConditionGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConditionYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConditionOrange;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConditionRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_StarDisabledColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_StarHighlightedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_StarSelectedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedPartColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExaminedPartColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnmountedPartColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoneyGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoneyOrange;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoneyYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_Active;

	private static readonly System.IntPtr NativeFieldInfoPtr_Unactive;

	private static readonly System.IntPtr NativeFieldInfoPtr_BarSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_BarFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_BarNeutral;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultArrowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_InventoryItemNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_InventoryItemHover;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnknownCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrderItemDone;

	private static readonly System.IntPtr NativeFieldInfoPtr_JunkItemColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultTintColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LockedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Grey1;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedItemBackgroundColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalItemBackgroundColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_LockedColor2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonSelectedNotActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonNonActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonLocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_LockedBars;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextNonActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextLockedWithBars;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextLocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCViolet;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityOrange;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_QualityRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_ErrorRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionBlueText;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepairGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainMenuButtonActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainMenuButtonHighlighted;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainMenuButtonPressed;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainMenuButtonDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalButtonColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighlightedButtonColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_PressedButtonColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisabledButtonColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScrapBigBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeLockedIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeUnlockedIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeLockedBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeAvailableBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradeRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_BidCircleStandardColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_BidCircleWinColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_BidCircleLoseColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassA;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassB;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassC;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassD;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassAHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassBHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassCHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassDHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragClassEHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_DriveAssistanceEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_DriveAssistanceDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_DriveAssistanceEngaged;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Colors>.NativeClassPtr));

	public unsafe static Color DotActiveColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DotActiveColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DotActiveColor, &color);
		}
	}

	public unsafe static Color DotNormalColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DotNormalColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DotNormalColor, &color);
		}
	}

	public unsafe static Color QualityStarActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityStarActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityStarActive, &color);
		}
	}

	public unsafe static Color QualityStarInActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityStarInActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityStarInActive, &color);
		}
	}

	public unsafe static Color ConditionGreen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConditionGreen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConditionGreen, &color);
		}
	}

	public unsafe static Color ConditionYellow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConditionYellow, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConditionYellow, &color);
		}
	}

	public unsafe static Color ConditionOrange
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConditionOrange, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConditionOrange, &color);
		}
	}

	public unsafe static Color ConditionRed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConditionRed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConditionRed, &color);
		}
	}

	public unsafe static Color StarDisabledColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StarDisabledColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StarDisabledColor, &color);
		}
	}

	public unsafe static Color StarHighlightedColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StarHighlightedColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StarHighlightedColor, &color);
		}
	}

	public unsafe static Color StarSelectedColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StarSelectedColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StarSelectedColor, &color);
		}
	}

	public unsafe static Color SelectedPartColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelectedPartColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelectedPartColor, &color);
		}
	}

	public unsafe static Color ExaminedPartColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExaminedPartColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExaminedPartColor, &color);
		}
	}

	public unsafe static Color UnmountedPartColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnmountedPartColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnmountedPartColor, &color);
		}
	}

	public unsafe static string MoneyGreen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoneyGreen, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoneyGreen, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string MoneyOrange
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoneyOrange, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoneyOrange, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string MoneyYellow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoneyYellow, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoneyYellow, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static Color Active
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Active, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Active, &color);
		}
	}

	public unsafe static Color Unactive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Unactive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Unactive, &color);
		}
	}

	public unsafe static Color BarSuccess
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BarSuccess, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BarSuccess, &color);
		}
	}

	public unsafe static Color BarFail
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BarFail, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BarFail, &color);
		}
	}

	public unsafe static Color BarNeutral
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BarNeutral, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BarNeutral, &color);
		}
	}

	public unsafe static Color DefaultArrowColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultArrowColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultArrowColor, &color);
		}
	}

	public unsafe static Color InventoryItemNormal
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InventoryItemNormal, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InventoryItemNormal, &color);
		}
	}

	public unsafe static Color InventoryItemHover
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InventoryItemHover, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InventoryItemHover, &color);
		}
	}

	public unsafe static Color UnknownCondition
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnknownCondition, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnknownCondition, &color);
		}
	}

	public unsafe static Color OrderItemDone
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OrderItemDone, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OrderItemDone, &color);
		}
	}

	public unsafe static CustomColor JunkItemColor
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JunkItemColor, (void*)intPtr);
			return new CustomColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JunkItemColor, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj)));
		}
	}

	public unsafe static Color DefaultTintColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultTintColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultTintColor, &color);
		}
	}

	public unsafe static Color SelectColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelectColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelectColor, &color);
		}
	}

	public unsafe static Color NormalColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NormalColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NormalColor, &color);
		}
	}

	public unsafe static Color LockedColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LockedColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LockedColor, &color);
		}
	}

	public unsafe static Color Grey1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Grey1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Grey1, &color);
		}
	}

	public unsafe static Color SelectedItemBackgroundColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelectedItemBackgroundColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelectedItemBackgroundColor, &color);
		}
	}

	public unsafe static Color NormalItemBackgroundColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NormalItemBackgroundColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NormalItemBackgroundColor, &color);
		}
	}

	public unsafe static Color LockedColor2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LockedColor2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LockedColor2, &color);
		}
	}

	public unsafe static Color ButtonSelected
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonSelected, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonSelected, &color);
		}
	}

	public unsafe static Color ButtonSelectedNotActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonSelectedNotActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonSelectedNotActive, &color);
		}
	}

	public unsafe static Color ButtonActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonActive, &color);
		}
	}

	public unsafe static Color ButtonNonActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonNonActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonNonActive, &color);
		}
	}

	public unsafe static Color ButtonLocked
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonLocked, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonLocked, &color);
		}
	}

	public unsafe static Color LockedBars
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LockedBars, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LockedBars, &color);
		}
	}

	public unsafe static Color TextSelected
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextSelected, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextSelected, &color);
		}
	}

	public unsafe static Color TextActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextActive, &color);
		}
	}

	public unsafe static Color TextNonActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextNonActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextNonActive, &color);
		}
	}

	public unsafe static Color TextLockedWithBars
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextLockedWithBars, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextLockedWithBars, &color);
		}
	}

	public unsafe static Color TextLocked
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TextLocked, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TextLocked, &color);
		}
	}

	public unsafe static Color DLCViolet
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DLCViolet, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DLCViolet, &color);
		}
	}

	public unsafe static Color QualityGreen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityGreen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityGreen, &color);
		}
	}

	public unsafe static Color QualityOrange
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityOrange, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityOrange, &color);
		}
	}

	public unsafe static Color QualityYellow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityYellow, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityYellow, &color);
		}
	}

	public unsafe static Color QualityRed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QualityRed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QualityRed, &color);
		}
	}

	public unsafe static Color ErrorRed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ErrorRed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ErrorRed, &color);
		}
	}

	public unsafe static Color MissionBlueText
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionBlueText, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionBlueText, &color);
		}
	}

	public unsafe static Color RepairGreen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RepairGreen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RepairGreen, &color);
		}
	}

	public unsafe static Color MainMenuButtonActive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainMenuButtonActive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainMenuButtonActive, &color);
		}
	}

	public unsafe static Color MainMenuButtonHighlighted
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainMenuButtonHighlighted, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainMenuButtonHighlighted, &color);
		}
	}

	public unsafe static Color MainMenuButtonPressed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainMenuButtonPressed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainMenuButtonPressed, &color);
		}
	}

	public unsafe static Color MainMenuButtonDisabled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainMenuButtonDisabled, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainMenuButtonDisabled, &color);
		}
	}

	public unsafe static Color NormalButtonColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NormalButtonColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NormalButtonColor, &color);
		}
	}

	public unsafe static Color HighlightedButtonColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HighlightedButtonColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HighlightedButtonColor, &color);
		}
	}

	public unsafe static Color PressedButtonColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PressedButtonColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PressedButtonColor, &color);
		}
	}

	public unsafe static Color DisabledButtonColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisabledButtonColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisabledButtonColor, &color);
		}
	}

	public unsafe static Color ScrapBigBonus
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ScrapBigBonus, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ScrapBigBonus, &color);
		}
	}

	public unsafe static Color UpgradeLockedIcon
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpgradeLockedIcon, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpgradeLockedIcon, &color);
		}
	}

	public unsafe static Color UpgradeUnlockedIcon
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpgradeUnlockedIcon, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpgradeUnlockedIcon, &color);
		}
	}

	public unsafe static Color UpgradeLockedBG
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpgradeLockedBG, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpgradeLockedBG, &color);
		}
	}

	public unsafe static Color UpgradeAvailableBG
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpgradeAvailableBG, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpgradeAvailableBG, &color);
		}
	}

	public unsafe static Color UpgradeGreen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpgradeGreen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpgradeGreen, &color);
		}
	}

	public unsafe static Color UpgradeRed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpgradeRed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpgradeRed, &color);
		}
	}

	public unsafe static Color BidCircleStandardColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BidCircleStandardColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BidCircleStandardColor, &color);
		}
	}

	public unsafe static Color BidCircleWinColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BidCircleWinColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BidCircleWinColor, &color);
		}
	}

	public unsafe static Color BidCircleLoseColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BidCircleLoseColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BidCircleLoseColor, &color);
		}
	}

	public unsafe static Color DragClassA
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassA, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassA, &color);
		}
	}

	public unsafe static Color DragClassB
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassB, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassB, &color);
		}
	}

	public unsafe static Color DragClassC
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassC, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassC, &color);
		}
	}

	public unsafe static Color DragClassD
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassD, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassD, &color);
		}
	}

	public unsafe static Color DragClassE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassE, &color);
		}
	}

	public unsafe static string DragClassAHex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassAHex, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassAHex, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DragClassBHex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassBHex, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassBHex, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DragClassCHex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassCHex, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassCHex, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DragClassDHex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassDHex, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassDHex, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DragClassEHex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DragClassEHex, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DragClassEHex, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static Color DriveAssistanceEnabled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DriveAssistanceEnabled, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DriveAssistanceEnabled, &color);
		}
	}

	public unsafe static Color DriveAssistanceDisabled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DriveAssistanceDisabled, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DriveAssistanceDisabled, &color);
		}
	}

	public unsafe static Color DriveAssistanceEngaged
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DriveAssistanceEngaged, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DriveAssistanceEngaged, &color);
		}
	}

	static Colors()
	{
		Il2CppClassPointerStore<Colors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Colors");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Colors>.NativeClassPtr);
		NativeFieldInfoPtr_DotActiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DotActiveColor");
		NativeFieldInfoPtr_DotNormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DotNormalColor");
		NativeFieldInfoPtr_QualityStarActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "QualityStarActive");
		NativeFieldInfoPtr_QualityStarInActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "QualityStarInActive");
		NativeFieldInfoPtr_ConditionGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ConditionGreen");
		NativeFieldInfoPtr_ConditionYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ConditionYellow");
		NativeFieldInfoPtr_ConditionOrange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ConditionOrange");
		NativeFieldInfoPtr_ConditionRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ConditionRed");
		NativeFieldInfoPtr_StarDisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "StarDisabledColor");
		NativeFieldInfoPtr_StarHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "StarHighlightedColor");
		NativeFieldInfoPtr_StarSelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "StarSelectedColor");
		NativeFieldInfoPtr_SelectedPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "SelectedPartColor");
		NativeFieldInfoPtr_ExaminedPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ExaminedPartColor");
		NativeFieldInfoPtr_UnmountedPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UnmountedPartColor");
		NativeFieldInfoPtr_MoneyGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MoneyGreen");
		NativeFieldInfoPtr_MoneyOrange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MoneyOrange");
		NativeFieldInfoPtr_MoneyYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MoneyYellow");
		NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "Active");
		NativeFieldInfoPtr_Unactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "Unactive");
		NativeFieldInfoPtr_BarSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "BarSuccess");
		NativeFieldInfoPtr_BarFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "BarFail");
		NativeFieldInfoPtr_BarNeutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "BarNeutral");
		NativeFieldInfoPtr_DefaultArrowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DefaultArrowColor");
		NativeFieldInfoPtr_InventoryItemNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "InventoryItemNormal");
		NativeFieldInfoPtr_InventoryItemHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "InventoryItemHover");
		NativeFieldInfoPtr_UnknownCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UnknownCondition");
		NativeFieldInfoPtr_OrderItemDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "OrderItemDone");
		NativeFieldInfoPtr_JunkItemColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "JunkItemColor");
		NativeFieldInfoPtr_DefaultTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DefaultTintColor");
		NativeFieldInfoPtr_SelectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "SelectColor");
		NativeFieldInfoPtr_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "NormalColor");
		NativeFieldInfoPtr_LockedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "LockedColor");
		NativeFieldInfoPtr_Grey1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "Grey1");
		NativeFieldInfoPtr_SelectedItemBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "SelectedItemBackgroundColor");
		NativeFieldInfoPtr_NormalItemBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "NormalItemBackgroundColor");
		NativeFieldInfoPtr_LockedColor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "LockedColor2");
		NativeFieldInfoPtr_ButtonSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ButtonSelected");
		NativeFieldInfoPtr_ButtonSelectedNotActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ButtonSelectedNotActive");
		NativeFieldInfoPtr_ButtonActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ButtonActive");
		NativeFieldInfoPtr_ButtonNonActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ButtonNonActive");
		NativeFieldInfoPtr_ButtonLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ButtonLocked");
		NativeFieldInfoPtr_LockedBars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "LockedBars");
		NativeFieldInfoPtr_TextSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "TextSelected");
		NativeFieldInfoPtr_TextActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "TextActive");
		NativeFieldInfoPtr_TextNonActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "TextNonActive");
		NativeFieldInfoPtr_TextLockedWithBars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "TextLockedWithBars");
		NativeFieldInfoPtr_TextLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "TextLocked");
		NativeFieldInfoPtr_DLCViolet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DLCViolet");
		NativeFieldInfoPtr_QualityGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "QualityGreen");
		NativeFieldInfoPtr_QualityOrange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "QualityOrange");
		NativeFieldInfoPtr_QualityYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "QualityYellow");
		NativeFieldInfoPtr_QualityRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "QualityRed");
		NativeFieldInfoPtr_ErrorRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ErrorRed");
		NativeFieldInfoPtr_MissionBlueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MissionBlueText");
		NativeFieldInfoPtr_RepairGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "RepairGreen");
		NativeFieldInfoPtr_MainMenuButtonActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MainMenuButtonActive");
		NativeFieldInfoPtr_MainMenuButtonHighlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MainMenuButtonHighlighted");
		NativeFieldInfoPtr_MainMenuButtonPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MainMenuButtonPressed");
		NativeFieldInfoPtr_MainMenuButtonDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "MainMenuButtonDisabled");
		NativeFieldInfoPtr_NormalButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "NormalButtonColor");
		NativeFieldInfoPtr_HighlightedButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "HighlightedButtonColor");
		NativeFieldInfoPtr_PressedButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "PressedButtonColor");
		NativeFieldInfoPtr_DisabledButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DisabledButtonColor");
		NativeFieldInfoPtr_ScrapBigBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "ScrapBigBonus");
		NativeFieldInfoPtr_UpgradeLockedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UpgradeLockedIcon");
		NativeFieldInfoPtr_UpgradeUnlockedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UpgradeUnlockedIcon");
		NativeFieldInfoPtr_UpgradeLockedBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UpgradeLockedBG");
		NativeFieldInfoPtr_UpgradeAvailableBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UpgradeAvailableBG");
		NativeFieldInfoPtr_UpgradeGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UpgradeGreen");
		NativeFieldInfoPtr_UpgradeRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "UpgradeRed");
		NativeFieldInfoPtr_BidCircleStandardColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "BidCircleStandardColor");
		NativeFieldInfoPtr_BidCircleWinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "BidCircleWinColor");
		NativeFieldInfoPtr_BidCircleLoseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "BidCircleLoseColor");
		NativeFieldInfoPtr_DragClassA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassA");
		NativeFieldInfoPtr_DragClassB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassB");
		NativeFieldInfoPtr_DragClassC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassC");
		NativeFieldInfoPtr_DragClassD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassD");
		NativeFieldInfoPtr_DragClassE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassE");
		NativeFieldInfoPtr_DragClassAHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassAHex");
		NativeFieldInfoPtr_DragClassBHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassBHex");
		NativeFieldInfoPtr_DragClassCHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassCHex");
		NativeFieldInfoPtr_DragClassDHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassDHex");
		NativeFieldInfoPtr_DragClassEHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DragClassEHex");
		NativeFieldInfoPtr_DriveAssistanceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DriveAssistanceEnabled");
		NativeFieldInfoPtr_DriveAssistanceDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DriveAssistanceDisabled");
		NativeFieldInfoPtr_DriveAssistanceEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Colors>.NativeClassPtr, "DriveAssistanceEngaged");
	}

	public Colors(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
