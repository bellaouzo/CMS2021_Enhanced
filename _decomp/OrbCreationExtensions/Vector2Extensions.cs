using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class Vector2Extensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_Static_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_Static_String_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Product_Public_Static_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InProduct_Public_Static_Single_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiffBetween_Public_Static_Boolean_Vector2_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDiffSmallEnough_Public_Static_Boolean_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllSmaller_Public_Static_Boolean_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBarycentricInTriangle_Public_Static_Boolean_Vector2_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234017, XrefRangeEnd = 234053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeString(this Vector2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_Static_String_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234053, XrefRangeEnd = 234136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeString(this Vector2 v, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_Static_String_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static Vector2 Product(this Vector2 v1, Vector2 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Product_Public_Static_Vector2_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float InProduct(this Vector2 v1, Vector2 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InProduct_Public_Static_Single_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector2 Abs(this Vector2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsEqual(this Vector2 v1, Vector2 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool DiffBetween(this Vector2 v1, Vector2 v2, float from, float to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&v1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiffBetween_Public_Static_Boolean_Vector2_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsDiffSmallEnough(this Vector2 v1, Vector2 v2, float maxDiff)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&v1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDiff;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDiffSmallEnough_Public_Static_Boolean_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsAllSmaller(this Vector2 v1, Vector2 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllSmaller_Public_Static_Boolean_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsBarycentricInTriangle(this Vector2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBarycentricInTriangle_Public_Static_Boolean_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static Vector2Extensions()
	{
		Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "Vector2Extensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr);
		NativeMethodInfoPtr_MakeString_Public_Static_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680903);
		NativeMethodInfoPtr_MakeString_Public_Static_String_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680904);
		NativeMethodInfoPtr_Product_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680905);
		NativeMethodInfoPtr_InProduct_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680906);
		NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680907);
		NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680908);
		NativeMethodInfoPtr_DiffBetween_Public_Static_Boolean_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680909);
		NativeMethodInfoPtr_IsDiffSmallEnough_Public_Static_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680910);
		NativeMethodInfoPtr_IsAllSmaller_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680911);
		NativeMethodInfoPtr_IsBarycentricInTriangle_Public_Static_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Extensions>.NativeClassPtr, 100680912);
	}

	public Vector2Extensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
