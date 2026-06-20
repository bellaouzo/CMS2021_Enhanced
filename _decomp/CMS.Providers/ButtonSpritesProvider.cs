using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Providers;

public class ButtonSpritesProvider : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PCButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_XboxButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_PS4Buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_PS5Buttons;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonByName_Public_Sprite_String_PlaystationControllerState_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonName_Private_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnnecessaryButtons_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePCButtons_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveXboxButtons_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePS4Buttons_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePS5Buttons_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadButtons_Public_Void_List_1_SpriteContainer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr));

	public unsafe List<SpriteContainer> PCButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PCButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SpriteContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PCButtons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<SpriteContainer> XboxButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XboxButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SpriteContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XboxButtons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<SpriteContainer> PS4Buttons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PS4Buttons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SpriteContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PS4Buttons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<SpriteContainer> PS5Buttons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PS5Buttons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SpriteContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PS5Buttons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 139238, RefRangeEnd = 139246, XrefRangeStart = 139220, XrefRangeEnd = 139238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetButtonByName(string buttonName, [Optional] PlaystationControllerState playstationControllerState, bool isControllerUsed = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		*(PlaystationControllerState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playstationControllerState;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isControllerUsed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonByName_Public_Sprite_String_PlaystationControllerState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 139255, RefRangeEnd = 139256, XrefRangeStart = 139246, XrefRangeEnd = 139255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetButtonName(string button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void RemoveUnnecessaryButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUnnecessaryButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139256, XrefRangeEnd = 139263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePCButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePCButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139263, XrefRangeEnd = 139270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveXboxButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveXboxButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139270, XrefRangeEnd = 139277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePS4Buttons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePS4Buttons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139277, XrefRangeEnd = 139284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePS5Buttons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePS5Buttons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 139302, RefRangeEnd = 139303, XrefRangeStart = 139284, XrefRangeEnd = 139302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReloadButtons(List<SpriteContainer> range, int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadButtons_Public_Void_List_1_SpriteContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ButtonSpritesProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ButtonSpritesProvider()
	{
		Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Providers", "ButtonSpritesProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr);
		NativeFieldInfoPtr_PCButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, "PCButtons");
		NativeFieldInfoPtr_XboxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, "XboxButtons");
		NativeFieldInfoPtr_PS4Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, "PS4Buttons");
		NativeFieldInfoPtr_PS5Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, "PS5Buttons");
		NativeMethodInfoPtr_GetButtonByName_Public_Sprite_String_PlaystationControllerState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672635);
		NativeMethodInfoPtr_GetButtonName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672636);
		NativeMethodInfoPtr_RemoveUnnecessaryButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672637);
		NativeMethodInfoPtr_RemovePCButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672638);
		NativeMethodInfoPtr_RemoveXboxButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672639);
		NativeMethodInfoPtr_RemovePS4Buttons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672640);
		NativeMethodInfoPtr_RemovePS5Buttons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672641);
		NativeMethodInfoPtr_ReloadButtons_Public_Void_List_1_SpriteContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672642);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSpritesProvider>.NativeClassPtr, 100672643);
	}

	public ButtonSpritesProvider(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
