using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.Containers;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class CaseOpeningCardData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CardType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Thumbnail;

	private static readonly System.IntPtr NativeFieldInfoPtr_Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mark;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr));

	public unsafe CaseCardType CardType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CardType);
			return *(CaseCardType*)num;
		}
		set
		{
			*(CaseCardType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CardType)) = caseCardType;
		}
	}

	public unsafe Sprite Thumbnail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Thumbnail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Thumbnail), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value)) = num;
		}
	}

	public unsafe string Mark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mark);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mark), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static CaseOpeningCardData()
	{
		Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "CaseOpeningCardData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr);
		NativeFieldInfoPtr_CardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr, "CardType");
		NativeFieldInfoPtr_Thumbnail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr, "Thumbnail");
		NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr, "Value");
		NativeFieldInfoPtr_Mark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr, "Mark");
	}

	public CaseOpeningCardData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe CaseOpeningCardData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<CaseOpeningCardData>.NativeClassPtr))
	{
	}
}
