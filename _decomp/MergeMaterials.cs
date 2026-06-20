using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MergeMaterials : MonoBehaviour
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdvancedMerge_Public_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdvancedMerge2_Public_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoIt_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Merge3_Public_Void_Transform_Transform_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoItWithChilds_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85031, XrefRangeEnd = 85068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Merge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Merge_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85068, XrefRangeEnd = 85253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdvancedMerge(Transform parent, Transform child)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(child);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvancedMerge_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85441, RefRangeEnd = 85442, XrefRangeStart = 85253, XrefRangeEnd = 85441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdvancedMerge2(Transform parent, Transform child)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(child);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvancedMerge2_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85442, XrefRangeEnd = 85483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoIt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoIt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85568, RefRangeEnd = 85569, XrefRangeStart = 85483, XrefRangeEnd = 85568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Merge3(Transform newRoot, Transform src, Material mat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newRoot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(mat);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Merge3_Public_Void_Transform_Transform_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85611, RefRangeEnd = 85612, XrefRangeStart = 85569, XrefRangeEnd = 85611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoItWithChilds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoItWithChilds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85612, XrefRangeEnd = 85613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MergeMaterials()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MergeMaterials()
	{
		Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MergeMaterials");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr);
		NativeMethodInfoPtr_Merge_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668153);
		NativeMethodInfoPtr_AdvancedMerge_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668154);
		NativeMethodInfoPtr_AdvancedMerge2_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668155);
		NativeMethodInfoPtr_DoIt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668156);
		NativeMethodInfoPtr_Merge3_Public_Void_Transform_Transform_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668157);
		NativeMethodInfoPtr_DoItWithChilds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668158);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668159);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeMaterials>.NativeClassPtr, 100668160);
	}

	public MergeMaterials(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
