using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Tracks.Dragstrip;

public static class OpponentManager : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("CMS.Tracks.Dragstrip.OpponentManager/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomOpponentCar_b__0_0_Internal_Int32_DragstripRandomOpponentBasicData_DragstripRandomOpponentBasicData_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c>.NativeClassPtr));

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new __c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Comparison<DragstripRandomOpponentBasicData> __9__0_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__0_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Comparison<DragstripRandomOpponentBasicData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__0_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe int _GetRandomOpponentCar_b__0_0(DragstripRandomOpponentBasicData a, DragstripRandomOpponentBasicData b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(DragstripRandomOpponentBasicData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetRandomOpponentCar_b__0_0_Internal_Int32_DragstripRandomOpponentBasicData_DragstripRandomOpponentBasicData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpponentManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__0_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672251);
			NativeMethodInfoPtr__GetRandomOpponentCar_b__0_0_Internal_Int32_DragstripRandomOpponentBasicData_DragstripRandomOpponentBasicData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672252);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomOpponentCar_Public_Static_CarForDragstrip_List_1_BasicCarForDragstrip_Single_byref_Single_byref_Single_byref_CarForDragstrip_byref_CarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsForChampionshipCount_Public_Static_Int32_List_1_BasicCarForDragstrip_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OpponentManager>.NativeClassPtr));

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 134650, RefRangeEnd = 134655, XrefRangeStart = 134610, XrefRangeEnd = 134650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CarForDragstrip GetRandomOpponentCar(List<BasicCarForDragstrip> availableCars, float performanceIndex, out float minPI, out float maxPI, out CarForDragstrip minCar, out CarForDragstrip maxCar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableCars);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &performanceIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref minPI);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref maxPI);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(minCar);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(maxCar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomOpponentCar_Public_Static_CarForDragstrip_List_1_BasicCarForDragstrip_Single_byref_Single_byref_Single_byref_CarForDragstrip_byref_CarForDragstrip_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CarForDragstrip(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134677, RefRangeEnd = 134678, XrefRangeStart = 134655, XrefRangeEnd = 134677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCarsForChampionshipCount(List<BasicCarForDragstrip> availableCars, float performanceIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableCars);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &performanceIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsForChampionshipCount_Public_Static_Int32_List_1_BasicCarForDragstrip_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static OpponentManager()
	{
		Il2CppClassPointerStore<OpponentManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "OpponentManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentManager>.NativeClassPtr);
		NativeMethodInfoPtr_GetRandomOpponentCar_Public_Static_CarForDragstrip_List_1_BasicCarForDragstrip_Single_byref_Single_byref_Single_byref_CarForDragstrip_byref_CarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentManager>.NativeClassPtr, 100672248);
		NativeMethodInfoPtr_GetCarsForChampionshipCount_Public_Static_Int32_List_1_BasicCarForDragstrip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentManager>.NativeClassPtr, 100672249);
	}

	public OpponentManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
