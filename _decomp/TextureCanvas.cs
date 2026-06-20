using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class TextureCanvas : Il2CppSystem.Object
{
	public enum LineType
	{
		Solid,
		Dotted,
		Dashed,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LineType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static LineType()
		{
			Il2CppClassPointerStore<LineType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "LineType");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_texture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsWd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsHt;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_canvasRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_scaleX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_scaleY;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_clipArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsXMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsXMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsYMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsYMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_alpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_alphaBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_srcBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dstBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr__lineType_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__dotInterval_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__dashInterval_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_moveX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_moveY;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_step;

	private static readonly System.IntPtr NativeFieldInfoPtr__functionResolution_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeTexture_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyTexture_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipArea_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clipArea_Public_set_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pixels2CanvasX_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pixels2CanvasY_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelX_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelY_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelWidth_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPixelHeight_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alphaBlend_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_alphaBlend_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lineType_Public_get_LineType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dotInterval_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dotInterval_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dashInterval_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dashInterval_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Line_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HorizontalLine_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerticalLine_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Circumference_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Circle_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ellipse_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillEllipse_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Grid_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HorizontalGrid_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerticalGrid_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DotGrid_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pixel_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cross_Public_Void_Single_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rectangle_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillRect_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_functionResolution_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_functionResolution_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SolidFunction_Public_Void_Func_2_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SolidFunction_Public_Void_Func_2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HorizontalAction_Public_Void_Action_1_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerticalAction_Public_Void_Action_1_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Restore_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIDraw_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyChanges_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCanvas_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupPixelColor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAlphaBlendedPixel_Private_Color32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForPixel_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexPixel_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexLine_Private_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexSegmentV_Private_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexSegmentH_Private_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexEllipse_Private_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexFillEllipse_Private_Void_Int32_Int32_Int32_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr));

	public unsafe Texture2D m_texture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_texture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_texture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_pixelsWd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsWd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsWd)) = num;
		}
	}

	public unsafe int m_pixelsHt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsHt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsHt)) = num;
		}
	}

	public unsafe bool m_dirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dirty)) = flag;
		}
	}

	public unsafe Il2CppStructArray<Color32> m_pixels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color32>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Color32> m_buffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_buffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color32>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rect m_canvasRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_canvasRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_canvasRect)) = rect;
		}
	}

	public unsafe float m_scaleX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_scaleX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_scaleX)) = num;
		}
	}

	public unsafe float m_scaleY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_scaleY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_scaleY)) = num;
		}
	}

	public unsafe Rect m_clipArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_clipArea);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_clipArea)) = rect;
		}
	}

	public unsafe int m_pixelsXMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsXMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsXMin)) = num;
		}
	}

	public unsafe int m_pixelsXMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsXMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsXMax)) = num;
		}
	}

	public unsafe int m_pixelsYMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsYMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsYMin)) = num;
		}
	}

	public unsafe int m_pixelsYMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsYMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsYMax)) = num;
		}
	}

	public unsafe Color32 m_pixelColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelColor)) = color;
		}
	}

	public unsafe Color m_color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_color)) = color;
		}
	}

	public unsafe float m_alpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_alpha);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_alpha)) = num;
		}
	}

	public unsafe bool m_alphaBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_alphaBlend);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_alphaBlend)) = flag;
		}
	}

	public unsafe float m_srcBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_srcBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_srcBlend)) = num;
		}
	}

	public unsafe float m_dstBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dstBlend);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dstBlend)) = num;
		}
	}

	public unsafe LineType _lineType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lineType_k__BackingField);
			return *(LineType*)num;
		}
		set
		{
			*(LineType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lineType_k__BackingField)) = lineType;
		}
	}

	public unsafe int _dotInterval_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dotInterval_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dotInterval_k__BackingField)) = num;
		}
	}

	public unsafe int _dashInterval_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dashInterval_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dashInterval_k__BackingField)) = num;
		}
	}

	public unsafe float m_moveX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_moveX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_moveX)) = num;
		}
	}

	public unsafe float m_moveY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_moveY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_moveY)) = num;
		}
	}

	public unsafe int m_step
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_step);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_step)) = num;
		}
	}

	public unsafe int _functionResolution_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__functionResolution_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__functionResolution_k__BackingField)) = num;
		}
	}

	public unsafe Rect rect
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int width
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int height
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Rect clipArea
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipArea_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108805, XrefRangeEnd = 108815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipArea_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Color color
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108889, XrefRangeEnd = 108890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float alpha
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108890, XrefRangeEnd = 108891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool alphaBlend
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alphaBlend_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108891, XrefRangeEnd = 108892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alphaBlend_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe LineType lineType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lineType_Public_get_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(LineType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int dotInterval
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108892, RefRangeEnd = 108893, XrefRangeStart = 108892, XrefRangeEnd = 108892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dotInterval_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dotInterval_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int dashInterval
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108893, RefRangeEnd = 108894, XrefRangeStart = 108893, XrefRangeEnd = 108893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dashInterval_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dashInterval_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int functionResolution
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_functionResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_functionResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Texture2D texture
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109074, XrefRangeEnd = 109076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
		}
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 108786, RefRangeEnd = 108793, XrefRangeStart = 108784, XrefRangeEnd = 108786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureCanvas(int pixelsWd, int pixelsHt, Rect canvasRect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasRect;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108793, XrefRangeEnd = 108794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureCanvas(int pixelsWd, int pixelsHt, float canvasWd, float canvasHt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasWd;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108794, XrefRangeEnd = 108795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureCanvas(int pixelsWd, int pixelsHt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108795, XrefRangeEnd = 108796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureCanvas()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108796, XrefRangeEnd = 108801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResizeTexture(int pixelsWd, int pixelsHt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeTexture_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108801, XrefRangeEnd = 108805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyTexture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float Pixels2CanvasX(int pixels)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pixels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pixels2CanvasX_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float Pixels2CanvasY(int pixels)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pixels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pixels2CanvasY_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 108819, RefRangeEnd = 108844, XrefRangeStart = 108815, XrefRangeEnd = 108819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPixelX(float x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelX_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 108848, RefRangeEnd = 108865, XrefRangeStart = 108844, XrefRangeEnd = 108848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPixelY(float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelY_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 108869, RefRangeEnd = 108879, XrefRangeStart = 108865, XrefRangeEnd = 108869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPixelWidth(float width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&width);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelWidth_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 108883, RefRangeEnd = 108889, XrefRangeStart = 108879, XrefRangeEnd = 108883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPixelHeight(float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&height);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPixelHeight_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void MoveTo(float x0, float y0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 108899, RefRangeEnd = 108908, XrefRangeStart = 108894, XrefRangeEnd = 108899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineTo(float x1, float y1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108909, RefRangeEnd = 108910, XrefRangeStart = 108908, XrefRangeEnd = 108909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Line(float x0, float y0, float x1, float y1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Line_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 108912, RefRangeEnd = 108914, XrefRangeStart = 108910, XrefRangeEnd = 108912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HorizontalLine(float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HorizontalLine_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108914, XrefRangeEnd = 108916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VerticalLine(float x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerticalLine_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108916, XrefRangeEnd = 108920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Circumference(float x, float y, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Circumference_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108920, XrefRangeEnd = 108924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Circle(float x, float y, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Circle_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108924, XrefRangeEnd = 108929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Ellipse(float x, float y, float rx, float ry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ellipse_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108929, XrefRangeEnd = 108934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillEllipse(float x, float y, float rx, float ry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillEllipse_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108944, RefRangeEnd = 108947, XrefRangeStart = 108934, XrefRangeEnd = 108944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Grid(float stepX, float stepY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stepX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Grid_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108947, XrefRangeEnd = 108952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HorizontalGrid(float stepY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stepY);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HorizontalGrid_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108952, XrefRangeEnd = 108957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VerticalGrid(float stepX)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stepX);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerticalGrid_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108957, XrefRangeEnd = 108958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DotGrid(float stepX, float stepY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stepX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DotGrid_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108958, XrefRangeEnd = 108961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pixel(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pixel_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 108968, RefRangeEnd = 108974, XrefRangeStart = 108961, XrefRangeEnd = 108968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dot(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108974, XrefRangeEnd = 108978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cross(float x, float y, [Optional] int radiusX, [Optional] int radiusY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radiusX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radiusY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cross_Public_Void_Single_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108978, XrefRangeEnd = 108982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rectangle(float x, float y, float width, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rectangle_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108982, XrefRangeEnd = 108987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillRect(float x, float y, float width, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillRect_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108987, XrefRangeEnd = 108997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function(Il2CppSystem.Func<float, float> func, float x0, float x1, [Optional] float stepSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108997, XrefRangeEnd = 109007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function(Il2CppSystem.Func<float, float> func, [Optional] float stepSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109007, XrefRangeEnd = 109018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SolidFunction(Il2CppSystem.Func<float, float> func, float x0, float x1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SolidFunction_Public_Void_Func_2_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109018, XrefRangeEnd = 109029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SolidFunction(Il2CppSystem.Func<float, float> func)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SolidFunction_Public_Void_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109029, XrefRangeEnd = 109032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HorizontalAction(Il2CppSystem.Action<float> action, float interval, [Optional] float offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &interval;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HorizontalAction_Public_Void_Action_1_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109032, XrefRangeEnd = 109035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VerticalAction(Il2CppSystem.Action<float> action, float interval, [Optional] float offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &interval;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerticalAction_Public_Void_Action_1_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109037, RefRangeEnd = 109039, XrefRangeStart = 109035, XrefRangeEnd = 109037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109039, XrefRangeEnd = 109040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Restore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Restore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 109050, RefRangeEnd = 109054, XrefRangeStart = 109040, XrefRangeEnd = 109050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIDraw(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIDraw_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109054, XrefRangeEnd = 109064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIStretchDraw(int x, int y, int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109064, XrefRangeEnd = 109074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIStretchDraw(int x, int y, int width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109076, XrefRangeEnd = 109078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109088, RefRangeEnd = 109090, XrefRangeStart = 109078, XrefRangeEnd = 109088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCanvas(int pixelsWd, int pixelsHt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCanvas_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 109092, RefRangeEnd = 109129, XrefRangeStart = 109090, XrefRangeEnd = 109092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupPixelColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupPixelColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 109129, RefRangeEnd = 109132, XrefRangeStart = 109129, XrefRangeEnd = 109129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color32 GetAlphaBlendedPixel(Color32 dst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dst);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAlphaBlendedPixel_Private_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109132, RefRangeEnd = 109133, XrefRangeStart = 109132, XrefRangeEnd = 109132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckForPixel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForPixel_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 109135, RefRangeEnd = 109153, XrefRangeStart = 109133, XrefRangeEnd = 109135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexPixel(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexPixel_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109157, RefRangeEnd = 109158, XrefRangeStart = 109153, XrefRangeEnd = 109157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexLine(int x0, int y0, int x1, int y1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexLine_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 109160, RefRangeEnd = 109178, XrefRangeStart = 109158, XrefRangeEnd = 109160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexSegmentV(int x, int y0, int y1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexSegmentV_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 109180, RefRangeEnd = 109195, XrefRangeStart = 109178, XrefRangeEnd = 109180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexSegmentH(int x0, int x1, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexSegmentH_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109206, RefRangeEnd = 109208, XrefRangeStart = 109195, XrefRangeEnd = 109206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexEllipse(int cx, int cy, int rx, int ry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexEllipse_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109229, RefRangeEnd = 109231, XrefRangeStart = 109208, XrefRangeEnd = 109229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexFillEllipse(int cx, int cy, int rx, int ry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexFillEllipse_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TextureCanvas()
	{
		Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TextureCanvas");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr);
		NativeFieldInfoPtr_m_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_texture");
		NativeFieldInfoPtr_m_pixelsWd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelsWd");
		NativeFieldInfoPtr_m_pixelsHt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelsHt");
		NativeFieldInfoPtr_m_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_dirty");
		NativeFieldInfoPtr_m_pixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixels");
		NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_buffer");
		NativeFieldInfoPtr_m_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_canvasRect");
		NativeFieldInfoPtr_m_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_scaleX");
		NativeFieldInfoPtr_m_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_scaleY");
		NativeFieldInfoPtr_m_clipArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_clipArea");
		NativeFieldInfoPtr_m_pixelsXMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelsXMin");
		NativeFieldInfoPtr_m_pixelsXMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelsXMax");
		NativeFieldInfoPtr_m_pixelsYMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelsYMin");
		NativeFieldInfoPtr_m_pixelsYMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelsYMax");
		NativeFieldInfoPtr_m_pixelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_pixelColor");
		NativeFieldInfoPtr_m_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_color");
		NativeFieldInfoPtr_m_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_alpha");
		NativeFieldInfoPtr_m_alphaBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_alphaBlend");
		NativeFieldInfoPtr_m_srcBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_srcBlend");
		NativeFieldInfoPtr_m_dstBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_dstBlend");
		NativeFieldInfoPtr__lineType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "<lineType>k__BackingField");
		NativeFieldInfoPtr__dotInterval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "<dotInterval>k__BackingField");
		NativeFieldInfoPtr__dashInterval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "<dashInterval>k__BackingField");
		NativeFieldInfoPtr_m_moveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_moveX");
		NativeFieldInfoPtr_m_moveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_moveY");
		NativeFieldInfoPtr_m_step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "m_step");
		NativeFieldInfoPtr__functionResolution_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, "<functionResolution>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670090);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670091);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670092);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670093);
		NativeMethodInfoPtr_ResizeTexture_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670094);
		NativeMethodInfoPtr_DestroyTexture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670095);
		NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670096);
		NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670097);
		NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670098);
		NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670099);
		NativeMethodInfoPtr_get_clipArea_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670100);
		NativeMethodInfoPtr_set_clipArea_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670101);
		NativeMethodInfoPtr_Pixels2CanvasX_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670102);
		NativeMethodInfoPtr_Pixels2CanvasY_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670103);
		NativeMethodInfoPtr_GetPixelX_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670104);
		NativeMethodInfoPtr_GetPixelY_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670105);
		NativeMethodInfoPtr_GetPixelWidth_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670106);
		NativeMethodInfoPtr_GetPixelHeight_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670107);
		NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670108);
		NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670109);
		NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670110);
		NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670111);
		NativeMethodInfoPtr_get_alphaBlend_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670112);
		NativeMethodInfoPtr_set_alphaBlend_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670113);
		NativeMethodInfoPtr_get_lineType_Public_get_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670114);
		NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670115);
		NativeMethodInfoPtr_get_dotInterval_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670116);
		NativeMethodInfoPtr_set_dotInterval_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670117);
		NativeMethodInfoPtr_get_dashInterval_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670118);
		NativeMethodInfoPtr_set_dashInterval_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670119);
		NativeMethodInfoPtr_MoveTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670120);
		NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670121);
		NativeMethodInfoPtr_Line_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670122);
		NativeMethodInfoPtr_HorizontalLine_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670123);
		NativeMethodInfoPtr_VerticalLine_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670124);
		NativeMethodInfoPtr_Circumference_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670125);
		NativeMethodInfoPtr_Circle_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670126);
		NativeMethodInfoPtr_Ellipse_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670127);
		NativeMethodInfoPtr_FillEllipse_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670128);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670129);
		NativeMethodInfoPtr_Grid_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670130);
		NativeMethodInfoPtr_HorizontalGrid_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670131);
		NativeMethodInfoPtr_VerticalGrid_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670132);
		NativeMethodInfoPtr_DotGrid_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670133);
		NativeMethodInfoPtr_Pixel_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670134);
		NativeMethodInfoPtr_Dot_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670135);
		NativeMethodInfoPtr_Cross_Public_Void_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670136);
		NativeMethodInfoPtr_Rectangle_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670137);
		NativeMethodInfoPtr_FillRect_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670138);
		NativeMethodInfoPtr_get_functionResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670139);
		NativeMethodInfoPtr_set_functionResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670140);
		NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670141);
		NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670142);
		NativeMethodInfoPtr_SolidFunction_Public_Void_Func_2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670143);
		NativeMethodInfoPtr_SolidFunction_Public_Void_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670144);
		NativeMethodInfoPtr_HorizontalAction_Public_Void_Action_1_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670145);
		NativeMethodInfoPtr_VerticalAction_Public_Void_Action_1_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670146);
		NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670147);
		NativeMethodInfoPtr_Restore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670148);
		NativeMethodInfoPtr_GUIDraw_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670149);
		NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670150);
		NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670151);
		NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670152);
		NativeMethodInfoPtr_ApplyChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670153);
		NativeMethodInfoPtr_SetupCanvas_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670154);
		NativeMethodInfoPtr_SetupPixelColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670155);
		NativeMethodInfoPtr_GetAlphaBlendedPixel_Private_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670156);
		NativeMethodInfoPtr_CheckForPixel_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670157);
		NativeMethodInfoPtr_TexPixel_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670158);
		NativeMethodInfoPtr_TexLine_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670159);
		NativeMethodInfoPtr_TexSegmentV_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670160);
		NativeMethodInfoPtr_TexSegmentH_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670161);
		NativeMethodInfoPtr_TexEllipse_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670162);
		NativeMethodInfoPtr_TexFillEllipse_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCanvas>.NativeClassPtr, 100670163);
	}

	public TextureCanvas(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
