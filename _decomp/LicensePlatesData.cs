using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class LicensePlatesData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlateNumberFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlateNumberRear;

	private static readonly System.IntPtr NativeFieldInfoPtr_FactoryLicensePlateNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlateFrontTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlateRearTex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LicensePlatesData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr));

	public unsafe string LicensePlateNumberFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateNumberFront);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateNumberFront), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string LicensePlateNumberRear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateNumberRear);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateNumberRear), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string FactoryLicensePlateNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactoryLicensePlateNumber);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactoryLicensePlateNumber), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string LicensePlateFrontTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateFrontTex);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateFrontTex), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string LicensePlateRearTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateRearTex);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateRearTex), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94055, RefRangeEnd = 94056, XrefRangeStart = 94055, XrefRangeEnd = 94055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LicensePlatesData(LicensePlatesData copy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(copy));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LicensePlatesData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94063, RefRangeEnd = 94064, XrefRangeStart = 94056, XrefRangeEnd = 94063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94064, RefRangeEnd = 94065, XrefRangeStart = 94064, XrefRangeEnd = 94064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LicensePlatesData()
	{
		Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LicensePlatesData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr);
		NativeFieldInfoPtr_LicensePlateNumberFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, "LicensePlateNumberFront");
		NativeFieldInfoPtr_LicensePlateNumberRear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, "LicensePlateNumberRear");
		NativeFieldInfoPtr_FactoryLicensePlateNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, "FactoryLicensePlateNumber");
		NativeFieldInfoPtr_LicensePlateFrontTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, "LicensePlateFrontTex");
		NativeFieldInfoPtr_LicensePlateRearTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, "LicensePlateRearTex");
		NativeMethodInfoPtr__ctor_Public_Void_LicensePlatesData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, 100668730);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, 100668731);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, 100668732);
	}

	public LicensePlatesData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe LicensePlatesData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<LicensePlatesData>.NativeClassPtr))
	{
	}
}
