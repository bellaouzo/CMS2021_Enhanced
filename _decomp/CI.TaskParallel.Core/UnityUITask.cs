using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CI.TaskParallel.Core;

public class UnityUITask : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__action;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnityUITask>.NativeClassPtr));

	public unsafe Il2CppSystem.Action _action
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__action);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__action), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe UnityUITask(Il2CppSystem.Action action)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITask>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230414, XrefRangeEnd = 230418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UnityUITask()
	{
		Il2CppClassPointerStore<UnityUITask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CI.TaskParallel.Core", "UnityUITask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITask>.NativeClassPtr);
		NativeFieldInfoPtr__action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITask>.NativeClassPtr, "_action");
		NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITask>.NativeClassPtr, 100680764);
		NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITask>.NativeClassPtr, 100680765);
	}

	public UnityUITask(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
