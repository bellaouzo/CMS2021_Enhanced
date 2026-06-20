using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers;

public static class CarPerformanceHelper : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Params : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_EngineID;

		private static readonly System.IntPtr NativeFieldInfoPtr_EngineScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_EngineTorqueMod;

		private static readonly System.IntPtr NativeFieldInfoPtr_EngineRPMMod;

		private static readonly System.IntPtr NativeFieldInfoPtr_CarWeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_TransmissionType;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Params>.NativeClassPtr));

		public unsafe string EngineID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineID), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe float EngineScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineScale)) = num;
			}
		}

		public unsafe float EngineTorqueMod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineTorqueMod);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineTorqueMod)) = num;
			}
		}

		public unsafe float EngineRPMMod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineRPMMod);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineRPMMod)) = num;
			}
		}

		public unsafe float CarWeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarWeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarWeight)) = num;
			}
		}

		public unsafe string TransmissionType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransmissionType);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransmissionType), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		static Params()
		{
			Il2CppClassPointerStore<Params>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, "Params");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Params>.NativeClassPtr);
			NativeFieldInfoPtr_EngineID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Params>.NativeClassPtr, "EngineID");
			NativeFieldInfoPtr_EngineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Params>.NativeClassPtr, "EngineScale");
			NativeFieldInfoPtr_EngineTorqueMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Params>.NativeClassPtr, "EngineTorqueMod");
			NativeFieldInfoPtr_EngineRPMMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Params>.NativeClassPtr, "EngineRPMMod");
			NativeFieldInfoPtr_CarWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Params>.NativeClassPtr, "CarWeight");
			NativeFieldInfoPtr_TransmissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Params>.NativeClassPtr, "TransmissionType");
		}

		public Params(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe Params()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Params>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Params>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcGripMod_Public_Static_Single_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcGripMod_Public_Static_Single_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Private_Static_Single_String_String_String_String_byref_EngineData_Single_String_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Boolean_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Single_Single_Single_Single_Single_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_byref_Params_Single_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_byref_Params_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Single_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_String_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_Single_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_CarLoader_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_byref_Params_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_byref_Params_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcCurrentPerformanceIndex_Public_Static_Single_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarMaxTuning_Public_Static_Single_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTuningForParts_Public_Static_Single_ArrayOf_PartScript_Func_2_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_String_PDM_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr));

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 212521, RefRangeEnd = 212524, XrefRangeStart = 212516, XrefRangeEnd = 212521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcGripMod(string frontLeftTire, string frontRightTire, string rearLeftTire, string rearRightTire)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(frontLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontRightTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearRightTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcGripMod_Public_Static_Single_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 212527, RefRangeEnd = 212531, XrefRangeStart = 212524, XrefRangeEnd = 212527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcGripMod(string leftTire, string rightTire)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(leftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rightTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcGripMod_Public_Static_Single_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 212542, RefRangeEnd = 212551, XrefRangeStart = 212531, XrefRangeEnd = 212542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(string frontLeftTire, string frontRightTire, string rearLeftTire, string rearRightTire, ref EngineData engineData, float weight, string transmissionType, out float gripMod, out float maxPower)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(frontLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontRightTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearRightTire);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref engineData);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(transmissionType);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref gripMod);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref maxPower);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Private_Static_Single_String_String_String_String_byref_EngineData_Single_String_byref_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212551, XrefRangeEnd = 212556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(CarLoader carLoader, bool useMaxTuning, string frontLeftTire = "", string frontRightTire = "", string rearLeftTire = "", string rearRightTire = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useMaxTuning;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontRightTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearRightTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Boolean_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212556, XrefRangeEnd = 212559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(CarLoader carLoader, float tuningValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212559, XrefRangeEnd = 212561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(string engineName, float engineScale, float torqueMod, float rpmMod, float carWeight, float tuningValue, string tireType, string transmissionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engineName);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &engineScale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &torqueMod;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmMod;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &carWeight;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tireType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(transmissionType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Single_Single_Single_Single_Single_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 212563, RefRangeEnd = 212569, XrefRangeStart = 212561, XrefRangeEnd = 212563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(ref Params calcParams, float tuningValue, Il2CppStringArray tires)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(calcParams);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tires);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_byref_Params_Single_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 212571, RefRangeEnd = 212575, XrefRangeStart = 212569, XrefRangeEnd = 212571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(ref Params calcParams, float tuningValue, string tireType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(calcParams);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tireType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_byref_Params_Single_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 212607, RefRangeEnd = 212622, XrefRangeStart = 212575, XrefRangeEnd = 212607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(CarLoader carLoader, float tuningValue, string frontLeftTire = "", string frontRightTire = "", string rearLeftTire = "", string rearRightTire = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontRightTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearRightTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Single_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212622, XrefRangeEnd = 212631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 212712, RefRangeEnd = 212715, XrefRangeStart = 212631, XrefRangeEnd = 212712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(string carID, int config, string engine, float tuningValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engine);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 212757, RefRangeEnd = 212760, XrefRangeStart = 212715, XrefRangeEnd = 212757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(string carID, int config, string engine, float tuningValue, string tire)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engine);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_String_Single_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 212808, RefRangeEnd = 212809, XrefRangeStart = 212760, XrefRangeEnd = 212808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPerformanceIndex(string carID, int config, float tuningValue, string frontTire, string rearTire)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_Single_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212811, RefRangeEnd = 212813, XrefRangeStart = 212809, XrefRangeEnd = 212811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerformanceIndexPerPercent(CarLoader carLoader, string frontLeftTire = "", string frontRightTire = "", string rearLeftTire = "", string rearRightTire = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(frontRightTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearLeftTire);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rearRightTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_CarLoader_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212813, XrefRangeEnd = 212815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerformanceIndexPerPercent(ref Params calcParams, Il2CppStringArray tires)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(calcParams);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tires);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_byref_Params_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 212817, RefRangeEnd = 212818, XrefRangeStart = 212815, XrefRangeEnd = 212817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerformanceIndexPerPercent(ref Params calcParams, string tireType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(calcParams);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tireType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_byref_Params_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 212835, RefRangeEnd = 212838, XrefRangeStart = 212818, XrefRangeEnd = 212835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcCurrentPerformanceIndex(NewCarData carData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcCurrentPerformanceIndex_Public_Static_Single_NewCarData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212864, RefRangeEnd = 212866, XrefRangeStart = 212838, XrefRangeEnd = 212864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetCarMaxTuning(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarMaxTuning_Public_Static_Single_CarLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212889, RefRangeEnd = 212891, XrefRangeStart = 212866, XrefRangeEnd = 212889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetMaxTuningForParts(Il2CppReferenceArray<PartScript> parts, Il2CppSystem.Func<string, float> GetTuningValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(GetTuningValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTuningForParts_Public_Static_Single_ArrayOf_PartScript_Func_2_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212891, XrefRangeEnd = 212893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Method_Internal_Static_Single_String_PDM_0(string partID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(partID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_String_PDM_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static CarPerformanceHelper()
	{
		Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "CarPerformanceHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr);
		NativeMethodInfoPtr_CalcGripMod_Public_Static_Single_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679273);
		NativeMethodInfoPtr_CalcGripMod_Public_Static_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679274);
		NativeMethodInfoPtr_CalcPerformanceIndex_Private_Static_Single_String_String_String_String_byref_EngineData_Single_String_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679275);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Boolean_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679276);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679277);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Single_Single_Single_Single_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679278);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_byref_Params_Single_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679279);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_byref_Params_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679280);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_CarLoader_Single_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679281);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679282);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679283);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679284);
		NativeMethodInfoPtr_CalcPerformanceIndex_Public_Static_Single_String_Int32_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679285);
		NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_CarLoader_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679286);
		NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_byref_Params_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679287);
		NativeMethodInfoPtr_GetPerformanceIndexPerPercent_Public_Static_Single_byref_Params_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679288);
		NativeMethodInfoPtr_CalcCurrentPerformanceIndex_Public_Static_Single_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679289);
		NativeMethodInfoPtr_GetCarMaxTuning_Public_Static_Single_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679290);
		NativeMethodInfoPtr_GetMaxTuningForParts_Public_Static_Single_ArrayOf_PartScript_Func_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679291);
		NativeMethodInfoPtr_Method_Internal_Static_Single_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPerformanceHelper>.NativeClassPtr, 100679292);
	}

	public CarPerformanceHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
