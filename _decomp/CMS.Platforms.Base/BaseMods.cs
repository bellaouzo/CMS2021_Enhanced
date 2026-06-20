using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Platforms.Base;

public class BaseMods : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Maps;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhotoLocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cars;

	private static readonly System.IntPtr NativeFieldInfoPtr_Languages;

	private static readonly System.IntPtr NativeFieldInfoPtr_LicencePlates;

	private static readonly System.IntPtr NativeFieldInfoPtr_Liveries;

	private static readonly System.IntPtr NativeFieldInfoPtr_Configs;

	private static readonly System.IntPtr NativeFieldInfoPtr_TexturePacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusParts;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstalledItemsPaths_Public_Abstract_Virtual_New_List_1_String_ModType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLiveries_Public_Abstract_Virtual_New_List_1_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigs_Public_Abstract_Virtual_New_List_1_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseMods>.NativeClassPtr));

	public unsafe List<string> Maps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Maps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Maps), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> PhotoLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhotoLocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhotoLocations), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> Cars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> Languages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Languages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Languages), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> LicencePlates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicencePlates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicencePlates), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppStringArray> Liveries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Liveries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Liveries), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppStringArray> Configs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Configs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Configs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> TexturePacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexturePacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexturePacks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<WorkshopBonusPart> BonusParts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusParts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<WorkshopBonusPart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusParts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe List<string> GetInstalledItemsPaths(ModType modeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&modeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetInstalledItemsPaths_Public_Abstract_Virtual_New_List_1_String_ModType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe List<Il2CppStringArray> GetLiveries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLiveries_Public_Abstract_Virtual_New_List_1_ArrayOf_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe List<Il2CppStringArray> GetConfigs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetConfigs_Public_Abstract_Virtual_New_List_1_ArrayOf_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230047, RefRangeEnd = 230048, XrefRangeStart = 229998, XrefRangeEnd = 230047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseMods()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseMods>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseMods()
	{
		Il2CppClassPointerStore<BaseMods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.Base", "BaseMods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseMods>.NativeClassPtr);
		NativeFieldInfoPtr_Maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "Maps");
		NativeFieldInfoPtr_PhotoLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "PhotoLocations");
		NativeFieldInfoPtr_Cars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "Cars");
		NativeFieldInfoPtr_Languages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "Languages");
		NativeFieldInfoPtr_LicencePlates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "LicencePlates");
		NativeFieldInfoPtr_Liveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "Liveries");
		NativeFieldInfoPtr_Configs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "Configs");
		NativeFieldInfoPtr_TexturePacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "TexturePacks");
		NativeFieldInfoPtr_BonusParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, "BonusParts");
		NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, 100680635);
		NativeMethodInfoPtr_GetInstalledItemsPaths_Public_Abstract_Virtual_New_List_1_String_ModType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, 100680636);
		NativeMethodInfoPtr_GetLiveries_Public_Abstract_Virtual_New_List_1_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, 100680637);
		NativeMethodInfoPtr_GetConfigs_Public_Abstract_Virtual_New_List_1_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, 100680638);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMods>.NativeClassPtr, 100680639);
	}

	public BaseMods(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
