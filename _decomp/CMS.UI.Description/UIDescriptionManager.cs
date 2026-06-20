using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Description;

public class UIDescriptionManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_descriptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeDescriptions;

	private static readonly System.IntPtr NativeFieldInfoPtr__AssignedButtonListCache_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphicRaycaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGraphicsRaycasterEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockShowingDescriptions;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AssignedButtonListCache_Public_get_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AssignedButtonListCache_Private_set_Void_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDescription_Public_Void_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterDescription_Public_Void_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDescriptionRegistered_Private_Boolean_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_UIDescription_WindowID_DescriptionVariant_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_UIDescription_AlternativeDescriptionID_DescriptionVariant_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_UIDescription_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_UIDescription_AlternativeDescriptionID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAllAlternativeDescriptions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAllAlternativeDescriptions_Public_Void_AlternativeDescriptionID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_AlternativeDescriptionID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableGraphicsRaycaster_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescriptionAsActive_Public_Void_UIDescription_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockShowingDescriptions_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanShowDescription_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyDescriptionActive_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastActiveDescription_Public_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAssignedButtonsCache_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyAssignedButtonsCache_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr));

	public unsafe List<UIDescription> descriptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<UIDescription>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LinkedList<UIDescription> activeDescriptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeDescriptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LinkedList<UIDescription>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeDescriptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe List<string> _AssignedButtonListCache_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AssignedButtonListCache_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AssignedButtonListCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GraphicRaycaster graphicRaycaster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphicRaycaster);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GraphicRaycaster(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphicRaycaster), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static UIDescriptionManager Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new UIDescriptionManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isGraphicsRaycasterEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGraphicsRaycasterEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGraphicsRaycasterEnabled)) = flag;
		}
	}

	public unsafe bool blockShowingDescriptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockShowingDescriptions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockShowingDescriptions)) = flag;
		}
	}

	public unsafe List<string> AssignedButtonListCache
	{
		[CallerCount(4)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AssignedButtonListCache_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		[CallerCount(150)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AssignedButtonListCache_Private_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209413, XrefRangeEnd = 209424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209424, XrefRangeEnd = 209427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209445, RefRangeEnd = 209446, XrefRangeStart = 209427, XrefRangeEnd = 209445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209468, RefRangeEnd = 209469, XrefRangeStart = 209446, XrefRangeEnd = 209468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209469, XrefRangeEnd = 209473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDescription(UIDescription description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDescription_Public_Void_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209473, XrefRangeEnd = 209475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterDescription(UIDescription description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterDescription_Public_Void_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 209479, RefRangeEnd = 209480, XrefRangeStart = 209475, XrefRangeEnd = 209479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDescriptionRegistered(UIDescription description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDescriptionRegistered_Private_Boolean_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209480, XrefRangeEnd = 209485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDescription Show(WindowID ID, DescriptionVariant descriptionVariant, bool hideOtherVariants = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ID);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptionVariant;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideOtherVariants;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_UIDescription_WindowID_DescriptionVariant_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209485, XrefRangeEnd = 209490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDescription Show(AlternativeDescriptionID ID, DescriptionVariant descriptionVariant, bool hideOtherVariants = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ID);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptionVariant;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideOtherVariants;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_UIDescription_AlternativeDescriptionID_DescriptionVariant_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 209495, RefRangeEnd = 209518, XrefRangeStart = 209490, XrefRangeEnd = 209495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDescription Show(WindowID ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_UIDescription_WindowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 209522, RefRangeEnd = 209525, XrefRangeStart = 209518, XrefRangeEnd = 209522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDescription Show(AlternativeDescriptionID ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_UIDescription_AlternativeDescriptionID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209525, XrefRangeEnd = 209529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 209533, RefRangeEnd = 209535, XrefRangeStart = 209529, XrefRangeEnd = 209533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAllAlternativeDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAllAlternativeDescriptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209535, XrefRangeEnd = 209539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAllAlternativeDescriptions(AlternativeDescriptionID except)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&except);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAllAlternativeDescriptions_Public_Void_AlternativeDescriptionID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 209543, RefRangeEnd = 209550, XrefRangeStart = 209539, XrefRangeEnd = 209543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide(WindowID ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_WindowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 209554, RefRangeEnd = 209556, XrefRangeStart = 209550, XrefRangeEnd = 209554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide(AlternativeDescriptionID ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_AlternativeDescriptionID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 209585, RefRangeEnd = 209593, XrefRangeStart = 209556, XrefRangeEnd = 209585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableGraphicsRaycaster(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableGraphicsRaycaster_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 209598, RefRangeEnd = 209602, XrefRangeStart = 209593, XrefRangeEnd = 209598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDescriptionAsActive(UIDescription uiDescription, bool active = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &active;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescriptionAsActive_Public_Void_UIDescription_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void BlockShowingDescriptions(bool block = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&block);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockShowingDescriptions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool CanShowDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanShowDescription_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209602, XrefRangeEnd = 209603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAnyDescriptionActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyDescriptionActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 209607, RefRangeEnd = 209611, XrefRangeStart = 209603, XrefRangeEnd = 209607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDescription GetLastActiveDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastActiveDescription_Public_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209611, XrefRangeEnd = 209619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateAssignedButtonsCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAssignedButtonsCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void DestroyAssignedButtonsCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyAssignedButtonsCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209619, XrefRangeEnd = 209632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIDescriptionManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UIDescriptionManager()
	{
		Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Description", "UIDescriptionManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr);
		NativeFieldInfoPtr_descriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "descriptions");
		NativeFieldInfoPtr_activeDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "activeDescriptions");
		NativeFieldInfoPtr__AssignedButtonListCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "<AssignedButtonListCache>k__BackingField");
		NativeFieldInfoPtr_graphicRaycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "graphicRaycaster");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_isGraphicsRaycasterEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "isGraphicsRaycasterEnabled");
		NativeFieldInfoPtr_blockShowingDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, "blockShowingDescriptions");
		NativeMethodInfoPtr_get_AssignedButtonListCache_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678893);
		NativeMethodInfoPtr_set_AssignedButtonListCache_Private_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678894);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678895);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678896);
		NativeMethodInfoPtr_UnregisterDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678897);
		NativeMethodInfoPtr_RegisterDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678898);
		NativeMethodInfoPtr_RegisterDescription_Public_Void_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678899);
		NativeMethodInfoPtr_UnregisterDescription_Public_Void_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678900);
		NativeMethodInfoPtr_IsDescriptionRegistered_Private_Boolean_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678901);
		NativeMethodInfoPtr_Show_Public_UIDescription_WindowID_DescriptionVariant_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678902);
		NativeMethodInfoPtr_Show_Public_UIDescription_AlternativeDescriptionID_DescriptionVariant_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678903);
		NativeMethodInfoPtr_Show_Public_UIDescription_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678904);
		NativeMethodInfoPtr_Show_Public_UIDescription_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678905);
		NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678906);
		NativeMethodInfoPtr_HideAllAlternativeDescriptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678907);
		NativeMethodInfoPtr_HideAllAlternativeDescriptions_Public_Void_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678908);
		NativeMethodInfoPtr_Hide_Public_Void_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678909);
		NativeMethodInfoPtr_Hide_Public_Void_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678910);
		NativeMethodInfoPtr_EnableGraphicsRaycaster_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678911);
		NativeMethodInfoPtr_SetDescriptionAsActive_Public_Void_UIDescription_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678912);
		NativeMethodInfoPtr_BlockShowingDescriptions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678913);
		NativeMethodInfoPtr_CanShowDescription_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678914);
		NativeMethodInfoPtr_IsAnyDescriptionActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678915);
		NativeMethodInfoPtr_GetLastActiveDescription_Public_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678916);
		NativeMethodInfoPtr_CreateAssignedButtonsCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678917);
		NativeMethodInfoPtr_DestroyAssignedButtonsCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678918);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDescriptionManager>.NativeClassPtr, 100678919);
	}

	public UIDescriptionManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
