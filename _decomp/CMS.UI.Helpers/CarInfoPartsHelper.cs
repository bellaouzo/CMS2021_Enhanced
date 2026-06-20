using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.CarInfo;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Helpers;

public static class CarInfoPartsHelper : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("CMS.UI.Helpers.CarInfoPartsHelper/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__3_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__4_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnmountedBodyParts_b__1_0_Internal_Boolean_CarPart_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetMountedBodyParts_b__2_0_Internal_Boolean_CarPart_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetMountedBodyParts_b__2_1_Internal_Int32_CarPart_CarPart_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetExaminedCarParts_b__3_0_Internal_Boolean_PartScript_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetExaminedCarParts_b__3_1_Internal_Int32_PartScript_PartScript_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNotExaminedCarParts_b__4_0_Internal_Boolean_PartScript_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNotExaminedCarParts_b__4_1_Internal_String_PartScript_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnmountedCarParts_b__5_0_Internal_Boolean_PartScript_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnmountedCarParts_b__5_1_Internal_String_PartScript_0;

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

		public unsafe static Il2CppSystem.Predicate<CarPart> __9__1_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__1_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Predicate<CarPart>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__1_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Predicate<CarPart> __9__2_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Predicate<CarPart>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Comparison<CarPart> __9__2_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Comparison<CarPart>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Predicate<PartScript> __9__3_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__3_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Predicate<PartScript>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__3_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Comparison<PartScript> __9__3_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__3_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Comparison<PartScript>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__3_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Predicate<PartScript> __9__4_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__4_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Predicate<PartScript>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__4_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<PartScript, string> __9__4_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__4_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<PartScript, string>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__4_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Predicate<PartScript> __9__5_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__5_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Predicate<PartScript>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__5_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<PartScript, string> __9__5_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__5_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<PartScript, string>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__5_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe bool _GetUnmountedBodyParts_b__1_0(CarPart p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnmountedBodyParts_b__1_0_Internal_Boolean_CarPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _GetMountedBodyParts_b__2_0(CarPart p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetMountedBodyParts_b__2_0_Internal_Boolean_CarPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe int _GetMountedBodyParts_b__2_1(CarPart a, CarPart b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetMountedBodyParts_b__2_1_Internal_Int32_CarPart_CarPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _GetExaminedCarParts_b__3_0(PartScript part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(part);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetExaminedCarParts_b__3_0_Internal_Boolean_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe int _GetExaminedCarParts_b__3_1(PartScript a, PartScript b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetExaminedCarParts_b__3_1_Internal_Int32_PartScript_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe bool _GetNotExaminedCarParts_b__4_0(PartScript part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(part);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNotExaminedCarParts_b__4_0_Internal_Boolean_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203570, XrefRangeEnd = 203573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _GetNotExaminedCarParts_b__4_1(PartScript p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNotExaminedCarParts_b__4_1_Internal_String_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		[CallerCount(0)]
		public unsafe bool _GetUnmountedCarParts_b__5_0(PartScript part)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(part);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnmountedCarParts_b__5_0_Internal_Boolean_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe string _GetUnmountedCarParts_b__5_1(PartScript p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnmountedCarParts_b__5_1_Internal_String_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__1_0");
			NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_0");
			NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__2_1");
			NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__3_0");
			NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__3_1");
			NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__4_0");
			NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__4_1");
			NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__5_0");
			NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__5_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678714);
			NativeMethodInfoPtr__GetUnmountedBodyParts_b__1_0_Internal_Boolean_CarPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678715);
			NativeMethodInfoPtr__GetMountedBodyParts_b__2_0_Internal_Boolean_CarPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678716);
			NativeMethodInfoPtr__GetMountedBodyParts_b__2_1_Internal_Int32_CarPart_CarPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678717);
			NativeMethodInfoPtr__GetExaminedCarParts_b__3_0_Internal_Boolean_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678718);
			NativeMethodInfoPtr__GetExaminedCarParts_b__3_1_Internal_Int32_PartScript_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678719);
			NativeMethodInfoPtr__GetNotExaminedCarParts_b__4_0_Internal_Boolean_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678720);
			NativeMethodInfoPtr__GetNotExaminedCarParts_b__4_1_Internal_String_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678721);
			NativeMethodInfoPtr__GetUnmountedCarParts_b__5_0_Internal_Boolean_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678722);
			NativeMethodInfoPtr__GetUnmountedCarParts_b__5_1_Internal_String_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100678723);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.UI.Helpers.CarInfoPartsHelper/<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_part;

		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetExaminedCarParts_b__2_Internal_Void_Boolean_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr));

		public unsafe PartScript part
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe CarInfoPart item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarInfoPart(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe void _GetExaminedCarParts_b__2(bool mark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mark);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetExaminedCarParts_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr);
			NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "part");
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, "item");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100678724);
			NativeMethodInfoPtr__GetExaminedCarParts_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass3_0>.NativeClassPtr, 100678725);
		}

		public __c__DisplayClass3_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.UI.Helpers.CarInfoPartsHelper/<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_part;

		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetNotExaminedCarParts_b__2_Internal_Void_Boolean_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr));

		public unsafe PartScript part
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe CarInfoPart item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarInfoPart(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe void _GetNotExaminedCarParts_b__2(bool mark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mark);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetNotExaminedCarParts_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
			NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "part");
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "item");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100678726);
			NativeMethodInfoPtr__GetNotExaminedCarParts_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100678727);
		}

		public __c__DisplayClass4_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.UI.Helpers.CarInfoPartsHelper/<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_part;

		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetUnmountedCarParts_b__2_Internal_Void_Boolean_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr));

		public unsafe PartScript part
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_part), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe CarInfoPart item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarInfoPart(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe void _GetUnmountedCarParts_b__2(bool mark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mark);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetUnmountedCarParts_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_part = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "part");
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "item");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100678728);
			NativeMethodInfoPtr__GetUnmountedCarParts_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100678729);
		}

		public __c__DisplayClass5_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParts_Public_Static_Void_CarLoader_byref_List_1_CarInfoPart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnmountedBodyParts_Public_Static_List_1_CarInfoPart_List_1_CarPart_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMountedBodyParts_Public_Static_List_1_CarInfoPart_List_1_CarPart_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExaminedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNotExaminedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnmountedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 203601, RefRangeEnd = 203603, XrefRangeStart = 203573, XrefRangeEnd = 203601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetParts(CarLoader carLoader, out List<CarInfoPart> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(result);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParts_Public_Static_Void_CarLoader_byref_List_1_CarInfoPart_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		result = (List<CarInfoPart>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 203698, RefRangeEnd = 203699, XrefRangeStart = 203603, XrefRangeEnd = 203698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarInfoPart> GetUnmountedBodyParts(List<CarPart> allParts, string carToLoad)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(allParts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carToLoad);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnmountedBodyParts_Public_Static_List_1_CarInfoPart_List_1_CarPart_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarInfoPart>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 203809, RefRangeEnd = 203810, XrefRangeStart = 203699, XrefRangeEnd = 203809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarInfoPart> GetMountedBodyParts(List<CarPart> allParts, string carToLoad)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(allParts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carToLoad);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMountedBodyParts_Public_Static_List_1_CarInfoPart_List_1_CarPart_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarInfoPart>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 203876, RefRangeEnd = 203877, XrefRangeStart = 203810, XrefRangeEnd = 203876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarInfoPart> GetExaminedCarParts(List<PartScript> allParts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(allParts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExaminedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarInfoPart>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 203948, RefRangeEnd = 203949, XrefRangeStart = 203877, XrefRangeEnd = 203948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarInfoPart> GetNotExaminedCarParts(List<PartScript> allParts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(allParts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNotExaminedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarInfoPart>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 204020, RefRangeEnd = 204021, XrefRangeStart = 203949, XrefRangeEnd = 204020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarInfoPart> GetUnmountedCarParts(List<PartScript> allParts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(allParts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnmountedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarInfoPart>(intPtr) : null;
	}

	static CarInfoPartsHelper()
	{
		Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "CarInfoPartsHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetParts_Public_Static_Void_CarLoader_byref_List_1_CarInfoPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, 100678707);
		NativeMethodInfoPtr_GetUnmountedBodyParts_Public_Static_List_1_CarInfoPart_List_1_CarPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, 100678708);
		NativeMethodInfoPtr_GetMountedBodyParts_Public_Static_List_1_CarInfoPart_List_1_CarPart_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, 100678709);
		NativeMethodInfoPtr_GetExaminedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, 100678710);
		NativeMethodInfoPtr_GetNotExaminedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, 100678711);
		NativeMethodInfoPtr_GetUnmountedCarParts_Public_Static_List_1_CarInfoPart_List_1_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPartsHelper>.NativeClassPtr, 100678712);
	}

	public CarInfoPartsHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
