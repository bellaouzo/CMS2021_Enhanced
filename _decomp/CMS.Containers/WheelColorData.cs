using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct WheelColorData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HasColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllowedColor;

	[FieldOffset(0)]
	public bool HasColor;

	[FieldOffset(4)]
	public AllowedColor AllowedColor;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelColorData>.NativeClassPtr));

	static WheelColorData()
	{
		Il2CppClassPointerStore<WheelColorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "WheelColorData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelColorData>.NativeClassPtr);
		NativeFieldInfoPtr_HasColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelColorData>.NativeClassPtr, "HasColor");
		NativeFieldInfoPtr_AllowedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelColorData>.NativeClassPtr, "AllowedColor");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelColorData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
