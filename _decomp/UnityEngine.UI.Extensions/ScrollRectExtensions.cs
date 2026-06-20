using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public static class ScrollRectExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollToTop_Public_Static_Void_ScrollRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollToBottom_Public_Static_Void_ScrollRect_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120683, XrefRangeEnd = 120684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScrollToTop(this ScrollRect scrollRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollRect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollToTop_Public_Static_Void_ScrollRect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120684, XrefRangeEnd = 120685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScrollToBottom(this ScrollRect scrollRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollRect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollToBottom_Public_Static_Void_ScrollRect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScrollRectExtensions()
	{
		Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "ScrollRectExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_ScrollToTop_Public_Static_Void_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr, 100671002);
		NativeMethodInfoPtr_ScrollToBottom_Public_Static_Void_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr, 100671003);
	}

	public ScrollRectExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
