using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.ScriptableObjects;

public class DLCWindowConfig : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Info;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVisibleOnCurrentPlatform_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderForCurrentPlatform_Public_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Public_Sprite_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<DLCInfo> Info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Info);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DLCInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Info), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227110, RefRangeEnd = 227112, XrefRangeStart = 227110, XrefRangeEnd = 227110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsVisibleOnCurrentPlatform(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVisibleOnCurrentPlatform_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 227112, RefRangeEnd = 227113, XrefRangeStart = 227112, XrefRangeEnd = 227112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte GetOrderForCurrentPlatform(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrderForCurrentPlatform_Public_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 227113, RefRangeEnd = 227114, XrefRangeStart = 227113, XrefRangeEnd = 227113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetIcon(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIcon_Public_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DLCWindowConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DLCWindowConfig()
	{
		Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ScriptableObjects", "DLCWindowConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr);
		NativeFieldInfoPtr_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr, "Info");
		NativeMethodInfoPtr_IsVisibleOnCurrentPlatform_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr, 100680279);
		NativeMethodInfoPtr_GetOrderForCurrentPlatform_Public_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr, 100680280);
		NativeMethodInfoPtr_GetIcon_Public_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr, 100680281);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLCWindowConfig>.NativeClassPtr, 100680282);
	}

	public DLCWindowConfig(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
