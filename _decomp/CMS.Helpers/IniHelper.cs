using System;
using System.Runtime.CompilerServices;
using CMS.FileSupport.INI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers;

public static class IniHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSections_Public_Static_List_1_String_byref_IniData_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IniHelper>.NativeClassPtr));

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 213210, RefRangeEnd = 213217, XrefRangeStart = 213196, XrefRangeEnd = 213210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetSections(ref IniData iniData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(iniData);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSections_Public_Static_List_1_String_byref_IniData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		iniData = ((intPtr3 == (System.IntPtr)0) ? null : new IniData(intPtr3));
		return (intPtr2 != (System.IntPtr)0) ? new List<string>(intPtr2) : null;
	}

	static IniHelper()
	{
		Il2CppClassPointerStore<IniHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "IniHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IniHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetSections_Public_Static_List_1_String_byref_IniData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniHelper>.NativeClassPtr, 100679311);
	}

	public IniHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
