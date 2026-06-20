using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Explicit, Size = 1)]
public struct InputData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Steer;

	private static readonly System.IntPtr NativeFieldInfoPtr_Throttle;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brake;

	private static readonly System.IntPtr NativeFieldInfoPtr_Handbrake;

	private static readonly System.IntPtr NativeFieldInfoPtr_Clutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_ManualGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutomaticGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearShift;

	private static readonly System.IntPtr NativeFieldInfoPtr_Retarder;

	private static readonly System.IntPtr NativeFieldInfoPtr_Key;

	private static readonly System.IntPtr NativeFieldInfoPtr__STDINPUT_SIZE;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InputData>.NativeClassPtr));

	public unsafe static int Steer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Steer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Steer, &num);
		}
	}

	public unsafe static int Throttle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Throttle, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Throttle, &num);
		}
	}

	public unsafe static int Brake
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Brake, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Brake, &num);
		}
	}

	public unsafe static int Handbrake
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Handbrake, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Handbrake, &num);
		}
	}

	public unsafe static int Clutch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Clutch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Clutch, &num);
		}
	}

	public unsafe static int ManualGear
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ManualGear, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ManualGear, &num);
		}
	}

	public unsafe static int AutomaticGear
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutomaticGear, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutomaticGear, &num);
		}
	}

	public unsafe static int GearShift
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GearShift, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GearShift, &num);
		}
	}

	public unsafe static int Retarder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Retarder, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Retarder, &num);
		}
	}

	public unsafe static int Key
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Key, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Key, &num);
		}
	}

	public unsafe static int _STDINPUT_SIZE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__STDINPUT_SIZE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__STDINPUT_SIZE, &num);
		}
	}

	static InputData()
	{
		Il2CppClassPointerStore<InputData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "InputData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputData>.NativeClassPtr);
		NativeFieldInfoPtr_Steer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Steer");
		NativeFieldInfoPtr_Throttle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Throttle");
		NativeFieldInfoPtr_Brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Brake");
		NativeFieldInfoPtr_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Handbrake");
		NativeFieldInfoPtr_Clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Clutch");
		NativeFieldInfoPtr_ManualGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "ManualGear");
		NativeFieldInfoPtr_AutomaticGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "AutomaticGear");
		NativeFieldInfoPtr_GearShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "GearShift");
		NativeFieldInfoPtr_Retarder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Retarder");
		NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Key");
		NativeFieldInfoPtr__STDINPUT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "_STDINPUT_SIZE");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
