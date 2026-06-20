using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers;

public static class SerializationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_WriteColor_Public_Static_Void_BinaryWriter_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadColor_Public_Static_Void_BinaryReader_byref_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WritePaintData_Public_Static_Void_BinaryWriter_byref_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPaintData_Public_Static_Void_BinaryReader_byref_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteFloatArrayWrapper_Public_Static_Void_BinaryWriter_byref_FloatArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloatArrayWrapper_Public_Static_Void_BinaryReader_byref_FloatArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteFloatArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloatArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteIntArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadIntArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteStringArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadStringArray_Public_Static_Void_BinaryReader_byref_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteBoolArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBoolArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteShortArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadShortArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeItemsList_Public_Static_Void_BinaryWriter_List_1_Item_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeItemsList_Public_Static_Void_BinaryReader_byref_List_1_Item_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatToUint_Private_Static_UInt32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UintToFloat_Private_Static_Single_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteAsUint_Public_Static_Void_BinaryWriter_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUintAsFloat_Public_Static_Single_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213346, RefRangeEnd = 213348, XrefRangeStart = 213337, XrefRangeEnd = 213346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteColor(BinaryWriter binaryWriter, Il2CppStructArray<float> color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteColor_Public_Static_Void_BinaryWriter_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213351, RefRangeEnd = 213353, XrefRangeStart = 213348, XrefRangeEnd = 213351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadColor(BinaryReader binaryReader, out Il2CppStructArray<float> color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadColor_Public_Static_Void_BinaryReader_byref_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 213354, RefRangeEnd = 213361, XrefRangeStart = 213353, XrefRangeEnd = 213354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WritePaintData(BinaryWriter binaryWriter, ref PaintData paintData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref paintData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WritePaintData_Public_Static_Void_BinaryWriter_byref_PaintData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 213366, RefRangeEnd = 213373, XrefRangeStart = 213361, XrefRangeEnd = 213366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadPaintData(BinaryReader binaryReader, ref PaintData paintData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref paintData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPaintData_Public_Static_Void_BinaryReader_byref_PaintData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 213374, RefRangeEnd = 213379, XrefRangeStart = 213373, XrefRangeEnd = 213374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteFloatArrayWrapper(BinaryWriter binaryWriter, ref FloatArrayWrapper wrapper)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(wrapper);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteFloatArrayWrapper_Public_Static_Void_BinaryWriter_byref_FloatArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 213383, RefRangeEnd = 213390, XrefRangeStart = 213379, XrefRangeEnd = 213383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadFloatArrayWrapper(BinaryReader binaryReader, ref FloatArrayWrapper wrapper)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(wrapper);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFloatArrayWrapper_Public_Static_Void_BinaryReader_byref_FloatArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 213391, RefRangeEnd = 213392, XrefRangeStart = 213390, XrefRangeEnd = 213391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteFloatArray(BinaryWriter binaryWriter, ref Il2CppStructArray<float> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteFloatArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213395, RefRangeEnd = 213397, XrefRangeStart = 213392, XrefRangeEnd = 213395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadFloatArray(BinaryReader binaryReader, out Il2CppStructArray<float> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFloatArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213398, RefRangeEnd = 213400, XrefRangeStart = 213397, XrefRangeEnd = 213398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteIntArray(BinaryWriter binaryWriter, ref Il2CppStructArray<int> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteIntArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 213403, RefRangeEnd = 213412, XrefRangeStart = 213400, XrefRangeEnd = 213403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadIntArray(BinaryReader binaryReader, out Il2CppStructArray<int> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadIntArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213413, RefRangeEnd = 213415, XrefRangeStart = 213412, XrefRangeEnd = 213413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteStringArray(BinaryWriter binaryWriter, ref Il2CppStringArray array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp((string)(object)array);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteStringArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		array = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppStringArray(intPtr3));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213422, RefRangeEnd = 213424, XrefRangeStart = 213415, XrefRangeEnd = 213422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadStringArray(BinaryReader binaryReader, out Il2CppStringArray array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp((string)(object)array);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadStringArray_Public_Static_Void_BinaryReader_byref_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		array = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppStringArray(intPtr3));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 213425, RefRangeEnd = 213429, XrefRangeStart = 213424, XrefRangeEnd = 213425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteBoolArray(BinaryWriter binaryWriter, ref Il2CppStructArray<bool> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteBoolArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 213432, RefRangeEnd = 213438, XrefRangeStart = 213429, XrefRangeEnd = 213432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadBoolArray(BinaryReader binaryReader, out Il2CppStructArray<bool> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBoolArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213438, XrefRangeEnd = 213439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteShortArray(BinaryWriter binaryWriter, ref Il2CppStructArray<short> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteShortArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Int16_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213439, XrefRangeEnd = 213442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadShortArray(BinaryReader binaryReader, out Il2CppStructArray<short> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadShortArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Int16_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 213446, RefRangeEnd = 213449, XrefRangeStart = 213442, XrefRangeEnd = 213446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeItemsList(BinaryWriter binaryWriter, List<Item> items, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeItemsList_Public_Static_Void_BinaryWriter_List_1_Item_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 213466, RefRangeEnd = 213470, XrefRangeStart = 213449, XrefRangeEnd = 213466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeserializeItemsList(BinaryReader binaryReader, ref List<Item> items, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr**)num = &intPtr;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeItemsList_Public_Static_Void_BinaryReader_byref_List_1_Item_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		items = (List<Item>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(0)]
	public unsafe static uint FloatToUint(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatToUint_Private_Static_UInt32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(uint*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float UintToFloat(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UintToFloat_Private_Static_Single_UInt32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213470, XrefRangeEnd = 213471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteAsUint(this BinaryWriter binaryWriter, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteAsUint_Public_Static_Void_BinaryWriter_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static float ReadUintAsFloat(this BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadUintAsFloat_Public_Static_Single_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static SerializationHelper()
	{
		Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "SerializationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr);
		NativeMethodInfoPtr_WriteColor_Public_Static_Void_BinaryWriter_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679328);
		NativeMethodInfoPtr_ReadColor_Public_Static_Void_BinaryReader_byref_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679329);
		NativeMethodInfoPtr_WritePaintData_Public_Static_Void_BinaryWriter_byref_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679330);
		NativeMethodInfoPtr_ReadPaintData_Public_Static_Void_BinaryReader_byref_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679331);
		NativeMethodInfoPtr_WriteFloatArrayWrapper_Public_Static_Void_BinaryWriter_byref_FloatArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679332);
		NativeMethodInfoPtr_ReadFloatArrayWrapper_Public_Static_Void_BinaryReader_byref_FloatArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679333);
		NativeMethodInfoPtr_WriteFloatArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679334);
		NativeMethodInfoPtr_ReadFloatArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679335);
		NativeMethodInfoPtr_WriteIntArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679336);
		NativeMethodInfoPtr_ReadIntArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679337);
		NativeMethodInfoPtr_WriteStringArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679338);
		NativeMethodInfoPtr_ReadStringArray_Public_Static_Void_BinaryReader_byref_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679339);
		NativeMethodInfoPtr_WriteBoolArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679340);
		NativeMethodInfoPtr_ReadBoolArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679341);
		NativeMethodInfoPtr_WriteShortArray_Public_Static_Void_BinaryWriter_byref_ArrayOf_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679342);
		NativeMethodInfoPtr_ReadShortArray_Public_Static_Void_BinaryReader_byref_ArrayOf_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679343);
		NativeMethodInfoPtr_SerializeItemsList_Public_Static_Void_BinaryWriter_List_1_Item_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679344);
		NativeMethodInfoPtr_DeserializeItemsList_Public_Static_Void_BinaryReader_byref_List_1_Item_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679345);
		NativeMethodInfoPtr_FloatToUint_Private_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679346);
		NativeMethodInfoPtr_UintToFloat_Private_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679347);
		NativeMethodInfoPtr_WriteAsUint_Public_Static_Void_BinaryWriter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679348);
		NativeMethodInfoPtr_ReadUintAsFloat_Public_Static_Single_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHelper>.NativeClassPtr, 100679349);
	}

	public SerializationHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
