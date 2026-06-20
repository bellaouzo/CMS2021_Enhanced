using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace ArtIsDark;

[System.Serializable]
public class ShaderKeywords : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_shaderName;

	private static readonly System.IntPtr NativeFieldInfoPtr_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_keywordsUsedList;

	private static readonly System.IntPtr NativeFieldInfoPtr_expand;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr));

	public unsafe string shaderName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe List<string> keywordsUsedList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keywordsUsedList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keywordsUsedList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool expand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expand);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expand)) = flag;
		}
	}

	public unsafe bool selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234136, XrefRangeEnd = 234142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderKeywords()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShaderKeywords()
	{
		Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "ArtIsDark", "ShaderKeywords");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
		NativeFieldInfoPtr_shaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "shaderName");
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "path");
		NativeFieldInfoPtr_keywordsUsedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "keywordsUsedList");
		NativeFieldInfoPtr_expand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "expand");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "selected");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, 100680913);
	}

	public ShaderKeywords(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
