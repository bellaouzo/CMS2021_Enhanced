using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace INI;

public static class INIFile : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Static_Boolean_String_INIContent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFile_Private_Static_INIContent_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFile_Private_Static_INIContent_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_INIContent_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTextAssets_Public_Static_INIContent_TextAsset_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<INIFile>.NativeClassPtr));

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 236528, RefRangeEnd = 236534, XrefRangeStart = 236474, XrefRangeEnd = 236528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Write(string filePath, INIContent contents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(contents);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Static_Boolean_String_INIContent_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 236593, RefRangeEnd = 236599, XrefRangeStart = 236534, XrefRangeEnd = 236593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static INIContent ParseFile(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFile_Private_Static_INIContent_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new INIContent(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236635, RefRangeEnd = 236638, XrefRangeStart = 236599, XrefRangeEnd = 236635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static INIContent ParseFile(Il2CppStringArray content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFile_Private_Static_INIContent_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new INIContent(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 236648, RefRangeEnd = 236657, XrefRangeStart = 236638, XrefRangeEnd = 236648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static INIContent Read(string filePath, bool checkIfExists = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkIfExists;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Public_Static_INIContent_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new INIContent(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236657, XrefRangeEnd = 236670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static INIContent ReadTextAssets(TextAsset ta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTextAssets_Public_Static_INIContent_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new INIContent(intPtr) : null;
	}

	static INIFile()
	{
		Il2CppClassPointerStore<INIFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "INI", "INIFile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<INIFile>.NativeClassPtr);
		NativeMethodInfoPtr_Write_Public_Static_Boolean_String_INIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIFile>.NativeClassPtr, 100681095);
		NativeMethodInfoPtr_ParseFile_Private_Static_INIContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIFile>.NativeClassPtr, 100681096);
		NativeMethodInfoPtr_ParseFile_Private_Static_INIContent_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIFile>.NativeClassPtr, 100681097);
		NativeMethodInfoPtr_Read_Public_Static_INIContent_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIFile>.NativeClassPtr, 100681098);
		NativeMethodInfoPtr_ReadTextAssets_Public_Static_INIContent_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIFile>.NativeClassPtr, 100681099);
	}

	public INIFile(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
