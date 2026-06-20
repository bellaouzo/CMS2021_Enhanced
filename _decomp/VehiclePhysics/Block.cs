using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class Block : Il2CppSystem.Object
{
	public class Connection : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_L;

		private static readonly System.IntPtr NativeFieldInfoPtr_I;

		private static readonly System.IntPtr NativeFieldInfoPtr_Tr;

		private static readonly System.IntPtr NativeFieldInfoPtr_outTd;

		private static readonly System.IntPtr NativeFieldInfoPtr_input;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputSlot;

		private static readonly System.IntPtr NativeFieldInfoPtr_output;

		private static readonly System.IntPtr NativeFieldInfoPtr_outputSlot;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Connection>.NativeClassPtr));

		public unsafe float L
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L)) = num;
			}
		}

		public unsafe float I
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_I);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_I)) = num;
			}
		}

		public unsafe float Tr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tr);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tr)) = num;
			}
		}

		public unsafe float outTd
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outTd);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outTd)) = num;
			}
		}

		public unsafe Block input
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Block(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int inputSlot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputSlot);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputSlot)) = num;
			}
		}

		public unsafe Block output
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_output);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Block(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int outputSlot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSlot);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSlot)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Connection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Connection>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Connection()
		{
			Il2CppClassPointerStore<Connection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Block>.NativeClassPtr, "Connection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Connection>.NativeClassPtr);
			NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "L");
			NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "I");
			NativeFieldInfoPtr_Tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "Tr");
			NativeFieldInfoPtr_outTd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "outTd");
			NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "input");
			NativeFieldInfoPtr_inputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "inputSlot");
			NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "output");
			NativeFieldInfoPtr_outputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "outputSlot");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100671197);
		}

		public Connection(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct State
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_L;

		private static readonly System.IntPtr NativeFieldInfoPtr_P;

		private static readonly System.IntPtr NativeFieldInfoPtr_Lr;

		[FieldOffset(0)]
		public float L;

		[FieldOffset(4)]
		public Vector2 P;

		[FieldOffset(12)]
		public float Lr;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<State>.NativeClassPtr));

		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Block>.NativeClassPtr, "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "L");
			NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "P");
			NativeFieldInfoPtr_Lr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "Lr");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<State>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Derivative
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_T;

		private static readonly System.IntPtr NativeFieldInfoPtr_F;

		private static readonly System.IntPtr NativeFieldInfoPtr_Tr;

		[FieldOffset(0)]
		public float T;

		[FieldOffset(4)]
		public Vector2 F;

		[FieldOffset(12)]
		public float Tr;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Derivative>.NativeClassPtr));

		static Derivative()
		{
			Il2CppClassPointerStore<Derivative>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Block>.NativeClassPtr, "Derivative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Derivative>.NativeClassPtr);
			NativeFieldInfoPtr_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Derivative>.NativeClassPtr, "T");
			NativeFieldInfoPtr_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Derivative>.NativeClassPtr, "F");
			NativeFieldInfoPtr_Tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Derivative>.NativeClassPtr, "Tr");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Derivative>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_inputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_outputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_connectedInputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_connectedOutputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpmToW;

	private static readonly System.IntPtr NativeFieldInfoPtr_WToRpm;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputs_Public_get_ArrayOf_Connection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outputs_Public_get_ArrayOf_Connection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasInputs_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasOutputs_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_connectedInputs_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_connectedOutputs_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConnections_Public_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreStep_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_New_Void_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSubstepState_Public_Virtual_New_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_New_Void_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputs_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOutputs_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Static_Boolean_Block_Int32_Block_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectInput_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectOutput_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountConnections_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Block>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Connection> m_inputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inputs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Connection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inputs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Connection> m_outputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_outputs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Connection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_outputs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_connectedInputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_connectedInputs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_connectedInputs)) = num;
		}
	}

	public unsafe int m_connectedOutputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_connectedOutputs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_connectedOutputs)) = num;
		}
	}

	public unsafe static float RpmToW
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RpmToW, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RpmToW, &num);
		}
	}

	public unsafe static float WToRpm
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WToRpm, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WToRpm, &num);
		}
	}

	public unsafe Il2CppReferenceArray<Connection> inputs
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputs_Public_get_ArrayOf_Connection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Connection>(intPtr) : null;
		}
	}

	public unsafe Il2CppReferenceArray<Connection> outputs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_outputs_Public_get_ArrayOf_Connection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Connection>(intPtr) : null;
		}
	}

	public unsafe bool hasInputs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasInputs_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool hasOutputs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasOutputs_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int connectedInputs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connectedInputs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int connectedOutputs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connectedOutputs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122852, XrefRangeEnd = 122858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool CheckConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CheckConnections_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void PreStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_PreStep_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void GetState(ref State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetState_Public_Virtual_New_Void_byref_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetSubstepState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetSubstepState_Public_Virtual_New_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void ComputeStateUpstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void EvaluateTorqueDownstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void GetSubstepDerivative(ref Derivative D)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_New_Void_byref_Derivative_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Block()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Block>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122858, XrefRangeEnd = 122861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInputs(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputs_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122861, XrefRangeEnd = 122864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOutputs(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOutputs_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 122875, RefRangeEnd = 122926, XrefRangeStart = 122864, XrefRangeEnd = 122875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Connect(Block inputUnit, int inputSlot, Block outputUnit, int outputSlot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputUnit);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputSlot;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(outputUnit);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputSlot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Connect_Public_Static_Boolean_Block_Int32_Block_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122929, RefRangeEnd = 122931, XrefRangeStart = 122926, XrefRangeEnd = 122929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DisconnectInput(int inputSlot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputSlot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisconnectInput_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122934, RefRangeEnd = 122936, XrefRangeStart = 122931, XrefRangeEnd = 122934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DisconnectOutput(int outputSlot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&outputSlot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisconnectOutput_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122938, RefRangeEnd = 122942, XrefRangeStart = 122936, XrefRangeEnd = 122938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CountConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountConnections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Block()
	{
		Il2CppClassPointerStore<Block>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Block");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Block>.NativeClassPtr);
		NativeFieldInfoPtr_m_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block>.NativeClassPtr, "m_inputs");
		NativeFieldInfoPtr_m_outputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block>.NativeClassPtr, "m_outputs");
		NativeFieldInfoPtr_m_connectedInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block>.NativeClassPtr, "m_connectedInputs");
		NativeFieldInfoPtr_m_connectedOutputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block>.NativeClassPtr, "m_connectedOutputs");
		NativeFieldInfoPtr_RpmToW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block>.NativeClassPtr, "RpmToW");
		NativeFieldInfoPtr_WToRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Block>.NativeClassPtr, "WToRpm");
		NativeMethodInfoPtr_get_inputs_Public_get_ArrayOf_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671174);
		NativeMethodInfoPtr_get_outputs_Public_get_ArrayOf_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671175);
		NativeMethodInfoPtr_get_hasInputs_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671176);
		NativeMethodInfoPtr_get_hasOutputs_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671177);
		NativeMethodInfoPtr_get_connectedInputs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671178);
		NativeMethodInfoPtr_get_connectedOutputs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671179);
		NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671180);
		NativeMethodInfoPtr_CheckConnections_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671181);
		NativeMethodInfoPtr_PreStep_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671182);
		NativeMethodInfoPtr_GetState_Public_Virtual_New_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671183);
		NativeMethodInfoPtr_SetSubstepState_Public_Virtual_New_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671184);
		NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671185);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671186);
		NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_New_Void_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671187);
		NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671188);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671189);
		NativeMethodInfoPtr_SetInputs_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671190);
		NativeMethodInfoPtr_SetOutputs_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671191);
		NativeMethodInfoPtr_Connect_Public_Static_Boolean_Block_Int32_Block_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671192);
		NativeMethodInfoPtr_DisconnectInput_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671193);
		NativeMethodInfoPtr_DisconnectOutput_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671194);
		NativeMethodInfoPtr_CountConnections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100671195);
	}

	public Block(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
