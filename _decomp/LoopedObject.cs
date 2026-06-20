using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class LoopedObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_go;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopEnd;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr));

	public unsafe bool isLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop)) = flag;
		}
	}

	public unsafe GameObject go
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource audioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float loopStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopStart)) = num;
		}
	}

	public unsafe float loopEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopEnd)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LoopedObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LoopedObject()
	{
		Il2CppClassPointerStore<LoopedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LoopedObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr);
		NativeFieldInfoPtr_isLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr, "isLoop");
		NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr, "go");
		NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr, "audioSource");
		NativeFieldInfoPtr_loopStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr, "loopStart");
		NativeFieldInfoPtr_loopEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr, "loopEnd");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopedObject>.NativeClassPtr, 100668106);
	}

	public LoopedObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
