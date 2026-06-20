using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPForceCones : VehicleBehaviour
{
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Cones : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_red;

		private static readonly System.IntPtr NativeFieldInfoPtr_green;

		private static readonly System.IntPtr NativeFieldInfoPtr_blue;

		private static readonly System.IntPtr NativeFieldInfoPtr_gray;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Cones>.NativeClassPtr));

		public unsafe Transform red
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_red);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_red), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Transform green
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_green);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_green), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Transform blue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blue);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blue), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Transform gray
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gray);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gray), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		static Cones()
		{
			Il2CppClassPointerStore<Cones>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "Cones");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cones>.NativeClassPtr);
			NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cones>.NativeClassPtr, "red");
			NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cones>.NativeClassPtr, "green");
			NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cones>.NativeClassPtr, "blue");
			NativeFieldInfoPtr_gray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cones>.NativeClassPtr, "gray");
		}

		public Cones(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe Cones()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Cones>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Cones>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_baseLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_showDownforce;

	private static readonly System.IntPtr NativeFieldInfoPtr_showTireForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedTireForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_useLogScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelCones;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateConeObject_Private_Transform_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaledForce_Private_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr));

	public unsafe float baseLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLength)) = num;
		}
	}

	public unsafe bool showDownforce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDownforce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDownforce)) = flag;
		}
	}

	public unsafe bool showTireForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTireForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showTireForce)) = flag;
		}
	}

	public unsafe bool combinedTireForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedTireForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedTireForce)) = flag;
		}
	}

	public unsafe bool useLogScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLogScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLogScale)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<Cones> m_wheelCones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelCones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Cones>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelCones), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113118, XrefRangeEnd = 113152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113152, XrefRangeEnd = 113165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 113271, RefRangeEnd = 113275, XrefRangeStart = 113165, XrefRangeEnd = 113271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform CreateConeObject(string name, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateConeObject_Private_Transform_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 113282, RefRangeEnd = 113286, XrefRangeStart = 113275, XrefRangeEnd = 113282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ScaledForce(float force)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaledForce_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113286, XrefRangeEnd = 113340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113340, XrefRangeEnd = 113346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPForceCones()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPForceCones()
	{
		Il2CppClassPointerStore<VPForceCones>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPForceCones");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr);
		NativeFieldInfoPtr_baseLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "baseLength");
		NativeFieldInfoPtr_showDownforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "showDownforce");
		NativeFieldInfoPtr_showTireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "showTireForce");
		NativeFieldInfoPtr_combinedTireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "combinedTireForce");
		NativeFieldInfoPtr_useLogScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "useLogScale");
		NativeFieldInfoPtr_m_wheelCones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, "m_wheelCones");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, 100670439);
		NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, 100670440);
		NativeMethodInfoPtr_CreateConeObject_Private_Transform_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, 100670441);
		NativeMethodInfoPtr_ScaledForce_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, 100670442);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, 100670443);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPForceCones>.NativeClassPtr, 100670444);
	}

	public VPForceCones(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
