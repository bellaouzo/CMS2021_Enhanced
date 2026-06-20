using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class DemoMesh : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bar2d;

	private static readonly System.IntPtr NativeFieldInfoPtr_bar3d;

	private static readonly System.IntPtr NativeFieldInfoPtr_curve2d;

	private static readonly System.IntPtr NativeFieldInfoPtr_curve3d;

	private static readonly System.IntPtr NativeFieldInfoPtr_line2d;

	private static readonly System.IntPtr NativeFieldInfoPtr_line3d;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie2d;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie3d;

	private static readonly System.IntPtr NativeFieldInfoPtr_thickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet2;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr));

	public unsafe BarChartMesh bar2d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar2d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BarChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar2d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BarChartMesh bar3d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar3d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BarChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar3d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChartMesh curve2d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve2d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve2d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChartMesh curve3d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve3d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve3d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChartMesh line2d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line2d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line2d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChartMesh line3d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line3d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line3d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie2d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie3d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe float delta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delta)) = num;
		}
	}

	public unsafe ChartData2D dataSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChartData1D dataSet2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData1D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872, XrefRangeEnd = 919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 919, XrefRangeEnd = 941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941, XrefRangeEnd = 944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DemoMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DemoMesh()
	{
		Il2CppClassPointerStore<DemoMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DemoMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr);
		NativeFieldInfoPtr_bar2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "bar2d");
		NativeFieldInfoPtr_bar3d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "bar3d");
		NativeFieldInfoPtr_curve2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "curve2d");
		NativeFieldInfoPtr_curve3d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "curve3d");
		NativeFieldInfoPtr_line2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "line2d");
		NativeFieldInfoPtr_line3d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "line3d");
		NativeFieldInfoPtr_pie2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "pie2d");
		NativeFieldInfoPtr_pie3d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "pie3d");
		NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "thickness");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "dataSet");
		NativeFieldInfoPtr_dataSet2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, "dataSet2");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoMesh>.NativeClassPtr, 100663329);
	}

	public DemoMesh(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
