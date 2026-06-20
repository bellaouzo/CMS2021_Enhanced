using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

[System.Serializable]
public class SaveGame : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_savegameName;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneObjects;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_SceneObject_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SaveGame>.NativeClassPtr));

	public unsafe string savegameName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_savegameName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_savegameName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe List<SceneObject> sceneObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SceneObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneObjects), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120786, XrefRangeEnd = 120794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveGame>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120794, XrefRangeEnd = 120802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveGame(string s, List<SceneObject> list)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveGame>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(list);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_List_1_SceneObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SaveGame()
	{
		Il2CppClassPointerStore<SaveGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "SaveGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveGame>.NativeClassPtr);
		NativeFieldInfoPtr_savegameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveGame>.NativeClassPtr, "savegameName");
		NativeFieldInfoPtr_sceneObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveGame>.NativeClassPtr, "sceneObjects");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveGame>.NativeClassPtr, 100671032);
		NativeMethodInfoPtr__ctor_Public_Void_String_List_1_SceneObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveGame>.NativeClassPtr, 100671033);
	}

	public SaveGame(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
