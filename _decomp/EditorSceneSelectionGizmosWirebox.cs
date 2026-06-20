using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class EditorSceneSelectionGizmosWirebox : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LeftFrontTopArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftRearTopArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightFrontTopArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightRearTopArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftFrontDownArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_LeftRearDownArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightFrontDownArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightRearDownArm;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSize_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr));

	public unsafe Transform LeftFrontTopArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftFrontTopArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftFrontTopArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform LeftRearTopArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftRearTopArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftRearTopArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform RightFrontTopArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightFrontTopArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightFrontTopArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform RightRearTopArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightRearTopArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightRearTopArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform LeftFrontDownArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftFrontDownArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftFrontDownArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform LeftRearDownArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftRearDownArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftRearDownArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform RightFrontDownArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightFrontDownArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightFrontDownArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform RightRearDownArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightRearDownArm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightRearDownArm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 105666, RefRangeEnd = 105668, XrefRangeStart = 105458, XrefRangeEnd = 105666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSize(GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSize_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe EditorSceneSelectionGizmosWirebox()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EditorSceneSelectionGizmosWirebox()
	{
		Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EditorSceneSelectionGizmosWirebox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr);
		NativeFieldInfoPtr_LeftFrontTopArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "LeftFrontTopArm");
		NativeFieldInfoPtr_LeftRearTopArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "LeftRearTopArm");
		NativeFieldInfoPtr_RightFrontTopArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "RightFrontTopArm");
		NativeFieldInfoPtr_RightRearTopArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "RightRearTopArm");
		NativeFieldInfoPtr_LeftFrontDownArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "LeftFrontDownArm");
		NativeFieldInfoPtr_LeftRearDownArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "LeftRearDownArm");
		NativeFieldInfoPtr_RightFrontDownArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "RightFrontDownArm");
		NativeFieldInfoPtr_RightRearDownArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, "RightRearDownArm");
		NativeMethodInfoPtr_UpdateSize_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, 100669637);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmosWirebox>.NativeClassPtr, 100669638);
	}

	public EditorSceneSelectionGizmosWirebox(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
