using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class CarPart : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_Switched;

	private static readonly System.IntPtr NativeFieldInfoPtr_InProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_TakeOnOffInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_Condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Unmounted;

	private static readonly System.IntPtr NativeFieldInfoPtr_TunedID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsTinted;

	private static readonly System.IntPtr NativeFieldInfoPtr_TintColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_StructureCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConditionPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_Livery;

	private static readonly System.IntPtr NativeFieldInfoPtr_LiveryStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutsideRustEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dent;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalString;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedParts;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dust;

	private static readonly System.IntPtr NativeFieldInfoPtr_WashFactor;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConditionToShow_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Void_BodyPartData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuned_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIDWithTuned_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorAndOpacity_Public_Void_Color_Int32_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarPart>.NativeClassPtr));

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe GameObject handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool Switched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Switched);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Switched)) = flag;
		}
	}

	public unsafe bool InProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InProgress)) = flag;
		}
	}

	public unsafe bool TakeOnOffInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TakeOnOffInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TakeOnOffInProgress)) = flag;
		}
	}

	public unsafe float Condition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition)) = num;
		}
	}

	public unsafe bool Unmounted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Unmounted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Unmounted)) = flag;
		}
	}

	public unsafe string TunedID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TunedID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TunedID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsTinted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTinted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTinted)) = flag;
		}
	}

	public unsafe Color TintColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TintColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TintColor)) = color;
		}
	}

	public unsafe Color Color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color)) = color;
		}
	}

	public unsafe PaintType PaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType)) = paintType;
		}
	}

	public unsafe PaintData PaintData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData);
			return *(PaintData*)num;
		}
		set
		{
			*(PaintData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData)) = paintData;
		}
	}

	public unsafe float StructureCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StructureCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StructureCondition)) = num;
		}
	}

	public unsafe float ConditionPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConditionPaint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConditionPaint)) = num;
		}
	}

	public unsafe string Livery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Livery);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Livery), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float LiveryStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LiveryStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LiveryStrength)) = num;
		}
	}

	public unsafe bool OutsideRustEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutsideRustEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutsideRustEnabled)) = flag;
		}
	}

	public unsafe float Dent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dent)) = num;
		}
	}

	public unsafe string AdditionalString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdditionalString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdditionalString), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe List<string> ConnectedParts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectedParts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConnectedParts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int Quality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality)) = num;
		}
	}

	public unsafe float Dust
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dust);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dust)) = num;
		}
	}

	public unsafe float WashFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashFactor)) = num;
		}
	}

	public unsafe float ConditionToShow
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConditionToShow_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89932, RefRangeEnd = 89933, XrefRangeStart = 89923, XrefRangeEnd = 89932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarPart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarPart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89933, XrefRangeEnd = 89950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarPart(GameObject go)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarPart>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 89966, RefRangeEnd = 89974, XrefRangeStart = 89950, XrefRangeEnd = 89966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarPart(GameObject go, string goName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarPart>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(goName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89974, XrefRangeEnd = 89984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clone(BodyPartData carBodyPartData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carBodyPartData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Void_BodyPartData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 89986, RefRangeEnd = 89994, XrefRangeStart = 89984, XrefRangeEnd = 89986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTuned(bool forLicensePlate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forLicensePlate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuned_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 89998, RefRangeEnd = 90016, XrefRangeStart = 89994, XrefRangeEnd = 89998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetIDWithTuned()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIDWithTuned_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe void SetColorAndOpacity(Color color, int opacity, bool tinted)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&color);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tinted;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorAndOpacity_Public_Void_Color_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarPart()
	{
		Il2CppClassPointerStore<CarPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarPart>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "name");
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "handle");
		NativeFieldInfoPtr_Switched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Switched");
		NativeFieldInfoPtr_InProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "InProgress");
		NativeFieldInfoPtr_TakeOnOffInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "TakeOnOffInProgress");
		NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Condition");
		NativeFieldInfoPtr_Unmounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Unmounted");
		NativeFieldInfoPtr_TunedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "TunedID");
		NativeFieldInfoPtr_IsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "IsTinted");
		NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "TintColor");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_StructureCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "StructureCondition");
		NativeFieldInfoPtr_ConditionPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "ConditionPaint");
		NativeFieldInfoPtr_Livery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Livery");
		NativeFieldInfoPtr_LiveryStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "LiveryStrength");
		NativeFieldInfoPtr_OutsideRustEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "OutsideRustEnabled");
		NativeFieldInfoPtr_Dent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Dent");
		NativeFieldInfoPtr_AdditionalString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "AdditionalString");
		NativeFieldInfoPtr_ConnectedParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "ConnectedParts");
		NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Quality");
		NativeFieldInfoPtr_Dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "Dust");
		NativeFieldInfoPtr_WashFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPart>.NativeClassPtr, "WashFactor");
		NativeMethodInfoPtr_get_ConditionToShow_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668453);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668454);
		NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668455);
		NativeMethodInfoPtr__ctor_Public_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668456);
		NativeMethodInfoPtr_Clone_Public_Void_BodyPartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668457);
		NativeMethodInfoPtr_IsTuned_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668458);
		NativeMethodInfoPtr_GetIDWithTuned_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668459);
		NativeMethodInfoPtr_SetColorAndOpacity_Public_Void_Color_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPart>.NativeClassPtr, 100668460);
	}

	public CarPart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
