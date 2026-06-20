using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDemo : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_barChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_spacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_barThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_marginInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_barLabelToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_barLabelPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineChart;

	private static readonly System.IntPtr NativeFieldInfoPtr_thickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_thicknessInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointSizeInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineLabelToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoData;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_tooltip;

	private static readonly System.IntPtr NativeFieldInfoPtr_tooltipText;

	private static readonly System.IntPtr NativeFieldInfoPtr_labelBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_labelLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_axisXLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_axisYLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_row;

	private static readonly System.IntPtr NativeFieldInfoPtr_column;

	private static readonly System.IntPtr NativeFieldInfoPtr_overRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_overColumn;

	private static readonly System.IntPtr NativeFieldInfoPtr_barLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_barXLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_barYLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineXLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineYLabels;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectDelegate_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOverDelegate_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClick_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChanged_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLabels_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr));

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

	public unsafe Slider spacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spacing);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spacing), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider barThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barThickness);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barThickness), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField distanceInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField marginInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marginInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marginInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle barLabelToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barLabelToggle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barLabelToggle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider barLabelPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barLabelPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barLabelPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Slider thickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickness);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thickness), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Slider pointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField thicknessInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thicknessInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thicknessInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField pointSizeInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSizeInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSizeInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle lineLabelToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineLabelToggle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineLabelToggle), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe GameObject labelBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelBar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelBar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject labelLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelLine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelLine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject axisXLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisXLabel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisXLabel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject axisYLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisYLabel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisYLabel), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe int row
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_row);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_row)) = num;
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

	public unsafe int overRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overRow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overRow)) = num;
		}
	}

	public unsafe int overColumn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overColumn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overColumn)) = num;
		}
	}

	public unsafe List<Text> barLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Text> barXLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barXLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barXLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Text> barYLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barYLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barYLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Text> lineLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Text> lineXLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineXLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineXLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Text> lineYLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineYLabels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineYLabels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13, XrefRangeEnd = 42, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectDelegate(int row, int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectDelegate_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnOverDelegate(int row, int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOverDelegate_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42, XrefRangeEnd = 241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241, XrefRangeEnd = 267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267, XrefRangeEnd = 302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302, XrefRangeEnd = 314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick(string button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClick_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314, XrefRangeEnd = 347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 421, RefRangeEnd = 422, XrefRangeStart = 347, XrefRangeEnd = 421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLabels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLabels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422, XrefRangeEnd = 451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanvasDemo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CanvasDemo()
	{
		Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CanvasDemo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr);
		NativeFieldInfoPtr_barChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barChart");
		NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "spacing");
		NativeFieldInfoPtr_barThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barThickness");
		NativeFieldInfoPtr_distanceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "distanceInput");
		NativeFieldInfoPtr_marginInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "marginInput");
		NativeFieldInfoPtr_barLabelToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barLabelToggle");
		NativeFieldInfoPtr_barLabelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barLabelPos");
		NativeFieldInfoPtr_lineChart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "lineChart");
		NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "thickness");
		NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "pointSize");
		NativeFieldInfoPtr_thicknessInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "thicknessInput");
		NativeFieldInfoPtr_pointSizeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "pointSizeInput");
		NativeFieldInfoPtr_lineLabelToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "lineLabelToggle");
		NativeFieldInfoPtr_dataPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "dataPanel");
		NativeFieldInfoPtr_infoData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "infoData");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "data");
		NativeFieldInfoPtr_dataInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "dataInput");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "info");
		NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "tooltip");
		NativeFieldInfoPtr_tooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "tooltipText");
		NativeFieldInfoPtr_labelBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "labelBar");
		NativeFieldInfoPtr_labelLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "labelLine");
		NativeFieldInfoPtr_axisXLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "axisXLabel");
		NativeFieldInfoPtr_axisYLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "axisYLabel");
		NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "dataSet");
		NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "row");
		NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "column");
		NativeFieldInfoPtr_overRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "overRow");
		NativeFieldInfoPtr_overColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "overColumn");
		NativeFieldInfoPtr_barLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barLabels");
		NativeFieldInfoPtr_barXLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barXLabels");
		NativeFieldInfoPtr_barYLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "barYLabels");
		NativeFieldInfoPtr_lineLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "lineLabels");
		NativeFieldInfoPtr_lineXLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "lineXLabels");
		NativeFieldInfoPtr_lineYLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, "lineYLabels");
		NativeMethodInfoPtr_OnSelectDelegate_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_OnOverDelegate_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_OnClick_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_OnValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_UpdateLabels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDemo>.NativeClassPtr, 100663307);
	}

	public CanvasDemo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
