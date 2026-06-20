using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Demo : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_barChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_barChart2;

	private static readonly System.IntPtr NativeFieldInfoPtr_pieChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineChart2;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet2;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Demo>.NativeClassPtr));

	public unsafe BarChart barChart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barChart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BarChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barChart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BarChart barChart2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barChart2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BarChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barChart2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChart pieChart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieChart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieChart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChart lineChart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineChart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineChart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChart lineChart2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineChart2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineChart2), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684, XrefRangeEnd = 724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Demo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Demo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Demo()
	{
		Il2CppClassPointerStore<Demo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Demo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Demo>.NativeClassPtr);
		NativeFieldInfoPtr_barChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "barChart");
		NativeFieldInfoPtr_barChart2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "barChart2");
		NativeFieldInfoPtr_pieChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "pieChart");
		NativeFieldInfoPtr_lineChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "lineChart");
		NativeFieldInfoPtr_lineChart2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "lineChart2");
		NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "dataSet");
		NativeFieldInfoPtr_dataSet2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "dataSet2");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100663321);
	}

	public Demo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
