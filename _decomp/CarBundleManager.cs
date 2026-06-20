using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class CarBundleManager : Il2CppSystem.Object
{
	[ObfuscatedName("CarBundleManager/<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TryRemoveCarBundle_b__0_Internal_Boolean_AssetBundle_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr));

		public unsafe string carName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60757, XrefRangeEnd = 60758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TryRemoveCarBundle_b__0(AssetBundle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TryRemoveCarBundle_b__0_Internal_Boolean_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
			NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "carName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100666943);
			NativeMethodInfoPtr__TryRemoveCarBundle_b__0_Internal_Boolean_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100666944);
		}

		public __c__DisplayClass4_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadedCarBundles;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxCarsAmountInMemory;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCarBundle_Private_AssetBundle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarBundle_Public_AssetBundle_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryRemoveCarBundle_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr));

	public unsafe List<AssetBundle> LoadedCarBundles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadedCarBundles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<AssetBundle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadedCarBundles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int MaxCarsAmountInMemory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCarsAmountInMemory);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCarsAmountInMemory)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60758, XrefRangeEnd = 60775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundle LoadCarBundle(string filePath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCarBundle_Private_AssetBundle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AssetBundle(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 60841, RefRangeEnd = 60847, XrefRangeStart = 60775, XrefRangeEnd = 60841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetBundle GetCarBundle(string carName, string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarBundle_Public_AssetBundle_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new AssetBundle(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60888, RefRangeEnd = 60889, XrefRangeStart = 60847, XrefRangeEnd = 60888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryRemoveCarBundle(string carName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryRemoveCarBundle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60889, XrefRangeEnd = 60895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarBundleManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarBundleManager()
	{
		Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarBundleManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr);
		NativeFieldInfoPtr_LoadedCarBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, "LoadedCarBundles");
		NativeFieldInfoPtr_MaxCarsAmountInMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, "MaxCarsAmountInMemory");
		NativeMethodInfoPtr_LoadCarBundle_Private_AssetBundle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, 100666939);
		NativeMethodInfoPtr_GetCarBundle_Public_AssetBundle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, 100666940);
		NativeMethodInfoPtr_TryRemoveCarBundle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, 100666941);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleManager>.NativeClassPtr, 100666942);
	}

	public CarBundleManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
