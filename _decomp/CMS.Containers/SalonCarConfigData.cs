using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class SalonCarConfigData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AmountOfConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultConfig;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr));

	public unsafe string CarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string CarName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int AmountOfConfigs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmountOfConfigs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmountOfConfigs)) = num;
		}
	}

	public unsafe int DefaultConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultConfig);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultConfig)) = num;
		}
	}

	static SalonCarConfigData()
	{
		Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "SalonCarConfigData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr);
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_CarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr, "CarName");
		NativeFieldInfoPtr_AmountOfConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr, "AmountOfConfigs");
		NativeFieldInfoPtr_DefaultConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr, "DefaultConfig");
	}

	public SalonCarConfigData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe SalonCarConfigData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<SalonCarConfigData>.NativeClassPtr))
	{
	}
}
