using System;
using System.Runtime.InteropServices;
using CMS.UI.Logic;
using CMS.UI.Logic.Themes;
using Il2CppSystem;
using UnhollowerBaseLib;

[StructLayout(LayoutKind.Sequential)]
public sealed class ShopConfig : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DLC;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShopType;

	private static readonly System.IntPtr NativeFieldInfoPtr_SortOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Theme;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr));

	public unsafe int DLC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC)) = num;
		}
	}

	public unsafe string LocalizationKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe ShopType ShopType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopType);
			return *(ShopType*)num;
		}
		set
		{
			*(ShopType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopType)) = shopType;
		}
	}

	public unsafe string SortOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SortOptions);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SortOptions), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string BackgroundName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackgroundName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackgroundName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Theme Theme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Theme);
			return *(Theme*)num;
		}
		set
		{
			*(Theme*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Theme)) = theme;
		}
	}

	static ShopConfig()
	{
		Il2CppClassPointerStore<ShopConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ShopConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr);
		NativeFieldInfoPtr_DLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, "DLC");
		NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, "LocalizationKey");
		NativeFieldInfoPtr_ShopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, "ShopType");
		NativeFieldInfoPtr_SortOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, "SortOptions");
		NativeFieldInfoPtr_BackgroundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, "BackgroundName");
		NativeFieldInfoPtr_Theme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, "Theme");
	}

	public ShopConfig(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe ShopConfig()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShopConfig>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<ShopConfig>.NativeClassPtr))
	{
	}
}
