using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Helpers;

public static class AuctionHelper : Il2CppSystem.Object
{
	[ObfuscatedName("CMS.Helpers.AuctionHelper/<GenerateSalvageCar>d__5")]
	public sealed class _GenerateSalvageCar_d__5 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_wait;

		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeFieldInfoPtr_rating;

		private static readonly System.IntPtr NativeFieldInfoPtr_context;

		private static readonly System.IntPtr NativeFieldInfoPtr__carGlobalConditionRandom_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr));

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

		public unsafe bool wait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wait);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wait)) = flag;
			}
		}

		public unsafe CarLoader carLoader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int rating
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rating);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rating)) = num;
			}
		}

		public unsafe MonoBehaviour context
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new MonoBehaviour(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector2 _carGlobalConditionRandom_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carGlobalConditionRandom_5__2);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carGlobalConditionRandom_5__2)) = vector;
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
		public unsafe _GenerateSalvageCar_d__5(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212209, XrefRangeEnd = 212313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212313, XrefRangeEnd = 212322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _GenerateSalvageCar_d__5()
		{
			Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, "<GenerateSalvageCar>d__5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "wait");
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "carLoader");
			NativeFieldInfoPtr_rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "rating");
			NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "context");
			NativeFieldInfoPtr__carGlobalConditionRandom_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, "<carGlobalConditionRandom>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, 100679255);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, 100679256);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, 100679257);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, 100679258);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, 100679259);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateSalvageCar_d__5>.NativeClassPtr, 100679260);
		}

		public _GenerateSalvageCar_d__5(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.AuctionHelper/<GenerateAuctionCar>d__6")]
	public sealed class _GenerateAuctionCar_d__6 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_wait;

		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeFieldInfoPtr_rating;

		private static readonly System.IntPtr NativeFieldInfoPtr_context;

		private static readonly System.IntPtr NativeFieldInfoPtr__carGlobalConditionRandom_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr));

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

		public unsafe bool wait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wait);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wait)) = flag;
			}
		}

		public unsafe CarLoader carLoader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int rating
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rating);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rating)) = num;
			}
		}

		public unsafe MonoBehaviour context
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new MonoBehaviour(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector2 _carGlobalConditionRandom_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carGlobalConditionRandom_5__2);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carGlobalConditionRandom_5__2)) = vector;
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
		public unsafe _GenerateAuctionCar_d__6(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212322, XrefRangeEnd = 212400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212400, XrefRangeEnd = 212405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _GenerateAuctionCar_d__6()
		{
			Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, "<GenerateAuctionCar>d__6");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "wait");
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "carLoader");
			NativeFieldInfoPtr_rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "rating");
			NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "context");
			NativeFieldInfoPtr__carGlobalConditionRandom_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, "<carGlobalConditionRandom>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, 100679261);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, 100679262);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, 100679263);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, 100679264);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, 100679265);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAuctionCar_d__6>.NativeClassPtr, 100679266);
		}

		public _GenerateAuctionCar_d__6(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Helpers.AuctionHelper/<GenerateAdditionalAuctionCar>d__7")]
	public sealed class _GenerateAdditionalAuctionCar_d__7 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_wait;

		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeFieldInfoPtr_rating;

		private static readonly System.IntPtr NativeFieldInfoPtr_context;

		private static readonly System.IntPtr NativeFieldInfoPtr__carGlobalConditionRandom_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr));

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

		public unsafe bool wait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wait);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wait)) = flag;
			}
		}

		public unsafe CarLoader carLoader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int rating
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rating);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rating)) = num;
			}
		}

		public unsafe MonoBehaviour context
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new MonoBehaviour(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector2 _carGlobalConditionRandom_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carGlobalConditionRandom_5__2);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carGlobalConditionRandom_5__2)) = vector;
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
		public unsafe _GenerateAdditionalAuctionCar_d__7(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212405, XrefRangeEnd = 212477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212477, XrefRangeEnd = 212482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _GenerateAdditionalAuctionCar_d__7()
		{
			Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, "<GenerateAdditionalAuctionCar>d__7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "wait");
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "carLoader");
			NativeFieldInfoPtr_rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "rating");
			NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "context");
			NativeFieldInfoPtr__carGlobalConditionRandom_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, "<carGlobalConditionRandom>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, 100679267);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, 100679268);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, 100679269);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, 100679270);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, 100679271);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateAdditionalAuctionCar_d__7>.NativeClassPtr, 100679272);
		}

		public _GenerateAdditionalAuctionCar_d__7(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRatingForCar_Public_Static_Int32_AuctionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPriceForRating_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStartingPrice_Public_Static_Int32_Int32_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAIMaxBid_Public_Static_Int32_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBidAmount_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSalvageCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAuctionCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAdditionalAuctionCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212489, RefRangeEnd = 212491, XrefRangeStart = 212482, XrefRangeEnd = 212489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRatingForCar(AuctionType auctionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&auctionType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRatingForCar_Public_Static_Int32_AuctionType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212491, XrefRangeEnd = 212492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPriceForRating(int carValue, int rating)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&carValue);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rating;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPriceForRating_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212499, RefRangeEnd = 212501, XrefRangeStart = 212492, XrefRangeEnd = 212499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetStartingPrice(int carValue, Vector2 priceModRange, int rating)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&carValue);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &priceModRange;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rating;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStartingPrice_Public_Static_Int32_Int32_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212501, XrefRangeEnd = 212502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAIMaxBid(int carValue, Vector2 AIMaxBidModRange)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&carValue);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &AIMaxBidModRange;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAIMaxBid_Public_Static_Int32_Int32_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static int GetBidAmount(int AIMaxBid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&AIMaxBid);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBidAmount_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212505, RefRangeEnd = 212507, XrefRangeStart = 212502, XrefRangeEnd = 212505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator GenerateSalvageCar(MonoBehaviour context, CarLoader carLoader, int rating, bool wait = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rating;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wait;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSalvageCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 212510, RefRangeEnd = 212513, XrefRangeStart = 212507, XrefRangeEnd = 212510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator GenerateAuctionCar(MonoBehaviour context, CarLoader carLoader, int rating, bool wait = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rating;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wait;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateAuctionCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212513, XrefRangeEnd = 212516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator GenerateAdditionalAuctionCar(MonoBehaviour context, CarLoader carLoader, int rating, bool wait = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rating;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wait;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateAdditionalAuctionCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	static AuctionHelper()
	{
		Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "AuctionHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetRatingForCar_Public_Static_Int32_AuctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679247);
		NativeMethodInfoPtr_GetPriceForRating_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679248);
		NativeMethodInfoPtr_GetStartingPrice_Public_Static_Int32_Int32_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679249);
		NativeMethodInfoPtr_GetAIMaxBid_Public_Static_Int32_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679250);
		NativeMethodInfoPtr_GetBidAmount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679251);
		NativeMethodInfoPtr_GenerateSalvageCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679252);
		NativeMethodInfoPtr_GenerateAuctionCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679253);
		NativeMethodInfoPtr_GenerateAdditionalAuctionCar_Public_Static_IEnumerator_MonoBehaviour_CarLoader_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionHelper>.NativeClassPtr, 100679254);
	}

	public AuctionHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
