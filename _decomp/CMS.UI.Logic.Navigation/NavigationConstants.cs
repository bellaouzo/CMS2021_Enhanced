using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.UI.Logic.Navigation;

public static class NavigationConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GridItemNotFoundPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_ListItemNotFoundPos;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavigationConstants>.NativeClassPtr));

	public unsafe static Vector2Int GridItemNotFoundPos
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector2Int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GridItemNotFoundPos, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GridItemNotFoundPos, &vector2Int);
		}
	}

	public unsafe static int ListItemNotFoundPos
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ListItemNotFoundPos, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ListItemNotFoundPos, &num);
		}
	}

	static NavigationConstants()
	{
		Il2CppClassPointerStore<NavigationConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Navigation", "NavigationConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationConstants>.NativeClassPtr);
		NativeFieldInfoPtr_GridItemNotFoundPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationConstants>.NativeClassPtr, "GridItemNotFoundPos");
		NativeFieldInfoPtr_ListItemNotFoundPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationConstants>.NativeClassPtr, "ListItemNotFoundPos");
	}

	public NavigationConstants(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
