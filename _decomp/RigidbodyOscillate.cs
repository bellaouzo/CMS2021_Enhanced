using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class RigidbodyOscillate : MonoBehaviour
{
	public enum Mode
	{
		Sine,
		Perlin,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_xOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_xOscillation;

	private static readonly System.IntPtr NativeFieldInfoPtr_xMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_xAmplitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_xFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_xAbsolute;

	private static readonly System.IntPtr NativeFieldInfoPtr_yOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_yOscillation;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_yAmplitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_yFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_yAbsolute;

	private static readonly System.IntPtr NativeFieldInfoPtr_zOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_zOscillation;

	private static readonly System.IntPtr NativeFieldInfoPtr_zMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_zAmplitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_zFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_zAbsolute;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_startPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_isKinematic;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOscillation_Private_Single_Mode_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr));

	public unsafe float xOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xOffset)) = num;
		}
	}

	public unsafe bool xOscillation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xOscillation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xOscillation)) = flag;
		}
	}

	public unsafe Mode xMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMode)) = mode;
		}
	}

	public unsafe float xAmplitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xAmplitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xAmplitude)) = num;
		}
	}

	public unsafe float xFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xFrequency)) = num;
		}
	}

	public unsafe bool xAbsolute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xAbsolute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xAbsolute)) = flag;
		}
	}

	public unsafe float yOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yOffset)) = num;
		}
	}

	public unsafe bool yOscillation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yOscillation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yOscillation)) = flag;
		}
	}

	public unsafe Mode yMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMode)) = mode;
		}
	}

	public unsafe float yAmplitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yAmplitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yAmplitude)) = num;
		}
	}

	public unsafe float yFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yFrequency)) = num;
		}
	}

	public unsafe bool yAbsolute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yAbsolute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yAbsolute)) = flag;
		}
	}

	public unsafe float zOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zOffset)) = num;
		}
	}

	public unsafe bool zOscillation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zOscillation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zOscillation)) = flag;
		}
	}

	public unsafe Mode zMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zMode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zMode)) = mode;
		}
	}

	public unsafe float zAmplitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zAmplitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zAmplitude)) = num;
		}
	}

	public unsafe float zFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zFrequency)) = num;
		}
	}

	public unsafe bool zAbsolute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zAbsolute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zAbsolute)) = flag;
		}
	}

	public unsafe Rigidbody m_rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_startPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startPos)) = vector;
		}
	}

	public unsafe Vector3 m_time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_time);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_time)) = vector;
		}
	}

	public unsafe bool m_isKinematic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isKinematic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isKinematic)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117433, XrefRangeEnd = 117444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117444, XrefRangeEnd = 117448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117448, XrefRangeEnd = 117468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117468, XrefRangeEnd = 117471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetOscillation(Mode mode, float x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mode);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOscillation_Private_Single_Mode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117471, XrefRangeEnd = 117474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RigidbodyOscillate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RigidbodyOscillate()
	{
		Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RigidbodyOscillate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr);
		NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "xOffset");
		NativeFieldInfoPtr_xOscillation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "xOscillation");
		NativeFieldInfoPtr_xMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "xMode");
		NativeFieldInfoPtr_xAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "xAmplitude");
		NativeFieldInfoPtr_xFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "xFrequency");
		NativeFieldInfoPtr_xAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "xAbsolute");
		NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "yOffset");
		NativeFieldInfoPtr_yOscillation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "yOscillation");
		NativeFieldInfoPtr_yMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "yMode");
		NativeFieldInfoPtr_yAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "yAmplitude");
		NativeFieldInfoPtr_yFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "yFrequency");
		NativeFieldInfoPtr_yAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "yAbsolute");
		NativeFieldInfoPtr_zOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "zOffset");
		NativeFieldInfoPtr_zOscillation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "zOscillation");
		NativeFieldInfoPtr_zMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "zMode");
		NativeFieldInfoPtr_zAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "zAmplitude");
		NativeFieldInfoPtr_zFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "zFrequency");
		NativeFieldInfoPtr_zAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "zAbsolute");
		NativeFieldInfoPtr_m_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "m_rigidbody");
		NativeFieldInfoPtr_m_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "m_startPos");
		NativeFieldInfoPtr_m_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "m_time");
		NativeFieldInfoPtr_m_isKinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, "m_isKinematic");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, 100670730);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, 100670731);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, 100670732);
		NativeMethodInfoPtr_GetOscillation_Private_Single_Mode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, 100670733);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyOscillate>.NativeClassPtr, 100670734);
	}

	public RigidbodyOscillate(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
