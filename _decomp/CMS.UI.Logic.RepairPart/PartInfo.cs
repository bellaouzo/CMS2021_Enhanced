using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic.RepairPart;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class PartInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Item;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepairCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuccessCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_FailCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentSuccessCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentFailCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_DentCurrentCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_InstantRepair;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartInfo>.NativeClassPtr));

	public unsafe Item Item
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Item);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int RepairCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairCost)) = num;
		}
	}

	public unsafe float SuccessCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuccessCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuccessCondition)) = num;
		}
	}

	public unsafe float FailCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FailCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FailCondition)) = num;
		}
	}

	public unsafe float CurrentCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentCondition)) = num;
		}
	}

	public unsafe float DentSuccessCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DentSuccessCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DentSuccessCondition)) = num;
		}
	}

	public unsafe float DentFailCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DentFailCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DentFailCondition)) = num;
		}
	}

	public unsafe float DentCurrentCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DentCurrentCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DentCurrentCondition)) = num;
		}
	}

	public unsafe bool InstantRepair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantRepair);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InstantRepair)) = flag;
		}
	}

	static PartInfo()
	{
		Il2CppClassPointerStore<PartInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.RepairPart", "PartInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "Item");
		NativeFieldInfoPtr_RepairCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "RepairCost");
		NativeFieldInfoPtr_SuccessCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "SuccessCondition");
		NativeFieldInfoPtr_FailCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "FailCondition");
		NativeFieldInfoPtr_CurrentCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "CurrentCondition");
		NativeFieldInfoPtr_DentSuccessCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "DentSuccessCondition");
		NativeFieldInfoPtr_DentFailCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "DentFailCondition");
		NativeFieldInfoPtr_DentCurrentCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "DentCurrentCondition");
		NativeFieldInfoPtr_InstantRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, "InstantRepair");
	}

	public PartInfo(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe PartInfo()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PartInfo>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<PartInfo>.NativeClassPtr))
	{
	}
}
