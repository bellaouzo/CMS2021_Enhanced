using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPPerformanceDisplay : VehicleBehaviour
{
	public enum Chart
	{
		Essentials,
		Accelerations,
		Engine,
		Wheelspin,
		SuspensionTravel,
		WheelLoad,
		Custom,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Chart>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Chart()
		{
			Il2CppClassPointerStore<Chart>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "Chart");
		}

	}

	public enum ViewportMode
	{
		Small,
		Large,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ViewportMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ViewportMode()
		{
			Il2CppClassPointerStore<ViewportMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "ViewportMode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_chart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataRecordingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_refreshInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_startRecording;

	private static readonly System.IntPtr NativeFieldInfoPtr_panRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoomRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_largeDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_referenceSpecs;

	private static readonly System.IntPtr NativeFieldInfoPtr_toggleRecordKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftPanAndZoomKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightPanAndZoomKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_upPanAndZoomKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_downPanAndZoomKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_toggleViewModeKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetViewKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextChartKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevChartKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_textColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_customChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dataTool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_recording;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastRefreshTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_textStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_telemetryCharts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentChart;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_customChart_Public_get_PerformanceChart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_customChart_Public_set_Void_PerformanceChart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCurrentChart_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartRecord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopRecord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleRecord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextChart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrevChart_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr));

	public unsafe Chart chart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chart);
			return *(Chart*)num;
		}
		set
		{
			*(Chart*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chart)) = chart;
		}
	}

	public unsafe float dataRecordingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataRecordingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataRecordingTime)) = num;
		}
	}

	public unsafe float refreshInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refreshInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refreshInterval)) = num;
		}
	}

	public unsafe bool startRecording
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRecording);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startRecording)) = flag;
		}
	}

	public unsafe float panRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_panRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_panRate)) = num;
		}
	}

	public unsafe float zoomRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomRate)) = num;
		}
	}

	public unsafe ViewportMode viewMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMode);
			return *(ViewportMode*)num;
		}
		set
		{
			*(ViewportMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMode)) = viewportMode;
		}
	}

	public unsafe DataLogger.DisplaySettings smallDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.DisplaySettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger.DisplaySettings largeDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger.DisplaySettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_largeDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ReferenceSpecs referenceSpecs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceSpecs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ReferenceSpecs(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceSpecs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe KeyCode toggleRecordKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleRecordKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleRecordKey)) = keyCode;
		}
	}

	public unsafe KeyCode leftPanAndZoomKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPanAndZoomKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPanAndZoomKey)) = keyCode;
		}
	}

	public unsafe KeyCode rightPanAndZoomKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPanAndZoomKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPanAndZoomKey)) = keyCode;
		}
	}

	public unsafe KeyCode upPanAndZoomKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upPanAndZoomKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upPanAndZoomKey)) = keyCode;
		}
	}

	public unsafe KeyCode downPanAndZoomKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downPanAndZoomKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downPanAndZoomKey)) = keyCode;
		}
	}

	public unsafe KeyCode toggleViewModeKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleViewModeKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleViewModeKey)) = keyCode;
		}
	}

	public unsafe KeyCode resetViewKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetViewKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetViewKey)) = keyCode;
		}
	}

	public unsafe KeyCode nextChartKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextChartKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextChartKey)) = keyCode;
		}
	}

	public unsafe KeyCode prevChartKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevChartKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevChartKey)) = keyCode;
		}
	}

	public unsafe Color textColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textColor)) = color;
		}
	}

	public unsafe Font font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Font(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PerformanceChart m_customChart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_customChart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PerformanceChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_customChart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataLogger m_dataTool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataTool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataLogger(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataTool), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_recording
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_recording);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_recording)) = flag;
		}
	}

	public unsafe float m_lastRefreshTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastRefreshTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastRefreshTime)) = num;
		}
	}

	public unsafe GUIStyle m_textStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<PerformanceChart> m_telemetryCharts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_telemetryCharts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<PerformanceChart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_telemetryCharts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Chart m_lastChart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastChart);
			return *(Chart*)num;
		}
		set
		{
			*(Chart*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastChart)) = chart;
		}
	}

	public unsafe PerformanceChart m_currentChart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentChart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PerformanceChart(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentChart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PerformanceChart customChart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_customChart_Public_get_PerformanceChart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new PerformanceChart(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113346, XrefRangeEnd = 113347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_customChart_Public_set_Void_PerformanceChart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113347, XrefRangeEnd = 113411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPPerformanceDisplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113411, XrefRangeEnd = 113422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113422, XrefRangeEnd = 113427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113427, XrefRangeEnd = 113428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 113435, RefRangeEnd = 113437, XrefRangeStart = 113428, XrefRangeEnd = 113435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 113444, RefRangeEnd = 113447, XrefRangeStart = 113437, XrefRangeEnd = 113444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeCurrentChart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCurrentChart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113447, XrefRangeEnd = 113481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe int GetUpdateOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113481, XrefRangeEnd = 113482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113482, XrefRangeEnd = 113537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113537, XrefRangeEnd = 113538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartRecord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartRecord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopRecord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopRecord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113538, XrefRangeEnd = 113539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleRecord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleRecord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void NextChart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextChart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void PrevChart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrevChart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPPerformanceDisplay()
	{
		Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPPerformanceDisplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr);
		NativeFieldInfoPtr_chart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "chart");
		NativeFieldInfoPtr_dataRecordingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "dataRecordingTime");
		NativeFieldInfoPtr_refreshInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "refreshInterval");
		NativeFieldInfoPtr_startRecording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "startRecording");
		NativeFieldInfoPtr_panRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "panRate");
		NativeFieldInfoPtr_zoomRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "zoomRate");
		NativeFieldInfoPtr_viewMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "viewMode");
		NativeFieldInfoPtr_smallDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "smallDisplay");
		NativeFieldInfoPtr_largeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "largeDisplay");
		NativeFieldInfoPtr_referenceSpecs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "referenceSpecs");
		NativeFieldInfoPtr_toggleRecordKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "toggleRecordKey");
		NativeFieldInfoPtr_leftPanAndZoomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "leftPanAndZoomKey");
		NativeFieldInfoPtr_rightPanAndZoomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "rightPanAndZoomKey");
		NativeFieldInfoPtr_upPanAndZoomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "upPanAndZoomKey");
		NativeFieldInfoPtr_downPanAndZoomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "downPanAndZoomKey");
		NativeFieldInfoPtr_toggleViewModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "toggleViewModeKey");
		NativeFieldInfoPtr_resetViewKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "resetViewKey");
		NativeFieldInfoPtr_nextChartKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "nextChartKey");
		NativeFieldInfoPtr_prevChartKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "prevChartKey");
		NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "textColor");
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "font");
		NativeFieldInfoPtr_m_customChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_customChart");
		NativeFieldInfoPtr_m_dataTool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_dataTool");
		NativeFieldInfoPtr_m_recording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_recording");
		NativeFieldInfoPtr_m_lastRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_lastRefreshTime");
		NativeFieldInfoPtr_m_textStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_textStyle");
		NativeFieldInfoPtr_m_telemetryCharts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_telemetryCharts");
		NativeFieldInfoPtr_m_lastChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_lastChart");
		NativeFieldInfoPtr_m_currentChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, "m_currentChart");
		NativeMethodInfoPtr_get_customChart_Public_get_PerformanceChart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670445);
		NativeMethodInfoPtr_set_customChart_Public_set_Void_PerformanceChart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670446);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670447);
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670448);
		NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670449);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670450);
		NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670451);
		NativeMethodInfoPtr_InitializeCurrentChart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670452);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670453);
		NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670454);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670455);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670456);
		NativeMethodInfoPtr_StartRecord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670457);
		NativeMethodInfoPtr_StopRecord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670458);
		NativeMethodInfoPtr_ToggleRecord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670459);
		NativeMethodInfoPtr_NextChart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670460);
		NativeMethodInfoPtr_PrevChart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPPerformanceDisplay>.NativeClassPtr, 100670461);
	}

	public VPPerformanceDisplay(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
