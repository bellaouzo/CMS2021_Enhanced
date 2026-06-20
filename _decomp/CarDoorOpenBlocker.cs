using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarDoorOpenBlocker : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_openLeftSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_openRightSide;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr));

	public unsafe bool openLeftSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openLeftSide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openLeftSide)) = flag;
		}
	}

	public unsafe bool openRightSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRightSide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRightSide)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52572, XrefRangeEnd = 52620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarDoorOpenBlocker()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarDoorOpenBlocker()
	{
		Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarDoorOpenBlocker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr);
		NativeFieldInfoPtr_openLeftSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr, "openLeftSide");
		NativeFieldInfoPtr_openRightSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr, "openRightSide");
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr, 100666366);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDoorOpenBlocker>.NativeClassPtr, 100666367);
	}

	public CarDoorOpenBlocker(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
