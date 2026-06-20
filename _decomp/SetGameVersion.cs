using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SetGameVersion : MonoBehaviour
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBytesFromBinaryString_Private_Static_ArrayOf_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95339, XrefRangeEnd = 95377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Setup()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 95393, RefRangeEnd = 95397, XrefRangeStart = 95377, XrefRangeEnd = 95393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetBytesFromBinaryString(string binary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(binary);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBytesFromBinaryString_Private_Static_ArrayOf_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SetGameVersion()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SetGameVersion()
	{
		Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SetGameVersion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr);
		NativeMethodInfoPtr_Setup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr, 100668832);
		NativeMethodInfoPtr_GetBytesFromBinaryString_Private_Static_ArrayOf_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr, 100668833);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetGameVersion>.NativeClassPtr, 100668834);
	}

	public SetGameVersion(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
