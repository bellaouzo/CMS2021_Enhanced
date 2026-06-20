using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Extensions;

public static class IntExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsWithin_Public_Static_Boolean_Int32_Int32_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IntExtension>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool IsWithin(this int value, int minimum, int maximum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minimum;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maximum;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWithin_Public_Static_Boolean_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IntExtension()
	{
		Il2CppClassPointerStore<IntExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Extensions", "IntExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntExtension>.NativeClassPtr);
		NativeMethodInfoPtr_IsWithin_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntExtension>.NativeClassPtr, 100679678);
	}

	public IntExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
