using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class RotationInput : MonoBehaviour
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
			Il2CppClassPointerStore<InputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "InputSource");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_source;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseButtonForDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseButtonExclusive;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rot;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDefaultsImmediate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RotationInput>.NativeClassPtr));

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

	public unsafe string horizontalAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string verticalAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalAxis);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalAxis), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int mouseButtonForDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseButtonForDrag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseButtonForDrag)) = num;
		}
	}

	public unsafe bool mouseButtonExclusive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseButtonExclusive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseButtonExclusive)) = flag;
		}
	}

	public unsafe float horizontalSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSensitivity)) = num;
		}
	}

	public unsafe float verticalSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalSensitivity)) = num;
		}
	}

	public unsafe float horizontalDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalDefault);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalDefault)) = num;
		}
	}

	public unsafe float verticalDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalDefault);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalDefault)) = num;
		}
	}

	public unsafe RotationController m_rot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RotationController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rot), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109500, XrefRangeEnd = 109503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 109505, RefRangeEnd = 109508, XrefRangeStart = 109503, XrefRangeEnd = 109505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Move(Vector2 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Move_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109508, XrefRangeEnd = 109517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109517, XrefRangeEnd = 109524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDefaultsImmediate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDefaultsImmediate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109524, XrefRangeEnd = 109535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessStandardInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109535, XrefRangeEnd = 109546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109546, XrefRangeEnd = 109547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrag(Vector2 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109547, XrefRangeEnd = 109554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RotationInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RotationInput()
	{
		Il2CppClassPointerStore<RotationInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RotationInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationInput>.NativeClassPtr);
		NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "source");
		NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "horizontalAxis");
		NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "verticalAxis");
		NativeFieldInfoPtr_mouseButtonForDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "mouseButtonForDrag");
		NativeFieldInfoPtr_mouseButtonExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "mouseButtonExclusive");
		NativeFieldInfoPtr_horizontalSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "horizontalSensitivity");
		NativeFieldInfoPtr_verticalSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "verticalSensitivity");
		NativeFieldInfoPtr_horizontalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "horizontalDefault");
		NativeFieldInfoPtr_verticalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "verticalDefault");
		NativeFieldInfoPtr_m_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, "m_rot");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670197);
		NativeMethodInfoPtr_Move_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670198);
		NativeMethodInfoPtr_ResetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670199);
		NativeMethodInfoPtr_ResetDefaultsImmediate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670200);
		NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670201);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670202);
		NativeMethodInfoPtr_OnDrag_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670203);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationInput>.NativeClassPtr, 100670204);
	}

	public RotationInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
