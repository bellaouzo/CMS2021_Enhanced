using System;
using System.Runtime.InteropServices;
using INI;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class SteamWorkshopUploaderItem : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PreviewPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContentPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PackageVisibility;

	private static readonly System.IntPtr NativeFieldInfoPtr_IniFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_PackageID;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr));

	public unsafe string PreviewPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewPath), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string ContentPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContentPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContentPath), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string PackageVisibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageVisibility);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageVisibility), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe INIUnity IniFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IniFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new INIUnity(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IniFile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string Tag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tag);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tag), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string PackageID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static SteamWorkshopUploaderItem()
	{
		Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SteamWorkshopUploaderItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr);
		NativeFieldInfoPtr_PreviewPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, "PreviewPath");
		NativeFieldInfoPtr_ContentPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, "ContentPath");
		NativeFieldInfoPtr_PackageVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, "PackageVisibility");
		NativeFieldInfoPtr_IniFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, "IniFile");
		NativeFieldInfoPtr_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, "Tag");
		NativeFieldInfoPtr_PackageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, "PackageID");
	}

	public SteamWorkshopUploaderItem(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe SteamWorkshopUploaderItem()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<SteamWorkshopUploaderItem>.NativeClassPtr))
	{
	}
}
