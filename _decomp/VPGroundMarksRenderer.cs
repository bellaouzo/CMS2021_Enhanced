using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPGroundMarksRenderer : MonoBehaviour
{
	public enum Mode
	{
		PressureAndSkid,
		PressureOnly,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressureBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMarks;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_groundOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_material;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_markCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_markArraySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_markPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_biasCtx;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_segmentsUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_segmentCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_segmentArraySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_mesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_normals;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_tangents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_colors;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_uvs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_triangles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_values;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMark_Public_Int32_Vector3_Vector3_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSegment_Private_Void_MarkPoint_MarkPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr));

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
		}
	}

	public unsafe float pressureBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressureBoost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pressureBoost)) = num;
		}
	}

	public unsafe int maxMarks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMarks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMarks)) = num;
		}
	}

	public unsafe float minDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance)) = num;
		}
	}

	public unsafe float groundOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundOffset)) = num;
		}
	}

	public unsafe float textureOffsetY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureOffsetY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureOffsetY)) = num;
		}
	}

	public unsafe float fadeOutRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOutRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOutRange)) = num;
		}
	}

	public unsafe Material material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_markCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_markCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_markCount)) = num;
		}
	}

	public unsafe int m_markArraySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_markArraySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_markArraySize)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<MarkPoint> m_markPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_markPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<MarkPoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_markPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CommonTools.BiasLerpContext m_biasCtx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_biasCtx);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CommonTools.BiasLerpContext(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_biasCtx), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_segmentsUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_segmentsUpdated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_segmentsUpdated)) = flag;
		}
	}

	public unsafe int m_segmentCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_segmentCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_segmentCount)) = num;
		}
	}

	public unsafe int m_segmentArraySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_segmentArraySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_segmentArraySize)) = num;
		}
	}

	public unsafe Mesh m_mesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_mesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector3> m_vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vertices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vertices), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector3> m_normals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_normals);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_normals), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_tangents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tangents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector4>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tangents), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Color> m_colors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector2> m_uvs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_uvs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_uvs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> m_triangles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_triangles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_triangles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector2> m_values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_values);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111006, XrefRangeEnd = 111189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111189, XrefRangeEnd = 111190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111190, XrefRangeEnd = 111199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int AddMark(Vector3 pos, Vector3 normal, float pressureRatio, float skidRatio, float width, int lastIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&pos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pressureRatio;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skidRatio;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMark_Public_Int32_Vector3_Vector3_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111199, XrefRangeEnd = 111207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void AddSegment(MarkPoint first, MarkPoint second)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(second);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSegment_Private_Void_MarkPoint_MarkPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111207, XrefRangeEnd = 111225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111225, XrefRangeEnd = 111231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPGroundMarksRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPGroundMarksRenderer()
	{
		Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPGroundMarksRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_pressureBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "pressureBoost");
		NativeFieldInfoPtr_maxMarks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "maxMarks");
		NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "minDistance");
		NativeFieldInfoPtr_groundOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "groundOffset");
		NativeFieldInfoPtr_textureOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "textureOffsetY");
		NativeFieldInfoPtr_fadeOutRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "fadeOutRange");
		NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "material");
		NativeFieldInfoPtr_m_markCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_markCount");
		NativeFieldInfoPtr_m_markArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_markArraySize");
		NativeFieldInfoPtr_m_markPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_markPoints");
		NativeFieldInfoPtr_m_biasCtx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_biasCtx");
		NativeFieldInfoPtr_m_segmentsUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_segmentsUpdated");
		NativeFieldInfoPtr_m_segmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_segmentCount");
		NativeFieldInfoPtr_m_segmentArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_segmentArraySize");
		NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_mesh");
		NativeFieldInfoPtr_m_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_vertices");
		NativeFieldInfoPtr_m_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_normals");
		NativeFieldInfoPtr_m_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_tangents");
		NativeFieldInfoPtr_m_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_colors");
		NativeFieldInfoPtr_m_uvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_uvs");
		NativeFieldInfoPtr_m_triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_triangles");
		NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, "m_values");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670308);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670309);
		NativeMethodInfoPtr_AddMark_Public_Int32_Vector3_Vector3_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670310);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670311);
		NativeMethodInfoPtr_AddSegment_Private_Void_MarkPoint_MarkPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670312);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670313);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMarksRenderer>.NativeClassPtr, 100670314);
	}

	public VPGroundMarksRenderer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
