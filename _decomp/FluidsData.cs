using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class FluidsData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Oil;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brake;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineCoolant;

	private static readonly System.IntPtr NativeFieldInfoPtr_PowerSteering;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindscreenWash;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeFluids_Private_Void_BinaryWriter_List_1_FluidData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeFluids_Private_Void_BinaryReader_byref_List_1_FluidData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_FluidsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Void_FluidsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_CarFluid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveReservoir_Public_Boolean_CarFluidType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLevelAndCondition_Public_Void_Single_Single_CarFluidType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLevelAndConditionOnAll_Public_Void_Single_Single_CarFluidType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLevel_Public_Single_CarFluidType_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLevel_Public_Void_Single_CarFluidType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCondition_Public_Single_CarFluidType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCondition_Public_Void_Single_CarFluidType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFluid_Public_Void_Single_Single_CarFluidType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomLevel_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomCondition_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvgLevel_Public_Single_CarFluidType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvgCondition_Public_Single_CarFluidType_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FluidsData>.NativeClassPtr));

	public unsafe FluidData Oil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Oil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new FluidData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Oil), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<FluidData> Brake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brake);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<FluidData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brake), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<FluidData> EngineCoolant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineCoolant);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<FluidData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineCoolant), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<FluidData> PowerSteering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PowerSteering);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<FluidData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PowerSteering), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<FluidData> WindscreenWash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindscreenWash);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<FluidData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindscreenWash), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93620, RefRangeEnd = 93621, XrefRangeStart = 93615, XrefRangeEnd = 93620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93625, RefRangeEnd = 93626, XrefRangeStart = 93621, XrefRangeEnd = 93625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 93629, RefRangeEnd = 93633, XrefRangeStart = 93626, XrefRangeEnd = 93629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeFluids(BinaryWriter binaryWriter, List<FluidData> fluids)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fluids);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeFluids_Private_Void_BinaryWriter_List_1_FluidData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 93645, RefRangeEnd = 93649, XrefRangeStart = 93633, XrefRangeEnd = 93645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeserializeFluids(BinaryReader binaryReader, ref List<FluidData> fluids)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(fluids);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeFluids_Private_Void_BinaryReader_byref_List_1_FluidData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		fluids = (List<FluidData>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93711, RefRangeEnd = 93712, XrefRangeStart = 93649, XrefRangeEnd = 93711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save(FluidsData fluidsData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fluidsData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_FluidsData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93712, XrefRangeEnd = 93746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Copy(FluidsData fluidsData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fluidsData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Void_FluidsData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 93777, RefRangeEnd = 93781, XrefRangeStart = 93746, XrefRangeEnd = 93777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93791, RefRangeEnd = 93792, XrefRangeStart = 93781, XrefRangeEnd = 93791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(CarFluid carFluid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carFluid);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_CarFluid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 93796, RefRangeEnd = 93805, XrefRangeStart = 93792, XrefRangeEnd = 93796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveReservoir(CarFluidType carFluidType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&carFluidType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveReservoir_Public_Boolean_CarFluidType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 93817, RefRangeEnd = 93835, XrefRangeStart = 93805, XrefRangeEnd = 93817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLevelAndCondition(float level, float condition, CarFluidType carFluidType, [Optional] int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&level);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(CarFluidType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &carFluidType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLevelAndCondition_Public_Void_Single_Single_CarFluidType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 93847, RefRangeEnd = 93862, XrefRangeStart = 93835, XrefRangeEnd = 93847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLevelAndConditionOnAll(float level, float condition, CarFluidType carFluidType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&level);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(CarFluidType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &carFluidType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLevelAndConditionOnAll_Public_Void_Single_Single_CarFluidType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 93866, RefRangeEnd = 93893, XrefRangeStart = 93862, XrefRangeEnd = 93866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLevel(CarFluidType carFluidType, [Optional] int id, bool isElectric = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&carFluidType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isElectric;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLevel_Public_Single_CarFluidType_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 93897, RefRangeEnd = 93908, XrefRangeStart = 93893, XrefRangeEnd = 93897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLevel(float level, CarFluidType carFluidType, [Optional] int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&level);
		*(CarFluidType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carFluidType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLevel_Public_Void_Single_CarFluidType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93909, RefRangeEnd = 93911, XrefRangeStart = 93908, XrefRangeEnd = 93909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCondition(CarFluidType carFluidType, [Optional] int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&carFluidType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCondition_Public_Single_CarFluidType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 93915, RefRangeEnd = 93926, XrefRangeStart = 93911, XrefRangeEnd = 93915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCondition(float condition, CarFluidType carFluidType, [Optional] int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&condition);
		*(CarFluidType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carFluidType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCondition_Public_Void_Single_CarFluidType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93931, RefRangeEnd = 93933, XrefRangeStart = 93926, XrefRangeEnd = 93931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFluid(float level, float condition, CarFluidType carFluidType, [Optional] int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&level);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(CarFluidType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &carFluidType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFluid_Public_Void_Single_Single_CarFluidType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 93952, RefRangeEnd = 93957, XrefRangeStart = 93933, XrefRangeEnd = 93952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRandomLevel(float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRandomLevel_Public_Void_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 93976, RefRangeEnd = 93981, XrefRangeStart = 93957, XrefRangeEnd = 93976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRandomCondition(float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRandomCondition_Public_Void_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 93984, RefRangeEnd = 94003, XrefRangeStart = 93981, XrefRangeEnd = 93984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAvgLevel(CarFluidType carFluidType, bool isElectric = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&carFluidType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isElectric;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvgLevel_Public_Single_CarFluidType_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 94006, RefRangeEnd = 94010, XrefRangeStart = 94003, XrefRangeEnd = 94006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAvgCondition(CarFluidType carFluidType, bool isElectric = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&carFluidType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isElectric;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvgCondition_Public_Single_CarFluidType_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static FluidsData()
	{
		Il2CppClassPointerStore<FluidsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FluidsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FluidsData>.NativeClassPtr);
		NativeFieldInfoPtr_Oil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, "Oil");
		NativeFieldInfoPtr_Brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, "Brake");
		NativeFieldInfoPtr_EngineCoolant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, "EngineCoolant");
		NativeFieldInfoPtr_PowerSteering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, "PowerSteering");
		NativeFieldInfoPtr_WindscreenWash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, "WindscreenWash");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668705);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668706);
		NativeMethodInfoPtr_SerializeFluids_Private_Void_BinaryWriter_List_1_FluidData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668707);
		NativeMethodInfoPtr_DeserializeFluids_Private_Void_BinaryReader_byref_List_1_FluidData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668708);
		NativeMethodInfoPtr_Save_Public_Void_FluidsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668709);
		NativeMethodInfoPtr_Copy_Public_Void_FluidsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668710);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668711);
		NativeMethodInfoPtr_Add_Public_Void_CarFluid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668712);
		NativeMethodInfoPtr_HaveReservoir_Public_Boolean_CarFluidType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668713);
		NativeMethodInfoPtr_SetLevelAndCondition_Public_Void_Single_Single_CarFluidType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668714);
		NativeMethodInfoPtr_SetLevelAndConditionOnAll_Public_Void_Single_Single_CarFluidType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668715);
		NativeMethodInfoPtr_GetLevel_Public_Single_CarFluidType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668716);
		NativeMethodInfoPtr_SetLevel_Public_Void_Single_CarFluidType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668717);
		NativeMethodInfoPtr_GetCondition_Public_Single_CarFluidType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668718);
		NativeMethodInfoPtr_SetCondition_Public_Void_Single_CarFluidType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668719);
		NativeMethodInfoPtr_AddFluid_Public_Void_Single_Single_CarFluidType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668720);
		NativeMethodInfoPtr_SetRandomLevel_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668721);
		NativeMethodInfoPtr_SetRandomCondition_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668722);
		NativeMethodInfoPtr_GetAvgLevel_Public_Single_CarFluidType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668723);
		NativeMethodInfoPtr_GetAvgCondition_Public_Single_CarFluidType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, 100668724);
	}

	public FluidsData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe FluidsData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FluidsData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<FluidsData>.NativeClassPtr))
	{
	}
}
