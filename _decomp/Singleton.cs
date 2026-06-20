using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr__lock;

	private static readonly System.IntPtr NativeFieldInfoPtr_applicationIsQuitting;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr));

	public unsafe static T _instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr objectPointer);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, &objectPointer);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: false);
		}
		set
		{
			//IL_005b->IL0060: Incompatible stack types: I vs Ref
			//IL_0037->IL0060: Incompatible stack types: I vs Ref
			//IL_0044->IL0060: Incompatible stack types: I vs Ref
			//IL_004e->IL0060: Incompatible stack types: I vs Ref
			System.IntPtr nativeFieldInfoPtr__instance = NativeFieldInfoPtr__instance;
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = val2;
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
				reference = ref val2;
			}
			IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__instance, System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		}
	}

	public unsafe static Il2CppSystem.Object _lock
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__lock, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__lock, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static bool applicationIsQuitting
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_applicationIsQuitting, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_applicationIsQuitting, &flag);
		}
	}

	public unsafe static T Instance
	{
		[CallerCount(1196)]
		[CachedScanResults(RefRangeStart = 82697, RefRangeEnd = 83893, XrefRangeStart = 82559, XrefRangeEnd = 82697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83893, XrefRangeEnd = 83898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83898, XrefRangeEnd = 83901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Singleton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Singleton()
	{
		Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr);
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "_lock");
		NativeFieldInfoPtr_applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "applicationIsQuitting");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100668074);
		NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100668075);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100668076);
	}

	public Singleton(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
