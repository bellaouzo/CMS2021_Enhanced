using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LODSystem : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lodMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshFilter;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshFilter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLODLevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LODSystem>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Mesh> lodMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodMeshes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MeshFilter meshFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MeshFilter(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60696, XrefRangeEnd = 60701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMeshFilter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60733, RefRangeEnd = 60734, XrefRangeStart = 60701, XrefRangeEnd = 60733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLODLevel(int newLodLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLodLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLODLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LODSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LODSystem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LODSystem()
	{
		Il2CppClassPointerStore<LODSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LODSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODSystem>.NativeClassPtr);
		NativeFieldInfoPtr_lodMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSystem>.NativeClassPtr, "lodMeshes");
		NativeFieldInfoPtr_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSystem>.NativeClassPtr, "meshFilter");
		NativeMethodInfoPtr_GetMeshFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSystem>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr_SetLODLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSystem>.NativeClassPtr, 100666935);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSystem>.NativeClassPtr, 100666936);
	}

	public LODSystem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
