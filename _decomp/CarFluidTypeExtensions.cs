using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class CarFluidTypeExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Localize_Public_Static_String_CarFluidType_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarFluidTypeExtensions>.NativeClassPtr));

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 95413, RefRangeEnd = 95416, XrefRangeStart = 95397, XrefRangeEnd = 95413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Localize(this CarFluidType value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Localize_Public_Static_String_CarFluidType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static CarFluidTypeExtensions()
	{
		Il2CppClassPointerStore<CarFluidTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarFluidTypeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarFluidTypeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Localize_Public_Static_String_CarFluidType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarFluidTypeExtensions>.NativeClassPtr, 100668835);
	}

	public CarFluidTypeExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
