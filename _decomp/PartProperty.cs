using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class PartProperty : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Price;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShopGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExamineGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_RepairGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpecialGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLC;

	private static readonly System.IntPtr NativeFieldInfoPtr_HaveDLC;

	private static readonly System.IntPtr NativeFieldInfoPtr_TuningValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_BrakesValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brand;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShopName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMod;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_String_Int32_Int32_SpecialGroup_ArrayOf_Int32_Boolean_Single_Boolean_String_String_String_Boolean_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBonusPart_Public_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartProperty>.NativeClassPtr));

	public unsafe string ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int Price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Price)) = num;
		}
	}

	public unsafe int PartGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartGroup);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartGroup)) = num;
		}
	}

	public unsafe string ShopGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopGroup);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopGroup), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int ExamineGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExamineGroup);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExamineGroup)) = num;
		}
	}

	public unsafe int RepairGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairGroup);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RepairGroup)) = num;
		}
	}

	public unsafe SpecialGroup SpecialGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpecialGroup);
			return *(SpecialGroup*)num;
		}
		set
		{
			*(SpecialGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpecialGroup)) = specialGroup;
		}
	}

	public unsafe Il2CppStructArray<int> DLC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool HaveDLC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HaveDLC);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HaveDLC)) = flag;
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

	public unsafe float BrakesValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakesValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakesValue)) = num;
		}
	}

	public unsafe bool IsBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsBody);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsBody)) = flag;
		}
	}

	public unsafe bool CanPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanPaint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanPaint)) = flag;
		}
	}

	public unsafe string LocalizedName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizedName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizedName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Brand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brand);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brand), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string ShopName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string CarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMod);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMod)) = flag;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93286, RefRangeEnd = 93288, XrefRangeStart = 93286, XrefRangeEnd = 93286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartProperty(string _ID, int _Price, int _PartGroup, string _ShopGroup, int _ExamineGroup, int _RepairGroup, SpecialGroup _SpecialGroup, Il2CppStructArray<int> _DLC, bool _HaveDLC, float _TuningValue, bool _IsBody, string _LocalizedName, string _Brand, string _ShopName, bool _CanPaint, string _CarID, float _BrakesValue, bool _IsMod = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartProperty>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[18];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_ID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_Price;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_PartGroup;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_ShopGroup);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &_ExamineGroup;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &_RepairGroup;
		*(SpecialGroup**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &_SpecialGroup;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(_DLC);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &_HaveDLC;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &_TuningValue;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &_IsBody;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_LocalizedName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_Brand);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_ShopName);
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &_CanPaint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_CarID);
		*(float**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &_BrakesValue;
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &_IsMod;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_String_Int32_Int32_SpecialGroup_ArrayOf_Int32_Boolean_Single_Boolean_String_String_String_Boolean_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93290, RefRangeEnd = 93291, XrefRangeStart = 93288, XrefRangeEnd = 93290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartProperty(string _ID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartProperty>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsBonusPart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBonusPart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static PartProperty()
	{
		Il2CppClassPointerStore<PartProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PartProperty");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartProperty>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "Price");
		NativeFieldInfoPtr_PartGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "PartGroup");
		NativeFieldInfoPtr_ShopGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "ShopGroup");
		NativeFieldInfoPtr_ExamineGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "ExamineGroup");
		NativeFieldInfoPtr_RepairGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "RepairGroup");
		NativeFieldInfoPtr_SpecialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "SpecialGroup");
		NativeFieldInfoPtr_DLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "DLC");
		NativeFieldInfoPtr_HaveDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "HaveDLC");
		NativeFieldInfoPtr_TuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "TuningValue");
		NativeFieldInfoPtr_BrakesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "BrakesValue");
		NativeFieldInfoPtr_IsBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "IsBody");
		NativeFieldInfoPtr_CanPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "CanPaint");
		NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "LocalizedName");
		NativeFieldInfoPtr_Brand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "Brand");
		NativeFieldInfoPtr_ShopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "ShopName");
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_IsMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, "IsMod");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_String_Int32_Int32_SpecialGroup_ArrayOf_Int32_Boolean_Single_Boolean_String_String_String_Boolean_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, 100668677);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, 100668678);
		NativeMethodInfoPtr_IsBonusPart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartProperty>.NativeClassPtr, 100668679);
	}

	public PartProperty(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
