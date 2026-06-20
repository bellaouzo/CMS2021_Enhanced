using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers.Comparers;

public class BaseItemComparerByName : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Ascending;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_BaseItem_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareAsc_Private_Int32_BaseItem_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareDesc_Private_Int32_BaseItem_BaseItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr));

	public unsafe bool Ascending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ascending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ascending)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215306, XrefRangeEnd = 215307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Compare(BaseItem x, BaseItem y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215307, XrefRangeEnd = 215317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CompareAsc(BaseItem x, BaseItem y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareAsc_Private_Int32_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 215327, RefRangeEnd = 215328, XrefRangeStart = 215317, XrefRangeEnd = 215327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CompareDesc(BaseItem x, BaseItem y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareDesc_Private_Int32_BaseItem_BaseItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe BaseItemComparerByName()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseItemComparerByName()
	{
		Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers.Comparers", "BaseItemComparerByName");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr);
		NativeFieldInfoPtr_Ascending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr, "Ascending");
		NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr, 100679473);
		NativeMethodInfoPtr_CompareAsc_Private_Int32_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr, 100679474);
		NativeMethodInfoPtr_CompareDesc_Private_Int32_BaseItem_BaseItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr, 100679475);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseItemComparerByName>.NativeClassPtr, 100679476);
	}

	public BaseItemComparerByName(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
