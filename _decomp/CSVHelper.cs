using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class CSVHelper : List<Il2CppStringArray>
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CSVHelper>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98078, RefRangeEnd = 98079, XrefRangeStart = 98054, XrefRangeEnd = 98078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSVHelper(string csv, string separator = "\",\"")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CSVHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(csv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(separator);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CSVHelper()
	{
		Il2CppClassPointerStore<CSVHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CSVHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSVHelper>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSVHelper>.NativeClassPtr, 100669069);
	}

	public CSVHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
