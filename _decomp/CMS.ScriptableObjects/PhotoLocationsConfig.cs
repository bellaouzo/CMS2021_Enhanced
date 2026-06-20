using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.ScriptableObjects;

public class PhotoLocationsConfig : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PhotoLocations;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PhotoLocationsConfig>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<PhotoLocation> PhotoLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhotoLocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<PhotoLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PhotoLocations), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PhotoLocationsConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoLocationsConfig>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PhotoLocationsConfig()
	{
		Il2CppClassPointerStore<PhotoLocationsConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ScriptableObjects", "PhotoLocationsConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoLocationsConfig>.NativeClassPtr);
		NativeFieldInfoPtr_PhotoLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocationsConfig>.NativeClassPtr, "PhotoLocations");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoLocationsConfig>.NativeClassPtr, 100680287);
	}

	public PhotoLocationsConfig(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
