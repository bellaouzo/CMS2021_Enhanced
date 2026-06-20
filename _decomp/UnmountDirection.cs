using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class UnmountDirection : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr));

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

	public unsafe Vector3 Direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction)) = vector;
		}
	}

	public unsafe float Length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length)) = num;
		}
	}

	static UnmountDirection()
	{
		Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UnmountDirection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr, "Direction");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr, "Length");
	}

	public UnmountDirection(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe UnmountDirection()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<UnmountDirection>.NativeClassPtr))
	{
	}
}
