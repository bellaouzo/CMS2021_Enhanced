using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Map.Info;

public class CarInfoPanel : MapInfoPanel
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mileage;

	private static readonly System.IntPtr NativeFieldInfoPtr_weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_measuredPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_measuredTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_powerText;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueText;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveIssues;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelAlignmentIssue;

	private static readonly System.IntPtr NativeFieldInfoPtr_needDyno;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_CarLoader_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTuning_Private_Void_byref_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupMeasuredPowerAndTorque_Private_Void_byref_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupIssues_Private_Void_byref_CarLoader_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveIssues_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveWheelAlignmentIssue_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NeedDyno_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarIssues_Private_Boolean_byref_CarLoader_byref_String_SceneType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr));

	public unsafe Text mileage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mileage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mileage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text measuredPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredPower);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredPower), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text measuredTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredTorque);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_measuredTorque), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text tireSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text engine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text powerText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text torqueText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool haveIssues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveIssues);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveIssues)) = flag;
		}
	}

	public unsafe bool wheelAlignmentIssue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelAlignmentIssue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelAlignmentIssue)) = flag;
		}
	}

	public unsafe bool needDyno
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needDyno);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needDyno)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196986, RefRangeEnd = 196987, XrefRangeStart = 196956, XrefRangeEnd = 196986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare(CarLoader carLoader, SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(SceneType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_CarLoader_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196987, XrefRangeEnd = 196993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckTuning(ref CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTuning_Private_Void_byref_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		carLoader = ((intPtr3 == (System.IntPtr)0) ? null : new CarLoader(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 197016, RefRangeEnd = 197017, XrefRangeStart = 196993, XrefRangeEnd = 197016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupMeasuredPowerAndTorque(ref CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupMeasuredPowerAndTorque_Private_Void_byref_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		carLoader = ((intPtr3 == (System.IntPtr)0) ? null : new CarLoader(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197017, XrefRangeEnd = 197028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupIssues(ref CarLoader carLoader, SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*ptr = (nint)(&intPtr);
		*(SceneType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupIssues_Private_Void_byref_CarLoader_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		carLoader = ((intPtr3 == (System.IntPtr)0) ? null : new CarLoader(intPtr3));
	}

	[CallerCount(0)]
	public unsafe bool HaveIssues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveIssues_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool HaveWheelAlignmentIssue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveWheelAlignmentIssue_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool NeedDyno()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedDyno_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 197090, RefRangeEnd = 197092, XrefRangeStart = 197028, XrefRangeEnd = 197090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetCarIssues(ref CarLoader carLoader, out string result, SceneType sceneType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(result);
		*(System.IntPtr**)num = &il2CppString;
		*(SceneType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarIssues_Private_Boolean_byref_CarLoader_byref_String_SceneType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		carLoader = ((intPtr2 == (System.IntPtr)0) ? null : new CarLoader(intPtr2));
		result = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarInfoPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarInfoPanel()
	{
		Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Map.Info", "CarInfoPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr);
		NativeFieldInfoPtr_mileage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "mileage");
		NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "weight");
		NativeFieldInfoPtr_measuredPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "measuredPower");
		NativeFieldInfoPtr_measuredTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "measuredTorque");
		NativeFieldInfoPtr_tireSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "tireSize");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "version");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "color");
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_powerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "powerText");
		NativeFieldInfoPtr_torqueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "torqueText");
		NativeFieldInfoPtr_haveIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "haveIssues");
		NativeFieldInfoPtr_wheelAlignmentIssue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "wheelAlignmentIssue");
		NativeFieldInfoPtr_needDyno = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, "needDyno");
		NativeMethodInfoPtr_Prepare_Public_Void_CarLoader_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678045);
		NativeMethodInfoPtr_CheckTuning_Private_Void_byref_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678046);
		NativeMethodInfoPtr_SetupMeasuredPowerAndTorque_Private_Void_byref_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678047);
		NativeMethodInfoPtr_SetupIssues_Private_Void_byref_CarLoader_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678048);
		NativeMethodInfoPtr_HaveIssues_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678049);
		NativeMethodInfoPtr_HaveWheelAlignmentIssue_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678050);
		NativeMethodInfoPtr_NeedDyno_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678051);
		NativeMethodInfoPtr_GetCarIssues_Private_Boolean_byref_CarLoader_byref_String_SceneType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678052);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPanel>.NativeClassPtr, 100678053);
	}

	public CarInfoPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
