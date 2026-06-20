using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class LocalizationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedBodyPartName_Public_Static_Void_String_byref_String_byref_String_byref_String_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr));

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 98447, RefRangeEnd = 98452, XrefRangeStart = 98331, XrefRangeEnd = 98447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalizedBodyPartName(string data, out string carId, out string partId, out string localizedName, bool localizeWithoutCarName = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(carId);
		*(System.IntPtr**)num = &il2CppString;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString2 = IL2CPP.ManagedStringToIl2Cpp(partId);
		*(System.IntPtr**)num2 = &il2CppString2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString3 = IL2CPP.ManagedStringToIl2Cpp(localizedName);
		*(System.IntPtr**)num3 = &il2CppString3;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &localizeWithoutCarName;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedBodyPartName_Public_Static_Void_String_byref_String_byref_String_byref_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		carId = IL2CPP.Il2CppStringToManaged(il2CppString);
		partId = IL2CPP.Il2CppStringToManaged(il2CppString2);
		localizedName = IL2CPP.Il2CppStringToManaged(il2CppString3);
	}

	static LocalizationHelper()
	{
		Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LocalizationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetLocalizedBodyPartName_Public_Static_Void_String_byref_String_byref_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationHelper>.NativeClassPtr, 100669093);
	}

	public LocalizationHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
