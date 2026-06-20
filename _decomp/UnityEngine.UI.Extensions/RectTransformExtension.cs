using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public static class RectTransformExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_switchToRectTransform_Public_Static_Vector2_RectTransform_RectTransform_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RectTransformExtension>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122228, XrefRangeEnd = 122268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 switchToRectTransform(this RectTransform from, RectTransform to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_switchToRectTransform_Public_Static_Vector2_RectTransform_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static RectTransformExtension()
	{
		Il2CppClassPointerStore<RectTransformExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "RectTransformExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformExtension>.NativeClassPtr);
		NativeMethodInfoPtr_switchToRectTransform_Public_Static_Vector2_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformExtension>.NativeClassPtr, 100671133);
	}

	public RectTransformExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
