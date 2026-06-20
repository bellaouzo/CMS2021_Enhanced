using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class TransformDeepChildExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FindDeepChild_Public_Static_Transform_Transform_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TransformDeepChildExtension>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86787, XrefRangeEnd = 86804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindDeepChild(this Transform aParent, string aName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aParent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(aName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindDeepChild_Public_Static_Transform_Transform_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	static TransformDeepChildExtension()
	{
		Il2CppClassPointerStore<TransformDeepChildExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TransformDeepChildExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformDeepChildExtension>.NativeClassPtr);
		NativeMethodInfoPtr_FindDeepChild_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformDeepChildExtension>.NativeClassPtr, 100668273);
	}

	public TransformDeepChildExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
