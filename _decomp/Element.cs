using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Element
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AngleRangeOfborders;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAvailable;

	[FieldOffset(0)]
	public Vector2 AngleRangeOfborders;

	[FieldOffset(8)]
	public bool IsAvailable;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Element>.NativeClassPtr));

	static Element()
	{
		Il2CppClassPointerStore<Element>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Element");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Element>.NativeClassPtr);
		NativeFieldInfoPtr_AngleRangeOfborders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Element>.NativeClassPtr, "AngleRangeOfborders");
		NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Element>.NativeClassPtr, "IsAvailable");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Element>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
