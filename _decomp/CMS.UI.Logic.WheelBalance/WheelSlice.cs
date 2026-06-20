using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.WheelBalance;

public class WheelSlice : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_image;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanBeSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr));

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

	public unsafe bool CanBeSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanBeSuccess);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanBeSuccess)) = flag;
		}
	}

	public unsafe BarType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(BarType*)num;
		}
		set
		{
			*(BarType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = barType;
		}
	}

	public unsafe BarType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_get_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(BarType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181267, RefRangeEnd = 181269, XrefRangeStart = 181266, XrefRangeEnd = 181267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Type_Public_set_Void_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe WheelSlice()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WheelSlice()
	{
		Il2CppClassPointerStore<WheelSlice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.WheelBalance", "WheelSlice");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr);
		NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr, "image");
		NativeFieldInfoPtr_CanBeSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr, "CanBeSuccess");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr, "type");
		NativeMethodInfoPtr_get_Type_Public_get_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr, 100676503);
		NativeMethodInfoPtr_set_Type_Public_set_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr, 100676504);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelSlice>.NativeClassPtr, 100676505);
	}

	public WheelSlice(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
