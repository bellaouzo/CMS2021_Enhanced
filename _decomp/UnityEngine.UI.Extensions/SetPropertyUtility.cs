using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public static class SetPropertyUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0, Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool SetColor(ref Color currentValue, Color newValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref currentValue);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121766, XrefRangeEnd = 121771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetStruct<T>(ref T currentValue, T newValue) where T : new()
	{
		//IL_008b->IL0090: Incompatible stack types: I vs Ref
		//IL_0067->IL0090: Incompatible stack types: I vs Ref
		//IL_0074->IL0090: Incompatible stack types: I vs Ref
		//IL_007e->IL0090: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(System.Runtime.CompilerServices.Unsafe.As<T, Il2CppObjectBase>(ref currentValue));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = newValue;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr2;
				if (intPtr2 != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr2;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr2)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr2);
					}
				}
			}
		}
		else
		{
			reference = ref newValue;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetStruct_Public_Static_Boolean_byref_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref currentValue) = ((intPtr3 == (System.IntPtr)0) ? ((T)null) : new T(intPtr3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 121771, RefRangeEnd = 121794, XrefRangeStart = 121771, XrefRangeEnd = 121771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetClass<T>(ref T currentValue, T newValue) where T : class
	{
		//IL_008b->IL0090: Incompatible stack types: I vs Ref
		//IL_0067->IL0090: Incompatible stack types: I vs Ref
		//IL_0074->IL0090: Incompatible stack types: I vs Ref
		//IL_007e->IL0090: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentValue);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = newValue;
			if (val is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(val as string);
			}
			else
			{
				System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr2;
				if (intPtr2 != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr2;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr2)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr2);
					}
				}
			}
		}
		else
		{
			reference = ref newValue;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetClass_Public_Static_Boolean_byref_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		currentValue = ((intPtr3 == (System.IntPtr)0) ? null : new T(intPtr3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static SetPropertyUtility()
	{
		Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "SetPropertyUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr);
		NativeMethodInfoPtr_SetColor_Public_Static_Boolean_byref_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100671082);
		NativeMethodInfoPtr_SetStruct_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100671083);
		NativeMethodInfoPtr_SetClass_Public_Static_Boolean_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyUtility>.NativeClassPtr, 100671084);
	}

	public SetPropertyUtility(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
