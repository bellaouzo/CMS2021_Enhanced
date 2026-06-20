using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class CustomColor : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorWithoutAlpha_Public_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomColor_CustomColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomColor_CustomColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CustomColor>.NativeClassPtr));

	public unsafe Il2CppStructArray<float> Color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 92770, RefRangeEnd = 92779, XrefRangeStart = 92767, XrefRangeEnd = 92770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomColor(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 92782, RefRangeEnd = 92788, XrefRangeStart = 92779, XrefRangeEnd = 92782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomColor(float r, float g, float b, float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&r);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &g;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 92791, RefRangeEnd = 92807, XrefRangeStart = 92788, XrefRangeEnd = 92791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 92810, RefRangeEnd = 92814, XrefRangeStart = 92807, XrefRangeEnd = 92810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColorWithoutAlpha()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorWithoutAlpha_Public_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92814, XrefRangeEnd = 92816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(CustomColor color0, CustomColor color1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color0));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color1));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomColor_CustomColor_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92816, XrefRangeEnd = 92818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(CustomColor color0, CustomColor color1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color0));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color1));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomColor_CustomColor_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92826, RefRangeEnd = 92829, XrefRangeStart = 92818, XrefRangeEnd = 92826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92832, RefRangeEnd = 92835, XrefRangeStart = 92829, XrefRangeEnd = 92832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CustomColor()
	{
		Il2CppClassPointerStore<CustomColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CustomColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomColor>.NativeClassPtr);
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, "Color");
		NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668599);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668600);
		NativeMethodInfoPtr_GetColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668601);
		NativeMethodInfoPtr_GetColorWithoutAlpha_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668602);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomColor_CustomColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668603);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomColor_CustomColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668604);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668605);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, 100668606);
	}

	public CustomColor(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe CustomColor()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<CustomColor>.NativeClassPtr))
	{
	}
}
