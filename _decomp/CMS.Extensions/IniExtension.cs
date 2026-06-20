using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using INI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Extensions;

public static class IniExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringFast_Public_Static_String_INIContent_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntFast_Public_Static_Int32_INIContent_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatFast_Public_Static_Single_INIContent_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFloatFast_Public_Static_Void_INIContent_String_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IniExtension>.NativeClassPtr));

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 216838, RefRangeEnd = 216858, XrefRangeStart = 216836, XrefRangeEnd = 216838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStringFast(this INIContent ini, string key, string defaultValue = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringFast_Public_Static_String_INIContent_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 216862, RefRangeEnd = 216882, XrefRangeStart = 216858, XrefRangeEnd = 216862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIntFast(this INIContent ini, string key, [Optional] int defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIntFast_Public_Static_Int32_INIContent_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 216884, RefRangeEnd = 216900, XrefRangeStart = 216882, XrefRangeEnd = 216884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetFloatFast(this INIContent ini, string key, [Optional] float defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatFast_Public_Static_Single_INIContent_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216915, RefRangeEnd = 216919, XrefRangeStart = 216900, XrefRangeEnd = 216915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeFloatFast(this INIContent ini, string key, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFloatFast_Public_Static_Void_INIContent_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static IniExtension()
	{
		Il2CppClassPointerStore<IniExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Extensions", "IniExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IniExtension>.NativeClassPtr);
		NativeMethodInfoPtr_GetStringFast_Public_Static_String_INIContent_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniExtension>.NativeClassPtr, 100679674);
		NativeMethodInfoPtr_GetIntFast_Public_Static_Int32_INIContent_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniExtension>.NativeClassPtr, 100679675);
		NativeMethodInfoPtr_GetFloatFast_Public_Static_Single_INIContent_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniExtension>.NativeClassPtr, 100679676);
		NativeMethodInfoPtr_ChangeFloatFast_Public_Static_Void_INIContent_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniExtension>.NativeClassPtr, 100679677);
	}

	public IniExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
