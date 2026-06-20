using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Managers;

[System.Serializable]
public class LiveriesManager : Il2CppSystem.Object
{
	[ObfuscatedName("CMS.Managers.LiveriesManager/<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carId;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePathToTuning;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PrepareForEditor_b__0_Internal_Boolean_Livery_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PrepareForEditor_b__1_Internal_Boolean_Livery_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr));

		public unsafe string carId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carId);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carId), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string filePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string filePathToTuning
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePathToTuning);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePathToTuning), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _PrepareForEditor_b__0(Livery element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PrepareForEditor_b__0_Internal_Boolean_Livery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _PrepareForEditor_b__1(Livery element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PrepareForEditor_b__1_Internal_Boolean_Livery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr);
			NativeFieldInfoPtr_carId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "carId");
			NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "filePath");
			NativeFieldInfoPtr_filePathToTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "filePathToTuning");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100672817);
			NativeMethodInfoPtr__PrepareForEditor_b__0_Internal_Boolean_Livery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100672818);
			NativeMethodInfoPtr__PrepareForEditor_b__1_Internal_Boolean_Livery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100672819);
		}

		public __c__DisplayClass3_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Managers.LiveriesManager/<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carId;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePathToTuning;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Prepare_b__1_Internal_Boolean_Livery_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Prepare_b__2_Internal_Boolean_Livery_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr));

		public unsafe string carId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carId);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carId), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string filePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string filePathToTuning
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePathToTuning);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePathToTuning), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _Prepare_b__1(Livery element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Prepare_b__1_Internal_Boolean_Livery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _Prepare_b__2(Livery element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Prepare_b__2_Internal_Boolean_Livery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
			NativeFieldInfoPtr_carId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "carId");
			NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "filePath");
			NativeFieldInfoPtr_filePathToTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "filePathToTuning");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100672820);
			NativeMethodInfoPtr__Prepare_b__1_Internal_Boolean_Livery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100672821);
			NativeMethodInfoPtr__Prepare_b__2_Internal_Boolean_Livery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100672822);
		}

		public __c__DisplayClass4_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Managers.LiveriesManager/<Prepare>d__4")]
	public sealed class _Prepare_d__4 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__pathToFilesFromWorkshop_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__index_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr));

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

		public unsafe LiveriesManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new LiveriesManager(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe List<string> _pathToFilesFromWorkshop_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pathToFilesFromWorkshop_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pathToFilesFromWorkshop_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int _index_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index_5__3)) = num;
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
		public unsafe _Prepare_d__4(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140829, XrefRangeEnd = 140883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140883, XrefRangeEnd = 140888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Prepare_d__4()
		{
			Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, "<Prepare>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__pathToFilesFromWorkshop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, "<pathToFilesFromWorkshop>5__2");
			NativeFieldInfoPtr__index_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, "<index>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, 100672823);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, 100672824);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, 100672825);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, 100672826);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, 100672827);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Prepare_d__4>.NativeClassPtr, 100672828);
		}

		public _Prepare_d__4(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Managers.LiveriesManager/<>c__DisplayClass11_0")]
	public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetLiveriesForCar_b__0_Internal_Boolean_Livery_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr));

		public unsafe string carName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName), IL2CPP.ManagedStringToIl2Cpp(str));
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

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140888, XrefRangeEnd = 140895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetLiveriesForCar_b__0(Livery x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetLiveriesForCar_b__0_Internal_Boolean_Livery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass11_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, "<>c__DisplayClass11_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr);
			NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, "carName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100672829);
			NativeMethodInfoPtr__GetLiveriesForCar_b__0_Internal_Boolean_Livery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass11_0>.NativeClassPtr, 100672830);
		}

		public __c__DisplayClass11_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_liveries;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTexture_Private_Texture_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForEditor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLivery_Public_Texture_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLivery_Public_Boolean_String_String_byref_Texture_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLivery_Public_Void_String_String_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLiveryForPart_Public_Void_byref_List_1_CarLoader_byref_String_byref_Guid_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllUnusedLiveries_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanRemoveLivery_Private_Boolean_byref_List_1_CarLoader_byref_Int32_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLiveriesForCar_Public_List_1_Livery_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLiveriesForCar_Public_Int32_String_byref_List_1_Livery_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLiveryByName_Public_Livery_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadedLiveriesCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLiveriesMemoryUsage_Public_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Prepare_b__4_0_Private_Void_String_ParallelLoopState_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr));

	public unsafe List<Livery> liveries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Livery>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveries), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140895, XrefRangeEnd = 140915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture LoadTexture(string filePath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTexture_Private_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141063, RefRangeEnd = 141064, XrefRangeStart = 140915, XrefRangeEnd = 141063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForEditor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForEditor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 141067, RefRangeEnd = 141069, XrefRangeStart = 141064, XrefRangeEnd = 141067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141073, RefRangeEnd = 141074, XrefRangeStart = 141069, XrefRangeEnd = 141073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetLivery(string carName, string liveryName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLivery_Public_Texture_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141074, XrefRangeEnd = 141093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetLivery(string carName, string liveryName, out Texture loadedLivery, out string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(loadedLivery);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr**)num2 = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLivery_Public_Boolean_String_String_byref_Texture_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		loadedLivery = ((intPtr2 == (System.IntPtr)0) ? null : new Texture(intPtr2));
		path = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141093, XrefRangeEnd = 141096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLivery(string carName, string liveryName, Texture texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(texture);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLivery_Public_Void_String_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141169, RefRangeEnd = 141170, XrefRangeStart = 141096, XrefRangeEnd = 141169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveLiveryForPart(ref List<CarLoader> cars, ref string carID, ref Il2CppSystem.Guid guid, ref string liveryName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr**)num = &il2CppString;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref guid);
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString2 = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		*(System.IntPtr**)num2 = &il2CppString2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveLiveryForPart_Public_Void_byref_List_1_CarLoader_byref_String_byref_Guid_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		cars = (List<CarLoader>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
		carID = IL2CPP.Il2CppStringToManaged(il2CppString);
		liveryName = IL2CPP.Il2CppStringToManaged(il2CppString2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 141199, RefRangeEnd = 141201, XrefRangeStart = 141170, XrefRangeEnd = 141199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllUnusedLiveries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllUnusedLiveries_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141227, RefRangeEnd = 141228, XrefRangeStart = 141201, XrefRangeEnd = 141227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanRemoveLivery(ref List<CarLoader> cars, ref int carsCount, ref string liveryName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref carsCount);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		*(System.IntPtr**)num = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanRemoveLivery_Private_Boolean_byref_List_1_CarLoader_byref_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		cars = (List<CarLoader>)(object)((intPtr2 == (System.IntPtr)0) ? null : new List<T>(intPtr2));
		liveryName = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141244, RefRangeEnd = 141245, XrefRangeStart = 141228, XrefRangeEnd = 141244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Livery> GetLiveriesForCar(string carName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLiveriesForCar_Public_List_1_Livery_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<Livery>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 141265, RefRangeEnd = 141268, XrefRangeStart = 141245, XrefRangeEnd = 141265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLiveriesForCar(string carName, out List<Livery> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(result);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLiveriesForCar_Public_Int32_String_byref_List_1_Livery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		result = (List<Livery>)(object)((intPtr2 == (System.IntPtr)0) ? null : new List<T>(intPtr2));
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141279, RefRangeEnd = 141280, XrefRangeStart = 141268, XrefRangeEnd = 141279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Livery GetLiveryByName(string carID, string liveryName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLiveryByName_Public_Livery_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Livery(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141280, XrefRangeEnd = 141297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLoadedLiveriesCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoadedLiveriesCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141316, RefRangeEnd = 141317, XrefRangeStart = 141297, XrefRangeEnd = 141316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetLiveriesMemoryUsage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLiveriesMemoryUsage_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141317, XrefRangeEnd = 141323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LiveriesManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141323, XrefRangeEnd = 141366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Prepare_b__4_0(string directory, ParallelLoopState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Prepare_b__4_0_Private_Void_String_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LiveriesManager()
	{
		Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Managers", "LiveriesManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr);
		NativeFieldInfoPtr_liveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, "liveries");
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, "IsReady");
		NativeMethodInfoPtr_LoadTexture_Private_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672801);
		NativeMethodInfoPtr_PrepareForEditor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672802);
		NativeMethodInfoPtr_Prepare_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672803);
		NativeMethodInfoPtr_GetLivery_Public_Texture_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672804);
		NativeMethodInfoPtr_GetLivery_Public_Boolean_String_String_byref_Texture_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672805);
		NativeMethodInfoPtr_SetLivery_Public_Void_String_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672806);
		NativeMethodInfoPtr_RemoveLiveryForPart_Public_Void_byref_List_1_CarLoader_byref_String_byref_Guid_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672807);
		NativeMethodInfoPtr_RemoveAllUnusedLiveries_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672808);
		NativeMethodInfoPtr_CanRemoveLivery_Private_Boolean_byref_List_1_CarLoader_byref_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672809);
		NativeMethodInfoPtr_GetLiveriesForCar_Public_List_1_Livery_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672810);
		NativeMethodInfoPtr_GetLiveriesForCar_Public_Int32_String_byref_List_1_Livery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672811);
		NativeMethodInfoPtr_GetLiveryByName_Public_Livery_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672812);
		NativeMethodInfoPtr_GetLoadedLiveriesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672813);
		NativeMethodInfoPtr_GetLiveriesMemoryUsage_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672814);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672815);
		NativeMethodInfoPtr__Prepare_b__4_0_Private_Void_String_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesManager>.NativeClassPtr, 100672816);
	}

	public LiveriesManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
