using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

public class RotationController : MonoBehaviour
{
	public sealed class OnRotationFinished : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe OnRotationFinished(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(217)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static OnRotationFinished()
		{
			Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "OnRotationFinished");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr, 100670184);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr, 100670185);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr, 100670186);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRotationFinished>.NativeClassPtr, 100670187);
		}

		public OnRotationFinished(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator OnRotationFinished(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnRotationFinished>(P_0);
		}

		public static OnRotationFinished operator +(OnRotationFinished P_0, OnRotationFinished P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<OnRotationFinished>();
		}

		public static OnRotationFinished operator -(OnRotationFinished P_0, OnRotationFinished P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnRotationFinished>();
			}
			return (OnRotationFinished)obj;
		}
	}

	[System.Serializable]
	public class Rotation : Il2CppSystem.Object
	{
		public enum Axis
		{
			Up,
			Right,
			Forward,
			// error: nested types are not permitted in C#.
			[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Axis>.NativeClassPtr));
			,
			// error: nested types are not permitted in C#.
			static Axis()
			{
				Il2CppClassPointerStore<Axis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "Axis");
			}

		}

		public enum Mode
		{
			Disabled,
			Free,
			LookAtTarget,
			LookAtTargetCenter,
			// error: nested types are not permitted in C#.
			[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
			,
			// error: nested types are not permitted in C#.
			static Mode()
			{
				Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "Mode");
			}

		}

		private static readonly System.IntPtr NativeFieldInfoPtr_angle;

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_damped;

		private static readonly System.IntPtr NativeFieldInfoPtr_damping;

		private static readonly System.IntPtr NativeFieldInfoPtr_clamped;

		private static readonly System.IntPtr NativeFieldInfoPtr_minAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_currentAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_currentTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_axis;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_axisVector;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Axis_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Axis_Mode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Axis_Mode_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ResetAngle_Public_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isRotating_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_Transform_Transform_Renderer_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AngleToTarget_Private_Single_Vector3_Vector3_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisVector_Private_Vector3_Axis_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Rotation>.NativeClassPtr));

		public unsafe float angle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
			}
		}

		public unsafe Mode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(Mode*)num;
			}
			set
			{
				*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
			}
		}

		public unsafe float targetOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetOffset);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetOffset)) = num;
			}
		}

		public unsafe bool damped
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damped);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damped)) = flag;
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

		public unsafe bool clamped
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clamped);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clamped)) = flag;
			}
		}

		public unsafe float minAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minAngle)) = num;
			}
		}

		public unsafe float maxAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngle)) = num;
			}
		}

		public unsafe float m_currentAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentAngle)) = num;
			}
		}

		public unsafe float m_currentTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentTarget);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentTarget)) = num;
			}
		}

		public unsafe Axis m_axis
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_axis);
				return *(Axis*)num;
			}
			set
			{
				*(Axis*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_axis)) = axis;
			}
		}

		public unsafe Vector3 m_axisVector
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_axisVector);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_axisVector)) = vector;
			}
		}

		public unsafe Quaternion rotation
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109342, RefRangeEnd = 109348, XrefRangeStart = 109340, XrefRangeEnd = 109342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		public unsafe bool isRotating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRotating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109337, XrefRangeEnd = 109338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotation(Axis axis)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&axis);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109338, XrefRangeEnd = 109339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotation(Axis axis, Mode rotationMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&axis);
			*(Mode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationMode;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Axis_Mode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109339, XrefRangeEnd = 109340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rotation(Axis axis, Mode rotationMode, float min, float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&axis);
			*(Mode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationMode;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Axis_Mode_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe void ResetAngle(float newAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&newAngle);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109391, RefRangeEnd = 109395, XrefRangeStart = 109348, XrefRangeEnd = 109391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(float deltaTime, Transform self, Transform target, Renderer targetRenderer, Transform reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&deltaTime);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(self);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(target);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(targetRenderer);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(reference);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_Single_Transform_Transform_Renderer_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109414, RefRangeEnd = 109415, XrefRangeStart = 109395, XrefRangeEnd = 109414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float AngleToTarget(Vector3 pos, Vector3 targetPos, Transform reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&pos);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPos;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(reference);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleToTarget_Private_Single_Vector3_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109417, RefRangeEnd = 109420, XrefRangeStart = 109415, XrefRangeEnd = 109417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxisVector(Axis axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&axis);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisVector_Private_Vector3_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static Rotation()
		{
			Il2CppClassPointerStore<Rotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "Rotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotation>.NativeClassPtr);
			NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "angle");
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_targetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "targetOffset");
			NativeFieldInfoPtr_damped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "damped");
			NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "damping");
			NativeFieldInfoPtr_clamped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "clamped");
			NativeFieldInfoPtr_minAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "minAngle");
			NativeFieldInfoPtr_maxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "maxAngle");
			NativeFieldInfoPtr_m_currentAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "m_currentAngle");
			NativeFieldInfoPtr_m_currentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "m_currentTarget");
			NativeFieldInfoPtr_m_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "m_axis");
			NativeFieldInfoPtr_m_axisVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotation>.NativeClassPtr, "m_axisVector");
			NativeMethodInfoPtr__ctor_Public_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670188);
			NativeMethodInfoPtr__ctor_Public_Void_Axis_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670189);
			NativeMethodInfoPtr__ctor_Public_Void_Axis_Mode_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670190);
			NativeMethodInfoPtr_ResetAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670191);
			NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670192);
			NativeMethodInfoPtr_get_isRotating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670193);
			NativeMethodInfoPtr_Update_Public_Void_Single_Transform_Transform_Renderer_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670194);
			NativeMethodInfoPtr_AngleToTarget_Private_Single_Vector3_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670195);
			NativeMethodInfoPtr_GetAxisVector_Private_Vector3_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotation>.NativeClassPtr, 100670196);
		}

		public Rotation(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotateInWorldSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertHVorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontal;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertical;

	private static readonly System.IntPtr NativeFieldInfoPtr_pitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_onRotationFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_trans;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_parent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_targetRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rotating;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RotationController>.NativeClassPtr));

	public unsafe Transform target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool rotateInWorldSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateInWorldSpace);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateInWorldSpace)) = flag;
		}
	}

	public unsafe bool invertHVorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertHVorder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertHVorder)) = flag;
		}
	}

	public unsafe Rotation horizontal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rotation(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rotation vertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertical);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rotation(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertical), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rotation pitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rotation(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitch), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OnRotationFinished onRotationFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRotationFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OnRotationFinished(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRotationFinished), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_trans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_trans);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_trans), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_parent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_cachedTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer m_targetRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Renderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_rotating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rotating);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rotating)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109420, XrefRangeEnd = 109429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109429, XrefRangeEnd = 109484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109484, XrefRangeEnd = 109500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RotationController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RotationController()
	{
		Il2CppClassPointerStore<RotationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RotationController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationController>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "target");
		NativeFieldInfoPtr_rotateInWorldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "rotateInWorldSpace");
		NativeFieldInfoPtr_invertHVorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "invertHVorder");
		NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "horizontal");
		NativeFieldInfoPtr_vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "vertical");
		NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "pitch");
		NativeFieldInfoPtr_onRotationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "onRotationFinished");
		NativeFieldInfoPtr_m_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "m_trans");
		NativeFieldInfoPtr_m_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "m_parent");
		NativeFieldInfoPtr_m_cachedTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "m_cachedTarget");
		NativeFieldInfoPtr_m_targetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "m_targetRenderer");
		NativeFieldInfoPtr_m_rotating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotationController>.NativeClassPtr, "m_rotating");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationController>.NativeClassPtr, 100670181);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationController>.NativeClassPtr, 100670182);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationController>.NativeClassPtr, 100670183);
	}

	public RotationController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
