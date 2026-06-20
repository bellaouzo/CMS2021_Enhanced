using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CI.TaskParallel.Core;

public class UnityThread : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__thread;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnityThread>.NativeClassPtr));

	public unsafe Thread _thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Thread(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230398, XrefRangeEnd = 230407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityThread(Il2CppSystem.Action action)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityThread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230407, XrefRangeEnd = 230409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230409, XrefRangeEnd = 230412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Abort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230412, XrefRangeEnd = 230414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Join()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Join_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UnityThread()
	{
		Il2CppClassPointerStore<UnityThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CI.TaskParallel.Core", "UnityThread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityThread>.NativeClassPtr);
		NativeFieldInfoPtr__thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityThread>.NativeClassPtr, "_thread");
		NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityThread>.NativeClassPtr, 100680760);
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityThread>.NativeClassPtr, 100680761);
		NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityThread>.NativeClassPtr, 100680762);
		NativeMethodInfoPtr_Join_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityThread>.NativeClassPtr, 100680763);
	}

	public UnityThread(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
