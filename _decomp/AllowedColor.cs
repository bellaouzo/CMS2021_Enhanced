using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AllowedColor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	[FieldOffset(0)]
	public Color Color;

	[FieldOffset(16)]
	public PaintType PaintType;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AllowedColor>.NativeClassPtr));

	static AllowedColor()
	{
		Il2CppClassPointerStore<AllowedColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AllowedColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllowedColor>.NativeClassPtr);
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllowedColor>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllowedColor>.NativeClassPtr, "PaintType");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllowedColor>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
