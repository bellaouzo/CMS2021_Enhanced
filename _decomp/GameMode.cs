using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class GameMode : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModGarage;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModGarageDisassemble;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModGarageAssemble;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModExamineCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModPartSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModPartSelectMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModPartMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModPartUnMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModGroupMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModGroupUnMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModExamineGarage;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModInteriorDisassemble;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillSpeedModInteriorAssemble;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPartSelectMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnModeChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_orbitCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_mountUnMountMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_BlockModeChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckMountUnMountMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentMode_Public_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousMode_Public_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareWithCurrentMode_Public_Boolean_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareWithPreviousMode_Public_Boolean_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreviousMode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateFillSpeedForCurrentMode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateFillSpeedForMode_Private_Single_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentMode_Public_Void_gameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPartSelectMode_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableRaycast_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_GameMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameMode>.NativeClassPtr));

	public unsafe static ushort FillSpeedModGarage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModGarage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModGarage, &num);
		}
	}

	public unsafe static ushort FillSpeedModGarageDisassemble
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModGarageDisassemble, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModGarageDisassemble, &num);
		}
	}

	public unsafe static ushort FillSpeedModGarageAssemble
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModGarageAssemble, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModGarageAssemble, &num);
		}
	}

	public unsafe static ushort FillSpeedModExamineCondition
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModExamineCondition, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModExamineCondition, &num);
		}
	}

	public unsafe static ushort FillSpeedModPartSelect
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModPartSelect, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModPartSelect, &num);
		}
	}

	public unsafe static ushort FillSpeedModPartSelectMount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModPartSelectMount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModPartSelectMount, &num);
		}
	}

	public unsafe static ushort FillSpeedModPartMount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModPartMount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModPartMount, &num);
		}
	}

	public unsafe static ushort FillSpeedModPartUnMount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModPartUnMount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModPartUnMount, &num);
		}
	}

	public unsafe static ushort FillSpeedModGroupMount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModGroupMount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModGroupMount, &num);
		}
	}

	public unsafe static ushort FillSpeedModGroupUnMount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModGroupUnMount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModGroupUnMount, &num);
		}
	}

	public unsafe static ushort FillSpeedModExamineGarage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModExamineGarage, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModExamineGarage, &num);
		}
	}

	public unsafe static ushort FillSpeedModInteriorDisassemble
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModInteriorDisassemble, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModInteriorDisassemble, &num);
		}
	}

	public unsafe static ushort FillSpeedModInteriorAssemble
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FillSpeedModInteriorAssemble, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FillSpeedModInteriorAssemble, &num);
		}
	}

	public unsafe Il2CppSystem.Action OnPartSelectMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPartSelectMode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPartSelectMode), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<gameMode> OnModeChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnModeChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<gameMode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnModeChange), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OrbitCamera orbitCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orbitCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OrbitCamera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orbitCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe gameMode currentMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMode);
			return *(gameMode*)num;
		}
		set
		{
			*(gameMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMode)) = gameMode2;
		}
	}

	public unsafe gameMode previousMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMode);
			return *(gameMode*)num;
		}
		set
		{
			*(gameMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMode)) = gameMode2;
		}
	}

	public unsafe bool mountUnMountMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountUnMountMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountUnMountMode)) = flag;
		}
	}

	public unsafe bool BlockModeChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlockModeChange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlockModeChange)) = flag;
		}
	}

	public unsafe static GameMode m_instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GameMode(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe bool CheckMountUnMountMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckMountUnMountMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe gameMode GetCurrentMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentMode_Public_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(gameMode*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe gameMode GetPreviousMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviousMode_Public_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(gameMode*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool CompareWithCurrentMode(gameMode toCompare)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&toCompare);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareWithCurrentMode_Public_Boolean_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool CompareWithPreviousMode(gameMode toCompare)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&toCompare);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareWithPreviousMode_Public_Boolean_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46688, XrefRangeEnd = 46689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPreviousMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreviousMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46689, XrefRangeEnd = 46694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecalculateFillSpeedForCurrentMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateFillSpeedForCurrentMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 46703, RefRangeEnd = 46707, XrefRangeStart = 46694, XrefRangeEnd = 46703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float RecalculateFillSpeedForMode(gameMode gameMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gameMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateFillSpeedForMode_Private_Single_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(176)]
	[CachedScanResults(RefRangeStart = 47409, RefRangeEnd = 47585, XrefRangeStart = 46707, XrefRangeEnd = 47409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentMode(gameMode newGameMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newGameMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentMode_Public_Void_gameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47585, XrefRangeEnd = 47639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPartSelectMode(Transform partTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(partTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPartSelectMode_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 47645, RefRangeEnd = 47652, XrefRangeStart = 47639, XrefRangeEnd = 47645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableRaycast(bool isEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isEnabled);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableRaycast_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(209)]
	[CachedScanResults(RefRangeStart = 47680, RefRangeEnd = 47889, XrefRangeStart = 47652, XrefRangeEnd = 47680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameMode Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_GameMode_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameMode(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47889, XrefRangeEnd = 47912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47912, XrefRangeEnd = 47915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameMode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameMode>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameMode()
	{
		Il2CppClassPointerStore<GameMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GameMode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameMode>.NativeClassPtr);
		NativeFieldInfoPtr_FillSpeedModGarage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModGarage");
		NativeFieldInfoPtr_FillSpeedModGarageDisassemble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModGarageDisassemble");
		NativeFieldInfoPtr_FillSpeedModGarageAssemble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModGarageAssemble");
		NativeFieldInfoPtr_FillSpeedModExamineCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModExamineCondition");
		NativeFieldInfoPtr_FillSpeedModPartSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModPartSelect");
		NativeFieldInfoPtr_FillSpeedModPartSelectMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModPartSelectMount");
		NativeFieldInfoPtr_FillSpeedModPartMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModPartMount");
		NativeFieldInfoPtr_FillSpeedModPartUnMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModPartUnMount");
		NativeFieldInfoPtr_FillSpeedModGroupMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModGroupMount");
		NativeFieldInfoPtr_FillSpeedModGroupUnMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModGroupUnMount");
		NativeFieldInfoPtr_FillSpeedModExamineGarage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModExamineGarage");
		NativeFieldInfoPtr_FillSpeedModInteriorDisassemble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModInteriorDisassemble");
		NativeFieldInfoPtr_FillSpeedModInteriorAssemble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "FillSpeedModInteriorAssemble");
		NativeFieldInfoPtr_OnPartSelectMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "OnPartSelectMode");
		NativeFieldInfoPtr_OnModeChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "OnModeChange");
		NativeFieldInfoPtr_orbitCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "orbitCamera");
		NativeFieldInfoPtr_currentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "currentMode");
		NativeFieldInfoPtr_previousMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "previousMode");
		NativeFieldInfoPtr_mountUnMountMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "mountUnMountMode");
		NativeFieldInfoPtr_BlockModeChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "BlockModeChange");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMode>.NativeClassPtr, "m_instance");
		NativeMethodInfoPtr_CheckMountUnMountMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666129);
		NativeMethodInfoPtr_GetCurrentMode_Public_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666130);
		NativeMethodInfoPtr_GetPreviousMode_Public_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666131);
		NativeMethodInfoPtr_CompareWithCurrentMode_Public_Boolean_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666132);
		NativeMethodInfoPtr_CompareWithPreviousMode_Public_Boolean_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666133);
		NativeMethodInfoPtr_SetPreviousMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666134);
		NativeMethodInfoPtr_RecalculateFillSpeedForCurrentMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666135);
		NativeMethodInfoPtr_RecalculateFillSpeedForMode_Private_Single_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666136);
		NativeMethodInfoPtr_SetCurrentMode_Public_Void_gameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666137);
		NativeMethodInfoPtr_SetPartSelectMode_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666138);
		NativeMethodInfoPtr_EnableRaycast_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666139);
		NativeMethodInfoPtr_Get_Public_Static_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666140);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666141);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMode>.NativeClassPtr, 100666142);
	}

	public GameMode(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
public enum gameMode : byte
{
	Garage,
	GarageDisassemble,
	GarageAssemble,
	InteriorDisassemble,
	InteriorAssemble,
	Interior,
	PartSelect,
	UI,
	PhotoMode,
	PartMount,
	PartUnMount,
	GroupUnMount,
	GroupMount,
	PartSelectMount,
	ExamineCondition,
	CarDrive,
	PathTest,
	ExamineTools,
	Dyno,
	Benchmark,
	ExamineGarage,
	BonusAssemble,
	BonusDisassemble,
	DrainTool,
	None,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<gameMode>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static gameMode()
	{
		Il2CppClassPointerStore<gameMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "gameMode");
	}

}
