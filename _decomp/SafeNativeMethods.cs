using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class SafeNativeMethods : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_StrCmpLogicalW_Public_Static_Int32_String_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SafeNativeMethods>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28152, XrefRangeEnd = 28154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int StrCmpLogicalW(string psz1, string psz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(psz1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(psz2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StrCmpLogicalW_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static SafeNativeMethods()
	{
		Il2CppClassPointerStore<SafeNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SafeNativeMethods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeNativeMethods>.NativeClassPtr);
		NativeMethodInfoPtr_StrCmpLogicalW_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeNativeMethods>.NativeClassPtr, 100665200);
	}

	public SafeNativeMethods(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
