using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class SmoothFloat : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_sum;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_smoothValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_end;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_count;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr));

	public unsafe float m_sum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sum);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sum)) = num;
		}
	}

	public unsafe float m_smoothValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smoothValue)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> m_buffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_buffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_size)) = num;
		}
	}

	public unsafe int m_start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_start);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_start)) = num;
		}
	}

	public unsafe int m_end
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_end);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_end)) = num;
		}
	}

	public unsafe int m_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_count)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108777, XrefRangeEnd = 108780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SmoothFloat(int size)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetValue(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108780, XrefRangeEnd = 108784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resize(int targetSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetSize);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SmoothFloat()
	{
		Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SmoothFloat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr);
		NativeFieldInfoPtr_m_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_sum");
		NativeFieldInfoPtr_m_smoothValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_smoothValue");
		NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_buffer");
		NativeFieldInfoPtr_m_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_size");
		NativeFieldInfoPtr_m_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_start");
		NativeFieldInfoPtr_m_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_end");
		NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "m_count");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100670085);
		NativeMethodInfoPtr_SetValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100670086);
		NativeMethodInfoPtr_GetValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100670087);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100670088);
		NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100670089);
	}

	public SmoothFloat(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
