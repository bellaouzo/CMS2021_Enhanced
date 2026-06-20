using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Explicit, Size = 1)]
public struct VehicleData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineStalled;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineWorking;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineLimiter;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnginePower;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineFuelRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClutchTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClutchLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearboxGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearboxMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearboxShifting;

	private static readonly System.IntPtr NativeFieldInfoPtr_RetarderTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_AbsEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_TcsEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_EscEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_AsrEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_AidedSteer;

	private static readonly System.IntPtr NativeFieldInfoPtr__VEHICLE_SIZE;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VehicleData>.NativeClassPtr));

	public unsafe static int Speed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Speed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Speed, &num);
		}
	}

	public unsafe static int EngineRpm
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineRpm, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineRpm, &num);
		}
	}

	public unsafe static int EngineStalled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineStalled, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineStalled, &num);
		}
	}

	public unsafe static int EngineWorking
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineWorking, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineWorking, &num);
		}
	}

	public unsafe static int EngineLimiter
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineLimiter, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineLimiter, &num);
		}
	}

	public unsafe static int EngineLoad
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineLoad, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineLoad, &num);
		}
	}

	public unsafe static int EngineTorque
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineTorque, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineTorque, &num);
		}
	}

	public unsafe static int EnginePower
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnginePower, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnginePower, &num);
		}
	}

	public unsafe static int EngineFuelRate
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EngineFuelRate, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EngineFuelRate, &num);
		}
	}

	public unsafe static int ClutchTorque
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClutchTorque, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClutchTorque, &num);
		}
	}

	public unsafe static int ClutchLock
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClutchLock, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClutchLock, &num);
		}
	}

	public unsafe static int GearboxGear
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GearboxGear, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GearboxGear, &num);
		}
	}

	public unsafe static int GearboxMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GearboxMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GearboxMode, &num);
		}
	}

	public unsafe static int GearboxShifting
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GearboxShifting, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GearboxShifting, &num);
		}
	}

	public unsafe static int RetarderTorque
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RetarderTorque, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RetarderTorque, &num);
		}
	}

	public unsafe static int AbsEngaged
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AbsEngaged, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AbsEngaged, &num);
		}
	}

	public unsafe static int TcsEngaged
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TcsEngaged, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TcsEngaged, &num);
		}
	}

	public unsafe static int EscEngaged
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EscEngaged, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EscEngaged, &num);
		}
	}

	public unsafe static int AsrEngaged
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AsrEngaged, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AsrEngaged, &num);
		}
	}

	public unsafe static int AidedSteer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AidedSteer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AidedSteer, &num);
		}
	}

	public unsafe static int _VEHICLE_SIZE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__VEHICLE_SIZE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__VEHICLE_SIZE, &num);
		}
	}

	static VehicleData()
	{
		Il2CppClassPointerStore<VehicleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "VehicleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleData>.NativeClassPtr);
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_EngineRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineRpm");
		NativeFieldInfoPtr_EngineStalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineStalled");
		NativeFieldInfoPtr_EngineWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineWorking");
		NativeFieldInfoPtr_EngineLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineLimiter");
		NativeFieldInfoPtr_EngineLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineLoad");
		NativeFieldInfoPtr_EngineTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineTorque");
		NativeFieldInfoPtr_EnginePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EnginePower");
		NativeFieldInfoPtr_EngineFuelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EngineFuelRate");
		NativeFieldInfoPtr_ClutchTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "ClutchTorque");
		NativeFieldInfoPtr_ClutchLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "ClutchLock");
		NativeFieldInfoPtr_GearboxGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GearboxGear");
		NativeFieldInfoPtr_GearboxMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GearboxMode");
		NativeFieldInfoPtr_GearboxShifting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GearboxShifting");
		NativeFieldInfoPtr_RetarderTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "RetarderTorque");
		NativeFieldInfoPtr_AbsEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "AbsEngaged");
		NativeFieldInfoPtr_TcsEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "TcsEngaged");
		NativeFieldInfoPtr_EscEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "EscEngaged");
		NativeFieldInfoPtr_AsrEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "AsrEngaged");
		NativeFieldInfoPtr_AidedSteer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "AidedSteer");
		NativeFieldInfoPtr__VEHICLE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "_VEHICLE_SIZE");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
