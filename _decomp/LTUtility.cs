using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LTUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_reverse_Public_Static_ArrayOf_Vector3_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTUtility>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 9228, RefRangeEnd = 9230, XrefRangeStart = 9228, XrefRangeEnd = 9228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> reverse(Il2CppStructArray<Vector3> arr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(arr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reverse_Public_Static_ArrayOf_Vector3_ArrayOf_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LTUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTUtility>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LTUtility()
	{
		Il2CppClassPointerStore<LTUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTUtility>.NativeClassPtr);
		NativeMethodInfoPtr_reverse_Public_Static_ArrayOf_Vector3_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTUtility>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTUtility>.NativeClassPtr, 100664075);
	}

	public LTUtility(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
