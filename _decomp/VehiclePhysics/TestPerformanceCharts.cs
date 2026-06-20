using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class TestPerformanceCharts : MonoBehaviour
{
	public enum Charts
	{
		AbsDiagnostics,
		AxleSuspension,
		SuspensionAnalysis,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Charts>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Charts()
		{
			Il2CppClassPointerStore<Charts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, "Charts");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_chart;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_charts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_perfComponent;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr));

	public unsafe Charts chart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chart);
			return *(Charts*)num;
		}
		set
		{
			*(Charts*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chart)) = charts;
		}
	}

	public unsafe Il2CppReferenceArray<PerformanceChart> m_charts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_charts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<PerformanceChart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_charts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPPerformanceDisplay m_perfComponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_perfComponent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPPerformanceDisplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_perfComponent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126606, XrefRangeEnd = 126609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126609, XrefRangeEnd = 126610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126610, XrefRangeEnd = 126640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TestPerformanceCharts()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TestPerformanceCharts()
	{
		Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "TestPerformanceCharts");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr);
		NativeFieldInfoPtr_chart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, "chart");
		NativeFieldInfoPtr_m_charts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, "m_charts");
		NativeFieldInfoPtr_m_perfComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, "m_perfComponent");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, 100671791);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, 100671792);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestPerformanceCharts>.NativeClassPtr, 100671793);
	}

	public TestPerformanceCharts(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
