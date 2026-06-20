using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class EnumerableExtension : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("EnumerableExtension/<>c__2`1")]
	public sealed class __c__2<T> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Shuffle_b__2_0_Internal_Guid_T_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr));

		public unsafe static __c__2<T> __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new __c__2<T>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<T, Il2CppSystem.Guid> __9__2_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__2_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<T, Il2CppSystem.Guid>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__2_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95416, XrefRangeEnd = 95420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Guid _Shuffle_b__2_0(T x)
		{
			//IL_0070->IL0075: Incompatible stack types: I vs Ref
			//IL_004c->IL0075: Incompatible stack types: I vs Ref
			//IL_0059->IL0075: Incompatible stack types: I vs Ref
			//IL_0063->IL0075: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				object obj = x;
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
				reference = ref x;
			}
			*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Shuffle_b__2_0_Internal_Guid_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Il2CppSystem.Guid*)IL2CPP.il2cpp_object_unbox(obj2);
		}

		static __c__2()
		{
			Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr, "<>c__2`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr, "<>9__2_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr, 100668841);
			NativeMethodInfoPtr__Shuffle_b__2_0_Internal_Guid_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__2<T>>.NativeClassPtr, 100668842);
		}

		public __c__2(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_PickRandom_Public_Static_T_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_PickRandom_Public_Static_T_IEnumerable_1_T_0, Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_PickRandom_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_PickRandom_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Int32_0, Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Shuffle_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_PickRandom_Public_Static_T_IEnumerable_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickRandom_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static T PickRandom<T>(this IEnumerable<T> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_PickRandom_Public_Static_T_IEnumerable_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_PickRandom_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerable<T>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95433, RefRangeEnd = 95435, XrefRangeStart = 95420, XrefRangeEnd = 95433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Shuffle_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerable<T>(intPtr) : null;
	}

	static EnumerableExtension()
	{
		Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EnumerableExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr);
		NativeMethodInfoPtr_PickRandom_Public_Static_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr, 100668837);
		NativeMethodInfoPtr_PickRandom_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr, 100668838);
		NativeMethodInfoPtr_Shuffle_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableExtension>.NativeClassPtr, 100668839);
	}

	public EnumerableExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
