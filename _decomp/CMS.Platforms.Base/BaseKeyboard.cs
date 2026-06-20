using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Platforms.Base;

public class BaseKeyboard : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OnKeyboardFinished;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_String_String_String_VirtualKeyboardType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_String_String_String_VirtualKeyboardType_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr));

	public unsafe Il2CppSystem.Action<VirtualKeyboardResult, string> OnKeyboardFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnKeyboardFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<VirtualKeyboardResult, string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnKeyboardFinished), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Show([Optional][DefaultParameterValue("")] string defaultText, [Optional][DefaultParameterValue("")] string title, [Optional][DefaultParameterValue("")] string description, [Optional] VirtualKeyboardType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(VirtualKeyboardType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_String_String_String_VirtualKeyboardType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Show([Optional][DefaultParameterValue("")] string defaultText, [Optional][DefaultParameterValue("")] string title, [Optional][DefaultParameterValue("")] string description, [Optional] VirtualKeyboardType type, [Optional] uint maxLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(VirtualKeyboardType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_String_String_String_VirtualKeyboardType_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe BaseKeyboard()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseKeyboard()
	{
		Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.Base", "BaseKeyboard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr);
		NativeFieldInfoPtr_OnKeyboardFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, "OnKeyboardFinished");
		NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, 100680709);
		NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, 100680710);
		NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_String_String_String_VirtualKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, 100680711);
		NativeMethodInfoPtr_Show_Public_Abstract_Virtual_New_Void_String_String_String_VirtualKeyboardType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, 100680712);
		NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, 100680713);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseKeyboard>.NativeClassPtr, 100680714);
	}

	public BaseKeyboard(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
