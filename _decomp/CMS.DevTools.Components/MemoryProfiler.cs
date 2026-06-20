using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using Unity.Profiling;
using UnityEngine;

namespace CMS.DevTools.Components;

public class MemoryProfiler : DebugMenuComponent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stats;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalReservedMemoryRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_gcReservedMemoryRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_systemUsedMemoryRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureMemoryRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshMemoryRecorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalState;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr));

	public unsafe Il2CppStringArray stats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ProfilerRecorder totalReservedMemoryRecorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalReservedMemoryRecorder);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalReservedMemoryRecorder)) = profilerRecorder;
		}
	}

	public unsafe ProfilerRecorder gcReservedMemoryRecorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gcReservedMemoryRecorder);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gcReservedMemoryRecorder)) = profilerRecorder;
		}
	}

	public unsafe ProfilerRecorder systemUsedMemoryRecorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_systemUsedMemoryRecorder);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_systemUsedMemoryRecorder)) = profilerRecorder;
		}
	}

	public unsafe ProfilerRecorder textureMemoryRecorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureMemoryRecorder);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureMemoryRecorder)) = profilerRecorder;
		}
	}

	public unsafe ProfilerRecorder meshMemoryRecorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshMemoryRecorder);
			return *(ProfilerRecorder*)num;
		}
		set
		{
			*(ProfilerRecorder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshMemoryRecorder)) = profilerRecorder;
		}
	}

	public unsafe GUIStyle normalState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217812, XrefRangeEnd = 217872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217872, XrefRangeEnd = 217877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217877, XrefRangeEnd = 218033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218033, XrefRangeEnd = 218074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Draw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Draw_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218074, XrefRangeEnd = 218075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double ConvertBytesToMegabytes(ulong bytes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(double*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe double ConvertBytesToMegabytes(long bytes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(double*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MemoryProfiler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MemoryProfiler()
	{
		Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.DevTools.Components", "MemoryProfiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
		NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "stats");
		NativeFieldInfoPtr_totalReservedMemoryRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "totalReservedMemoryRecorder");
		NativeFieldInfoPtr_gcReservedMemoryRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "gcReservedMemoryRecorder");
		NativeFieldInfoPtr_systemUsedMemoryRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "systemUsedMemoryRecorder");
		NativeFieldInfoPtr_textureMemoryRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "textureMemoryRecorder");
		NativeFieldInfoPtr_meshMemoryRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "meshMemoryRecorder");
		NativeFieldInfoPtr_normalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "normalState");
		NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679717);
		NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679718);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679719);
		NativeMethodInfoPtr_Draw_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679720);
		NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679721);
		NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679722);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100679723);
	}

	public MemoryProfiler(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
