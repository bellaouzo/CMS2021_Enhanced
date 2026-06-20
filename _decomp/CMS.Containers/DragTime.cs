using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Explicit)]
public struct DragTime
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Speed;

	[FieldOffset(0)]
	public DragCheckpointType Type;

	[FieldOffset(8)]
	public long ElapsedTime;

	[FieldOffset(16)]
	public bool HasSpeed;

	[FieldOffset(20)]
	public float Speed;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragTime>.NativeClassPtr));

	static DragTime()
	{
		Il2CppClassPointerStore<DragTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "DragTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragTime>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTime>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTime>.NativeClassPtr, "ElapsedTime");
		NativeFieldInfoPtr_HasSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTime>.NativeClassPtr, "HasSpeed");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTime>.NativeClassPtr, "Speed");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DragTime>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
