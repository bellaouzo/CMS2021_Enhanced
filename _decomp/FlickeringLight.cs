using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_base2;

	private static readonly System.IntPtr NativeFieldInfoPtr_amplitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_phase;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalColor;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvalWave_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr));

	public unsafe float base2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base2)) = num;
		}
	}

	public unsafe float amplitude
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amplitude);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amplitude)) = num;
		}
	}

	public unsafe float phase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phase);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phase)) = num;
		}
	}

	public unsafe float frequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = num;
		}
	}

	public unsafe Color originalColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalColor)) = color;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44062, XrefRangeEnd = 44067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44067, XrefRangeEnd = 44076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44076, XrefRangeEnd = 44080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EvalWave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvalWave_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44080, XrefRangeEnd = 44083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlickeringLight()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FlickeringLight()
	{
		Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FlickeringLight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr);
		NativeFieldInfoPtr_base2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "base2");
		NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "amplitude");
		NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "phase");
		NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "frequency");
		NativeFieldInfoPtr_originalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "originalColor");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100665980);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100665981);
		NativeMethodInfoPtr_EvalWave_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100665982);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100665983);
	}

	public FlickeringLight(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
