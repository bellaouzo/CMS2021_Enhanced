using System;
using System.Runtime.CompilerServices;
using CMS.FileSupport.INI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class DebugFileParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_debugConfigFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DebugFileParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseFile_Public_ArrayOf_DebugFile_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseAutoFill_Private_Boolean_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseCount_Private_Boolean_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMethods_Private_ArrayOf_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMethodsActions_Private_ArrayOf_String_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseToggles_Private_ArrayOf_DebugToggle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseScenes_Private_ArrayOf_SceneType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr));

	public unsafe IniData debugConfigFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugConfigFile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugConfigFile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static DebugFileParser instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new DebugFileParser(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static DebugFileParser Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94708, XrefRangeEnd = 94716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_DebugFileParser_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new DebugFileParser(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94716, XrefRangeEnd = 94812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<DebugFile> ParseFile(TextAsset textAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(textAsset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFile_Public_ArrayOf_DebugFile_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DebugFile>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94812, XrefRangeEnd = 94815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ParseAutoFill(string section, out string autoFill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(autoFill);
		*(System.IntPtr**)num = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseAutoFill_Private_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		autoFill = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94815, XrefRangeEnd = 94820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ParseCount(string section, out int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseCount_Private_Boolean_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94820, XrefRangeEnd = 94827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray ParseMethods(string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMethods_Private_ArrayOf_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94842, RefRangeEnd = 94843, XrefRangeStart = 94827, XrefRangeEnd = 94842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray ParseMethodsActions(string section, Il2CppStringArray methods)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(methods);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMethodsActions_Private_ArrayOf_String_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94861, RefRangeEnd = 94862, XrefRangeStart = 94843, XrefRangeEnd = 94861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<DebugToggle> ParseToggles(string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseToggles_Private_ArrayOf_DebugToggle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DebugToggle>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94898, RefRangeEnd = 94899, XrefRangeStart = 94862, XrefRangeEnd = 94898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<SceneType> ParseScenes(string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseScenes_Private_ArrayOf_SceneType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<SceneType>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DebugFileParser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DebugFileParser()
	{
		Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DebugFileParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr);
		NativeFieldInfoPtr_debugConfigFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, "debugConfigFile");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, "instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_DebugFileParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668797);
		NativeMethodInfoPtr_ParseFile_Public_ArrayOf_DebugFile_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668798);
		NativeMethodInfoPtr_ParseAutoFill_Private_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668799);
		NativeMethodInfoPtr_ParseCount_Private_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668800);
		NativeMethodInfoPtr_ParseMethods_Private_ArrayOf_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668801);
		NativeMethodInfoPtr_ParseMethodsActions_Private_ArrayOf_String_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668802);
		NativeMethodInfoPtr_ParseToggles_Private_ArrayOf_DebugToggle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668803);
		NativeMethodInfoPtr_ParseScenes_Private_ArrayOf_SceneType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668804);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFileParser>.NativeClassPtr, 100668805);
	}

	public DebugFileParser(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
