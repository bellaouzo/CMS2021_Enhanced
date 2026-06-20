using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
	public enum AutoMovement
	{
		None,
		Sine,
		Triangle,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutoMovement>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static AutoMovement()
		{
			Il2CppClassPointerStore<AutoMovement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "AutoMovement");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_max;

	private static readonly System.IntPtr NativeFieldInfoPtr_min;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_rate;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoAmplitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyIncrement;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyDecrement;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rb;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_basePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_offset;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MovableObject>.NativeClassPtr));

	public unsafe float position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = num;
		}
	}

	public unsafe float max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max)) = num;
		}
	}

	public unsafe float min
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_min);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_min)) = num;
		}
	}

	public unsafe Vector3 direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = vector;
		}
	}

	public unsafe float rate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rate)) = num;
		}
	}

	public unsafe AutoMovement autoMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoMode);
			return *(AutoMovement*)num;
		}
		set
		{
			*(AutoMovement*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoMode)) = autoMovement;
		}
	}

	public unsafe float autoAmplitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoAmplitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoAmplitude)) = num;
		}
	}

	public unsafe float autoFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFrequency)) = num;
		}
	}

	public unsafe KeyCode keyIncrement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyIncrement);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyIncrement)) = keyCode;
		}
	}

	public unsafe KeyCode keyDecrement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyDecrement);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyDecrement)) = keyCode;
		}
	}

	public unsafe Rigidbody m_rb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rb);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rb), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_basePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_basePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_basePos)) = vector;
		}
	}

	public unsafe float m_offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_offset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_offset)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109605, XrefRangeEnd = 109612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109612, XrefRangeEnd = 109616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109616, XrefRangeEnd = 109641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109641, XrefRangeEnd = 109646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MovableObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovableObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MovableObject()
	{
		Il2CppClassPointerStore<MovableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MovableObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovableObject>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "position");
		NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "max");
		NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "min");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "direction");
		NativeFieldInfoPtr_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "rate");
		NativeFieldInfoPtr_autoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "autoMode");
		NativeFieldInfoPtr_autoAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "autoAmplitude");
		NativeFieldInfoPtr_autoFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "autoFrequency");
		NativeFieldInfoPtr_keyIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "keyIncrement");
		NativeFieldInfoPtr_keyDecrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "keyDecrement");
		NativeFieldInfoPtr_m_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "m_rb");
		NativeFieldInfoPtr_m_basePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "m_basePos");
		NativeFieldInfoPtr_m_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, "m_offset");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, 100670220);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, 100670221);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, 100670222);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObject>.NativeClassPtr, 100670223);
	}

	public MovableObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
