using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class Solver : Il2CppSystem.Object
{
	public class StateVector : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_states;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_states_Public_get_ArrayOf_State_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<StateVector>.NativeClassPtr));

		public unsafe Il2CppStructArray<Block.State> m_states
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_states);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Block.State>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_states), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStructArray<Block.State> states
		{
			[CallerCount(1)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_states_Public_get_ArrayOf_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Block.State>(intPtr) : null;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123040, XrefRangeEnd = 123043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateVector(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateVector>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&length);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static StateVector()
		{
			Il2CppClassPointerStore<StateVector>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Solver>.NativeClassPtr, "StateVector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateVector>.NativeClassPtr);
			NativeFieldInfoPtr_m_states = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateVector>.NativeClassPtr, "m_states");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateVector>.NativeClassPtr, 100671235);
			NativeMethodInfoPtr_get_states_Public_get_ArrayOf_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateVector>.NativeClassPtr, 100671236);
		}

		public StateVector(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class DerivativeVector : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_derivatives;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_derivatives_Public_get_ArrayOf_Derivative_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr));

		public unsafe Il2CppStructArray<Block.Derivative> m_derivatives
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_derivatives);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Block.Derivative>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_derivatives), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStructArray<Block.Derivative> derivatives
		{
			[CallerCount(1)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_derivatives_Public_get_ArrayOf_Derivative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Block.Derivative>(intPtr) : null;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123043, XrefRangeEnd = 123046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DerivativeVector(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&length);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static DerivativeVector()
		{
			Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Solver>.NativeClassPtr, "DerivativeVector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr);
			NativeFieldInfoPtr_m_derivatives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr, "m_derivatives");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr, 100671237);
			NativeMethodInfoPtr_get_derivatives_Public_get_ArrayOf_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DerivativeVector>.NativeClassPtr, 100671238);
		}

		public DerivativeVector(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_blocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_states;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_derivatives;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RK4enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_minInertia;

	private static readonly System.IntPtr NativeFieldInfoPtr_minWheelRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_minWheelMass;

	private static readonly System.IntPtr NativeFieldInfoPtr_viscousCouplingRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_viscousLockedRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr__time_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__deltaTime_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__resultMessage_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Private_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_deltaTime_Private_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDebugTime_Public_Static_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resultMessage_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_resultMessage_Private_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_ArrayOf_Wheel_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Integrate_Public_Void_Single_Single_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViscousLockingDt_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EulerStep_Private_Static_Void_byref_State_byref_Derivative_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EulerStepL_Private_Static_Void_byref_State_byref_Derivative_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EulerStep_Private_Void_ArrayOf_State_ArrayOf_Derivative_ArrayOf_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntegrateEuler_Private_Void_ArrayOf_State_ArrayOf_Derivative_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateRK4_Private_Void_ArrayOf_State_ArrayOf_State_ArrayOf_Derivative_Single_Single_ArrayOf_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeRK4Derivative_Private_Void_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeRK4DerivativeT_Private_Void_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeRK4Derivative_Private_Void_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntegrateRK4_Private_Void_ArrayOf_State_ArrayOf_State_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDerivative_Private_Void_ArrayOf_State_ArrayOf_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Solver>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Block> m_blocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_blocks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Block>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_blocks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_wheelCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelCount)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<StateVector> m_states
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_states);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<StateVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_states), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<DerivativeVector> m_derivatives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_derivatives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DerivativeVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_derivatives), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_RK4enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RK4enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RK4enabled)) = flag;
		}
	}

	public unsafe static float minInertia
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minInertia, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minInertia, &num);
		}
	}

	public unsafe static float minWheelRadius
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minWheelRadius, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minWheelRadius, &num);
		}
	}

	public unsafe static float minWheelMass
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minWheelMass, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minWheelMass, &num);
		}
	}

	public unsafe static float viscousCouplingRate
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_viscousCouplingRate, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_viscousCouplingRate, &num);
		}
	}

	public unsafe static float viscousLockedRatio
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_viscousLockedRatio, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_viscousLockedRatio, &num);
		}
	}

	public unsafe static float _time_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__time_k__BackingField, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__time_k__BackingField, &num);
		}
	}

	public unsafe static float _deltaTime_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__deltaTime_k__BackingField, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__deltaTime_k__BackingField, &num);
		}
	}

	public unsafe string _resultMessage_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resultMessage_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resultMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static float time
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123046, XrefRangeEnd = 123050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123050, XrefRangeEnd = 123054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Private_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe static float deltaTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123054, XrefRangeEnd = 123058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123058, XrefRangeEnd = 123062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deltaTime_Private_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe string resultMessage
	{
		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resultMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		[CallerCount(44)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_resultMessage_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe static void SetDebugTime(float t, float dt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&t);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDebugTime_Public_Static_Void_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123062, XrefRangeEnd = 123140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Initialize(Il2CppReferenceArray<Wheel> wheels, bool enableRK4)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheels);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRK4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Boolean_ArrayOf_Wheel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123141, RefRangeEnd = 123142, XrefRangeStart = 123140, XrefRangeEnd = 123141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Integrate(float t, float dt, int steps, bool useRK4)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&t);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &steps;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRK4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Integrate_Public_Void_Single_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 123152, RefRangeEnd = 123156, XrefRangeStart = 123142, XrefRangeEnd = 123152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetViscousLockingDt(float lockRatio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lockRatio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViscousLockingDt_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 123162, RefRangeEnd = 123169, XrefRangeStart = 123156, XrefRangeEnd = 123162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EulerStep(ref Block.State In, ref Block.Derivative Der, ref Block.State Out)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref In);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref Der);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref Out);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EulerStep_Private_Static_Void_byref_State_byref_Derivative_byref_State_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 123174, RefRangeEnd = 123181, XrefRangeStart = 123169, XrefRangeEnd = 123174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EulerStepL(ref Block.State In, ref Block.Derivative Der, ref Block.State Out)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref In);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref Der);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref Out);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EulerStepL_Private_Static_Void_byref_State_byref_Derivative_byref_State_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123181, XrefRangeEnd = 123188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EulerStep(Il2CppStructArray<Block.State> In, Il2CppStructArray<Block.Derivative> Der, Il2CppStructArray<Block.State> Out)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(In);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Der);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Out);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EulerStep_Private_Void_ArrayOf_State_ArrayOf_Derivative_ArrayOf_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123209, RefRangeEnd = 123210, XrefRangeStart = 123188, XrefRangeEnd = 123209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IntegrateEuler(Il2CppStructArray<Block.State> S, Il2CppStructArray<Block.Derivative> D, float t, float dt, int subSteps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(D);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &subSteps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntegrateEuler_Private_Void_ArrayOf_State_ArrayOf_Derivative_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123210, XrefRangeEnd = 123237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EvaluateRK4(Il2CppStructArray<Block.State> S, Il2CppStructArray<Block.State> Stemp, Il2CppStructArray<Block.Derivative> DIn, float t, float dt, Il2CppStructArray<Block.Derivative> DOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Stemp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(DIn);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(DOut);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateRK4_Private_Void_ArrayOf_State_ArrayOf_State_ArrayOf_Derivative_Single_Single_ArrayOf_Derivative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ComputeRK4Derivative(ref Block.Derivative A, ref Block.Derivative B, ref Block.Derivative C, ref Block.Derivative D, ref Block.Derivative DOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref A);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref B);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref C);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref D);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref DOut);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeRK4Derivative_Private_Void_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ComputeRK4DerivativeT(ref Block.Derivative A, ref Block.Derivative B, ref Block.Derivative C, ref Block.Derivative D, ref Block.Derivative DOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref A);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref B);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref C);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref D);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref DOut);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeRK4DerivativeT_Private_Void_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ComputeRK4Derivative(Il2CppStructArray<Block.Derivative> A, Il2CppStructArray<Block.Derivative> B, Il2CppStructArray<Block.Derivative> C, Il2CppStructArray<Block.Derivative> D, Il2CppStructArray<Block.Derivative> DOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(A);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(B);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(C);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(D);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(DOut);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeRK4Derivative_Private_Void_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123237, XrefRangeEnd = 123298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IntegrateRK4(Il2CppStructArray<Block.State> S, Il2CppStructArray<Block.State> Stemp, Il2CppStructArray<Block.Derivative> D, Il2CppStructArray<Block.Derivative> Da, Il2CppStructArray<Block.Derivative> Db, Il2CppStructArray<Block.Derivative> Dc, Il2CppStructArray<Block.Derivative> Dd, float t, float dt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Stemp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(D);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Da);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Db);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Dc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Dd);
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntegrateRK4_Private_Void_ArrayOf_State_ArrayOf_State_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 123298, RefRangeEnd = 123304, XrefRangeStart = 123298, XrefRangeEnd = 123298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeDerivative(Il2CppStructArray<Block.State> S, Il2CppStructArray<Block.Derivative> Out)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(S);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(Out);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDerivative_Private_Void_ArrayOf_State_ArrayOf_Derivative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Solver()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Solver>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Solver()
	{
		Il2CppClassPointerStore<Solver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Solver");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Solver>.NativeClassPtr);
		NativeFieldInfoPtr_m_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "m_blocks");
		NativeFieldInfoPtr_m_wheelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "m_wheelCount");
		NativeFieldInfoPtr_m_states = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "m_states");
		NativeFieldInfoPtr_m_derivatives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "m_derivatives");
		NativeFieldInfoPtr_m_RK4enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "m_RK4enabled");
		NativeFieldInfoPtr_minInertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "minInertia");
		NativeFieldInfoPtr_minWheelRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "minWheelRadius");
		NativeFieldInfoPtr_minWheelMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "minWheelMass");
		NativeFieldInfoPtr_viscousCouplingRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "viscousCouplingRate");
		NativeFieldInfoPtr_viscousLockedRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "viscousLockedRatio");
		NativeFieldInfoPtr__time_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "<time>k__BackingField");
		NativeFieldInfoPtr__deltaTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "<deltaTime>k__BackingField");
		NativeFieldInfoPtr__resultMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Solver>.NativeClassPtr, "<resultMessage>k__BackingField");
		NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671213);
		NativeMethodInfoPtr_set_time_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671214);
		NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671215);
		NativeMethodInfoPtr_set_deltaTime_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671216);
		NativeMethodInfoPtr_SetDebugTime_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671217);
		NativeMethodInfoPtr_get_resultMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671218);
		NativeMethodInfoPtr_set_resultMessage_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671219);
		NativeMethodInfoPtr_Initialize_Public_Boolean_ArrayOf_Wheel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671220);
		NativeMethodInfoPtr_Integrate_Public_Void_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671221);
		NativeMethodInfoPtr_GetViscousLockingDt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671222);
		NativeMethodInfoPtr_EulerStep_Private_Static_Void_byref_State_byref_Derivative_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671223);
		NativeMethodInfoPtr_EulerStepL_Private_Static_Void_byref_State_byref_Derivative_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671224);
		NativeMethodInfoPtr_EulerStep_Private_Void_ArrayOf_State_ArrayOf_Derivative_ArrayOf_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671225);
		NativeMethodInfoPtr_IntegrateEuler_Private_Void_ArrayOf_State_ArrayOf_Derivative_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671226);
		NativeMethodInfoPtr_EvaluateRK4_Private_Void_ArrayOf_State_ArrayOf_State_ArrayOf_Derivative_Single_Single_ArrayOf_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671227);
		NativeMethodInfoPtr_ComputeRK4Derivative_Private_Void_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671228);
		NativeMethodInfoPtr_ComputeRK4DerivativeT_Private_Void_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671229);
		NativeMethodInfoPtr_ComputeRK4Derivative_Private_Void_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671230);
		NativeMethodInfoPtr_IntegrateRK4_Private_Void_ArrayOf_State_ArrayOf_State_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_ArrayOf_Derivative_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671231);
		NativeMethodInfoPtr_ComputeDerivative_Private_Void_ArrayOf_State_ArrayOf_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671232);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Solver>.NativeClassPtr, 100671233);
	}

	public Solver(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
