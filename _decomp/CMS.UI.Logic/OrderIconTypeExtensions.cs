using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic;

public static class OrderIconTypeExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_OrderIconType_OrderIconType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFlag_Public_Static_Void_byref_OrderIconType_OrderIconType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFlag_Public_Static_Void_byref_OrderIconType_OrderIconType_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OrderIconTypeExtensions>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool HasFlagFast(this OrderIconType value, OrderIconType flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(OrderIconType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_OrderIconType_OrderIconType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static void AddFlag(this ref OrderIconType value, OrderIconType flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value);
		*(OrderIconType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFlag_Public_Static_Void_byref_OrderIconType_OrderIconType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static void RemoveFlag(this ref OrderIconType value, OrderIconType flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value);
		*(OrderIconType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFlag_Public_Static_Void_byref_OrderIconType_OrderIconType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OrderIconTypeExtensions()
	{
		Il2CppClassPointerStore<OrderIconTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "OrderIconTypeExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderIconTypeExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_OrderIconType_OrderIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIconTypeExtensions>.NativeClassPtr, 100676498);
		NativeMethodInfoPtr_AddFlag_Public_Static_Void_byref_OrderIconType_OrderIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIconTypeExtensions>.NativeClassPtr, 100676499);
		NativeMethodInfoPtr_RemoveFlag_Public_Static_Void_byref_OrderIconType_OrderIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIconTypeExtensions>.NativeClassPtr, 100676500);
	}

	public OrderIconTypeExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
