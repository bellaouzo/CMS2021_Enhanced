using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Platforms.Base;
using Il2CppSystem;
using Steamworks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Platforms.Steam;

public class SteamKeyboard : BaseKeyboard
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gamepadTextInputDismissed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGamePadTextInputDismissed_Private_Void_GamepadTextInputDismissed_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Void_String_String_String_VirtualKeyboardType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Void_String_String_String_VirtualKeyboardType_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr));

	public unsafe Callback<GamepadTextInputDismissed_t> gamepadTextInputDismissed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadTextInputDismissed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Callback<GamepadTextInputDismissed_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadTextInputDismissed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227894, XrefRangeEnd = 227907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Init_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227907, XrefRangeEnd = 227914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGamePadTextInputDismissed(GamepadTextInputDismissed_t param)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&param);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGamePadTextInputDismissed_Private_Void_GamepadTextInputDismissed_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227914, XrefRangeEnd = 227920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void Show([Optional][DefaultParameterValue("")] string defaultText, [Optional][DefaultParameterValue("")] string title, [Optional][DefaultParameterValue("")] string description, [Optional] VirtualKeyboardType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(VirtualKeyboardType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Void_String_String_String_VirtualKeyboardType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227920, XrefRangeEnd = 227921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Show([Optional][DefaultParameterValue("")] string defaultText, [Optional][DefaultParameterValue("")] string title, [Optional][DefaultParameterValue("")] string description, [Optional] VirtualKeyboardType type, [Optional] uint maxLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(VirtualKeyboardType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Void_String_String_String_VirtualKeyboardType_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SteamKeyboard()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SteamKeyboard()
	{
		Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.Steam", "SteamKeyboard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr);
		NativeFieldInfoPtr_gamepadTextInputDismissed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, "gamepadTextInputDismissed");
		NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680414);
		NativeMethodInfoPtr_OnGamePadTextInputDismissed_Private_Void_GamepadTextInputDismissed_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680415);
		NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680416);
		NativeMethodInfoPtr_Show_Public_Virtual_Void_String_String_String_VirtualKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680417);
		NativeMethodInfoPtr_Show_Public_Virtual_Void_String_String_String_VirtualKeyboardType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680418);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680419);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamKeyboard>.NativeClassPtr, 100680420);
	}

	public SteamKeyboard(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
