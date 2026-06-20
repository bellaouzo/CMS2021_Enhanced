using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class GroundMaterialManagerBase : MonoBehaviour
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroundMaterial_Public_Abstract_Virtual_New_GroundMaterial_PhysicMaterial_VehicleBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroundMaterialCached_Public_Void_PhysicMaterial_VehicleBase_byref_PhysicMaterial_byref_GroundMaterial_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe GroundMaterial GetGroundMaterial(PhysicMaterial physicMaterial, VehicleBase vehicle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(physicMaterial);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetGroundMaterial_Public_Abstract_Virtual_New_GroundMaterial_PhysicMaterial_VehicleBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GroundMaterial(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123038, RefRangeEnd = 123040, XrefRangeStart = 123022, XrefRangeEnd = 123038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetGroundMaterialCached(PhysicMaterial physicMaterial, VehicleBase vehicle, ref PhysicMaterial cachedMaterial, ref GroundMaterial groundMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(physicMaterial);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedMaterial);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(groundMaterial);
		*(System.IntPtr**)num2 = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroundMaterialCached_Public_Void_PhysicMaterial_VehicleBase_byref_PhysicMaterial_byref_GroundMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		cachedMaterial = ((intPtr4 == (System.IntPtr)0) ? null : new PhysicMaterial(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		groundMaterial = ((intPtr5 == (System.IntPtr)0) ? null : new GroundMaterial(intPtr5));
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe GroundMaterialManagerBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GroundMaterialManagerBase()
	{
		Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "GroundMaterialManagerBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr);
		NativeMethodInfoPtr_GetGroundMaterial_Public_Abstract_Virtual_New_GroundMaterial_PhysicMaterial_VehicleBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr, 100671210);
		NativeMethodInfoPtr_GetGroundMaterialCached_Public_Void_PhysicMaterial_VehicleBase_byref_PhysicMaterial_byref_GroundMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr, 100671211);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroundMaterialManagerBase>.NativeClassPtr, 100671212);
	}

	public GroundMaterialManagerBase(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
