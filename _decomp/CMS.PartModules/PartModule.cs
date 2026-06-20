using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.PartModules;

public class PartModule : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_partScript;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PartScript_Public_get_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniqueID_Public_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tune_Public_Void_ArrayOf_Int16_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuned_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_ArrayOf_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDataTo_Public_Void_byref_TuningData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDataFrom_Public_Void_byref_TuningData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartModule>.NativeClassPtr));

	public unsafe PartScript partScript
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partScript);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partScript), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TuningData data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			return new TuningData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TuningData>.NativeClassPtr, num));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TuningData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe PartScript PartScript
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PartScript_Public_get_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139879, XrefRangeEnd = 139894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUniqueID(string carName, string engineName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engineName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniqueID_Public_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 139900, RefRangeEnd = 139902, XrefRangeStart = 139894, XrefRangeEnd = 139900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tune(Il2CppStructArray<short> newValues, float newTuningValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newValues);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newTuningValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tune_Public_Void_ArrayOf_Int16_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsTuned()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuned_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Il2CppStructArray<short> GetValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_ArrayOf_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<short>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 139902, RefRangeEnd = 139904, XrefRangeStart = 139902, XrefRangeEnd = 139902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyDataTo(out TuningData target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDataTo_Public_Void_byref_TuningData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 139904, RefRangeEnd = 139906, XrefRangeStart = 139904, XrefRangeEnd = 139904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyDataFrom(ref TuningData from)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(from);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDataFrom_Public_Void_byref_TuningData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PartModule()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartModule>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PartModule()
	{
		Il2CppClassPointerStore<PartModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.PartModules", "PartModule");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartModule>.NativeClassPtr);
		NativeFieldInfoPtr_partScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartModule>.NativeClassPtr, "partScript");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartModule>.NativeClassPtr, "data");
		NativeMethodInfoPtr_get_PartScript_Public_get_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672708);
		NativeMethodInfoPtr_GetUniqueID_Public_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672709);
		NativeMethodInfoPtr_Tune_Public_Void_ArrayOf_Int16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672710);
		NativeMethodInfoPtr_IsTuned_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672711);
		NativeMethodInfoPtr_GetValues_Public_ArrayOf_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672712);
		NativeMethodInfoPtr_CopyDataTo_Public_Void_byref_TuningData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672713);
		NativeMethodInfoPtr_CopyDataFrom_Public_Void_byref_TuningData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672714);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartModule>.NativeClassPtr, 100672715);
	}

	public PartModule(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
