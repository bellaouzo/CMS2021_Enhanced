using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarSupportData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FL;

	private static readonly System.IntPtr NativeFieldInfoPtr_FR;

	private static readonly System.IntPtr NativeFieldInfoPtr_RL;

	private static readonly System.IntPtr NativeFieldInfoPtr_RR;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr));

	public unsafe Vector3 FL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FL);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FL)) = vector;
		}
	}

	public unsafe Vector3 FR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FR);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FR)) = vector;
		}
	}

	public unsafe Vector3 RL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RL);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RL)) = vector;
		}
	}

	public unsafe Vector3 RR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RR);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RR)) = vector;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarSupportData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarSupportData()
	{
		Il2CppClassPointerStore<CarSupportData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarSupportData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr);
		NativeFieldInfoPtr_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr, "FL");
		NativeFieldInfoPtr_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr, "FR");
		NativeFieldInfoPtr_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr, "RL");
		NativeFieldInfoPtr_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr, "RR");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSupportData>.NativeClassPtr, 100668597);
	}

	public CarSupportData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
