using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MusicVisualizer : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tr;

	private static readonly System.IntPtr NativeFieldInfoPtr_musicClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_freqData;

	private static readonly System.IntPtr NativeFieldInfoPtr_fMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_fxTransformOrg;

	private static readonly System.IntPtr NativeMethodInfoPtr_BandVol_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr));

	public unsafe Transform tr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tr), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource musicClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> freqData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freqData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freqData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float fMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fMax)) = num;
		}
	}

	public unsafe Vector3 fxTransformOrg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fxTransformOrg);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fxTransformOrg)) = vector;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 100508, RefRangeEnd = 100509, XrefRangeStart = 100495, XrefRangeEnd = 100508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float BandVol(float fLow, float fHigh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&fLow);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fHigh;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BandVol_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100509, XrefRangeEnd = 100511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100511, XrefRangeEnd = 100517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100517, XrefRangeEnd = 100523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MusicVisualizer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MusicVisualizer()
	{
		Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MusicVisualizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr);
		NativeFieldInfoPtr_tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, "tr");
		NativeFieldInfoPtr_musicClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, "musicClip");
		NativeFieldInfoPtr_freqData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, "freqData");
		NativeFieldInfoPtr_fMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, "fMax");
		NativeFieldInfoPtr_fxTransformOrg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, "fxTransformOrg");
		NativeMethodInfoPtr_BandVol_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, 100669178);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, 100669179);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, 100669180);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicVisualizer>.NativeClassPtr, 100669181);
	}

	public MusicVisualizer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
