using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ArtIsDark;

public class ShaderKeywordsTool : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr__skipProperties;

	private static readonly System.IntPtr NativeFieldInfoPtr__skipKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalKeywordsFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialKeywordsFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialsFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalKeywords;

	private static readonly System.IntPtr NativeFieldInfoPtr_keywordsFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_showProjectKeywords;

	private static readonly System.IntPtr NativeFieldInfoPtr_showProjectShaders;

	private static readonly System.IntPtr NativeFieldInfoPtr_shaderKeywordsList;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scanForKeywords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findKeywords_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_skipProperties_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_skipKeys_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_countMaterialKeywords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeMaterialKeywords_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkMaterials_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr));

	public unsafe Il2CppStringArray _skipProperties
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipProperties);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipProperties), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray _skipKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipKeys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipKeys), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> globalKeywordsFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalKeywordsFound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalKeywordsFound), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int materialKeywordsFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialKeywordsFound);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialKeywordsFound)) = num;
		}
	}

	public unsafe int materialsFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsFound);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsFound)) = num;
		}
	}

	public unsafe string globalKeywords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalKeywords);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalKeywords), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe List<string> keywordsFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keywordsFound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keywordsFound), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool showProjectKeywords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showProjectKeywords);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showProjectKeywords)) = flag;
		}
	}

	public unsafe bool showProjectShaders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showProjectShaders);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showProjectShaders)) = flag;
		}
	}

	public unsafe List<ShaderKeywords> shaderKeywordsList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderKeywordsList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<ShaderKeywords>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shaderKeywordsList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234142, XrefRangeEnd = 234152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234152, XrefRangeEnd = 234195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void scanForKeywords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scanForKeywords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234248, RefRangeEnd = 234249, XrefRangeStart = 234195, XrefRangeEnd = 234248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findKeywords(string file)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findKeywords_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234249, XrefRangeEnd = 234251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool skipProperties(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_skipProperties_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234260, RefRangeEnd = 234261, XrefRangeStart = 234251, XrefRangeEnd = 234260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool skipKeys(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_skipKeys_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234273, RefRangeEnd = 234274, XrefRangeStart = 234261, XrefRangeEnd = 234273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void countMaterialKeywords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_countMaterialKeywords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234274, XrefRangeEnd = 234286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeMaterialKeywords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeMaterialKeywords_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234316, RefRangeEnd = 234318, XrefRangeStart = 234286, XrefRangeEnd = 234316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkMaterials(string file, bool write)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &write;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkMaterials_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234318, XrefRangeEnd = 234562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderKeywordsTool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShaderKeywordsTool()
	{
		Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "ArtIsDark", "ShaderKeywordsTool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr);
		NativeFieldInfoPtr__skipProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "_skipProperties");
		NativeFieldInfoPtr__skipKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "_skipKeys");
		NativeFieldInfoPtr_globalKeywordsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "globalKeywordsFound");
		NativeFieldInfoPtr_materialKeywordsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "materialKeywordsFound");
		NativeFieldInfoPtr_materialsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "materialsFound");
		NativeFieldInfoPtr_globalKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "globalKeywords");
		NativeFieldInfoPtr_keywordsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "keywordsFound");
		NativeFieldInfoPtr_showProjectKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "showProjectKeywords");
		NativeFieldInfoPtr_showProjectShaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "showProjectShaders");
		NativeFieldInfoPtr_shaderKeywordsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, "shaderKeywordsList");
		NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680914);
		NativeMethodInfoPtr_scanForKeywords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680915);
		NativeMethodInfoPtr_findKeywords_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680916);
		NativeMethodInfoPtr_skipProperties_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680917);
		NativeMethodInfoPtr_skipKeys_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680918);
		NativeMethodInfoPtr_countMaterialKeywords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680919);
		NativeMethodInfoPtr_removeMaterialKeywords_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680920);
		NativeMethodInfoPtr_checkMaterials_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680921);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywordsTool>.NativeClassPtr, 100680922);
	}

	public ShaderKeywordsTool(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
