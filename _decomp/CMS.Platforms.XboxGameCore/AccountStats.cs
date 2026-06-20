using System;
using System.Runtime.CompilerServices;
using CMS.Platforms.Xbox;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Platforms.XboxGameCore;

[System.Serializable]
public class AccountStats : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Achievements;

	private static readonly System.IntPtr NativeFieldInfoPtr_Stats;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountStats_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AccountStats>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<AchievementSave> Achievements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Achievements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<AchievementSave>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Achievements), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<StatSave> Stats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Stats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<StatSave>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Stats), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227305, XrefRangeEnd = 227313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AccountStats(CMS.Platforms.Xbox.AccountStats xdkStats)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountStats>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(xdkStats);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AccountStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe AccountStats()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountStats>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AccountStats()
	{
		Il2CppClassPointerStore<AccountStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.XboxGameCore", "AccountStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountStats>.NativeClassPtr);
		NativeFieldInfoPtr_Achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountStats>.NativeClassPtr, "Achievements");
		NativeFieldInfoPtr_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountStats>.NativeClassPtr, "Stats");
		NativeMethodInfoPtr__ctor_Public_Void_AccountStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountStats>.NativeClassPtr, 100680369);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountStats>.NativeClassPtr, 100680370);
	}

	public AccountStats(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
