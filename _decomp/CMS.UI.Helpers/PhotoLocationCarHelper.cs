using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Helpers;

public class PhotoLocationCarHelper : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_carRotationVector;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCarRotationSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelsRotationVector;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWheelsRotationSet;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetCarRotation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCarRotation_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCarRotation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentCarRotation_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultRotation_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetWheelsSteeringAngle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWheelsSteeringAngle_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentWheelsAngle_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr));

	public unsafe CarLoader carLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 carRotationVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carRotationVector);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carRotationVector)) = vector;
		}
	}

	public unsafe bool isCarRotationSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCarRotationSet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCarRotationSet)) = flag;
		}
	}

	public unsafe Vector3 wheelsRotationVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelsRotationVector);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelsRotationVector)) = vector;
		}
	}

	public unsafe bool isWheelsRotationSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWheelsRotationSet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWheelsRotationSet)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207312, XrefRangeEnd = 207314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCarRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetCarRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 207328, RefRangeEnd = 207331, XrefRangeStart = 207314, XrefRangeEnd = 207328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCarRotation(float rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rotation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCarRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207331, XrefRangeEnd = 207344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCarRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCarRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetCurrentCarRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentCarRotation_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetDefaultRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultRotation_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207344, XrefRangeEnd = 207345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetWheelsSteeringAngle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetWheelsSteeringAngle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 207358, RefRangeEnd = 207362, XrefRangeStart = 207345, XrefRangeEnd = 207358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWheelsSteeringAngle(float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWheelsSteeringAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetCurrentWheelsAngle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentWheelsAngle_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PhotoLocationCarHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PhotoLocationCarHelper()
	{
		Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "PhotoLocationCarHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr);
		NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, "carLoader");
		NativeFieldInfoPtr_carRotationVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, "carRotationVector");
		NativeFieldInfoPtr_isCarRotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, "isCarRotationSet");
		NativeFieldInfoPtr_wheelsRotationVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, "wheelsRotationVector");
		NativeFieldInfoPtr_isWheelsRotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, "isWheelsRotationSet");
		NativeMethodInfoPtr_ResetCarRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678772);
		NativeMethodInfoPtr_SetCarRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678773);
		NativeMethodInfoPtr_UpdateCarRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678774);
		NativeMethodInfoPtr_GetCurrentCarRotation_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678775);
		NativeMethodInfoPtr_GetDefaultRotation_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678776);
		NativeMethodInfoPtr_ResetWheelsSteeringAngle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678777);
		NativeMethodInfoPtr_SetWheelsSteeringAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678778);
		NativeMethodInfoPtr_GetCurrentWheelsAngle_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678779);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationCarHelper>.NativeClassPtr, 100678780);
	}

	public PhotoLocationCarHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
