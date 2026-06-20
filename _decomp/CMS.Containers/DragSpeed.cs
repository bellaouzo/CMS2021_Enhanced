using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Explicit)]
public struct DragSpeed
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;

	[FieldOffset(0)]
	public DragSpeedType Type;

	[FieldOffset(8)]
	public long ElapsedTime;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragSpeed>.NativeClassPtr));

	static DragSpeed()
	{
		Il2CppClassPointerStore<DragSpeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "DragSpeed");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragSpeed>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSpeed>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSpeed>.NativeClassPtr, "ElapsedTime");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DragSpeed>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
