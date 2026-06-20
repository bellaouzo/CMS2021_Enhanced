using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class CarLightBasic : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LightsCloseAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightsOpenAngle;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr));

	public unsafe Vector3 LightsCloseAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightsCloseAngle);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightsCloseAngle)) = vector;
		}
	}

	public unsafe Vector3 LightsOpenAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightsOpenAngle);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightsOpenAngle)) = vector;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarLightBasic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarLightBasic()
	{
		Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarLightBasic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr);
		NativeFieldInfoPtr_LightsCloseAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr, "LightsCloseAngle");
		NativeFieldInfoPtr_LightsOpenAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr, "LightsOpenAngle");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLightBasic>.NativeClassPtr, 100668593);
	}

	public CarLightBasic(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
