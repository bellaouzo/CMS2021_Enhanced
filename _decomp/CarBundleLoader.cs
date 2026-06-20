using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.Tracks.Dragstrip;
using INI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarBundleLoader : MonoBehaviour
{
	[ObfuscatedName("CarBundleLoader/<Init>d__2")]
	public sealed class _Init_d__2 : Il2CppSystem.Object
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
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr));

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

		public unsafe CarBundleLoader __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarBundleLoader(intPtr) : null;
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
		public unsafe _Init_d__2(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19757, XrefRangeEnd = 19776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19776, XrefRangeEnd = 19781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Init_d__2()
		{
			Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<Init>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, 100664813);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, 100664814);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, 100664815);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, 100664816);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, 100664817);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__2>.NativeClassPtr, 100664818);
		}

		public _Init_d__2(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass14_0")]
	public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetCarVersionWindowEntries_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr));

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
		public unsafe __c__DisplayClass14_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _GetCarVersionWindowEntries_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetCarVersionWindowEntries_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass14_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass14_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr);
			NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, "carName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100664819);
			NativeMethodInfoPtr__GetCarVersionWindowEntries_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass14_0>.NativeClassPtr, 100664820);
		}

		public __c__DisplayClass14_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass26_0")]
	public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CheckConfigWithUIdExists_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr));

		public unsafe string carID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carID), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass26_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _CheckConfigWithUIdExists_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckConfigWithUIdExists_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass26_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass26_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr);
			NativeFieldInfoPtr_carID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, "carID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100664821);
			NativeMethodInfoPtr__CheckConfigWithUIdExists_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100664822);
		}

		public __c__DisplayClass26_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass36_0")]
	public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_paths;

		private static readonly System.IntPtr NativeFieldInfoPtr_pattern;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_amountOfModCars;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadAllAssetBundlesNames_b__0_Internal_Void_Int32_ParallelLoopState_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr));

		public unsafe Il2CppStringArray paths
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paths);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paths), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string pattern
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pattern);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pattern), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe CarBundleLoader __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarBundleLoader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int amountOfModCars
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountOfModCars);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountOfModCars)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass36_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19781, XrefRangeEnd = 19864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LoadAllAssetBundlesNames_b__0(int i, ParallelLoopState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadAllAssetBundlesNames_b__0_Internal_Void_Int32_ParallelLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass36_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass36_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr);
			NativeFieldInfoPtr_paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, "paths");
			NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, "pattern");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_amountOfModCars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, "amountOfModCars");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, 100664823);
			NativeMethodInfoPtr__LoadAllAssetBundlesNames_b__0_Internal_Void_Int32_ParallelLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass36_0>.NativeClassPtr, 100664824);
		}

		public __c__DisplayClass36_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("CarBundleLoader/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__36_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadAllAssetBundlesNames_b__36_1_Internal_String_CarConfigData_0;

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

		public unsafe static Il2CppSystem.Func<CarConfigData, string> __9__36_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__36_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<CarConfigData, string>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__36_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe string _LoadAllAssetBundlesNames_b__36_1(CarConfigData car)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(car);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadAllAssetBundlesNames_b__36_1_Internal_String_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__36_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664826);
			NativeMethodInfoPtr__LoadAllAssetBundlesNames_b__36_1_Internal_String_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664827);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass40_0")]
	public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleCarName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetCarFromAssetBundle_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr));

		public unsafe string AssetBundleCarName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleCarName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleCarName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass40_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19864, XrefRangeEnd = 19868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetCarFromAssetBundle_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetCarFromAssetBundle_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass40_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass40_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr);
			NativeFieldInfoPtr_AssetBundleCarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr, "AssetBundleCarName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr, 100664828);
			NativeMethodInfoPtr__GetCarFromAssetBundle_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass40_0>.NativeClassPtr, 100664829);
		}

		public __c__DisplayClass40_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<GetCarFromAssetBundle>d__40")]
	public sealed class _GetCarFromAssetBundle_d__40 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleCarName;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_modelName;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__abr_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr));

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

		public unsafe string AssetBundleCarName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleCarName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleCarName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe CarBundleLoader __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarBundleLoader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string modelName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe __c__DisplayClass40_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new __c__DisplayClass40_0(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe AssetBundleRequest _abr_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__abr_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AssetBundleRequest(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__abr_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _GetCarFromAssetBundle_d__40(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19868, XrefRangeEnd = 19919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19919, XrefRangeEnd = 19924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _GetCarFromAssetBundle_d__40()
		{
			Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<GetCarFromAssetBundle>d__40");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_AssetBundleCarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "AssetBundleCarName");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_modelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "modelName");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__abr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, "<abr>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, 100664830);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, 100664831);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, 100664832);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, 100664833);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, 100664834);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetCarFromAssetBundle_d__40>.NativeClassPtr, 100664835);
		}

		public _GetCarFromAssetBundle_d__40(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass41_0")]
	public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BodyPart_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr));

		public unsafe string AssetBundleName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName), IL2CPP.ManagedStringToIl2Cpp(str));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19924, XrefRangeEnd = 19938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BodyPart_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BodyPart_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass41_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass41_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr);
			NativeFieldInfoPtr_AssetBundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, "AssetBundleName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100664836);
			NativeMethodInfoPtr__BodyPart_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass41_0>.NativeClassPtr, 100664837);
		}

		public __c__DisplayClass41_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass42_0")]
	public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetFromBundle_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr));

		public unsafe string AssetBundleName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass42_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19938, XrefRangeEnd = 19952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetFromBundle_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetFromBundle_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass42_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass42_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr);
			NativeFieldInfoPtr_AssetBundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr, "AssetBundleName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr, 100664838);
			NativeMethodInfoPtr__GetFromBundle_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass42_0>.NativeClassPtr, 100664839);
		}

		public __c__DisplayClass42_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass43_0")]
	public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetListOfPartsNames_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr));

		public unsafe string AssetBundleName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass43_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19952, XrefRangeEnd = 19966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetListOfPartsNames_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetListOfPartsNames_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass43_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass43_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr);
			NativeFieldInfoPtr_AssetBundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, "AssetBundleName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, 100664840);
			NativeMethodInfoPtr__GetListOfPartsNames_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass43_0>.NativeClassPtr, 100664841);
		}

		public __c__DisplayClass43_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass44_0")]
	public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetListOfTuningPartsNames_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr));

		public unsafe string AssetBundleName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass44_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19966, XrefRangeEnd = 19980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetListOfTuningPartsNames_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetListOfTuningPartsNames_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass44_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass44_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr);
			NativeFieldInfoPtr_AssetBundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, "AssetBundleName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, 100664842);
			NativeMethodInfoPtr__GetListOfTuningPartsNames_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass44_0>.NativeClassPtr, 100664843);
		}

		public __c__DisplayClass44_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass45_0")]
	public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundleName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetTuningParts_b__0_Internal_Boolean_CarConfigData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr));

		public unsafe string AssetBundleName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundleName), IL2CPP.ManagedStringToIl2Cpp(str));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19980, XrefRangeEnd = 19994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetTuningParts_b__0(CarConfigData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetTuningParts_b__0_Internal_Boolean_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass45_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass45_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr);
			NativeFieldInfoPtr_AssetBundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, "AssetBundleName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, 100664844);
			NativeMethodInfoPtr__GetTuningParts_b__0_Internal_Boolean_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass45_0>.NativeClassPtr, 100664845);
		}

		public __c__DisplayClass45_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CarBundleLoader/<>c__DisplayClass58_0")]
	public sealed class __c__DisplayClass58_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ini;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr));

		public unsafe INIUnity ini
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ini);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new INIUnity(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ini), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		static __c__DisplayClass58_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "<>c__DisplayClass58_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr);
			NativeFieldInfoPtr_ini = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, "ini");
		}

		public __c__DisplayClass58_0(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe __c__DisplayClass58_0()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CarNamesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarNames_Public_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarConfigData_Public_CarConfigData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarConfigData_Private_INIUnity_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarNames_Public_List_1_CarConfigData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsModCar_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarNamesWithCheckDLC_Public_List_1_CarConfigData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckHaveDLCForCar_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigCounts_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarExists_Public_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarNameWithSuffix_Public_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarVersionWindowEntries_Public_ArrayOf_CarVersionWindowEntry_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarVersionsForDrag_Public_ArrayOf_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForDrag_Public_Void_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForLevel_Public_List_1_CarsIdWithConfig_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForScene_Public_List_1_CarsIdWithConfig_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForDLC_Public_List_1_CarsIdWithConfig_Int32_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForDLC_Public_List_1_CarsIdWithConfig_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsConfigDataForSalon_Public_List_1_SalonCarConfigData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllCarsForDragstrip_Public_List_1_BasicCarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsBetweenPowerIndex_Public_Void_List_1_BasicCarForDragstrip_List_1_DragstripRandomOpponentBasicData_Single_byref_Single_byref_Single_byref_CarForDragstrip_byref_CarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForDragstripPlayer_Public_List_1_CarForDragstrip_List_1_BasicCarForDragstrip_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomCarName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConfigWithUIdExists_Public_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarPropertyV2_Public_Vector2_String_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarPropertyInt_Public_Int32_String_Int32_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarPropertyFloat_Public_Single_String_Int32_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarPropertyString_Public_String_String_Int32_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarBodyPropertyString_Public_String_String_Int32_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadThumbnails_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadModdingPartsToShop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssetBundlesNames_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssetBundlesNamesFromWorkshop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssetBundlesNames_Private_Void_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllAssetBundlesDecrypted_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPathForTextFile_Public_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBundleDirectory_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarFromAssetBundle_Public_IEnumerator_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BodyPart_Public_Object_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFromBundle_Public_Object_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListOfPartsNames_Public_List_1_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetListOfTuningPartsNames_Public_List_1_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningParts_Public_List_1_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapMaterials_Public_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarFileInfo_Public_CarFileType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTextFile_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindCarConfig_Public_CarConfigData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarConfigExists_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAvailableCars_Public_List_1_CarsIdWithConfig_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarIsAvailableOnLevel_Private_Boolean_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarIsAvailableOnScene_Private_Boolean_String_Int32_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConfigs_Public_Void_PartsMaxTuningData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConfigData_Private_Void_CarConfigData_PartsMaxTuningData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConfig_Private_Void_INIUnity_PartsMaxTuningData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePerformanceIndexStock_Private_Boolean_INIUnity_String_Single_Single_Single_Single_Single_String_ArrayOf_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePerformanceIndexForTires_Private_Void_INIUnity_String_Single_Single_Single_Single_Single_String_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaxTuning_Private_Static_ValueTuple_2_Single_Single_INIUnity_String_PartsMaxTuningData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTires_Private_Static_Void_INIUnity_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_String_byref___c__DisplayClass58_0_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr));

	public unsafe List<CarConfigData> CarNamesData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarNamesData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<CarConfigData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarNamesData), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19997, RefRangeEnd = 19999, XrefRangeStart = 19994, XrefRangeEnd = 19997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19999, XrefRangeEnd = 20000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CarCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20000, XrefRangeEnd = 20010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetCarNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarNames_Public_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 20013, RefRangeEnd = 20027, XrefRangeStart = 20010, XrefRangeEnd = 20013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarConfigData GetCarConfigData(string carId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarConfigData_Public_CarConfigData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarConfigData(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20032, RefRangeEnd = 20034, XrefRangeStart = 20027, XrefRangeEnd = 20032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe INIUnity GetCarConfigData(string carID, int config)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarConfigData_Private_INIUnity_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new INIUnity(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe List<CarConfigData> CarNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarNames_Public_List_1_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarConfigData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 20037, XrefRangeStart = 20034, XrefRangeEnd = 20036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsModCar(string carName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsModCar_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 20105, RefRangeEnd = 20108, XrefRangeStart = 20037, XrefRangeEnd = 20105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarConfigData> CarNamesWithCheckDLC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarNamesWithCheckDLC_Public_List_1_CarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarConfigData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20119, RefRangeEnd = 20121, XrefRangeStart = 20108, XrefRangeEnd = 20119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CheckHaveDLCForCar(string carName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckHaveDLCForCar_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20127, RefRangeEnd = 20129, XrefRangeStart = 20121, XrefRangeEnd = 20127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetConfigCounts(string carName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigCounts_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20129, XrefRangeEnd = 20130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarExists(string carID, int config)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarExists_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 20146, RefRangeEnd = 20161, XrefRangeStart = 20130, XrefRangeEnd = 20146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCarNameWithSuffix(string carID, int configVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &configVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarNameWithSuffix_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20240, RefRangeEnd = 20241, XrefRangeStart = 20161, XrefRangeEnd = 20240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<CarVersionWindowEntry> GetCarVersionWindowEntries(string carName, bool checkDLCAndScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkDLCAndScene;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarVersionWindowEntries_Public_ArrayOf_CarVersionWindowEntry_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CarVersionWindowEntry>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20274, RefRangeEnd = 20275, XrefRangeStart = 20241, XrefRangeEnd = 20274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetCarVersionsForDrag(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarVersionsForDrag_Public_ArrayOf_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20296, RefRangeEnd = 20297, XrefRangeStart = 20275, XrefRangeEnd = 20296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCarsForDrag(out List<string> cars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForDrag_Public_Void_byref_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		cars = (List<string>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20297, XrefRangeEnd = 20304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarsIdWithConfig> GetCarsForLevel(int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForLevel_Public_List_1_CarsIdWithConfig_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarsIdWithConfig>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 20315, RefRangeEnd = 20320, XrefRangeStart = 20304, XrefRangeEnd = 20315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarsIdWithConfig> GetCarsForScene(SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sceneType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForScene_Public_List_1_CarsIdWithConfig_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarsIdWithConfig>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 20331, RefRangeEnd = 20334, XrefRangeStart = 20320, XrefRangeEnd = 20331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarsIdWithConfig> GetCarsForDLC(int dlc, SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dlc);
		*(SceneType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForDLC_Public_List_1_CarsIdWithConfig_Int32_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarsIdWithConfig>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20334, XrefRangeEnd = 20341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarsIdWithConfig> GetCarsForDLC(int dlc, int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dlc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForDLC_Public_List_1_CarsIdWithConfig_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarsIdWithConfig>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20389, RefRangeEnd = 20391, XrefRangeStart = 20341, XrefRangeEnd = 20389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SalonCarConfigData> GetCarsConfigDataForSalon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsConfigDataForSalon_Public_List_1_SalonCarConfigData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<SalonCarConfigData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20488, RefRangeEnd = 20489, XrefRangeStart = 20391, XrefRangeEnd = 20488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BasicCarForDragstrip> GetAllCarsForDragstrip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllCarsForDragstrip_Public_List_1_BasicCarForDragstrip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<BasicCarForDragstrip>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20495, RefRangeEnd = 20496, XrefRangeStart = 20489, XrefRangeEnd = 20495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCarsBetweenPowerIndex(List<BasicCarForDragstrip> availableCars, List<DragstripRandomOpponentBasicData> result, float powerIndex, out float minPI, out float maxPI, out CarForDragstrip minCar, out CarForDragstrip maxCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableCars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(result);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &powerIndex;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref minPI);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref maxPI);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(minCar);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(maxCar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsBetweenPowerIndex_Public_Void_List_1_BasicCarForDragstrip_List_1_DragstripRandomOpponentBasicData_Single_byref_Single_byref_Single_byref_CarForDragstrip_byref_CarForDragstrip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20511, RefRangeEnd = 20513, XrefRangeStart = 20496, XrefRangeEnd = 20511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarForDragstrip> GetCarsForDragstripPlayer(List<BasicCarForDragstrip> availableCars, float minPI, float maxPI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableCars);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minPI;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxPI;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForDragstripPlayer_Public_List_1_CarForDragstrip_List_1_BasicCarForDragstrip_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarForDragstrip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20513, XrefRangeEnd = 20517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string RandomCarName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomCarName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20517, XrefRangeEnd = 20532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckConfigWithUIdExists(string carID, string configUId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(configUId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckConfigWithUIdExists_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20532, XrefRangeEnd = 20541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetCarPropertyV2(string carID, int configVersion, string id, string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &configVersion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarPropertyV2_Public_Vector2_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20541, XrefRangeEnd = 20546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCarPropertyInt(string carID, int configVersion, string id, string key, int defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &configVersion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarPropertyInt_Public_Int32_String_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 20551, RefRangeEnd = 20578, XrefRangeStart = 20546, XrefRangeEnd = 20551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCarPropertyFloat(string carID, int configVersion, string id, string key, float defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &configVersion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarPropertyFloat_Public_Single_String_Int32_String_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 20583, RefRangeEnd = 20610, XrefRangeStart = 20578, XrefRangeEnd = 20583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCarPropertyString(string carID, int configVersion, string id, string key, string defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &configVersion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarPropertyString_Public_String_String_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20610, XrefRangeEnd = 20614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCarBodyPropertyString(string carID, int configVersion, string id, string section, string defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &configVersion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarBodyPropertyString_Public_String_String_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20665, RefRangeEnd = 20666, XrefRangeStart = 20614, XrefRangeEnd = 20665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadThumbnails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadThumbnails_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20764, RefRangeEnd = 20765, XrefRangeStart = 20666, XrefRangeEnd = 20764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadModdingPartsToShop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadModdingPartsToShop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20765, XrefRangeEnd = 20783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllAssetBundlesNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssetBundlesNames_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20864, RefRangeEnd = 20866, XrefRangeStart = 20783, XrefRangeEnd = 20864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllAssetBundlesNamesFromWorkshop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssetBundlesNamesFromWorkshop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20911, RefRangeEnd = 20913, XrefRangeStart = 20866, XrefRangeEnd = 20911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllAssetBundlesNames(Il2CppStringArray paths)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssetBundlesNames_Private_Void_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21100, RefRangeEnd = 21101, XrefRangeStart = 20913, XrefRangeEnd = 21100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllAssetBundlesDecrypted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllAssetBundlesDecrypted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 21115, RefRangeEnd = 21119, XrefRangeStart = 21101, XrefRangeEnd = 21115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPathForTextFile(string fileName, string bundleName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(bundleName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPathForTextFile_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 21141, RefRangeEnd = 21144, XrefRangeStart = 21119, XrefRangeEnd = 21141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBundleDirectory(string bundleName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(bundleName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBundleDirectory_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21147, RefRangeEnd = 21149, XrefRangeStart = 21144, XrefRangeEnd = 21147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator GetCarFromAssetBundle(string AssetBundleCarName, string modelName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetBundleCarName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(modelName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarFromAssetBundle_Public_IEnumerator_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 21207, RefRangeEnd = 21210, XrefRangeStart = 21149, XrefRangeEnd = 21207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityEngine.Object BodyPart(string AssetBundleName, string Part)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetBundleName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(Part);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BodyPart_Public_Object_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityEngine.Object(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 21256, RefRangeEnd = 21259, XrefRangeStart = 21210, XrefRangeEnd = 21256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityEngine.Object GetFromBundle(string AssetBundleName, string ObjectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetBundleName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ObjectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFromBundle_Public_Object_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UnityEngine.Object(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21307, RefRangeEnd = 21308, XrefRangeStart = 21259, XrefRangeEnd = 21307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetListOfPartsNames(string AssetBundleName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetBundleName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListOfPartsNames_Public_List_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21372, RefRangeEnd = 21373, XrefRangeStart = 21308, XrefRangeEnd = 21372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetListOfTuningPartsNames(string AssetBundleName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetBundleName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetListOfTuningPartsNames_Public_List_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21435, RefRangeEnd = 21436, XrefRangeStart = 21373, XrefRangeEnd = 21435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameObject> GetTuningParts(string AssetBundleName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(AssetBundleName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningParts_Public_List_1_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<GameObject>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 21491, RefRangeEnd = 21499, XrefRangeStart = 21436, XrefRangeEnd = 21491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject SwapMaterials(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapMaterials_Public_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21502, RefRangeEnd = 21504, XrefRangeStart = 21499, XrefRangeEnd = 21502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarFileType GetCarFileInfo(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarFileInfo_Public_CarFileType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(CarFileType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21509, RefRangeEnd = 21510, XrefRangeStart = 21504, XrefRangeEnd = 21509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadTextFile(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTextFile_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 21512, RefRangeEnd = 21560, XrefRangeStart = 21510, XrefRangeEnd = 21512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarConfigData FindCarConfig(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCarConfig_Public_CarConfigData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarConfigData(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21562, RefRangeEnd = 21564, XrefRangeStart = 21560, XrefRangeEnd = 21562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarConfigExists(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarConfigExists_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 21600, RefRangeEnd = 21606, XrefRangeStart = 21564, XrefRangeEnd = 21600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CarsIdWithConfig> GetAllAvailableCars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAvailableCars_Public_List_1_CarsIdWithConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarsIdWithConfig>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 21620, RefRangeEnd = 21624, XrefRangeStart = 21606, XrefRangeEnd = 21620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarIsAvailableOnLevel(string carID, int config, int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarIsAvailableOnLevel_Private_Boolean_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21642, RefRangeEnd = 21644, XrefRangeStart = 21624, XrefRangeEnd = 21642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarIsAvailableOnScene(string carID, int config, SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(SceneType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarIsAvailableOnScene_Private_Boolean_String_Int32_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21694, RefRangeEnd = 21695, XrefRangeStart = 21644, XrefRangeEnd = 21694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateConfigs(PartsMaxTuningData maxTuningData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(maxTuningData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateConfigs_Public_Void_PartsMaxTuningData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21695, XrefRangeEnd = 21699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateConfigData(CarConfigData carData, PartsMaxTuningData maxTuningData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxTuningData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateConfigData_Private_Void_CarConfigData_PartsMaxTuningData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21734, RefRangeEnd = 21736, XrefRangeStart = 21699, XrefRangeEnd = 21734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateConfig(INIUnity ini, PartsMaxTuningData maxTuningData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxTuningData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateConfig_Private_Void_INIUnity_PartsMaxTuningData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21753, RefRangeEnd = 21754, XrefRangeStart = 21736, XrefRangeEnd = 21753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdatePerformanceIndexStock(INIUnity ini, string engineID, float engineScale, float torqueMod, float rpmMod, float carWeight, float maxTuning, string transmissionType, Il2CppStringArray tires, bool maxTuningChanged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engineID);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &engineScale;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &torqueMod;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmMod;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &carWeight;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTuning;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(transmissionType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tires);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTuningChanged;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePerformanceIndexStock_Private_Boolean_INIUnity_String_Single_Single_Single_Single_Single_String_ArrayOf_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21812, RefRangeEnd = 21813, XrefRangeStart = 21754, XrefRangeEnd = 21812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePerformanceIndexForTires(INIUnity ini, string engineID, float engineScale, float torqueMod, float rpmMod, float carWeight, float maxTuning, string transmissionType, Il2CppStringArray tires)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engineID);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &engineScale;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &torqueMod;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmMod;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &carWeight;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTuning;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(transmissionType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tires);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePerformanceIndexForTires_Private_Void_INIUnity_String_Single_Single_Single_Single_Single_String_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21834, RefRangeEnd = 21835, XrefRangeStart = 21813, XrefRangeEnd = 21834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<float, float> UpdateMaxTuning(INIUnity ini, string engineID, PartsMaxTuningData maxTuningData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engineID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxTuningData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMaxTuning_Private_Static_ValueTuple_2_Single_Single_INIUnity_String_PartsMaxTuningData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new Il2CppSystem.ValueTuple<float, float>(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21894, RefRangeEnd = 21895, XrefRangeStart = 21835, XrefRangeEnd = 21894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTires(INIUnity ini, Il2CppStringArray tires)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tires);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTires_Private_Static_Void_INIUnity_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarBundleLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21912, RefRangeEnd = 21913, XrefRangeStart = 21895, XrefRangeEnd = 21912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_String_byref___c__DisplayClass58_0_0(string tire, ref __c__DisplayClass58_0 P_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(P_1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_String_byref___c__DisplayClass58_0_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarBundleLoader()
	{
		Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarBundleLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr);
		NativeFieldInfoPtr_CarNamesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "CarNamesData");
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, "IsReady");
		NativeMethodInfoPtr_Init_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664752);
		NativeMethodInfoPtr_CarCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664753);
		NativeMethodInfoPtr_GetCarNames_Public_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664754);
		NativeMethodInfoPtr_GetCarConfigData_Public_CarConfigData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664755);
		NativeMethodInfoPtr_GetCarConfigData_Private_INIUnity_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664756);
		NativeMethodInfoPtr_CarNames_Public_List_1_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664757);
		NativeMethodInfoPtr_IsModCar_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664758);
		NativeMethodInfoPtr_CarNamesWithCheckDLC_Public_List_1_CarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664759);
		NativeMethodInfoPtr_CheckHaveDLCForCar_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664760);
		NativeMethodInfoPtr_GetConfigCounts_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664761);
		NativeMethodInfoPtr_CarExists_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664762);
		NativeMethodInfoPtr_GetCarNameWithSuffix_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664763);
		NativeMethodInfoPtr_GetCarVersionWindowEntries_Public_ArrayOf_CarVersionWindowEntry_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664764);
		NativeMethodInfoPtr_GetCarVersionsForDrag_Public_ArrayOf_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664765);
		NativeMethodInfoPtr_GetCarsForDrag_Public_Void_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664766);
		NativeMethodInfoPtr_GetCarsForLevel_Public_List_1_CarsIdWithConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664767);
		NativeMethodInfoPtr_GetCarsForScene_Public_List_1_CarsIdWithConfig_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664768);
		NativeMethodInfoPtr_GetCarsForDLC_Public_List_1_CarsIdWithConfig_Int32_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664769);
		NativeMethodInfoPtr_GetCarsForDLC_Public_List_1_CarsIdWithConfig_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664770);
		NativeMethodInfoPtr_GetCarsConfigDataForSalon_Public_List_1_SalonCarConfigData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664771);
		NativeMethodInfoPtr_GetAllCarsForDragstrip_Public_List_1_BasicCarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664772);
		NativeMethodInfoPtr_GetCarsBetweenPowerIndex_Public_Void_List_1_BasicCarForDragstrip_List_1_DragstripRandomOpponentBasicData_Single_byref_Single_byref_Single_byref_CarForDragstrip_byref_CarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664773);
		NativeMethodInfoPtr_GetCarsForDragstripPlayer_Public_List_1_CarForDragstrip_List_1_BasicCarForDragstrip_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664774);
		NativeMethodInfoPtr_RandomCarName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664775);
		NativeMethodInfoPtr_CheckConfigWithUIdExists_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664776);
		NativeMethodInfoPtr_GetCarPropertyV2_Public_Vector2_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664777);
		NativeMethodInfoPtr_GetCarPropertyInt_Public_Int32_String_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664778);
		NativeMethodInfoPtr_GetCarPropertyFloat_Public_Single_String_Int32_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664779);
		NativeMethodInfoPtr_GetCarPropertyString_Public_String_String_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664780);
		NativeMethodInfoPtr_GetCarBodyPropertyString_Public_String_String_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664781);
		NativeMethodInfoPtr_LoadThumbnails_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664782);
		NativeMethodInfoPtr_LoadModdingPartsToShop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664783);
		NativeMethodInfoPtr_LoadAllAssetBundlesNames_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664784);
		NativeMethodInfoPtr_LoadAllAssetBundlesNamesFromWorkshop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664785);
		NativeMethodInfoPtr_LoadAllAssetBundlesNames_Private_Void_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664786);
		NativeMethodInfoPtr_LoadAllAssetBundlesDecrypted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664787);
		NativeMethodInfoPtr_GetPathForTextFile_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664788);
		NativeMethodInfoPtr_GetBundleDirectory_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664789);
		NativeMethodInfoPtr_GetCarFromAssetBundle_Public_IEnumerator_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664790);
		NativeMethodInfoPtr_BodyPart_Public_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664791);
		NativeMethodInfoPtr_GetFromBundle_Public_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664792);
		NativeMethodInfoPtr_GetListOfPartsNames_Public_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664793);
		NativeMethodInfoPtr_GetListOfTuningPartsNames_Public_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664794);
		NativeMethodInfoPtr_GetTuningParts_Public_List_1_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664795);
		NativeMethodInfoPtr_SwapMaterials_Public_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664796);
		NativeMethodInfoPtr_GetCarFileInfo_Public_CarFileType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664797);
		NativeMethodInfoPtr_LoadTextFile_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664798);
		NativeMethodInfoPtr_FindCarConfig_Public_CarConfigData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664799);
		NativeMethodInfoPtr_CarConfigExists_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664800);
		NativeMethodInfoPtr_GetAllAvailableCars_Public_List_1_CarsIdWithConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664801);
		NativeMethodInfoPtr_CarIsAvailableOnLevel_Private_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664802);
		NativeMethodInfoPtr_CarIsAvailableOnScene_Private_Boolean_String_Int32_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664803);
		NativeMethodInfoPtr_UpdateConfigs_Public_Void_PartsMaxTuningData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664804);
		NativeMethodInfoPtr_UpdateConfigData_Private_Void_CarConfigData_PartsMaxTuningData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664805);
		NativeMethodInfoPtr_UpdateConfig_Private_Void_INIUnity_PartsMaxTuningData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664806);
		NativeMethodInfoPtr_UpdatePerformanceIndexStock_Private_Boolean_INIUnity_String_Single_Single_Single_Single_Single_String_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664807);
		NativeMethodInfoPtr_UpdatePerformanceIndexForTires_Private_Void_INIUnity_String_Single_Single_Single_Single_Single_String_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664808);
		NativeMethodInfoPtr_UpdateMaxTuning_Private_Static_ValueTuple_2_Single_Single_INIUnity_String_PartsMaxTuningData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664809);
		NativeMethodInfoPtr_GetTires_Private_Static_Void_INIUnity_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664810);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664811);
		NativeMethodInfoPtr_Method_Internal_Static_Void_String_byref___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoader>.NativeClassPtr, 100664812);
	}

	public CarBundleLoader(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
