using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Orders;

public class OrderIcon : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_image;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderIconType;

	private static readonly System.IntPtr NativeMethodInfoPtr_Highlight_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIconType_Public_OrderIconType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr));

	public unsafe Image image
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OrderIconType orderIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderIconType);
			return *(OrderIconType*)num;
		}
		set
		{
			*(OrderIconType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderIconType)) = orderIconType;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194798, XrefRangeEnd = 194805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Highlight(bool highlight = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&highlight);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Highlight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe OrderIconType GetIconType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIconType_Public_OrderIconType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(OrderIconType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe OrderIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OrderIcon()
	{
		Il2CppClassPointerStore<OrderIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Orders", "OrderIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr);
		NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr, "image");
		NativeFieldInfoPtr_orderIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr, "orderIconType");
		NativeMethodInfoPtr_Highlight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr, 100677832);
		NativeMethodInfoPtr_GetIconType_Public_OrderIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr, 100677833);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderIcon>.NativeClassPtr, 100677834);
	}

	public OrderIcon(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
