using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ColorHSV : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_s;

	private static readonly System.IntPtr NativeFieldInfoPtr_v;

	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToColor_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr));

	public unsafe float h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h)) = num;
		}
	}

	public unsafe float s
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)) = num;
		}
	}

	public unsafe float v
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v)) = num;
		}
	}

	public unsafe float a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe ColorHSV(float h, float s, float v)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&h);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &s;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe ColorHSV(float h, float s, float v, float a)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&h);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &s;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 42744, RefRangeEnd = 42748, XrefRangeStart = 42737, XrefRangeEnd = 42744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColorHSV(Color color)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 42748, RefRangeEnd = 42755, XrefRangeStart = 42748, XrefRangeEnd = 42748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color ToColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42755, XrefRangeEnd = 42787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static ColorHSV()
	{
		Il2CppClassPointerStore<ColorHSV>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ColorHSV");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr);
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, "h");
		NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, "s");
		NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, "v");
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, "a");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100665838);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100665839);
		NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100665840);
		NativeMethodInfoPtr_ToColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100665841);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHSV>.NativeClassPtr, 100665842);
	}

	public ColorHSV(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
