using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers;

public static class UpgradesHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FindUpgradeData_Public_Static_UpgradeObjectsData_List_1_UpgradeObjectsData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUpgrade_Public_Static_Upgrade_List_1_Upgrade_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UpgradesHelper>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215255, XrefRangeEnd = 215258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UpgradeObjectsData FindUpgradeData(List<UpgradeObjectsData> list, string upgradeID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(upgradeID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUpgradeData_Public_Static_UpgradeObjectsData_List_1_UpgradeObjectsData_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new UpgradeObjectsData(intPtr);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 215261, RefRangeEnd = 215306, XrefRangeStart = 215258, XrefRangeEnd = 215261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Upgrade FindUpgrade(List<Upgrade> list, string upgradeID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(upgradeID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUpgrade_Public_Static_Upgrade_List_1_Upgrade_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new Upgrade(intPtr);
	}

	static UpgradesHelper()
	{
		Il2CppClassPointerStore<UpgradesHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "UpgradesHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradesHelper>.NativeClassPtr);
		NativeMethodInfoPtr_FindUpgradeData_Public_Static_UpgradeObjectsData_List_1_UpgradeObjectsData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradesHelper>.NativeClassPtr, 100679471);
		NativeMethodInfoPtr_FindUpgrade_Public_Static_Upgrade_List_1_Upgrade_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradesHelper>.NativeClassPtr, 100679472);
	}

	public UpgradesHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
