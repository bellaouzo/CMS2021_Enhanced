using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class ClockdownDemo : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pie_canvas_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie_canvas_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie_canvas_3;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie2d_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie2d_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie2d_3;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie3d_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie3d_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie3d_3;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_endTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTimer_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr));

	public unsafe PieChart pie_canvas_1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie_canvas_1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie_canvas_1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChart pie_canvas_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie_canvas_2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie_canvas_2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChart pie_canvas_3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie_canvas_3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie_canvas_3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie2d_1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d_1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d_1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie2d_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d_2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d_2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie2d_3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d_3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie2d_3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie3d_1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d_1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d_1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie3d_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d_2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d_2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie3d_3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d_3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie3d_3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChartData1D dataSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData1D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int startTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime)) = num;
		}
	}

	public unsafe int endTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 651, XrefRangeEnd = 666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666, XrefRangeEnd = 676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 678, RefRangeEnd = 680, XrefRangeStart = 676, XrefRangeEnd = 678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 683, RefRangeEnd = 684, XrefRangeStart = 680, XrefRangeEnd = 683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClockdownDemo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ClockdownDemo()
	{
		Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ClockdownDemo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr);
		NativeFieldInfoPtr_pie_canvas_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie_canvas_1");
		NativeFieldInfoPtr_pie_canvas_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie_canvas_2");
		NativeFieldInfoPtr_pie_canvas_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie_canvas_3");
		NativeFieldInfoPtr_pie2d_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie2d_1");
		NativeFieldInfoPtr_pie2d_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie2d_2");
		NativeFieldInfoPtr_pie2d_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie2d_3");
		NativeFieldInfoPtr_pie3d_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie3d_1");
		NativeFieldInfoPtr_pie3d_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie3d_2");
		NativeFieldInfoPtr_pie3d_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "pie3d_3");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "text");
		NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "dataSet");
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, "endTime");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_InitTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClockdownDemo>.NativeClassPtr, 100663319);
	}

	public ClockdownDemo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
