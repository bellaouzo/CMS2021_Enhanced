using System;
using System.Runtime.CompilerServices;
using CI.TaskParallel.Core;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CI.TaskParallel;

public class UnityTask : Il2CppSystem.Object
{
	[ObfuscatedName("CI.TaskParallel.UnityTask/<>c__DisplayClass7_0")]
	public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr));

		public unsafe Il2CppSystem.Action action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass7_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230182, XrefRangeEnd = 230184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass7_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "<>c__DisplayClass7_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "action");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100680734);
			NativeMethodInfoPtr___ctor_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100680735);
		}

		public __c__DisplayClass7_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CI.TaskParallel.UnityTask/<>c__DisplayClass13_0")]
	public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ContinueWith_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr));

		public unsafe Il2CppSystem.Action<UnityTask> action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<UnityTask>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass13_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230184, XrefRangeEnd = 230187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ContinueWith_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ContinueWith_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass13_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "<>c__DisplayClass13_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, "action");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, 100680736);
			NativeMethodInfoPtr__ContinueWith_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass13_0>.NativeClassPtr, 100680737);
		}

		public __c__DisplayClass13_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CI.TaskParallel.UnityTask/<>c__DisplayClass14_0`1")]
	public sealed class __c__DisplayClass14_0<TResult> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_function;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ContinueWith_b__0_Internal_TResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr));

		public unsafe Il2CppSystem.Func<UnityTask, TResult> function
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_function);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Func<UnityTask, TResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_function), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass14_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230187, XrefRangeEnd = 230188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult _ContinueWith_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ContinueWith_b__0_Internal_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<TResult>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}

		static __c__DisplayClass14_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr);
			NativeFieldInfoPtr_function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr, "function");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr, 100680738);
			NativeMethodInfoPtr__ContinueWith_b__0_Internal_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0<TResult>>.NativeClassPtr, 100680739);
		}

		public __c__DisplayClass14_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CI.TaskParallel.UnityTask/<>c__DisplayClass15_0")]
	public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ContinueOnUIThread_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr));

		public unsafe Il2CppSystem.Action<UnityTask> action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<UnityTask>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230188, XrefRangeEnd = 230192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ContinueOnUIThread_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ContinueOnUIThread_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass15_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "<>c__DisplayClass15_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, "action");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, 100680740);
			NativeMethodInfoPtr__ContinueOnUIThread_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass15_0>.NativeClassPtr, 100680741);
		}

		public __c__DisplayClass15_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_ContinueWith_Public_UnityTask_1_TResult_Func_2_UnityTask_TResult_0<TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ContinueWith_Public_UnityTask_1_TResult_Func_2_UnityTask_TResult_0, Il2CppClassPointerStore<UnityTask>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Run_Public_Static_UnityTask_1_TResult_Func_1_TResult_0<TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Run_Public_Static_UnityTask_1_TResult_Func_1_TResult_0, Il2CppClassPointerStore<UnityTask>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__thread;

	private static readonly System.IntPtr NativeFieldInfoPtr__continuation;

	private static readonly System.IntPtr NativeFieldInfoPtr__dispatcher;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_UnityTaskState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_UnityTaskState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialise_Protected_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueWith_Public_UnityTask_Action_1_UnityTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueWith_Public_UnityTask_1_TResult_Func_2_UnityTask_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueOnUIThread_Public_Void_Action_1_UnityTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Static_UnityTask_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Static_UnityTask_1_TResult_Func_1_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunOnUIThread_Public_Static_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitialiseDispatcher_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitAll_Public_Static_Void_ArrayOf_UnityTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitAll_Public_Static_Void_IEnumerable_1_UnityTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialise_b__9_0_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnityTask>.NativeClassPtr));

	public unsafe UnityTaskState _State_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__State_k__BackingField);
			return *(UnityTaskState*)num;
		}
		set
		{
			*(UnityTaskState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__State_k__BackingField)) = unityTaskState;
		}
	}

	public unsafe UnityThread _thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UnityThread(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IUnityTask _continuation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__continuation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IUnityTask(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__continuation), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static UnityDispatcher _dispatcher
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__dispatcher, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new UnityDispatcher(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__dispatcher, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UnityTaskState State
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_State_Public_get_UnityTaskState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(UnityTaskState*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_State_Protected_set_Void_UnityTaskState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 230202, RefRangeEnd = 230206, XrefRangeStart = 230192, XrefRangeEnd = 230202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityTask(Il2CppSystem.Action action)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTask>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe UnityTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTask>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230225, RefRangeEnd = 230227, XrefRangeStart = 230206, XrefRangeEnd = 230225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialise(Il2CppSystem.Action action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialise_Protected_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230227, XrefRangeEnd = 230228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230228, XrefRangeEnd = 230230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Abort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230230, XrefRangeEnd = 230231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Wait()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230231, XrefRangeEnd = 230243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityTask ContinueWith(Il2CppSystem.Action<UnityTask> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueWith_Public_UnityTask_Action_1_UnityTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230243, XrefRangeEnd = 230249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityTask<TResult> ContinueWith<TResult>(Il2CppSystem.Func<UnityTask, TResult> function)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ContinueWith_Public_UnityTask_1_TResult_Func_2_UnityTask_TResult_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityTask<TResult>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230249, XrefRangeEnd = 230260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueOnUIThread(Il2CppSystem.Action<UnityTask> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueOnUIThread_Public_Void_Action_1_UnityTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230260, XrefRangeEnd = 230265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityTask Run(Il2CppSystem.Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Run_Public_Static_UnityTask_Action_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230268, RefRangeEnd = 230270, XrefRangeStart = 230265, XrefRangeEnd = 230268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityTask<TResult> Run<TResult>(Il2CppSystem.Func<TResult> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Run_Public_Static_UnityTask_1_TResult_Func_1_TResult_0<TResult>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityTask<TResult>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230270, XrefRangeEnd = 230274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunOnUIThread(Il2CppSystem.Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunOnUIThread_Public_Static_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230274, XrefRangeEnd = 230298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitialiseDispatcher()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitialiseDispatcher_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230298, XrefRangeEnd = 230314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WaitAll(Il2CppReferenceArray<UnityTask> unityTasks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityTasks);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitAll_Public_Static_Void_ArrayOf_UnityTask_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230314, XrefRangeEnd = 230330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WaitAll(IEnumerable<UnityTask> unityTasks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityTasks);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitAll_Public_Static_Void_IEnumerable_1_UnityTask_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230330, XrefRangeEnd = 230333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialise_b__9_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialise_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UnityTask()
	{
		Il2CppClassPointerStore<UnityTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CI.TaskParallel", "UnityTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTask>.NativeClassPtr);
		NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "<State>k__BackingField");
		NativeFieldInfoPtr__thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "_thread");
		NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "_continuation");
		NativeFieldInfoPtr__dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, "_dispatcher");
		NativeMethodInfoPtr_get_State_Public_get_UnityTaskState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680716);
		NativeMethodInfoPtr_set_State_Protected_set_Void_UnityTaskState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680717);
		NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680718);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680719);
		NativeMethodInfoPtr_Initialise_Protected_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680720);
		NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680721);
		NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680722);
		NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680723);
		NativeMethodInfoPtr_ContinueWith_Public_UnityTask_Action_1_UnityTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680724);
		NativeMethodInfoPtr_ContinueWith_Public_UnityTask_1_TResult_Func_2_UnityTask_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680725);
		NativeMethodInfoPtr_ContinueOnUIThread_Public_Void_Action_1_UnityTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680726);
		NativeMethodInfoPtr_Run_Public_Static_UnityTask_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680727);
		NativeMethodInfoPtr_Run_Public_Static_UnityTask_1_TResult_Func_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680728);
		NativeMethodInfoPtr_RunOnUIThread_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680729);
		NativeMethodInfoPtr_InitialiseDispatcher_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680730);
		NativeMethodInfoPtr_WaitAll_Public_Static_Void_ArrayOf_UnityTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680731);
		NativeMethodInfoPtr_WaitAll_Public_Static_Void_IEnumerable_1_UnityTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680732);
		NativeMethodInfoPtr__Initialise_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask>.NativeClassPtr, 100680733);
	}

	public UnityTask(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
public class UnityTask<TResult> : UnityTask
{
	[ObfuscatedName("CI.TaskParallel.UnityTask`1/<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_function;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr));

		public unsafe UnityTask<TResult> __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask<TResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Func<TResult> function
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_function);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Func<TResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_function), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230333, XrefRangeEnd = 230334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "function");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100680748);
			NativeMethodInfoPtr___ctor_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100680749);
		}

		public __c__DisplayClass4_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CI.TaskParallel.UnityTask`1/<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ContinueWith_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr));

		public unsafe Il2CppSystem.Action<UnityTask<TResult>> action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<UnityTask<TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask<TResult> __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask<TResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230334, XrefRangeEnd = 230335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ContinueWith_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ContinueWith_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "action");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100680750);
			NativeMethodInfoPtr__ContinueWith_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100680751);
		}

		public __c__DisplayClass5_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CI.TaskParallel.UnityTask`1/<>c__DisplayClass6_0`1")]
	public sealed class __c__DisplayClass6_0<NewTResult> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_function;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ContinueWith_b__0_Internal_NewTResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr));

		public unsafe Il2CppSystem.Func<UnityTask<TResult>, NewTResult> function
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_function);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Func<UnityTask<TResult>, NewTResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_function), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask<TResult> __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask<TResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass6_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe NewTResult _ContinueWith_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ContinueWith_b__0_Internal_NewTResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<NewTResult>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}

		static __c__DisplayClass6_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewTResult>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr);
			NativeFieldInfoPtr_function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr, "function");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr, 100680752);
			NativeMethodInfoPtr__ContinueWith_b__0_Internal_NewTResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0<NewTResult>>.NativeClassPtr, 100680753);
		}

		public __c__DisplayClass6_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CI.TaskParallel.UnityTask`1/<>c__DisplayClass7_0")]
	public new sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ContinueOnUIThread_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr));

		public unsafe Il2CppSystem.Action<UnityTask<TResult>> action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<UnityTask<TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UnityTask<TResult> __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityTask<TResult>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass7_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void _ContinueOnUIThread_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ContinueOnUIThread_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass7_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, "<>c__DisplayClass7_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "action");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100680754);
			NativeMethodInfoPtr__ContinueOnUIThread_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100680755);
		}

		public __c__DisplayClass7_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_ContinueWith_Public_UnityTask_1_NewTResult_Func_2_UnityTask_1_TResult_NewTResult_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnityTask<TResult>.NativeMethodInfoPtr_ContinueWith_Public_UnityTask_1_NewTResult_Func_2_UnityTask_1_TResult_NewTResult_0, Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Result_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Result_Public_get_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Result_Public_set_Void_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueWith_Public_UnityTask_Action_1_UnityTask_1_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueWith_Public_UnityTask_1_NewTResult_Func_2_UnityTask_1_TResult_NewTResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueOnUIThread_Public_Void_Action_1_UnityTask_1_TResult_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr));

	public unsafe TResult _Result_k__BackingField
	{
		get
		{
			nint objectPointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Result_k__BackingField);
			return IL2CPP.PointerToValueGeneric<TResult>(objectPointer, isFieldPointer: true, valueTypeWouldBeBoxed: false);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Result_k__BackingField);
			System.Type typeFromHandle = typeof(TResult);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
					if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						System.IntPtr obj = intPtr;
						// IL cpblk instruction
						System.Runtime.CompilerServices.Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), ref *(uint*)null));
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, intPtr);
					}
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, IL2CPP.ManagedStringToIl2Cpp(val as string));
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.Write((void*)num2, val);
			}
		}
	}

	public unsafe TResult Result
	{
		[CallerCount(4)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Result_Public_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<TResult>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}
		[CallerCount(150)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			//IL_0070->IL0075: Incompatible stack types: I vs Ref
			//IL_004c->IL0075: Incompatible stack types: I vs Ref
			//IL_0059->IL0075: Incompatible stack types: I vs Ref
			//IL_0063->IL0075: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TResult reference;
			if (!typeof(TResult).IsValueType)
			{
				object obj = value;
				if (obj is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
					reference = ref *(_003F*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(_003F*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref value;
			}
			*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Result_Public_set_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230335, XrefRangeEnd = 230342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityTask(Il2CppSystem.Func<TResult> function)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Func_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230342, XrefRangeEnd = 230351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityTask ContinueWith(Il2CppSystem.Action<UnityTask<TResult>> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueWith_Public_UnityTask_Action_1_UnityTask_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityTask(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe UnityTask<NewTResult> ContinueWith<NewTResult>(Il2CppSystem.Func<UnityTask<TResult>, NewTResult> function)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTask<NewTResult>.MethodInfoStoreGeneric_ContinueWith_Public_UnityTask_1_NewTResult_Func_2_UnityTask_1_TResult_NewTResult_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityTask<NewTResult>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230351, XrefRangeEnd = 230359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueOnUIThread(Il2CppSystem.Action<UnityTask<TResult>> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueOnUIThread_Public_Void_Action_1_UnityTask_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UnityTask()
	{
		Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CI.TaskParallel", "UnityTask`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr);
		NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, "<Result>k__BackingField");
		NativeMethodInfoPtr_get_Result_Public_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, 100680742);
		NativeMethodInfoPtr_set_Result_Public_set_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, 100680743);
		NativeMethodInfoPtr__ctor_Public_Void_Func_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, 100680744);
		NativeMethodInfoPtr_ContinueWith_Public_UnityTask_Action_1_UnityTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, 100680745);
		NativeMethodInfoPtr_ContinueWith_Public_UnityTask_1_NewTResult_Func_2_UnityTask_1_TResult_NewTResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, 100680746);
		NativeMethodInfoPtr_ContinueOnUIThread_Public_Void_Action_1_UnityTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTask<TResult>>.NativeClassPtr, 100680747);
	}

	public UnityTask(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
