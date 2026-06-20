using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

[System.Serializable]
public class SceneObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabName;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_idParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_active;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_localScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectComponents;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SceneObject>.NativeClassPtr));

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

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

	public unsafe bool active
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active)) = flag;
		}
	}

	public unsafe Vector3 position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = vector;
		}
	}

	public unsafe Vector3 localScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localScale)) = vector;
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = quaternion;
		}
	}

	public unsafe List<ObjectComponent> objectComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectComponents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<ObjectComponent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectComponents), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120802, XrefRangeEnd = 120808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SceneObject()
	{
		Il2CppClassPointerStore<SceneObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "SceneObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneObject>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "name");
		NativeFieldInfoPtr_prefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "prefabName");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "id");
		NativeFieldInfoPtr_idParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "idParent");
		NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "active");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "position");
		NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "localScale");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_objectComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, "objectComponents");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObject>.NativeClassPtr, 100671034);
	}

	public SceneObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
