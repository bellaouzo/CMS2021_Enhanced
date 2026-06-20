using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class DifficultyHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DifficultyLevelToString_Public_Static_String_DifficultyLevel_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DifficultyHelper>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43384, RefRangeEnd = 43386, XrefRangeStart = 43363, XrefRangeEnd = 43384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DifficultyLevelToString(DifficultyLevel difficultyLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficultyLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DifficultyLevelToString_Public_Static_String_DifficultyLevel_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static DifficultyHelper()
	{
		Il2CppClassPointerStore<DifficultyHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DifficultyHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifficultyHelper>.NativeClassPtr);
		NativeMethodInfoPtr_DifficultyLevelToString_Public_Static_String_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyHelper>.NativeClassPtr, 100665919);
	}

	public DifficultyHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
