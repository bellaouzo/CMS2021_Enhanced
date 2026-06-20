using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class UIWindowProperties : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr));

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
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

	static UIWindowProperties()
	{
		Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UIWindowProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr, "name");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr, "isActive");
	}

	public UIWindowProperties(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe UIWindowProperties()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<UIWindowProperties>.NativeClassPtr))
	{
	}
}
