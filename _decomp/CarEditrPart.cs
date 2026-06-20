using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class CarEditrPart : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TextPartID;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToggleExist;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldColorR;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldColorG;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldColorB;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToggleExamined;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToggleSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_SupportedPart;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPartID_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSupportedPart_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSupportedPart_Public_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShouldSave_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSaveColor_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPartID_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCondition_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExist_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuality_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExamined_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectPart_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCondition_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExist_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQuality_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExamined_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr));

	public unsafe Text TextPartID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextPartID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextPartID), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField InputFieldCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldCondition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldCondition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle ToggleExist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleExist);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleExist), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text TextColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField InputFieldColorR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldColorR);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldColorR), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField InputFieldColorG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldColorG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldColorG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField InputFieldColorB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldColorB);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldColorB), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField InputFieldQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldQuality);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputFieldQuality), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle ToggleExamined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleExamined);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleExamined), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle ToggleSave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleSave);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToggleSave), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject SupportedPart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportedPart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SupportedPart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22710, XrefRangeEnd = 22711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPartID(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPartID_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22711, XrefRangeEnd = 22734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSupportedPart(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSupportedPart_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe GameObject GetSupportedPart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSupportedPart_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool ShouldSave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22734, XrefRangeEnd = 22736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShouldSave(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShouldSave_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22736, XrefRangeEnd = 22751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldSaveColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldSaveColor_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22751, XrefRangeEnd = 22752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPartID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPartID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22752, XrefRangeEnd = 22762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCondition_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetExist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExist_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22762, XrefRangeEnd = 22789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color32 GetColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color32*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22789, XrefRangeEnd = 22799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetQuality()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuality_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetExamined()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExamined_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22799, XrefRangeEnd = 22809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectPart(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectPart_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22809, XrefRangeEnd = 22816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCondition(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCondition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22816, XrefRangeEnd = 22818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExist(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExist_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22818, XrefRangeEnd = 22829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(Color val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22829, XrefRangeEnd = 22833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetQuality(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQuality_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22833, XrefRangeEnd = 22835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExamined(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExamined_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarEditrPart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarEditrPart()
	{
		Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarEditrPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr);
		NativeFieldInfoPtr_TextPartID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "TextPartID");
		NativeFieldInfoPtr_InputFieldCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "InputFieldCondition");
		NativeFieldInfoPtr_ToggleExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "ToggleExist");
		NativeFieldInfoPtr_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "TextColor");
		NativeFieldInfoPtr_InputFieldColorR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "InputFieldColorR");
		NativeFieldInfoPtr_InputFieldColorG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "InputFieldColorG");
		NativeFieldInfoPtr_InputFieldColorB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "InputFieldColorB");
		NativeFieldInfoPtr_InputFieldQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "InputFieldQuality");
		NativeFieldInfoPtr_ToggleExamined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "ToggleExamined");
		NativeFieldInfoPtr_ToggleSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "ToggleSave");
		NativeFieldInfoPtr_SupportedPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, "SupportedPart");
		NativeMethodInfoPtr_SetPartID_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664926);
		NativeMethodInfoPtr_SetSupportedPart_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664927);
		NativeMethodInfoPtr_GetSupportedPart_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664928);
		NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664929);
		NativeMethodInfoPtr_SetShouldSave_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664930);
		NativeMethodInfoPtr_ShouldSaveColor_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664931);
		NativeMethodInfoPtr_GetPartID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664932);
		NativeMethodInfoPtr_GetCondition_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664933);
		NativeMethodInfoPtr_GetExist_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664934);
		NativeMethodInfoPtr_GetColor_Public_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664935);
		NativeMethodInfoPtr_GetQuality_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664936);
		NativeMethodInfoPtr_GetExamined_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664937);
		NativeMethodInfoPtr_SelectPart_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664938);
		NativeMethodInfoPtr_SetCondition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664939);
		NativeMethodInfoPtr_SetExist_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664940);
		NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664941);
		NativeMethodInfoPtr_SetQuality_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664942);
		NativeMethodInfoPtr_SetExamined_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664943);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEditrPart>.NativeClassPtr, 100664944);
	}

	public CarEditrPart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
