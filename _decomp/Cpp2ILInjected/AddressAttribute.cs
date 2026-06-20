using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace Cpp2ILInjected;

public sealed class AddressAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RVA;

	private static readonly System.IntPtr NativeFieldInfoPtr_Offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AddressAttribute>.NativeClassPtr));

	public unsafe string RVA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RVA);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RVA), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static AddressAttribute()
	{
		Il2CppClassPointerStore<AddressAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Cpp2ILInjected", "AddressAttribute");
		NativeFieldInfoPtr_RVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressAttribute>.NativeClassPtr, "RVA");
		NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressAttribute>.NativeClassPtr, "Offset");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressAttribute>.NativeClassPtr, "Length");
	}

	public AddressAttribute(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
