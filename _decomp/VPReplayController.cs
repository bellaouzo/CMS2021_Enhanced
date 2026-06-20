using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPReplayController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enableShortcuts;

	private static readonly System.IntPtr NativeFieldInfoPtr_recordKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_playPauseKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_rewindKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_quitKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_togglePanelKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_showPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoShowHide;

	private static readonly System.IntPtr NativeFieldInfoPtr_faskPlaybackFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSkipTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_predefinedReplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveReplayFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_replay;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_prevState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastSavedReplayFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_timeStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bigStyle;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_replay_Public_get_VPReplay_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStateStr_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CenteredLabel_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplayKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordKey_Public_Void_RecordMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayPauseKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForwardKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RewindKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuitKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr));

	public unsafe bool enableShortcuts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableShortcuts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableShortcuts)) = flag;
		}
	}

	public unsafe KeyCode recordKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordKey)) = keyCode;
		}
	}

	public unsafe KeyCode playPauseKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playPauseKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playPauseKey)) = keyCode;
		}
	}

	public unsafe KeyCode forwardKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardKey)) = keyCode;
		}
	}

	public unsafe KeyCode rewindKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewindKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewindKey)) = keyCode;
		}
	}

	public unsafe KeyCode quitKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quitKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quitKey)) = keyCode;
		}
	}

	public unsafe KeyCode togglePanelKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_togglePanelKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_togglePanelKey)) = keyCode;
		}
	}

	public unsafe bool showPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showPanel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showPanel)) = flag;
		}
	}

	public unsafe bool autoShowHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShowHide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoShowHide)) = flag;
		}
	}

	public unsafe int faskPlaybackFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faskPlaybackFrames);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faskPlaybackFrames)) = num;
		}
	}

	public unsafe float fastSkipTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSkipTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSkipTime)) = num;
		}
	}

	public unsafe VPReplayAsset predefinedReplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_predefinedReplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPReplayAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_predefinedReplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string saveReplayFileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveReplayFileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveReplayFileName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector2 screenPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPosition)) = vector;
		}
	}

	public unsafe Font font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Font(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPReplay m_replay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_replay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPReplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_replay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPReplay.State m_prevState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevState);
			return *(VPReplay.State*)num;
		}
		set
		{
			*(VPReplay.State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_prevState)) = state;
		}
	}

	public unsafe string m_lastSavedReplayFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastSavedReplayFile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastSavedReplayFile), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe GUIStyle m_timeStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_timeStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_timeStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle m_bigStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPReplay replay
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_replay_Public_get_VPReplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new VPReplay(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112491, XrefRangeEnd = 112495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112495, XrefRangeEnd = 112548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112548, XrefRangeEnd = 113014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113014, XrefRangeEnd = 113028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetStateStr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStateStr_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113028, XrefRangeEnd = 113052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CenteredLabel(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CenteredLabel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113087, RefRangeEnd = 113088, XrefRangeStart = 113052, XrefRangeEnd = 113087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113088, XrefRangeEnd = 113089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplayKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplayKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 113090, RefRangeEnd = 113092, XrefRangeStart = 113089, XrefRangeEnd = 113090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordKey(VPReplay.RecordMode recordModeAtReplay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&recordModeAtReplay);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordKey_Public_Void_RecordMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113093, RefRangeEnd = 113094, XrefRangeStart = 113092, XrefRangeEnd = 113093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayPauseKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayPauseKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113094, XrefRangeEnd = 113097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForwardKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForwardKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113097, XrefRangeEnd = 113100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewindKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RewindKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113100, XrefRangeEnd = 113106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QuitKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuitKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113106, XrefRangeEnd = 113118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPReplayController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPReplayController()
	{
		Il2CppClassPointerStore<VPReplayController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPReplayController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr);
		NativeFieldInfoPtr_enableShortcuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "enableShortcuts");
		NativeFieldInfoPtr_recordKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "recordKey");
		NativeFieldInfoPtr_playPauseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "playPauseKey");
		NativeFieldInfoPtr_forwardKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "forwardKey");
		NativeFieldInfoPtr_rewindKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "rewindKey");
		NativeFieldInfoPtr_quitKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "quitKey");
		NativeFieldInfoPtr_togglePanelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "togglePanelKey");
		NativeFieldInfoPtr_showPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "showPanel");
		NativeFieldInfoPtr_autoShowHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "autoShowHide");
		NativeFieldInfoPtr_faskPlaybackFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "faskPlaybackFrames");
		NativeFieldInfoPtr_fastSkipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "fastSkipTime");
		NativeFieldInfoPtr_predefinedReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "predefinedReplay");
		NativeFieldInfoPtr_saveReplayFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "saveReplayFileName");
		NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "screenPosition");
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "font");
		NativeFieldInfoPtr_m_replay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "m_replay");
		NativeFieldInfoPtr_m_prevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "m_prevState");
		NativeFieldInfoPtr_m_lastSavedReplayFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "m_lastSavedReplayFile");
		NativeFieldInfoPtr_m_timeStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "m_timeStyle");
		NativeFieldInfoPtr_m_bigStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, "m_bigStyle");
		NativeMethodInfoPtr_get_replay_Public_get_VPReplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670425);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670426);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670427);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670428);
		NativeMethodInfoPtr_GetStateStr_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670429);
		NativeMethodInfoPtr_CenteredLabel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670430);
		NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670431);
		NativeMethodInfoPtr_ReplayKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670432);
		NativeMethodInfoPtr_RecordKey_Public_Void_RecordMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670433);
		NativeMethodInfoPtr_PlayPauseKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670434);
		NativeMethodInfoPtr_ForwardKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670435);
		NativeMethodInfoPtr_RewindKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670436);
		NativeMethodInfoPtr_QuitKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670437);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplayController>.NativeClassPtr, 100670438);
	}

	public VPReplayController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
