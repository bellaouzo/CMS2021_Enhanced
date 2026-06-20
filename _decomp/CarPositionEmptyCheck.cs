using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarPositionEmptyCheck : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_boxCollider;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerInside_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr));

	public unsafe BoxCollider boxCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boxCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BoxCollider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boxCollider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 54098, RefRangeEnd = 54099, XrefRangeStart = 54079, XrefRangeEnd = 54098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlayerInside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayerInside_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarPositionEmptyCheck()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarPositionEmptyCheck()
	{
		Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarPositionEmptyCheck");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr);
		NativeFieldInfoPtr_boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr, "boxCollider");
		NativeMethodInfoPtr_IsPlayerInside_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr, 100666438);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPositionEmptyCheck>.NativeClassPtr, 100666439);
	}

	public CarPositionEmptyCheck(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
