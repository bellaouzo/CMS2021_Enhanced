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
public sealed class ShopListItemDataEx : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlateName;

	private static readonly System.IntPtr NativeFieldInfoPtr_LicensePlate;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tire;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rim;

	private static readonly System.IntPtr NativeFieldInfoPtr_Width;

	private static readonly System.IntPtr NativeFieldInfoPtr_Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_Profile;

	private static readonly System.IntPtr NativeFieldInfoPtr_ET;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ShopListItemDataEx_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr));

	public unsafe string LicensePlateName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlateName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool LicensePlate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LicensePlate)) = flag;
		}
	}

	public unsafe bool Tire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire)) = flag;
		}
	}

	public unsafe bool Rim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rim);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rim)) = flag;
		}
	}

	public unsafe int Width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Width);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Width)) = num;
		}
	}

	public unsafe int Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size)) = num;
		}
	}

	public unsafe int Profile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Profile);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Profile)) = num;
		}
	}

	public unsafe int ET
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ET);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ET)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe bool Equals(ShopListItemDataEx compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(compare));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_ShopListItemDataEx_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 218410, RefRangeEnd = 218413, XrefRangeStart = 218408, XrefRangeEnd = 218410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 218415, RefRangeEnd = 218417, XrefRangeStart = 218413, XrefRangeEnd = 218415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 218420, RefRangeEnd = 218422, XrefRangeStart = 218417, XrefRangeEnd = 218420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShopListItemDataEx()
	{
		Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "ShopListItemDataEx");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr);
		NativeFieldInfoPtr_LicensePlateName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "LicensePlateName");
		NativeFieldInfoPtr_LicensePlate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "LicensePlate");
		NativeFieldInfoPtr_Tire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "Tire");
		NativeFieldInfoPtr_Rim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "Rim");
		NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "Width");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "Profile");
		NativeFieldInfoPtr_ET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, "ET");
		NativeMethodInfoPtr_Equals_Public_Boolean_ShopListItemDataEx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, 100679791);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, 100679792);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, 100679793);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, 100679794);
	}

	public ShopListItemDataEx(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe ShopListItemDataEx()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<ShopListItemDataEx>.NativeClassPtr))
	{
	}
}
