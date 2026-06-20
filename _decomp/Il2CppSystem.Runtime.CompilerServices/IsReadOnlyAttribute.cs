using System;
using System.Runtime.CompilerServices;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class IsReadOnlyAttribute : Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType => Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr));

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe IsReadOnlyAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static IsReadOnlyAttribute()
	{
		Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "System.Runtime.CompilerServices", "IsReadOnlyAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsReadOnlyAttribute>.NativeClassPtr, 100663298);
	}

	public IsReadOnlyAttribute(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
