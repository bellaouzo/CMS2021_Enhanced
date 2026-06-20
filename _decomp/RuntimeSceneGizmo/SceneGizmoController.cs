using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RuntimeSceneGizmo;

public class SceneGizmoController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GIZMOS_LAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoCamParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoComponents;

	private static readonly System.IntPtr NativeFieldInfoPtr_labels;

	private static readonly System.IntPtr NativeFieldInfoPtr_labelsTR;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_referenceTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevForward;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoNormalMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoFadeMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoHighlightMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_gizmoMaterialFadeProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightedComponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadingComponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFadingToZero;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeT;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateTargetTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetTexture_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ReferenceTransform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ReferenceTransform_Public_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetTexture_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetTexture_Private_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_GizmoComponent_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerHover_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHiddenComponent_Private_Void_GizmoComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlphaOf_Private_Void_GizmoComponent_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialOf_Private_Void_GizmoComponent_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOppositeComponent_Private_GizmoComponent_GizmoComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr));

	public unsafe static int GIZMOS_LAYER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GIZMOS_LAYER, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GIZMOS_LAYER, &num);
		}
	}

	public unsafe Camera gizmoCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform gizmoCamParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoCamParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoCamParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Renderer> gizmoComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoComponents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Renderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoComponents), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<TextMesh> labels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<TextMesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> labelsTR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelsTR);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelsTR), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_referenceTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_referenceTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_referenceTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 prevForward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevForward);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevForward)) = vector;
		}
	}

	public unsafe Material gizmoNormalMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoNormalMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoNormalMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material gizmoFadeMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoFadeMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoFadeMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material gizmoHighlightMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoHighlightMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoHighlightMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int gizmoMaterialFadeProperty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoMaterialFadeProperty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoMaterialFadeProperty)) = num;
		}
	}

	public unsafe GizmoComponent highlightedComponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightedComponent);
			return *(GizmoComponent*)num;
		}
		set
		{
			*(GizmoComponent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightedComponent)) = gizmoComponent;
		}
	}

	public unsafe GizmoComponent fadingComponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadingComponent);
			return *(GizmoComponent*)num;
		}
		set
		{
			*(GizmoComponent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadingComponent)) = gizmoComponent;
		}
	}

	public unsafe bool isFadingToZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFadingToZero);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFadingToZero)) = flag;
		}
	}

	public unsafe float fadeT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeT);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeT)) = num;
		}
	}

	public unsafe bool updateTargetTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateTargetTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateTargetTexture)) = flag;
		}
	}

	public unsafe RenderTexture _TargetTexture_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetTexture_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RenderTexture(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetTexture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform ReferenceTransform
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReferenceTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234731, RefRangeEnd = 234734, XrefRangeStart = 234677, XrefRangeEnd = 234731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ReferenceTransform_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture TargetTexture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new RenderTexture(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetTexture_Private_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234734, XrefRangeEnd = 234796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234796, XrefRangeEnd = 234799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234799, XrefRangeEnd = 234816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234816, XrefRangeEnd = 234834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234865, RefRangeEnd = 234867, XrefRangeStart = 234834, XrefRangeEnd = 234865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GizmoComponent Raycast(Vector3 normalizedPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normalizedPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_GizmoComponent_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(GizmoComponent*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234869, RefRangeEnd = 234871, XrefRangeStart = 234867, XrefRangeEnd = 234869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPointerHover(Vector3 normalizedPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normalizedPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerHover_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234885, RefRangeEnd = 234886, XrefRangeStart = 234871, XrefRangeEnd = 234885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHiddenComponent(GizmoComponent component)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&component);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHiddenComponent_Private_Void_GizmoComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234889, RefRangeEnd = 234890, XrefRangeStart = 234886, XrefRangeEnd = 234889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAlphaOf(GizmoComponent component, float alpha)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&component);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlphaOf_Private_Void_GizmoComponent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234896, RefRangeEnd = 234898, XrefRangeStart = 234890, XrefRangeEnd = 234896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaterialOf(GizmoComponent component, Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(material);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterialOf_Private_Void_GizmoComponent_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe GizmoComponent GetOppositeComponent(GizmoComponent component)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&component);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOppositeComponent_Private_GizmoComponent_GizmoComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(GizmoComponent*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234898, XrefRangeEnd = 234901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneGizmoController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SceneGizmoController()
	{
		Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "RuntimeSceneGizmo", "SceneGizmoController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr);
		NativeFieldInfoPtr_GIZMOS_LAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "GIZMOS_LAYER");
		NativeFieldInfoPtr_gizmoCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoCamera");
		NativeFieldInfoPtr_gizmoCamParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoCamParent");
		NativeFieldInfoPtr_gizmoComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoComponents");
		NativeFieldInfoPtr_labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "labels");
		NativeFieldInfoPtr_labelsTR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "labelsTR");
		NativeFieldInfoPtr_m_referenceTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "m_referenceTransform");
		NativeFieldInfoPtr_prevForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "prevForward");
		NativeFieldInfoPtr_gizmoNormalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoNormalMaterial");
		NativeFieldInfoPtr_gizmoFadeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoFadeMaterial");
		NativeFieldInfoPtr_gizmoHighlightMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoHighlightMaterial");
		NativeFieldInfoPtr_gizmoMaterialFadeProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "gizmoMaterialFadeProperty");
		NativeFieldInfoPtr_highlightedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "highlightedComponent");
		NativeFieldInfoPtr_fadingComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "fadingComponent");
		NativeFieldInfoPtr_isFadingToZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "isFadingToZero");
		NativeFieldInfoPtr_fadeT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "fadeT");
		NativeFieldInfoPtr_updateTargetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "updateTargetTexture");
		NativeFieldInfoPtr__TargetTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, "<TargetTexture>k__BackingField");
		NativeMethodInfoPtr_get_ReferenceTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680946);
		NativeMethodInfoPtr_set_ReferenceTransform_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680947);
		NativeMethodInfoPtr_get_TargetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680948);
		NativeMethodInfoPtr_set_TargetTexture_Private_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680949);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680950);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680951);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680952);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680953);
		NativeMethodInfoPtr_Raycast_Public_GizmoComponent_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680954);
		NativeMethodInfoPtr_OnPointerHover_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680955);
		NativeMethodInfoPtr_SetHiddenComponent_Private_Void_GizmoComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680956);
		NativeMethodInfoPtr_SetAlphaOf_Private_Void_GizmoComponent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680957);
		NativeMethodInfoPtr_SetMaterialOf_Private_Void_GizmoComponent_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680958);
		NativeMethodInfoPtr_GetOppositeComponent_Private_GizmoComponent_GizmoComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680959);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoController>.NativeClassPtr, 100680960);
	}

	public SceneGizmoController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
