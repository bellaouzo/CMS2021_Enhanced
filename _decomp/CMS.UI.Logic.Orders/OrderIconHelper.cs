using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Orders;

public static class OrderIconHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetupIcons_Public_Static_Void_OrderIconType_byref_ArrayOf_OrderIcon_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OrderIconHelper>.NativeClassPtr));

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 194813, RefRangeEnd = 194816, XrefRangeStart = 194805, XrefRangeEnd = 194813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupIcons(OrderIconType orderIconType, ref Il2CppReferenceArray<OrderIcon> orderIcons)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&orderIconType);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(orderIcons);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupIcons_Public_Static_Void_OrderIconType_byref_ArrayOf_OrderIcon_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		orderIcons = (Il2CppReferenceArray<OrderIcon>)(object)((intPtr3 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr3));
	}

	static OrderIconHelper()
	{
		Il2CppClassPointerStore<OrderIconHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Orders", "OrderIconHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderIconHelper>.NativeClassPtr);
		NativeMethodInfoPtr_SetupIcons_Public_Static_Void_OrderIconType_byref_ArrayOf_OrderIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIconHelper>.NativeClassPtr, 100677835);
	}

	public OrderIconHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
