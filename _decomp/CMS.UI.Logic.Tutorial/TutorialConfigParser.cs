using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.FileSupport.INI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Logic.Tutorial;

public class TutorialConfigParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ini;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseForImage_Public_ImageTutorialData_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseForVideo_Public_VideoTutorialData_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSection_Private_Nullable_1_TutorialSubtitle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr));

	public unsafe IniData ini
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ini);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IniData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ini), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183726, XrefRangeEnd = 183733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImageTutorialData ParseForImage(TextAsset textAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(textAsset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseForImage_Public_ImageTutorialData_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new ImageTutorialData(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183733, XrefRangeEnd = 183742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VideoTutorialData ParseForVideo(TextAsset textAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(textAsset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseForVideo_Public_VideoTutorialData_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new VideoTutorialData(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 183760, RefRangeEnd = 183762, XrefRangeStart = 183742, XrefRangeEnd = 183760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<TutorialSubtitle> ParseSection(string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSection_Private_Nullable_1_TutorialSubtitle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new Il2CppSystem.Nullable<TutorialSubtitle>(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TutorialConfigParser()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TutorialConfigParser()
	{
		Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Tutorial", "TutorialConfigParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr);
		NativeFieldInfoPtr_ini = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr, "ini");
		NativeMethodInfoPtr_ParseForImage_Public_ImageTutorialData_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr, 100676717);
		NativeMethodInfoPtr_ParseForVideo_Public_VideoTutorialData_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr, 100676718);
		NativeMethodInfoPtr_ParseSection_Private_Nullable_1_TutorialSubtitle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr, 100676719);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialConfigParser>.NativeClassPtr, 100676720);
	}

	public TutorialConfigParser(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
