using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Controls;

public class ColorBox : Button
{
	private static readonly System.IntPtr NativeFieldInfoPtr_checkMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_opacity;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableCheckMark_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_Color_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_PaintshopLastColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintType_Public_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintData_Public_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_TintLastColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOpacity_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ColorBox>.NativeClassPtr));

	public unsafe GameObject checkMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkMark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkMark), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PaintType paintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintType)) = paintType;
		}
	}

	public unsafe PaintData paintData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintData);
			return *(PaintData*)num;
		}
		set
		{
			*(PaintData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintData)) = paintData;
		}
	}

	public unsafe int opacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacity)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe Color GetColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 209745, RefRangeEnd = 209758, XrefRangeStart = 209731, XrefRangeEnd = 209745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableCheckMark(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableCheckMark_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 209772, RefRangeEnd = 209778, XrefRangeStart = 209758, XrefRangeEnd = 209772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(Color color, [Optional] PaintType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(PaintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_Color_PaintType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209792, RefRangeEnd = 209793, XrefRangeStart = 209778, XrefRangeEnd = 209792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(PaintshopLastColor lastColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lastColor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_PaintshopLastColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PaintType GetPaintType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaintType_Public_PaintType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe PaintData GetPaintData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaintData_Public_PaintData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209807, RefRangeEnd = 209808, XrefRangeStart = 209793, XrefRangeEnd = 209807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(TintLastColor lastColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lastColor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_TintLastColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int GetOpacity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOpacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ColorBox()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorBox>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ColorBox()
	{
		Il2CppClassPointerStore<ColorBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Controls", "ColorBox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorBox>.NativeClassPtr);
		NativeFieldInfoPtr_checkMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, "checkMark");
		NativeFieldInfoPtr_paintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, "paintType");
		NativeFieldInfoPtr_paintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, "paintData");
		NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, "opacity");
		NativeMethodInfoPtr_GetColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678938);
		NativeMethodInfoPtr_EnableCheckMark_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678939);
		NativeMethodInfoPtr_Setup_Public_Void_Color_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678940);
		NativeMethodInfoPtr_Setup_Public_Void_PaintshopLastColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678941);
		NativeMethodInfoPtr_GetPaintType_Public_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678942);
		NativeMethodInfoPtr_GetPaintData_Public_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678943);
		NativeMethodInfoPtr_Setup_Public_Void_TintLastColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678944);
		NativeMethodInfoPtr_GetOpacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678945);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBox>.NativeClassPtr, 100678946);
	}

	public ColorBox(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
