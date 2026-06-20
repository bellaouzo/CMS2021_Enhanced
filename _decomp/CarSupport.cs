using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarSupport : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_FL;

	private static readonly System.IntPtr NativeFieldInfoPtr_FR;

	private static readonly System.IntPtr NativeFieldInfoPtr_RL;

	private static readonly System.IntPtr NativeFieldInfoPtr_RR;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportHeightMod;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRandomLook_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForCar_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarSupport>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<MeshFilter> meshFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<MeshFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilters), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<MeshRenderer> meshRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject FL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FL);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FL), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject FR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FR);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FR), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject RL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RL);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RL), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject RR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RR);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RR), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static float supportHeightMod
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportHeightMod, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportHeightMod, &num);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92431, RefRangeEnd = 92432, XrefRangeStart = 92333, XrefRangeEnd = 92431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRandomLook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRandomLook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 92449, RefRangeEnd = 92456, XrefRangeStart = 92432, XrefRangeEnd = 92449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92637, RefRangeEnd = 92638, XrefRangeStart = 92456, XrefRangeEnd = 92637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForCar(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForCar_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarSupport()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarSupport>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarSupport()
	{
		Il2CppClassPointerStore<CarSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarSupport>.NativeClassPtr);
		NativeFieldInfoPtr_meshFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "meshFilters");
		NativeFieldInfoPtr_meshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "meshRenderers");
		NativeFieldInfoPtr_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "FL");
		NativeFieldInfoPtr_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "FR");
		NativeFieldInfoPtr_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "RL");
		NativeFieldInfoPtr_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "RR");
		NativeFieldInfoPtr_supportHeightMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, "supportHeightMod");
		NativeMethodInfoPtr_SetupRandomLook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, 100668583);
		NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, 100668584);
		NativeMethodInfoPtr_SetupForCar_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, 100668585);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSupport>.NativeClassPtr, 100668586);
	}

	public CarSupport(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
