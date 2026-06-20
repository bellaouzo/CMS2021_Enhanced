using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class FloatArrayWrapper : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_element;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr));

	public unsafe Il2CppStructArray<float> element
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_element);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static FloatArrayWrapper()
	{
		Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FloatArrayWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr, "element");
	}

	public FloatArrayWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe FloatArrayWrapper()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr))
	{
	}
}
