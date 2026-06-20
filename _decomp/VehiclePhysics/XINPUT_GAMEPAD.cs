using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Explicit)]
public struct XINPUT_GAMEPAD
{
	private static readonly System.IntPtr NativeFieldInfoPtr_wButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_bLeftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_bRightTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_sThumbLX;

	private static readonly System.IntPtr NativeFieldInfoPtr_sThumbLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_sThumbRX;

	private static readonly System.IntPtr NativeFieldInfoPtr_sThumbRY;

	[FieldOffset(0)]
	public ushort wButtons;

	[FieldOffset(2)]
	public byte bLeftTrigger;

	[FieldOffset(3)]
	public byte bRightTrigger;

	[FieldOffset(4)]
	public short sThumbLX;

	[FieldOffset(6)]
	public short sThumbLY;

	[FieldOffset(8)]
	public short sThumbRX;

	[FieldOffset(10)]
	public short sThumbRY;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr));

	static XINPUT_GAMEPAD()
	{
		Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "XINPUT_GAMEPAD");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr);
		NativeFieldInfoPtr_wButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "wButtons");
		NativeFieldInfoPtr_bLeftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "bLeftTrigger");
		NativeFieldInfoPtr_bRightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "bRightTrigger");
		NativeFieldInfoPtr_sThumbLX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "sThumbLX");
		NativeFieldInfoPtr_sThumbLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "sThumbLY");
		NativeFieldInfoPtr_sThumbRX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "sThumbRX");
		NativeFieldInfoPtr_sThumbRY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, "sThumbRY");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XINPUT_GAMEPAD>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
