using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class CurvedLayout : LayoutGroup
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CurveOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_centerpoint;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRadial_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr));

	public unsafe Vector3 CurveOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveOffset)) = vector;
		}
	}

	public unsafe Vector3 itemAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemAxis);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemAxis)) = vector;
		}
	}

	public unsafe float itemSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSize)) = num;
		}
	}

	public unsafe float centerpoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerpoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerpoint)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118720, XrefRangeEnd = 118722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void SetLayoutHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void SetLayoutVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118722, XrefRangeEnd = 118723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void CalculateLayoutInputVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void CalculateLayoutInputHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118762, RefRangeEnd = 118765, XrefRangeStart = 118723, XrefRangeEnd = 118762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateRadial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRadial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118765, XrefRangeEnd = 118766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurvedLayout()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CurvedLayout()
	{
		Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "CurvedLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr);
		NativeFieldInfoPtr_CurveOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, "CurveOffset");
		NativeFieldInfoPtr_itemAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, "itemAxis");
		NativeFieldInfoPtr_itemSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, "itemSize");
		NativeFieldInfoPtr_centerpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, "centerpoint");
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670821);
		NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670822);
		NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670823);
		NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670824);
		NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670825);
		NativeMethodInfoPtr_CalculateRadial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670826);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedLayout>.NativeClassPtr, 100670827);
	}

	public CurvedLayout(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
