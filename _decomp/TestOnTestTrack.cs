using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class TestOnTestTrack : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDone;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr));

	public unsafe int Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index)) = num;
		}
	}

	public unsafe bool IsDone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDone)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TestOnTestTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TestOnTestTrack()
	{
		Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TestOnTestTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr);
		NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr, "Index");
		NativeFieldInfoPtr_IsDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr, "IsDone");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestOnTestTrack>.NativeClassPtr, 100668231);
	}

	public TestOnTestTrack(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
