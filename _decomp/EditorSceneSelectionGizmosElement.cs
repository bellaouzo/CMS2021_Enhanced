using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class EditorSceneSelectionGizmosElement : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EditorSceneSelectionGizmos;

	private static readonly System.IntPtr NativeFieldInfoPtr_mOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mZCoord;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginDrag_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseAsWorldPoint_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr));

	public unsafe EditorSceneSelectionGizmos EditorSceneSelectionGizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorSceneSelectionGizmos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EditorSceneSelectionGizmos(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EditorSceneSelectionGizmos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 mOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mOffset)) = vector;
		}
	}

	public unsafe float mZCoord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mZCoord);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mZCoord)) = num;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 105431, RefRangeEnd = 105433, XrefRangeStart = 105420, XrefRangeEnd = 105431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Move()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Move_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105433, XrefRangeEnd = 105450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 105456, RefRangeEnd = 105458, XrefRangeStart = 105450, XrefRangeEnd = 105456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetMouseAsWorldPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseAsWorldPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe EditorSceneSelectionGizmosElement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EditorSceneSelectionGizmosElement()
	{
		Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EditorSceneSelectionGizmosElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr);
		NativeFieldInfoPtr_EditorSceneSelectionGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, "EditorSceneSelectionGizmos");
		NativeFieldInfoPtr_mOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, "mOffset");
		NativeFieldInfoPtr_mZCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, "mZCoord");
		NativeMethodInfoPtr_Move_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, 100669633);
		NativeMethodInfoPtr_BeginDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, 100669634);
		NativeMethodInfoPtr_GetMouseAsWorldPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, 100669635);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorSceneSelectionGizmosElement>.NativeClassPtr, 100669636);
	}

	public EditorSceneSelectionGizmosElement(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
