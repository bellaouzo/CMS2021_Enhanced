using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

public class ChoosePartDownItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BaseItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForSalon;

	private static readonly System.IntPtr NativeFieldInfoPtr_Price;

	private static readonly System.IntPtr NativeFieldInfoPtr_Checked;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepairLevel;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseItem_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr));

	public unsafe BaseItem BaseItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool ForSalon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForSalon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForSalon)) = flag;
		}
	}

	public unsafe int Price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Price)) = num;
		}
	}

	public unsafe bool Checked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Checked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Checked)) = flag;
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

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ChoosePartDownItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ChoosePartDownItem(BaseItem baseItem)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChoosePartDownItem()
	{
		Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "ChoosePartDownItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr);
		NativeFieldInfoPtr_BaseItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, "BaseItem");
		NativeFieldInfoPtr_ForSalon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, "ForSalon");
		NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, "Price");
		NativeFieldInfoPtr_Checked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, "Checked");
		NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, "IsLocked");
		NativeFieldInfoPtr_RepairLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, "RepairLevel");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, 100679762);
		NativeMethodInfoPtr__ctor_Public_Void_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoosePartDownItem>.NativeClassPtr, 100679763);
	}

	public ChoosePartDownItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
