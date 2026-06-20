using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers;

public static class PieMenuHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetIniEntryForSpecialType_Public_Static_String_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIniEntryForMachine_Private_Static_Boolean_IOSpecialType_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipment_Private_Static_Boolean_IOSpecialType_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PieMenuHelper>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213267, RefRangeEnd = 213269, XrefRangeStart = 213217, XrefRangeEnd = 213267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetIniEntryForSpecialType(gameMode previousMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&previousMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIniEntryForSpecialType_Public_Static_String_gameMode_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213269, XrefRangeEnd = 213285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetIniEntryForMachine(IOSpecialType machine, out string iniEntryForSpecialType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&machine);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(iniEntryForSpecialType);
		*(System.IntPtr**)num = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIniEntryForMachine_Private_Static_Boolean_IOSpecialType_byref_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		iniEntryForSpecialType = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsEquipment(IOSpecialType specialType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&specialType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEquipment_Private_Static_Boolean_IOSpecialType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static PieMenuHelper()
	{
		Il2CppClassPointerStore<PieMenuHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "PieMenuHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PieMenuHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetIniEntryForSpecialType_Public_Static_String_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMenuHelper>.NativeClassPtr, 100679312);
		NativeMethodInfoPtr_GetIniEntryForMachine_Private_Static_Boolean_IOSpecialType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMenuHelper>.NativeClassPtr, 100679313);
		NativeMethodInfoPtr_IsEquipment_Private_Static_Boolean_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PieMenuHelper>.NativeClassPtr, 100679314);
	}

	public PieMenuHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
