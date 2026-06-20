using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Themes;

public static class ThemeManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_currentTheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultTheme;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreDefault_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTheme_Public_Static_Void_Theme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTheme_Public_Static_Theme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeDefault_Private_Static_Theme_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr));

	public unsafe static Theme currentTheme
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Theme result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentTheme, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentTheme, &theme);
		}
	}

	public unsafe static Theme defaultTheme
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Theme result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultTheme, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultTheme, &theme);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185317, RefRangeEnd = 185318, XrefRangeStart = 185312, XrefRangeEnd = 185317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RestoreDefault()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreDefault_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185318, XrefRangeEnd = 185322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTheme(Theme theme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&theme);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTheme_Public_Static_Void_Theme_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185322, XrefRangeEnd = 185326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Theme GetTheme()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTheme_Public_Static_Theme_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Theme*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185326, XrefRangeEnd = 185332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Theme MakeDefault()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeDefault_Private_Static_Theme_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Theme*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static ThemeManager()
	{
		Il2CppClassPointerStore<ThemeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Themes", "ThemeManager");
		NativeFieldInfoPtr_currentTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "currentTheme");
		NativeFieldInfoPtr_defaultTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, "defaultTheme");
		NativeMethodInfoPtr_RestoreDefault_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100676881);
		NativeMethodInfoPtr_SetTheme_Public_Static_Void_Theme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100676882);
		NativeMethodInfoPtr_GetTheme_Public_Static_Theme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100676883);
		NativeMethodInfoPtr_MakeDefault_Private_Static_Theme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeManager>.NativeClassPtr, 100676884);
	}

	public ThemeManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
