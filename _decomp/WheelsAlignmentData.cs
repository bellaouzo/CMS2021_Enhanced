using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct WheelsAlignmentData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FL;

	private static readonly System.IntPtr NativeFieldInfoPtr_FR;

	private static readonly System.IntPtr NativeFieldInfoPtr_RL;

	private static readonly System.IntPtr NativeFieldInfoPtr_RR;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WheelsAlignment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	[FieldOffset(0)]
	public float FL;

	[FieldOffset(4)]
	public float FR;

	[FieldOffset(8)]
	public float RL;

	[FieldOffset(12)]
	public float RR;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe WheelsAlignmentData(WheelsAlignment wheelsAlignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelsAlignment);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_WheelsAlignment_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65098, RefRangeEnd = 65099, XrefRangeStart = 65097, XrefRangeEnd = 65098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65099, RefRangeEnd = 65100, XrefRangeStart = 65099, XrefRangeEnd = 65099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WheelsAlignmentData()
	{
		Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "WheelsAlignmentData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr);
		NativeFieldInfoPtr_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, "FL");
		NativeFieldInfoPtr_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, "FR");
		NativeFieldInfoPtr_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, "RL");
		NativeFieldInfoPtr_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, "RR");
		NativeMethodInfoPtr__ctor_Public_Void_WheelsAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, 100667276);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, 100667277);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, 100667278);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelsAlignmentData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
