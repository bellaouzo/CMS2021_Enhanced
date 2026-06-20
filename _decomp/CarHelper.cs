using System;
using System.Runtime.CompilerServices;
using CMS.FileSupport.INI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class CarHelper : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("CarHelper/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ProcessAllowedColors_b__13_0_Internal_String_String_0;

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

		public unsafe static Il2CppSystem.Func<string, string> __9__13_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__13_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<string, string>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__13_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe string _ProcessAllowedColors_b__13_0(string p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProcessAllowedColors_b__13_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__13_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666436);
			NativeMethodInfoPtr__ProcessAllowedColors_b__13_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666437);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipRimIfShould_Public_Static_Void_GameObject_WheelType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipNormalRim_Private_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlipHuayraRims_Private_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcRimSize_Public_Static_Void_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetET_Public_Static_Void_Transform_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcTireSize_Public_Static_Void_GameObject_Transform_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BakeSkinnedMesh_Public_Static_Void_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BakeMesh_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleObjectToPositionY_Public_Static_Void_GameObject_Vector3_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionFor_Public_Static_Vector3_byref_IniData_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationFor_Public_Static_Vector3_byref_IniData_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScaleFor_Public_Static_Single_byref_IniData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAbsorbersToConnectNames_Public_Static_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAllowedColors_Public_Static_Void_byref_List_1_AllowedColor_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessThumbnailColor_Public_Static_Void_byref_AllowedColor_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomFactoryColor_Public_Static_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomCarColor_Public_Static_ColorHSV_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcRadialFaultsCondition_Public_Static_Single_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomMileage_Public_Static_Int32_Int32_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomMileage_Public_Static_Int32_Int32_AuctionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalCondition_Public_Static_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalCondition_Public_Static_Vector2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissingBodyPartsChance_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMileagePriceMod_Public_Static_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRestorationMod_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetXrayAlpha_Public_Static_Void_GameObject_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetXrayAlpha_Public_Static_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableRustOutside_Public_Static_Void_ArrayOf_Renderer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_ArrayOf_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_Material_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRustMap_Public_Static_Void_Texture2D_ArrayOf_Renderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDustValue_Public_Static_Void_ArrayOf_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDustValue_Public_Static_Void_Material_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWashFactor_Public_Static_Void_ArrayOf_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomLicensePlate_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessBonusPartsIds_Public_Static_Void_byref_List_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPartsToExamine_Public_Static_List_1_PartScript_CarLoader_ToolType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedCarOrigin_Public_Static_String_CarFrom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckEngineState_Public_Static_EngineState_CarLoader_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PartCanBeDented_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReparentParts_Public_Static_Void_Transform_Transform_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableMotionVectors_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableSkinnedMotionVectors_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintBonus_Public_Static_Int32_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWashFactorBonus_Public_Static_Int32_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTireSizeString_Public_Static_String_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTireTypeFromID_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFromChild_Public_Static_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyIfNotNull_Public_Static_Void_Transform_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarHelper>.NativeClassPtr));

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 52947, RefRangeEnd = 52954, XrefRangeStart = 52940, XrefRangeEnd = 52947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipRimIfShould(GameObject go, WheelType wheelType, string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(WheelType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wheelType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipRimIfShould_Public_Static_Void_GameObject_WheelType_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53002, RefRangeEnd = 53004, XrefRangeStart = 52954, XrefRangeEnd = 53002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipNormalRim(GameObject go, bool right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipNormalRim_Private_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53048, RefRangeEnd = 53049, XrefRangeStart = 53004, XrefRangeEnd = 53048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlipHuayraRims(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlipHuayraRims_Private_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53070, RefRangeEnd = 53073, XrefRangeStart = 53049, XrefRangeEnd = 53070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalcRimSize(GameObject rim, float wheelWidth, float rimSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rim);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wheelWidth;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rimSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcRimSize_Public_Static_Void_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 53126, RefRangeEnd = 53136, XrefRangeStart = 53073, XrefRangeEnd = 53126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetET(Transform t, int et)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &et;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetET_Public_Static_Void_Transform_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53169, RefRangeEnd = 53171, XrefRangeStart = 53136, XrefRangeEnd = 53169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalcTireSize(GameObject tire, Transform parentGO, float wheelWidth, float rimSize, float tireSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parentGO);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wheelWidth;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rimSize;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tireSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcTireSize_Public_Static_Void_GameObject_Transform_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 53190, RefRangeEnd = 53199, XrefRangeStart = 53171, XrefRangeEnd = 53190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BakeSkinnedMesh(GameObject from, GameObject to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BakeSkinnedMesh_Public_Static_Void_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53265, RefRangeEnd = 53266, XrefRangeStart = 53199, XrefRangeEnd = 53265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BakeMesh(GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BakeMesh_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53278, RefRangeEnd = 53281, XrefRangeStart = 53266, XrefRangeEnd = 53278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScaleObjectToPositionY(GameObject scaledObject, Vector3 dir, float startPosition, float length, float startingScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaledObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startPosition;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingScale;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleObjectToPositionY_Public_Static_Void_GameObject_Vector3_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53281, XrefRangeEnd = 53285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetPositionFor(ref IniData ini, string objectName, string parentName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parentName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionFor_Public_Static_Vector3_byref_IniData_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		ini = ((intPtr2 == (System.IntPtr)0) ? null : new IniData(intPtr2));
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53285, XrefRangeEnd = 53289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetRotationFor(ref IniData ini, string objectName, string parentName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parentName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationFor_Public_Static_Vector3_byref_IniData_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		ini = ((intPtr2 == (System.IntPtr)0) ? null : new IniData(intPtr2));
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53289, XrefRangeEnd = 53294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetScaleFor(ref IniData ini, string objectName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScaleFor_Public_Static_Single_byref_IniData_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		ini = ((intPtr2 == (System.IntPtr)0) ? null : new IniData(intPtr2));
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53294, XrefRangeEnd = 53308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetAbsorbersToConnectNames()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAbsorbersToConnectNames_Public_Static_ArrayOf_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53343, RefRangeEnd = 53346, XrefRangeStart = 53308, XrefRangeEnd = 53343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessAllowedColors(out List<AllowedColor> allowedColors, string data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(allowedColors);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessAllowedColors_Public_Static_Void_byref_List_1_AllowedColor_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		allowedColors = (List<AllowedColor>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53349, RefRangeEnd = 53353, XrefRangeStart = 53346, XrefRangeEnd = 53349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessThumbnailColor(out AllowedColor allowedColors, string data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref allowedColors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessThumbnailColor_Public_Static_Void_byref_AllowedColor_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53355, RefRangeEnd = 53360, XrefRangeStart = 53353, XrefRangeEnd = 53355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRandomFactoryColor(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRandomFactoryColor_Public_Static_Void_CarLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53373, RefRangeEnd = 53376, XrefRangeStart = 53360, XrefRangeEnd = 53373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ColorHSV GenerateRandomCarColor()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRandomCarColor_Public_Static_ColorHSV_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ColorHSV(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53376, XrefRangeEnd = 53412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcRadialFaultsCondition(Transform t1, Transform t2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(t2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcRadialFaultsCondition_Public_Static_Single_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53424, RefRangeEnd = 53428, XrefRangeStart = 53412, XrefRangeEnd = 53424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRandomMileage(int year, SceneType carFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&year);
		*(SceneType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carFrom;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomMileage_Public_Static_Int32_Int32_SceneType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53428, XrefRangeEnd = 53440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRandomMileage(int year, AuctionType auctionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&year);
		*(AuctionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &auctionType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomMileage_Public_Static_Int32_Int32_AuctionType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53444, RefRangeEnd = 53446, XrefRangeStart = 53440, XrefRangeEnd = 53444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetGlobalCondition(int year)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&year);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalCondition_Public_Static_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53461, RefRangeEnd = 53464, XrefRangeStart = 53446, XrefRangeEnd = 53461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetGlobalCondition(int year, int rating)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&year);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rating;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalCondition_Public_Static_Vector2_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static int GetMissingBodyPartsChance(int rating)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rating);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissingBodyPartsChance_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float GetMileagePriceMod(float globalCondition, int mileage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&globalCondition);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mileage;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMileagePriceMod_Public_Static_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53472, RefRangeEnd = 53477, XrefRangeStart = 53464, XrefRangeEnd = 53472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetRestorationMod(float globalCondition, float carValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&globalCondition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRestorationMod_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53505, RefRangeEnd = 53513, XrefRangeStart = 53477, XrefRangeEnd = 53505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetXrayAlpha(GameObject go, float alpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetXrayAlpha_Public_Static_Void_GameObject_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53542, RefRangeEnd = 53547, XrefRangeStart = 53513, XrefRangeEnd = 53542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetXrayAlpha(Transform t, float alpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetXrayAlpha_Public_Static_Void_Transform_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53561, RefRangeEnd = 53563, XrefRangeStart = 53547, XrefRangeEnd = 53561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableRustOutside(Il2CppReferenceArray<Renderer> renderers, bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableRustOutside_Public_Static_Void_ArrayOf_Renderer_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53584, RefRangeEnd = 53587, XrefRangeStart = 53563, XrefRangeEnd = 53584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateCarBodyPart(Il2CppReferenceArray<Renderer> renderers, float condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_ArrayOf_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53587, XrefRangeEnd = 53603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateCarBodyPart(Renderer renderer, float condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 53626, RefRangeEnd = 53635, XrefRangeStart = 53603, XrefRangeEnd = 53626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateCarBodyPart(Material material, float condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_Material_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53657, RefRangeEnd = 53658, XrefRangeStart = 53635, XrefRangeEnd = 53657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRustMap(Texture2D rustMap, Il2CppReferenceArray<Renderer> renderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rustMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRustMap_Public_Static_Void_Texture2D_ArrayOf_Renderer_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 53671, RefRangeEnd = 53682, XrefRangeStart = 53658, XrefRangeEnd = 53671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDustValue(Il2CppReferenceArray<Renderer> renderers, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDustValue_Public_Static_Void_ArrayOf_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53692, RefRangeEnd = 53696, XrefRangeStart = 53682, XrefRangeEnd = 53692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDustValue(Material material, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDustValue_Public_Static_Void_Material_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53709, RefRangeEnd = 53713, XrefRangeStart = 53696, XrefRangeEnd = 53709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWashFactor(Il2CppReferenceArray<Renderer> renderers, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWashFactor_Public_Static_Void_ArrayOf_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53741, RefRangeEnd = 53743, XrefRangeStart = 53713, XrefRangeEnd = 53741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRandomLicensePlate()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomLicensePlate_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53761, RefRangeEnd = 53763, XrefRangeStart = 53743, XrefRangeEnd = 53761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessBonusPartsIds(out List<int> bonusPartsIds, string data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(bonusPartsIds);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessBonusPartsIds_Public_Static_Void_byref_List_1_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		bonusPartsIds = (List<int>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53783, RefRangeEnd = 53784, XrefRangeStart = 53763, XrefRangeEnd = 53783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PartScript> GetPartsToExamine(CarLoader carLoader, ToolType examineType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(ToolType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &examineType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPartsToExamine_Public_Static_List_1_PartScript_CarLoader_ToolType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<PartScript>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53784, XrefRangeEnd = 53805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedCarOrigin(CarFrom carFrom)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&carFrom);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedCarOrigin_Public_Static_String_CarFrom_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53805, XrefRangeEnd = 53806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static EngineState CheckEngineState(CarLoader car, out float enginePartsAvgCondition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(car);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref enginePartsAvgCondition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckEngineState_Public_Static_EngineState_CarLoader_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(EngineState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53815, RefRangeEnd = 53818, XrefRangeStart = 53806, XrefRangeEnd = 53815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PartCanBeDented(string partName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PartCanBeDented_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53848, RefRangeEnd = 53853, XrefRangeStart = 53818, XrefRangeEnd = 53848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReparentParts(Transform suspensionTransform, Transform parent, Il2CppStringArray objectsToReparent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(suspensionTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(objectsToReparent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReparentParts_Public_Static_Void_Transform_Transform_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 53858, RefRangeEnd = 53868, XrefRangeStart = 53853, XrefRangeEnd = 53858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableMotionVectors(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableMotionVectors_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53873, RefRangeEnd = 53881, XrefRangeStart = 53868, XrefRangeEnd = 53873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableSkinnedMotionVectors(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableSkinnedMotionVectors_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53912, RefRangeEnd = 53914, XrefRangeStart = 53881, XrefRangeEnd = 53912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPaintBonus(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaintBonus_Public_Static_Int32_CarLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53944, RefRangeEnd = 53946, XrefRangeStart = 53914, XrefRangeEnd = 53944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetWashFactorBonus(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWashFactorBonus_Public_Static_Int32_CarLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53966, RefRangeEnd = 53968, XrefRangeStart = 53946, XrefRangeEnd = 53966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTireSizeString(float frontWidth, float frontProfile, float frontSize, float rearWidth, float rearProfile, float rearSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&frontWidth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frontProfile;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &frontSize;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rearWidth;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rearProfile;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &rearSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTireSizeString_Public_Static_String_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 54011, RefRangeEnd = 54015, XrefRangeStart = 53968, XrefRangeEnd = 54011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTireTypeFromID(string tireID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tireID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTireTypeFromID_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 54046, RefRangeEnd = 54055, XrefRangeStart = 54015, XrefRangeEnd = 54046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearFromChild(Transform parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFromChild_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 54072, RefRangeEnd = 54079, XrefRangeStart = 54055, XrefRangeEnd = 54072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyIfNotNull(Transform t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyIfNotNull_Public_Static_Void_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarHelper()
	{
		Il2CppClassPointerStore<CarHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarHelper>.NativeClassPtr);
		NativeMethodInfoPtr_FlipRimIfShould_Public_Static_Void_GameObject_WheelType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666385);
		NativeMethodInfoPtr_FlipNormalRim_Private_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666386);
		NativeMethodInfoPtr_FlipHuayraRims_Private_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666387);
		NativeMethodInfoPtr_CalcRimSize_Public_Static_Void_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666388);
		NativeMethodInfoPtr_SetET_Public_Static_Void_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666389);
		NativeMethodInfoPtr_CalcTireSize_Public_Static_Void_GameObject_Transform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666390);
		NativeMethodInfoPtr_BakeSkinnedMesh_Public_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666391);
		NativeMethodInfoPtr_BakeMesh_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666392);
		NativeMethodInfoPtr_ScaleObjectToPositionY_Public_Static_Void_GameObject_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666393);
		NativeMethodInfoPtr_GetPositionFor_Public_Static_Vector3_byref_IniData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666394);
		NativeMethodInfoPtr_GetRotationFor_Public_Static_Vector3_byref_IniData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666395);
		NativeMethodInfoPtr_GetScaleFor_Public_Static_Single_byref_IniData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666396);
		NativeMethodInfoPtr_GetAbsorbersToConnectNames_Public_Static_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666397);
		NativeMethodInfoPtr_ProcessAllowedColors_Public_Static_Void_byref_List_1_AllowedColor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666398);
		NativeMethodInfoPtr_ProcessThumbnailColor_Public_Static_Void_byref_AllowedColor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666399);
		NativeMethodInfoPtr_SetRandomFactoryColor_Public_Static_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666400);
		NativeMethodInfoPtr_GenerateRandomCarColor_Public_Static_ColorHSV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666401);
		NativeMethodInfoPtr_CalcRadialFaultsCondition_Public_Static_Single_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666402);
		NativeMethodInfoPtr_GetRandomMileage_Public_Static_Int32_Int32_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666403);
		NativeMethodInfoPtr_GetRandomMileage_Public_Static_Int32_Int32_AuctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666404);
		NativeMethodInfoPtr_GetGlobalCondition_Public_Static_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666405);
		NativeMethodInfoPtr_GetGlobalCondition_Public_Static_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666406);
		NativeMethodInfoPtr_GetMissingBodyPartsChance_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666407);
		NativeMethodInfoPtr_GetMileagePriceMod_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666408);
		NativeMethodInfoPtr_GetRestorationMod_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666409);
		NativeMethodInfoPtr_SetXrayAlpha_Public_Static_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666410);
		NativeMethodInfoPtr_SetXrayAlpha_Public_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666411);
		NativeMethodInfoPtr_EnableRustOutside_Public_Static_Void_ArrayOf_Renderer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666412);
		NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_ArrayOf_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666413);
		NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666414);
		NativeMethodInfoPtr_UpdateCarBodyPart_Public_Static_Void_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666415);
		NativeMethodInfoPtr_SetRustMap_Public_Static_Void_Texture2D_ArrayOf_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666416);
		NativeMethodInfoPtr_SetDustValue_Public_Static_Void_ArrayOf_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666417);
		NativeMethodInfoPtr_SetDustValue_Public_Static_Void_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666418);
		NativeMethodInfoPtr_SetWashFactor_Public_Static_Void_ArrayOf_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666419);
		NativeMethodInfoPtr_GetRandomLicensePlate_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666420);
		NativeMethodInfoPtr_ProcessBonusPartsIds_Public_Static_Void_byref_List_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666421);
		NativeMethodInfoPtr_GetPartsToExamine_Public_Static_List_1_PartScript_CarLoader_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666422);
		NativeMethodInfoPtr_GetLocalizedCarOrigin_Public_Static_String_CarFrom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666423);
		NativeMethodInfoPtr_CheckEngineState_Public_Static_EngineState_CarLoader_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666424);
		NativeMethodInfoPtr_PartCanBeDented_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666425);
		NativeMethodInfoPtr_ReparentParts_Public_Static_Void_Transform_Transform_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666426);
		NativeMethodInfoPtr_DisableMotionVectors_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666427);
		NativeMethodInfoPtr_DisableSkinnedMotionVectors_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666428);
		NativeMethodInfoPtr_GetPaintBonus_Public_Static_Int32_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666429);
		NativeMethodInfoPtr_GetWashFactorBonus_Public_Static_Int32_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666430);
		NativeMethodInfoPtr_GetTireSizeString_Public_Static_String_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666431);
		NativeMethodInfoPtr_GetTireTypeFromID_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666432);
		NativeMethodInfoPtr_ClearFromChild_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666433);
		NativeMethodInfoPtr_DestroyIfNotNull_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarHelper>.NativeClassPtr, 100666434);
	}

	public CarHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
