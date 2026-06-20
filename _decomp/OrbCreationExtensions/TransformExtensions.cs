using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class TransformExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetFirstComponentInParents_Public_Static_T_Transform_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetFirstComponentInParents_Public_Static_T_Transform_0, Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPartOf_Public_Static_Boolean_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstChildWithName_Public_Static_Transform_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstChildWhereNameContains_Public_Static_Transform_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstComponentInParents_Public_Static_T_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointToWorldSpace_Public_Static_Vector3_Transform_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointToLocalSpace_Public_Static_Vector3_Transform_Vector3_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233770, RefRangeEnd = 233771, XrefRangeStart = 233725, XrefRangeEnd = 233770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPartOf(this Transform trans, Transform aTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(aTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPartOf_Public_Static_Boolean_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233804, RefRangeEnd = 233806, XrefRangeStart = 233771, XrefRangeEnd = 233804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindFirstChildWithName(this Transform trans, string childName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(childName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstChildWithName_Public_Static_Transform_Transform_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233840, RefRangeEnd = 233841, XrefRangeStart = 233806, XrefRangeEnd = 233840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindFirstChildWhereNameContains(this Transform trans, string childName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(childName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstChildWhereNameContains_Public_Static_Transform_Transform_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233841, XrefRangeEnd = 233855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetFirstComponentInParents<T>(this Transform trans) where T : MonoBehaviour
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetFirstComponentInParents_Public_Static_T_Transform_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233855, XrefRangeEnd = 233857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 PointToWorldSpace(this Transform trans, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointToWorldSpace_Public_Static_Vector3_Transform_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233857, XrefRangeEnd = 233859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 PointToLocalSpace(this Transform trans, Vector3 p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointToLocalSpace_Public_Static_Vector3_Transform_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static TransformExtensions()
	{
		Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "TransformExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_IsPartOf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100680883);
		NativeMethodInfoPtr_FindFirstChildWithName_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100680884);
		NativeMethodInfoPtr_FindFirstChildWhereNameContains_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100680885);
		NativeMethodInfoPtr_GetFirstComponentInParents_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100680886);
		NativeMethodInfoPtr_PointToWorldSpace_Public_Static_Vector3_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100680887);
		NativeMethodInfoPtr_PointToLocalSpace_Public_Static_Vector3_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100680888);
	}

	public TransformExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
