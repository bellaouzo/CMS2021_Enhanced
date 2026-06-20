using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class UpgradeObjectsData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectsToTurnOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectsToTurnOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_relatedObjectsToTurnOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_relatedObjectsToTurnOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactiveObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighlightOnUnlock;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr));

	public unsafe string ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level)) = num;
		}
	}

	public unsafe List<GameObject> objectsToTurnOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToTurnOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToTurnOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<GameObject> objectsToTurnOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToTurnOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToTurnOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<GameObject> relatedObjectsToTurnOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedObjectsToTurnOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedObjectsToTurnOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<GameObject> relatedObjectsToTurnOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedObjectsToTurnOff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relatedObjectsToTurnOff), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<InteractiveObject> interactiveObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactiveObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<InteractiveObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactiveObjects), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<InteractiveObject> HighlightOnUnlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighlightOnUnlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<InteractiveObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HighlightOnUnlock), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static UpgradeObjectsData()
	{
		Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UpgradeObjectsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "level");
		NativeFieldInfoPtr_objectsToTurnOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "objectsToTurnOn");
		NativeFieldInfoPtr_objectsToTurnOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "objectsToTurnOff");
		NativeFieldInfoPtr_relatedObjectsToTurnOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "relatedObjectsToTurnOn");
		NativeFieldInfoPtr_relatedObjectsToTurnOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "relatedObjectsToTurnOff");
		NativeFieldInfoPtr_interactiveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "interactiveObjects");
		NativeFieldInfoPtr_HighlightOnUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, "HighlightOnUnlock");
	}

	public UpgradeObjectsData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe UpgradeObjectsData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<UpgradeObjectsData>.NativeClassPtr))
	{
	}
}
