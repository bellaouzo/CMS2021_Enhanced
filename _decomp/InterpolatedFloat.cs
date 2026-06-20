using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class InterpolatedFloat : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_value;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrameRatio_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInterpolated_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInterpolated_Public_Single_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr));

	public unsafe float m_prevValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevValue)) = num;
		}
	}

	public unsafe float m_value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_value)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe InterpolatedFloat([Optional] float initialValue)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Reset(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Set(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float Get()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 107487, RefRangeEnd = 107493, XrefRangeStart = 107478, XrefRangeEnd = 107487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetFrameRatio()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrameRatio_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107494, RefRangeEnd = 107497, XrefRangeStart = 107493, XrefRangeEnd = 107494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetInterpolated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInterpolated_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetInterpolated(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInterpolated_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static InterpolatedFloat()
	{
		Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InterpolatedFloat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr);
		NativeFieldInfoPtr_m_prevValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, "m_prevValue");
		NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, "m_value");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669894);
		NativeMethodInfoPtr_Reset_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669895);
		NativeMethodInfoPtr_Set_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669896);
		NativeMethodInfoPtr_Get_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669897);
		NativeMethodInfoPtr_GetFrameRatio_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669898);
		NativeMethodInfoPtr_GetInterpolated_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669899);
		NativeMethodInfoPtr_GetInterpolated_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpolatedFloat>.NativeClassPtr, 100669900);
	}

	public InterpolatedFloat(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
