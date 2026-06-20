using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class ImageTutorialData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKey;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ImageTutorialData>.NativeClassPtr));

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

	static ImageTutorialData()
	{
		Il2CppClassPointerStore<ImageTutorialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "ImageTutorialData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageTutorialData>.NativeClassPtr);
		NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageTutorialData>.NativeClassPtr, "LocalizationKey");
	}

	public ImageTutorialData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe ImageTutorialData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ImageTutorialData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<ImageTutorialData>.NativeClassPtr))
	{
	}
}
