using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Platforms.Base;

public class BaseUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentUserName_Public_Abstract_Virtual_New_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFriends_Public_Abstract_Virtual_New_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowGameStorePage_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe string GetCurrentUserName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetCurrentUserName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe Il2CppStringArray GetFriends(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetFriends_Public_Abstract_Virtual_New_ArrayOf_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void ShowGameStorePage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ShowGameStorePage_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe BaseUtils()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseUtils()
	{
		Il2CppClassPointerStore<BaseUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.Base", "BaseUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr);
		NativeMethodInfoPtr_GetCurrentUserName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr, 100680705);
		NativeMethodInfoPtr_GetFriends_Public_Abstract_Virtual_New_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr, 100680706);
		NativeMethodInfoPtr_ShowGameStorePage_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr, 100680707);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUtils>.NativeClassPtr, 100680708);
	}

	public BaseUtils(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
