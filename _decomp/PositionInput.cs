using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class PositionInput : MonoBehaviour
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
			Il2CppClassPointerStore<InputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "InputSource");
		}

	}

	public enum OutputPlane
	{
		XZ,
		XY,
		ZY,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OutputPlane>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static OutputPlane()
		{
			Il2CppClassPointerStore<OutputPlane>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "OutputPlane");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_source;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_swapCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputAxisX;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputAxisY;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseButtonForDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseButtonExclusive;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pos;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToPlane_Public_Vector3_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMove_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PositionInput>.NativeClassPtr));

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

	public unsafe OutputPlane outputPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputPlane);
			return *(OutputPlane*)num;
		}
		set
		{
			*(OutputPlane*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputPlane)) = outputPlane;
		}
	}

	public unsafe bool swapCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swapCoordinates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swapCoordinates)) = flag;
		}
	}

	public unsafe string inputAxisX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxisX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxisX), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string inputAxisY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxisY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxisY), IL2CPP.ManagedStringToIl2Cpp(str));
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

	public unsafe Vector2 inputSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputSensitivity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputSensitivity)) = vector;
		}
	}

	public unsafe Vector2 defaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultPosition)) = vector;
		}
	}

	public unsafe PositionController m_pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PositionController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_pos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109291, XrefRangeEnd = 109294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109299, RefRangeEnd = 109301, XrefRangeStart = 109294, XrefRangeEnd = 109299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 MapToPlane(Vector2 v, Vector3 defaultPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultPos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToPlane_Public_Vector3_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109306, RefRangeEnd = 109308, XrefRangeStart = 109301, XrefRangeEnd = 109306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109308, XrefRangeEnd = 109311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 109323, RefRangeEnd = 109324, XrefRangeStart = 109311, XrefRangeEnd = 109323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessStandardInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109324, XrefRangeEnd = 109325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109325, XrefRangeEnd = 109326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMove(Vector2 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMove_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109326, XrefRangeEnd = 109337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PositionInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PositionInput()
	{
		Il2CppClassPointerStore<PositionInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PositionInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionInput>.NativeClassPtr);
		NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "source");
		NativeFieldInfoPtr_outputPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "outputPlane");
		NativeFieldInfoPtr_swapCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "swapCoordinates");
		NativeFieldInfoPtr_inputAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "inputAxisX");
		NativeFieldInfoPtr_inputAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "inputAxisY");
		NativeFieldInfoPtr_mouseButtonForDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "mouseButtonForDrag");
		NativeFieldInfoPtr_mouseButtonExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "mouseButtonExclusive");
		NativeFieldInfoPtr_inputSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "inputSensitivity");
		NativeFieldInfoPtr_defaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "defaultPosition");
		NativeFieldInfoPtr_m_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, "m_pos");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670173);
		NativeMethodInfoPtr_MapToPlane_Public_Vector3_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670174);
		NativeMethodInfoPtr_Move_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670175);
		NativeMethodInfoPtr_ResetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670176);
		NativeMethodInfoPtr_ProcessStandardInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670177);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670178);
		NativeMethodInfoPtr_OnMove_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670179);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInput>.NativeClassPtr, 100670180);
	}

	public PositionInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
