using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class DataBus : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_data;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_ArrayOf_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bus_Public_get_ArrayOf_ArrayOf_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataBus>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> m_data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> bus
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bus_Public_get_ArrayOf_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppStructArray<int>>(intPtr) : null;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122965, RefRangeEnd = 122966, XrefRangeStart = 122942, XrefRangeEnd = 122965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataBus()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBus>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122966, RefRangeEnd = 122967, XrefRangeStart = 122966, XrefRangeEnd = 122966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Get(int idChannel, int idValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idChannel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void Set(int idChannel, int idValue, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&idChannel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122967, RefRangeEnd = 122971, XrefRangeStart = 122967, XrefRangeEnd = 122967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> Get(int idChannel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idChannel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_ArrayOf_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
	}

	static DataBus()
	{
		Il2CppClassPointerStore<DataBus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DataBus");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBus>.NativeClassPtr);
		NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBus>.NativeClassPtr, "m_data");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBus>.NativeClassPtr, 100671198);
		NativeMethodInfoPtr_Get_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBus>.NativeClassPtr, 100671199);
		NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBus>.NativeClassPtr, 100671200);
		NativeMethodInfoPtr_Get_Public_ArrayOf_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBus>.NativeClassPtr, 100671201);
		NativeMethodInfoPtr_get_bus_Public_get_ArrayOf_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBus>.NativeClassPtr, 100671202);
	}

	public DataBus(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
