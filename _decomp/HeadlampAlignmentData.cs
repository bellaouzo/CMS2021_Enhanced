using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct HeadlampAlignmentData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Horizontal;

	private static readonly System.IntPtr NativeFieldInfoPtr_Vertical;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HeadlampAlignment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	[FieldOffset(0)]
	public float Horizontal;

	[FieldOffset(4)]
	public float Vertical;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe HeadlampAlignmentData(HeadlampAlignment headlampAlignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&headlampAlignment);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HeadlampAlignment_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65067, XrefRangeEnd = 65068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65068, RefRangeEnd = 65070, XrefRangeStart = 65068, XrefRangeEnd = 65068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HeadlampAlignmentData()
	{
		Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "HeadlampAlignmentData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr);
		NativeFieldInfoPtr_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr, "Horizontal");
		NativeFieldInfoPtr_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr, "Vertical");
		NativeMethodInfoPtr__ctor_Public_Void_HeadlampAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr, 100667260);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr, 100667261);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr, 100667262);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HeadlampAlignmentData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
