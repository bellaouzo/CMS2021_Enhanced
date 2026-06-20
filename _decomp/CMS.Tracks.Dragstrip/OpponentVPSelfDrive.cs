using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Diagnostics;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

namespace CMS.Tracks.Dragstrip;

public class OpponentVPSelfDrive : VehicleBehaviour
{
	[ObfuscatedName("CMS.Tracks.Dragstrip.OpponentVPSelfDrive/<StartCar>d__22")]
	public sealed class _StartCar_d__22 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__stopWatch_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe OpponentVPSelfDrive __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new OpponentVPSelfDrive(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Stopwatch _stopWatch_5__2
		{
			get
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr == (System.IntPtr)0) ? ((Stopwatch)null) : new Stopwatch(intPtr);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _StartCar_d__22(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134678, XrefRangeEnd = 134699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134699, XrefRangeEnd = 134704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _StartCar_d__22()
		{
			Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "<StartCar>d__22");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__stopWatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, "<stopWatch>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, 100672263);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, 100672264);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, 100672265);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, 100672266);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, 100672267);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_StartCar_d__22>.NativeClassPtr, 100672268);
		}

		public _StartCar_d__22(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_targetPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStop;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerMoveRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerReleaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_steerInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_stabilityControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowdownDistanceFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetReachedDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleRamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_BrakeCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_GasState;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DriveToEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopDriveToEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplySpeedControl_Private_Void_Single_Single_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Steer_Private_Void_Single_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TargetSteerInput_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TargetApproachAndReaching_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartCar_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr));

	public unsafe Transform targetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool forceStop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStop)) = flag;
		}
	}

	public unsafe float steerMoveRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerMoveRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerMoveRate)) = num;
		}
	}

	public unsafe float steerReleaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerReleaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerReleaseRate)) = num;
		}
	}

	public unsafe float m_steerInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_steerInput)) = num;
		}
	}

	public unsafe VPVehicleController m_vehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StabilityControl stabilityControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stabilityControl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StabilityControl(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stabilityControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static float slowdownDistanceFactor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_slowdownDistanceFactor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_slowdownDistanceFactor, &num);
		}
	}

	public unsafe static float targetReachedDistance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_targetReachedDistance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_targetReachedDistance, &num);
		}
	}

	public unsafe float maxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeed)) = num;
		}
	}

	public unsafe static float throttleRamp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_throttleRamp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_throttleRamp, &num);
		}
	}

	public unsafe static float brakeRamp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_brakeRamp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_brakeRamp, &num);
		}
	}

	public unsafe bool BrakeCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakeCar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakeCar)) = flag;
		}
	}

	public unsafe GasState GasState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GasState);
			return *(GasState*)num;
		}
		set
		{
			*(GasState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GasState)) = gasState;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134704, XrefRangeEnd = 134716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void DriveToEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DriveToEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopDriveToEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopDriveToEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134716, XrefRangeEnd = 134726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ApplySpeedControl(float currentSpeed, float targetSpeed, out float targetThrottle, out float targetBrake)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&currentSpeed);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetSpeed;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref targetThrottle);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref targetBrake);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplySpeedControl_Private_Void_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134744, RefRangeEnd = 134745, XrefRangeStart = 134726, XrefRangeEnd = 134744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Steer(float targetSteerInput, Il2CppStructArray<int> inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetSteerInput);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Steer_Private_Void_Single_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134771, RefRangeEnd = 134772, XrefRangeStart = 134745, XrefRangeEnd = 134771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float TargetSteerInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TargetSteerInput_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134795, RefRangeEnd = 134796, XrefRangeStart = 134772, XrefRangeEnd = 134795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float TargetApproachAndReaching(float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TargetApproachAndReaching_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134796, XrefRangeEnd = 134799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator StartCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCar_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134799, XrefRangeEnd = 134802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OpponentVPSelfDrive()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OpponentVPSelfDrive()
	{
		Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "OpponentVPSelfDrive");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr);
		NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "targetPosition");
		NativeFieldInfoPtr_forceStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "forceStop");
		NativeFieldInfoPtr_steerMoveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "steerMoveRate");
		NativeFieldInfoPtr_steerReleaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "steerReleaseRate");
		NativeFieldInfoPtr_m_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "m_steerInput");
		NativeFieldInfoPtr_m_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "m_vehicle");
		NativeFieldInfoPtr_stabilityControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "stabilityControl");
		NativeFieldInfoPtr_slowdownDistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "slowdownDistanceFactor");
		NativeFieldInfoPtr_targetReachedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "targetReachedDistance");
		NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "maxSpeed");
		NativeFieldInfoPtr_throttleRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "throttleRamp");
		NativeFieldInfoPtr_brakeRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "brakeRamp");
		NativeFieldInfoPtr_BrakeCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "BrakeCar");
		NativeFieldInfoPtr_GasState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, "GasState");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672253);
		NativeMethodInfoPtr_DriveToEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672254);
		NativeMethodInfoPtr_StopDriveToEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672255);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672256);
		NativeMethodInfoPtr_ApplySpeedControl_Private_Void_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672257);
		NativeMethodInfoPtr_Steer_Private_Void_Single_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672258);
		NativeMethodInfoPtr_TargetSteerInput_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672259);
		NativeMethodInfoPtr_TargetApproachAndReaching_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672260);
		NativeMethodInfoPtr_StartCar_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672261);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentVPSelfDrive>.NativeClassPtr, 100672262);
	}

	public OpponentVPSelfDrive(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
