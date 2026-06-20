using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace VehiclePhysics;

public class DataLogger : Il2CppSystem.Object
{
	[System.Serializable]
	public class DisplaySettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_width;

		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		private static readonly System.IntPtr NativeFieldInfoPtr_backgroundColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_backgroundAlpha;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr));

		public unsafe int x
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
			}
		}

		public unsafe int y
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
			}
		}

		public unsafe int width
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = num;
			}
		}

		public unsafe int height
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
			}
		}

		public unsafe Color backgroundColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundColor);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundColor)) = color;
			}
		}

		public unsafe float backgroundAlpha
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundAlpha);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundAlpha)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe DisplaySettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static DisplaySettings()
		{
			Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "DisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "y");
			NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "width");
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "height");
			NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "backgroundColor");
			NativeFieldInfoPtr_backgroundAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "backgroundAlpha");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, 100671700);
		}

		public DisplaySettings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class GridSettings : Il2CppSystem.Object
	{
		public enum Type
		{
			Full,
			Vertical,
			Horizontal,
			// error: nested types are not permitted in C#.
			[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr));
			,
			// error: nested types are not permitted in C#.
			static Type()
			{
				Il2CppClassPointerStore<Type>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, "Type");
			}

		}

		private static readonly System.IntPtr NativeFieldInfoPtr_show;

		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_resolution;

		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoHidePixels;

		private static readonly System.IntPtr NativeMethodInfoPtr_CheckVisibility_Private_Boolean_TextureCanvas_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_TextureCanvas_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawDots_Public_Void_TextureCanvas_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GridSettings>.NativeClassPtr));

		public unsafe bool show
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_show);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_show)) = flag;
			}
		}

		public unsafe Type type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(Type*)num;
			}
			set
			{
				*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = type;
			}
		}

		public unsafe Vector2 resolution
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution)) = vector;
			}
		}

		public unsafe Color color
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
			}
		}

		public unsafe int autoHidePixels
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoHidePixels);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoHidePixels)) = num;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125777, XrefRangeEnd = 125779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckVisibility(TextureCanvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckVisibility_Private_Boolean_TextureCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125783, RefRangeEnd = 125785, XrefRangeStart = 125779, XrefRangeEnd = 125783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw(TextureCanvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Void_TextureCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125785, XrefRangeEnd = 125789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawDots(TextureCanvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDots_Public_Void_TextureCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125793, RefRangeEnd = 125796, XrefRangeStart = 125789, XrefRangeEnd = 125793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static GridSettings()
		{
			Il2CppClassPointerStore<GridSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "GridSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridSettings>.NativeClassPtr);
			NativeFieldInfoPtr_show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, "show");
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, "type");
			NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, "resolution");
			NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, "color");
			NativeFieldInfoPtr_autoHidePixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, "autoHidePixels");
			NativeMethodInfoPtr_CheckVisibility_Private_Boolean_TextureCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, 100671701);
			NativeMethodInfoPtr_Draw_Public_Void_TextureCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, 100671702);
			NativeMethodInfoPtr_DrawDots_Public_Void_TextureCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, 100671703);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSettings>.NativeClassPtr, 100671704);
		}

		public GridSettings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class Channel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_origin;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		private static readonly System.IntPtr NativeFieldInfoPtr_alphaBlend;

		private static readonly System.IntPtr NativeFieldInfoPtr_show;

		private static readonly System.IntPtr NativeFieldInfoPtr_showSegmentBegin;

		private static readonly System.IntPtr NativeFieldInfoPtr_showSegmentEnd;

		private static readonly System.IntPtr NativeFieldInfoPtr_captionPositionY;

		private static readonly System.IntPtr NativeFieldInfoPtr_valueFormat;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_channelId;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_recorder;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataRecorder_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Single_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Channel>.NativeClassPtr));

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe float origin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origin);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origin)) = num;
			}
		}

		public unsafe float scale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = num;
			}
		}

		public unsafe Color color
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
			}
		}

		public unsafe bool alphaBlend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaBlend);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaBlend)) = flag;
			}
		}

		public unsafe bool show
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_show);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_show)) = flag;
			}
		}

		public unsafe bool showSegmentBegin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSegmentBegin);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSegmentBegin)) = flag;
			}
		}

		public unsafe bool showSegmentEnd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSegmentEnd);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSegmentEnd)) = flag;
			}
		}

		public unsafe float captionPositionY
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captionPositionY);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captionPositionY)) = num;
			}
		}

		public unsafe string valueFormat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueFormat);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueFormat), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe int m_channelId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_channelId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_channelId)) = num;
			}
		}

		public unsafe DataRecorder m_recorder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_recorder);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new DataRecorder(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_recorder), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125796, XrefRangeEnd = 125801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Channel(DataRecorder recorder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Channel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recorder);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DataRecorder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 125803, RefRangeEnd = 125849, XrefRangeStart = 125801, XrefRangeEnd = 125803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125851, RefRangeEnd = 125855, XrefRangeStart = 125849, XrefRangeEnd = 125851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static Channel()
		{
			Il2CppClassPointerStore<Channel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "Channel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Channel>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "name");
			NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "origin");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "scale");
			NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "color");
			NativeFieldInfoPtr_alphaBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "alphaBlend");
			NativeFieldInfoPtr_show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "show");
			NativeFieldInfoPtr_showSegmentBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "showSegmentBegin");
			NativeFieldInfoPtr_showSegmentEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "showSegmentEnd");
			NativeFieldInfoPtr_captionPositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "captionPositionY");
			NativeFieldInfoPtr_valueFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "valueFormat");
			NativeFieldInfoPtr_m_channelId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "m_channelId");
			NativeFieldInfoPtr_m_recorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "m_recorder");
			NativeMethodInfoPtr__ctor_Public_Void_DataRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100671705);
			NativeMethodInfoPtr_Write_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100671706);
			NativeMethodInfoPtr_Read_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100671707);
		}

		public Channel(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public sealed class PlotAction : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Channel_Boolean_Single_Single_Boolean_Single_Single_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PlotAction>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe PlotAction(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlotAction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125883, RefRangeEnd = 125885, XrefRangeStart = 125855, XrefRangeEnd = 125883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Channel channel, bool hasValue1, float value1, float t1, bool hasValue2, float value2, float t2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue1;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value1;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t1;
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue2;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &value2;
			*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &t2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125885, XrefRangeEnd = 125900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Channel channel, bool hasValue1, float value1, float t1, bool hasValue2, float value2, float t2, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue1;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value1;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t1;
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue2;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &value2;
			*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &t2;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Channel_Boolean_Single_Single_Boolean_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
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

		static PlotAction()
		{
			Il2CppClassPointerStore<PlotAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "PlotAction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotAction>.NativeClassPtr, 100671708);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotAction>.NativeClassPtr, 100671709);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Channel_Boolean_Single_Single_Boolean_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotAction>.NativeClassPtr, 100671710);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlotAction>.NativeClassPtr, 100671711);
		}

		public PlotAction(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator PlotAction(Action<Channel, bool, float, float, bool, float, float> P_0)
		{
			return DelegateSupport.ConvertDelegate<PlotAction>(P_0);
		}

		public static PlotAction operator +(PlotAction P_0, PlotAction P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<PlotAction>();
		}

		public static PlotAction operator -(PlotAction P_0, PlotAction P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PlotAction>();
			}
			return (PlotAction)obj;
		}
	}

	[ObfuscatedName("VehiclePhysics.DataLogger/<>c__DisplayClass28_0")]
	public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_verticalPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_style;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GUIDrawLabels_b__0_Internal_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GUIDrawLabels_b__1_Internal_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GUIDrawLabels_b__2_Internal_Void_Single_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr));

		public unsafe DataLogger __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new DataLogger(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int verticalPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalPos);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalPos)) = num;
			}
		}

		public unsafe GUIStyle style
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass28_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125900, XrefRangeEnd = 125906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GUIDrawLabels_b__0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GUIDrawLabels_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125906, XrefRangeEnd = 125912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GUIDrawLabels_b__1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GUIDrawLabels_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125912, XrefRangeEnd = 125918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GUIDrawLabels_b__2(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GUIDrawLabels_b__2_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass28_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "<>c__DisplayClass28_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_verticalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, "verticalPos");
			NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, "style");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, 100671712);
			NativeMethodInfoPtr__GUIDrawLabels_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, 100671713);
			NativeMethodInfoPtr__GUIDrawLabels_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, 100671714);
			NativeMethodInfoPtr__GUIDrawLabels_b__2_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass28_0>.NativeClassPtr, 100671715);
		}

		public __c__DisplayClass28_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_minViewportWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxViewPortWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_minViewportHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_topLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_bottomLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightMarginOnRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalZoomCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalZoomCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoRefresh;

	private static readonly System.IntPtr NativeFieldInfoPtr_primaryGrid;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryGrid;

	private static readonly System.IntPtr NativeFieldInfoPtr_dotGrid;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelOriginColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelCaptionMargin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dataRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_canvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_displaySettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_channels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bufferTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_deltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dirty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_DisplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDisplay_Public_Void_DisplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseTexture_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIDrawGraphic_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUIDrawLabels_Public_Void_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUILabel_Public_Void_Int32_Int32_String_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GUILabelOnTexture_Public_Void_Int32_Int32_String_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampView_Private_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HorizontalZoom_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerticalZoom_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewChannel_Public_Channel_String_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FrameCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Restart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlotChannels_Private_Void_PlotAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BoundsCheck_Private_Boolean_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlotLines_Private_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlotDots_Private_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataLogger>.NativeClassPtr));

	public unsafe float minViewportWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minViewportWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minViewportWidth)) = num;
		}
	}

	public unsafe float maxViewPortWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxViewPortWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxViewPortWidth)) = num;
		}
	}

	public unsafe float minViewportHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minViewportHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minViewportHeight)) = num;
		}
	}

	public unsafe float topLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topLimit)) = num;
		}
	}

	public unsafe float bottomLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomLimit)) = num;
		}
	}

	public unsafe int rightMarginOnRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightMarginOnRecord);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightMarginOnRecord)) = num;
		}
	}

	public unsafe float horizontalZoomCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalZoomCenter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalZoomCenter)) = num;
		}
	}

	public unsafe float verticalZoomCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalZoomCenter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalZoomCenter)) = num;
		}
	}

	public unsafe bool autoRefresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoRefresh);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoRefresh)) = flag;
		}
	}

	public unsafe GridSettings primaryGrid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryGrid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GridSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryGrid), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GridSettings secondaryGrid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryGrid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GridSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryGrid), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GridSettings dotGrid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dotGrid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GridSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dotGrid), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Color channelOriginColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelOriginColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelOriginColor)) = color;
		}
	}

	public unsafe int channelCaptionMargin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelCaptionMargin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelCaptionMargin)) = num;
		}
	}

	public unsafe DataRecorder m_dataRecorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataRecorder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataRecorder(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataRecorder), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextureCanvas m_canvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_canvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextureCanvas(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_canvas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DisplaySettings m_displaySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_displaySettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DisplaySettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_displaySettings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Channel> m_channels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_channels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Channel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_channels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_bufferTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bufferTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bufferTime)) = num;
		}
	}

	public unsafe float m_deltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_deltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_deltaTime)) = num;
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
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 126083, RefRangeEnd = 126093, XrefRangeStart = 126083, XrefRangeEnd = 126083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125949, RefRangeEnd = 125950, XrefRangeStart = 125918, XrefRangeEnd = 125949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataLogger(float bufferTime, float deltaTime, DisplaySettings textureSettings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataLogger>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&bufferTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(textureSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125959, RefRangeEnd = 125960, XrefRangeStart = 125950, XrefRangeEnd = 125959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureDisplay(DisplaySettings textureSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDisplay_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125960, XrefRangeEnd = 125965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseTexture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125965, XrefRangeEnd = 125968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIDrawGraphic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIDrawGraphic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126067, RefRangeEnd = 126068, XrefRangeStart = 125968, XrefRangeEnd = 126067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUIDrawLabels(GUIStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUIDrawLabels_Public_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 126072, RefRangeEnd = 126076, XrefRangeStart = 126068, XrefRangeEnd = 126072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUILabel(int x, int y, string label, GUIStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUILabel_Public_Void_Int32_Int32_String_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 126080, RefRangeEnd = 126083, XrefRangeStart = 126076, XrefRangeEnd = 126080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GUILabelOnTexture(int x, int y, string label, GUIStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GUILabelOnTexture_Public_Void_Int32_Int32_String_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Rect ClampView(Rect rc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampView_Private_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126093, RefRangeEnd = 126094, XrefRangeStart = 126093, XrefRangeEnd = 126093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MovePosition(float offsetX, float offsetY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offsetX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovePosition_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126094, RefRangeEnd = 126096, XrefRangeStart = 126094, XrefRangeEnd = 126094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HorizontalZoom(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HorizontalZoom_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126096, RefRangeEnd = 126098, XrefRangeStart = 126096, XrefRangeEnd = 126096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VerticalZoom(float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerticalZoom_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void NextFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 126109, RefRangeEnd = 126155, XrefRangeStart = 126098, XrefRangeEnd = 126109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Channel NewChannel(string name, Color color, [Optional] float origin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewChannel_Public_Channel_String_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Channel(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe int FrameCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FrameCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 126155, RefRangeEnd = 126159, XrefRangeStart = 126155, XrefRangeEnd = 126155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126159, XrefRangeEnd = 126165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Restart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Restart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 126200, RefRangeEnd = 126204, XrefRangeStart = 126165, XrefRangeEnd = 126200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126222, RefRangeEnd = 126224, XrefRangeStart = 126204, XrefRangeEnd = 126222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlotChannels(PlotAction plotAction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(plotAction);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlotChannels_Private_Void_PlotAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool BoundsCheck(float bound0, float bound1, float value0, float value1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&bound0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bound1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BoundsCheck_Private_Boolean_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126224, XrefRangeEnd = 126225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlotLines(Channel channel, bool hasValue1, float value1, float t1, bool hasValue2, float value2, float t2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t1;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue2;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &value2;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &t2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlotLines_Private_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126225, XrefRangeEnd = 126227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlotDots(Channel channel, bool hasValue1, float value1, float t1, bool hasValue2, float value2, float t2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t1;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasValue2;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &value2;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &t2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlotDots_Private_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DataLogger()
	{
		Il2CppClassPointerStore<DataLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DataLogger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataLogger>.NativeClassPtr);
		NativeFieldInfoPtr_minViewportWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "minViewportWidth");
		NativeFieldInfoPtr_maxViewPortWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "maxViewPortWidth");
		NativeFieldInfoPtr_minViewportHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "minViewportHeight");
		NativeFieldInfoPtr_topLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "topLimit");
		NativeFieldInfoPtr_bottomLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "bottomLimit");
		NativeFieldInfoPtr_rightMarginOnRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "rightMarginOnRecord");
		NativeFieldInfoPtr_horizontalZoomCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "horizontalZoomCenter");
		NativeFieldInfoPtr_verticalZoomCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "verticalZoomCenter");
		NativeFieldInfoPtr_autoRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "autoRefresh");
		NativeFieldInfoPtr_primaryGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "primaryGrid");
		NativeFieldInfoPtr_secondaryGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "secondaryGrid");
		NativeFieldInfoPtr_dotGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "dotGrid");
		NativeFieldInfoPtr_channelOriginColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "channelOriginColor");
		NativeFieldInfoPtr_channelCaptionMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "channelCaptionMargin");
		NativeFieldInfoPtr_m_dataRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_dataRecorder");
		NativeFieldInfoPtr_m_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_canvas");
		NativeFieldInfoPtr_m_displaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_displaySettings");
		NativeFieldInfoPtr_m_channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_channels");
		NativeFieldInfoPtr_m_bufferTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_bufferTime");
		NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_deltaTime");
		NativeFieldInfoPtr_m_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, "m_dirty");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671677);
		NativeMethodInfoPtr_ConfigureDisplay_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671678);
		NativeMethodInfoPtr_ReleaseTexture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671679);
		NativeMethodInfoPtr_GUIDrawGraphic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671680);
		NativeMethodInfoPtr_GUIDrawLabels_Public_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671681);
		NativeMethodInfoPtr_GUILabel_Public_Void_Int32_Int32_String_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671682);
		NativeMethodInfoPtr_GUILabelOnTexture_Public_Void_Int32_Int32_String_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671683);
		NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671684);
		NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671685);
		NativeMethodInfoPtr_ClampView_Private_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671686);
		NativeMethodInfoPtr_MovePosition_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671687);
		NativeMethodInfoPtr_HorizontalZoom_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671688);
		NativeMethodInfoPtr_VerticalZoom_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671689);
		NativeMethodInfoPtr_NextFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671690);
		NativeMethodInfoPtr_NewChannel_Public_Channel_String_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671691);
		NativeMethodInfoPtr_FrameCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671692);
		NativeMethodInfoPtr_ResetData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671693);
		NativeMethodInfoPtr_Restart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671694);
		NativeMethodInfoPtr_Refresh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671695);
		NativeMethodInfoPtr_PlotChannels_Private_Void_PlotAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671696);
		NativeMethodInfoPtr_BoundsCheck_Private_Boolean_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671697);
		NativeMethodInfoPtr_PlotLines_Private_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671698);
		NativeMethodInfoPtr_PlotDots_Private_Void_Channel_Boolean_Single_Single_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLogger>.NativeClassPtr, 100671699);
	}

	public DataLogger(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
