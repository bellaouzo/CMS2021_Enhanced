using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using CMS.UI.Logic;
using CMS.UI.Logic.CaseOpening;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.Helpers;

public static class UIHelper : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("CMS.Helpers.UIHelper/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_5;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_4;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__20_0_Internal_Int64_BaseItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__20_1_Internal_Int64_BaseItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__20_2_Internal_BaseItem_BaseItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__20_3_Internal_BaseItem_BaseItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__20_4_Internal_BaseItem_BaseItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__20_5_Internal_BaseItem_BaseItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__49_0_Internal_Int64_ChoosePartDownItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__49_1_Internal_Single_ChoosePartDownItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__49_2_Internal_Single_ChoosePartDownItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__49_3_Internal_ChoosePartDownItem_ChoosePartDownItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortItems_b__49_4_Internal_String_ChoosePartDownItem_0;

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

		public unsafe static Il2CppSystem.Func<BaseItem, long> __9__20_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<BaseItem, long>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<BaseItem, long> __9__20_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<BaseItem, long>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<BaseItem, BaseItem> __9__20_2
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_2, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<BaseItem, BaseItem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_2, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<BaseItem, BaseItem> __9__20_3
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_3, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<BaseItem, BaseItem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_3, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<BaseItem, BaseItem> __9__20_4
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_4, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<BaseItem, BaseItem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_4, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<BaseItem, BaseItem> __9__20_5
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_5, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<BaseItem, BaseItem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_5, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<ChoosePartDownItem, long> __9__49_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<ChoosePartDownItem, long>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<ChoosePartDownItem, float> __9__49_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<ChoosePartDownItem, float>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<ChoosePartDownItem, float> __9__49_2
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_2, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<ChoosePartDownItem, float>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_2, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<ChoosePartDownItem, ChoosePartDownItem> __9__49_3
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_3, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<ChoosePartDownItem, ChoosePartDownItem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_3, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<ChoosePartDownItem, string> __9__49_4
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_4, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<ChoosePartDownItem, string>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_4, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe long _SortItems_b__20_0(BaseItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__20_0_Internal_Int64_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(long*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe long _SortItems_b__20_1(BaseItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__20_1_Internal_Int64_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(long*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe BaseItem _SortItems_b__20_2(BaseItem x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__20_2_Internal_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new BaseItem(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe BaseItem _SortItems_b__20_3(BaseItem x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__20_3_Internal_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new BaseItem(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe BaseItem _SortItems_b__20_4(BaseItem x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__20_4_Internal_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new BaseItem(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe BaseItem _SortItems_b__20_5(BaseItem x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__20_5_Internal_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new BaseItem(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe long _SortItems_b__49_0(ChoosePartDownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__49_0_Internal_Int64_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(long*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213471, XrefRangeEnd = 213472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SortItems_b__49_1(ChoosePartDownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__49_1_Internal_Single_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe float _SortItems_b__49_2(ChoosePartDownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__49_2_Internal_Single_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe ChoosePartDownItem _SortItems_b__49_3(ChoosePartDownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__49_3_Internal_ChoosePartDownItem_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ChoosePartDownItem(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213472, XrefRangeEnd = 213473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _SortItems_b__49_4(ChoosePartDownItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortItems_b__49_4_Internal_String_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_0");
			NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_1");
			NativeFieldInfoPtr___9__20_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_2");
			NativeFieldInfoPtr___9__20_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_3");
			NativeFieldInfoPtr___9__20_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_4");
			NativeFieldInfoPtr___9__20_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_5");
			NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_0");
			NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_1");
			NativeFieldInfoPtr___9__49_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_2");
			NativeFieldInfoPtr___9__49_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_3");
			NativeFieldInfoPtr___9__49_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_4");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679425);
			NativeMethodInfoPtr__SortItems_b__20_0_Internal_Int64_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679426);
			NativeMethodInfoPtr__SortItems_b__20_1_Internal_Int64_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679427);
			NativeMethodInfoPtr__SortItems_b__20_2_Internal_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679428);
			NativeMethodInfoPtr__SortItems_b__20_3_Internal_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679429);
			NativeMethodInfoPtr__SortItems_b__20_4_Internal_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679430);
			NativeMethodInfoPtr__SortItems_b__20_5_Internal_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679431);
			NativeMethodInfoPtr__SortItems_b__49_0_Internal_Int64_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679432);
			NativeMethodInfoPtr__SortItems_b__49_1_Internal_Single_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679433);
			NativeMethodInfoPtr__SortItems_b__49_2_Internal_Single_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679434);
			NativeMethodInfoPtr__SortItems_b__49_3_Internal_ChoosePartDownItem_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679435);
			NativeMethodInfoPtr__SortItems_b__49_4_Internal_String_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100679436);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<RefreshLayout>d__24")]
	public sealed class _RefreshLayout_d__24 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_rectTransform;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr));

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

		public unsafe HorizontalOrVerticalLayoutGroup layoutGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new HorizontalOrVerticalLayoutGroup(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe RectTransform rectTransform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectTransform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _RefreshLayout_d__24(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213473, XrefRangeEnd = 213491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213491, XrefRangeEnd = 213496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _RefreshLayout_d__24()
		{
			Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<RefreshLayout>d__24");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, "layoutGroup");
			NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, "rectTransform");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, 100679437);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, 100679438);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, 100679439);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, 100679440);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, 100679441);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshLayout_d__24>.NativeClassPtr, 100679442);
		}

		public _RefreshLayout_d__24(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass50_0")]
	public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetAsChoosePartDownItems_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr));

		public unsafe List<BaseItem> items
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe List<ChoosePartDownItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<ChoosePartDownItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass50_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213496, XrefRangeEnd = 213506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetAsChoosePartDownItems_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetAsChoosePartDownItems_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass50_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass50_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, 100679443);
			NativeMethodInfoPtr__GetAsChoosePartDownItems_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, 100679444);
		}

		public __c__DisplayClass50_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass56_0")]
	public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_separatedKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_resultList;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MultiThreadSearching_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr));

		public unsafe List<BaseItem> items
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStringArray separatedKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_separatedKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_separatedKeys), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe List<BaseItem> resultList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultList), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass56_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213506, XrefRangeEnd = 213529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _MultiThreadSearching_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MultiThreadSearching_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass56_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass56_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_separatedKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr, "separatedKeys");
			NativeFieldInfoPtr_resultList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr, "resultList");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr, 100679445);
			NativeMethodInfoPtr__MultiThreadSearching_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass56_0>.NativeClassPtr, 100679446);
		}

		public __c__DisplayClass56_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass59_0")]
	public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_category;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetItemsForCategory_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr));

		public unsafe List<BaseItem> items
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

		public unsafe string category
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass59_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213529, XrefRangeEnd = 213538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetItemsForCategory_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetItemsForCategory_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass59_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass59_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "category");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, 100679447);
			NativeMethodInfoPtr__GetItemsForCategory_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, 100679448);
		}

		public __c__DisplayClass59_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass60_0")]
	public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBodyItems_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr));

		public unsafe List<BaseItem> items
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass60_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213538, XrefRangeEnd = 213546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetBodyItems_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBodyItems_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass60_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass60_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr, 100679449);
			NativeMethodInfoPtr__GetBodyItems_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass60_0>.NativeClassPtr, 100679450);
		}

		public __c__DisplayClass60_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass61_0")]
	public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_category;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetItemsForCategory_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr));

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

		public unsafe string category
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass61_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213546, XrefRangeEnd = 213555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetItemsForCategory_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetItemsForCategory_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass61_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass61_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr, "category");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr, 100679451);
			NativeMethodInfoPtr__GetItemsForCategory_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass61_0>.NativeClassPtr, 100679452);
		}

		public __c__DisplayClass61_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass62_0")]
	public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetItemsForID_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr));

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

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass62_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213555, XrefRangeEnd = 213569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetItemsForID_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetItemsForID_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass62_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass62_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, "id");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, 100679453);
			NativeMethodInfoPtr__GetItemsForID_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, 100679454);
		}

		public __c__DisplayClass62_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass63_0")]
	public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBaseItemsForIDExact_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr));

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

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass63_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213569, XrefRangeEnd = 213577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetBaseItemsForIDExact_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBaseItemsForIDExact_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass63_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass63_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr, "id");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr, 100679455);
			NativeMethodInfoPtr__GetBaseItemsForIDExact_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass63_0>.NativeClassPtr, 100679456);
		}

		public __c__DisplayClass63_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass64_0")]
	public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetItemsForIDExact_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr));

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

		public unsafe List<Item> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<Item>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass64_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213577, XrefRangeEnd = 213585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetItemsForIDExact_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetItemsForIDExact_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass64_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass64_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, "id");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, 100679457);
			NativeMethodInfoPtr__GetItemsForIDExact_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, 100679458);
		}

		public __c__DisplayClass64_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass65_0")]
	public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_otherPartProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_benchSpecialGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBenches_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr));

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

		public unsafe PartProperty otherPartProperty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartProperty);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PartProperty(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartProperty), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe SpecialGroup benchSpecialGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_benchSpecialGroup);
				return *(SpecialGroup*)num;
			}
			set
			{
				*(SpecialGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_benchSpecialGroup)) = specialGroup;
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass65_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213585, XrefRangeEnd = 213599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetBenches_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBenches_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass65_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass65_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "id");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_otherPartProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "otherPartProperty");
			NativeFieldInfoPtr_benchSpecialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "benchSpecialGroup");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, 100679459);
			NativeMethodInfoPtr__GetBenches_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, 100679460);
		}

		public __c__DisplayClass65_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass66_0")]
	public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_specialGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBonusParts_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr));

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

		public unsafe SpecialGroup specialGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGroup);
				return *(SpecialGroup*)num;
			}
			set
			{
				*(SpecialGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGroup)) = specialGroup;
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass66_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213599, XrefRangeEnd = 213607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetBonusParts_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBonusParts_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass66_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass66_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_specialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, "specialGroup");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, 100679461);
			NativeMethodInfoPtr__GetBonusParts_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, 100679462);
		}

		public __c__DisplayClass66_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass67_0")]
	public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_otherPartProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetOtherItems_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr));

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

		public unsafe PartProperty otherPartProperty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartProperty);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PartProperty(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartProperty), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass67_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213607, XrefRangeEnd = 213620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetOtherItems_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetOtherItems_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass67_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass67_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "id");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_otherPartProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "otherPartProperty");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100679463);
			NativeMethodInfoPtr__GetOtherItems_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100679464);
		}

		public __c__DisplayClass67_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass68_0")]
	public sealed class __c__DisplayClass68_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_paintCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetItemsToPaint_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr));

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

		public unsafe ConcurrentDictionary<string, bool> paintCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintCache);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, bool>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintCache), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass68_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213620, XrefRangeEnd = 213632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetItemsToPaint_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetItemsToPaint_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass68_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass68_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_paintCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr, "paintCache");
			NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr, "gameInventory");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr, 100679465);
			NativeMethodInfoPtr__GetItemsToPaint_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass68_0>.NativeClassPtr, 100679466);
		}

		public __c__DisplayClass68_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass69_0")]
	public sealed class __c__DisplayClass69_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetTiresWithSize_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr));

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

		public unsafe int size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = num;
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass69_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213632, XrefRangeEnd = 213642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetTiresWithSize_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetTiresWithSize_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass69_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass69_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, "size");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, 100679467);
			NativeMethodInfoPtr__GetTiresWithSize_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, 100679468);
		}

		public __c__DisplayClass69_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.UIHelper/<>c__DisplayClass70_0")]
	public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		private static readonly System.IntPtr NativeFieldInfoPtr_elements;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetAbsorbers_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr));

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

		public unsafe Il2CppStringArray elements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe List<BaseItem> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass70_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213642, XrefRangeEnd = 213655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetAbsorbers_b__0(int i, ParallelLoopState stateA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateA);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetAbsorbers_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass70_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, "<>c__DisplayClass70_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr);
			NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, "items");
			NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, "elements");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, "result");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, 100679469);
			NativeMethodInfoPtr__GetAbsorbers_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, 100679470);
		}

		public __c__DisplayClass70_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiscountPrice_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiscountToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QualityToText_Public_Static_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextTuningValueWithQualityMod_Public_Static_String_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningValueWithQualityMod_Public_Static_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TuningToText_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TuningToTextWS_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvariantFormat_Private_Static_String_String_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeedUnit_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMileageUnit_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDistanceUnit_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MileageToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpeedToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpeedToStringOpt_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeightToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarNameWithYear_Public_Static_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarNameWithYearWithoutSize_Public_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNotDiscoveredPartName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDecimalPlaces_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItems_Public_Static_Void_byref_List_1_BaseItem_SortType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizationForLockReason_Public_Static_String_MapDestinationLockReason_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortTypeToLocalizationKey_Public_Static_String_SortType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPriceForQuality_Public_Static_Int32_Item_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLayout_Public_Static_IEnumerator_HorizontalOrVerticalLayoutGroup_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseInRectTransform_Public_Static_Boolean_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCaseOpeningCardValue_Public_Static_Void_CaseOpeningItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InventoryCategoryToString_Public_Static_String_InventoryCategories_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoneyToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoneyToStringAdvanced_Public_Static_String_Single_MoneyFormat_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConditionToColor_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WheelAlignmentToColor_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QualityToColor_Public_Static_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarName_Public_Static_Void_CarLoader_Text_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarName_Public_Static_Void_String_Int32_Text_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarVersion_Public_Static_Void_CarLoader_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarVersion_Public_Static_Void_String_Int32_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarTire_Public_Static_Void_CarLoader_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarRim_Public_Static_Void_CarLoader_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarColor_Public_Static_Void_CarLoader_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarColor_Public_Static_Void_Image_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_String_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_CarLoader_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_String_Int32_String_Text_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTireSize_Public_Static_Void_NewCarData_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarBrand_Public_Static_Void_String_Int32_Image_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarPreview_Public_Static_Void_String_Image_GameInventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarTireType_Public_Static_Void_String_String_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarTireType_Public_Static_Void_String_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItems_Public_Static_Void_byref_List_1_ChoosePartDownItem_SortType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAsChoosePartDownItems_Public_Static_List_1_ChoosePartDownItem_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityPresetName_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformancePresetName_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintTypeFromIndex_Public_Static_PaintType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexFromPaintType_Public_Static_Int32_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchItems_Public_Static_List_1_BaseItem_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiThreadSearching_Private_Static_List_1_BaseItem_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchLicensePlateStrict_Private_Static_Boolean_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchLicensePlate_Private_Static_Boolean_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Public_Static_List_1_BaseItem_List_1_BaseItem_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyItems_Public_Static_List_1_BaseItem_List_1_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForCategory_Public_Static_List_1_BaseItem_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForID_Public_Static_List_1_BaseItem_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseItemsForIDExact_Public_Static_List_1_BaseItem_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsForIDExact_Public_Static_List_1_Item_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBenches_Public_Static_List_1_BaseItem_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBonusParts_Public_Static_List_1_BaseItem_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOtherItems_Public_Static_List_1_BaseItem_List_1_Item_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsToPaint_Public_Static_List_1_BaseItem_List_1_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTiresWithSize_Public_Static_List_1_BaseItem_List_1_Item_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbsorbers_Public_Static_List_1_BaseItem_List_1_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorForTuningBarValue_Public_Static_Color_Int16_Int16_Int16_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorForTuningValue_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleForValue_Public_Static_Single_Int16_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIHelper>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static float GetDiscountPrice(float discountPercent, float price)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&discountPercent);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &price;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiscountPrice_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 213661, RefRangeEnd = 213666, XrefRangeStart = 213655, XrefRangeEnd = 213661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DiscountToString(float discountPercent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&discountPercent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscountToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213666, XrefRangeEnd = 213678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string QualityToText(int quality, [Optional] int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&quality);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QualityToText_Public_Static_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213678, XrefRangeEnd = 213692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTextTuningValueWithQualityMod(float power, float condition, int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&power);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextTuningValueWithQualityMod_Public_Static_String_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static float GetTuningValueWithQualityMod(float power, float bonusTuning, float condition, int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&power);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bonusTuning;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningValueWithQualityMod_Public_Static_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 213711, RefRangeEnd = 213714, XrefRangeStart = 213692, XrefRangeEnd = 213711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TuningToText(float tuning)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tuning);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TuningToText_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 213720, RefRangeEnd = 213721, XrefRangeStart = 213714, XrefRangeEnd = 213720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TuningToTextWS(float tuning)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tuning);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TuningToTextWS_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 213730, RefRangeEnd = 213735, XrefRangeStart = 213721, XrefRangeEnd = 213730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InvariantFormat(string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvariantFormat_Private_Static_String_String_ArrayOf_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 213744, RefRangeEnd = 213748, XrefRangeStart = 213735, XrefRangeEnd = 213744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSpeedUnit()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeedUnit_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213748, XrefRangeEnd = 213757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetMileageUnit()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMileageUnit_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213757, XrefRangeEnd = 213766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDistanceUnit()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDistanceUnit_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 213811, RefRangeEnd = 213815, XrefRangeStart = 213766, XrefRangeEnd = 213811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MileageToString(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MileageToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213860, RefRangeEnd = 213862, XrefRangeStart = 213815, XrefRangeEnd = 213860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DistanceToString(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 213899, RefRangeEnd = 213900, XrefRangeStart = 213862, XrefRangeEnd = 213899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SpeedToString(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpeedToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 213916, RefRangeEnd = 213917, XrefRangeStart = 213900, XrefRangeEnd = 213916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SpeedToStringOpt(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpeedToStringOpt_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 213960, RefRangeEnd = 213963, XrefRangeStart = 213917, XrefRangeEnd = 213960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string WeightToString(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeightToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 213987, RefRangeEnd = 213993, XrefRangeStart = 213963, XrefRangeEnd = 213987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCarNameWithYear(string carName, int year, [Optional] int fontSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fontSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarNameWithYear_Public_Static_String_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 214011, RefRangeEnd = 214017, XrefRangeStart = 213993, XrefRangeEnd = 214011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCarNameWithYearWithoutSize(string carName, int year)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarNameWithYearWithoutSize_Public_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214022, RefRangeEnd = 214023, XrefRangeStart = 214017, XrefRangeEnd = 214022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNotDiscoveredPartName(string partName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNotDiscoveredPartName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214041, RefRangeEnd = 214042, XrefRangeStart = 214023, XrefRangeEnd = 214041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDecimalPlaces(float number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&number);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDecimalPlaces_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 214148, RefRangeEnd = 214158, XrefRangeStart = 214042, XrefRangeEnd = 214148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortItems(ref List<BaseItem> itemsToSort, SortType sortType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(itemsToSort);
		*ptr = (nint)(&intPtr);
		*(SortType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortItems_Public_Static_Void_byref_List_1_BaseItem_SortType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		itemsToSort = (List<BaseItem>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214170, RefRangeEnd = 214171, XrefRangeStart = 214158, XrefRangeEnd = 214170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizationForLockReason(MapDestinationLockReason lockReason)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lockReason);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizationForLockReason_Public_Static_String_MapDestinationLockReason_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214171, XrefRangeEnd = 214175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SortTypeToLocalizationKey(SortType sortType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sortType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortTypeToLocalizationKey_Public_Static_String_SortType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214193, RefRangeEnd = 214195, XrefRangeStart = 214175, XrefRangeEnd = 214193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPriceForQuality(Item item, [Optional] int quality, [Optional] float mod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mod;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPriceForQuality_Public_Static_Int32_Item_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214195, XrefRangeEnd = 214198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator RefreshLayout(HorizontalOrVerticalLayoutGroup layoutGroup, RectTransform rectTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshLayout_Public_Static_IEnumerator_HorizontalOrVerticalLayoutGroup_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214204, RefRangeEnd = 214206, XrefRangeStart = 214198, XrefRangeEnd = 214204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMouseInRectTransform(RectTransform rectTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMouseInRectTransform_Public_Static_Boolean_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214219, RefRangeEnd = 214221, XrefRangeStart = 214206, XrefRangeEnd = 214219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCaseOpeningCardValue(CaseOpeningItem card)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCaseOpeningCardValue_Public_Static_Void_CaseOpeningItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 214231, RefRangeEnd = 214237, XrefRangeStart = 214221, XrefRangeEnd = 214231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InventoryCategoryToString(InventoryCategories category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InventoryCategoryToString_Public_Static_String_InventoryCategories_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 214244, RefRangeEnd = 214255, XrefRangeStart = 214237, XrefRangeEnd = 214244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MoneyToString(float money)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&money);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoneyToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 214299, RefRangeEnd = 214333, XrefRangeStart = 214255, XrefRangeEnd = 214299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MoneyToStringAdvanced(float money, [Optional] MoneyFormat format, string color = "#32CE08FF")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&money);
		*(MoneyFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoneyToStringAdvanced_Public_Static_String_Single_MoneyFormat_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 214337, RefRangeEnd = 214353, XrefRangeStart = 214333, XrefRangeEnd = 214337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ConditionToColor(float condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&condition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConditionToColor_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214353, XrefRangeEnd = 214361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color WheelAlignmentToColor(float alignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alignment);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WheelAlignmentToColor_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Color QualityToColor(int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QualityToColor_Public_Static_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214361, XrefRangeEnd = 214366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarName(CarLoader carLoader, Text carName, bool withSize = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carName);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarName_Public_Static_Void_CarLoader_Text_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 214382, RefRangeEnd = 214390, XrefRangeStart = 214366, XrefRangeEnd = 214382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarName(string car, int version, Text carName, bool withSize = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(car);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carName);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarName_Public_Static_Void_String_Int32_Text_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 214404, RefRangeEnd = 214407, XrefRangeStart = 214390, XrefRangeEnd = 214404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarVersion(CarLoader carLoader, Text versionText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(versionText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarVersion_Public_Static_Void_CarLoader_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 214421, RefRangeEnd = 214425, XrefRangeStart = 214407, XrefRangeEnd = 214421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarVersion(string car, int version, Text versionText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(car);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(versionText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarVersion_Public_Static_Void_String_Int32_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214425, XrefRangeEnd = 214427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarTire(CarLoader carLoader, Text factoryTireSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(factoryTireSize);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarTire_Public_Static_Void_CarLoader_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214427, XrefRangeEnd = 214434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarRim(CarLoader carLoader, Text factoryRimType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(factoryRimType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarRim_Public_Static_Void_CarLoader_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static void SetupCarColor(CarLoader carLoader, Image colorImage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colorImage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarColor_Public_Static_Void_CarLoader_Image_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static void SetupCarColor(Image colorImage, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorImage);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarColor_Public_Static_Void_Image_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214434, XrefRangeEnd = 214439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarEngine(string engineID, Text engineText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engineID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(engineText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_String_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214439, XrefRangeEnd = 214448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarEngine(CarLoader carLoader, Text engineText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(engineText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_CarLoader_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214482, RefRangeEnd = 214484, XrefRangeStart = 214448, XrefRangeEnd = 214482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarEngine(string carID, int config, string engineSwap, Text engineText, CarBundleLoader carBundleLoader = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engineSwap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(engineText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_String_Int32_String_Text_CarBundleLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214484, XrefRangeEnd = 214498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupTireSize(NewCarData carData, Text tireText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tireText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTireSize_Public_Static_Void_NewCarData_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 214550, RefRangeEnd = 214556, XrefRangeStart = 214498, XrefRangeEnd = 214550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarBrand(string carID, int config, Image carBrand, CarBundleLoader carBundleLoader = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBrand);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarBrand_Public_Static_Void_String_Int32_Image_CarBundleLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 214599, RefRangeEnd = 214605, XrefRangeStart = 214556, XrefRangeEnd = 214599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarPreview(string carID, Image carPreview, GameInventory gameInventory = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carPreview);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(gameInventory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarPreview_Public_Static_Void_String_Image_GameInventory_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 214618, RefRangeEnd = 214628, XrefRangeStart = 214605, XrefRangeEnd = 214618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarTireType(string frontTire, string rearTire, Text tireType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(frontTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tireType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarTireType_Public_Static_Void_String_String_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214628, XrefRangeEnd = 214630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupCarTireType(string tiresID, Text tireType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tiresID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tireType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarTireType_Public_Static_Void_String_Text_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214674, RefRangeEnd = 214676, XrefRangeStart = 214630, XrefRangeEnd = 214674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortItems(ref List<ChoosePartDownItem> itemsToSort, SortType sortType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(itemsToSort);
		*ptr = (nint)(&intPtr);
		*(SortType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortItems_Public_Static_Void_byref_List_1_ChoosePartDownItem_SortType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		itemsToSort = (List<ChoosePartDownItem>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 214703, RefRangeEnd = 214709, XrefRangeStart = 214676, XrefRangeEnd = 214703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ChoosePartDownItem> GetAsChoosePartDownItems(List<BaseItem> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAsChoosePartDownItems_Public_Static_List_1_ChoosePartDownItem_List_1_BaseItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<ChoosePartDownItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214717, RefRangeEnd = 214718, XrefRangeStart = 214709, XrefRangeEnd = 214717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetQualityPresetName()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualityPresetName_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214726, RefRangeEnd = 214728, XrefRangeStart = 214718, XrefRangeEnd = 214726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPerformancePresetName()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformancePresetName_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static PaintType GetPaintTypeFromIndex(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaintTypeFromIndex_Public_Static_PaintType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 214728, RefRangeEnd = 214731, XrefRangeStart = 214728, XrefRangeEnd = 214728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIndexFromPaintType(PaintType paintType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndexFromPaintType_Public_Static_Int32_PaintType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 214756, RefRangeEnd = 214762, XrefRangeStart = 214731, XrefRangeEnd = 214756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> SearchItems(List<BaseItem> items, string searchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchItems_Public_Static_List_1_BaseItem_List_1_BaseItem_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214762, XrefRangeEnd = 214793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> MultiThreadSearching(List<BaseItem> items, string searchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiThreadSearching_Private_Static_List_1_BaseItem_List_1_BaseItem_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214811, RefRangeEnd = 214812, XrefRangeStart = 214793, XrefRangeEnd = 214811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SearchLicensePlateStrict(Item item, string searchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchLicensePlateStrict_Private_Static_Boolean_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214832, RefRangeEnd = 214833, XrefRangeStart = 214812, XrefRangeEnd = 214832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SearchLicensePlate(Item item, string searchText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchLicensePlate_Private_Static_Boolean_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 214861, RefRangeEnd = 214865, XrefRangeStart = 214833, XrefRangeEnd = 214861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetItemsForCategory(List<BaseItem> items, string category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForCategory_Public_Static_List_1_BaseItem_List_1_BaseItem_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214893, RefRangeEnd = 214895, XrefRangeStart = 214865, XrefRangeEnd = 214893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetBodyItems(List<BaseItem> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyItems_Public_Static_List_1_BaseItem_List_1_BaseItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214923, RefRangeEnd = 214924, XrefRangeStart = 214895, XrefRangeEnd = 214923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetItemsForCategory(List<Item> items, string category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(category);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForCategory_Public_Static_List_1_BaseItem_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 214951, RefRangeEnd = 214953, XrefRangeStart = 214924, XrefRangeEnd = 214951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetItemsForID(List<Item> items, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForID_Public_Static_List_1_BaseItem_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 214980, RefRangeEnd = 214981, XrefRangeStart = 214953, XrefRangeEnd = 214980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetBaseItemsForIDExact(List<Item> items, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseItemsForIDExact_Public_Static_List_1_BaseItem_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 215008, RefRangeEnd = 215010, XrefRangeStart = 214981, XrefRangeEnd = 215008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Item> GetItemsForIDExact(List<Item> items, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsForIDExact_Public_Static_List_1_Item_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Item>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215041, RefRangeEnd = 215042, XrefRangeStart = 215010, XrefRangeEnd = 215041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetBenches(List<Item> items, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBenches_Public_Static_List_1_BaseItem_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215086, RefRangeEnd = 215087, XrefRangeStart = 215042, XrefRangeEnd = 215086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetBonusParts(List<Item> items, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBonusParts_Public_Static_List_1_BaseItem_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215117, RefRangeEnd = 215118, XrefRangeStart = 215087, XrefRangeEnd = 215117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetOtherItems(List<Item> items, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOtherItems_Public_Static_List_1_BaseItem_List_1_Item_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 215165, RefRangeEnd = 215167, XrefRangeStart = 215118, XrefRangeEnd = 215165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetItemsToPaint(List<Item> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsToPaint_Public_Static_List_1_BaseItem_List_1_Item_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 215194, RefRangeEnd = 215196, XrefRangeStart = 215167, XrefRangeEnd = 215194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetTiresWithSize(List<Item> items, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTiresWithSize_Public_Static_List_1_BaseItem_List_1_Item_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215237, RefRangeEnd = 215238, XrefRangeStart = 215196, XrefRangeEnd = 215237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseItem> GetAbsorbers(List<Item> items)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbsorbers_Public_Static_List_1_BaseItem_List_1_Item_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215248, RefRangeEnd = 215249, XrefRangeStart = 215238, XrefRangeEnd = 215248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetColorForTuningBarValue(short value, short min, short max, out float normalizedValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&value);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref normalizedValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorForTuningBarValue_Public_Static_Color_Int16_Int16_Int16_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 215253, RefRangeEnd = 215255, XrefRangeStart = 215249, XrefRangeEnd = 215253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetColorForTuningValue(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorForTuningValue_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float GetScaleForValue(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleForValue_Public_Static_Single_Int16_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static UIHelper()
	{
		Il2CppClassPointerStore<UIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "UIHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetDiscountPrice_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679350);
		NativeMethodInfoPtr_DiscountToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679351);
		NativeMethodInfoPtr_QualityToText_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679352);
		NativeMethodInfoPtr_GetTextTuningValueWithQualityMod_Public_Static_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679353);
		NativeMethodInfoPtr_GetTuningValueWithQualityMod_Public_Static_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679354);
		NativeMethodInfoPtr_TuningToText_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679355);
		NativeMethodInfoPtr_TuningToTextWS_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679356);
		NativeMethodInfoPtr_InvariantFormat_Private_Static_String_String_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679357);
		NativeMethodInfoPtr_GetSpeedUnit_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679358);
		NativeMethodInfoPtr_GetMileageUnit_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679359);
		NativeMethodInfoPtr_GetDistanceUnit_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679360);
		NativeMethodInfoPtr_MileageToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679361);
		NativeMethodInfoPtr_DistanceToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679362);
		NativeMethodInfoPtr_SpeedToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679363);
		NativeMethodInfoPtr_SpeedToStringOpt_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679364);
		NativeMethodInfoPtr_WeightToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679365);
		NativeMethodInfoPtr_GetCarNameWithYear_Public_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679366);
		NativeMethodInfoPtr_GetCarNameWithYearWithoutSize_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679367);
		NativeMethodInfoPtr_GetNotDiscoveredPartName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679368);
		NativeMethodInfoPtr_GetDecimalPlaces_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679369);
		NativeMethodInfoPtr_SortItems_Public_Static_Void_byref_List_1_BaseItem_SortType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679370);
		NativeMethodInfoPtr_GetLocalizationForLockReason_Public_Static_String_MapDestinationLockReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679371);
		NativeMethodInfoPtr_SortTypeToLocalizationKey_Public_Static_String_SortType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679372);
		NativeMethodInfoPtr_GetPriceForQuality_Public_Static_Int32_Item_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679373);
		NativeMethodInfoPtr_RefreshLayout_Public_Static_IEnumerator_HorizontalOrVerticalLayoutGroup_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679374);
		NativeMethodInfoPtr_IsMouseInRectTransform_Public_Static_Boolean_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679375);
		NativeMethodInfoPtr_SetCaseOpeningCardValue_Public_Static_Void_CaseOpeningItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679376);
		NativeMethodInfoPtr_InventoryCategoryToString_Public_Static_String_InventoryCategories_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679377);
		NativeMethodInfoPtr_MoneyToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679378);
		NativeMethodInfoPtr_MoneyToStringAdvanced_Public_Static_String_Single_MoneyFormat_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679379);
		NativeMethodInfoPtr_ConditionToColor_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679380);
		NativeMethodInfoPtr_WheelAlignmentToColor_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679381);
		NativeMethodInfoPtr_QualityToColor_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679382);
		NativeMethodInfoPtr_SetupCarName_Public_Static_Void_CarLoader_Text_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679383);
		NativeMethodInfoPtr_SetupCarName_Public_Static_Void_String_Int32_Text_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679384);
		NativeMethodInfoPtr_SetupCarVersion_Public_Static_Void_CarLoader_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679385);
		NativeMethodInfoPtr_SetupCarVersion_Public_Static_Void_String_Int32_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679386);
		NativeMethodInfoPtr_SetupCarTire_Public_Static_Void_CarLoader_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679387);
		NativeMethodInfoPtr_SetupCarRim_Public_Static_Void_CarLoader_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679388);
		NativeMethodInfoPtr_SetupCarColor_Public_Static_Void_CarLoader_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679389);
		NativeMethodInfoPtr_SetupCarColor_Public_Static_Void_Image_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679390);
		NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_String_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679391);
		NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_CarLoader_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679392);
		NativeMethodInfoPtr_SetupCarEngine_Public_Static_Void_String_Int32_String_Text_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679393);
		NativeMethodInfoPtr_SetupTireSize_Public_Static_Void_NewCarData_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679394);
		NativeMethodInfoPtr_SetupCarBrand_Public_Static_Void_String_Int32_Image_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679395);
		NativeMethodInfoPtr_SetupCarPreview_Public_Static_Void_String_Image_GameInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679396);
		NativeMethodInfoPtr_SetupCarTireType_Public_Static_Void_String_String_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679397);
		NativeMethodInfoPtr_SetupCarTireType_Public_Static_Void_String_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679398);
		NativeMethodInfoPtr_SortItems_Public_Static_Void_byref_List_1_ChoosePartDownItem_SortType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679399);
		NativeMethodInfoPtr_GetAsChoosePartDownItems_Public_Static_List_1_ChoosePartDownItem_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679400);
		NativeMethodInfoPtr_GetQualityPresetName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679401);
		NativeMethodInfoPtr_GetPerformancePresetName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679402);
		NativeMethodInfoPtr_GetPaintTypeFromIndex_Public_Static_PaintType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679403);
		NativeMethodInfoPtr_GetIndexFromPaintType_Public_Static_Int32_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679404);
		NativeMethodInfoPtr_SearchItems_Public_Static_List_1_BaseItem_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679405);
		NativeMethodInfoPtr_MultiThreadSearching_Private_Static_List_1_BaseItem_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679406);
		NativeMethodInfoPtr_SearchLicensePlateStrict_Private_Static_Boolean_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679407);
		NativeMethodInfoPtr_SearchLicensePlate_Private_Static_Boolean_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679408);
		NativeMethodInfoPtr_GetItemsForCategory_Public_Static_List_1_BaseItem_List_1_BaseItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679409);
		NativeMethodInfoPtr_GetBodyItems_Public_Static_List_1_BaseItem_List_1_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679410);
		NativeMethodInfoPtr_GetItemsForCategory_Public_Static_List_1_BaseItem_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679411);
		NativeMethodInfoPtr_GetItemsForID_Public_Static_List_1_BaseItem_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679412);
		NativeMethodInfoPtr_GetBaseItemsForIDExact_Public_Static_List_1_BaseItem_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679413);
		NativeMethodInfoPtr_GetItemsForIDExact_Public_Static_List_1_Item_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679414);
		NativeMethodInfoPtr_GetBenches_Public_Static_List_1_BaseItem_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679415);
		NativeMethodInfoPtr_GetBonusParts_Public_Static_List_1_BaseItem_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679416);
		NativeMethodInfoPtr_GetOtherItems_Public_Static_List_1_BaseItem_List_1_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679417);
		NativeMethodInfoPtr_GetItemsToPaint_Public_Static_List_1_BaseItem_List_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679418);
		NativeMethodInfoPtr_GetTiresWithSize_Public_Static_List_1_BaseItem_List_1_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679419);
		NativeMethodInfoPtr_GetAbsorbers_Public_Static_List_1_BaseItem_List_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679420);
		NativeMethodInfoPtr_GetColorForTuningBarValue_Public_Static_Color_Int16_Int16_Int16_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679421);
		NativeMethodInfoPtr_GetColorForTuningValue_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679422);
		NativeMethodInfoPtr_GetScaleForValue_Public_Static_Single_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100679423);
	}

	public UIHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
