using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class Rotations : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RotationRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_RotationAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_transformsToRotate;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Rotations>.NativeClassPtr));

	public unsafe float RotationRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationRate)) = num;
		}
	}

	public unsafe Vector3 RotationAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationAxis);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotationAxis)) = vector;
		}
	}

	public unsafe Il2CppReferenceArray<Transform> transformsToRotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformsToRotate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformsToRotate), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static Rotations()
	{
		Il2CppClassPointerStore<Rotations>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Rotations");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotations>.NativeClassPtr);
		NativeFieldInfoPtr_RotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotations>.NativeClassPtr, "RotationRate");
		NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotations>.NativeClassPtr, "RotationAxis");
		NativeFieldInfoPtr_transformsToRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotations>.NativeClassPtr, "transformsToRotate");
	}

	public Rotations(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe Rotations()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Rotations>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Rotations>.NativeClassPtr))
	{
	}
}
