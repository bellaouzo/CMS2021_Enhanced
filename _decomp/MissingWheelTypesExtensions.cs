using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class MissingWheelTypesExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_MissingWheelTypes_MissingWheelTypes_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MissingWheelTypesExtensions>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static bool HasFlagFast(this MissingWheelTypes value, MissingWheelTypes flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(MissingWheelTypes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flag;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_MissingWheelTypes_MissingWheelTypes_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static MissingWheelTypesExtensions()
	{
		Il2CppClassPointerStore<MissingWheelTypesExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MissingWheelTypesExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingWheelTypesExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_HasFlagFast_Public_Static_Boolean_MissingWheelTypes_MissingWheelTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingWheelTypesExtensions>.NativeClassPtr, 100668836);
	}

	public MissingWheelTypesExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
