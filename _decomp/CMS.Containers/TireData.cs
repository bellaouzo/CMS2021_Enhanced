using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class TireData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_Found;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TireData>.NativeClassPtr));

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

	public unsafe WheelType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(WheelType*)num;
		}
		set
		{
			*(WheelType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = wheelType;
		}
	}

	public unsafe bool Found
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Found);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Found)) = flag;
		}
	}

	static TireData()
	{
		Il2CppClassPointerStore<TireData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "TireData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TireData>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireData>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireData>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_Found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireData>.NativeClassPtr, "Found");
	}

	public TireData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe TireData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TireData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<TireData>.NativeClassPtr))
	{
	}
}
