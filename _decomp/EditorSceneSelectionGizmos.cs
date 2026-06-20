using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class EditorSceneSelectionGizmos : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EditorSceneSelectionGizmosWirebox;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnGizmoMove;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelection_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelection_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectionPosition_Public_Void_Vector3_MoveType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGizmosSize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr));

	public unsafe EditorSceneSelectionGizmosWirebox EditorSceneSelectionGizmosWirebox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorSceneSelectionGizmosWirebox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EditorSceneSelectionGizmosWirebox(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorSceneSelectionGizmosWirebox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float minSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSize)) = num;
		}
	}

	public unsafe float maxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSize)) = num;
		}
	}

	public unsafe float distanceMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceMod)) = num;
		}
	}

	public unsafe GameObject currentSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelection), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action OnGizmoMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGizmoMove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGizmoMove), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105295, XrefRangeEnd = 105312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 105351, RefRangeEnd = 105353, XrefRangeStart = 105312, XrefRangeEnd = 105351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelection(GameObject selection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelection_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 105370, RefRangeEnd = 105373, XrefRangeStart = 105353, XrefRangeEnd = 105370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 105393, RefRangeEnd = 105394, XrefRangeStart = 105373, XrefRangeEnd = 105393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectionPosition(Vector3 newSelectionPosition, MoveType axis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newSelectionPosition);
		*(MoveType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectionPosition_Public_Void_Vector3_MoveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 105409, RefRangeEnd = 105410, XrefRangeStart = 105394, XrefRangeEnd = 105409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGizmosSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGizmosSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105410, XrefRangeEnd = 105417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105417, XrefRangeEnd = 105420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EditorSceneSelectionGizmos()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EditorSceneSelectionGizmos()
	{
		Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EditorSceneSelectionGizmos");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr);
		NativeFieldInfoPtr_EditorSceneSelectionGizmosWirebox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, "EditorSceneSelectionGizmosWirebox");
		NativeFieldInfoPtr_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, "minSize");
		NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, "maxSize");
		NativeFieldInfoPtr_distanceMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, "distanceMod");
		NativeFieldInfoPtr_currentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, "currentSelection");
		NativeFieldInfoPtr_OnGizmoMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, "OnGizmoMove");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669626);
		NativeMethodInfoPtr_SetSelection_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669627);
		NativeMethodInfoPtr_ClearSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669628);
		NativeMethodInfoPtr_SetSelectionPosition_Public_Void_Vector3_MoveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669629);
		NativeMethodInfoPtr_UpdateGizmosSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669630);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669631);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmos>.NativeClassPtr, 100669632);
	}

	public EditorSceneSelectionGizmos(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
