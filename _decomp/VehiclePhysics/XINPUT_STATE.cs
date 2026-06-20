using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Explicit)]
public struct XINPUT_STATE
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dwPacketNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_xState;

	[FieldOffset(0)]
	public uint dwPacketNumber;

	[FieldOffset(4)]
	public XINPUT_GAMEPAD xState;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XINPUT_STATE>.NativeClassPtr));

	static XINPUT_STATE()
	{
		Il2CppClassPointerStore<XINPUT_STATE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "XINPUT_STATE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XINPUT_STATE>.NativeClassPtr);
		NativeFieldInfoPtr_dwPacketNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_STATE>.NativeClassPtr, "dwPacketNumber");
		NativeFieldInfoPtr_xState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_STATE>.NativeClassPtr, "xState");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XINPUT_STATE>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
