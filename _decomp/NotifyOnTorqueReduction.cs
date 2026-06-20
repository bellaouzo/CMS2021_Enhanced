using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class NotifyOnTorqueReduction : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_driveTorqueLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_notifyAtFrameNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelName;

	private static readonly System.IntPtr NativeFieldInfoPtr_notified;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_frameNum;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr));

	public unsafe float driveTorqueLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveTorqueLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveTorqueLimit)) = num;
		}
	}

	public unsafe int notifyAtFrameNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notifyAtFrameNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notifyAtFrameNum)) = num;
		}
	}

	public unsafe string wheelName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool notified
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notified);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notified)) = flag;
		}
	}

	public unsafe int m_frameNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameNum)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117250, XrefRangeEnd = 117258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117258, XrefRangeEnd = 117263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NotifyOnTorqueReduction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NotifyOnTorqueReduction()
	{
		Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NotifyOnTorqueReduction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr);
		NativeFieldInfoPtr_driveTorqueLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, "driveTorqueLimit");
		NativeFieldInfoPtr_notifyAtFrameNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, "notifyAtFrameNum");
		NativeFieldInfoPtr_wheelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, "wheelName");
		NativeFieldInfoPtr_notified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, "notified");
		NativeFieldInfoPtr_m_frameNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, "m_frameNum");
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, 100670712);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyOnTorqueReduction>.NativeClassPtr, 100670713);
	}

	public NotifyOnTorqueReduction(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
