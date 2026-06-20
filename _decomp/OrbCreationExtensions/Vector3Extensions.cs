using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class Vector3Extensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_Static_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_Static_String_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Product_Public_Static_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sum_Public_Static_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InProduct_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VectorMax_Public_Static_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiffBetween_Public_Static_Boolean_Vector3_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDiffSmallEnough_Public_Static_Boolean_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllSmaller_Public_Static_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Barycentric_Public_Static_Vector2_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To180Angle_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To360Angle_Public_Static_Vector3_Vector3_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233859, XrefRangeEnd = 233906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeString(this Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_Static_String_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233906, XrefRangeEnd = 234015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeString(this Vector3 v, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_Static_String_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static Vector3 Product(this Vector3 v1, Vector3 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Product_Public_Static_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float Sum(this Vector3 v1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sum_Public_Static_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float InProduct(this Vector3 v1, Vector3 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InProduct_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 Abs(this Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 VectorMax(this Vector3 v1, Vector3 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VectorMax_Public_Static_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsEqual(this Vector3 v1, Vector3 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool DiffBetween(this Vector3 v1, Vector3 v2, float from, float to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiffBetween_Public_Static_Boolean_Vector3_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsDiffSmallEnough(this Vector3 v1, Vector3 v2, float maxDiff)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDiff;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDiffSmallEnough_Public_Static_Boolean_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsAllSmaller(this Vector3 v1, Vector3 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllSmaller_Public_Static_Boolean_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234015, RefRangeEnd = 234017, XrefRangeStart = 234015, XrefRangeEnd = 234015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Barycentric(this Vector3 p, Vector3 a, Vector3 b, Vector3 c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&p);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Barycentric_Public_Static_Vector2_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 To180Angle(this Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To180Angle_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 To360Angle(this Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To360Angle_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static Vector3Extensions()
	{
		Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "Vector3Extensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr);
		NativeMethodInfoPtr_MakeString_Public_Static_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680889);
		NativeMethodInfoPtr_MakeString_Public_Static_String_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680890);
		NativeMethodInfoPtr_Product_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680891);
		NativeMethodInfoPtr_Sum_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680892);
		NativeMethodInfoPtr_InProduct_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680893);
		NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680894);
		NativeMethodInfoPtr_VectorMax_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680895);
		NativeMethodInfoPtr_IsEqual_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680896);
		NativeMethodInfoPtr_DiffBetween_Public_Static_Boolean_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680897);
		NativeMethodInfoPtr_IsDiffSmallEnough_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680898);
		NativeMethodInfoPtr_IsAllSmaller_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680899);
		NativeMethodInfoPtr_Barycentric_Public_Static_Vector2_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680900);
		NativeMethodInfoPtr_To180Angle_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680901);
		NativeMethodInfoPtr_To360Angle_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Extensions>.NativeClassPtr, 100680902);
	}

	public Vector3Extensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
