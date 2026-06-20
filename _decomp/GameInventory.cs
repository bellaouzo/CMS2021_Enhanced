using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CI.TaskParallel;
using CMS.Containers;
using CMS.FileSupport.INI;
using CMS.Providers;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
	[ObfuscatedName("GameInventory/<DoInitAsync>d__100")]
	public sealed class _DoInitAsync_d__100 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr));

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

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _DoInitAsync_d__100(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44176, XrefRangeEnd = 44178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44178, XrefRangeEnd = 44183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _DoInitAsync_d__100()
		{
			Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<DoInitAsync>d__100");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, 100666088);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, 100666089);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, 100666090);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, 100666091);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, 100666092);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_DoInitAsync_d__100>.NativeClassPtr, 100666093);
		}

		public _DoInitAsync_d__100(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<Init>d__101")]
	public sealed class _Init_d__101 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__currentScene_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr));

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

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string _currentScene_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentScene_5__2);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentScene_5__2), IL2CPP.ManagedStringToIl2Cpp(str));
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
		public unsafe _Init_d__101(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44183, XrefRangeEnd = 44194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44194, XrefRangeEnd = 44199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Init_d__101()
		{
			Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<Init>d__101");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__currentScene_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, "<currentScene>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, 100666094);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, 100666095);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, 100666096);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, 100666097);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, 100666098);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__101>.NativeClassPtr, 100666099);
		}

		public _Init_d__101(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<>c__DisplayClass109_0")]
	public sealed class __c__DisplayClass109_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_csv;

		private static readonly System.IntPtr NativeFieldInfoPtr_faultsDataLines;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr));

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe CSVHelper csv
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_csv);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CSVHelper(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_csv), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe List<string> faultsDataLines
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faultsDataLines);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faultsDataLines), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass109_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass109_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<>c__DisplayClass109_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_csv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, "csv");
			NativeFieldInfoPtr_faultsDataLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, "faultsDataLines");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass109_0>.NativeClassPtr, 100666100);
		}

		public __c__DisplayClass109_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<>c__DisplayClass109_1")]
	public sealed class __c__DisplayClass109_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_start;

		private static readonly System.IntPtr NativeFieldInfoPtr_end;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass109_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FillPartPropertyList_b__0_Internal_Dictionary_2_String_PartProperty_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr));

		public unsafe int start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start)) = num;
			}
		}

		public unsafe int end
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end)) = num;
			}
		}

		public unsafe __c__DisplayClass109_0 field_Public___c__DisplayClass109_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass109_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new __c__DisplayClass109_0(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass109_0_0), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass109_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44199, XrefRangeEnd = 44200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, PartProperty> _FillPartPropertyList_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FillPartPropertyList_b__0_Internal_Dictionary_2_String_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, PartProperty>(intPtr) : null;
		}

		static __c__DisplayClass109_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<>c__DisplayClass109_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr);
			NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr, "start");
			NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr, "end");
			NativeFieldInfoPtr_field_Public___c__DisplayClass109_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr, 100666101);
			NativeMethodInfoPtr__FillPartPropertyList_b__0_Internal_Dictionary_2_String_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass109_1>.NativeClassPtr, 100666102);
		}

		public __c__DisplayClass109_1(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<FillPartPropertyList>d__109")]
	public sealed class _FillPartPropertyList_d__109 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__sectionsCount_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__tasks_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr));

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

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int _sectionsCount_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sectionsCount_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sectionsCount_5__2)) = num;
			}
		}

		public unsafe Il2CppReferenceArray<UnityTask<Dictionary<string, PartProperty>>> _tasks_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<UnityTask<Dictionary<string, PartProperty>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks_5__3), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _FillPartPropertyList_d__109(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44200, XrefRangeEnd = 44302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44302, XrefRangeEnd = 44307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _FillPartPropertyList_d__109()
		{
			Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<FillPartPropertyList>d__109");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__sectionsCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, "<sectionsCount>5__2");
			NativeFieldInfoPtr__tasks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, "<tasks>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, 100666103);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, 100666104);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, 100666105);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, 100666106);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, 100666107);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_FillPartPropertyList_d__109>.NativeClassPtr, 100666108);
		}

		public _FillPartPropertyList_d__109(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<>c__DisplayClass112_0")]
	public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReadTuningDataThreaded_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr));

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string fileData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileData);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileData), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass112_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44307, XrefRangeEnd = 44309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ReadTuningDataThreaded_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReadTuningDataThreaded_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass112_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<>c__DisplayClass112_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_fileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "fileData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100666109);
			NativeMethodInfoPtr__ReadTuningDataThreaded_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100666110);
		}

		public __c__DisplayClass112_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("GameInventory/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__119_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetGearboxesRatio_b__119_0_Internal_String_String_0;

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

		public unsafe static Il2CppSystem.Func<string, string> __9__119_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__119_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<string, string>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__119_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe string _GetGearboxesRatio_b__119_0(string p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetGearboxesRatio_b__119_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__119_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__119_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666112);
			NativeMethodInfoPtr__GetGearboxesRatio_b__119_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666113);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<>c__DisplayClass123_0")]
	public sealed class __c__DisplayClass123_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_tuningFileLines;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr));

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStringArray tuningFileLines
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningFileLines);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningFileLines), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass123_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass123_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<>c__DisplayClass123_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_tuningFileLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr, "tuningFileLines");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass123_0>.NativeClassPtr, 100666114);
		}

		public __c__DisplayClass123_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<>c__DisplayClass123_1")]
	public sealed class __c__DisplayClass123_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_start;

		private static readonly System.IntPtr NativeFieldInfoPtr_end;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass123_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PrepareTuningData_b__0_Internal_Dictionary_2_String_TuningPart_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr));

		public unsafe int start
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start)) = num;
			}
		}

		public unsafe int end
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end)) = num;
			}
		}

		public unsafe __c__DisplayClass123_0 field_Public___c__DisplayClass123_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass123_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new __c__DisplayClass123_0(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass123_0_0), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass123_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44309, XrefRangeEnd = 44310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, TuningPart> _PrepareTuningData_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PrepareTuningData_b__0_Internal_Dictionary_2_String_TuningPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, TuningPart>(intPtr) : null;
		}

		static __c__DisplayClass123_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<>c__DisplayClass123_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr);
			NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr, "start");
			NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr, "end");
			NativeFieldInfoPtr_field_Public___c__DisplayClass123_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr, 100666115);
			NativeMethodInfoPtr__PrepareTuningData_b__0_Internal_Dictionary_2_String_TuningPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass123_1>.NativeClassPtr, 100666116);
		}

		public __c__DisplayClass123_1(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<PrepareTuningData>d__123")]
	public sealed class _PrepareTuningData_d__123 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__sectionsCount_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__tasks_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr));

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

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int _sectionsCount_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sectionsCount_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sectionsCount_5__2)) = num;
			}
		}

		public unsafe Il2CppReferenceArray<UnityTask<Dictionary<string, TuningPart>>> _tasks_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<UnityTask<Dictionary<string, TuningPart>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tasks_5__3), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _PrepareTuningData_d__123(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44310, XrefRangeEnd = 44369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44369, XrefRangeEnd = 44374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _PrepareTuningData_d__123()
		{
			Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<PrepareTuningData>d__123");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__sectionsCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, "<sectionsCount>5__2");
			NativeFieldInfoPtr__tasks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, "<tasks>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, 100666117);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, 100666118);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, 100666119);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, 100666120);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, 100666121);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareTuningData_d__123>.NativeClassPtr, 100666122);
		}

		public _PrepareTuningData_d__123(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("GameInventory/<PrepareUnmountDirectionsData>d__126")]
	public sealed class _PrepareUnmountDirectionsData_d__126 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__unmountIni_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr));

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

		public unsafe GameInventory __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe IniData _unmountIni_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unmountIni_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unmountIni_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int _i_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__3)) = num;
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
		public unsafe _PrepareUnmountDirectionsData_d__126(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44374, XrefRangeEnd = 44421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44421, XrefRangeEnd = 44426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _PrepareUnmountDirectionsData_d__126()
		{
			Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "<PrepareUnmountDirectionsData>d__126");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__unmountIni_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, "<unmountIni>5__2");
			NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, "<i>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, 100666123);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, 100666124);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, 100666125);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, 100666126);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, 100666127);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrepareUnmountDirectionsData_d__126>.NativeClassPtr, 100666128);
		}

		public _PrepareUnmountDirectionsData_d__126(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_photoLocationsProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_customTracksProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_licensePlatesProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonSpritesProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataFileDemo;

	private static readonly System.IntPtr NativeFieldInfoPtr_partsOrderFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_partsMaxTuningData;

	private static readonly System.IntPtr NativeFieldInfoPtr_partPropertyList;

	private static readonly System.IntPtr NativeFieldInfoPtr_thumbnails;

	private static readonly System.IntPtr NativeFieldInfoPtr_noImageItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_noImageCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_noOpponentCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_threadSafeTuningDataLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_threadSafePartPropertyListLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemFaults;

	private static readonly System.IntPtr NativeFieldInfoPtr_ModdingPartsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brands;

	private static readonly System.IntPtr NativeFieldInfoPtr_enginesIni;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearboxesIni;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiresIni;

	private static readonly System.IntPtr NativeFieldInfoPtr_interiorMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningData;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_localization;

	private static readonly System.IntPtr NativeFieldInfoPtr_materials;

	private static readonly System.IntPtr NativeFieldInfoPtr_unmountDirections;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningCacheExists;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialsCacheList;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialPropertyBlock;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_GameInventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PhotoLocationsProvider_Public_get_PhotoLocationsProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CustomTracksProvider_Public_get_CustomTracksProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PartPropertyList_Private_get_IDictionary_2_String_PartProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PartPropertyList_Private_set_Void_IDictionary_2_String_PartProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Thumbnails_Private_get_IDictionary_2_String_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Thumbnails_Private_set_Void_IDictionary_2_String_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TuningDataLoaded_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TuningDataLoaded_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PartPropertyListLoaded_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PartPropertyListLoaded_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InteriorMaterials_Public_get_byref_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Materials_Public_get_IDictionary_2_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Materials_Public_set_Void_IDictionary_2_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitMaterialsDictionary_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToMaterialsDictionary_Public_Void_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBrand_Public_Sprite_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadBrands_Public_Void_List_1_SpriteContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuning_Public_Boolean_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTuningCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTuningCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToTuningCache_Private_Void_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuning_Public_Boolean_String_PartProperty_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarThumb_Public_Sprite_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThumb_Public_Sprite_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNoImageCar_Public_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetMemory_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNoImageThumbnail_Public_Void_Sprite_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNoOpponentThumbnail_Public_Void_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddThumbnails_Public_Void_Dictionary_2_String_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddThumbnail_Public_Void_String_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadThumbnails_Public_Void_Dictionary_2_String_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGO_Public_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGO2_Public_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemProperty_Public_PartProperty_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExistsInPartProperty_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemPropertyCached_Public_PartProperty_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOilDrainCheckFill_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveDLC_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBody_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanPaint_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedName_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanAddToShopList_Public_Static_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInteriorPart_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIOLocalizedName_Public_String_InteractiveObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractiveObjectID_Public_String_InteractiveObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyLocalizedName_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemLocalizeName_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCachedPartPropertyList_Public_Void_byref_List_1_PartProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomItemName_Public_String_byref_List_1_PartProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomItemForOwnedCars_Public_String_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomItem_Public_Item_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBodyItem_Public_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_List_1_PartProperty_ShopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshPartsDLC_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_List_1_PartProperty_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_List_1_String_SpecialGroup_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnginesToCreate_Public_Void_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoInit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoInitAsync_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemFault_Public_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemFaultWithRealID_Public_Boolean_String_Faults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemDifficultMod_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLocalizations_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPartPropertyListSegment_Private_Dictionary_2_String_PartProperty_CSVHelper_List_1_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillPartPropertyList_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToPartPropertyList_Public_Void_String_Int32_Int32_String_Int32_Int32_SpecialGroup_ArrayOf_Int32_Single_Boolean_String_String_String_String_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTuningData_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTuningDataThreaded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareInteriorMaterials_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareIniFiles_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTiresData_Public_IniData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEngineData_Public_Single_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEngineDataString_Public_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEngineDataBool_Public_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearboxesRatio_Public_ArrayOf_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearboxesDataFloat_Public_Single_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfItemExistInPropertyList_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningDataSegment_Private_Dictionary_2_String_TuningPart_ArrayOf_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareTuningData_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningProperty_Public_TuningPart_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGrip_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareUnmountDirectionsData_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnmountDirection_Public_UnmountDirection_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomLicensePlate_Public_LicensePlate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadLicensePlates_Public_Void_List_1_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLicensePlate_Public_Nullable_1_LicensePlate_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLicensePlateTexture_Public_Texture_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLicensePlateColor_Public_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllLicensePlates_Public_List_1_LicensePlate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLicensePlate_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonByName_Public_Sprite_String_PlaystationControllerState_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadButtons_Public_Void_List_1_SpriteContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaterialsCacheList_Public_get_List_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaterialPropertyBlock_Public_get_MaterialPropertyBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMaterialsCache_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameInventory>.NativeClassPtr));

	public unsafe static GameInventory instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GameInventory(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PhotoLocationsProvider photoLocationsProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoLocationsProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PhotoLocationsProvider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoLocationsProvider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CustomTracksProvider customTracksProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customTracksProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CustomTracksProvider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customTracksProvider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LicensePlatesProvider licensePlatesProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensePlatesProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LicensePlatesProvider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_licensePlatesProvider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ButtonSpritesProvider buttonSpritesProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonSpritesProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ButtonSpritesProvider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonSpritesProvider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextAsset dataFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataFile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextAsset dataFileDemo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataFileDemo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataFileDemo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextAsset partsOrderFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsOrderFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsOrderFile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PartsMaxTuningData partsMaxTuningData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsMaxTuningData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PartsMaxTuningData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsMaxTuningData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StringPartPropertyDictionary partPropertyList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partPropertyList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringPartPropertyDictionary(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partPropertyList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StringSpriteDictionary thumbnails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringSpriteDictionary(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnails), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite noImageItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noImageItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noImageItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite noImageCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noImageCar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noImageCar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite noOpponentCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noOpponentCar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noOpponentCar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppStringArray> tuningArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningArray), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int threadSafeTuningDataLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadSafeTuningDataLoaded);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadSafeTuningDataLoaded)) = num;
		}
	}

	public unsafe int threadSafePartPropertyListLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadSafePartPropertyListLoaded);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadSafePartPropertyListLoaded)) = num;
		}
	}

	public unsafe Dictionary<string, ItemFault> itemFaults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFaults);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, ItemFault>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFaults), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ModdingPartsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModdingPartsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModdingPartsCount)) = num;
		}
	}

	public unsafe List<SpriteContainer> Brands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brands);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SpriteContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brands), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IniData enginesIni
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enginesIni);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enginesIni), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IniData gearboxesIni
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearboxesIni);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearboxesIni), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IniData tiresIni
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresIni);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresIni), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray interiorMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorMaterials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<string, TuningPart> tuningData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, TuningPart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsReady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady)) = flag;
		}
	}

	public unsafe Localization localization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localization);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Localization(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localization), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StringMaterialDictionary materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringMaterialDictionary(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<UnmountDirection> unmountDirections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unmountDirections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<UnmountDirection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unmountDirections), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ConcurrentDictionary<string, Il2CppSystem.Tuple<string, bool>> tuningCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ConcurrentDictionary<string, Il2CppSystem.Tuple<string, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningCache), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool tuningCacheExists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningCacheExists);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningCacheExists)) = flag;
		}
	}

	public unsafe Il2CppSystem.Object syncObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Material> materialsCacheList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsCacheList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsCacheList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MaterialPropertyBlock materialPropertyBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialPropertyBlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MaterialPropertyBlock(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GameInventory Instance
	{
		[CallerCount(345)]
		[CachedScanResults(RefRangeStart = 44448, RefRangeEnd = 44793, XrefRangeStart = 44426, XrefRangeEnd = 44448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_GameInventory_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
		}
	}

	public unsafe PhotoLocationsProvider PhotoLocationsProvider
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PhotoLocationsProvider_Public_get_PhotoLocationsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new PhotoLocationsProvider(intPtr) : null;
		}
	}

	public unsafe CustomTracksProvider CustomTracksProvider
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CustomTracksProvider_Public_get_CustomTracksProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new CustomTracksProvider(intPtr) : null;
		}
	}

	public unsafe IDictionary<string, PartProperty> PartPropertyList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PartPropertyList_Private_get_IDictionary_2_String_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new IDictionary<string, PartProperty>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44793, XrefRangeEnd = 44797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PartPropertyList_Private_set_Void_IDictionary_2_String_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe IDictionary<string, Sprite> Thumbnails
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Thumbnails_Private_get_IDictionary_2_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new IDictionary<string, Sprite>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44797, XrefRangeEnd = 44801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Thumbnails_Private_set_Void_IDictionary_2_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool TuningDataLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TuningDataLoaded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TuningDataLoaded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool PartPropertyListLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PartPropertyListLoaded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PartPropertyListLoaded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ref Il2CppStringArray InteriorMaterials
	{
		[CallerCount(0)]
		get
		{
			//IL_0043->IL0048: Incompatible stack types: O vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InteriorMaterials_Public_get_byref_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return ref intPtr != (System.IntPtr)0 ? new ref Il2CppStringArray(intPtr) : ref *(Il2CppStringArray*)null;
		}
	}

	public unsafe IDictionary<string, Material> Materials
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Materials_Public_get_IDictionary_2_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new IDictionary<string, Material>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44801, XrefRangeEnd = 44805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Materials_Public_set_Void_IDictionary_2_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe List<Material> MaterialsCacheList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaterialsCacheList_Public_get_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new List<Material>(intPtr) : null;
		}
	}

	public unsafe MaterialPropertyBlock MaterialPropertyBlock
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaterialPropertyBlock_Public_get_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new MaterialPropertyBlock(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44805, XrefRangeEnd = 44814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitMaterialsDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitMaterialsDictionary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44814, XrefRangeEnd = 44819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToMaterialsDictionary(string materialName, Material material)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(materialName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(material);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToMaterialsDictionary_Public_Void_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44819, XrefRangeEnd = 44864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 44867, RefRangeEnd = 44880, XrefRangeStart = 44864, XrefRangeEnd = 44867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetBrand(string brandName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(brandName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBrand_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void ReloadBrands(List<SpriteContainer> range)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadBrands_Public_Void_List_1_SpriteContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44880, XrefRangeEnd = 44998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTuning(string id, string otherId, bool forCarLoad = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(otherId);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forCarLoad;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuning_Public_Boolean_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45004, RefRangeEnd = 45006, XrefRangeStart = 44998, XrefRangeEnd = 45004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateTuningCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTuningCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ClearTuningCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTuningCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45006, XrefRangeEnd = 45018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToTuningCache(string id, string otherId, bool isTuning)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(otherId);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTuning;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToTuningCache_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45050, RefRangeEnd = 45052, XrefRangeStart = 45018, XrefRangeEnd = 45050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTuning(string id, PartProperty otherPartProperty, string otherId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(otherPartProperty);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(otherId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuning_Public_Boolean_String_PartProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 45073, RefRangeEnd = 45084, XrefRangeStart = 45052, XrefRangeEnd = 45073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetCarThumb(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarThumb_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 45099, RefRangeEnd = 45112, XrefRangeStart = 45084, XrefRangeEnd = 45099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetThumb(string thumbName, bool carThumb = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thumbName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carThumb;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumb_Public_Sprite_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(30)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Sprite GetNoImageCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNoImageCar_Public_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45112, XrefRangeEnd = 45120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetMemory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetMemory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetNoImageThumbnail(Sprite item, Sprite car)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(car);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNoImageThumbnail_Public_Void_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(23)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetNoOpponentThumbnail(Sprite item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNoOpponentThumbnail_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45140, RefRangeEnd = 45141, XrefRangeStart = 45120, XrefRangeEnd = 45140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddThumbnails(Dictionary<string, Sprite> range)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddThumbnails_Public_Void_Dictionary_2_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45154, RefRangeEnd = 45155, XrefRangeStart = 45141, XrefRangeEnd = 45154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddThumbnail(string thumbID, Sprite sprite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thumbID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(sprite);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddThumbnail_Public_Void_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45155, XrefRangeEnd = 45171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReloadThumbnails(Dictionary<string, Sprite> range)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadThumbnails_Public_Void_Dictionary_2_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 45253, RefRangeEnd = 45262, XrefRangeStart = 45171, XrefRangeEnd = 45253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetGO(string goName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(goName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGO_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45358, RefRangeEnd = 45359, XrefRangeStart = 45262, XrefRangeEnd = 45358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetGO2(string goName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(goName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGO2_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(107)]
	[CachedScanResults(RefRangeStart = 45368, RefRangeEnd = 45475, XrefRangeStart = 45359, XrefRangeEnd = 45368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartProperty GetItemProperty(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemProperty_Public_PartProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new PartProperty(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 45477, RefRangeEnd = 45480, XrefRangeStart = 45475, XrefRangeEnd = 45477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ExistsInPartProperty(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExistsInPartProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45480, XrefRangeEnd = 45485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartProperty GetItemPropertyCached(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemPropertyCached_Public_PartProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new PartProperty(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 45493, RefRangeEnd = 45503, XrefRangeStart = 45485, XrefRangeEnd = 45493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsOilDrainCheckFill(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOilDrainCheckFill_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 45511, RefRangeEnd = 45515, XrefRangeStart = 45503, XrefRangeEnd = 45511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveDLC(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveDLC_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 45523, RefRangeEnd = 45528, XrefRangeStart = 45515, XrefRangeEnd = 45523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBody(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBody_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45536, RefRangeEnd = 45537, XrefRangeStart = 45528, XrefRangeEnd = 45536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanPaint(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanPaint_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45546, RefRangeEnd = 45547, XrefRangeStart = 45537, XrefRangeEnd = 45546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalizedName(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45615, RefRangeEnd = 45617, XrefRangeStart = 45547, XrefRangeEnd = 45615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanAddToShopList(string itemType, bool checkInterior)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkInterior;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAddToShopList_Public_Static_Boolean_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45627, RefRangeEnd = 45629, XrefRangeStart = 45617, XrefRangeEnd = 45627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInteriorPart(string itemType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInteriorPart_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45675, RefRangeEnd = 45677, XrefRangeStart = 45629, XrefRangeEnd = 45675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetIOLocalizedName(InteractiveObject iO)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(iO);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIOLocalizedName_Public_String_InteractiveObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45721, RefRangeEnd = 45723, XrefRangeStart = 45677, XrefRangeEnd = 45721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInteractiveObjectID(InteractiveObject iO)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(iO);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractiveObjectID_Public_String_InteractiveObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 45736, RefRangeEnd = 45742, XrefRangeStart = 45723, XrefRangeEnd = 45736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBodyLocalizedName(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyLocalizedName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 45748, RefRangeEnd = 45770, XrefRangeStart = 45742, XrefRangeEnd = 45748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetItemLocalizeName(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemLocalizeName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45779, RefRangeEnd = 45781, XrefRangeStart = 45770, XrefRangeEnd = 45779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateCachedPartPropertyList(out List<PartProperty> cachedPartPropertyList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedPartPropertyList);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCachedPartPropertyList_Public_Void_byref_List_1_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		cachedPartPropertyList = (List<PartProperty>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45790, RefRangeEnd = 45792, XrefRangeStart = 45781, XrefRangeEnd = 45790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRandomItemName(ref List<PartProperty> cachedValues)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedValues);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomItemName_Public_String_byref_List_1_PartProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		cachedValues = (List<PartProperty>)(object)((intPtr2 == (System.IntPtr)0) ? null : new List<T>(intPtr2));
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45832, RefRangeEnd = 45833, XrefRangeStart = 45792, XrefRangeEnd = 45832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRandomItemForOwnedCars(ref List<string> cachedList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedList);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomItemForOwnedCars_Public_String_byref_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		cachedList = (List<string>)(object)((intPtr2 == (System.IntPtr)0) ? null : new List<T>(intPtr2));
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45877, RefRangeEnd = 45879, XrefRangeStart = 45833, XrefRangeEnd = 45877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item GetRandomItem(bool forCaseOpening = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forCaseOpening);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomItem_Public_Item_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45897, RefRangeEnd = 45898, XrefRangeStart = 45879, XrefRangeEnd = 45897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item GetRandomBodyItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomBodyItem_Public_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45937, RefRangeEnd = 45939, XrefRangeStart = 45898, XrefRangeEnd = 45937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<PartProperty> GetItems(ShopType shopType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shopType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_List_1_PartProperty_ShopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartProperty>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45939, XrefRangeEnd = 45984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshPartsDLC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshPartsDLC_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 46014, RefRangeEnd = 46017, XrefRangeStart = 45984, XrefRangeEnd = 46014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<PartProperty> GetItems(string shopName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_List_1_PartProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartProperty>(intPtr) : null;
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 46053, RefRangeEnd = 46075, XrefRangeStart = 46017, XrefRangeEnd = 46053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetItems(SpecialGroup specialGroup, string additional = "#Dummy")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&specialGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(additional);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_List_1_String_SpecialGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46102, RefRangeEnd = 46103, XrefRangeStart = 46075, XrefRangeEnd = 46102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEnginesToCreate(out List<string> engines)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(engines);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnginesToCreate_Public_Void_byref_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		engines = (List<string>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46106, RefRangeEnd = 46107, XrefRangeStart = 46103, XrefRangeEnd = 46106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoInit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46107, XrefRangeEnd = 46110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DoInitAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoInitAsync_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 46113, RefRangeEnd = 46116, XrefRangeStart = 46110, XrefRangeEnd = 46113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46116, XrefRangeEnd = 46120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetItemCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46128, RefRangeEnd = 46129, XrefRangeStart = 46120, XrefRangeEnd = 46128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetItemFault(string id, int no)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &no;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemFault_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46131, RefRangeEnd = 46133, XrefRangeStart = 46129, XrefRangeEnd = 46131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetItemFaultWithRealID(string realID, Faults no)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(realID);
		*(Faults**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &no;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemFaultWithRealID_Public_Boolean_String_Faults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46141, RefRangeEnd = 46142, XrefRangeStart = 46133, XrefRangeEnd = 46141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetItemDifficultMod(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemDifficultMod_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46168, RefRangeEnd = 46169, XrefRangeStart = 46142, XrefRangeEnd = 46168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLocalizations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLocalizations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46330, RefRangeEnd = 46331, XrefRangeStart = 46169, XrefRangeEnd = 46330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, PartProperty> GetPartPropertyListSegment(CSVHelper csv, List<string> faultsData, int from, int to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(csv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(faultsData);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPartPropertyListSegment_Private_Dictionary_2_String_PartProperty_CSVHelper_List_1_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Dictionary<string, PartProperty>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46331, XrefRangeEnd = 46334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator FillPartPropertyList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillPartPropertyList_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46359, RefRangeEnd = 46361, XrefRangeStart = 46334, XrefRangeEnd = 46359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToPartPropertyList(string id, int price, int partGroup, string shopGroup, int examineGroup, int repairGroup, SpecialGroup special, Il2CppStructArray<int> dlc, float tuning, bool isBody, string localizedName, string brand, string shopName, string carID, float brakesTuning, bool isMod, bool canPaint = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &price;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &partGroup;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(shopGroup);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &examineGroup;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &repairGroup;
		*(SpecialGroup**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &special;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(dlc);
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuning;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBody;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(localizedName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(brand);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(shopName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(float**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &brakesTuning;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &isMod;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &canPaint;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToPartPropertyList_Public_Void_String_Int32_Int32_String_Int32_Int32_SpecialGroup_ArrayOf_Int32_Single_Boolean_String_String_String_String_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46391, RefRangeEnd = 46392, XrefRangeStart = 46361, XrefRangeEnd = 46391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadTuningData(string fileData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTuningData_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46392, XrefRangeEnd = 46413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadTuningDataThreaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTuningDataThreaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46413, XrefRangeEnd = 46433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareInteriorMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareInteriorMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46433, XrefRangeEnd = 46449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareIniFiles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareIniFiles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe IniData GetTiresData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTiresData_Public_IniData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46449, XrefRangeEnd = 46451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetEngineData(string engine, string key, [Optional] float defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engine);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEngineData_Public_Single_String_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 46456, RefRangeEnd = 46463, XrefRangeStart = 46451, XrefRangeEnd = 46456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetEngineDataString(string engine, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engine);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEngineDataString_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46463, XrefRangeEnd = 46464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetEngineDataBool(string engine, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engine);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEngineDataBool_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 46509, RefRangeEnd = 46518, XrefRangeStart = 46464, XrefRangeEnd = 46509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> GetGearboxesRatio(string gearbox)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gearbox);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearboxesRatio_Public_ArrayOf_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 46521, RefRangeEnd = 46524, XrefRangeStart = 46518, XrefRangeEnd = 46521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGearboxesDataFloat(string gearbox, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gearbox);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearboxesDataFloat_Public_Single_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 46551, RefRangeEnd = 46554, XrefRangeStart = 46524, XrefRangeEnd = 46551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIfItemExistInPropertyList(string partName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfItemExistInPropertyList_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46594, RefRangeEnd = 46595, XrefRangeStart = 46554, XrefRangeEnd = 46594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, TuningPart> GetTuningDataSegment(Il2CppStringArray lines, int from, int to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(lines);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningDataSegment_Private_Dictionary_2_String_TuningPart_ArrayOf_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Dictionary<string, TuningPart>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46595, XrefRangeEnd = 46598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PrepareTuningData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareTuningData_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 46604, RefRangeEnd = 46612, XrefRangeStart = 46598, XrefRangeEnd = 46604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TuningPart GetTuningProperty(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningProperty_Public_TuningPart_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new TuningPart(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 46618, RefRangeEnd = 46634, XrefRangeStart = 46612, XrefRangeEnd = 46618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGrip(string gameObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGrip_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46634, XrefRangeEnd = 46637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PrepareUnmountDirectionsData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareUnmountDirectionsData_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46640, RefRangeEnd = 46641, XrefRangeStart = 46637, XrefRangeEnd = 46640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnmountDirection GetUnmountDirection(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnmountDirection_Public_UnmountDirection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new UnmountDirection(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 46645, RefRangeEnd = 46649, XrefRangeStart = 46641, XrefRangeEnd = 46645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LicensePlate GetRandomLicensePlate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomLicensePlate_Public_LicensePlate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new LicensePlate(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46649, XrefRangeEnd = 46651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReloadLicensePlates(List<Texture> range)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadLicensePlates_Public_Void_List_1_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46651, XrefRangeEnd = 46652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<LicensePlate> GetLicensePlate(string licensePlateName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLicensePlate_Public_Nullable_1_LicensePlate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new Il2CppSystem.Nullable<LicensePlate>(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46652, XrefRangeEnd = 46654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetLicensePlateTexture(string licensePlateName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLicensePlateTexture_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46654, XrefRangeEnd = 46655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetLicensePlateColor(string licensePlateName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLicensePlateColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe List<LicensePlate> GetAllLicensePlates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllLicensePlates_Public_List_1_LicensePlate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<LicensePlate>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46655, XrefRangeEnd = 46656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLicensePlate(string licensePlateName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(licensePlateName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLicensePlate_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46656, XrefRangeEnd = 46658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetButtonByName(string buttonName, PlaystationControllerState playstationControllerState, bool isControllerUsed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		*(PlaystationControllerState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playstationControllerState;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isControllerUsed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonByName_Public_Sprite_String_PlaystationControllerState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46658, XrefRangeEnd = 46660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReloadButtons(List<SpriteContainer> range, int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadButtons_Public_Void_List_1_SpriteContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46660, XrefRangeEnd = 46671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMaterialsCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMaterialsCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46671, XrefRangeEnd = 46688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameInventory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInventory>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameInventory()
	{
		Il2CppClassPointerStore<GameInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GameInventory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInventory>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_photoLocationsProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "photoLocationsProvider");
		NativeFieldInfoPtr_customTracksProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "customTracksProvider");
		NativeFieldInfoPtr_licensePlatesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "licensePlatesProvider");
		NativeFieldInfoPtr_buttonSpritesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "buttonSpritesProvider");
		NativeFieldInfoPtr_dataFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "dataFile");
		NativeFieldInfoPtr_dataFileDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "dataFileDemo");
		NativeFieldInfoPtr_partsOrderFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "partsOrderFile");
		NativeFieldInfoPtr_partsMaxTuningData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "partsMaxTuningData");
		NativeFieldInfoPtr_partPropertyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "partPropertyList");
		NativeFieldInfoPtr_thumbnails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "thumbnails");
		NativeFieldInfoPtr_noImageItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "noImageItem");
		NativeFieldInfoPtr_noImageCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "noImageCar");
		NativeFieldInfoPtr_noOpponentCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "noOpponentCar");
		NativeFieldInfoPtr_tuningArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "tuningArray");
		NativeFieldInfoPtr_threadSafeTuningDataLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "threadSafeTuningDataLoaded");
		NativeFieldInfoPtr_threadSafePartPropertyListLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "threadSafePartPropertyListLoaded");
		NativeFieldInfoPtr_itemFaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "itemFaults");
		NativeFieldInfoPtr_ModdingPartsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "ModdingPartsCount");
		NativeFieldInfoPtr_Brands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "Brands");
		NativeFieldInfoPtr_enginesIni = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "enginesIni");
		NativeFieldInfoPtr_gearboxesIni = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "gearboxesIni");
		NativeFieldInfoPtr_tiresIni = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "tiresIni");
		NativeFieldInfoPtr_interiorMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "interiorMaterials");
		NativeFieldInfoPtr_tuningData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "tuningData");
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "IsReady");
		NativeFieldInfoPtr_localization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "localization");
		NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "materials");
		NativeFieldInfoPtr_unmountDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "unmountDirections");
		NativeFieldInfoPtr_tuningCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "tuningCache");
		NativeFieldInfoPtr_tuningCacheExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "tuningCacheExists");
		NativeFieldInfoPtr_syncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "syncObject");
		NativeFieldInfoPtr_materialsCacheList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "materialsCacheList");
		NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, "materialPropertyBlock");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_GameInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665988);
		NativeMethodInfoPtr_get_PhotoLocationsProvider_Public_get_PhotoLocationsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665989);
		NativeMethodInfoPtr_get_CustomTracksProvider_Public_get_CustomTracksProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665990);
		NativeMethodInfoPtr_get_PartPropertyList_Private_get_IDictionary_2_String_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665991);
		NativeMethodInfoPtr_set_PartPropertyList_Private_set_Void_IDictionary_2_String_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665992);
		NativeMethodInfoPtr_get_Thumbnails_Private_get_IDictionary_2_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665993);
		NativeMethodInfoPtr_set_Thumbnails_Private_set_Void_IDictionary_2_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665994);
		NativeMethodInfoPtr_get_TuningDataLoaded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665995);
		NativeMethodInfoPtr_set_TuningDataLoaded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665996);
		NativeMethodInfoPtr_get_PartPropertyListLoaded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665997);
		NativeMethodInfoPtr_set_PartPropertyListLoaded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665998);
		NativeMethodInfoPtr_get_InteriorMaterials_Public_get_byref_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100665999);
		NativeMethodInfoPtr_get_Materials_Public_get_IDictionary_2_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666000);
		NativeMethodInfoPtr_set_Materials_Public_set_Void_IDictionary_2_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666001);
		NativeMethodInfoPtr_InitMaterialsDictionary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666002);
		NativeMethodInfoPtr_AddToMaterialsDictionary_Public_Void_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666003);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666004);
		NativeMethodInfoPtr_GetBrand_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666005);
		NativeMethodInfoPtr_ReloadBrands_Public_Void_List_1_SpriteContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666006);
		NativeMethodInfoPtr_IsTuning_Public_Boolean_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666007);
		NativeMethodInfoPtr_CreateTuningCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666008);
		NativeMethodInfoPtr_ClearTuningCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666009);
		NativeMethodInfoPtr_AddToTuningCache_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666010);
		NativeMethodInfoPtr_IsTuning_Public_Boolean_String_PartProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666011);
		NativeMethodInfoPtr_GetCarThumb_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666012);
		NativeMethodInfoPtr_GetThumb_Public_Sprite_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666013);
		NativeMethodInfoPtr_GetNoImageCar_Public_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666014);
		NativeMethodInfoPtr_ResetMemory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666015);
		NativeMethodInfoPtr_SetNoImageThumbnail_Public_Void_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666016);
		NativeMethodInfoPtr_SetNoOpponentThumbnail_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666017);
		NativeMethodInfoPtr_AddThumbnails_Public_Void_Dictionary_2_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666018);
		NativeMethodInfoPtr_AddThumbnail_Public_Void_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666019);
		NativeMethodInfoPtr_ReloadThumbnails_Public_Void_Dictionary_2_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666020);
		NativeMethodInfoPtr_GetGO_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666021);
		NativeMethodInfoPtr_GetGO2_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666022);
		NativeMethodInfoPtr_GetItemProperty_Public_PartProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666023);
		NativeMethodInfoPtr_ExistsInPartProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666024);
		NativeMethodInfoPtr_GetItemPropertyCached_Public_PartProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666025);
		NativeMethodInfoPtr_IsOilDrainCheckFill_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666026);
		NativeMethodInfoPtr_HaveDLC_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666027);
		NativeMethodInfoPtr_IsBody_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666028);
		NativeMethodInfoPtr_CanPaint_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666029);
		NativeMethodInfoPtr_GetLocalizedName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666030);
		NativeMethodInfoPtr_CanAddToShopList_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666031);
		NativeMethodInfoPtr_IsInteriorPart_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666032);
		NativeMethodInfoPtr_GetIOLocalizedName_Public_String_InteractiveObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666033);
		NativeMethodInfoPtr_GetInteractiveObjectID_Public_String_InteractiveObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666034);
		NativeMethodInfoPtr_GetBodyLocalizedName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666035);
		NativeMethodInfoPtr_GetItemLocalizeName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666036);
		NativeMethodInfoPtr_CreateCachedPartPropertyList_Public_Void_byref_List_1_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666037);
		NativeMethodInfoPtr_GetRandomItemName_Public_String_byref_List_1_PartProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666038);
		NativeMethodInfoPtr_GetRandomItemForOwnedCars_Public_String_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666039);
		NativeMethodInfoPtr_GetRandomItem_Public_Item_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666040);
		NativeMethodInfoPtr_GetRandomBodyItem_Public_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666041);
		NativeMethodInfoPtr_GetItems_Public_List_1_PartProperty_ShopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666042);
		NativeMethodInfoPtr_RefreshPartsDLC_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666043);
		NativeMethodInfoPtr_GetItems_Public_List_1_PartProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666044);
		NativeMethodInfoPtr_GetItems_Public_List_1_String_SpecialGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666045);
		NativeMethodInfoPtr_GetEnginesToCreate_Public_Void_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666046);
		NativeMethodInfoPtr_DoInit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666047);
		NativeMethodInfoPtr_DoInitAsync_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666048);
		NativeMethodInfoPtr_Init_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666049);
		NativeMethodInfoPtr_GetItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666050);
		NativeMethodInfoPtr_GetItemFault_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666051);
		NativeMethodInfoPtr_GetItemFaultWithRealID_Public_Boolean_String_Faults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666052);
		NativeMethodInfoPtr_GetItemDifficultMod_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666053);
		NativeMethodInfoPtr_UpdateLocalizations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666054);
		NativeMethodInfoPtr_GetPartPropertyListSegment_Private_Dictionary_2_String_PartProperty_CSVHelper_List_1_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666055);
		NativeMethodInfoPtr_FillPartPropertyList_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666056);
		NativeMethodInfoPtr_AddToPartPropertyList_Public_Void_String_Int32_Int32_String_Int32_Int32_SpecialGroup_ArrayOf_Int32_Single_Boolean_String_String_String_String_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666057);
		NativeMethodInfoPtr_ReadTuningData_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666058);
		NativeMethodInfoPtr_ReadTuningDataThreaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666059);
		NativeMethodInfoPtr_PrepareInteriorMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666060);
		NativeMethodInfoPtr_PrepareIniFiles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666061);
		NativeMethodInfoPtr_GetTiresData_Public_IniData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666062);
		NativeMethodInfoPtr_GetEngineData_Public_Single_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666063);
		NativeMethodInfoPtr_GetEngineDataString_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666064);
		NativeMethodInfoPtr_GetEngineDataBool_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666065);
		NativeMethodInfoPtr_GetGearboxesRatio_Public_ArrayOf_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666066);
		NativeMethodInfoPtr_GetGearboxesDataFloat_Public_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666067);
		NativeMethodInfoPtr_CheckIfItemExistInPropertyList_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666068);
		NativeMethodInfoPtr_GetTuningDataSegment_Private_Dictionary_2_String_TuningPart_ArrayOf_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666069);
		NativeMethodInfoPtr_PrepareTuningData_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666070);
		NativeMethodInfoPtr_GetTuningProperty_Public_TuningPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666071);
		NativeMethodInfoPtr_GetGrip_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666072);
		NativeMethodInfoPtr_PrepareUnmountDirectionsData_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666073);
		NativeMethodInfoPtr_GetUnmountDirection_Public_UnmountDirection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666074);
		NativeMethodInfoPtr_GetRandomLicensePlate_Public_LicensePlate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666075);
		NativeMethodInfoPtr_ReloadLicensePlates_Public_Void_List_1_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666076);
		NativeMethodInfoPtr_GetLicensePlate_Public_Nullable_1_LicensePlate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666077);
		NativeMethodInfoPtr_GetLicensePlateTexture_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666078);
		NativeMethodInfoPtr_GetLicensePlateColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666079);
		NativeMethodInfoPtr_GetAllLicensePlates_Public_List_1_LicensePlate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666080);
		NativeMethodInfoPtr_IsLicensePlate_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666081);
		NativeMethodInfoPtr_GetButtonByName_Public_Sprite_String_PlaystationControllerState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666082);
		NativeMethodInfoPtr_ReloadButtons_Public_Void_List_1_SpriteContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666083);
		NativeMethodInfoPtr_get_MaterialsCacheList_Public_get_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666084);
		NativeMethodInfoPtr_get_MaterialPropertyBlock_Public_get_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666085);
		NativeMethodInfoPtr_InitializeMaterialsCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666086);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInventory>.NativeClassPtr, 100666087);
	}

	public GameInventory(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
