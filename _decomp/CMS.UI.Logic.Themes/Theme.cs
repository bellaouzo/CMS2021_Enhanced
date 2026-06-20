using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.UI.Logic.Themes;

[StructLayout(LayoutKind.Explicit)]
public struct Theme
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NormalColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_HoverColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemSelectionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_TopMenuSelectedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_TopMenuSelectedIconColor;

	[FieldOffset(0)]
	public Color NormalColor;

	[FieldOffset(16)]
	public Color HoverColor;

	[FieldOffset(32)]
	public Color ItemSelectionColor;

	[FieldOffset(48)]
	public Color TopMenuSelectedColor;

	[FieldOffset(64)]
	public Color TopMenuSelectedIconColor;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Theme>.NativeClassPtr));

	static Theme()
	{
		Il2CppClassPointerStore<Theme>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Themes", "Theme");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Theme>.NativeClassPtr);
		NativeFieldInfoPtr_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theme>.NativeClassPtr, "NormalColor");
		NativeFieldInfoPtr_HoverColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theme>.NativeClassPtr, "HoverColor");
		NativeFieldInfoPtr_ItemSelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theme>.NativeClassPtr, "ItemSelectionColor");
		NativeFieldInfoPtr_TopMenuSelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theme>.NativeClassPtr, "TopMenuSelectedColor");
		NativeFieldInfoPtr_TopMenuSelectedIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theme>.NativeClassPtr, "TopMenuSelectedIconColor");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Theme>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
