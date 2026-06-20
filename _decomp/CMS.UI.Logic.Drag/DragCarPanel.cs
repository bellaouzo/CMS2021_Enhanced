using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag;

public class DragCarPanel : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_showroomCarItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_engine;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireType;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragIndexDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_detailed;

	private static readonly System.IntPtr NativeFieldInfoPtr_modeDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_modeDescriptionText;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCarConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDragIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCarID_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCarConfig_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDragIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForCar_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForDevCar_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEngine_Private_Void_NewCarData_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEngine_Private_Void_String_Int32_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTires_Private_Void_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTires_Private_Void_String_Int32_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCarVersion_Private_Void_String_Int32_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDetailedInfo_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescription_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr));

	public unsafe ShowroomCarItem showroomCarItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showroomCarItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ShowroomCarItem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showroomCarItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Text tireType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireType), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe DragIndexDisplay dragIndexDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragIndexDisplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject detailed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject modeDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modeDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modeDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text modeDescriptionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modeDescriptionText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modeDescriptionText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string currentCarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int currentCarConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarConfig);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarConfig)) = num;
		}
	}

	public unsafe int currentDragIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDragIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDragIndex)) = num;
		}
	}

	public unsafe string CurrentCarID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentCarID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	public unsafe int CurrentCarConfig
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentCarConfig_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int CurrentDragIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentDragIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 198403, RefRangeEnd = 198405, XrefRangeStart = 198368, XrefRangeEnd = 198403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForCar(string saveName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(saveName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForCar_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 198435, RefRangeEnd = 198437, XrefRangeStart = 198405, XrefRangeEnd = 198435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForDevCar(string carID, int config)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForDevCar_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198437, XrefRangeEnd = 198450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupEngine(NewCarData carData, CarBundleLoader carBundleLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEngine_Private_Void_NewCarData_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198450, XrefRangeEnd = 198462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupEngine(string carID, int config, CarBundleLoader carBundleLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEngine_Private_Void_String_Int32_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198462, XrefRangeEnd = 198466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTires(NewCarData carData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTires_Private_Void_NewCarData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198466, XrefRangeEnd = 198469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTires(string carID, int config, CarBundleLoader carBundleLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTires_Private_Void_String_Int32_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 198476, RefRangeEnd = 198478, XrefRangeStart = 198469, XrefRangeEnd = 198476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCarVersion(string carID, int config, CarBundleLoader carBundleLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCarVersion_Private_Void_String_Int32_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 198497, RefRangeEnd = 198500, XrefRangeStart = 198478, XrefRangeEnd = 198497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableDetailedInfo(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDetailedInfo_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetDescription(string description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragCarPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragCarPanel()
	{
		Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragCarPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr);
		NativeFieldInfoPtr_showroomCarItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "showroomCarItem");
		NativeFieldInfoPtr_engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "engine");
		NativeFieldInfoPtr_tireType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "tireType");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "version");
		NativeFieldInfoPtr_dragIndexDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "dragIndexDisplay");
		NativeFieldInfoPtr_detailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "detailed");
		NativeFieldInfoPtr_modeDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "modeDescription");
		NativeFieldInfoPtr_modeDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "modeDescriptionText");
		NativeFieldInfoPtr_currentCarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "currentCarID");
		NativeFieldInfoPtr_currentCarConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "currentCarConfig");
		NativeFieldInfoPtr_currentDragIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, "currentDragIndex");
		NativeMethodInfoPtr_get_CurrentCarID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678207);
		NativeMethodInfoPtr_get_CurrentCarConfig_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678208);
		NativeMethodInfoPtr_get_CurrentDragIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678209);
		NativeMethodInfoPtr_PrepareForCar_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678210);
		NativeMethodInfoPtr_PrepareForDevCar_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678211);
		NativeMethodInfoPtr_SetupEngine_Private_Void_NewCarData_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678212);
		NativeMethodInfoPtr_SetupEngine_Private_Void_String_Int32_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678213);
		NativeMethodInfoPtr_SetupTires_Private_Void_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678214);
		NativeMethodInfoPtr_SetupTires_Private_Void_String_Int32_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678215);
		NativeMethodInfoPtr_SetupCarVersion_Private_Void_String_Int32_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678216);
		NativeMethodInfoPtr_EnableDetailedInfo_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678217);
		NativeMethodInfoPtr_SetDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678218);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarPanel>.NativeClassPtr, 100678219);
	}

	public DragCarPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
