using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CapSize : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinRenderer;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CapSize>.NativeClassPtr));

	public unsafe float minScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minScale)) = num;
		}
	}

	public unsafe float maxScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxScale)) = num;
		}
	}

	public unsafe SkinnedMeshRenderer skinRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SkinnedMeshRenderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 19745, RefRangeEnd = 19754, XrefRangeStart = 19734, XrefRangeEnd = 19745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19754, XrefRangeEnd = 19757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CapSize()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CapSize>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CapSize()
	{
		Il2CppClassPointerStore<CapSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CapSize");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CapSize>.NativeClassPtr);
		NativeFieldInfoPtr_minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapSize>.NativeClassPtr, "minScale");
		NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapSize>.NativeClassPtr, "maxScale");
		NativeFieldInfoPtr_skinRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CapSize>.NativeClassPtr, "skinRenderer");
		NativeMethodInfoPtr_Resize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapSize>.NativeClassPtr, 100664750);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CapSize>.NativeClassPtr, 100664751);
	}

	public CapSize(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
