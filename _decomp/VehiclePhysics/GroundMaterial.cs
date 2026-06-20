using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

[System.Serializable]
public class GroundMaterial : Il2CppSystem.Object
{
	public enum SurfaceType
	{
		Hard,
		Soft,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SurfaceType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static SurfaceType()
		{
			Il2CppClassPointerStore<SurfaceType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "SurfaceType");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_physicMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_grip;

	private static readonly System.IntPtr NativeFieldInfoPtr_drag;

	private static readonly System.IntPtr NativeFieldInfoPtr_marksRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_particleEmitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_customData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr));

	public unsafe PhysicMaterial physicMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PhysicMaterial(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float grip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grip)) = num;
		}
	}

	public unsafe float drag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag)) = num;
		}
	}

	public unsafe VPGroundMarksRenderer marksRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marksRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPGroundMarksRenderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marksRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPGroundParticleEmitter particleEmitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleEmitter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPGroundParticleEmitter(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleEmitter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SurfaceType surfaceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceType);
			return *(SurfaceType*)num;
		}
		set
		{
			*(SurfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceType)) = surfaceType;
		}
	}

	public unsafe Il2CppSystem.Object customData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe GroundMaterial()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GroundMaterial()
	{
		Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "GroundMaterial");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr);
		NativeFieldInfoPtr_physicMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "physicMaterial");
		NativeFieldInfoPtr_grip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "grip");
		NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "drag");
		NativeFieldInfoPtr_marksRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "marksRenderer");
		NativeFieldInfoPtr_particleEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "particleEmitter");
		NativeFieldInfoPtr_surfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "surfaceType");
		NativeFieldInfoPtr_customData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, "customData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroundMaterial>.NativeClassPtr, 100671209);
	}

	public GroundMaterial(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
