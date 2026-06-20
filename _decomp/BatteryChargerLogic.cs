using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class BatteryChargerLogic : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_spawnPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_battery;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemOnBatteryCharger;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearBatteryCharger_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetItemOnBatteryCharger_Public_Void_Item_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BatteryChargerActivate_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SetItemOnBatteryCharger_b__5_0_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SetItemOnBatteryCharger_b__5_1_Private_Void_Object_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr));

	public unsafe Transform spawnPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject battery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battery);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_battery), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Item ItemOnBatteryCharger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemOnBatteryCharger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Item(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemOnBatteryCharger), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95464, RefRangeEnd = 95465, XrefRangeStart = 95435, XrefRangeEnd = 95464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearBatteryCharger()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearBatteryCharger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95477, RefRangeEnd = 95479, XrefRangeStart = 95465, XrefRangeEnd = 95477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95520, RefRangeEnd = 95522, XrefRangeStart = 95479, XrefRangeEnd = 95520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetItemOnBatteryCharger(Item item, bool instant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instant;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetItemOnBatteryCharger_Public_Void_Item_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95617, RefRangeEnd = 95619, XrefRangeStart = 95522, XrefRangeEnd = 95617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BatteryChargerActivate(bool activate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&activate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BatteryChargerActivate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95619, XrefRangeEnd = 95627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe BatteryChargerLogic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95627, XrefRangeEnd = 95632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _SetItemOnBatteryCharger_b__5_0(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetItemOnBatteryCharger_b__5_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95632, XrefRangeEnd = 95635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _SetItemOnBatteryCharger_b__5_1(Il2CppSystem.Object x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetItemOnBatteryCharger_b__5_1_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BatteryChargerLogic()
	{
		Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BatteryChargerLogic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr);
		NativeFieldInfoPtr_spawnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, "spawnPosition");
		NativeFieldInfoPtr_battery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, "battery");
		NativeFieldInfoPtr_ItemOnBatteryCharger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, "ItemOnBatteryCharger");
		NativeMethodInfoPtr_ClearBatteryCharger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668843);
		NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668844);
		NativeMethodInfoPtr_SetItemOnBatteryCharger_Public_Void_Item_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668845);
		NativeMethodInfoPtr_BatteryChargerActivate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668846);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668847);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668848);
		NativeMethodInfoPtr__SetItemOnBatteryCharger_b__5_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668849);
		NativeMethodInfoPtr__SetItemOnBatteryCharger_b__5_1_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatteryChargerLogic>.NativeClassPtr, 100668850);
	}

	public BatteryChargerLogic(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
