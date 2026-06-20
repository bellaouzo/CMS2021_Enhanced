using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public static class TypeSystem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementType_Internal_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindIEnumerable_Private_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnumerableType_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCollectionType_Public_Static_Boolean_Type_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TypeSystem>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121707, RefRangeEnd = 121708, XrefRangeStart = 121703, XrefRangeEnd = 121707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetElementType(Il2CppSystem.Type seqType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(seqType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetElementType_Internal_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Type(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 121751, RefRangeEnd = 121754, XrefRangeStart = 121708, XrefRangeEnd = 121751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type FindIEnumerable(Il2CppSystem.Type seqType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(seqType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindIEnumerable_Private_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Type(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121759, RefRangeEnd = 121760, XrefRangeStart = 121754, XrefRangeEnd = 121759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEnumerableType(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnumerableType_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121765, RefRangeEnd = 121766, XrefRangeStart = 121760, XrefRangeEnd = 121765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCollectionType(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCollectionType_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static TypeSystem()
	{
		Il2CppClassPointerStore<TypeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "TypeSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeSystem>.NativeClassPtr);
		NativeMethodInfoPtr_GetElementType_Internal_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystem>.NativeClassPtr, 100671078);
		NativeMethodInfoPtr_FindIEnumerable_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystem>.NativeClassPtr, 100671079);
		NativeMethodInfoPtr_IsEnumerableType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystem>.NativeClassPtr, 100671080);
		NativeMethodInfoPtr_IsCollectionType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSystem>.NativeClassPtr, 100671081);
	}

	public TypeSystem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
