using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class LTRect : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__rect;

	private static readonly System.IntPtr NativeFieldInfoPtr_alpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_pivot;

	private static readonly System.IntPtr NativeFieldInfoPtr_margin;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotateEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotateFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphaEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_labelStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_useColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontScaleToFit;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSimpleScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeByHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_texture;

	private static readonly System.IntPtr NativeFieldInfoPtr__id;

	private static readonly System.IntPtr NativeFieldInfoPtr_counter;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorTouched;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetForRotation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setColor_Public_LTRect_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLabel_Public_LTRect_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTRect>.NativeClassPtr));

	public unsafe Rect _rect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rect)) = rect;
		}
	}

	public unsafe float alpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alpha);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alpha)) = num;
		}
	}

	public unsafe float rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = num;
		}
	}

	public unsafe Vector2 pivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pivot);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pivot)) = vector;
		}
	}

	public unsafe Vector2 margin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_margin);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_margin)) = vector;
		}
	}

	public unsafe Rect relativeRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeRect)) = rect;
		}
	}

	public unsafe bool rotateEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateEnabled)) = flag;
		}
	}

	public unsafe bool rotateFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateFinished)) = flag;
		}
	}

	public unsafe bool alphaEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaEnabled)) = flag;
		}
	}

	public unsafe string labelStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelStr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_labelStr), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe LTGUI.Element_Type type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(LTGUI.Element_Type*)num;
		}
		set
		{
			*(LTGUI.Element_Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = element_Type;
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

	public unsafe bool useColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useColor)) = flag;
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

	public unsafe bool fontScaleToFit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontScaleToFit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontScaleToFit)) = flag;
		}
	}

	public unsafe bool useSimpleScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSimpleScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSimpleScale)) = flag;
		}
	}

	public unsafe bool sizeByHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeByHeight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeByHeight)) = flag;
		}
	}

	public unsafe Texture texture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id)) = num;
		}
	}

	public unsafe int counter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counter)) = num;
		}
	}

	public unsafe static bool colorTouched
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorTouched, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorTouched, &flag);
		}
	}

	public unsafe bool hasInitiliazed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float x
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_x_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 9654, RefRangeEnd = 9655, XrefRangeStart = 9654, XrefRangeEnd = 9654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float y
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_y_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float width
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float height
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Rect rect
	{
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 9713, RefRangeEnd = 9754, XrefRangeStart = 9655, XrefRangeEnd = 9713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9627, XrefRangeEnd = 9629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9629, XrefRangeEnd = 9631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect(Rect rect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LTRect(float x, float y, float width, float height)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LTRect(float x, float y, float width, float height, float alpha)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9631, XrefRangeEnd = 9632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect(float x, float y, float width, float height, float alpha, float rotation)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTRect>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void setId(int id, int counter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &counter;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9632, XrefRangeEnd = 9634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9651, RefRangeEnd = 9654, XrefRangeStart = 9634, XrefRangeEnd = 9651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resetForRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetForRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LTRect setStyle(GUIStyle style)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fontScaleToFit);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTRect setColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setColor_Public_LTRect_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTRect setAlpha(float alpha)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alpha);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTRect setLabel(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLabel_Public_LTRect_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&useSimpleScale);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeRect;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9754, XrefRangeEnd = 9758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTRect setUseSimpleScale(bool useSimpleScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useSimpleScale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTRect setSizeByHeight(bool sizeByHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sizeByHeight);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9758, XrefRangeEnd = 9827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static LTRect()
	{
		Il2CppClassPointerStore<LTRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTRect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTRect>.NativeClassPtr);
		NativeFieldInfoPtr__rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "_rect");
		NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "alpha");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "pivot");
		NativeFieldInfoPtr_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "margin");
		NativeFieldInfoPtr_relativeRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "relativeRect");
		NativeFieldInfoPtr_rotateEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "rotateEnabled");
		NativeFieldInfoPtr_rotateFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "rotateFinished");
		NativeFieldInfoPtr_alphaEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "alphaEnabled");
		NativeFieldInfoPtr_labelStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "labelStr");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "type");
		NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "style");
		NativeFieldInfoPtr_useColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "useColor");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "color");
		NativeFieldInfoPtr_fontScaleToFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "fontScaleToFit");
		NativeFieldInfoPtr_useSimpleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "useSimpleScale");
		NativeFieldInfoPtr_sizeByHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "sizeByHeight");
		NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "texture");
		NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "_id");
		NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "counter");
		NativeFieldInfoPtr_colorTouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTRect>.NativeClassPtr, "colorTouched");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664114);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_get_hasInitiliazed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_setId_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_resetForRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664123);
		NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664124);
		NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664125);
		NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664126);
		NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664127);
		NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_setStyle_Public_LTRect_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_setFontScaleToFit_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_setColor_Public_LTRect_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_setAlpha_Public_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_setLabel_Public_LTRect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_setUseSimpleScale_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_setSizeByHeight_Public_LTRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTRect>.NativeClassPtr, 100664141);
	}

	public LTRect(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
