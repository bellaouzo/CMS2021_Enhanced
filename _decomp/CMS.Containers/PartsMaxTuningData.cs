using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Containers;

[System.Serializable]
public class PartsMaxTuningData : ScriptableObject
{
	[System.Serializable]
	public class PartsTuningDictionary : SerializableDictionary<string, float>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartsTuningDictionary>.NativeClassPtr));

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218393, XrefRangeEnd = 218396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartsTuningDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartsTuningDictionary>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static PartsTuningDictionary()
		{
			Il2CppClassPointerStore<PartsTuningDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr, "PartsTuningDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartsTuningDictionary>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsTuningDictionary>.NativeClassPtr, 100679787);
		}

		public PartsTuningDictionary(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTuning;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxTuning_Public_get_IDictionary_2_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxTuning_Public_set_Void_IDictionary_2_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMaxTuning_Public_Boolean_String_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr));

	public unsafe PartsTuningDictionary maxTuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTuning);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PartsTuningDictionary(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTuning), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IDictionary<string, float> MaxTuning
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxTuning_Public_get_IDictionary_2_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new IDictionary<string, float>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218396, XrefRangeEnd = 218400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxTuning_Public_set_Void_IDictionary_2_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218401, RefRangeEnd = 218402, XrefRangeStart = 218400, XrefRangeEnd = 218401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetMaxTuning(string partID, out float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partID);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetMaxTuning_Public_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PartsMaxTuningData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PartsMaxTuningData()
	{
		Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "PartsMaxTuningData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr);
		NativeFieldInfoPtr_maxTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr, "maxTuning");
		NativeMethodInfoPtr_get_MaxTuning_Public_get_IDictionary_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr, 100679783);
		NativeMethodInfoPtr_set_MaxTuning_Public_set_Void_IDictionary_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr, 100679784);
		NativeMethodInfoPtr_TryGetMaxTuning_Public_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr, 100679785);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsMaxTuningData>.NativeClassPtr, 100679786);
	}

	public PartsMaxTuningData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
