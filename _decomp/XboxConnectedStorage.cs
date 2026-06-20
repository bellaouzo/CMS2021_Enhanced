using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class XboxConnectedStorage : MonoBehaviour
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XboxConnectedStorage>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe XboxConnectedStorage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxConnectedStorage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static XboxConnectedStorage()
	{
		Il2CppClassPointerStore<XboxConnectedStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "XboxConnectedStorage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxConnectedStorage>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxConnectedStorage>.NativeClassPtr, 100667205);
	}

	public XboxConnectedStorage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
