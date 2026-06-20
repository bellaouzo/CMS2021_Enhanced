using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Explicit, Size = 1)]
public struct Channel
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Input;

	private static readonly System.IntPtr NativeFieldInfoPtr_Vehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_Settings;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Channel>.NativeClassPtr));

	public unsafe static int Input
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Input, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Input, &num);
		}
	}

	public unsafe static int Vehicle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Vehicle, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Vehicle, &num);
		}
	}

	public unsafe static int Settings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Settings, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Settings, &num);
		}
	}

	static Channel()
	{
		Il2CppClassPointerStore<Channel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Channel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Channel>.NativeClassPtr);
		NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "Input");
		NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "Vehicle");
		NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "Settings");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Channel>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
