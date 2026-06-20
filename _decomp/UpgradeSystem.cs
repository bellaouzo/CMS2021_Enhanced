using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class UpgradeSystem : MonoBehaviour
{
	[ObfuscatedName("UpgradeSystem/<>c__DisplayClass8_0")]
	public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUpgradeCost_b__0_Internal_Boolean_Upgrade_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUpgradeCost_b__1_Internal_Boolean_Upgrade_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr));

		public unsafe string id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass8_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _GetUpgradeCost_b__0(Upgrade u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUpgradeCost_b__0_Internal_Boolean_Upgrade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _GetUpgradeCost_b__1(Upgrade u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUpgradeCost_b__1_Internal_Boolean_Upgrade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass8_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, "id");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100668371);
			NativeMethodInfoPtr__GetUpgradeCost_b__0_Internal_Boolean_Upgrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100668372);
			NativeMethodInfoPtr__GetUpgradeCost_b__1_Internal_Boolean_Upgrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100668373);
		}

		public __c__DisplayClass8_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("UpgradeSystem/<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UnlockUpgrade_b__0_Internal_Boolean_Upgrade_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UnlockUpgrade_b__1_Internal_Boolean_Upgrade_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr));

		public unsafe string id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass9_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _UnlockUpgrade_b__0(Upgrade u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UnlockUpgrade_b__0_Internal_Boolean_Upgrade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _UnlockUpgrade_b__1(Upgrade u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UnlockUpgrade_b__1_Internal_Boolean_Upgrade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "id");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100668374);
			NativeMethodInfoPtr__UnlockUpgrade_b__0_Internal_Boolean_Upgrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100668375);
			NativeMethodInfoPtr__UnlockUpgrade_b__1_Internal_Boolean_Upgrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100668376);
		}

		public __c__DisplayClass9_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("UpgradeSystem/<>c__DisplayClass29_0")]
	public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_upgradeID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnlocked_b__0_Internal_Boolean_Upgrade_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnlocked_b__1_Internal_Boolean_Upgrade_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr));

		public unsafe string upgradeID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeID), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass29_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _GetUnlocked_b__0(Upgrade u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnlocked_b__0_Internal_Boolean_Upgrade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _GetUnlocked_b__1(Upgrade u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnlocked_b__1_Internal_Boolean_Upgrade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass29_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "<>c__DisplayClass29_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr);
			NativeFieldInfoPtr_upgradeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr, "upgradeID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr, 100668377);
			NativeMethodInfoPtr__GetUnlocked_b__0_Internal_Boolean_Upgrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr, 100668378);
			NativeMethodInfoPtr__GetUnlocked_b__1_Internal_Boolean_Upgrade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass29_0>.NativeClassPtr, 100668379);
		}

		public __c__DisplayClass29_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradesForPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpgradesForMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointsPerLvl;

	private static readonly System.IntPtr NativeFieldInfoPtr_availablePoints;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailablePoints_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AvailablePoints_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgrades_Public_List_1_Upgrade_UpgradeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeCost_Public_Int32_String_Int32_UpgradeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockUpgrade_Public_Void_String_Int32_UpgradeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForAchievements_Private_Void_UpgradeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSave_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxPoints_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailablePoints_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPoints_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailablePointsForResetPoints_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetUpgradesFromUpgradesWindow_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAll_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockUpgradesForPoints_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCostForReset_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUnlocked_Public_Boolean_String_Int32_UpgradeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanGoToScene_Public_Boolean_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeValue_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFixChance_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeValueBool_Public_Boolean_String_UpgradeType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlocked_Public_ArrayOf_Boolean_String_UpgradeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr));

	public unsafe List<Upgrade> UpgradesForPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpgradesForPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Upgrade>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpgradesForPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Upgrade> UpgradesForMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpgradesForMoney);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Upgrade>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpgradesForMoney), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<int> pointsPerLvl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointsPerLvl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointsPerLvl), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int availablePoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availablePoints);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availablePoints)) = num;
		}
	}

	public unsafe int AvailablePoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AvailablePoints_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AvailablePoints_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe List<Upgrade> GetUpgrades([Optional] UpgradeType upgradeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&upgradeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgrades_Public_List_1_Upgrade_UpgradeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Upgrade>(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 88200, RefRangeEnd = 88211, XrefRangeStart = 88184, XrefRangeEnd = 88200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUpgradeCost(string id, int level, [Optional] UpgradeType upgradeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(UpgradeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgradeType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeCost_Public_Int32_String_Int32_UpgradeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 88257, RefRangeEnd = 88262, XrefRangeStart = 88211, XrefRangeEnd = 88257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockUpgrade(string id, int lvl, [Optional] UpgradeType upgradeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lvl;
		*(UpgradeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgradeType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockUpgrade_Public_Void_String_Int32_UpgradeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 88285, RefRangeEnd = 88288, XrefRangeStart = 88262, XrefRangeEnd = 88285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForAchievements(UpgradeType upgradeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&upgradeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForAchievements_Private_Void_UpgradeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88366, RefRangeEnd = 88367, XrefRangeStart = 88288, XrefRangeEnd = 88366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88367, XrefRangeEnd = 88410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88432, RefRangeEnd = 88433, XrefRangeStart = 88410, XrefRangeEnd = 88432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 88439, RefRangeEnd = 88441, XrefRangeStart = 88433, XrefRangeEnd = 88439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88441, XrefRangeEnd = 88445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxPoints_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88445, XrefRangeEnd = 88451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAvailablePoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvailablePoints_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88459, RefRangeEnd = 88460, XrefRangeStart = 88451, XrefRangeEnd = 88459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88472, RefRangeEnd = 88473, XrefRangeStart = 88460, XrefRangeEnd = 88472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAvailablePointsForResetPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvailablePointsForResetPoints_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88473, XrefRangeEnd = 88482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetUpgradesFromUpgradesWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetUpgradesFromUpgradesWindow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 88495, RefRangeEnd = 88500, XrefRangeStart = 88482, XrefRangeEnd = 88495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAll(bool switchObjects = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&switchObjects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88500, XrefRangeEnd = 88504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockUpgradesForPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockUpgradesForPoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 88523, RefRangeEnd = 88525, XrefRangeStart = 88504, XrefRangeEnd = 88523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88525, XrefRangeEnd = 88530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCostForReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCostForReset_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 88532, RefRangeEnd = 88564, XrefRangeStart = 88530, XrefRangeEnd = 88532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUnlocked(string upgradeID, int level, [Optional] UpgradeType upgradeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(UpgradeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgradeType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUnlocked_Public_Boolean_String_Int32_UpgradeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88564, XrefRangeEnd = 88576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanGoToScene(SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sceneType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanGoToScene_Public_Boolean_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 88634, RefRangeEnd = 88645, XrefRangeStart = 88576, XrefRangeEnd = 88634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetUpgradeValue(string upgradeName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeValue_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 88658, RefRangeEnd = 88661, XrefRangeStart = 88645, XrefRangeEnd = 88658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFixChance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFixChance_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88661, XrefRangeEnd = 88662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetUpgradeValueBool(string upgradeName, [Optional] UpgradeType upgradeType, [Optional] int upgradeLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeName);
		*(UpgradeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgradeType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgradeLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeValueBool_Public_Boolean_String_UpgradeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88677, RefRangeEnd = 88678, XrefRangeStart = 88662, XrefRangeEnd = 88677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<bool> GetUnlocked(string upgradeID, [Optional] UpgradeType upgradeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeID);
		*(UpgradeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgradeType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnlocked_Public_ArrayOf_Boolean_String_UpgradeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88678, XrefRangeEnd = 88689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UpgradeSystem()
	{
		Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UpgradeSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr);
		NativeFieldInfoPtr_UpgradesForPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "UpgradesForPoints");
		NativeFieldInfoPtr_UpgradesForMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "UpgradesForMoney");
		NativeFieldInfoPtr_pointsPerLvl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "pointsPerLvl");
		NativeFieldInfoPtr_availablePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, "availablePoints");
		NativeMethodInfoPtr_get_AvailablePoints_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668345);
		NativeMethodInfoPtr_set_AvailablePoints_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668346);
		NativeMethodInfoPtr_GetUpgrades_Public_List_1_Upgrade_UpgradeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668347);
		NativeMethodInfoPtr_GetUpgradeCost_Public_Int32_String_Int32_UpgradeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668348);
		NativeMethodInfoPtr_UnlockUpgrade_Public_Void_String_Int32_UpgradeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668349);
		NativeMethodInfoPtr_CheckForAchievements_Private_Void_UpgradeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668350);
		NativeMethodInfoPtr_Load_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668351);
		NativeMethodInfoPtr_Save_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668352);
		NativeMethodInfoPtr_LoadSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668353);
		NativeMethodInfoPtr_ClearData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668354);
		NativeMethodInfoPtr_GetMaxPoints_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668355);
		NativeMethodInfoPtr_GetAvailablePoints_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668356);
		NativeMethodInfoPtr_AddPoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668357);
		NativeMethodInfoPtr_GetAvailablePointsForResetPoints_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668358);
		NativeMethodInfoPtr_ResetUpgradesFromUpgradesWindow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668359);
		NativeMethodInfoPtr_UnlockAll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668360);
		NativeMethodInfoPtr_LockUpgradesForPoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668361);
		NativeMethodInfoPtr_LockAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668362);
		NativeMethodInfoPtr_GetCostForReset_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668363);
		NativeMethodInfoPtr_IsUnlocked_Public_Boolean_String_Int32_UpgradeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668364);
		NativeMethodInfoPtr_CanGoToScene_Public_Boolean_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668365);
		NativeMethodInfoPtr_GetUpgradeValue_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668366);
		NativeMethodInfoPtr_GetFixChance_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668367);
		NativeMethodInfoPtr_GetUpgradeValueBool_Public_Boolean_String_UpgradeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668368);
		NativeMethodInfoPtr_GetUnlocked_Public_ArrayOf_Boolean_String_UpgradeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668369);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeSystem>.NativeClassPtr, 100668370);
	}

	public UpgradeSystem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
