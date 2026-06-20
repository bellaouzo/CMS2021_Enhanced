using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ExtendedFlyCam : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cameraSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalMoveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowMoveFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastMoveFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevMousePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationY;

	private static readonly System.IntPtr NativeFieldInfoPtr_runUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraParent;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RotationX_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RotationX_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RotationY_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RotationY_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFocus_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr));

	public unsafe float cameraSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSensitivity)) = num;
		}
	}

	public unsafe float normalMoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMoveSpeed)) = num;
		}
	}

	public unsafe float slowMoveFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowMoveFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowMoveFactor)) = num;
		}
	}

	public unsafe float fastMoveFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastMoveFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastMoveFactor)) = num;
		}
	}

	public unsafe Vector2 prevMousePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevMousePos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevMousePos)) = vector;
		}
	}

	public unsafe float rotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX)) = num;
		}
	}

	public unsafe float rotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY)) = num;
		}
	}

	public unsafe bool runUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runUpdate)) = flag;
		}
	}

	public unsafe Transform cameraParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float RotationX
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RotationX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RotationX_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float RotationY
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RotationY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RotationY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26743, XrefRangeEnd = 26753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26753, XrefRangeEnd = 26821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26842, RefRangeEnd = 26844, XrefRangeStart = 26821, XrefRangeEnd = 26842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFocus(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFocus_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26844, XrefRangeEnd = 26847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExtendedFlyCam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ExtendedFlyCam()
	{
		Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ExtendedFlyCam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr);
		NativeFieldInfoPtr_cameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "cameraSensitivity");
		NativeFieldInfoPtr_normalMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "normalMoveSpeed");
		NativeFieldInfoPtr_slowMoveFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "slowMoveFactor");
		NativeFieldInfoPtr_fastMoveFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "fastMoveFactor");
		NativeFieldInfoPtr_prevMousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "prevMousePos");
		NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "rotationX");
		NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "rotationY");
		NativeFieldInfoPtr_runUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "runUpdate");
		NativeFieldInfoPtr_cameraParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, "cameraParent");
		NativeMethodInfoPtr_get_RotationX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665106);
		NativeMethodInfoPtr_set_RotationX_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665107);
		NativeMethodInfoPtr_get_RotationY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665108);
		NativeMethodInfoPtr_set_RotationY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665109);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665110);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665111);
		NativeMethodInfoPtr_SetFocus_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665112);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlyCam>.NativeClassPtr, 100665113);
	}

	public ExtendedFlyCam(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
public class ExtendedFlycam : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cameraSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_climbSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalMoveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowMoveFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastMoveFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_readInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationY;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr));

	public unsafe float cameraSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSensitivity)) = num;
		}
	}

	public unsafe float climbSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_climbSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_climbSpeed)) = num;
		}
	}

	public unsafe float normalMoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMoveSpeed)) = num;
		}
	}

	public unsafe float slowMoveFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowMoveFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowMoveFactor)) = num;
		}
	}

	public unsafe float fastMoveFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastMoveFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastMoveFactor)) = num;
		}
	}

	public unsafe bool readInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readInput)) = flag;
		}
	}

	public unsafe float rotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX)) = num;
		}
	}

	public unsafe float rotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43581, XrefRangeEnd = 43589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43589, XrefRangeEnd = 43744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43744, XrefRangeEnd = 43747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExtendedFlycam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ExtendedFlycam()
	{
		Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ExtendedFlycam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr);
		NativeFieldInfoPtr_cameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "cameraSensitivity");
		NativeFieldInfoPtr_climbSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "climbSpeed");
		NativeFieldInfoPtr_normalMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "normalMoveSpeed");
		NativeFieldInfoPtr_slowMoveFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "slowMoveFactor");
		NativeFieldInfoPtr_fastMoveFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "fastMoveFactor");
		NativeFieldInfoPtr_readInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "readInput");
		NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "rotationX");
		NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, "rotationY");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, 100665962);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, 100665963);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedFlycam>.NativeClassPtr, 100665964);
	}

	public ExtendedFlycam(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
