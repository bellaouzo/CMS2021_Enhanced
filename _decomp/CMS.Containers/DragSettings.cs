using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Explicit)]
public struct DragSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_Class;

	[FieldOffset(0)]
	public DragType Type;

	[FieldOffset(1)]
	public DragLength Length;

	[FieldOffset(2)]
	public DragClass Class;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragSettings>.NativeClassPtr));

	static DragSettings()
	{
		Il2CppClassPointerStore<DragSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "DragSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragSettings>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSettings>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSettings>.NativeClassPtr, "Length");
		NativeFieldInfoPtr_Class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSettings>.NativeClassPtr, "Class");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DragSettings>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
