using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPGroundMaterialManager : GroundMaterialManagerBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_groundMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroundMaterial_Public_Virtual_GroundMaterial_PhysicMaterial_VehicleBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<GroundMaterial> groundMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GroundMaterial>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundMaterials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GroundMaterial fallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroundMaterial(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallback), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111231, XrefRangeEnd = 111251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe GroundMaterial GetGroundMaterial(PhysicMaterial physicMaterial, VehicleBase vehicle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(physicMaterial);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetGroundMaterial_Public_Virtual_GroundMaterial_PhysicMaterial_VehicleBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GroundMaterial(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111251, XrefRangeEnd = 111260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPGroundMaterialManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPGroundMaterialManager()
	{
		Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPGroundMaterialManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr);
		NativeFieldInfoPtr_groundMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr, "groundMaterials");
		NativeFieldInfoPtr_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr, "fallback");
		NativeMethodInfoPtr_GetGroundMaterial_Public_Virtual_GroundMaterial_PhysicMaterial_VehicleBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr, 100670315);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundMaterialManager>.NativeClassPtr, 100670316);
	}

	public VPGroundMaterialManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
