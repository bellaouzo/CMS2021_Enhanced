using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Logic.Navigation;
using CMS.UI.Logic.Tabs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Upgrades;

public class GarageAndToolsTab : UpgradeTab
{
	[ObfuscatedName("CMS.UI.Logic.Upgrades.GarageAndToolsTab/<>c__DisplayClass30_0")]
	public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_upgradeID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SwitchObjectsUnlock_b__0_Internal_Boolean_UpgradeObjectsData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr));

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
		public unsafe __c__DisplayClass30_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _SwitchObjectsUnlock_b__0(UpgradeObjectsData u)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(u));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SwitchObjectsUnlock_b__0_Internal_Boolean_UpgradeObjectsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass30_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "<>c__DisplayClass30_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr);
			NativeFieldInfoPtr_upgradeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr, "upgradeID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr, 100676655);
			NativeMethodInfoPtr__SwitchObjectsUnlock_b__0_Internal_Boolean_UpgradeObjectsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass30_0>.NativeClassPtr, 100676656);
		}

		public __c__DisplayClass30_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.UI.Logic.Upgrades.GarageAndToolsTab/<SwitchObjectsUnlock>d__30")]
	public sealed class _SwitchObjectsUnlock_d__30 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_upgradeID;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_withFade;

		private static readonly System.IntPtr NativeFieldInfoPtr_unlockUpgrade;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__objectsData_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__screenFader_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

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

		public unsafe GarageAndToolsTab __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GarageAndToolsTab(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe bool withFade
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_withFade);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_withFade)) = flag;
			}
		}

		public unsafe bool unlockUpgrade
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockUpgrade);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockUpgrade)) = flag;
			}
		}

		public unsafe __c__DisplayClass30_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new __c__DisplayClass30_0(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UpgradeObjectsData _objectsData_5__2
		{
			get
			{
				nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectsData_5__2);
				return new UpgradeObjectsData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, data));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectsData_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ScreenFader _screenFader_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenFader_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new ScreenFader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenFader_5__3), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _SwitchObjectsUnlock_d__30(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182348, XrefRangeEnd = 182433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182433, XrefRangeEnd = 182438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _SwitchObjectsUnlock_d__30()
		{
			Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "<SwitchObjectsUnlock>d__30");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_upgradeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "upgradeID");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_withFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "withFade");
			NativeFieldInfoPtr_unlockUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "unlockUpgrade");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__objectsData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "<objectsData>5__2");
			NativeFieldInfoPtr__screenFader_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, "<screenFader>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, 100676657);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, 100676658);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, 100676659);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, 100676660);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, 100676661);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SwitchObjectsUnlock_d__30>.NativeClassPtr, 100676662);
		}

		public _SwitchObjectsUnlock_d__30(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_gridNavigationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeObjectsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_costText;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeRequirementsText;

	private static readonly System.IntPtr NativeFieldInfoPtr_icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeDesc;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevUpgradeItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentUpgradeItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTab_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetTab_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCostTextColor_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareItems_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSkillSelect_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRightPanelData_Private_Void_UpgradeItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPrevLockedByBGColor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDescriptionForSkill_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockSkill_Private_Void_UpgradeItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBuy_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareLowLevelGarage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchIfUnlocked_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchObjectsUnlock_Private_IEnumerator_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchInteractiveObjects_Private_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSkillState_Private_Void_UpgradeItem_UpgradeState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRelatedSkillState_Private_Void_UpgradeItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUIDescription_Public_Void_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockCurrentSelectedSkillAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillAction_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<UpgradeItem> upgradeItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<UpgradeItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeItems), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GridNavigationManager gridNavigationManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridNavigationManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GridNavigationManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridNavigationManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<UpgradeObjectsData> upgradeObjectsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeObjectsData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<UpgradeObjectsData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeObjectsData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text costText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_costText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text upgradeRequirementsText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeRequirementsText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeRequirementsText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text upgradeDesc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeDesc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeDesc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text upgradeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UpgradeSystem upgradeSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UpgradeSystem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIDescription uiDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UpgradeItem prevUpgradeItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevUpgradeItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UpgradeItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevUpgradeItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UpgradeItem currentUpgradeItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentUpgradeItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UpgradeItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentUpgradeItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182438, XrefRangeEnd = 182497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void InitializeTab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_InitializeTab_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182497, XrefRangeEnd = 182505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ResetTab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ResetTab_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182505, XrefRangeEnd = 182506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182517, RefRangeEnd = 182519, XrefRangeStart = 182506, XrefRangeEnd = 182517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCostTextColor(int upgradeCost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&upgradeCost);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCostTextColor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182519, XrefRangeEnd = 182521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182521, XrefRangeEnd = 182529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterGridEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182529, XrefRangeEnd = 182537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterGridEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182537, XrefRangeEnd = 182567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSkillSelect(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSkillSelect_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182651, RefRangeEnd = 182652, XrefRangeStart = 182567, XrefRangeEnd = 182651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRightPanelData(UpgradeItem upgradeItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRightPanelData_Private_Void_UpgradeItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182680, RefRangeEnd = 182681, XrefRangeStart = 182652, XrefRangeEnd = 182680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPrevLockedByBGColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPrevLockedByBGColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182681, XrefRangeEnd = 182682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDescriptionForSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDescriptionForSkill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182682, XrefRangeEnd = 182695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockSkill(UpgradeItem upgradeItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockSkill_Private_Void_UpgradeItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182717, RefRangeEnd = 182718, XrefRangeStart = 182695, XrefRangeEnd = 182717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanBuy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBuy_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 182808, RefRangeEnd = 182811, XrefRangeStart = 182718, XrefRangeEnd = 182808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareLowLevelGarage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareLowLevelGarage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 182909, RefRangeEnd = 182911, XrefRangeStart = 182811, XrefRangeEnd = 182909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SwitchIfUnlocked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchIfUnlocked_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182953, RefRangeEnd = 182954, XrefRangeStart = 182911, XrefRangeEnd = 182953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182954, XrefRangeEnd = 182957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator SwitchObjectsUnlock(string upgradeID, bool unlockUpgrade, bool withFade = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unlockUpgrade;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &withFade;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchObjectsUnlock_Private_IEnumerator_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 182980, RefRangeEnd = 182984, XrefRangeStart = 182957, XrefRangeEnd = 182980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchInteractiveObjects(string upgradeID, bool on)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(upgradeID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchInteractiveObjects_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182984, XrefRangeEnd = 182986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSkillState(UpgradeItem upgradeItem, UpgradeState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeItem);
		*(UpgradeState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSkillState_Private_Void_UpgradeItem_UpgradeState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182986, XrefRangeEnd = 182990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRelatedSkillState(UpgradeItem upgradeItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeItem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRelatedSkillState_Private_Void_UpgradeItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182990, XrefRangeEnd = 183006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183006, XrefRangeEnd = 183023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(41)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetUIDescription(UIDescription description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUIDescription_Public_Void_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 183040, RefRangeEnd = 183046, XrefRangeStart = 183023, XrefRangeEnd = 183040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183046, XrefRangeEnd = 183093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockCurrentSelectedSkillAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockCurrentSelectedSkillAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183093, XrefRangeEnd = 183111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillAction(float fillValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fillValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillAction_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe GarageAndToolsTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GarageAndToolsTab()
	{
		Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Upgrades", "GarageAndToolsTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr);
		NativeFieldInfoPtr_upgradeItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "upgradeItems");
		NativeFieldInfoPtr_gridNavigationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "gridNavigationManager");
		NativeFieldInfoPtr_upgradeObjectsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "upgradeObjectsData");
		NativeFieldInfoPtr_costText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "costText");
		NativeFieldInfoPtr_upgradeRequirementsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "upgradeRequirementsText");
		NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "icon");
		NativeFieldInfoPtr_upgradeDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "upgradeDesc");
		NativeFieldInfoPtr_upgradeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "upgradeName");
		NativeFieldInfoPtr_upgradeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "upgradeSystem");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "uiDescription");
		NativeFieldInfoPtr_prevUpgradeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "prevUpgradeItem");
		NativeFieldInfoPtr_currentUpgradeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "currentUpgradeItem");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, "isActive");
		NativeMethodInfoPtr_InitializeTab_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676626);
		NativeMethodInfoPtr_ResetTab_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676627);
		NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676628);
		NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676629);
		NativeMethodInfoPtr_UpdateCostTextColor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676630);
		NativeMethodInfoPtr_PrepareItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676631);
		NativeMethodInfoPtr_RegisterGridEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676632);
		NativeMethodInfoPtr_UnregisterGridEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676633);
		NativeMethodInfoPtr_OnSkillSelect_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676634);
		NativeMethodInfoPtr_SetRightPanelData_Private_Void_UpgradeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676635);
		NativeMethodInfoPtr_SetPrevLockedByBGColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676636);
		NativeMethodInfoPtr_UpdateDescriptionForSkill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676637);
		NativeMethodInfoPtr_UnlockSkill_Private_Void_UpgradeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676638);
		NativeMethodInfoPtr_CanBuy_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676639);
		NativeMethodInfoPtr_PrepareLowLevelGarage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676640);
		NativeMethodInfoPtr_SwitchIfUnlocked_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676641);
		NativeMethodInfoPtr_UnlockAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676642);
		NativeMethodInfoPtr_SwitchObjectsUnlock_Private_IEnumerator_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676643);
		NativeMethodInfoPtr_SwitchInteractiveObjects_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676644);
		NativeMethodInfoPtr_UpdateSkillState_Private_Void_UpgradeItem_UpgradeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676645);
		NativeMethodInfoPtr_UpdateRelatedSkillState_Private_Void_UpgradeItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676646);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676647);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676648);
		NativeMethodInfoPtr_SetUIDescription_Public_Void_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676649);
		NativeMethodInfoPtr_SetDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676650);
		NativeMethodInfoPtr_UnlockCurrentSelectedSkillAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676651);
		NativeMethodInfoPtr_FillAction_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676652);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676653);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageAndToolsTab>.NativeClassPtr, 100676654);
	}

	public GarageAndToolsTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
