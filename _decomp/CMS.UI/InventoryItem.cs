using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CMS.UI;

public class InventoryItem : GridItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_realID;

	private static readonly System.IntPtr NativeFieldInfoPtr_realPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChecked;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryItemGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_items;

	private static readonly System.IntPtr NativeFieldInfoPtr_condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_conditionPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_caption;

	private static readonly System.IntPtr NativeFieldInfoPtr_brand;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_liveryIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_qualityStar1;

	private static readonly System.IntPtr NativeFieldInfoPtr_qualityStar2;

	private static readonly System.IntPtr NativeFieldInfoPtr_qualityStar3;

	private static readonly System.IntPtr NativeFieldInfoPtr_unbalancedIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningBrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnMouseClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSpecial;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepairLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Locked;

	private static readonly System.IntPtr NativeFieldInfoPtr_LockedText;

	private static readonly System.IntPtr NativeFieldInfoPtr_SupportsPointerEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_SupportsPointerClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgSolid;

	private static readonly System.IntPtr NativeFieldInfoPtr__EnableHover_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableHover_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableHover_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowHover_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr));

	public unsafe BetterButtonAction ButtonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BetterButtonAction(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonAction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe long ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID)) = num;
		}
	}

	public unsafe string realID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int realPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realPrice)) = num;
		}
	}

	public unsafe bool isChecked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChecked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChecked)) = flag;
		}
	}

	public unsafe Image inventoryItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform inventoryItemGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItemGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItemGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Image> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image condition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text conditionPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionPercentage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionPercentage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text caption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caption);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caption), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image liveryIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveryIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveryIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform quality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quality);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quality), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image qualityStar1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityStar1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityStar1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image qualityStar2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityStar2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityStar2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image qualityStar3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityStar3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityStar3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image unbalancedIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unbalancedIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unbalancedIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform tuningIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image tuningBG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningBG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningBG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject tuningPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningPower);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningPower), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject tuningBrake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningBrake);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningBrake), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text tuningValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject checkmark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkmark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkmark), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<int, int> OnMouseClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseClick);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int, int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseClick), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsSpecial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSpecial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSpecial)) = flag;
		}
	}

	public unsafe bool IsGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGroup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGroup)) = flag;
		}
	}

	public unsafe bool IsLocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLocked)) = flag;
		}
	}

	public unsafe int RepairLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairLevel)) = num;
		}
	}

	public unsafe GameObject Locked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Locked);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Locked), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text LockedText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LockedText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LockedText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool SupportsPointerEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportsPointerEnter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportsPointerEnter)) = flag;
		}
	}

	public unsafe bool SupportsPointerClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportsPointerClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportsPointerClick)) = flag;
		}
	}

	public unsafe Image bgSolid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgSolid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgSolid), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _EnableHover_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnableHover_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnableHover_k__BackingField)) = flag;
		}
	}

	public unsafe bool EnableHover
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableHover_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableHover_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151185, XrefRangeEnd = 151189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151189, XrefRangeEnd = 151190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151190, XrefRangeEnd = 151195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151195, XrefRangeEnd = 151198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151198, XrefRangeEnd = 151199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151199, XrefRangeEnd = 151201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 151208, RefRangeEnd = 151211, XrefRangeStart = 151201, XrefRangeEnd = 151208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowHover(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowHover_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 151227, RefRangeEnd = 151231, XrefRangeStart = 151211, XrefRangeEnd = 151227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151231, XrefRangeEnd = 151234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InventoryItem()
	{
		Il2CppClassPointerStore<InventoryItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI", "InventoryItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr);
		NativeFieldInfoPtr_ButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "ButtonAction");
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_realID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "realID");
		NativeFieldInfoPtr_realPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "realPrice");
		NativeFieldInfoPtr_isChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "isChecked");
		NativeFieldInfoPtr_inventoryItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "inventoryItem");
		NativeFieldInfoPtr_inventoryItemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "inventoryItemGroup");
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "items");
		NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "condition");
		NativeFieldInfoPtr_conditionPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "conditionPercentage");
		NativeFieldInfoPtr_caption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "caption");
		NativeFieldInfoPtr_brand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "brand");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "color");
		NativeFieldInfoPtr_liveryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "liveryIcon");
		NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "quality");
		NativeFieldInfoPtr_qualityStar1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "qualityStar1");
		NativeFieldInfoPtr_qualityStar2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "qualityStar2");
		NativeFieldInfoPtr_qualityStar3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "qualityStar3");
		NativeFieldInfoPtr_unbalancedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "unbalancedIcon");
		NativeFieldInfoPtr_tuningIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "tuningIcon");
		NativeFieldInfoPtr_tuningBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "tuningBG");
		NativeFieldInfoPtr_tuningPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "tuningPower");
		NativeFieldInfoPtr_tuningBrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "tuningBrake");
		NativeFieldInfoPtr_tuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "tuningValue");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "price");
		NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "checkmark");
		NativeFieldInfoPtr_OnMouseClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "OnMouseClick");
		NativeFieldInfoPtr_IsSpecial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "IsSpecial");
		NativeFieldInfoPtr_IsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "IsGroup");
		NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "IsLocked");
		NativeFieldInfoPtr_RepairLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "RepairLevel");
		NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "Locked");
		NativeFieldInfoPtr_LockedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "LockedText");
		NativeFieldInfoPtr_SupportsPointerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "SupportsPointerEnter");
		NativeFieldInfoPtr_SupportsPointerClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "SupportsPointerClick");
		NativeFieldInfoPtr_bgSolid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "bgSolid");
		NativeFieldInfoPtr__EnableHover_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, "<EnableHover>k__BackingField");
		NativeMethodInfoPtr_get_EnableHover_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673835);
		NativeMethodInfoPtr_set_EnableHover_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673836);
		NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673837);
		NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673838);
		NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673839);
		NativeMethodInfoPtr_Select_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673840);
		NativeMethodInfoPtr_Deselect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673841);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673842);
		NativeMethodInfoPtr_ShowHover_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673843);
		NativeMethodInfoPtr_EnableSelection_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673844);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItem>.NativeClassPtr, 100673845);
	}

	public InventoryItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
