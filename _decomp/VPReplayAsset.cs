using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPReplayAsset : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_timeStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_vehicleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneName;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_recordedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_notes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr));

	public unsafe float timeStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStep);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStep)) = num;
		}
	}

	public unsafe string vehicleName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vehicleName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vehicleName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string sceneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 velocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = vector;
		}
	}

	public unsafe Vector3 angularVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularVelocity)) = vector;
		}
	}

	public unsafe List<VPReplay.Frame> recordedData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordedData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<VPReplay.Frame>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordedData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string notes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notes);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notes), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112490, XrefRangeEnd = 112491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPReplayAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPReplayAsset()
	{
		Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPReplayAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr);
		NativeFieldInfoPtr_timeStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "timeStep");
		NativeFieldInfoPtr_vehicleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "vehicleName");
		NativeFieldInfoPtr_sceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "sceneName");
		NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "velocity");
		NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "angularVelocity");
		NativeFieldInfoPtr_recordedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "recordedData");
		NativeFieldInfoPtr_notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, "notes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayAsset>.NativeClassPtr, 100670424);
	}

	public VPReplayAsset(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
