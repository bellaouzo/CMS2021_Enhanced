using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.Containers;

[StructLayout(LayoutKind.Explicit)]
public struct TintState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsTinted;

	private static readonly System.IntPtr NativeFieldInfoPtr_Opacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	[FieldOffset(0)]
	public bool IsTinted;

	[FieldOffset(4)]
	public int Opacity;

	[FieldOffset(8)]
	public Color Color;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TintState>.NativeClassPtr));

	static TintState()
	{
		Il2CppClassPointerStore<TintState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "TintState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TintState>.NativeClassPtr);
		NativeFieldInfoPtr_IsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintState>.NativeClassPtr, "IsTinted");
		NativeFieldInfoPtr_Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintState>.NativeClassPtr, "Opacity");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TintState>.NativeClassPtr, "Color");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TintState>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
