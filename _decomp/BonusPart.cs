using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class BonusPart : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IdFromConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_UID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_Reflection;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsUnmounted;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPainted;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_Parent;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteractiveObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDummy_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TakeOff_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TakeOn_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDummy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Paint_Public_Void_Boolean_CustomColor_PaintData_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_Static_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstItemForType_Public_String_SpecialGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BonusPart>.NativeClassPtr));

	public unsafe int IdFromConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdFromConfig);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IdFromConfig)) = num;
		}
	}

	public unsafe string UID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 Position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position)) = vector;
		}
	}

	public unsafe Vector3 Rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation)) = vector;
		}
	}

	public unsafe float Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Scale)) = num;
		}
	}

	public unsafe bool Reflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Reflection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Reflection)) = flag;
		}
	}

	public unsafe string ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe SpecialGroup Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(SpecialGroup*)num;
		}
		set
		{
			*(SpecialGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = specialGroup;
		}
	}

	public unsafe bool IsUnmounted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUnmounted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUnmounted)) = flag;
		}
	}

	public unsafe bool IsPainted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPainted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPainted)) = flag;
		}
	}

	public unsafe CustomColor Color
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color);
			return new CustomColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomColor>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe GameObject Handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Handle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Parent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InteractiveObject InteractiveObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractiveObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InteractiveObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractiveObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89618, RefRangeEnd = 89620, XrefRangeStart = 89616, XrefRangeEnd = 89618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDummy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDummy_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89627, RefRangeEnd = 89629, XrefRangeStart = 89620, XrefRangeEnd = 89627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TakeOff(bool instant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instant);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TakeOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89629, XrefRangeEnd = 89637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TakeOn(bool instant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instant);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TakeOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89637, XrefRangeEnd = 89640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDummy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDummy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89766, RefRangeEnd = 89770, XrefRangeStart = 89640, XrefRangeEnd = 89766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Change(string newId, bool fromEditor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromEditor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89802, RefRangeEnd = 89804, XrefRangeStart = 89770, XrefRangeEnd = 89802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Create(bool forEditor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forEditor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89821, RefRangeEnd = 89822, XrefRangeStart = 89804, XrefRangeEnd = 89821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Paint(bool isPainted, CustomColor color, PaintData paintData, PaintType paintType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&isPainted);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color));
		*(PaintData**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintData;
		*(PaintType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Paint_Public_Void_Boolean_CustomColor_PaintData_PaintType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 89837, RefRangeEnd = 89847, XrefRangeStart = 89822, XrefRangeEnd = 89837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89847, XrefRangeEnd = 89860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetItems()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_Static_List_1_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89860, XrefRangeEnd = 89865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFirstItemForType(SpecialGroup specialGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&specialGroup);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstItemForType_Public_String_SpecialGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe BonusPart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BonusPart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BonusPart()
	{
		Il2CppClassPointerStore<BonusPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BonusPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BonusPart>.NativeClassPtr);
		NativeFieldInfoPtr_IdFromConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "IdFromConfig");
		NativeFieldInfoPtr_UID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "UID");
		NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Position");
		NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Rotation");
		NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Scale");
		NativeFieldInfoPtr_Reflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Reflection");
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_IsUnmounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "IsUnmounted");
		NativeFieldInfoPtr_IsPainted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "IsPainted");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Handle");
		NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "Parent");
		NativeFieldInfoPtr_InteractiveObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, "InteractiveObject");
		NativeMethodInfoPtr_IsDummy_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668434);
		NativeMethodInfoPtr_TakeOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668435);
		NativeMethodInfoPtr_TakeOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668436);
		NativeMethodInfoPtr_SetDummy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668437);
		NativeMethodInfoPtr_Change_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668438);
		NativeMethodInfoPtr_Create_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668439);
		NativeMethodInfoPtr_Paint_Public_Void_Boolean_CustomColor_PaintData_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668440);
		NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668441);
		NativeMethodInfoPtr_GetItems_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668442);
		NativeMethodInfoPtr_GetFirstItemForType_Public_String_SpecialGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668443);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPart>.NativeClassPtr, 100668444);
	}

	public BonusPart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
