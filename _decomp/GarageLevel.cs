using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class GarageLevel : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectsToActivate;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GarageLevel>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ObjectsToActivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static GarageLevel()
	{
		Il2CppClassPointerStore<GarageLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GarageLevel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageLevel>.NativeClassPtr);
		NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLevel>.NativeClassPtr, "ObjectsToActivate");
	}

	public GarageLevel(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe GarageLevel()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GarageLevel>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<GarageLevel>.NativeClassPtr))
	{
	}
}
