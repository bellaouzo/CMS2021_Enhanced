using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FuseBox : MonoBehaviour
{
	private sealed class MethodInfoStoreGeneric_Shuffle_Private_Static_Void_IList_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Shuffle_Private_Static_Void_IList_1_T_Int32_0, Il2CppClassPointerStore<FuseBox>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_relaysToDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_fusesToDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_relays;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuses;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Comparison_Private_Int32_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shuffle_Private_Static_Void_IList_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FuseBox>.NativeClassPtr));

	public unsafe int relaysToDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relaysToDisable);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relaysToDisable)) = num;
		}
	}

	public unsafe int fusesToDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fusesToDisable);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fusesToDisable)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> relays
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relays);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relays), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> fuses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuses), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92311, RefRangeEnd = 92312, XrefRangeStart = 92288, XrefRangeEnd = 92311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(string carName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92312, XrefRangeEnd = 92314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Comparison(GameObject x, GameObject y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Comparison_Private_Int32_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92328, RefRangeEnd = 92330, XrefRangeStart = 92314, XrefRangeEnd = 92328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shuffle<T>(IList<T> list, int seed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Shuffle_Private_Static_Void_IList_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92330, XrefRangeEnd = 92333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FuseBox()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FuseBox>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FuseBox()
	{
		Il2CppClassPointerStore<FuseBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FuseBox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FuseBox>.NativeClassPtr);
		NativeFieldInfoPtr_relaysToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, "relaysToDisable");
		NativeFieldInfoPtr_fusesToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, "fusesToDisable");
		NativeFieldInfoPtr_relays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, "relays");
		NativeFieldInfoPtr_fuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, "fuses");
		NativeMethodInfoPtr_Setup_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, 100668579);
		NativeMethodInfoPtr_Comparison_Private_Int32_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, 100668580);
		NativeMethodInfoPtr_Shuffle_Private_Static_Void_IList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, 100668581);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuseBox>.NativeClassPtr, 100668582);
	}

	public FuseBox(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
