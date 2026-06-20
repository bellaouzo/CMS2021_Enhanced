using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPGroundParticleEmitter : MonoBehaviour
{
	public enum Mode
	{
		PressureAndSkid,
		PressureAndVelocity,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_emissionRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_emissionShuffle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLifetime;

	private static readonly System.IntPtr NativeFieldInfoPtr_minVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelVelocityRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireVelocityRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color1;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color2;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_particles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_emitParams;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EmitParticle_Public_Single_Vector3_Vector3_Vector3_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr));

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
		}
	}

	public unsafe float emissionRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionRate)) = num;
		}
	}

	public unsafe float emissionShuffle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionShuffle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionShuffle)) = num;
		}
	}

	public unsafe float maxLifetime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLifetime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLifetime)) = num;
		}
	}

	public unsafe float minVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVelocity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVelocity)) = num;
		}
	}

	public unsafe float maxVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVelocity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVelocity)) = num;
		}
	}

	public unsafe float wheelVelocityRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelVelocityRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelVelocityRatio)) = num;
		}
	}

	public unsafe float tireVelocityRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireVelocityRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireVelocityRatio)) = num;
		}
	}

	public unsafe Color Color1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color1)) = color;
		}
	}

	public unsafe Color Color2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color2);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color2)) = color;
		}
	}

	public unsafe bool randomColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomColor)) = flag;
		}
	}

	public unsafe ParticleSystem m_particles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_particles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ParticleSystem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_particles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ParticleSystem.EmitParams m_emitParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_emitParams);
			return *(ParticleSystem.EmitParams*)num;
		}
		set
		{
			*(ParticleSystem.EmitParams*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_emitParams)) = emitParams;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111260, XrefRangeEnd = 111268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111295, RefRangeEnd = 111296, XrefRangeStart = 111268, XrefRangeEnd = 111295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EmitParticle(Vector3 position, Vector3 wheelVelocity, Vector3 tireVelocity, float pressureRatio, float intensityRatio, float lastParticleTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&position);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wheelVelocity;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tireVelocity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pressureRatio;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &intensityRatio;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastParticleTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EmitParticle_Public_Single_Vector3_Vector3_Vector3_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111296, XrefRangeEnd = 111299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPGroundParticleEmitter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPGroundParticleEmitter()
	{
		Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPGroundParticleEmitter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_emissionRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "emissionRate");
		NativeFieldInfoPtr_emissionShuffle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "emissionShuffle");
		NativeFieldInfoPtr_maxLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "maxLifetime");
		NativeFieldInfoPtr_minVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "minVelocity");
		NativeFieldInfoPtr_maxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "maxVelocity");
		NativeFieldInfoPtr_wheelVelocityRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "wheelVelocityRatio");
		NativeFieldInfoPtr_tireVelocityRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "tireVelocityRatio");
		NativeFieldInfoPtr_Color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "Color1");
		NativeFieldInfoPtr_Color2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "Color2");
		NativeFieldInfoPtr_randomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "randomColor");
		NativeFieldInfoPtr_m_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "m_particles");
		NativeFieldInfoPtr_m_emitParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, "m_emitParams");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, 100670317);
		NativeMethodInfoPtr_EmitParticle_Public_Single_Vector3_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, 100670318);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPGroundParticleEmitter>.NativeClassPtr, 100670319);
	}

	public VPGroundParticleEmitter(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
