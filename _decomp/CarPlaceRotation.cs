using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarPlaceRotation : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_yawRange;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewRotation_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr));

	public unsafe Vector2 yawRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yawRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yawRange)) = vector;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95860, XrefRangeEnd = 95861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetNewRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewRotation_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarPlaceRotation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarPlaceRotation()
	{
		Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarPlaceRotation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr);
		NativeFieldInfoPtr_yawRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr, "yawRange");
		NativeMethodInfoPtr_GetNewRotation_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr, 100668861);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceRotation>.NativeClassPtr, 100668862);
	}

	public CarPlaceRotation(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
