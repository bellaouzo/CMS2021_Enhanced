using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ShowroomTest : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_UI;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr));

	public unsafe GameObject UI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UI), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ShowroomTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShowroomTest()
	{
		Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ShowroomTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr);
		NativeFieldInfoPtr_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr, "UI");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr, 100668163);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowroomTest>.NativeClassPtr, 100668164);
	}

	public ShowroomTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
