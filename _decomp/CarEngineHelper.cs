using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class CarEngineHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineSpecs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EngineData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugEngineData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxPowerAsString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTorqueAsString_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxPower_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTorque_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTorqueMetric_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTorqueUnit_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxPowerRpm_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakRpm_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTorqueBars_Public_Void_Transform_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPowerBars_Private_Void_Transform_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPowerChart_Private_Void_LineChart_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawTorqueChart_Private_Void_LineChart_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPowerTorqueChart_Public_Void_LineChart_Color_Color_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr));

	public unsafe Engine engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Engine(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Engine.EngineSpecs engineSpecs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSpecs);
			return *(Engine.EngineSpecs*)num;
		}
		set
		{
			*(Engine.EngineSpecs*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineSpecs)) = engineSpecs;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 52626, RefRangeEnd = 52639, XrefRangeStart = 52620, XrefRangeEnd = 52626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarEngineHelper(EngineData engineData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&engineData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EngineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52639, XrefRangeEnd = 52645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarEngineHelper(float idleRpm, float idleRpmTorque, float idleRpmCurveBias, float peakRpm, float peakRpmTorque, float peakRpmCurveBias, float maxRpm, float inertia, float frictionTorque, float rotationalFriction, float viscousFriction, float rpmLimiterMax)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&idleRpm);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idleRpmTorque;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &idleRpmCurveBias;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &peakRpm;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &peakRpmTorque;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &peakRpmCurveBias;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRpm;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &inertia;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &frictionTorque;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationalFriction;
		*(float**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &viscousFriction;
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmLimiterMax;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52703, RefRangeEnd = 52704, XrefRangeStart = 52645, XrefRangeEnd = 52703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarEngineHelper(string engineName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engineName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52704, XrefRangeEnd = 52781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugEngineData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugEngineData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 52792, RefRangeEnd = 52798, XrefRangeStart = 52781, XrefRangeEnd = 52792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMaxPowerAsString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxPowerAsString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 52817, RefRangeEnd = 52824, XrefRangeStart = 52798, XrefRangeEnd = 52817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMaxTorqueAsString(bool onlyRpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&onlyRpm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTorqueAsString_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe float GetMaxPower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxPower_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 52828, RefRangeEnd = 52832, XrefRangeStart = 52824, XrefRangeEnd = 52828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxTorque()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTorque_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetMaxTorqueMetric()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTorqueMetric_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52841, RefRangeEnd = 52844, XrefRangeStart = 52832, XrefRangeEnd = 52841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTorqueUnit()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTorqueUnit_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe float GetMaxPowerRpm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxPowerRpm_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetPeakRpm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPeakRpm_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52844, XrefRangeEnd = 52866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawTorqueBars(Transform transform, float maxHeight, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTorqueBars_Public_Void_Transform_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52866, XrefRangeEnd = 52887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPowerBars(Transform transform, float maxHeight, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPowerBars_Private_Void_Transform_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52887, XrefRangeEnd = 52900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPowerChart(LineChart chart, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(chart);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPowerChart_Private_Void_LineChart_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52900, XrefRangeEnd = 52915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawTorqueChart(LineChart chart, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(chart);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawTorqueChart_Private_Void_LineChart_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 52936, RefRangeEnd = 52940, XrefRangeStart = 52915, XrefRangeEnd = 52936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPowerTorqueChart(LineChart chart, Color colorPower, Color colorTorque)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(chart);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorPower;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorTorque;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPowerTorqueChart_Public_Void_LineChart_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarEngineHelper()
	{
		Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarEngineHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr);
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_engineSpecs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, "engineSpecs");
		NativeMethodInfoPtr__ctor_Public_Void_EngineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666368);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666369);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666370);
		NativeMethodInfoPtr_DebugEngineData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666371);
		NativeMethodInfoPtr_GetMaxPowerAsString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666372);
		NativeMethodInfoPtr_GetMaxTorqueAsString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666373);
		NativeMethodInfoPtr_GetMaxPower_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666374);
		NativeMethodInfoPtr_GetMaxTorque_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666375);
		NativeMethodInfoPtr_GetMaxTorqueMetric_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666376);
		NativeMethodInfoPtr_GetTorqueUnit_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666377);
		NativeMethodInfoPtr_GetMaxPowerRpm_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666378);
		NativeMethodInfoPtr_GetPeakRpm_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666379);
		NativeMethodInfoPtr_DrawTorqueBars_Public_Void_Transform_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666380);
		NativeMethodInfoPtr_DrawPowerBars_Private_Void_Transform_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666381);
		NativeMethodInfoPtr_DrawPowerChart_Private_Void_LineChart_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666382);
		NativeMethodInfoPtr_DrawTorqueChart_Private_Void_LineChart_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666383);
		NativeMethodInfoPtr_DrawPowerTorqueChart_Public_Void_LineChart_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarEngineHelper>.NativeClassPtr, 100666384);
	}

	public CarEngineHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
