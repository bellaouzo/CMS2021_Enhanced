using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LTGUI : Il2CppSystem.Object
{
	public enum Element_Type
	{
		Texture,
		Label,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Element_Type>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Element_Type()
		{
			Il2CppClassPointerStore<Element_Type>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "Element_Type");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_RECT_LEVELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_RECTS_PER_LEVEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUTTONS_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_levels;

	private static readonly System.IntPtr NativeFieldInfoPtr_levelDepths;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonLastFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGUIEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_global_counter;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTGUI>.NativeClassPtr));

	public unsafe static int RECT_LEVELS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RECT_LEVELS, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RECT_LEVELS, &num);
		}
	}

	public unsafe static int RECTS_PER_LEVEL
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RECTS_PER_LEVEL, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RECTS_PER_LEVEL, &num);
		}
	}

	public unsafe static int BUTTONS_MAX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUTTONS_MAX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUTTONS_MAX, &num);
		}
	}

	public unsafe static Il2CppReferenceArray<LTRect> levels
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_levels, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<LTRect>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_levels, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<int> levelDepths
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_levelDepths, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_levelDepths, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<Rect> buttons
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttons, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<Rect>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttons, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<int> buttonLevels
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonLevels, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonLevels, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<int> buttonLastFrame
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonLastFrame, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonLastFrame, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static LTRect r
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_r, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new LTRect(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_r, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Color color
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_color, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_color, &color);
		}
	}

	public unsafe static bool isGUIEnabled
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isGUIEnabled, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isGUIEnabled, &flag);
		}
	}

	public unsafe static int global_counter
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_global_counter, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_global_counter, &num);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 9845, RefRangeEnd = 9847, XrefRangeStart = 9830, XrefRangeEnd = 9845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 9872, RefRangeEnd = 9873, XrefRangeStart = 9847, XrefRangeEnd = 9872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void initRectCheck()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 9892, RefRangeEnd = 9894, XrefRangeStart = 9873, XrefRangeEnd = 9892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reset()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9894, XrefRangeEnd = 10042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update(int updateLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10042, XrefRangeEnd = 10046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkOnScreen(Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 10057, RefRangeEnd = 10059, XrefRangeStart = 10046, XrefRangeEnd = 10057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void destroy(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10059, XrefRangeEnd = 10070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void destroyAll(int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&depth);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10070, XrefRangeEnd = 10082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect label(Rect rect, string label, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10082, XrefRangeEnd = 10087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect label(LTRect rect, string label, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10087, XrefRangeEnd = 10099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect texture(Rect rect, Texture texture, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10099, XrefRangeEnd = 10104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 10137, RefRangeEnd = 10141, XrefRangeStart = 10104, XrefRangeEnd = 10137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect element(LTRect rect, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10141, XrefRangeEnd = 10174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool hasNoOverlap(Rect rect, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 10188, RefRangeEnd = 10189, XrefRangeStart = 10174, XrefRangeEnd = 10188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool pressedWithinRect(Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10189, XrefRangeEnd = 10191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vec2);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10191, XrefRangeEnd = 10195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 firstTouch()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LTGUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTGUI>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LTGUI()
	{
		Il2CppClassPointerStore<LTGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTGUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTGUI>.NativeClassPtr);
		NativeFieldInfoPtr_RECT_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "RECT_LEVELS");
		NativeFieldInfoPtr_RECTS_PER_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "RECTS_PER_LEVEL");
		NativeFieldInfoPtr_BUTTONS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "BUTTONS_MAX");
		NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "levels");
		NativeFieldInfoPtr_levelDepths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "levelDepths");
		NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "buttons");
		NativeFieldInfoPtr_buttonLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "buttonLevels");
		NativeFieldInfoPtr_buttonLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "buttonLastFrame");
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "r");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "color");
		NativeFieldInfoPtr_isGUIEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "isGUIEnabled");
		NativeFieldInfoPtr_global_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "global_counter");
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_update_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100664159);
	}

	public LTGUI(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
