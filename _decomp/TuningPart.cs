using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class TuningPart : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Power;

	private static readonly System.IntPtr NativeFieldInfoPtr_Grip;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mass;

	private static readonly System.IntPtr NativeFieldInfoPtr_Steer;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TuningPart>.NativeClassPtr));

	public unsafe string ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float Power
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Power);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Power)) = num;
		}
	}

	public unsafe float Grip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Grip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Grip)) = num;
		}
	}

	public unsafe float Brakes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brakes);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brakes)) = num;
		}
	}

	public unsafe float Mass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mass)) = num;
		}
	}

	public unsafe float Steer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Steer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Steer)) = num;
		}
	}

	static TuningPart()
	{
		Il2CppClassPointerStore<TuningPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TuningPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TuningPart>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, "Power");
		NativeFieldInfoPtr_Grip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, "Grip");
		NativeFieldInfoPtr_Brakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, "Brakes");
		NativeFieldInfoPtr_Mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, "Mass");
		NativeFieldInfoPtr_Steer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, "Steer");
	}

	public TuningPart(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe TuningPart()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TuningPart>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<TuningPart>.NativeClassPtr))
	{
	}
}
