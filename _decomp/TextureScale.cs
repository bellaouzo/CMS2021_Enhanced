using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class TextureScale : Il2CppSystem.Object
{
	public class ThreadData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_start;

		private static readonly System.IntPtr NativeFieldInfoPtr_end;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ThreadData>.NativeClassPtr));

		public unsafe int start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start)) = num;
			}
		}

		public unsafe int end
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe ThreadData(int s, int e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&s);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &e;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static ThreadData()
		{
			Il2CppClassPointerStore<ThreadData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "ThreadData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadData>.NativeClassPtr);
			NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadData>.NativeClassPtr, "start");
			NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadData>.NativeClassPtr, "end");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadData>.NativeClassPtr, 100666667);
		}

		public ThreadData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_texColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_newColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_ratioX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ratioY;

	private static readonly System.IntPtr NativeFieldInfoPtr_w2;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_mutex;

	private static readonly System.IntPtr NativeMethodInfoPtr_Point_Public_Static_Void_Texture2D_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bilinear_Public_Static_Void_Texture2D_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadedScale_Private_Static_Void_Texture2D_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BilinearScale_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointScale_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorLerpUnclamped_Private_Static_Color_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TextureScale>.NativeClassPtr));

	public unsafe static Il2CppStructArray<Color> texColors
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_texColors, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_texColors, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<Color> newColors
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_newColors, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_newColors, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int w
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_w, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_w, &num);
		}
	}

	public unsafe static float ratioX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ratioX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ratioX, &num);
		}
	}

	public unsafe static float ratioY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ratioY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ratioY, &num);
		}
	}

	public unsafe static int w2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_w2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_w2, &num);
		}
	}

	public unsafe static int finishCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_finishCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_finishCount, &num);
		}
	}

	public unsafe static Mutex mutex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mutex, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Mutex(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mutex, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57671, XrefRangeEnd = 57672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Point(Texture2D tex, int newWidth, int newHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newHeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Point_Public_Static_Void_Texture2D_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57672, XrefRangeEnd = 57673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Bilinear(Texture2D tex, int newWidth, int newHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newHeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bilinear_Public_Static_Void_Texture2D_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 57752, RefRangeEnd = 57757, XrefRangeStart = 57673, XrefRangeEnd = 57752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newHeight;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBilinear;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadedScale_Private_Static_Void_Texture2D_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57768, RefRangeEnd = 57770, XrefRangeStart = 57757, XrefRangeEnd = 57768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BilinearScale(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BilinearScale_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57779, RefRangeEnd = 57781, XrefRangeStart = 57770, XrefRangeEnd = 57779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PointScale(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointScale_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static Color ColorLerpUnclamped(Color c1, Color c2, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&c1);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorLerpUnclamped_Private_Static_Color_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TextureScale()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureScale>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TextureScale()
	{
		Il2CppClassPointerStore<TextureScale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TextureScale");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureScale>.NativeClassPtr);
		NativeFieldInfoPtr_texColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "texColors");
		NativeFieldInfoPtr_newColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "newColors");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "w");
		NativeFieldInfoPtr_ratioX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "ratioX");
		NativeFieldInfoPtr_ratioY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "ratioY");
		NativeFieldInfoPtr_w2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "w2");
		NativeFieldInfoPtr_finishCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "finishCount");
		NativeFieldInfoPtr_mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, "mutex");
		NativeMethodInfoPtr_Point_Public_Static_Void_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666660);
		NativeMethodInfoPtr_Bilinear_Public_Static_Void_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666661);
		NativeMethodInfoPtr_ThreadedScale_Private_Static_Void_Texture2D_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666662);
		NativeMethodInfoPtr_BilinearScale_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666663);
		NativeMethodInfoPtr_PointScale_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666664);
		NativeMethodInfoPtr_ColorLerpUnclamped_Private_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666665);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureScale>.NativeClassPtr, 100666666);
	}

	public TextureScale(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
