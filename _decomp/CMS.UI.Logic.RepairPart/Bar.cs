using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.RepairPart;

public class Bar : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_plus;

	private static readonly System.IntPtr NativeFieldInfoPtr_plusPlus;

	private static readonly System.IntPtr NativeFieldInfoPtr_minus;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_Image;

	private static readonly System.IntPtr NativeFieldInfoPtr_forScraps;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForScraps_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Bar>.NativeClassPtr));

	public unsafe GameObject plus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject plusPlus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plusPlus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plusPlus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject minus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minus), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Image Image
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Image);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool forScraps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forScraps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forScraps)) = flag;
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
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 191283, RefRangeEnd = 191294, XrefRangeStart = 191262, XrefRangeEnd = 191283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	public unsafe void SetForScraps(bool scraps = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scraps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForScraps_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Bar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bar>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Bar()
	{
		Il2CppClassPointerStore<Bar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.RepairPart", "Bar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bar>.NativeClassPtr);
		NativeFieldInfoPtr_plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bar>.NativeClassPtr, "plus");
		NativeFieldInfoPtr_plusPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bar>.NativeClassPtr, "plusPlus");
		NativeFieldInfoPtr_minus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bar>.NativeClassPtr, "minus");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bar>.NativeClassPtr, "type");
		NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bar>.NativeClassPtr, "Image");
		NativeFieldInfoPtr_forScraps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bar>.NativeClassPtr, "forScraps");
		NativeMethodInfoPtr_get_Type_Public_get_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bar>.NativeClassPtr, 100677470);
		NativeMethodInfoPtr_set_Type_Public_set_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bar>.NativeClassPtr, 100677471);
		NativeMethodInfoPtr_SetForScraps_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bar>.NativeClassPtr, 100677472);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bar>.NativeClassPtr, 100677473);
	}

	public Bar(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
