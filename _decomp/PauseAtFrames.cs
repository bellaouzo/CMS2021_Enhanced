using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class PauseAtFrames : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pauseOnEachFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseAtFramesEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseAtFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_frameNum;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr));

	public unsafe bool pauseOnEachFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseOnEachFrame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseOnEachFrame)) = flag;
		}
	}

	public unsafe bool pauseAtFramesEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAtFramesEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAtFramesEnabled)) = flag;
		}
	}

	public unsafe Il2CppStructArray<int> pauseAtFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAtFrames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAtFrames), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_frameNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameNum)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117263, XrefRangeEnd = 117272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PauseAtFrames()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PauseAtFrames()
	{
		Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PauseAtFrames");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr);
		NativeFieldInfoPtr_pauseOnEachFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, "pauseOnEachFrame");
		NativeFieldInfoPtr_pauseAtFramesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, "pauseAtFramesEnabled");
		NativeFieldInfoPtr_pauseAtFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, "pauseAtFrames");
		NativeFieldInfoPtr_m_frameNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, "m_frameNum");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, 100670714);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, 100670715);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseAtFrames>.NativeClassPtr, 100670716);
	}

	public PauseAtFrames(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
