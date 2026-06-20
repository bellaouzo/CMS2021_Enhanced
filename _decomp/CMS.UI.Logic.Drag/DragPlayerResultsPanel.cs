using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Drag;

public class DragPlayerResultsPanel : DragResultsPanel
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Single_String_Int32_List_1_DragTime_Single_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillTimes_Private_Single_List_1_DragTime_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupSpeeds_Public_Void_List_1_DragSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillSpeeds_Private_Void_List_1_DragSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199750, RefRangeEnd = 199751, XrefRangeStart = 199727, XrefRangeEnd = 199750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Setup(string carID, int config, List<DragTime> stats, float dragIndex, DragLength dragLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stats);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragIndex;
		*(DragLength**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Single_String_Int32_List_1_DragTime_Single_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199777, RefRangeEnd = 199778, XrefRangeStart = 199751, XrefRangeEnd = 199777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FillTimes(List<DragTime> stats, DragLength dragLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stats);
		*(DragLength**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillTimes_Private_Single_List_1_DragTime_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199778, XrefRangeEnd = 199779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupSpeeds(List<DragSpeed> speeds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(speeds);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupSpeeds_Public_Void_List_1_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199816, RefRangeEnd = 199818, XrefRangeStart = 199779, XrefRangeEnd = 199816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillSpeeds(List<DragSpeed> speeds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(speeds);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillSpeeds_Private_Void_List_1_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragPlayerResultsPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragPlayerResultsPanel()
	{
		Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragPlayerResultsPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr);
		NativeMethodInfoPtr_Setup_Public_Single_String_Int32_List_1_DragTime_Single_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr, 100678328);
		NativeMethodInfoPtr_FillTimes_Private_Single_List_1_DragTime_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr, 100678329);
		NativeMethodInfoPtr_SetupSpeeds_Public_Void_List_1_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr, 100678330);
		NativeMethodInfoPtr_FillSpeeds_Private_Void_List_1_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr, 100678331);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerResultsPanel>.NativeClassPtr, 100678332);
	}

	public DragPlayerResultsPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
