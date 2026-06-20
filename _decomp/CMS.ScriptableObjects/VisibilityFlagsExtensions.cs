using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.ScriptableObjects;

public static class VisibilityFlagsExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_VisibilityFlags_VisibilityFlags_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VisibilityFlagsExtensions>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool HasFlagFast(this VisibilityFlags value, VisibilityFlags flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(VisibilityFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_VisibilityFlags_VisibilityFlags_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static VisibilityFlagsExtensions()
	{
		Il2CppClassPointerStore<VisibilityFlagsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ScriptableObjects", "VisibilityFlagsExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityFlagsExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_VisibilityFlags_VisibilityFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityFlagsExtensions>.NativeClassPtr, 100680283);
	}

	public VisibilityFlagsExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
