using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SuspensionTestElement : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_source;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoneTest_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr));

	public unsafe AudioSource source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86302, XrefRangeEnd = 86311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTriggerEnter(Collider col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86336, RefRangeEnd = 86337, XrefRangeStart = 86311, XrefRangeEnd = 86336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoneTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoneTest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SuspensionTestElement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SuspensionTestElement()
	{
		Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SuspensionTestElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr);
		NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr, "source");
		NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr, 100668228);
		NativeMethodInfoPtr_DoneTest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr, 100668229);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspensionTestElement>.NativeClassPtr, 100668230);
	}

	public SuspensionTestElement(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
