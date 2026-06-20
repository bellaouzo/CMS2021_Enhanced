using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class DLC : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ProductId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Owned;

	private static readonly System.IntPtr NativeFieldInfoPtr_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_Order;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReleaseDate;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddReleaseDate_Public_Void_UInt16_UInt16_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasReleaseDate_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReleaseDay_Public_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DLC>.NativeClassPtr));

	public unsafe string ProductId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProductId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProductId), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool Owned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Owned);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Owned)) = flag;
		}
	}

	public unsafe byte Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index)) = b;
		}
	}

	public unsafe byte Order
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Order);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Order)) = b;
		}
	}

	public unsafe long ReleaseDate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseDate);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseDate)) = num;
		}
	}

	[CallerCount(32)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DLC(string productId, string name, bool have)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &have;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 92841, RefRangeEnd = 92849, XrefRangeStart = 92835, XrefRangeEnd = 92841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddReleaseDate(ushort day, ushort month, ushort year)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&day);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &month;
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &year;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddReleaseDate_Public_Void_UInt16_UInt16_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool HasReleaseDate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasReleaseDate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92865, RefRangeEnd = 92868, XrefRangeStart = 92849, XrefRangeEnd = 92865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsReleaseDay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReleaseDay_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static DLC()
	{
		Il2CppClassPointerStore<DLC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DLC");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC>.NativeClassPtr);
		NativeFieldInfoPtr_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC>.NativeClassPtr, "ProductId");
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Owned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC>.NativeClassPtr, "Owned");
		NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC>.NativeClassPtr, "Index");
		NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC>.NativeClassPtr, "Order");
		NativeFieldInfoPtr_ReleaseDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC>.NativeClassPtr, "ReleaseDate");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC>.NativeClassPtr, 100668607);
		NativeMethodInfoPtr_AddReleaseDate_Public_Void_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC>.NativeClassPtr, 100668608);
		NativeMethodInfoPtr_HasReleaseDate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC>.NativeClassPtr, 100668609);
		NativeMethodInfoPtr_IsReleaseDay_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC>.NativeClassPtr, 100668610);
	}

	public DLC(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
