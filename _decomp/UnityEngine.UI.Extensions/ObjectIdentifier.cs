using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class ObjectIdentifier : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_prefabName;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_idParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontSave;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetID_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForRelatives_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr));

	public unsafe string prefabName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string idParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idParent);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idParent), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool dontSave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSave);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSave)) = flag;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120816, RefRangeEnd = 120818, XrefRangeStart = 120808, XrefRangeEnd = 120816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120860, RefRangeEnd = 120861, XrefRangeStart = 120818, XrefRangeEnd = 120860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForRelatives()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForRelatives_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ObjectIdentifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ObjectIdentifier()
	{
		Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "ObjectIdentifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr);
		NativeFieldInfoPtr_prefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, "prefabName");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, "id");
		NativeFieldInfoPtr_idParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, "idParent");
		NativeFieldInfoPtr_dontSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, "dontSave");
		NativeMethodInfoPtr_SetID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, 100671035);
		NativeMethodInfoPtr_CheckForRelatives_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, 100671036);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIdentifier>.NativeClassPtr, 100671037);
	}

	public ObjectIdentifier(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
