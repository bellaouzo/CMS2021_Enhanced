using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag;

public class DragSelectedModes : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dragTypeImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragClassImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragLengthImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_oneMileImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_halfMileImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_quarterMileImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_eightMileImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_practiceImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_quickRaceImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_singleRaceImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_championshipImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_classEImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_classDImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_classCImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_classBImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_classAImage;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDragType_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDragClass_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDragLength_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDragType_Public_Void_DragType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDragClass_Public_Void_DragClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDragLength_Public_Void_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr));

	public unsafe Image dragTypeImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragTypeImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragTypeImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image dragClassImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragClassImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragClassImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image dragLengthImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragLengthImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragLengthImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite oneMileImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneMileImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneMileImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite halfMileImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfMileImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfMileImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite quarterMileImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quarterMileImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quarterMileImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite eightMileImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eightMileImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eightMileImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite practiceImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_practiceImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_practiceImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite quickRaceImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quickRaceImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quickRaceImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite singleRaceImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleRaceImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleRaceImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite championshipImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_championshipImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_championshipImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite classEImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classEImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classEImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite classDImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classDImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classDImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite classCImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classCImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classCImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite classBImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classBImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classBImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite classAImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classAImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classAImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 199186, RefRangeEnd = 199191, XrefRangeStart = 199177, XrefRangeEnd = 199186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableDragType(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDragType_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void EnableDragClass(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDragClass_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 199200, RefRangeEnd = 199205, XrefRangeStart = 199191, XrefRangeEnd = 199200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableDragLength(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDragLength_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 199206, RefRangeEnd = 199209, XrefRangeStart = 199205, XrefRangeEnd = 199206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragType(DragType dragType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDragType_Public_Void_DragType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 199210, RefRangeEnd = 199215, XrefRangeStart = 199209, XrefRangeEnd = 199210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragClass(DragClass dragClass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDragClass_Public_Void_DragClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 199216, RefRangeEnd = 199221, XrefRangeStart = 199215, XrefRangeEnd = 199216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragLength(DragLength dragLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragLength);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDragLength_Public_Void_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragSelectedModes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragSelectedModes()
	{
		Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragSelectedModes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr);
		NativeFieldInfoPtr_dragTypeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "dragTypeImage");
		NativeFieldInfoPtr_dragClassImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "dragClassImage");
		NativeFieldInfoPtr_dragLengthImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "dragLengthImage");
		NativeFieldInfoPtr_oneMileImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "oneMileImage");
		NativeFieldInfoPtr_halfMileImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "halfMileImage");
		NativeFieldInfoPtr_quarterMileImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "quarterMileImage");
		NativeFieldInfoPtr_eightMileImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "eightMileImage");
		NativeFieldInfoPtr_practiceImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "practiceImage");
		NativeFieldInfoPtr_quickRaceImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "quickRaceImage");
		NativeFieldInfoPtr_singleRaceImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "singleRaceImage");
		NativeFieldInfoPtr_championshipImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "championshipImage");
		NativeFieldInfoPtr_classEImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "classEImage");
		NativeFieldInfoPtr_classDImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "classDImage");
		NativeFieldInfoPtr_classCImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "classCImage");
		NativeFieldInfoPtr_classBImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "classBImage");
		NativeFieldInfoPtr_classAImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, "classAImage");
		NativeMethodInfoPtr_EnableDragType_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678292);
		NativeMethodInfoPtr_EnableDragClass_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678293);
		NativeMethodInfoPtr_EnableDragLength_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678294);
		NativeMethodInfoPtr_SetDragType_Public_Void_DragType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678295);
		NativeMethodInfoPtr_SetDragClass_Public_Void_DragClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678296);
		NativeMethodInfoPtr_SetDragLength_Public_Void_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678297);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectedModes>.NativeClassPtr, 100678298);
	}

	public DragSelectedModes(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
