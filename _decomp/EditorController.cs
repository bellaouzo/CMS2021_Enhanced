using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class EditorController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_postionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_postionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_postionZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleX;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleY;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EditorController;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_EditorController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedObject_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeMode_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTransformInterface_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePositionX_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePositionY_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePositionZ_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRotationX_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRotationY_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRotationZ_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeScaleX_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeScaleY_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeScaleZ_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EditorController>.NativeClassPtr));

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

	public unsafe InputField postionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postionX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postionX), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField postionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postionY);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postionY), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField postionZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postionZ);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postionZ), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField rotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField rotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField rotationZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationZ);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationZ), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField scaleX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleX), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField scaleY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleY);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleY), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField scaleZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleZ);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleZ), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static EditorController m_EditorController
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_EditorController, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new EditorController(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_EditorController, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dropdown changeMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeMode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dropdown(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeMode), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 26058, RefRangeEnd = 26061, XrefRangeStart = 26030, XrefRangeEnd = 26058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static EditorController Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_EditorController_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new EditorController(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 26275, RefRangeEnd = 26279, XrefRangeStart = 26061, XrefRangeEnd = 26275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectedObject(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26279, XrefRangeEnd = 26291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeMode(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeMode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 26379, RefRangeEnd = 26383, XrefRangeStart = 26291, XrefRangeEnd = 26379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTransformInterface()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTransformInterface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26383, XrefRangeEnd = 26418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePositionX(string newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePositionX_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26418, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePositionY(string newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePositionY_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26453, XrefRangeEnd = 26488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePositionZ(string newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePositionZ_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26488, XrefRangeEnd = 26527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeRotationX(string newRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newRotation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRotationX_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26527, XrefRangeEnd = 26566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeRotationY(string newRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newRotation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRotationY_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26566, XrefRangeEnd = 26605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeRotationZ(string newRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newRotation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeRotationZ_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26605, XrefRangeEnd = 26640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeScaleX(string newScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newScale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeScaleX_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26640, XrefRangeEnd = 26675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeScaleY(string newScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newScale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeScaleY_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26675, XrefRangeEnd = 26710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeScaleZ(string newScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newScale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeScaleZ_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26710, XrefRangeEnd = 26743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe EditorController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EditorController()
	{
		Il2CppClassPointerStore<EditorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EditorController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorController>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_postionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "postionX");
		NativeFieldInfoPtr_postionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "postionY");
		NativeFieldInfoPtr_postionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "postionZ");
		NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "rotationX");
		NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "rotationY");
		NativeFieldInfoPtr_rotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "rotationZ");
		NativeFieldInfoPtr_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "scaleX");
		NativeFieldInfoPtr_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "scaleY");
		NativeFieldInfoPtr_scaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "scaleZ");
		NativeFieldInfoPtr_m_EditorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "m_EditorController");
		NativeFieldInfoPtr_changeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "changeMode");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorController>.NativeClassPtr, "selected");
		NativeMethodInfoPtr_Get_Public_Static_EditorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_SetSelectedObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_ChangeMode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665092);
		NativeMethodInfoPtr_UpdateTransformInterface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665093);
		NativeMethodInfoPtr_ChangePositionX_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665094);
		NativeMethodInfoPtr_ChangePositionY_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665095);
		NativeMethodInfoPtr_ChangePositionZ_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665096);
		NativeMethodInfoPtr_ChangeRotationX_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665097);
		NativeMethodInfoPtr_ChangeRotationY_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665098);
		NativeMethodInfoPtr_ChangeRotationZ_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665099);
		NativeMethodInfoPtr_ChangeScaleX_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665100);
		NativeMethodInfoPtr_ChangeScaleY_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665101);
		NativeMethodInfoPtr_ChangeScaleZ_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665102);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665103);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorController>.NativeClassPtr, 100665104);
	}

	public EditorController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
