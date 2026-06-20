using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class RadialLayout : LayoutGroup
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fAngles;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRadial_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr));

	public unsafe float fDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fDistance)) = num;
		}
	}

	public unsafe float MinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinAngle)) = num;
		}
	}

	public unsafe float MaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxAngle)) = num;
		}
	}

	public unsafe float StartAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartAngle)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> fAngles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fAngles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fAngles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119131, XrefRangeEnd = 119133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void SetLayoutHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void SetLayoutVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119133, XrefRangeEnd = 119134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void CalculateLayoutInputVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void CalculateLayoutInputHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 119181, RefRangeEnd = 119185, XrefRangeStart = 119134, XrefRangeEnd = 119181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateRadial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateRadial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119185, XrefRangeEnd = 119186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RadialLayout()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RadialLayout()
	{
		Il2CppClassPointerStore<RadialLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "RadialLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr);
		NativeFieldInfoPtr_fDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, "fDistance");
		NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, "MinAngle");
		NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, "MaxAngle");
		NativeFieldInfoPtr_StartAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, "StartAngle");
		NativeFieldInfoPtr_fAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, "fAngles");
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670863);
		NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670864);
		NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670865);
		NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670866);
		NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670867);
		NativeMethodInfoPtr_CalculateRadial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670868);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadialLayout>.NativeClassPtr, 100670869);
	}

	public RadialLayout(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
