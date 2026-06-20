using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDemoPie : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pieChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_innerRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_startAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_chartSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_innerRadiusInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_startAngleInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_chartSizeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoData;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_tooltip;

	private static readonly System.IntPtr NativeFieldInfoPtr_tooltipText;

	private static readonly System.IntPtr NativeFieldInfoPtr_labelToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_labelPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_label;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_column;

	private static readonly System.IntPtr NativeFieldInfoPtr_over;

	private static readonly System.IntPtr NativeFieldInfoPtr_labels;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectDelegate_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOverDelegate_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChanged_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLabels_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr));

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

	public unsafe Slider innerRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innerRadius);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innerRadius), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider startAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startAngle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startAngle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider chartSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chartSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chartSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField innerRadiusInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innerRadiusInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innerRadiusInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField startAngleInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startAngleInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startAngleInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField chartSizeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chartSizeInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chartSizeInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject dataPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text infoData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField dataInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform tooltip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text tooltipText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltipText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltipText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle labelToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelToggle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelToggle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider labelPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject label
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe int column
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_column);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_column)) = num;
		}
	}

	public unsafe int over
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_over);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_over)) = num;
		}
	}

	public unsafe List<Text> labels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451, XrefRangeEnd = 477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectDelegate(int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&column);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectDelegate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnOverDelegate(int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&column);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOverDelegate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477, XrefRangeEnd = 538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538, XrefRangeEnd = 552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 552, XrefRangeEnd = 585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 585, XrefRangeEnd = 621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValueChanged(string slider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(slider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValueChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 641, RefRangeEnd = 642, XrefRangeStart = 621, XrefRangeEnd = 641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLabels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642, XrefRangeEnd = 651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanvasDemoPie()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CanvasDemoPie()
	{
		Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CanvasDemoPie");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr);
		NativeFieldInfoPtr_pieChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "pieChart");
		NativeFieldInfoPtr_innerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "innerRadius");
		NativeFieldInfoPtr_startAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "startAngle");
		NativeFieldInfoPtr_chartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "chartSize");
		NativeFieldInfoPtr_innerRadiusInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "innerRadiusInput");
		NativeFieldInfoPtr_startAngleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "startAngleInput");
		NativeFieldInfoPtr_chartSizeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "chartSizeInput");
		NativeFieldInfoPtr_dataPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "dataPanel");
		NativeFieldInfoPtr_infoData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "infoData");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "data");
		NativeFieldInfoPtr_dataInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "dataInput");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "info");
		NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "tooltip");
		NativeFieldInfoPtr_tooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "tooltipText");
		NativeFieldInfoPtr_labelToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "labelToggle");
		NativeFieldInfoPtr_labelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "labelPos");
		NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "label");
		NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "dataSet");
		NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "column");
		NativeFieldInfoPtr_over = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "over");
		NativeFieldInfoPtr_labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, "labels");
		NativeMethodInfoPtr_OnSelectDelegate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_OnOverDelegate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_OnValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_UpdateLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemoPie>.NativeClassPtr, 100663315);
	}

	public CanvasDemoPie(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
