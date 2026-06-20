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
public sealed class WindowTintData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LastColors;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindColorIndex_Private_Int32_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToLastColors_Public_Void_Color32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastColors_Public_List_1_TintLastColor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr));

	public unsafe List<TintLastColor> LastColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<TintLastColor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastColors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 218295, RefRangeEnd = 218301, XrefRangeStart = 218287, XrefRangeEnd = 218295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218309, RefRangeEnd = 218310, XrefRangeStart = 218301, XrefRangeEnd = 218309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindColorIndex(Color32 newColor, int opacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newColor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindColorIndex_Private_Int32_Color32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 218324, RefRangeEnd = 218326, XrefRangeStart = 218310, XrefRangeEnd = 218324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToLastColors(Color32 newColor, int opacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newColor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToLastColors_Public_Void_Color32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218326, XrefRangeEnd = 218327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<TintLastColor> GetLastColors()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastColors_Public_List_1_TintLastColor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<TintLastColor>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218330, RefRangeEnd = 218331, XrefRangeStart = 218327, XrefRangeEnd = 218330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218339, RefRangeEnd = 218340, XrefRangeStart = 218331, XrefRangeEnd = 218339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WindowTintData()
	{
		Il2CppClassPointerStore<WindowTintData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ContainersSave", "WindowTintData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr);
		NativeFieldInfoPtr_LastColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, "LastColors");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, 100679740);
		NativeMethodInfoPtr_FindColorIndex_Private_Int32_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, 100679741);
		NativeMethodInfoPtr_AddToLastColors_Public_Void_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, 100679742);
		NativeMethodInfoPtr_GetLastColors_Public_List_1_TintLastColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, 100679743);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, 100679744);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, 100679745);
	}

	public WindowTintData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe WindowTintData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WindowTintData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<WindowTintData>.NativeClassPtr))
	{
	}
}
