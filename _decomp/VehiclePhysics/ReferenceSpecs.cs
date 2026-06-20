using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

[System.Serializable]
public class ReferenceSpecs : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_numGears;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSuspensionDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpringRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxAccelerationG;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr));

	public unsafe float maxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
		}
	}

	public unsafe float maxRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpm);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpm)) = num;
		}
	}

	public unsafe float maxTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTorque)) = num;
		}
	}

	public unsafe float maxPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPower)) = num;
		}
	}

	public unsafe int numGears
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGears);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGears)) = num;
		}
	}

	public unsafe float maxSuspensionDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSuspensionDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSuspensionDistance)) = num;
		}
	}

	public unsafe float maxSpringRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpringRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpringRate)) = num;
		}
	}

	public unsafe float maxAccelerationG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAccelerationG);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAccelerationG)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe ReferenceSpecs()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ReferenceSpecs()
	{
		Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "ReferenceSpecs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr);
		NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxSpeed");
		NativeFieldInfoPtr_maxRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxRpm");
		NativeFieldInfoPtr_maxTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxTorque");
		NativeFieldInfoPtr_maxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxPower");
		NativeFieldInfoPtr_numGears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "numGears");
		NativeFieldInfoPtr_maxSuspensionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxSuspensionDistance");
		NativeFieldInfoPtr_maxSpringRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxSpringRate");
		NativeFieldInfoPtr_maxAccelerationG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, "maxAccelerationG");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceSpecs>.NativeClassPtr, 100671741);
	}

	public ReferenceSpecs(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
