using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class TuningData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsTuned;

	private static readonly System.IntPtr NativeFieldInfoPtr_Values;

	private static readonly System.IntPtr NativeFieldInfoPtr_TuningValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_BinaryWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_BinaryReader_Byte_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TuningData>.NativeClassPtr));

	public unsafe bool IsTuned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTuned);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTuned)) = flag;
		}
	}

	public unsafe Il2CppStructArray<short> Values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Values);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<short>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float TuningValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningValue)) = num;
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 218429, RefRangeEnd = 218432, XrefRangeStart = 218428, XrefRangeEnd = 218429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_BinaryWriter_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 218435, RefRangeEnd = 218438, XrefRangeStart = 218432, XrefRangeEnd = 218435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_BinaryReader_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TuningData()
	{
		Il2CppClassPointerStore<TuningData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "TuningData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TuningData>.NativeClassPtr);
		NativeFieldInfoPtr_IsTuned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningData>.NativeClassPtr, "IsTuned");
		NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningData>.NativeClassPtr, "Values");
		NativeFieldInfoPtr_TuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TuningData>.NativeClassPtr, "TuningValue");
		NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_BinaryWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningData>.NativeClassPtr, 100679799);
		NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningData>.NativeClassPtr, 100679800);
	}

	public TuningData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe TuningData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TuningData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<TuningData>.NativeClassPtr))
	{
	}
}
