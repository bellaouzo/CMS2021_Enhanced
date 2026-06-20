using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.ContainersSave;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class PaintshopData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LastUsedColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastColors;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvert_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToLastColors_Public_Void_PaintshopLastColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindColorIndex_Private_Int32_Color32_PaintType_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToLastColors_Public_Void_Color32_PaintType_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastColors_Public_List_1_PaintshopLastColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr));

	public unsafe List<Color32> LastUsedColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUsedColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Color32>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUsedColors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<PaintshopLastColor> LastColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<PaintshopLastColor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastColors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 218208, RefRangeEnd = 218211, XrefRangeStart = 218200, XrefRangeEnd = 218208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218223, RefRangeEnd = 218224, XrefRangeStart = 218211, XrefRangeEnd = 218223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryConvert()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvert_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 218237, RefRangeEnd = 218239, XrefRangeStart = 218224, XrefRangeEnd = 218237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToLastColors(PaintshopLastColor newColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newColor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToLastColors_Public_Void_PaintshopLastColor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218253, RefRangeEnd = 218254, XrefRangeStart = 218239, XrefRangeEnd = 218253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindColorIndex(Color32 newColor, PaintType paintType, PaintData paintData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&newColor);
		*(PaintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		*(PaintData**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintData;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindColorIndex_Private_Int32_Color32_PaintType_PaintData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218259, RefRangeEnd = 218260, XrefRangeStart = 218254, XrefRangeEnd = 218259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToLastColors(Color32 newColor, PaintType paintType, PaintData paintData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&newColor);
		*(PaintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		*(PaintData**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintData;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToLastColors_Public_Void_Color32_PaintType_PaintData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218268, RefRangeEnd = 218269, XrefRangeStart = 218260, XrefRangeEnd = 218268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<PaintshopLastColor> GetLastColors()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastColors_Public_List_1_PaintshopLastColor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PaintshopLastColor>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218273, RefRangeEnd = 218274, XrefRangeStart = 218269, XrefRangeEnd = 218273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218283, RefRangeEnd = 218284, XrefRangeStart = 218274, XrefRangeEnd = 218283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PaintshopData()
	{
		Il2CppClassPointerStore<PaintshopData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ContainersSave", "PaintshopData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr);
		NativeFieldInfoPtr_LastUsedColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, "LastUsedColors");
		NativeFieldInfoPtr_LastColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, "LastColors");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679730);
		NativeMethodInfoPtr_TryConvert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679731);
		NativeMethodInfoPtr_AddToLastColors_Public_Void_PaintshopLastColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679732);
		NativeMethodInfoPtr_FindColorIndex_Private_Int32_Color32_PaintType_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679733);
		NativeMethodInfoPtr_AddToLastColors_Public_Void_Color32_PaintType_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679734);
		NativeMethodInfoPtr_GetLastColors_Public_List_1_PaintshopLastColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679735);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679736);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, 100679737);
	}

	public PaintshopData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe PaintshopData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PaintshopData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<PaintshopData>.NativeClassPtr))
	{
	}
}
