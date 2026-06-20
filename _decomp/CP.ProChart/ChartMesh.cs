using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CP.ProChart;

public class ChartMesh : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode_3d;

	private static readonly System.IntPtr NativeFieldInfoPtr__Dirty_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_Vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_VertexColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_Triangles;

	private static readonly System.IntPtr NativeFieldInfoPtr_colors;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Dirty_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Dirty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Protected_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDataChangeDelegate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr));

	public unsafe Vector3 size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
		}
	}

	public unsafe bool mode_3d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode_3d);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode_3d)) = flag;
		}
	}

	public unsafe bool _Dirty_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Dirty_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Dirty_k__BackingField)) = flag;
		}
	}

	public unsafe List<Vector3> Vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vertices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Vertices), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Color32> VertexColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VertexColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Color32>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VertexColors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<int> Triangles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Triangles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Triangles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppObjectBase colors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppObjectBase(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int colorCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorCount)) = num;
		}
	}

	public unsafe bool Dirty
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Dirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Dirty_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Create_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 238067, RefRangeEnd = 238077, XrefRangeStart = 238065, XrefRangeEnd = 238067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(int row, Color color1, Color color2 = default(Color))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&row);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color1;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnDataChangeDelegate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDataChangeDelegate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238077, XrefRangeEnd = 238124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238130, RefRangeEnd = 238133, XrefRangeStart = 238124, XrefRangeEnd = 238130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChartMesh()
	{
		Il2CppClassPointerStore<ChartMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CP.ProChart", "ChartMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr);
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "size");
		NativeFieldInfoPtr_mode_3d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "mode_3d");
		NativeFieldInfoPtr__Dirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "<Dirty>k__BackingField");
		NativeFieldInfoPtr_Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "Vertices");
		NativeFieldInfoPtr_VertexColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "VertexColors");
		NativeFieldInfoPtr_Triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "Triangles");
		NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "colors");
		NativeFieldInfoPtr_colorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, "colorCount");
		NativeMethodInfoPtr_set_Dirty_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681195);
		NativeMethodInfoPtr_get_Dirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681196);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681197);
		NativeMethodInfoPtr_Create_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681198);
		NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681199);
		NativeMethodInfoPtr_OnDataChangeDelegate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681200);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681201);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartMesh>.NativeClassPtr, 100681202);
	}

	public ChartMesh(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
