using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Logic;

public class CarRibbon : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dlc;

	private static readonly System.IntPtr NativeFieldInfoPtr_mod;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForCar_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr));

	public unsafe GameObject dlc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dlc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject mod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mod), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 179356, RefRangeEnd = 179371, XrefRangeStart = 179336, XrefRangeEnd = 179356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForCar(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForCar_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetNone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarRibbon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarRibbon()
	{
		Il2CppClassPointerStore<CarRibbon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "CarRibbon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr);
		NativeFieldInfoPtr_dlc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr, "dlc");
		NativeFieldInfoPtr_mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr, "mod");
		NativeMethodInfoPtr_SetForCar_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr, 100676305);
		NativeMethodInfoPtr_SetNone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr, 100676306);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarRibbon>.NativeClassPtr, 100676307);
	}

	public CarRibbon(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
