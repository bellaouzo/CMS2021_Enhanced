using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

[System.Serializable]
public class ObjectComponent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_componentName;

	private static readonly System.IntPtr NativeFieldInfoPtr_fields;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr));

	public unsafe string componentName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.Object> fields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fields);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ObjectComponent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ObjectComponent()
	{
		Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "ObjectComponent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr);
		NativeFieldInfoPtr_componentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr, "componentName");
		NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr, "fields");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectComponent>.NativeClassPtr, 100671031);
	}

	public ObjectComponent(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
