using System;
using System.Runtime.InteropServices;
using CMS.UI.Logic;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Description;

[StructLayout(LayoutKind.Sequential)]
public sealed class Description : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Variant;

	private static readonly System.IntPtr NativeFieldInfoPtr_Action;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Description>.NativeClassPtr));

	public unsafe DescriptionVariant Variant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Variant);
			return *(DescriptionVariant*)num;
		}
		set
		{
			*(DescriptionVariant*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Variant)) = descriptionVariant;
		}
	}

	public unsafe string Action
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Action);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Action), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static Description()
	{
		Il2CppClassPointerStore<Description>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Description", "Description");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Description>.NativeClassPtr);
		NativeFieldInfoPtr_Variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Description>.NativeClassPtr, "Variant");
		NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Description>.NativeClassPtr, "Action");
	}

	public Description(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe Description()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Description>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Description>.NativeClassPtr))
	{
	}
}
