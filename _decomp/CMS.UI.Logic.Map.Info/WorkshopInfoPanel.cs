using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.UI.Controls;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Map.Info;

public class WorkshopInfoPanel : ThumbDescInfoPanel
{
	private static readonly System.IntPtr NativeFieldInfoPtr_selector;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_author;

	private static readonly System.IntPtr NativeFieldInfoPtr_customTracks;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateProblemDescription_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillSelector_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterSelectorEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterSelectorEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillTrackInfo_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAuthor_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLength_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadThumbnail_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr));

	public unsafe StringSelector selector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringSelector(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text author
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CustomTrack> customTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customTracks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<CustomTrack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customTracks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197447, XrefRangeEnd = 197467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 197495, RefRangeEnd = 197496, XrefRangeStart = 197467, XrefRangeEnd = 197495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197496, XrefRangeEnd = 197502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateProblemDescription(bool customTracksExists)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&customTracksExists);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateProblemDescription_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 197523, RefRangeEnd = 197524, XrefRangeStart = 197502, XrefRangeEnd = 197523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillSelector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197524, XrefRangeEnd = 197535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterSelectorEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterSelectorEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197535, XrefRangeEnd = 197544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterSelectorEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterSelectorEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197544, XrefRangeEnd = 197559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillTrackInfo(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillTrackInfo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197559, XrefRangeEnd = 197560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAuthor(string author)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(author);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAuthor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetLength(string length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(length);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLength_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197560, XrefRangeEnd = 197570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadThumbnail(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadThumbnail_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe WorkshopInfoPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WorkshopInfoPanel()
	{
		Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Map.Info", "WorkshopInfoPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr);
		NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, "selector");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, "length");
		NativeFieldInfoPtr_author = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, "author");
		NativeFieldInfoPtr_customTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, "customTracks");
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678088);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678089);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678090);
		NativeMethodInfoPtr_UpdateProblemDescription_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678091);
		NativeMethodInfoPtr_FillSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678092);
		NativeMethodInfoPtr_RegisterSelectorEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678093);
		NativeMethodInfoPtr_UnregisterSelectorEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678094);
		NativeMethodInfoPtr_FillTrackInfo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678095);
		NativeMethodInfoPtr_SetAuthor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678096);
		NativeMethodInfoPtr_SetLength_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678097);
		NativeMethodInfoPtr_LoadThumbnail_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678098);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopInfoPanel>.NativeClassPtr, 100678099);
	}

	public WorkshopInfoPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
