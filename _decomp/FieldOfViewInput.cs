using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FieldOfViewInput : MonoBehaviour
{
	public enum InputSource
	{
		StandardInput,
		Messages,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InputSource>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static InputSource()
		{
			Il2CppClassPointerStore<InputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "InputSource");
		}

	}

	public enum MoveParameter
	{
		Angle,
		Size,
		SizeProportional,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MoveParameter>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static MoveParameter()
		{
			Il2CppClassPointerStore<MoveParameter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "MoveParameter");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_source;

	private static readonly System.IntPtr NativeFieldInfoPtr_axisName;

	private static readonly System.IntPtr NativeFieldInfoPtr_parameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_angleSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_angleDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fov;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnScroll_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Scroll_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr));

	public unsafe InputSource source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
			return *(InputSource*)num;
		}
		set
		{
			*(InputSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)) = inputSource;
		}
	}

	public unsafe string axisName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe MoveParameter parameter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameter);
			return *(MoveParameter*)num;
		}
		set
		{
			*(MoveParameter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameter)) = moveParameter;
		}
	}

	public unsafe float angleSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleSensitivity)) = num;
		}
	}

	public unsafe float sizeSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeSensitivity)) = num;
		}
	}

	public unsafe float angleDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleDefault);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleDefault)) = num;
		}
	}

	public unsafe float sizeDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeDefault);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeDefault)) = num;
		}
	}

	public unsafe FieldOfViewController m_fov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fov);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new FieldOfViewController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fov), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107108, XrefRangeEnd = 107111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 107113, RefRangeEnd = 107117, XrefRangeStart = 107111, XrefRangeEnd = 107113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Move(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Move_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107117, XrefRangeEnd = 107119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107119, XrefRangeEnd = 107124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessStandardInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107124, XrefRangeEnd = 107127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107127, XrefRangeEnd = 107130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScroll(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScroll_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107130, XrefRangeEnd = 107135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Scroll(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Scroll_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107135, XrefRangeEnd = 107140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FieldOfViewInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FieldOfViewInput()
	{
		Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FieldOfViewInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr);
		NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "source");
		NativeFieldInfoPtr_axisName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "axisName");
		NativeFieldInfoPtr_parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "parameter");
		NativeFieldInfoPtr_angleSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "angleSensitivity");
		NativeFieldInfoPtr_sizeSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "sizeSensitivity");
		NativeFieldInfoPtr_angleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "angleDefault");
		NativeFieldInfoPtr_sizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "sizeDefault");
		NativeFieldInfoPtr_m_fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, "m_fov");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669794);
		NativeMethodInfoPtr_Move_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669795);
		NativeMethodInfoPtr_ResetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669796);
		NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669797);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669798);
		NativeMethodInfoPtr_OnScroll_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669799);
		NativeMethodInfoPtr_Scroll_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669800);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOfViewInput>.NativeClassPtr, 100669801);
	}

	public FieldOfViewInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
