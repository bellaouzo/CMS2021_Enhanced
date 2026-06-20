using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class RectExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Rect_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMousePosInRect_Public_Static_Vector2_Rect_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeMousePosInRect_Public_Static_Vector2_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativeRectInImage_Public_Static_Rect_Rect_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxExtents_Public_Static_Single_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxSize_Public_Static_Single_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinExtents_Public_Static_Single_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinSize_Public_Static_Single_Bounds_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233560, RefRangeEnd = 233561, XrefRangeStart = 233560, XrefRangeEnd = 233560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MouseInRect(this Rect rect, Vector2 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233561, XrefRangeEnd = 233565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MouseInRect(this Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool MouseInRect(this Rect rect, Rect parentRect, Vector2 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentRect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233565, XrefRangeEnd = 233569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MouseInRect(this Rect rect, Rect parentRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentRect;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool MouseInRect(this Rect rect, Rect parentRect1, Rect parentRect2, Vector2 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&rect);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentRect1;
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentRect2;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Rect_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233569, XrefRangeEnd = 233573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MouseInRect(this Rect rect, Rect parentRect1, Rect parentRect2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentRect1;
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentRect2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector2 RelativeMousePosInRect(this Rect rect, Vector2 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeMousePosInRect_Public_Static_Vector2_Rect_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233573, XrefRangeEnd = 233577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 RelativeMousePosInRect(this Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeMousePosInRect_Public_Static_Vector2_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Rect RelativeRectInImage(this Rect r, Texture2D img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&r);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(img);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativeRectInImage_Public_Static_Rect_Rect_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float MaxExtents(this Bounds b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxExtents_Public_Static_Single_Bounds_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float MaxSize(this Bounds b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxSize_Public_Static_Single_Bounds_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float MinExtents(this Bounds b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinExtents_Public_Static_Single_Bounds_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float MinSize(this Bounds b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinSize_Public_Static_Single_Bounds_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static RectExtensions()
	{
		Il2CppClassPointerStore<RectExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "RectExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680853);
		NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680854);
		NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680855);
		NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680856);
		NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680857);
		NativeMethodInfoPtr_MouseInRect_Public_Static_Boolean_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680858);
		NativeMethodInfoPtr_RelativeMousePosInRect_Public_Static_Vector2_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680859);
		NativeMethodInfoPtr_RelativeMousePosInRect_Public_Static_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680860);
		NativeMethodInfoPtr_RelativeRectInImage_Public_Static_Rect_Rect_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680861);
		NativeMethodInfoPtr_MaxExtents_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680862);
		NativeMethodInfoPtr_MaxSize_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680863);
		NativeMethodInfoPtr_MinExtents_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680864);
		NativeMethodInfoPtr_MinSize_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectExtensions>.NativeClassPtr, 100680865);
	}

	public RectExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
