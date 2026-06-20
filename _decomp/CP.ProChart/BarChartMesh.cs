using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CP.ProChart;

public class BarChartMesh : ChartMesh
{
	private static readonly System.IntPtr NativeFieldInfoPtr_values;

	private static readonly System.IntPtr NativeFieldInfoPtr_spacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_thickness;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Spacing_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Thickness_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Void_byref_ChartData2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTriangle_Private_Void_Vector3_Vector3_Vector3_Color32_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr));

	public unsafe ChartData2D values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_values);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float spacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spacing)) = num;
		}
	}

	public unsafe float thickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickness)) = num;
		}
	}

	public unsafe float Spacing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Thickness
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Thickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237442, XrefRangeEnd = 237455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 237467, RefRangeEnd = 237471, XrefRangeStart = 237455, XrefRangeEnd = 237467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValues(ref ChartData2D values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(values);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValues_Public_Void_byref_ChartData2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		values = ((intPtr3 == (System.IntPtr)0) ? null : new ChartData2D(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237471, XrefRangeEnd = 237596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Create_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 237613, RefRangeEnd = 237637, XrefRangeStart = 237596, XrefRangeEnd = 237613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Color32 color1, Color32 color2, Color32 color3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&p1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color2;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &color3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTriangle_Private_Void_Vector3_Vector3_Vector3_Color32_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237637, XrefRangeEnd = 237638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarChartMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BarChartMesh()
	{
		Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CP.ProChart", "BarChartMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr);
		NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, "values");
		NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, "spacing");
		NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, "thickness");
		NativeMethodInfoPtr_get_Spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681156);
		NativeMethodInfoPtr_set_Spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681157);
		NativeMethodInfoPtr_get_Thickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681158);
		NativeMethodInfoPtr_set_Thickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681159);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681160);
		NativeMethodInfoPtr_SetValues_Public_Void_byref_ChartData2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681161);
		NativeMethodInfoPtr_Create_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681162);
		NativeMethodInfoPtr_AddTriangle_Private_Void_Vector3_Vector3_Vector3_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681163);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarChartMesh>.NativeClassPtr, 100681164);
	}

	public BarChartMesh(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
