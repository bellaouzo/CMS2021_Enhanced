using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic;

public static class NavigationFeaturesExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_NavigationFeatures_NavigationFeatures_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavigationFeaturesExtensions>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool HasFlagFast(this NavigationFeatures value, NavigationFeatures flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(NavigationFeatures**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_NavigationFeatures_NavigationFeatures_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static NavigationFeaturesExtensions()
	{
		Il2CppClassPointerStore<NavigationFeaturesExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "NavigationFeaturesExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationFeaturesExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_NavigationFeatures_NavigationFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationFeaturesExtensions>.NativeClassPtr, 100676497);
	}

	public NavigationFeaturesExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
