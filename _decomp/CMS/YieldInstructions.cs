using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS;

public static class YieldInstructions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WaitForEndOfFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitForSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitForSecondRT;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitForTwoSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitBeforeInvokingAction;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr));

	public unsafe static WaitForEndOfFrame WaitForEndOfFrame
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitForEndOfFrame, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new WaitForEndOfFrame(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitForEndOfFrame, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static WaitForSeconds WaitForSecond
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitForSecond, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new WaitForSeconds(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitForSecond, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static WaitForSecondsRealtime WaitForSecondRT
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitForSecondRT, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new WaitForSecondsRealtime(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitForSecondRT, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static WaitForSecondsRealtime WaitForTwoSeconds
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitForTwoSeconds, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new WaitForSecondsRealtime(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitForTwoSeconds, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static WaitForSecondsRealtime WaitBeforeInvokingAction
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitBeforeInvokingAction, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new WaitForSecondsRealtime(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitBeforeInvokingAction, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static YieldInstructions()
	{
		Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS", "YieldInstructions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr);
		NativeFieldInfoPtr_WaitForEndOfFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr, "WaitForEndOfFrame");
		NativeFieldInfoPtr_WaitForSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr, "WaitForSecond");
		NativeFieldInfoPtr_WaitForSecondRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr, "WaitForSecondRT");
		NativeFieldInfoPtr_WaitForTwoSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr, "WaitForTwoSeconds");
		NativeFieldInfoPtr_WaitBeforeInvokingAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldInstructions>.NativeClassPtr, "WaitBeforeInvokingAction");
	}

	public YieldInstructions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
