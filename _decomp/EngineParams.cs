using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class EngineParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineSwap;

	private static readonly System.IntPtr NativeFieldInfoPtr_Swapoptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineParams>.NativeClassPtr));

	public unsafe Vector3 Position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position)) = vector;
		}
	}

	public unsafe Vector3 Rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation)) = vector;
		}
	}

	public unsafe float Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale)) = num;
		}
	}

	public unsafe string Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string EngineSwap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineSwap);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineSwap), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppStringArray Swapoptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Swapoptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Swapoptions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight)) = num;
		}
	}

	static EngineParams()
	{
		Il2CppClassPointerStore<EngineParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EngineParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EngineParams>.NativeClassPtr);
		NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "Position");
		NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "Rotation");
		NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "Scale");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_EngineSwap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "EngineSwap");
		NativeFieldInfoPtr_Swapoptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "Swapoptions");
		NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, "Weight");
	}

	public EngineParams(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe EngineParams()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EngineParams>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<EngineParams>.NativeClassPtr))
	{
	}
}
