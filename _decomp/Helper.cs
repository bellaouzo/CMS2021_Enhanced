using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CI.TaskParallel;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class Helper : Il2CppSystem.Object
{
	[ObfuscatedName("Helper/<>c__DisplayClass67_0")]
	public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_car;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomCars_b__0_Internal_Boolean_CarsIdWithConfig_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr));

		public unsafe CarsIdWithConfig car
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_car);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarsIdWithConfig(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_car), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass67_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _GetRandomCars_b__0(CarsIdWithConfig x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetRandomCars_b__0_Internal_Boolean_CarsIdWithConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass67_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, "<>c__DisplayClass67_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr);
			NativeFieldInfoPtr_car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "car");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100666601);
			NativeMethodInfoPtr__GetRandomCars_b__0_Internal_Boolean_CarsIdWithConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100666602);
		}

		public __c__DisplayClass67_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_AllTasksDone_Public_Static_Boolean_ArrayOf_UnityTask_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AllTasksDone_Public_Static_Boolean_ArrayOf_UnityTask_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ExistsInArray_Public_Static_Boolean_byref_ArrayOf_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ExistsInArray_Public_Static_Boolean_byref_ArrayOf_T_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_perlinrandom;

	private static readonly System.IntPtr NativeFieldInfoPtr_idDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_namesDictionary;

	private static readonly System.IntPtr NativeMethodInfoPtr_Noise_Public_Static_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatGoTo_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StepRandom_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EaseInOutSine_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PointIsInTriangle_Public_Static_Boolean_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDecimalPlaces_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWindow_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsStaticWindow_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOpenableWindow_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningValue_Public_Static_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRimPrice_Public_Static_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinRimPrice_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTirePrice_Public_Static_Int32_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinTirePrice_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrice_Public_Static_Int32_BaseItem_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrice_Public_Static_Int32_Item_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrice_Public_Static_Int32_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrice_Public_Static_Int32_String_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPriceWithQualityMod_Public_Static_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomRimData_Public_Static_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandNum_Private_Static_Single_Random_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandNum_Private_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrice_Public_Static_Int32_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemsCondition_Public_Static_Single_List_1_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroupCondition_Public_Static_String_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageGroupCondition_Public_Static_Single_GroupItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Between_Public_Static_Boolean_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMin_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitString_Public_Static_ArrayOf_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToHex_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToColor_Public_Static_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorToHex_Public_Static_String_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_V3Equal_Public_Static_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGroupSize_Public_Static_ArrayOf_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroupSize_Public_Static_Vector3_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ColorToArray_Public_Static_ArrayOf_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayToColor_Public_Static_Color_ArrayOf_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vector3ToArray_Public_Static_ArrayOf_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayToVector3_Public_Static_Vector3_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PowerToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TorqueToString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDistance_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConditionToString_Public_Static_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundCondition_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFileIfExists_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastIndexOf_Public_Static_Int32_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastIndexOf_Public_Static_Int32_Int32_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastLastIndexOf_Public_Static_Int32_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastArrayIndexOf_Public_Static_Int32_ArrayOf_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WhatIsMyID_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCacheForIDs_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCacheForIDs_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CachedWhatIsMyID_Public_Static_String_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexFromCarLoaderName_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BodyPartIsTuning_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotatePoint_Public_Static_Vector2_Vector2_Vector2_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KmToMph_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MetersToFeets_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KgToLbs_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllTasksDone_Public_Static_Boolean_ArrayOf_UnityTask_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomCars_Public_Static_List_1_CarsIdWithConfig_List_1_CarsIdWithConfig_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRawFile_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndMovePlayerIfNecessary_Public_Static_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseAllowedPlacesLevel_Public_Static_Boolean_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareColorsWithoutAlpha_Public_Static_Boolean_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileIsEmpty_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ButtonTypeToDragType_Public_Static_DragType_DragButtonType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ButtonTypeToDragLength_Public_Static_DragLength_DragButtonType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ButtonTypeToDragClass_Public_Static_DragClass_DragButtonType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDragLengthEqual_Public_Static_Boolean_DragCheckpointType_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExistsInArray_Public_Static_Boolean_byref_ArrayOf_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanGenerateDLCCar_Public_Static_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomDLCCar_Public_Static_CarsIdWithConfig_Int32_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomDLCCar_Public_Static_CarsIdWithConfig_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomDLCCar_Public_Static_String_Int32_SceneType_List_1_CarsIdWithConfig_List_1_CarsIdWithConfig_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Helper>.NativeClassPtr));

	public unsafe static Vector3 perlinrandom
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_perlinrandom, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_perlinrandom, &vector);
		}
	}

	public unsafe static Dictionary<string, string> idDictionary
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idDictionary, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Dictionary<string, string>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<int, string> namesDictionary
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_namesDictionary, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Dictionary<int, string>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_namesDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55305, RefRangeEnd = 55306, XrefRangeStart = 55272, XrefRangeEnd = 55305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Noise(float speed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Noise_Public_Static_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 55309, RefRangeEnd = 55325, XrefRangeStart = 55306, XrefRangeEnd = 55309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float FloatGoTo(float from, float to, float speed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatGoTo_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 55327, RefRangeEnd = 55332, XrefRangeStart = 55325, XrefRangeEnd = 55327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float StepRandom(float min, float max, float step)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &step;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StepRandom_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55332, XrefRangeEnd = 55333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ClampAngle(float angle, float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&angle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe static float EaseInOutSine(float start, float end, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EaseInOutSine_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55333, XrefRangeEnd = 55334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PointIsInTriangle(float ax, float ay, float bx, float by, float cx, float cy, float px, float py)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&ax);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ay;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bx;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &by;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cx;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &px;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &py;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PointIsInTriangle_Public_Static_Boolean_Single_Single_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 55337, RefRangeEnd = 55341, XrefRangeStart = 55334, XrefRangeEnd = 55337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDecimalPlaces(float n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDecimalPlaces_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55347, RefRangeEnd = 55349, XrefRangeStart = 55341, XrefRangeEnd = 55347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReadAllText(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55353, RefRangeEnd = 55354, XrefRangeStart = 55349, XrefRangeEnd = 55353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWindow(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWindow_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55367, RefRangeEnd = 55369, XrefRangeStart = 55354, XrefRangeEnd = 55367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsStaticWindow(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStaticWindow_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55382, RefRangeEnd = 55385, XrefRangeStart = 55369, XrefRangeEnd = 55382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOpenableWindow(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOpenableWindow_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float GetTuningValue(float power, float condition, int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&power);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningValue_Public_Static_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 55387, RefRangeEnd = 55391, XrefRangeStart = 55385, XrefRangeEnd = 55387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRimPrice(string rimName, int rimSize, int et)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rimName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rimSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &et;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRimPrice_Public_Static_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55391, XrefRangeEnd = 55396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMinRimPrice(string tireName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tireName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinRimPrice_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 55402, RefRangeEnd = 55410, XrefRangeStart = 55396, XrefRangeEnd = 55402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTirePrice(string tireName, int tireWidth, int tireProfile, int tireSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tireName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tireWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tireProfile;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tireSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTirePrice_Public_Static_Int32_String_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55410, XrefRangeEnd = 55414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMinTirePrice(string tireName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tireName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinTirePrice_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55456, RefRangeEnd = 55457, XrefRangeStart = 55414, XrefRangeEnd = 55456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrice(BaseItem baseItem, [Optional] float mod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseItem);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mod;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrice_Public_Static_Int32_BaseItem_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 55475, RefRangeEnd = 55486, XrefRangeStart = 55457, XrefRangeEnd = 55475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrice(Item item, [Optional] float mod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mod;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrice_Public_Static_Int32_Item_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55496, RefRangeEnd = 55499, XrefRangeStart = 55486, XrefRangeEnd = 55496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrice(PartScript part)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(part);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrice_Public_Static_Int32_PartScript_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55508, RefRangeEnd = 55510, XrefRangeStart = 55499, XrefRangeEnd = 55508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrice(string partID, float condition, int quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrice_Public_Static_Int32_String_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float GetPriceWithQualityMod(int quality, float finalPrice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&quality);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalPrice;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPriceWithQualityMod_Public_Static_Single_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 55538, RefRangeEnd = 55542, XrefRangeStart = 55510, XrefRangeEnd = 55538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetRandomRimData()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomRimData_Public_Static_Vector3_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55550, RefRangeEnd = 55553, XrefRangeStart = 55542, XrefRangeEnd = 55550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RandNum(Il2CppSystem.Random rnd, float min, float max, float step)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rnd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &step;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandNum_Private_Static_Single_Random_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55553, XrefRangeEnd = 55561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RandNum(float min, float max, float step)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &step;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandNum_Private_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55568, RefRangeEnd = 55569, XrefRangeStart = 55561, XrefRangeEnd = 55568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrice(GroupItem group)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrice_Public_Static_Int32_GroupItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55569, XrefRangeEnd = 55572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetItemsCondition(List<PartScript> parts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemsCondition_Public_Static_Single_List_1_PartScript_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55583, RefRangeEnd = 55585, XrefRangeStart = 55572, XrefRangeEnd = 55583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGroupCondition(GroupItem group)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroupCondition_Public_Static_String_GroupItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55588, RefRangeEnd = 55591, XrefRangeStart = 55585, XrefRangeEnd = 55588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAverageGroupCondition(GroupItem group)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAverageGroupCondition_Public_Static_Single_GroupItem_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55591, XrefRangeEnd = 55592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Angle(float cx, float cy, float ex, float ey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cx);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ex;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ey;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Angle_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool Between(float number, float rangeX, float rangeY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&number);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeX;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Between_Public_Static_Boolean_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float GetMin(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMin_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55592, XrefRangeEnd = 55596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray SplitString(string text, char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitString_Public_Static_ArrayOf_String_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55596, XrefRangeEnd = 55606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int StringToHex(string hexValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hexValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToHex_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 55631, RefRangeEnd = 55653, XrefRangeStart = 55606, XrefRangeEnd = 55631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color HexToColor(string hex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToColor_Public_Static_Color_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 55654, RefRangeEnd = 55661, XrefRangeStart = 55653, XrefRangeEnd = 55654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ColorToHex(Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorToHex_Public_Static_String_Color32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static bool V3Equal(Vector3 a, Vector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_V3Equal_Public_Static_Boolean_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55661, XrefRangeEnd = 55664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> SetGroupSize(Vector3 size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGroupSize_Public_Static_ArrayOf_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetGroupSize(Il2CppStructArray<float> size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroupSize_Public_Static_Vector3_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 55667, RefRangeEnd = 55673, XrefRangeStart = 55664, XrefRangeEnd = 55667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> ColorToArray(Color size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ColorToArray_Public_Static_ArrayOf_Single_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static Color ArrayToColor(Il2CppStructArray<float> size, bool withAlpha = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(size);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAlpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayToColor_Public_Static_Color_ArrayOf_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55673, XrefRangeEnd = 55676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> Vector3ToArray(Vector3 vector3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vector3ToArray_Public_Static_ArrayOf_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static Vector3 ArrayToVector3(Il2CppStructArray<float> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayToVector3_Public_Static_Vector3_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55676, XrefRangeEnd = 55706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PowerToString(float valueHP)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueHP);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PowerToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55706, XrefRangeEnd = 55738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TorqueToString(float valueNm)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueNm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TorqueToString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55738, XrefRangeEnd = 55742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetDistance(float valueKM)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueKM);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDistance_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 55755, RefRangeEnd = 55771, XrefRangeStart = 55742, XrefRangeEnd = 55755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ConditionToString(float condition, bool round = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&condition);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &round;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConditionToString_Public_Static_String_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 55775, RefRangeEnd = 55783, XrefRangeStart = 55771, XrefRangeEnd = 55775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RoundCondition(float condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&condition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundCondition_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55783, XrefRangeEnd = 55785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteFileIfExists(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFileIfExists_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55811, RefRangeEnd = 55812, XrefRangeStart = 55785, XrefRangeEnd = 55811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteDirectory(string target_dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target_dir);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 55813, RefRangeEnd = 55843, XrefRangeStart = 55812, XrefRangeEnd = 55813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FastIndexOf(string text, char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastIndexOf_Public_Static_Int32_String_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55843, XrefRangeEnd = 55844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FastIndexOf(int startPos, string text, char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&startPos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastIndexOf_Public_Static_Int32_Int32_String_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static int FastLastIndexOf(string text, char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastLastIndexOf_Public_Static_Int32_String_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 55845, RefRangeEnd = 55851, XrefRangeStart = 55844, XrefRangeEnd = 55845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FastArrayIndexOf(Il2CppStringArray array, string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastArrayIndexOf_Public_Static_Int32_ArrayOf_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 55856, RefRangeEnd = 55903, XrefRangeStart = 55851, XrefRangeEnd = 55856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string WhatIsMyID(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WhatIsMyID_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55903, XrefRangeEnd = 55931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateCacheForIDs()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCacheForIDs_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55946, RefRangeEnd = 55949, XrefRangeStart = 55931, XrefRangeEnd = 55946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearCacheForIDs()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCacheForIDs_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 55978, RefRangeEnd = 55980, XrefRangeStart = 55949, XrefRangeEnd = 55978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CachedWhatIsMyID(Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CachedWhatIsMyID_Public_Static_String_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 55997, RefRangeEnd = 56003, XrefRangeStart = 55980, XrefRangeEnd = 55997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIndexFromCarLoaderName(string carLoaderName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carLoaderName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndexFromCarLoaderName_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56003, XrefRangeEnd = 56007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool BodyPartIsTuning(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BodyPartIsTuning_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56007, XrefRangeEnd = 56012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 RotatePoint(Vector2 pointToRotate, Vector2 centerPoint, double angleInDegrees)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&pointToRotate);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerPoint;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &angleInDegrees;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotatePoint_Public_Static_Vector2_Vector2_Vector2_Double_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float KmToMph(float valueKM)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueKM);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KmToMph_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float MetersToFeets(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MetersToFeets_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float KgToLbs(float valueKg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueKg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KgToLbs_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56012, XrefRangeEnd = 56013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AllTasksDone<T>(Il2CppReferenceArray<UnityTask<T>> tasks)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AllTasksDone_Public_Static_Boolean_ArrayOf_UnityTask_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56046, RefRangeEnd = 56049, XrefRangeStart = 56013, XrefRangeEnd = 56046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarsIdWithConfig> GetRandomCars(List<CarsIdWithConfig> cars, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomCars_Public_Static_List_1_CarsIdWithConfig_List_1_CarsIdWithConfig_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<CarsIdWithConfig>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56049, XrefRangeEnd = 56052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRawFile(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRawFile_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56078, RefRangeEnd = 56080, XrefRangeStart = 56052, XrefRangeEnd = 56078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckAndMovePlayerIfNecessary(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndMovePlayerIfNecessary_Public_Static_Void_CarLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56096, RefRangeEnd = 56097, XrefRangeStart = 56080, XrefRangeEnd = 56096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseAllowedPlacesLevel(string allowedPlaces, out int fromLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(allowedPlaces);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref fromLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseAllowedPlacesLevel_Public_Static_Boolean_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56097, RefRangeEnd = 56100, XrefRangeStart = 56097, XrefRangeEnd = 56097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareColorsWithoutAlpha(Color left, Color right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareColorsWithoutAlpha_Public_Static_Boolean_Color_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56100, XrefRangeEnd = 56109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FileIsEmpty(string pathToFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToFile);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileIsEmpty_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static DragType ButtonTypeToDragType(DragButtonType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ButtonTypeToDragType_Public_Static_DragType_DragButtonType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DragType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static DragLength ButtonTypeToDragLength(DragButtonType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ButtonTypeToDragLength_Public_Static_DragLength_DragButtonType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DragLength*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static DragClass ButtonTypeToDragClass(DragButtonType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ButtonTypeToDragClass_Public_Static_DragClass_DragButtonType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DragClass*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56109, RefRangeEnd = 56111, XrefRangeStart = 56109, XrefRangeEnd = 56109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDragLengthEqual(DragCheckpointType checkpointType, DragLength dragLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&checkpointType);
		*(DragLength**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDragLengthEqual_Public_Static_Boolean_DragCheckpointType_DragLength_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56111, XrefRangeEnd = 56112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ExistsInArray<T>(ref Il2CppArrayBase<T> array, T element)
	{
		//IL_008b->IL0090: Incompatible stack types: I vs Ref
		//IL_0067->IL0090: Incompatible stack types: I vs Ref
		//IL_0074->IL0090: Incompatible stack types: I vs Ref
		//IL_007e->IL0090: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = element;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr2;
				if (intPtr2 != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr2;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr2)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr2);
					}
				}
			}
		}
		else
		{
			reference = ref element;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ExistsInArray_Public_Static_Boolean_byref_ArrayOf_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		array = (Il2CppArrayBase<T>)(object)((intPtr3 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 56124, RefRangeEnd = 56129, XrefRangeStart = 56112, XrefRangeEnd = 56124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanGenerateDLCCar(out int dlc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dlc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanGenerateDLCCar_Public_Static_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56129, XrefRangeEnd = 56139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CarsIdWithConfig GetRandomDLCCar(int dlc, SceneType sceneType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dlc);
		*(SceneType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomDLCCar_Public_Static_CarsIdWithConfig_Int32_SceneType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarsIdWithConfig(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56155, RefRangeEnd = 56156, XrefRangeStart = 56139, XrefRangeEnd = 56155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CarsIdWithConfig GetRandomDLCCar(int dlc, int level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dlc);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomDLCCar_Public_Static_CarsIdWithConfig_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarsIdWithConfig(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56174, RefRangeEnd = 56177, XrefRangeStart = 56156, XrefRangeEnd = 56174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AddRandomDLCCar(int dlc, SceneType sceneType, List<CarsIdWithConfig> availableCars, List<CarsIdWithConfig> randomCars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&dlc);
		*(SceneType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(availableCars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(randomCars);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRandomDLCCar_Public_Static_String_Int32_SceneType_List_1_CarsIdWithConfig_List_1_CarsIdWithConfig_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static Helper()
	{
		Il2CppClassPointerStore<Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Helper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper>.NativeClassPtr);
		NativeFieldInfoPtr_perlinrandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, "perlinrandom");
		NativeFieldInfoPtr_idDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, "idDictionary");
		NativeFieldInfoPtr_namesDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, "namesDictionary");
		NativeMethodInfoPtr_Noise_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666521);
		NativeMethodInfoPtr_FloatGoTo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666522);
		NativeMethodInfoPtr_StepRandom_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666523);
		NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666524);
		NativeMethodInfoPtr_EaseInOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666525);
		NativeMethodInfoPtr_PointIsInTriangle_Public_Static_Boolean_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666526);
		NativeMethodInfoPtr_GetDecimalPlaces_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666527);
		NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666528);
		NativeMethodInfoPtr_IsWindow_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666529);
		NativeMethodInfoPtr_IsStaticWindow_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666530);
		NativeMethodInfoPtr_IsOpenableWindow_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666531);
		NativeMethodInfoPtr_GetTuningValue_Public_Static_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666532);
		NativeMethodInfoPtr_GetRimPrice_Public_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666533);
		NativeMethodInfoPtr_GetMinRimPrice_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666534);
		NativeMethodInfoPtr_GetTirePrice_Public_Static_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666535);
		NativeMethodInfoPtr_GetMinTirePrice_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666536);
		NativeMethodInfoPtr_GetPrice_Public_Static_Int32_BaseItem_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666537);
		NativeMethodInfoPtr_GetPrice_Public_Static_Int32_Item_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666538);
		NativeMethodInfoPtr_GetPrice_Public_Static_Int32_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666539);
		NativeMethodInfoPtr_GetPrice_Public_Static_Int32_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666540);
		NativeMethodInfoPtr_GetPriceWithQualityMod_Public_Static_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666541);
		NativeMethodInfoPtr_GetRandomRimData_Public_Static_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666542);
		NativeMethodInfoPtr_RandNum_Private_Static_Single_Random_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666543);
		NativeMethodInfoPtr_RandNum_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666544);
		NativeMethodInfoPtr_GetPrice_Public_Static_Int32_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666545);
		NativeMethodInfoPtr_GetItemsCondition_Public_Static_Single_List_1_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666546);
		NativeMethodInfoPtr_GetGroupCondition_Public_Static_String_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666547);
		NativeMethodInfoPtr_GetAverageGroupCondition_Public_Static_Single_GroupItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666548);
		NativeMethodInfoPtr_Angle_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666549);
		NativeMethodInfoPtr_Between_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666550);
		NativeMethodInfoPtr_GetMin_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666551);
		NativeMethodInfoPtr_SplitString_Public_Static_ArrayOf_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666552);
		NativeMethodInfoPtr_StringToHex_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666553);
		NativeMethodInfoPtr_HexToColor_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666554);
		NativeMethodInfoPtr_ColorToHex_Public_Static_String_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666555);
		NativeMethodInfoPtr_V3Equal_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666556);
		NativeMethodInfoPtr_SetGroupSize_Public_Static_ArrayOf_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666557);
		NativeMethodInfoPtr_GetGroupSize_Public_Static_Vector3_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666558);
		NativeMethodInfoPtr_ColorToArray_Public_Static_ArrayOf_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666559);
		NativeMethodInfoPtr_ArrayToColor_Public_Static_Color_ArrayOf_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666560);
		NativeMethodInfoPtr_Vector3ToArray_Public_Static_ArrayOf_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666561);
		NativeMethodInfoPtr_ArrayToVector3_Public_Static_Vector3_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666562);
		NativeMethodInfoPtr_PowerToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666563);
		NativeMethodInfoPtr_TorqueToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666564);
		NativeMethodInfoPtr_GetDistance_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666565);
		NativeMethodInfoPtr_ConditionToString_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666566);
		NativeMethodInfoPtr_RoundCondition_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666567);
		NativeMethodInfoPtr_DeleteFileIfExists_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666568);
		NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666569);
		NativeMethodInfoPtr_FastIndexOf_Public_Static_Int32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666570);
		NativeMethodInfoPtr_FastIndexOf_Public_Static_Int32_Int32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666571);
		NativeMethodInfoPtr_FastLastIndexOf_Public_Static_Int32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666572);
		NativeMethodInfoPtr_FastArrayIndexOf_Public_Static_Int32_ArrayOf_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666573);
		NativeMethodInfoPtr_WhatIsMyID_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666574);
		NativeMethodInfoPtr_CreateCacheForIDs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666575);
		NativeMethodInfoPtr_ClearCacheForIDs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666576);
		NativeMethodInfoPtr_CachedWhatIsMyID_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666577);
		NativeMethodInfoPtr_GetIndexFromCarLoaderName_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666578);
		NativeMethodInfoPtr_BodyPartIsTuning_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666579);
		NativeMethodInfoPtr_RotatePoint_Public_Static_Vector2_Vector2_Vector2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666580);
		NativeMethodInfoPtr_KmToMph_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666581);
		NativeMethodInfoPtr_MetersToFeets_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666582);
		NativeMethodInfoPtr_KgToLbs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666583);
		NativeMethodInfoPtr_AllTasksDone_Public_Static_Boolean_ArrayOf_UnityTask_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666584);
		NativeMethodInfoPtr_GetRandomCars_Public_Static_List_1_CarsIdWithConfig_List_1_CarsIdWithConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666585);
		NativeMethodInfoPtr_IsRawFile_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666586);
		NativeMethodInfoPtr_CheckAndMovePlayerIfNecessary_Public_Static_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666587);
		NativeMethodInfoPtr_ParseAllowedPlacesLevel_Public_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666588);
		NativeMethodInfoPtr_CompareColorsWithoutAlpha_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666589);
		NativeMethodInfoPtr_FileIsEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666590);
		NativeMethodInfoPtr_ButtonTypeToDragType_Public_Static_DragType_DragButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666591);
		NativeMethodInfoPtr_ButtonTypeToDragLength_Public_Static_DragLength_DragButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666592);
		NativeMethodInfoPtr_ButtonTypeToDragClass_Public_Static_DragClass_DragButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666593);
		NativeMethodInfoPtr_IsDragLengthEqual_Public_Static_Boolean_DragCheckpointType_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666594);
		NativeMethodInfoPtr_ExistsInArray_Public_Static_Boolean_byref_ArrayOf_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666595);
		NativeMethodInfoPtr_CanGenerateDLCCar_Public_Static_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666596);
		NativeMethodInfoPtr_GetRandomDLCCar_Public_Static_CarsIdWithConfig_Int32_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666597);
		NativeMethodInfoPtr_GetRandomDLCCar_Public_Static_CarsIdWithConfig_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666598);
		NativeMethodInfoPtr_AddRandomDLCCar_Public_Static_String_Int32_SceneType_List_1_CarsIdWithConfig_List_1_CarsIdWithConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100666599);
	}

	public Helper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
