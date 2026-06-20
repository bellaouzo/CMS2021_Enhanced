using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class DriveshaftParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_DriveshaftLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_DriveshaftType;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr));

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

	public unsafe float DriveshaftLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DriveshaftLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DriveshaftLength)) = num;
		}
	}

	public unsafe string DriveshaftType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DriveshaftType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DriveshaftType), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static DriveshaftParams()
	{
		Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DriveshaftParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr);
		NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr, "Position");
		NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr, "Rotation");
		NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr, "Scale");
		NativeFieldInfoPtr_DriveshaftLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr, "DriveshaftLength");
		NativeFieldInfoPtr_DriveshaftType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr, "DriveshaftType");
	}

	public DriveshaftParams(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DriveshaftParams()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DriveshaftParams>.NativeClassPtr))
	{
	}
}
