using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LODSwitcher : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lodMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGameObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodScreenSizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_deactivateAtDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinnedMeshRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_centerOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelsPerMeter;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_fixedLODLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_cam;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDimensions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFixedLODLevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseFixedLODLevel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLODLevel_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxLODLevel_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMesh_Public_Mesh_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMesh_Public_Void_Mesh_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRelativeScreenSize_Public_Void_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NearestCameraPositionForLOD_Public_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenPortion_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeLODLevel_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshFilter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLODLevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr));

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

	public unsafe Il2CppReferenceArray<GameObject> lodGameObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGameObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGameObjects), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> lodScreenSizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodScreenSizes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodScreenSizes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float deactivateAtDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deactivateAtDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deactivateAtDistance)) = num;
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

	public unsafe SkinnedMeshRenderer skinnedMeshRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinnedMeshRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SkinnedMeshRenderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinnedMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 centerOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerOffset)) = vector;
		}
	}

	public unsafe float pixelsPerMeter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelsPerMeter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelsPerMeter)) = num;
		}
	}

	public unsafe float objectSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectSize)) = num;
		}
	}

	public unsafe int fixedLODLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fixedLODLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fixedLODLevel)) = num;
		}
	}

	public unsafe int lodLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodLevel)) = num;
		}
	}

	public unsafe int frameOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameOffset)) = num;
		}
	}

	public unsafe int frameInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameInterval);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameInterval)) = num;
		}
	}

	public unsafe Camera cam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16491, XrefRangeEnd = 16530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 16573, RefRangeEnd = 16579, XrefRangeStart = 16530, XrefRangeEnd = 16573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeDimensions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDimensions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetFixedLODLevel(int aLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFixedLODLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ReleaseFixedLODLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseFixedLODLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int GetLODLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLODLevel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int MaxLODLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxLODLevel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Mesh GetMesh(int aLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMesh_Public_Mesh_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 16598, RefRangeEnd = 16604, XrefRangeStart = 16579, XrefRangeEnd = 16598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMesh(Mesh aMesh, int aLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aMesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMesh_Public_Void_Mesh_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16604, XrefRangeEnd = 16612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRelativeScreenSize(float aValue, int aLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aValue);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRelativeScreenSize_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16612, XrefRangeEnd = 16618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16618, XrefRangeEnd = 16632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 NearestCameraPositionForLOD(int aLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NearestCameraPositionForLOD_Public_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16647, RefRangeEnd = 16649, XrefRangeStart = 16632, XrefRangeEnd = 16647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ScreenPortion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenPortion_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16653, RefRangeEnd = 16654, XrefRangeStart = 16649, XrefRangeEnd = 16653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeLODLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeLODLevel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16661, XrefRangeStart = 16654, XrefRangeEnd = 16659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMeshFilter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 16689, RefRangeEnd = 16697, XrefRangeStart = 16661, XrefRangeEnd = 16689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLODLevel(int newLodLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLodLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLODLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16697, XrefRangeEnd = 16700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LODSwitcher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LODSwitcher()
	{
		Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LODSwitcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr);
		NativeFieldInfoPtr_lodMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "lodMeshes");
		NativeFieldInfoPtr_lodGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "lodGameObjects");
		NativeFieldInfoPtr_lodScreenSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "lodScreenSizes");
		NativeFieldInfoPtr_deactivateAtDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "deactivateAtDistance");
		NativeFieldInfoPtr_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "meshFilter");
		NativeFieldInfoPtr_skinnedMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "skinnedMeshRenderer");
		NativeFieldInfoPtr_centerOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "centerOffset");
		NativeFieldInfoPtr_pixelsPerMeter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "pixelsPerMeter");
		NativeFieldInfoPtr_objectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "objectSize");
		NativeFieldInfoPtr_fixedLODLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "fixedLODLevel");
		NativeFieldInfoPtr_lodLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "lodLevel");
		NativeFieldInfoPtr_frameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "frameOffset");
		NativeFieldInfoPtr_frameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "frameInterval");
		NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, "cam");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664483);
		NativeMethodInfoPtr_ComputeDimensions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664484);
		NativeMethodInfoPtr_SetFixedLODLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664485);
		NativeMethodInfoPtr_ReleaseFixedLODLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664486);
		NativeMethodInfoPtr_GetLODLevel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664487);
		NativeMethodInfoPtr_MaxLODLevel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664488);
		NativeMethodInfoPtr_GetMesh_Public_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664489);
		NativeMethodInfoPtr_SetMesh_Public_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664490);
		NativeMethodInfoPtr_SetRelativeScreenSize_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664491);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664492);
		NativeMethodInfoPtr_NearestCameraPositionForLOD_Public_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664493);
		NativeMethodInfoPtr_ScreenPortion_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664494);
		NativeMethodInfoPtr_ComputeLODLevel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664495);
		NativeMethodInfoPtr_GetMeshFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664496);
		NativeMethodInfoPtr_SetLODLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664497);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODSwitcher>.NativeClassPtr, 100664498);
	}

	public LODSwitcher(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
