using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class LicensePlate : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_texture;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LicensePlate>.NativeClassPtr));

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Texture texture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
		}
	}

	static LicensePlate()
	{
		Il2CppClassPointerStore<LicensePlate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LicensePlate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensePlate>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlate>.NativeClassPtr, "name");
		NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlate>.NativeClassPtr, "texture");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlate>.NativeClassPtr, "color");
	}

	public LicensePlate(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe LicensePlate()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LicensePlate>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<LicensePlate>.NativeClassPtr))
	{
	}
}
