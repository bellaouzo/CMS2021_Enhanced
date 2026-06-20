using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	[System.Serializable]
	[ObfuscatedName("Inventory/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__41_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__42_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__43_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__44_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__46_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DeleteJunkForTutorial_b__9_0_Internal_Boolean_Item_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetGroupInventory_b__41_1_Internal_Boolean_GroupItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetWheels_b__42_0_Internal_Boolean_GroupItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetAbsorbers_b__43_0_Internal_Boolean_GroupItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnbalancedWheels_b__44_0_Internal_Boolean_GroupItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetRimsWithSizeGreaterOrEqualThanAndLessThan_b__46_0_Internal_Boolean_GroupItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c>.NativeClassPtr));

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new __c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Item> __9__9_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__9_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Predicate<Item>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__9_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<GroupItem, bool> __9__41_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__41_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<GroupItem, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__41_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<GroupItem, bool> __9__42_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__42_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<GroupItem, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__42_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<GroupItem, bool> __9__43_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__43_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<GroupItem, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__43_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<GroupItem, bool> __9__44_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__44_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<GroupItem, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__44_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<GroupItem, bool> __9__46_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__46_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<GroupItem, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__46_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _DeleteJunkForTutorial_b__9_0(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DeleteJunkForTutorial_b__9_0_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59238, XrefRangeEnd = 59242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetGroupInventory_b__41_1(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetGroupInventory_b__41_1_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59242, XrefRangeEnd = 59246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetWheels_b__42_0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWheels_b__42_0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59246, XrefRangeEnd = 59250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetAbsorbers_b__43_0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetAbsorbers_b__43_0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59250, XrefRangeEnd = 59254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetUnbalancedWheels_b__44_0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnbalancedWheels_b__44_0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59254, XrefRangeEnd = 59258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetRimsWithSizeGreaterOrEqualThanAndLessThan_b__46_0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetRimsWithSizeGreaterOrEqualThanAndLessThan_b__46_0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__9_0");
			NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__41_1");
			NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__42_0");
			NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__43_0");
			NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__44_0");
			NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__46_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666886);
			NativeMethodInfoPtr__DeleteJunkForTutorial_b__9_0_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666887);
			NativeMethodInfoPtr__GetGroupInventory_b__41_1_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666888);
			NativeMethodInfoPtr__GetWheels_b__42_0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666889);
			NativeMethodInfoPtr__GetAbsorbers_b__43_0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666890);
			NativeMethodInfoPtr__GetUnbalancedWheels_b__44_0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666891);
			NativeMethodInfoPtr__GetRimsWithSizeGreaterOrEqualThanAndLessThan_b__46_0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666892);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass10_0")]
	public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cache;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_condition;

		private static readonly System.IntPtr NativeFieldInfoPtr_price;

		private static readonly System.IntPtr NativeFieldInfoPtr_statJunk;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_SpecialGroup_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SellPerCondition_b__1_Internal_Boolean_Item_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SellPerCondition_b__2_Internal_Void_Item_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SellPerCondition_b__3_Internal_Boolean_Item_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr));

		public unsafe ConcurrentDictionary<string, int> cache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, int>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe GameInventory gameInventory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float condition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition)) = num;
			}
		}

		public unsafe int price
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
			}
		}

		public unsafe int statJunk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statJunk);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statJunk)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass10_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59270, RefRangeEnd = 59272, XrefRangeStart = 59258, XrefRangeEnd = 59270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGroup Method_Internal_SpecialGroup_String_0(string itemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_SpecialGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(SpecialGroup*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59272, XrefRangeEnd = 59277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SellPerCondition_b__1(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SellPerCondition_b__1_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59277, XrefRangeEnd = 59281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SellPerCondition_b__2(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SellPerCondition_b__2_Internal_Void_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59281, XrefRangeEnd = 59286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SellPerCondition_b__3(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SellPerCondition_b__3_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass10_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass10_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr);
			NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "cache");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "condition");
			NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "price");
			NativeFieldInfoPtr_statJunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "statJunk");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666893);
			NativeMethodInfoPtr_Method_Internal_SpecialGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666894);
			NativeMethodInfoPtr__SellPerCondition_b__1_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666895);
			NativeMethodInfoPtr__SellPerCondition_b__2_Internal_Void_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666896);
			NativeMethodInfoPtr__SellPerCondition_b__3_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666897);
		}

		public __c__DisplayClass10_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass11_0")]
	public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cache;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_condition;

		private static readonly System.IntPtr NativeFieldInfoPtr_price;

		private static readonly System.IntPtr NativeFieldInfoPtr_statJunk;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_SpecialGroup_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ScrapPerCondition_b__1_Internal_Boolean_Item_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ScrapPerCondition_b__2_Internal_Void_Item_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ScrapPerCondition_b__3_Internal_Boolean_Item_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr));

		public unsafe ConcurrentDictionary<string, int> cache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, int>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe GameInventory gameInventory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float condition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition)) = num;
			}
		}

		public unsafe int price
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
			}
		}

		public unsafe int statJunk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statJunk);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statJunk)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass11_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59298, RefRangeEnd = 59300, XrefRangeStart = 59286, XrefRangeEnd = 59298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGroup Method_Internal_SpecialGroup_String_0(string itemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemId);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_SpecialGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(SpecialGroup*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59300, XrefRangeEnd = 59305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ScrapPerCondition_b__1(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ScrapPerCondition_b__1_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59305, XrefRangeEnd = 59309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScrapPerCondition_b__2(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ScrapPerCondition_b__2_Internal_Void_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59309, XrefRangeEnd = 59314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ScrapPerCondition_b__3(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ScrapPerCondition_b__3_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass11_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass11_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr);
			NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "cache");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "condition");
			NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "price");
			NativeFieldInfoPtr_statJunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "statJunk");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100666898);
			NativeMethodInfoPtr_Method_Internal_SpecialGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100666899);
			NativeMethodInfoPtr__ScrapPerCondition_b__1_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100666900);
			NativeMethodInfoPtr__ScrapPerCondition_b__2_Internal_Void_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100666901);
			NativeMethodInfoPtr__ScrapPerCondition_b__3_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100666902);
		}

		public __c__DisplayClass11_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass12_0")]
	public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetItem_b__0_Internal_Boolean_Item_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr));

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
		public unsafe __c__DisplayClass12_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59314, XrefRangeEnd = 59318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetItem_b__0(Item inventoryItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inventoryItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetItem_b__0_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass12_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass12_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, "id");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, 100666903);
			NativeMethodInfoPtr__GetItem_b__0_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, 100666904);
		}

		public __c__DisplayClass12_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass15_0")]
	public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_UID;

		private static readonly System.IntPtr NativeFieldInfoPtr_ID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseItem_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr));

		public unsafe Inventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Inventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe long UID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID)) = num;
			}
		}

		public unsafe string ID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass15_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59318, XrefRangeEnd = 59321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetBaseItem_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBaseItem_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass15_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass15_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_UID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, "UID");
			NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, "ID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, 100666905);
			NativeMethodInfoPtr__GetBaseItem_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, 100666906);
		}

		public __c__DisplayClass15_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass16_0")]
	public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_UID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FindItemIndex_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr));

		public unsafe Inventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Inventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe long UID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass16_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59321, XrefRangeEnd = 59322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _FindItemIndex_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindItemIndex_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass16_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass16_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_UID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, "UID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, 100666907);
			NativeMethodInfoPtr__FindItemIndex_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass16_0>.NativeClassPtr, 100666908);
		}

		public __c__DisplayClass16_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass37_0")]
	public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_UId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DeleteGroup_b__0_Internal_Boolean_GroupItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr));

		public unsafe long UId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UId);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UId)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass37_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _DeleteGroup_b__0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DeleteGroup_b__0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass37_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass37_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr);
			NativeFieldInfoPtr_UId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr, "UId");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr, 100666909);
			NativeMethodInfoPtr__DeleteGroup_b__0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr, 100666910);
		}

		public __c__DisplayClass37_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass38_0")]
	public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__UId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetGroup_b__0_Internal_Boolean_GroupItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr));

		public unsafe long _UId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UId);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UId)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass38_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _GetGroup_b__0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetGroup_b__0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass38_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass38_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr);
			NativeFieldInfoPtr__UId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr, "_UId");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr, 100666911);
			NativeMethodInfoPtr__GetGroup_b__0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass38_0>.NativeClassPtr, 100666912);
		}

		public __c__DisplayClass38_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass41_0")]
	public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetGroupInventory_b__0_Internal_Boolean_GroupItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetGroupInventory_b__2_Internal_Boolean_GroupItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr));

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
		public unsafe __c__DisplayClass41_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59322, XrefRangeEnd = 59324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetGroupInventory_b__0(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetGroupInventory_b__0_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _GetGroupInventory_b__2(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetGroupInventory_b__2_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass41_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass41_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, "id");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100666913);
			NativeMethodInfoPtr__GetGroupInventory_b__0_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100666914);
			NativeMethodInfoPtr__GetGroupInventory_b__2_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100666915);
		}

		public __c__DisplayClass41_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass41_1")]
	public sealed class __c__DisplayClass41_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_part;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetGroupInventory_b__3_Internal_Boolean_GroupItem_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr));

		public unsafe GameInventory gameInventory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStringArray part
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass41_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59324, XrefRangeEnd = 59325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetGroupInventory_b__3(GroupItem groupItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupItem);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetGroupInventory_b__3_Internal_Boolean_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass41_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass41_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr);
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr, "part");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr, 100666916);
			NativeMethodInfoPtr__GetGroupInventory_b__3_Internal_Boolean_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_1>.NativeClassPtr, 100666917);
		}

		public __c__DisplayClass41_1(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("Inventory/<>c__DisplayClass45_0")]
	public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetRims_b__0_Internal_Boolean_Item_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr));

		public unsafe GameInventory gameInventory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass45_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59325, XrefRangeEnd = 59326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetRims_b__0(Item item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetRims_b__0_Internal_Boolean_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass45_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "<>c__DisplayClass45_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr);
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, "gameInventory");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, 100666918);
			NativeMethodInfoPtr__GetRims_b__0_Internal_Boolean_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, 100666919);
		}

		public __c__DisplayClass45_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_items;

	private static readonly System.IntPtr NativeFieldInfoPtr_groups;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Item_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Void_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteAllInventory_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteJunkForTutorial_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SellPerCondition_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrapPerCondition_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllItems_Public_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Item_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseItem_Public_BaseItem_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindItemIndex_Public_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForRepairTable_Public_List_1_ChoosePartDownItem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItemsForRepair_Private_Int32_ChoosePartDownItem_ChoosePartDownItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanRepair_Private_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForScrapProduction_Public_List_1_ChoosePartDownItem_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForScrapUpgrade_Public_List_1_ChoosePartDownItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForBrakeLathe_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroup_Public_List_1_BaseItem_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPartsToPaint_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTiresWithSize_Public_List_1_BaseItem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsByName_Public_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_List_1_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddSpecialCase_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpecialMap_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateItemsIfNeeded_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGroupsIfNeeded_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGroup_Public_Void_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteGroup_Public_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroup_Public_GroupItem_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroups_Public_List_1_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroupInventorySize_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroupInventory_Public_List_1_GroupItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheels_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbsorbers_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnbalancedWheels_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRims_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRimsWithSizeGreaterOrEqualThanAndLessThan_Public_List_1_GroupItem_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllItemsAndGroups_Public_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Public_List_1_BaseItem_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchItems_Public_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Inventory>.NativeClassPtr));

	public unsafe List<Item> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Item>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<GroupItem> groups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<GroupItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59326, XrefRangeEnd = 59332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59332, XrefRangeEnd = 59346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 59403, RefRangeEnd = 59429, XrefRangeStart = 59346, XrefRangeEnd = 59403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(Item item, bool showPopup = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopup;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Item_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59429, XrefRangeEnd = 59439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(List<BaseItem> newItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItems);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 59455, RefRangeEnd = 59467, XrefRangeStart = 59439, XrefRangeEnd = 59455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Delete(Item item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delete_Public_Void_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59467, XrefRangeEnd = 59469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59473, RefRangeEnd = 59476, XrefRangeStart = 59469, XrefRangeEnd = 59473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteAllInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteAllInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 59501, RefRangeEnd = 59508, XrefRangeStart = 59476, XrefRangeEnd = 59501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteJunkForTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteJunkForTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59602, RefRangeEnd = 59603, XrefRangeStart = 59508, XrefRangeEnd = 59602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SellPerCondition(float condition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&condition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellPerCondition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59690, RefRangeEnd = 59691, XrefRangeStart = 59603, XrefRangeEnd = 59690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrapPerCondition(float condition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&condition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrapPerCondition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59708, RefRangeEnd = 59711, XrefRangeStart = 59691, XrefRangeEnd = 59708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item GetItem(string _ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Item_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59711, XrefRangeEnd = 59716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Item> GetAllItems(string _ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllItems_Public_List_1_Item_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Item>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59716, XrefRangeEnd = 59719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item GetItem(long UID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Item_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 59752, RefRangeEnd = 59755, XrefRangeStart = 59719, XrefRangeEnd = 59752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseItem GetBaseItem(string ID, long UID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &UID;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseItem_Public_BaseItem_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new BaseItem(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59778, RefRangeEnd = 59780, XrefRangeStart = 59755, XrefRangeEnd = 59778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindItemIndex(long UID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindItemIndex_Public_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59818, RefRangeEnd = 59819, XrefRangeStart = 59780, XrefRangeEnd = 59818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ChoosePartDownItem> GetItemsForRepairTable(bool bodyParts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bodyParts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForRepairTable_Public_List_1_ChoosePartDownItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<ChoosePartDownItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe int SortItemsForRepair(ChoosePartDownItem x, ChoosePartDownItem y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortItemsForRepair_Private_Int32_ChoosePartDownItem_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59829, RefRangeEnd = 59830, XrefRangeStart = 59819, XrefRangeEnd = 59829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanRepair(int repairGroup, bool isBodyParts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&repairGroup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyParts;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanRepair_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59830, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ChoosePartDownItem> GetItemsForScrapProduction(float min, float max)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForScrapProduction_Public_List_1_ChoosePartDownItem_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<ChoosePartDownItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59869, RefRangeEnd = 59870, XrefRangeStart = 59848, XrefRangeEnd = 59869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ChoosePartDownItem> GetItemsForScrapUpgrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForScrapUpgrade_Public_List_1_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<ChoosePartDownItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59891, RefRangeEnd = 59892, XrefRangeStart = 59870, XrefRangeEnd = 59891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItemsForBrakeLathe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForBrakeLathe_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 59951, RefRangeEnd = 59957, XrefRangeStart = 59892, XrefRangeEnd = 59951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItems(string _ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_List_1_BaseItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59957, XrefRangeEnd = 59989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetGroup(Il2CppStringArray group)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroup_Public_List_1_BaseItem_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59989, XrefRangeEnd = 59990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetPartsToPaint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPartsToPaint_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59990, XrefRangeEnd = 59991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetTiresWithSize(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTiresWithSize_Public_List_1_BaseItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60000, RefRangeEnd = 60003, XrefRangeStart = 59991, XrefRangeEnd = 60000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItemsByName(string _ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsByName_Public_List_1_BaseItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60003, XrefRangeEnd = 60004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe List<Item> GetItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_List_1_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Item>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60004, XrefRangeEnd = 60025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAddSpecialCase(bool isMission = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isMission);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddSpecialCase_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60025, XrefRangeEnd = 60033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpecialMap([Optional] int amount, bool showPopup = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&amount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showPopup;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpecialMap_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60037, RefRangeEnd = 60039, XrefRangeStart = 60033, XrefRangeEnd = 60037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateItemsIfNeeded(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItemsIfNeeded_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60043, RefRangeEnd = 60045, XrefRangeStart = 60039, XrefRangeEnd = 60043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateGroupsIfNeeded(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGroupsIfNeeded_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60095, RefRangeEnd = 60096, XrefRangeStart = 60045, XrefRangeEnd = 60095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60096, XrefRangeEnd = 60120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60124, RefRangeEnd = 60127, XrefRangeStart = 60120, XrefRangeEnd = 60124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGroup(GroupItem group)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGroup_Public_Void_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 60153, RefRangeEnd = 60162, XrefRangeStart = 60127, XrefRangeEnd = 60153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteGroup(long UId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteGroup_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60175, RefRangeEnd = 60178, XrefRangeStart = 60162, XrefRangeEnd = 60175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GroupItem GetGroup(long _UId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_UId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroup_Public_GroupItem_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GroupItem(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe List<GroupItem> GetGroups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroups_Public_List_1_GroupItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<GroupItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60178, XrefRangeEnd = 60179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGroupInventorySize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroupInventorySize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 60244, RefRangeEnd = 60251, XrefRangeStart = 60179, XrefRangeEnd = 60244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GroupItem> GetGroupInventory(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroupInventory_Public_List_1_GroupItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<GroupItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60271, RefRangeEnd = 60272, XrefRangeStart = 60251, XrefRangeEnd = 60271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetWheels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheels_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60292, RefRangeEnd = 60294, XrefRangeStart = 60272, XrefRangeEnd = 60292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetAbsorbers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbsorbers_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60314, RefRangeEnd = 60315, XrefRangeStart = 60294, XrefRangeEnd = 60314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetUnbalancedWheels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnbalancedWheels_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60315, XrefRangeEnd = 60332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetRims()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRims_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60352, RefRangeEnd = 60353, XrefRangeStart = 60332, XrefRangeEnd = 60352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GroupItem> GetRimsWithSizeGreaterOrEqualThanAndLessThan(int minRimSize, float maxSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minRimSize);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRimsWithSizeGreaterOrEqualThanAndLessThan_Public_List_1_GroupItem_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<GroupItem>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 60364, RefRangeEnd = 60368, XrefRangeStart = 60353, XrefRangeEnd = 60364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetAllItemsAndGroups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllItemsAndGroups_Public_List_1_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60368, XrefRangeEnd = 60374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItemsForCategory(InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForCategory_Public_List_1_BaseItem_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60374, XrefRangeEnd = 60387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> GetItemsForCategory(List<BaseItem> itemsList, InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemsList);
		*(InventoryCategories**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 60406, RefRangeEnd = 60412, XrefRangeStart = 60387, XrefRangeEnd = 60406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SearchAndSortItemsForCategory(string searchText, SortType sortType, InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		*(SortType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortType;
		*(InventoryCategories**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60412, XrefRangeEnd = 60414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SearchItems(string searchText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchItems_Public_List_1_BaseItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60414, XrefRangeEnd = 60421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BaseItem> SortItemsForCategory(SortType sortType, InventoryCategories category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sortType);
		*(InventoryCategories**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60421, XrefRangeEnd = 60436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Inventory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Inventory>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Inventory()
	{
		Il2CppClassPointerStore<Inventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Inventory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Inventory>.NativeClassPtr);
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "items");
		NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "groups");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666833);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666834);
		NativeMethodInfoPtr_Add_Public_Void_Item_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666835);
		NativeMethodInfoPtr_Add_Public_Void_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666836);
		NativeMethodInfoPtr_Delete_Public_Void_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666837);
		NativeMethodInfoPtr_DeleteAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666838);
		NativeMethodInfoPtr_DeleteAllInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666839);
		NativeMethodInfoPtr_DeleteJunkForTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666840);
		NativeMethodInfoPtr_SellPerCondition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666841);
		NativeMethodInfoPtr_ScrapPerCondition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666842);
		NativeMethodInfoPtr_GetItem_Public_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666843);
		NativeMethodInfoPtr_GetAllItems_Public_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666844);
		NativeMethodInfoPtr_GetItem_Public_Item_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666845);
		NativeMethodInfoPtr_GetBaseItem_Public_BaseItem_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666846);
		NativeMethodInfoPtr_FindItemIndex_Public_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666847);
		NativeMethodInfoPtr_GetItemsForRepairTable_Public_List_1_ChoosePartDownItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666848);
		NativeMethodInfoPtr_SortItemsForRepair_Private_Int32_ChoosePartDownItem_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666849);
		NativeMethodInfoPtr_CanRepair_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666850);
		NativeMethodInfoPtr_GetItemsForScrapProduction_Public_List_1_ChoosePartDownItem_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666851);
		NativeMethodInfoPtr_GetItemsForScrapUpgrade_Public_List_1_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666852);
		NativeMethodInfoPtr_GetItemsForBrakeLathe_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666853);
		NativeMethodInfoPtr_GetItems_Public_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666854);
		NativeMethodInfoPtr_GetGroup_Public_List_1_BaseItem_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666855);
		NativeMethodInfoPtr_GetPartsToPaint_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666856);
		NativeMethodInfoPtr_GetTiresWithSize_Public_List_1_BaseItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666857);
		NativeMethodInfoPtr_GetItemsByName_Public_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666858);
		NativeMethodInfoPtr_GetItemsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666859);
		NativeMethodInfoPtr_GetItems_Public_List_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666860);
		NativeMethodInfoPtr_TryAddSpecialCase_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666861);
		NativeMethodInfoPtr_AddSpecialMap_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666862);
		NativeMethodInfoPtr_CreateItemsIfNeeded_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666863);
		NativeMethodInfoPtr_CreateGroupsIfNeeded_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666864);
		NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666865);
		NativeMethodInfoPtr_Save_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666866);
		NativeMethodInfoPtr_AddGroup_Public_Void_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666867);
		NativeMethodInfoPtr_DeleteGroup_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666868);
		NativeMethodInfoPtr_GetGroup_Public_GroupItem_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666869);
		NativeMethodInfoPtr_GetGroups_Public_List_1_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666870);
		NativeMethodInfoPtr_GetGroupInventorySize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666871);
		NativeMethodInfoPtr_GetGroupInventory_Public_List_1_GroupItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666872);
		NativeMethodInfoPtr_GetWheels_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666873);
		NativeMethodInfoPtr_GetAbsorbers_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666874);
		NativeMethodInfoPtr_GetUnbalancedWheels_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666875);
		NativeMethodInfoPtr_GetRims_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666876);
		NativeMethodInfoPtr_GetRimsWithSizeGreaterOrEqualThanAndLessThan_Public_List_1_GroupItem_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666877);
		NativeMethodInfoPtr_GetAllItemsAndGroups_Public_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666878);
		NativeMethodInfoPtr_GetItemsForCategory_Public_List_1_BaseItem_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666879);
		NativeMethodInfoPtr_GetItemsForCategory_Private_List_1_BaseItem_List_1_BaseItem_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666880);
		NativeMethodInfoPtr_SearchAndSortItemsForCategory_Public_List_1_BaseItem_String_SortType_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666881);
		NativeMethodInfoPtr_SearchItems_Public_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666882);
		NativeMethodInfoPtr_SortItemsForCategory_Public_List_1_BaseItem_SortType_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666883);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100666884);
	}

	public Inventory(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
