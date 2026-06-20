using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class DataRecorder : Il2CppSystem.Object
{
	public class FloatData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_frame;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FloatData>.NativeClassPtr));

		public unsafe int frame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame)) = num;
			}
		}

		public unsafe float value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe FloatData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static FloatData()
		{
			Il2CppClassPointerStore<FloatData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "FloatData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatData>.NativeClassPtr);
			NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatData>.NativeClassPtr, "frame");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatData>.NativeClassPtr, "value");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatData>.NativeClassPtr, 100671740);
		}

		public FloatData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_floatChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vector3Channels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_quaternionChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_deltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_frameCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_writeFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_readFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_firstFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastFrame;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextWriteFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RewriteFromRead_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWriteFrame_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstFrame_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastFrame_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadPointers_Public_Void_Single_Single_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadTimeSpan_Public_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveReadToFrame_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveReadToTime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveReadToStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveReadToEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextReadFrame_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrevReadFrame_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewFloatChannel_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteFloatValue_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloatValue_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewVector3Channel_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteVector3Value_Public_Void_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadVector3Value_Public_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewQuaternionChannel_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteQuaternionValue_Public_Void_Int32_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadQuaternionValue_Public_Quaternion_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr));

	public unsafe List<Il2CppReferenceArray<FloatData>> m_floatChannels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_floatChannels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Il2CppReferenceArray<FloatData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_floatChannels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppStructArray<Vector3>> m_vector3Channels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vector3Channels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vector3Channels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppStructArray<Quaternion>> m_quaternionChannels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_quaternionChannels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Il2CppStructArray<Quaternion>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_quaternionChannels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_deltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_deltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_deltaTime)) = num;
		}
	}

	public unsafe int m_frameCapacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameCapacity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameCapacity)) = num;
		}
	}

	public unsafe int m_writeFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_writeFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_writeFrame)) = num;
		}
	}

	public unsafe int m_readFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_readFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_readFrame)) = num;
		}
	}

	public unsafe int m_firstFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstFrame)) = num;
		}
	}

	public unsafe int m_lastFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastFrame)) = num;
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 126249, RefRangeEnd = 126252, XrefRangeStart = 126227, XrefRangeEnd = 126249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataRecorder(float recordTime, float recordDeltaTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&recordTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &recordDeltaTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void NextWriteFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextWriteFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void RewriteFromRead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RewriteFromRead_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int GetWriteFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWriteFrame_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetFirstFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstFrame_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetLastFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastFrame_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void ResetData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126252, XrefRangeEnd = 126253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetReadPointers(float fromTime, float toTime, out int fromFrame, out int frameCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fromTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toTime;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref fromFrame);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref frameCount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadPointers_Public_Void_Single_Single_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126253, XrefRangeEnd = 126255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ReadTimeSpan(float fromTime, float toTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&fromTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadTimeSpan_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void MoveReadToFrame(int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frame);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveReadToFrame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void MoveReadToTime(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveReadToTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void MoveReadToStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveReadToStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void MoveReadToEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveReadToEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool NextReadFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextReadFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool PrevReadFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrevReadFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126269, RefRangeEnd = 126271, XrefRangeStart = 126255, XrefRangeEnd = 126269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int NewFloatChannel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewFloatChannel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126271, XrefRangeEnd = 126273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteFloatValue(int channel, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&channel);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteFloatValue_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126273, XrefRangeEnd = 126275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ReadFloatValue(int channel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&channel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFloatValue_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126275, XrefRangeEnd = 126282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int NewVector3Channel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewVector3Channel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126282, XrefRangeEnd = 126284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteVector3Value(int channel, Vector3 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&channel);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteVector3Value_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126284, XrefRangeEnd = 126289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ReadVector3Value(int channel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&channel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadVector3Value_Public_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126289, XrefRangeEnd = 126296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int NewQuaternionChannel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewQuaternionChannel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126296, XrefRangeEnd = 126298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteQuaternionValue(int channel, Quaternion value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&channel);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteQuaternionValue_Public_Void_Int32_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126298, XrefRangeEnd = 126303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion ReadQuaternionValue(int channel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&channel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadQuaternionValue_Public_Quaternion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static DataRecorder()
	{
		Il2CppClassPointerStore<DataRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DataRecorder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr);
		NativeFieldInfoPtr_m_floatChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_floatChannels");
		NativeFieldInfoPtr_m_vector3Channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_vector3Channels");
		NativeFieldInfoPtr_m_quaternionChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_quaternionChannels");
		NativeFieldInfoPtr_m_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_deltaTime");
		NativeFieldInfoPtr_m_frameCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_frameCapacity");
		NativeFieldInfoPtr_m_writeFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_writeFrame");
		NativeFieldInfoPtr_m_readFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_readFrame");
		NativeFieldInfoPtr_m_firstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_firstFrame");
		NativeFieldInfoPtr_m_lastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, "m_lastFrame");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671716);
		NativeMethodInfoPtr_NextWriteFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671717);
		NativeMethodInfoPtr_RewriteFromRead_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671718);
		NativeMethodInfoPtr_GetWriteFrame_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671719);
		NativeMethodInfoPtr_GetFirstFrame_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671720);
		NativeMethodInfoPtr_GetLastFrame_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671721);
		NativeMethodInfoPtr_ResetData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671722);
		NativeMethodInfoPtr_GetReadPointers_Public_Void_Single_Single_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671723);
		NativeMethodInfoPtr_ReadTimeSpan_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671724);
		NativeMethodInfoPtr_MoveReadToFrame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671725);
		NativeMethodInfoPtr_MoveReadToTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671726);
		NativeMethodInfoPtr_MoveReadToStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671727);
		NativeMethodInfoPtr_MoveReadToEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671728);
		NativeMethodInfoPtr_NextReadFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671729);
		NativeMethodInfoPtr_PrevReadFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671730);
		NativeMethodInfoPtr_NewFloatChannel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671731);
		NativeMethodInfoPtr_WriteFloatValue_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671732);
		NativeMethodInfoPtr_ReadFloatValue_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671733);
		NativeMethodInfoPtr_NewVector3Channel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671734);
		NativeMethodInfoPtr_WriteVector3Value_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671735);
		NativeMethodInfoPtr_ReadVector3Value_Public_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671736);
		NativeMethodInfoPtr_NewQuaternionChannel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671737);
		NativeMethodInfoPtr_WriteQuaternionValue_Public_Void_Int32_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671738);
		NativeMethodInfoPtr_ReadQuaternionValue_Public_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRecorder>.NativeClassPtr, 100671739);
	}

	public DataRecorder(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
