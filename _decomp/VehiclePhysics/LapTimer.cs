using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class LapTimer : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sectors;

	private static readonly System.IntPtr NativeFieldInfoPtr_minLapTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableTestKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentSector;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_trackStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sectorStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_invalidLap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_laps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bestTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sectors;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewLap_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTimerHit_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateLap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSectors_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatLapTime_Private_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSectorTime_Private_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LapTimer>.NativeClassPtr));

	public unsafe int sectors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sectors);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sectors)) = num;
		}
	}

	public unsafe float minLapTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLapTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLapTime)) = num;
		}
	}

	public unsafe float positionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX)) = num;
		}
	}

	public unsafe float positionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionY)) = num;
		}
	}

	public unsafe KeyCode resetKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetKey)) = keyCode;
		}
	}

	public unsafe bool enableTestKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTestKeys);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTestKeys)) = flag;
		}
	}

	public unsafe GUIStyle style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle bigStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_currentSector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentSector);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentSector)) = num;
		}
	}

	public unsafe float m_trackStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_trackStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_trackStartTime)) = num;
		}
	}

	public unsafe float m_sectorStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sectorStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sectorStartTime)) = num;
		}
	}

	public unsafe bool m_invalidLap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_invalidLap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_invalidLap)) = flag;
		}
	}

	public unsafe List<float> m_laps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_laps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_laps), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_lastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastTime)) = num;
		}
	}

	public unsafe float m_bestTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bestTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bestTime)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> m_sectors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sectors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sectors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122611, XrefRangeEnd = 122614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122614, XrefRangeEnd = 122625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122636, RefRangeEnd = 122637, XrefRangeStart = 122625, XrefRangeEnd = 122636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NewLap(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewLap_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122651, RefRangeEnd = 122655, XrefRangeStart = 122637, XrefRangeEnd = 122651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTimerHit(int sector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sector);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTimerHit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void InvalidateLap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvalidateLap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122655, RefRangeEnd = 122657, XrefRangeStart = 122655, XrefRangeEnd = 122655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSectors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSectors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122657, XrefRangeEnd = 122757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 122776, RefRangeEnd = 122779, XrefRangeStart = 122757, XrefRangeEnd = 122776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatLapTime(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatLapTime_Private_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122783, RefRangeEnd = 122784, XrefRangeStart = 122779, XrefRangeEnd = 122783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatSectorTime(float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSectorTime_Private_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122784, XrefRangeEnd = 122802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LapTimer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LapTimer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LapTimer()
	{
		Il2CppClassPointerStore<LapTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "LapTimer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LapTimer>.NativeClassPtr);
		NativeFieldInfoPtr_sectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "sectors");
		NativeFieldInfoPtr_minLapTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "minLapTime");
		NativeFieldInfoPtr_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "positionX");
		NativeFieldInfoPtr_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "positionY");
		NativeFieldInfoPtr_resetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "resetKey");
		NativeFieldInfoPtr_enableTestKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "enableTestKeys");
		NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "style");
		NativeFieldInfoPtr_bigStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "bigStyle");
		NativeFieldInfoPtr_m_currentSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_currentSector");
		NativeFieldInfoPtr_m_trackStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_trackStartTime");
		NativeFieldInfoPtr_m_sectorStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_sectorStartTime");
		NativeFieldInfoPtr_m_invalidLap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_invalidLap");
		NativeFieldInfoPtr_m_laps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_laps");
		NativeFieldInfoPtr_m_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_lastTime");
		NativeFieldInfoPtr_m_bestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_bestTime");
		NativeFieldInfoPtr_m_sectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, "m_sectors");
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671158);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671159);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671160);
		NativeMethodInfoPtr_NewLap_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671161);
		NativeMethodInfoPtr_OnTimerHit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671162);
		NativeMethodInfoPtr_InvalidateLap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671163);
		NativeMethodInfoPtr_ClearSectors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671164);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671165);
		NativeMethodInfoPtr_FormatLapTime_Private_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671166);
		NativeMethodInfoPtr_FormatSectorTime_Private_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671167);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LapTimer>.NativeClassPtr, 100671168);
	}

	public LapTimer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
