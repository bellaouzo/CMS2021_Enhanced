using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class FlowLayoutGroup : LayoutGroup
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SpacingX;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpacingY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExpandHorizontalSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChildForceExpandWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChildForceExpandHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr__layoutHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr__rowList;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCenterAlign_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRightAlign_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMiddleAlign_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLowerAlign_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayout_Public_Single_Single_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRowVerticalOffset_Private_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LayoutRow_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGreatestMinimumChildWidth_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr));

	public unsafe float SpacingX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpacingX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpacingX)) = num;
		}
	}

	public unsafe float SpacingY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpacingY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpacingY)) = num;
		}
	}

	public unsafe bool ExpandHorizontalSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExpandHorizontalSpacing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExpandHorizontalSpacing)) = flag;
		}
	}

	public unsafe bool ChildForceExpandWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChildForceExpandWidth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChildForceExpandWidth)) = flag;
		}
	}

	public unsafe bool ChildForceExpandHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChildForceExpandHeight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChildForceExpandHeight)) = flag;
		}
	}

	public unsafe float _layoutHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layoutHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layoutHeight)) = num;
		}
	}

	public unsafe IList<RectTransform> _rowList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rowList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new IList<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rowList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsCenterAlign
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCenterAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsRightAlign
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRightAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsMiddleAlign
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118787, RefRangeEnd = 118788, XrefRangeStart = 118787, XrefRangeEnd = 118787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsMiddleAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsLowerAlign
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 118788, RefRangeEnd = 118791, XrefRangeStart = 118788, XrefRangeEnd = 118788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLowerAlign_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118766, XrefRangeEnd = 118775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void CalculateLayoutInputHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118775, XrefRangeEnd = 118779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetLayoutHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118779, XrefRangeEnd = 118783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetLayoutVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118783, XrefRangeEnd = 118787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void CalculateLayoutInputVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118838, RefRangeEnd = 118841, XrefRangeStart = 118791, XrefRangeEnd = 118838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float SetLayout(float width, int axis, bool layoutInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutInput;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayout_Public_Single_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&groupHeight);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yOffset;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentRowHeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRowVerticalOffset_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118873, RefRangeEnd = 118875, XrefRangeStart = 118841, XrefRangeEnd = 118873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(contents);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowWidth;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowHeight;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &xOffset;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &yOffset;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LayoutRow_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118875, XrefRangeEnd = 118879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGreatestMinimumChildWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGreatestMinimumChildWidth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118879, XrefRangeEnd = 118886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlowLayoutGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FlowLayoutGroup()
	{
		Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "FlowLayoutGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr);
		NativeFieldInfoPtr_SpacingX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "SpacingX");
		NativeFieldInfoPtr_SpacingY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "SpacingY");
		NativeFieldInfoPtr_ExpandHorizontalSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "ExpandHorizontalSpacing");
		NativeFieldInfoPtr_ChildForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "ChildForceExpandWidth");
		NativeFieldInfoPtr_ChildForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "ChildForceExpandHeight");
		NativeFieldInfoPtr__layoutHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "_layoutHeight");
		NativeFieldInfoPtr__rowList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, "_rowList");
		NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670828);
		NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670829);
		NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670830);
		NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670831);
		NativeMethodInfoPtr_get_IsCenterAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670832);
		NativeMethodInfoPtr_get_IsRightAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670833);
		NativeMethodInfoPtr_get_IsMiddleAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670834);
		NativeMethodInfoPtr_get_IsLowerAlign_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670835);
		NativeMethodInfoPtr_SetLayout_Public_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670836);
		NativeMethodInfoPtr_CalculateRowVerticalOffset_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670837);
		NativeMethodInfoPtr_LayoutRow_Protected_Void_IList_1_RectTransform_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670838);
		NativeMethodInfoPtr_GetGreatestMinimumChildWidth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670839);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowLayoutGroup>.NativeClassPtr, 100670840);
	}

	public FlowLayoutGroup(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
