using System;
using System.Runtime.CompilerServices;
using CMS.Managers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.DevTools.Components;

public class LiveriesProfiler : DebugMenuComponent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stats;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalState;

	private static readonly System.IntPtr NativeFieldInfoPtr_liveriesManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr));

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

	public unsafe LiveriesManager liveriesManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LiveriesManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217699, XrefRangeEnd = 217731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217731, XrefRangeEnd = 217771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217771, XrefRangeEnd = 217812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Draw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Draw_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
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
	public unsafe LiveriesProfiler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LiveriesProfiler()
	{
		Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.DevTools.Components", "LiveriesProfiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr);
		NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, "stats");
		NativeFieldInfoPtr_normalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, "normalState");
		NativeFieldInfoPtr_liveriesManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, "liveriesManager");
		NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, 100679711);
		NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, 100679712);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, 100679713);
		NativeMethodInfoPtr_Draw_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, 100679714);
		NativeMethodInfoPtr_ConvertBytesToMegabytes_Private_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, 100679715);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveriesProfiler>.NativeClassPtr, 100679716);
	}

	public LiveriesProfiler(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
