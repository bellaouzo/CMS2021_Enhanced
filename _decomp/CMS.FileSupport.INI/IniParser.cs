using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.FileSupport.INI;

public class IniParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_IniData_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_IniData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Private_Static_IniData_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IniParser>.NativeClassPtr));

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 216501, RefRangeEnd = 216523, XrefRangeStart = 216488, XrefRangeEnd = 216501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IniData Parse(TextAsset textAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(textAsset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_IniData_TextAsset_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 216534, RefRangeEnd = 216537, XrefRangeStart = 216523, XrefRangeEnd = 216534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IniData Parse(string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_IniData_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216565, RefRangeEnd = 216567, XrefRangeStart = 216537, XrefRangeEnd = 216565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IniData Parse(Il2CppStringArray content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Private_Static_IniData_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe IniParser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IniParser>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static IniParser()
	{
		Il2CppClassPointerStore<IniParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.FileSupport.INI", "IniParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IniParser>.NativeClassPtr);
		NativeMethodInfoPtr_Parse_Public_Static_IniData_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniParser>.NativeClassPtr, 100679640);
		NativeMethodInfoPtr_Parse_Public_Static_IniData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniParser>.NativeClassPtr, 100679641);
		NativeMethodInfoPtr_Parse_Private_Static_IniData_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniParser>.NativeClassPtr, 100679642);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniParser>.NativeClassPtr, 100679643);
	}

	public IniParser(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
