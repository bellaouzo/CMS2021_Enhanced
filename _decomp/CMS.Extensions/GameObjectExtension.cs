using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Extensions;

public static class GameObjectExtension : Il2CppSystem.Object
{
	[ObfuscatedName("CMS.Extensions.GameObjectExtension/<>c__DisplayClass5_0`1")]
	public sealed class __c__DisplayClass5_0<T> : Il2CppSystem.Object where T : Component
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreLayerMask;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetComponentsInChildren_b__0_Internal_Boolean_T_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr));

		public unsafe LayerMask ignoreLayerMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreLayerMask);
				return *(LayerMask*)num;
			}
			set
			{
				*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreLayerMask)) = layerMask;
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216742, XrefRangeEnd = 216746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetComponentsInChildren_b__0(T item)
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
				T val = item;
				if (val is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(val as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
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
				reference = ref item;
			}
			*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetComponentsInChildren_b__0_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, "<>c__DisplayClass5_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_ignoreLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr, "ignoreLayerMask");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr, 100679672);
			NativeMethodInfoPtr__GetComponentsInChildren_b__0_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0<T>>.NativeClassPtr, 100679673);
		}

		public __c__DisplayClass5_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CopyComponent_Public_Static_T_GameObject_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyComponent_Public_Static_T_GameObject_T_0, Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Static_ArrayOf_T_GameObject_Boolean_LayerMask_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInChildren_Public_Static_ArrayOf_T_GameObject_Boolean_LayerMask_0, Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteMaterials_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderingLayer_Public_Static_Void_GameObject_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyComponent_Public_Static_T_GameObject_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Static_ArrayOf_T_GameObject_Boolean_LayerMask_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr));

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 216757, RefRangeEnd = 216767, XrefRangeStart = 216746, XrefRangeEnd = 216757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteMaterials(this GameObject parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteMaterials_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216782, RefRangeEnd = 216784, XrefRangeStart = 216767, XrefRangeEnd = 216782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(this GameObject parent, string layerName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layerName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216797, RefRangeEnd = 216801, XrefRangeStart = 216784, XrefRangeEnd = 216797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(this GameObject parent, int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216801, XrefRangeEnd = 216806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderingLayer(this GameObject parent, uint layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderingLayer_Public_Static_Void_GameObject_UInt32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 216830, RefRangeEnd = 216831, XrefRangeStart = 216806, XrefRangeEnd = 216830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T CopyComponent<T>(this GameObject destination, T original) where T : Component
	{
		//IL_0081->IL0086: Incompatible stack types: I vs Ref
		//IL_005d->IL0086: Incompatible stack types: I vs Ref
		//IL_006a->IL0086: Incompatible stack types: I vs Ref
		//IL_0074->IL0086: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = original;
			if (val is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(val as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
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
			reference = ref original;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyComponent_Public_Static_T_GameObject_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216831, XrefRangeEnd = 216836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> GetComponentsInChildren<T>(this GameObject original, bool includeInactive, LayerMask ignoreLayerMask) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeInactive;
		*(LayerMask**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreLayerMask;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInChildren_Public_Static_ArrayOf_T_GameObject_Boolean_LayerMask_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
	}

	static GameObjectExtension()
	{
		Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Extensions", "GameObjectExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr);
		NativeMethodInfoPtr_DeleteMaterials_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, 100679666);
		NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, 100679667);
		NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, 100679668);
		NativeMethodInfoPtr_SetRenderingLayer_Public_Static_Void_GameObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, 100679669);
		NativeMethodInfoPtr_CopyComponent_Public_Static_T_GameObject_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, 100679670);
		NativeMethodInfoPtr_GetComponentsInChildren_Public_Static_ArrayOf_T_GameObject_Boolean_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtension>.NativeClassPtr, 100679671);
	}

	public GameObjectExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
