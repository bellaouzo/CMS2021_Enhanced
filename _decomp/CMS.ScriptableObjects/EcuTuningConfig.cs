using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.ScriptableObjects;

public class EcuTuningConfig : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stage1BarCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage2BarCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage3BarCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage1BarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage2BarValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage3BarValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBarCountForStage_Public_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBarValueForStage_Public_Single_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr));

	public unsafe byte stage1BarCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1BarCount);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1BarCount)) = b;
		}
	}

	public unsafe byte stage2BarCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2BarCount);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2BarCount)) = b;
		}
	}

	public unsafe byte stage3BarCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3BarCount);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3BarCount)) = b;
		}
	}

	public unsafe float stage1BarValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1BarValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1BarValue)) = num;
		}
	}

	public unsafe float stage2BarValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2BarValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2BarValue)) = num;
		}
	}

	public unsafe float stage3BarValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3BarValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3BarValue)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe byte GetBarCountForStage(byte stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBarCountForStage_Public_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetBarValueForStage(byte stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBarValueForStage_Public_Single_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227114, XrefRangeEnd = 227115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EcuTuningConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EcuTuningConfig()
	{
		Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ScriptableObjects", "EcuTuningConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr);
		NativeFieldInfoPtr_stage1BarCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, "stage1BarCount");
		NativeFieldInfoPtr_stage2BarCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, "stage2BarCount");
		NativeFieldInfoPtr_stage3BarCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, "stage3BarCount");
		NativeFieldInfoPtr_stage1BarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, "stage1BarValue");
		NativeFieldInfoPtr_stage2BarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, "stage2BarValue");
		NativeFieldInfoPtr_stage3BarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, "stage3BarValue");
		NativeMethodInfoPtr_GetBarCountForStage_Public_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, 100680284);
		NativeMethodInfoPtr_GetBarValueForStage_Public_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, 100680285);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcuTuningConfig>.NativeClassPtr, 100680286);
	}

	public EcuTuningConfig(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
