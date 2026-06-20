using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Explicit, Size = 1)]
public struct SettingsData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DifferentialLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_DrivelineLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoShiftOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_AbsOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_TcsOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_EcsOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_AsrOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr__SETTINGS_SIZE;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SettingsData>.NativeClassPtr));

	public unsafe static int DifferentialLock
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DifferentialLock, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DifferentialLock, &num);
		}
	}

	public unsafe static int DrivelineLock
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DrivelineLock, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DrivelineLock, &num);
		}
	}

	public unsafe static int AutoShiftOverride
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoShiftOverride, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoShiftOverride, &num);
		}
	}

	public unsafe static int AbsOverride
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AbsOverride, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AbsOverride, &num);
		}
	}

	public unsafe static int TcsOverride
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TcsOverride, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TcsOverride, &num);
		}
	}

	public unsafe static int EcsOverride
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EcsOverride, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EcsOverride, &num);
		}
	}

	public unsafe static int AsrOverride
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AsrOverride, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AsrOverride, &num);
		}
	}

	public unsafe static int _SETTINGS_SIZE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SETTINGS_SIZE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SETTINGS_SIZE, &num);
		}
	}

	static SettingsData()
	{
		Il2CppClassPointerStore<SettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "SettingsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsData>.NativeClassPtr);
		NativeFieldInfoPtr_DifferentialLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DifferentialLock");
		NativeFieldInfoPtr_DrivelineLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "DrivelineLock");
		NativeFieldInfoPtr_AutoShiftOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "AutoShiftOverride");
		NativeFieldInfoPtr_AbsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "AbsOverride");
		NativeFieldInfoPtr_TcsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "TcsOverride");
		NativeFieldInfoPtr_EcsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "EcsOverride");
		NativeFieldInfoPtr_AsrOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "AsrOverride");
		NativeFieldInfoPtr__SETTINGS_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, "_SETTINGS_SIZE");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SettingsData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
