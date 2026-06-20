using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.ContainersSave;

[StructLayout(LayoutKind.Sequential)]
public sealed class SaveData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HasData;

	private static readonly System.IntPtr NativeFieldInfoPtr_Data;

	private static readonly System.IntPtr NativeFieldInfoPtr_Format;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SaveData>.NativeClassPtr));

	public unsafe bool HasData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasData)) = flag;
		}
	}

	public unsafe Il2CppStructArray<byte> Data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe byte Format
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Format);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Format)) = b;
		}
	}

	static SaveData()
	{
		Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ContainersSave", "SaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
		NativeFieldInfoPtr_HasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "HasData");
		NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "Data");
		NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "Format");
	}

	public SaveData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe SaveData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SaveData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<SaveData>.NativeClassPtr))
	{
	}
}
