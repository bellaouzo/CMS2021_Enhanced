using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct EngineData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isElectric;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleRpmTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleRpmCurveBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_peakRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_peakRpmTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_peakRpmCurveBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_inertia;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineFrictionTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineFrictionRotational;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineFrictionViscous;

	private static readonly System.IntPtr NativeFieldInfoPtr_limiterTriggerRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_measured;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EngineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeOnDefaultIfZero_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_CarLoader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_String_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentEngineData_Public_EngineData_CarLoader_Boolean_Single_0;

	[FieldOffset(0)]
	public bool isElectric;

	[FieldOffset(4)]
	public float idleRpm;

	[FieldOffset(8)]
	public float idleRpmTorque;

	[FieldOffset(12)]
	public float idleRpmCurveBias;

	[FieldOffset(16)]
	public float peakRpm;

	[FieldOffset(20)]
	public float peakRpmTorque;

	[FieldOffset(24)]
	public float peakRpmCurveBias;

	[FieldOffset(28)]
	public float maxRpm;

	[FieldOffset(32)]
	public float inertia;

	[FieldOffset(36)]
	public float engineFrictionTorque;

	[FieldOffset(40)]
	public float engineFrictionRotational;

	[FieldOffset(44)]
	public float engineFrictionViscous;

	[FieldOffset(48)]
	public float limiterTriggerRpm;

	[FieldOffset(52)]
	public float tuningValue;

	[FieldOffset(56)]
	public bool measured;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineData>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93456, RefRangeEnd = 93457, XrefRangeStart = 93455, XrefRangeEnd = 93456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93457, RefRangeEnd = 93458, XrefRangeStart = 93457, XrefRangeEnd = 93457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Clear()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93458, RefRangeEnd = 93459, XrefRangeStart = 93458, XrefRangeEnd = 93458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EngineData(EngineData engine)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&engine);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EngineData_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93460, RefRangeEnd = 93461, XrefRangeStart = 93459, XrefRangeEnd = 93460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeOnDefaultIfZero(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeOnDefaultIfZero_Public_Void_CarLoader_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 93507, RefRangeEnd = 93512, XrefRangeStart = 93461, XrefRangeEnd = 93507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EngineData GetStockEngineData(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_CarLoader_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(EngineData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93557, RefRangeEnd = 93559, XrefRangeStart = 93512, XrefRangeEnd = 93557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EngineData GetStockEngineData(CarLoader carLoader, string engineName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(engineName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_CarLoader_String_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(EngineData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 93602, RefRangeEnd = 93611, XrefRangeStart = 93559, XrefRangeEnd = 93602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EngineData GetStockEngineData(string engineName, float engineScale, float torqueMod, float rpmMod, [Optional] float tuning)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engineName);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &engineScale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &torqueMod;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmMod;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuning;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_String_Single_Single_Single_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(EngineData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 93611, RefRangeEnd = 93615, XrefRangeStart = 93611, XrefRangeEnd = 93611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EngineData GetCurrentEngineData(CarLoader carLoader, bool wantMeasured, [Optional] float tuningValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wantMeasured;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuningValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentEngineData_Public_EngineData_CarLoader_Boolean_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(EngineData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static EngineData()
	{
		Il2CppClassPointerStore<EngineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "EngineData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EngineData>.NativeClassPtr);
		NativeFieldInfoPtr_isElectric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "isElectric");
		NativeFieldInfoPtr_idleRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "idleRpm");
		NativeFieldInfoPtr_idleRpmTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "idleRpmTorque");
		NativeFieldInfoPtr_idleRpmCurveBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "idleRpmCurveBias");
		NativeFieldInfoPtr_peakRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "peakRpm");
		NativeFieldInfoPtr_peakRpmTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "peakRpmTorque");
		NativeFieldInfoPtr_peakRpmCurveBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "peakRpmCurveBias");
		NativeFieldInfoPtr_maxRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "maxRpm");
		NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "inertia");
		NativeFieldInfoPtr_engineFrictionTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "engineFrictionTorque");
		NativeFieldInfoPtr_engineFrictionRotational = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "engineFrictionRotational");
		NativeFieldInfoPtr_engineFrictionViscous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "engineFrictionViscous");
		NativeFieldInfoPtr_limiterTriggerRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "limiterTriggerRpm");
		NativeFieldInfoPtr_tuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "tuningValue");
		NativeFieldInfoPtr_measured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineData>.NativeClassPtr, "measured");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668696);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668697);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668698);
		NativeMethodInfoPtr__ctor_Public_Void_EngineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668699);
		NativeMethodInfoPtr_ChangeOnDefaultIfZero_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668700);
		NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668701);
		NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_CarLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668702);
		NativeMethodInfoPtr_GetStockEngineData_Public_EngineData_String_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668703);
		NativeMethodInfoPtr_GetCurrentEngineData_Public_EngineData_CarLoader_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EngineData>.NativeClassPtr, 100668704);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EngineData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
