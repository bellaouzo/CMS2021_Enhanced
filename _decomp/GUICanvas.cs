using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

public class GUICanvas : Il2CppSystem.Object
{
	public sealed class DrawLineDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Int32_Int32_Int32_Int32_Color32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_Int32_Int32_Int32_Color32_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe DrawLineDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107512, RefRangeEnd = 107513, XrefRangeStart = 107497, XrefRangeEnd = 107512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int x0, int y0, int x1, int y1, int n, Color32 col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&x0);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
			*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Int32_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107513, XrefRangeEnd = 107528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(int x0, int y0, int x1, int y1, int n, Color32 col, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = (nint)(&x0);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
			*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_Int32_Int32_Int32_Color32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static DrawLineDelegate()
		{
			Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "DrawLineDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr, 100669997);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_Int32_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr, 100669998);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Int32_Int32_Int32_Int32_Color32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr, 100669999);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawLineDelegate>.NativeClassPtr, 100670000);
		}

		public DrawLineDelegate(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator DrawLineDelegate(Action<int, int, int, int, int, Color32> P_0)
		{
			return DelegateSupport.ConvertDelegate<DrawLineDelegate>(P_0);
		}

		public static DrawLineDelegate operator +(DrawLineDelegate P_0, DrawLineDelegate P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<DrawLineDelegate>();
		}

		public static DrawLineDelegate operator -(DrawLineDelegate P_0, DrawLineDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<DrawLineDelegate>();
			}
			return (DrawLineDelegate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_texture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsWd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsHt;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_viewArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_scaleX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_scaleY;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_moveX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_moveY;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_step;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_alpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_alphaBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_changed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_clipArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsXMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsXMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsYMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pixelsYMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_functionResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastExponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_COLORS;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitCanvas_Private_Void_Int32_Int32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeCanvas_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeCanvas_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanvasWidth_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanvasHeight_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanvasXMin_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanvasXMax_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanvasYMin_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanvasYMax_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PixelsWidth_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PixelsHeight_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleX_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleY_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pixels2CanvasX_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pixels2CanvasY_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Canvas2PixelsX_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Canvas2PixelsY_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Position2Canvas_Public_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetClipArea_Public_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetClipArea_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFunctionResolution_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyTexture_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlphaBlend_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Line_Public_Void_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedLine_Public_Void_Single_Single_Single_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DashedLine_Public_Void_Single_Single_Single_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedLineTo_Public_Void_Single_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DashedLineTo_Public_Void_Single_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_Color32_DrawLineDelegate_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Line_Public_Void_Vector2_Vector2_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineTo_Public_Void_Vector2_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineH_Public_Void_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineV_Public_Void_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DashedLineH_Public_Void_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DashedLineV_Public_Void_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedLineH_Public_Void_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedLineV_Public_Void_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Circumference_Public_Void_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Circle_Public_Void_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ellipse_Public_Void_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillEllipse_Public_Void_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rect_Public_Void_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillRect_Public_Void_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpLine_Public_Void_Vector2_Vector2_Vector2_Vector2_Color32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Grid_Public_Void_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedGrid_Public_Void_Single_Single_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DotMatrix_Public_Void_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasCurve_Public_Void_Vector2_Vector2_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Void_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Void_Vector2_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cross_Public_Void_Single_Single_Color32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cross_Public_Void_Vector2_Color32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LineGraph_Public_Void_ArrayOf_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_Single_Color32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedFunction_Public_Void_Func_2_Single_Single_Single_Single_Color32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DashedFunction_Public_Void_Func_2_Single_Single_Single_Single_Color32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DottedFunction_Public_Void_Func_2_Single_Single_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DashedFunction_Public_Void_Func_2_Single_Single_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Color32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FunctionColorFill_Public_Void_Func_2_Single_Vector4_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContourFill_Public_Void_Func_3_Single_Single_Color32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Restore_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyChanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIDraw_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIDrawDirty_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIStretchDrawWidth_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasRaw_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bias_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexSetPixel_Private_Void_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexLine_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexLineDot_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexLineDash_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexSegmentV_Private_Void_Int32_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexSegmentH_Private_Void_Int32_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexEllipse_Private_Void_Int32_Int32_Int32_Int32_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TexFillEllipse_Private_Void_Int32_Int32_Int32_Int32_Color32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr));

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

	public unsafe float m_pixelsWd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsWd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsWd)) = num;
		}
	}

	public unsafe float m_pixelsHt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsHt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pixelsHt)) = num;
		}
	}

	public unsafe Rect m_viewArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_viewArea);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_viewArea)) = rect;
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

	public unsafe bool m_changed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_changed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_changed)) = flag;
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

	public unsafe int m_functionResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_functionResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_functionResolution)) = num;
		}
	}

	public unsafe float m_lastExponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastExponent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastExponent)) = num;
		}
	}

	public unsafe float m_lastBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastBias)) = num;
		}
	}

	public unsafe Il2CppStructArray<Color> COLORS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_COLORS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_COLORS), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107528, XrefRangeEnd = 107549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUICanvas(int pixelsWd, int pixelsHt, float canvasX0, float canvasY0, float canvasWd, float canvasHt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasX0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasY0;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasWd;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107549, XrefRangeEnd = 107553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUICanvas(int pixelsWd, int pixelsHt, float canvasWd, float canvasHt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr))
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107553, XrefRangeEnd = 107557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUICanvas(int pixelsWd, int pixelsHt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107577, RefRangeEnd = 107580, XrefRangeStart = 107557, XrefRangeEnd = 107577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitCanvas(int pixelsWd, int pixelsHt, float canvasX0, float canvasY0, float canvasWd, float canvasHt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&pixelsWd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsHt;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasX0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasY0;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasWd;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitCanvas_Private_Void_Int32_Int32_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107580, RefRangeEnd = 107582, XrefRangeStart = 107580, XrefRangeEnd = 107580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResizeCanvas(float canvasX0, float canvasY0, float canvasWd, float canvasHt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&canvasX0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasY0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasWd;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasHt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeCanvas_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107582, XrefRangeEnd = 107583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResizeCanvas(float canvasWidth, float canvasHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&canvasWidth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &canvasHeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResizeCanvas_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float CanvasWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanvasWidth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CanvasHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanvasHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CanvasXMin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanvasXMin_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CanvasXMax()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanvasXMax_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CanvasYMin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanvasYMin_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CanvasYMax()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanvasYMax_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float PixelsWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PixelsWidth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float PixelsHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PixelsHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float ScaleX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleX_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float ScaleY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107583, XrefRangeEnd = 107587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Canvas2PixelsX(float canvas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&canvas);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Canvas2PixelsX_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107587, XrefRangeEnd = 107591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Canvas2PixelsY(float canvas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&canvas);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Canvas2PixelsY_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector2 Position2Canvas(Vector2 pixels)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pixels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Position2Canvas_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetClipArea(Rect clipArea)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&clipArea);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetClipArea_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetClipArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetClipArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetFunctionResolution(int pixels)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pixels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFunctionResolution_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107591, XrefRangeEnd = 107595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyTexture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetAlpha(float alpha)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alpha);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetAlphaBlend(bool alphaBlend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alphaBlend);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAlphaBlend_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107595, XrefRangeEnd = 107596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Line(float x0, float y0, float x1, float y1, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Line_Public_Void_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107596, XrefRangeEnd = 107597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedLine(float x0, float y0, float x1, float y1, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedLine_Public_Void_Single_Single_Single_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107597, XrefRangeEnd = 107598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DashedLine(float x0, float y0, float x1, float y1, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DashedLine_Public_Void_Single_Single_Single_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
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

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 107604, RefRangeEnd = 107618, XrefRangeStart = 107598, XrefRangeEnd = 107604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineTo(float xn, float yn, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xn);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yn;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 107624, RefRangeEnd = 107633, XrefRangeStart = 107618, XrefRangeEnd = 107624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedLineTo(float xn, float yn, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xn);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedLineTo_Public_Void_Single_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 107639, RefRangeEnd = 107646, XrefRangeStart = 107633, XrefRangeEnd = 107639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DashedLineTo(float xn, float yn, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xn);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DashedLineTo_Public_Void_Single_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107647, RefRangeEnd = 107650, XrefRangeStart = 107646, XrefRangeEnd = 107647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineTo(float xn, float yn, Color32 col, DrawLineDelegate TexLineFn, int n)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&xn);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yn;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(TexLineFn);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_Color32_DrawLineDelegate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107650, XrefRangeEnd = 107651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Line(Vector2 P0, Vector2 P1, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&P0);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &P1;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Line_Public_Void_Vector2_Vector2_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void MoveTo(Vector2 P0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&P0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTo_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107651, XrefRangeEnd = 107652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineTo(Vector2 P1, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&P1);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineTo_Public_Void_Vector2_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107652, XrefRangeEnd = 107653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineH(float y, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&y);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineH_Public_Void_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107653, XrefRangeEnd = 107654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineV(float x, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineV_Public_Void_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107654, XrefRangeEnd = 107655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DashedLineH(float y, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&y);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DashedLineH_Public_Void_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107655, XrefRangeEnd = 107656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DashedLineV(float x, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DashedLineV_Public_Void_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107656, XrefRangeEnd = 107657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedLineH(float y, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&y);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedLineH_Public_Void_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107657, XrefRangeEnd = 107658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedLineV(float x, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedLineV_Public_Void_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107658, XrefRangeEnd = 107659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Circumference(float x, float y, float radius, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Circumference_Public_Void_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107659, XrefRangeEnd = 107660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Circle(float x, float y, float radius, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Circle_Public_Void_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107660, XrefRangeEnd = 107661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Ellipse(float x, float y, float rx, float ry, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ellipse_Public_Void_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107661, XrefRangeEnd = 107662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillEllipse(float x, float y, float rx, float ry, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillEllipse_Public_Void_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Clear(Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&col);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107662, XrefRangeEnd = 107666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rect(float x, float y, float width, float height, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rect_Public_Void_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107666, XrefRangeEnd = 107667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillRect(float x, float y, float width, float height, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillRect_Public_Void_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107667, XrefRangeEnd = 107668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpLine(Vector2 P0, Vector2 T0, Vector2 P1, Vector2 T1, Color32 col, [Optional] int steps, [Optional] float scaleY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&P0);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &T0;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &P1;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &T1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &steps;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpLine_Public_Void_Vector2_Vector2_Vector2_Vector2_Color32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107668, XrefRangeEnd = 107679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Grid(float stepX, float stepY, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&stepX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepY;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Grid_Public_Void_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107679, XrefRangeEnd = 107690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedGrid(float stepX, float stepY, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&stepX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedGrid_Public_Void_Single_Single_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107690, XrefRangeEnd = 107700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DotMatrix(float stepX, float stepY, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&stepX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepY;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DotMatrix_Public_Void_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107700, XrefRangeEnd = 107704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BiasCurve(Vector2 P0, Vector2 P1, float bias, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&P0);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &P1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bias;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasCurve_Public_Void_Vector2_Vector2_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107709, RefRangeEnd = 107711, XrefRangeStart = 107704, XrefRangeEnd = 107709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dot(float x, float y, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Void_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107711, XrefRangeEnd = 107712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dot(Vector2 P, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&P);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Void_Vector2_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107712, XrefRangeEnd = 107714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cross(float x, float y, Color32 col, int pixelsX, int pixelsY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsX;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cross_Public_Void_Single_Single_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107714, XrefRangeEnd = 107716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cross(Vector2 P, Color32 col, int pixelsX, int pixelsY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&P);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cross_Public_Void_Vector2_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107716, XrefRangeEnd = 107718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LineGraph(Il2CppStructArray<float> Values, int ValueSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(Values);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ValueSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LineGraph_Public_Void_ArrayOf_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107718, XrefRangeEnd = 107727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function(Il2CppSystem.Func<float, float> func, float x0, float x1, Color32 col, [Optional] float scaleY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_Single_Color32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107727, XrefRangeEnd = 107736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedFunction(Il2CppSystem.Func<float, float> func, float x0, float x1, Color32 col, [Optional] int n, [Optional] float scaleY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedFunction_Public_Void_Func_2_Single_Single_Single_Single_Color32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107736, XrefRangeEnd = 107745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DashedFunction(Il2CppSystem.Func<float, float> func, float x0, float x1, Color32 col, [Optional] int n, [Optional] float scaleY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DashedFunction_Public_Void_Func_2_Single_Single_Single_Single_Color32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107745, XrefRangeEnd = 107754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function(Il2CppSystem.Func<float, float> func, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107754, XrefRangeEnd = 107763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DottedFunction(Il2CppSystem.Func<float, float> func, Color32 col, [Optional] int n)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DottedFunction_Public_Void_Func_2_Single_Single_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107763, XrefRangeEnd = 107772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DashedFunction(Il2CppSystem.Func<float, float> func, Color32 col, [Optional] int n)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DashedFunction_Public_Void_Func_2_Single_Single_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107781, RefRangeEnd = 107784, XrefRangeStart = 107772, XrefRangeEnd = 107781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function2(Il2CppSystem.Func<float, float, float> func, float p, float x0, float x1, Color32 col, float stepSize, float scaleY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107784, XrefRangeEnd = 107785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function2(Il2CppSystem.Func<float, float, float> func, float p, float x0, float x1, Color32 col, float stepSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107785, XrefRangeEnd = 107786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function2(Il2CppSystem.Func<float, float, float> func, float p, float x0, float x1, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107786, XrefRangeEnd = 107787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function2(Il2CppSystem.Func<float, float, float> func, float p, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 107796, RefRangeEnd = 107800, XrefRangeStart = 107787, XrefRangeEnd = 107796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function3(Il2CppSystem.Func<float, float, float, float> func, float p, float q, float x0, float x1, Color32 col, float stepSize, float scaleY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &scaleY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107800, XrefRangeEnd = 107801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function3(Il2CppSystem.Func<float, float, float, float> func, float p, float q, float x0, float x1, Color32 col, float stepSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107801, XrefRangeEnd = 107802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function3(Il2CppSystem.Func<float, float, float, float> func, float p, float q, float x0, float x1, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107802, XrefRangeEnd = 107803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function3(Il2CppSystem.Func<float, float, float, float> func, float p, float q, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107803, XrefRangeEnd = 107804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Function3(Il2CppSystem.Func<float, float, float, float> func, float p, float q, Color32 col, float stepSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &q;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Color32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107804, XrefRangeEnd = 107813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FunctionColorFill(Il2CppSystem.Func<float, Vector4> func, float x0, float x1, float y0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FunctionColorFill_Public_Void_Func_2_Single_Vector4_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107813, XrefRangeEnd = 107817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContourFill(Il2CppSystem.Func<float, float, Color32> func, float x, float y, float width, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContourFill_Public_Void_Func_3_Single_Single_Color32_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107817, XrefRangeEnd = 107819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107819, XrefRangeEnd = 107820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Restore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Restore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107820, XrefRangeEnd = 107822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyChanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107822, XrefRangeEnd = 107832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIDraw(int posX, int posY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&posX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIDraw_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107832, XrefRangeEnd = 107840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIDrawDirty(int posX, int posY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&posX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIDrawDirty_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107840, XrefRangeEnd = 107850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIStretchDraw(int posX, int posY, int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&posX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107850, XrefRangeEnd = 107860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIStretchDrawWidth(int posX, int posY, int width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&posX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &posY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIStretchDrawWidth_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107860, XrefRangeEnd = 107862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D GetTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Public_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 107862, RefRangeEnd = 107866, XrefRangeStart = 107862, XrefRangeEnd = 107862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float BiasRaw(float x, float fBias)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fBias;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasRaw_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107866, XrefRangeEnd = 107869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Bias(float x, float fBias)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fBias;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bias_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 107869, RefRangeEnd = 107904, XrefRangeStart = 107869, XrefRangeEnd = 107869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexSetPixel(int x, int y, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color32**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexSetPixel_Private_Void_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107904, XrefRangeEnd = 107908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexLine(int x0, int y0, int x1, int y1, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexLine_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107908, XrefRangeEnd = 107912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexLineDot(int x0, int y0, int x1, int y1, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexLineDot_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107912, XrefRangeEnd = 107916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexLineDash(int x0, int y0, int x1, int y1, int n, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(Color32**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexLineDash_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 107916, RefRangeEnd = 107929, XrefRangeStart = 107916, XrefRangeEnd = 107916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexSegmentV(int x, int y0, int y1, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexSegmentV_Private_Void_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 107929, RefRangeEnd = 107942, XrefRangeStart = 107929, XrefRangeEnd = 107929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexSegmentH(int x0, int x1, int y, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(Color32**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexSegmentH_Private_Void_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107963, RefRangeEnd = 107965, XrefRangeStart = 107942, XrefRangeEnd = 107963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexEllipse(int cx, int cy, int rx, int ry, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&cx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexEllipse_Private_Void_Int32_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107986, RefRangeEnd = 107988, XrefRangeStart = 107965, XrefRangeEnd = 107986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TexFillEllipse(int cx, int cy, int rx, int ry, Color32 col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&cx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ry;
		*(Color32**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TexFillEllipse_Private_Void_Int32_Int32_Int32_Int32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GUICanvas()
	{
		Il2CppClassPointerStore<GUICanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GUICanvas");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr);
		NativeFieldInfoPtr_m_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_texture");
		NativeFieldInfoPtr_m_pixelsWd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixelsWd");
		NativeFieldInfoPtr_m_pixelsHt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixelsHt");
		NativeFieldInfoPtr_m_viewArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_viewArea");
		NativeFieldInfoPtr_m_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_scaleX");
		NativeFieldInfoPtr_m_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_scaleY");
		NativeFieldInfoPtr_m_moveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_moveX");
		NativeFieldInfoPtr_m_moveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_moveY");
		NativeFieldInfoPtr_m_step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_step");
		NativeFieldInfoPtr_m_pixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixels");
		NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_buffer");
		NativeFieldInfoPtr_m_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_alpha");
		NativeFieldInfoPtr_m_alphaBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_alphaBlend");
		NativeFieldInfoPtr_m_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_changed");
		NativeFieldInfoPtr_m_clipArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_clipArea");
		NativeFieldInfoPtr_m_pixelsXMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixelsXMin");
		NativeFieldInfoPtr_m_pixelsXMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixelsXMax");
		NativeFieldInfoPtr_m_pixelsYMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixelsYMin");
		NativeFieldInfoPtr_m_pixelsYMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_pixelsYMax");
		NativeFieldInfoPtr_m_functionResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_functionResolution");
		NativeFieldInfoPtr_m_lastExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_lastExponent");
		NativeFieldInfoPtr_m_lastBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "m_lastBias");
		NativeFieldInfoPtr_COLORS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, "COLORS");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669901);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669902);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669903);
		NativeMethodInfoPtr_InitCanvas_Private_Void_Int32_Int32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669904);
		NativeMethodInfoPtr_ResizeCanvas_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669905);
		NativeMethodInfoPtr_ResizeCanvas_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669906);
		NativeMethodInfoPtr_CanvasWidth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669907);
		NativeMethodInfoPtr_CanvasHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669908);
		NativeMethodInfoPtr_CanvasXMin_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669909);
		NativeMethodInfoPtr_CanvasXMax_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669910);
		NativeMethodInfoPtr_CanvasYMin_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669911);
		NativeMethodInfoPtr_CanvasYMax_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669912);
		NativeMethodInfoPtr_PixelsWidth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669913);
		NativeMethodInfoPtr_PixelsHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669914);
		NativeMethodInfoPtr_ScaleX_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669915);
		NativeMethodInfoPtr_ScaleY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669916);
		NativeMethodInfoPtr_Pixels2CanvasX_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669917);
		NativeMethodInfoPtr_Pixels2CanvasY_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669918);
		NativeMethodInfoPtr_Canvas2PixelsX_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669919);
		NativeMethodInfoPtr_Canvas2PixelsY_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669920);
		NativeMethodInfoPtr_Position2Canvas_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669921);
		NativeMethodInfoPtr_SetClipArea_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669922);
		NativeMethodInfoPtr_ResetClipArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669923);
		NativeMethodInfoPtr_SetFunctionResolution_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669924);
		NativeMethodInfoPtr_DestroyTexture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669925);
		NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669926);
		NativeMethodInfoPtr_SetAlphaBlend_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669927);
		NativeMethodInfoPtr_Line_Public_Void_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669928);
		NativeMethodInfoPtr_DottedLine_Public_Void_Single_Single_Single_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669929);
		NativeMethodInfoPtr_DashedLine_Public_Void_Single_Single_Single_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669930);
		NativeMethodInfoPtr_MoveTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669931);
		NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669932);
		NativeMethodInfoPtr_DottedLineTo_Public_Void_Single_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669933);
		NativeMethodInfoPtr_DashedLineTo_Public_Void_Single_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669934);
		NativeMethodInfoPtr_LineTo_Public_Void_Single_Single_Color32_DrawLineDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669935);
		NativeMethodInfoPtr_Line_Public_Void_Vector2_Vector2_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669936);
		NativeMethodInfoPtr_MoveTo_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669937);
		NativeMethodInfoPtr_LineTo_Public_Void_Vector2_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669938);
		NativeMethodInfoPtr_LineH_Public_Void_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669939);
		NativeMethodInfoPtr_LineV_Public_Void_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669940);
		NativeMethodInfoPtr_DashedLineH_Public_Void_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669941);
		NativeMethodInfoPtr_DashedLineV_Public_Void_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669942);
		NativeMethodInfoPtr_DottedLineH_Public_Void_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669943);
		NativeMethodInfoPtr_DottedLineV_Public_Void_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669944);
		NativeMethodInfoPtr_Circumference_Public_Void_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669945);
		NativeMethodInfoPtr_Circle_Public_Void_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669946);
		NativeMethodInfoPtr_Ellipse_Public_Void_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669947);
		NativeMethodInfoPtr_FillEllipse_Public_Void_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669948);
		NativeMethodInfoPtr_Clear_Public_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669949);
		NativeMethodInfoPtr_Rect_Public_Void_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669950);
		NativeMethodInfoPtr_FillRect_Public_Void_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669951);
		NativeMethodInfoPtr_SpLine_Public_Void_Vector2_Vector2_Vector2_Vector2_Color32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669952);
		NativeMethodInfoPtr_Grid_Public_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669953);
		NativeMethodInfoPtr_DottedGrid_Public_Void_Single_Single_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669954);
		NativeMethodInfoPtr_DotMatrix_Public_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669955);
		NativeMethodInfoPtr_BiasCurve_Public_Void_Vector2_Vector2_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669956);
		NativeMethodInfoPtr_Dot_Public_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669957);
		NativeMethodInfoPtr_Dot_Public_Void_Vector2_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669958);
		NativeMethodInfoPtr_Cross_Public_Void_Single_Single_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669959);
		NativeMethodInfoPtr_Cross_Public_Void_Vector2_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669960);
		NativeMethodInfoPtr_LineGraph_Public_Void_ArrayOf_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669961);
		NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Single_Single_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669962);
		NativeMethodInfoPtr_DottedFunction_Public_Void_Func_2_Single_Single_Single_Single_Color32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669963);
		NativeMethodInfoPtr_DashedFunction_Public_Void_Func_2_Single_Single_Single_Single_Color32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669964);
		NativeMethodInfoPtr_Function_Public_Void_Func_2_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669965);
		NativeMethodInfoPtr_DottedFunction_Public_Void_Func_2_Single_Single_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669966);
		NativeMethodInfoPtr_DashedFunction_Public_Void_Func_2_Single_Single_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669967);
		NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669968);
		NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669969);
		NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669970);
		NativeMethodInfoPtr_Function2_Public_Void_Func_3_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669971);
		NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669972);
		NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669973);
		NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669974);
		NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669975);
		NativeMethodInfoPtr_Function3_Public_Void_Func_4_Single_Single_Single_Single_Single_Single_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669976);
		NativeMethodInfoPtr_FunctionColorFill_Public_Void_Func_2_Single_Vector4_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669977);
		NativeMethodInfoPtr_ContourFill_Public_Void_Func_3_Single_Single_Color32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669978);
		NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669979);
		NativeMethodInfoPtr_Restore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669980);
		NativeMethodInfoPtr_ApplyChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669981);
		NativeMethodInfoPtr_GUIDraw_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669982);
		NativeMethodInfoPtr_GUIDrawDirty_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669983);
		NativeMethodInfoPtr_GUIStretchDraw_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669984);
		NativeMethodInfoPtr_GUIStretchDrawWidth_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669985);
		NativeMethodInfoPtr_GetTexture_Public_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669986);
		NativeMethodInfoPtr_BiasRaw_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669987);
		NativeMethodInfoPtr_Bias_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669988);
		NativeMethodInfoPtr_TexSetPixel_Private_Void_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669989);
		NativeMethodInfoPtr_TexLine_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669990);
		NativeMethodInfoPtr_TexLineDot_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669991);
		NativeMethodInfoPtr_TexLineDash_Private_Void_Int32_Int32_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669992);
		NativeMethodInfoPtr_TexSegmentV_Private_Void_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669993);
		NativeMethodInfoPtr_TexSegmentH_Private_Void_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669994);
		NativeMethodInfoPtr_TexEllipse_Private_Void_Int32_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669995);
		NativeMethodInfoPtr_TexFillEllipse_Private_Void_Int32_Int32_Int32_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUICanvas>.NativeClassPtr, 100669996);
	}

	public GUICanvas(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
