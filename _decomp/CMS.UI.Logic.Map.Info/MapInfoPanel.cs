using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Map.Info;

public class MapInfoPanel : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_thumbAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_problemDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapInfoPanelType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_MapInfoPanelType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProblemDescriptionActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProblemDescription_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProblemDescriptionColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterThumbEvents_Public_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterThumbEvents_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCanUseThumb_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr));

	public unsafe ThumbAction thumbAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ThumbAction(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbAction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text problemDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_problemDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_problemDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MapInfoPanelType mapInfoPanelType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapInfoPanelType);
			return *(MapInfoPanelType*)num;
		}
		set
		{
			*(MapInfoPanelType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapInfoPanelType)) = mapInfoPanelType;
		}
	}

	public unsafe MapInfoPanelType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_get_MapInfoPanelType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(MapInfoPanelType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 197108, RefRangeEnd = 197112, XrefRangeStart = 197092, XrefRangeEnd = 197108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProblemDescriptionActive(bool active = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&active);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProblemDescriptionActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 197124, RefRangeEnd = 197133, XrefRangeStart = 197112, XrefRangeEnd = 197124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProblemDescription(string description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProblemDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 197145, RefRangeEnd = 197147, XrefRangeStart = 197133, XrefRangeEnd = 197145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProblemDescriptionColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProblemDescriptionColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 197151, RefRangeEnd = 197152, XrefRangeStart = 197147, XrefRangeEnd = 197151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterThumbEvents(Il2CppSystem.Action onClick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onClick);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterThumbEvents_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 197156, RefRangeEnd = 197159, XrefRangeStart = 197152, XrefRangeEnd = 197156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterThumbEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterThumbEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 197161, RefRangeEnd = 197162, XrefRangeStart = 197159, XrefRangeEnd = 197161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCanUseThumb(bool can = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&can);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCanUseThumb_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MapInfoPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MapInfoPanel()
	{
		Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Map.Info", "MapInfoPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr);
		NativeFieldInfoPtr_thumbAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, "thumbAction");
		NativeFieldInfoPtr_problemDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, "problemDescription");
		NativeFieldInfoPtr_mapInfoPanelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, "mapInfoPanelType");
		NativeMethodInfoPtr_get_Type_Public_get_MapInfoPanelType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678055);
		NativeMethodInfoPtr_SetProblemDescriptionActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678056);
		NativeMethodInfoPtr_SetProblemDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678057);
		NativeMethodInfoPtr_SetProblemDescriptionColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678058);
		NativeMethodInfoPtr_RegisterThumbEvents_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678059);
		NativeMethodInfoPtr_UnregisterThumbEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678060);
		NativeMethodInfoPtr_SetCanUseThumb_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678061);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapInfoPanel>.NativeClassPtr, 100678062);
	}

	public MapInfoPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
