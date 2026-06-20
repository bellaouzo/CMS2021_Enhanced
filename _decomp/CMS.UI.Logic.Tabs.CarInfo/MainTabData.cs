using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Drag;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Tabs.CarInfo;

public class MainTabData : CarInfoTab
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarCurrentColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarFactoryColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_BodyCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_PartsCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrameCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteriorCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mileage;

	private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarOrigin;

	private static readonly System.IntPtr NativeFieldInfoPtr_FactoryTireSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_FactoryRimType;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanBeFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorVariants;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarRibbon;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragIndexDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanShowConditions;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupConditions_Private_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupColors_Private_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAllowedPlaces_Private_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MainTabData>.NativeClassPtr));

	public unsafe Image CarPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarPreview);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarPreview), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image CarCurrentColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarCurrentColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarCurrentColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image CarFactoryColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarFactoryColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarFactoryColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Condition BodyCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyCondition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Condition(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyCondition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Condition PartsCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartsCondition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Condition(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartsCondition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Condition FrameCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrameCondition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Condition(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrameCondition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Condition InteriorCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteriorCondition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Condition(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteriorCondition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text CarName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text Mileage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mileage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mileage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text CarOrigin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarOrigin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarOrigin), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text FactoryTireSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactoryTireSize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactoryTireSize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text FactoryRimType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactoryRimType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FactoryRimType), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text CarVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarVersion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarVersion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text CanBeFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanBeFound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanBeFound), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Image> ColorVariants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorVariants);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorVariants), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarRibbon CarRibbon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarRibbon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarRibbon(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarRibbon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragIndexDisplay DragIndexDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragIndexDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragIndexDisplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragIndexDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool CanShowConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanShowConditions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanShowConditions)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186013, XrefRangeEnd = 186018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186018, XrefRangeEnd = 186094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetupData(CarInfoWindowData carInfoWindowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carInfoWindowData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186121, RefRangeEnd = 186122, XrefRangeStart = 186094, XrefRangeEnd = 186121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupConditions(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupConditions_Private_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186135, RefRangeEnd = 186136, XrefRangeStart = 186122, XrefRangeEnd = 186135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupColors(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupColors_Private_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186176, RefRangeEnd = 186177, XrefRangeStart = 186136, XrefRangeEnd = 186176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAllowedPlaces(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAllowedPlaces_Private_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MainTabData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainTabData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MainTabData()
	{
		Il2CppClassPointerStore<MainTabData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Tabs.CarInfo", "MainTabData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainTabData>.NativeClassPtr);
		NativeFieldInfoPtr_CarPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarPreview");
		NativeFieldInfoPtr_CarCurrentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarCurrentColor");
		NativeFieldInfoPtr_CarFactoryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarFactoryColor");
		NativeFieldInfoPtr_BodyCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "BodyCondition");
		NativeFieldInfoPtr_PartsCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "PartsCondition");
		NativeFieldInfoPtr_FrameCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "FrameCondition");
		NativeFieldInfoPtr_InteriorCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "InteriorCondition");
		NativeFieldInfoPtr_CarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarName");
		NativeFieldInfoPtr_Mileage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "Mileage");
		NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "Weight");
		NativeFieldInfoPtr_CarOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarOrigin");
		NativeFieldInfoPtr_FactoryTireSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "FactoryTireSize");
		NativeFieldInfoPtr_FactoryRimType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "FactoryRimType");
		NativeFieldInfoPtr_CarVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarVersion");
		NativeFieldInfoPtr_CanBeFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CanBeFound");
		NativeFieldInfoPtr_ColorVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "ColorVariants");
		NativeFieldInfoPtr_CarRibbon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CarRibbon");
		NativeFieldInfoPtr_DragIndexDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "DragIndexDisplay");
		NativeFieldInfoPtr_CanShowConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, "CanShowConditions");
		NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676932);
		NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676933);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676934);
		NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676935);
		NativeMethodInfoPtr_SetupConditions_Private_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676936);
		NativeMethodInfoPtr_SetupColors_Private_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676937);
		NativeMethodInfoPtr_SetupAllowedPlaces_Private_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676938);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainTabData>.NativeClassPtr, 100676939);
	}

	public MainTabData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
