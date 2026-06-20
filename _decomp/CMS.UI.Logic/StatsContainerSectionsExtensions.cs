using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic;

public static class StatsContainerSectionsExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_StatsContainerSections_StatsContainerSections_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<StatsContainerSectionsExtensions>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool HasFlagFast(this StatsContainerSections value, StatsContainerSections flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(StatsContainerSections**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_StatsContainerSections_StatsContainerSections_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static StatsContainerSectionsExtensions()
	{
		Il2CppClassPointerStore<StatsContainerSectionsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "StatsContainerSectionsExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsContainerSectionsExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_StatsContainerSections_StatsContainerSections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsContainerSectionsExtensions>.NativeClassPtr, 100676495);
	}

	public StatsContainerSectionsExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
