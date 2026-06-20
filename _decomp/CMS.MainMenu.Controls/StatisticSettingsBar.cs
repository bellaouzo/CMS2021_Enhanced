using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.MainMenu.Controls;

public class StatisticSettingsBar : SettingsBar
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sumStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_subtractStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_statisticID;

	private static readonly System.IntPtr NativeFieldInfoPtr_statisticID1;

	private static readonly System.IntPtr NativeFieldInfoPtr_statisticID2;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForSingle_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForSum_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr));

	public unsafe bool sumStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sumStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sumStats)) = flag;
		}
	}

	public unsafe bool subtractStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subtractStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subtractStats)) = flag;
		}
	}

	public unsafe string statisticID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string statisticID1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticID1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticID1), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string statisticID2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticID2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticID2), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150868, XrefRangeEnd = 150882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150882, XrefRangeEnd = 150896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForSingle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForSingle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 150918, RefRangeEnd = 150919, XrefRangeStart = 150896, XrefRangeEnd = 150918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForSum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForSum_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe StatisticSettingsBar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StatisticSettingsBar()
	{
		Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.MainMenu.Controls", "StatisticSettingsBar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr);
		NativeFieldInfoPtr_sumStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, "sumStats");
		NativeFieldInfoPtr_subtractStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, "subtractStats");
		NativeFieldInfoPtr_statisticID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, "statisticID");
		NativeFieldInfoPtr_statisticID1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, "statisticID1");
		NativeFieldInfoPtr_statisticID2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, "statisticID2");
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, 100673795);
		NativeMethodInfoPtr_PrepareForSingle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, 100673796);
		NativeMethodInfoPtr_PrepareForSum_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, 100673797);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticSettingsBar>.NativeClassPtr, 100673798);
	}

	public StatisticSettingsBar(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
