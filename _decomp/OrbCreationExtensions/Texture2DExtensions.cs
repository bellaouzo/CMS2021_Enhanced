using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class Texture2DExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSection_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaledCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_Void_Texture2D_Texture2D_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Static_Void_Texture2D_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeFormatWritable_Public_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWritableFormat_Public_Static_TextureFormat_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageColor_Public_Static_Color_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageColor_Public_Static_Color_Texture2D_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReadable_Public_Static_Boolean_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasTransparency_Public_Static_Boolean_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaledPixels_Private_Static_ArrayOf_Color_ArrayOf_Color_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnityNormalMap_Public_Static_Texture2D_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUnityNormalMap_Public_Static_Texture2D_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Texture2D_Color_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233577, XrefRangeEnd = 233580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetCopy(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233580, XrefRangeEnd = 233583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetCopy(this Texture2D tex, int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe static Texture2D GetSection(this Texture2D tex, int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSection_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 233594, RefRangeEnd = 233598, XrefRangeStart = 233583, XrefRangeEnd = 233594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetCopy(this Texture2D tex, int x, int y, int w, int h, bool mipMaps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMaps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233598, XrefRangeEnd = 233600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D ScaledCopy(this Texture2D tex, int width, int height, bool mipMaps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipMaps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaledCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233600, XrefRangeEnd = 233617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyFrom(this Texture2D tex, Texture2D fromTex, int toX, int toY, int fromX, int fromY, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fromTex);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &toY;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromX;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromY;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFrom_Public_Static_Void_Texture2D_Texture2D_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233617, XrefRangeEnd = 233626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Scale(this Texture2D tex, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Scale_Public_Static_Void_Texture2D_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233638, RefRangeEnd = 233641, XrefRangeStart = 233626, XrefRangeEnd = 233638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MakeFormatWritable(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeFormatWritable_Public_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static TextureFormat GetWritableFormat(TextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWritableFormat_Public_Static_TextureFormat_TextureFormat_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(TextureFormat*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233641, XrefRangeEnd = 233645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetAverageColor(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAverageColor_Public_Static_Color_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233645, XrefRangeEnd = 233649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetAverageColor(this Texture2D tex, Color useThisColorForAlpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useThisColorForAlpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAverageColor_Public_Static_Color_Texture2D_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233649, XrefRangeEnd = 233651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReadable(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReadable_Public_Static_Boolean_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233651, XrefRangeEnd = 233653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasTransparency(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasTransparency_Public_Static_Boolean_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233678, RefRangeEnd = 233679, XrefRangeStart = 233653, XrefRangeEnd = 233678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Color> ScaledPixels(Il2CppStructArray<Color> originalPixels, int oldWidth, int oldHeight, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalPixels);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldHeight;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaledPixels_Private_Static_ArrayOf_Color_ArrayOf_Color_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233679, XrefRangeEnd = 233696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetUnityNormalMap(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnityNormalMap_Public_Static_Texture2D_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233696, XrefRangeEnd = 233713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D FromUnityNormalMap(this Texture2D tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUnityNormalMap_Public_Static_Texture2D_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233713, XrefRangeEnd = 233725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Fill(this Texture2D tex, Color aColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fill_Public_Static_Void_Texture2D_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Texture2DExtensions()
	{
		Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "Texture2DExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680866);
		NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680867);
		NativeMethodInfoPtr_GetSection_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680868);
		NativeMethodInfoPtr_GetCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680869);
		NativeMethodInfoPtr_ScaledCopy_Public_Static_Texture2D_Texture2D_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680870);
		NativeMethodInfoPtr_CopyFrom_Public_Static_Void_Texture2D_Texture2D_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680871);
		NativeMethodInfoPtr_Scale_Public_Static_Void_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680872);
		NativeMethodInfoPtr_MakeFormatWritable_Public_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680873);
		NativeMethodInfoPtr_GetWritableFormat_Public_Static_TextureFormat_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680874);
		NativeMethodInfoPtr_GetAverageColor_Public_Static_Color_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680875);
		NativeMethodInfoPtr_GetAverageColor_Public_Static_Color_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680876);
		NativeMethodInfoPtr_IsReadable_Public_Static_Boolean_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680877);
		NativeMethodInfoPtr_HasTransparency_Public_Static_Boolean_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680878);
		NativeMethodInfoPtr_ScaledPixels_Private_Static_ArrayOf_Color_ArrayOf_Color_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680879);
		NativeMethodInfoPtr_GetUnityNormalMap_Public_Static_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680880);
		NativeMethodInfoPtr_FromUnityNormalMap_Public_Static_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680881);
		NativeMethodInfoPtr_Fill_Public_Static_Void_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DExtensions>.NativeClassPtr, 100680882);
	}

	public Texture2DExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
