using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class DifferentialGeneric : Block
{
	private static readonly System.IntPtr NativeFieldInfoPtr_torqueGeometry;

	private static readonly System.IntPtr NativeFieldInfoPtr_stiffness;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_input;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output2;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr));

	public unsafe float torqueGeometry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueGeometry);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueGeometry)) = num;
		}
	}

	public unsafe float stiffness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stiffness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stiffness)) = num;
		}
	}

	public unsafe float damping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping)) = num;
		}
	}

	public unsafe Connection m_input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_input);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_input), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Connection m_output1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Connection m_output2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe bool CheckConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124685, XrefRangeEnd = 124687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ComputeStateUpstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124687, XrefRangeEnd = 124691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void EvaluateTorqueDownstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124691, XrefRangeEnd = 124694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DifferentialGeneric()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DifferentialGeneric()
	{
		Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DifferentialGeneric");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr);
		NativeFieldInfoPtr_torqueGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, "torqueGeometry");
		NativeFieldInfoPtr_stiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, "stiffness");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_m_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, "m_input");
		NativeFieldInfoPtr_m_output1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, "m_output1");
		NativeFieldInfoPtr_m_output2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, "m_output2");
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, 100671504);
		NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, 100671505);
		NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, 100671506);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, 100671507);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifferentialGeneric>.NativeClassPtr, 100671508);
	}

	public DifferentialGeneric(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
