using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class TutorialSubtitle : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_From;

	private static readonly System.IntPtr NativeFieldInfoPtr_To;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKey;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr));

	public unsafe double From
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_From);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_From)) = num;
		}
	}

	public unsafe double To
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_To);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_To)) = num;
		}
	}

	public unsafe string LocalizationKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static TutorialSubtitle()
	{
		Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "TutorialSubtitle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr);
		NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr, "From");
		NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr, "To");
		NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr, "LocalizationKey");
	}

	public TutorialSubtitle(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe TutorialSubtitle()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<TutorialSubtitle>.NativeClassPtr))
	{
	}
}
