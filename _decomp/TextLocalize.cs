using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class TextLocalize : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizeOnAwake;

	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyXbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyPlaystation;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyPlaystation5;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyDemo;

	private static readonly System.IntPtr NativeFieldInfoPtr_capitalLetters;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCapitalLetters_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanLocalize_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Localize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedText_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedTextOffline_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalizeOffline_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr));

	public unsafe bool LocalizeOnAwake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizeOnAwake);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizeOnAwake)) = flag;
		}
	}

	public unsafe string key
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string keyXbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyXbox);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyXbox), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string keyPlaystation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyPlaystation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyPlaystation), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string keyPlaystation5
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyPlaystation5);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyPlaystation5), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string keyDemo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyDemo);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyDemo), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool capitalLetters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capitalLetters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capitalLetters)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98452, XrefRangeEnd = 98453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98453, XrefRangeEnd = 98454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetText(string _key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe string GetKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe bool GetCapitalLetters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCapitalLetters_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98456, RefRangeEnd = 98458, XrefRangeStart = 98454, XrefRangeEnd = 98456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanLocalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanLocalize_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 98464, RefRangeEnd = 98469, XrefRangeStart = 98458, XrefRangeEnd = 98464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Localize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Localize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98469, XrefRangeEnd = 98470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalizedText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98470, XrefRangeEnd = 98471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalizedTextOffline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedTextOffline_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98471, XrefRangeEnd = 98477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LocalizeOffline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalizeOffline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98477, XrefRangeEnd = 98486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextLocalize()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TextLocalize()
	{
		Il2CppClassPointerStore<TextLocalize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TextLocalize");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr);
		NativeFieldInfoPtr_LocalizeOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "LocalizeOnAwake");
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "key");
		NativeFieldInfoPtr_keyXbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "keyXbox");
		NativeFieldInfoPtr_keyPlaystation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "keyPlaystation");
		NativeFieldInfoPtr_keyPlaystation5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "keyPlaystation5");
		NativeFieldInfoPtr_keyDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "keyDemo");
		NativeFieldInfoPtr_capitalLetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, "capitalLetters");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669094);
		NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669095);
		NativeMethodInfoPtr_GetKey_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669096);
		NativeMethodInfoPtr_GetCapitalLetters_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669097);
		NativeMethodInfoPtr_CanLocalize_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669098);
		NativeMethodInfoPtr_Localize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669099);
		NativeMethodInfoPtr_GetLocalizedText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669100);
		NativeMethodInfoPtr_GetLocalizedTextOffline_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669101);
		NativeMethodInfoPtr_LocalizeOffline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669102);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextLocalize>.NativeClassPtr, 100669103);
	}

	public TextLocalize(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
