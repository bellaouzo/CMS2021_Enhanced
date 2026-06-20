using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPReplay : VehicleBehaviour
{
	public enum PlaybackMode
	{
		InputAndPose,
		InputOnly,
		PoseOnly,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PlaybackMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static PlaybackMode()
		{
			Il2CppClassPointerStore<PlaybackMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "PlaybackMode");
		}

	}

	public enum EndOfPlayback
	{
		Quit,
		Record,
		Pause,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EndOfPlayback>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static EndOfPlayback()
		{
			Il2CppClassPointerStore<EndOfPlayback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "EndOfPlayback");
		}

	}

	public enum OnEnableAction
	{
		None,
		PlayLoaded,
		RecordNew,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OnEnableAction>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static OnEnableAction()
		{
			Il2CppClassPointerStore<OnEnableAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "OnEnableAction");
		}

	}

	public enum State
	{
		Idle,
		Record,
		Playback,
		Paused,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<State>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "State");
		}

	}

	[System.Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Frame : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_inputData;

		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Frame>.NativeClassPtr));

		public unsafe Il2CppStructArray<int> inputData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector3 position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = vector;
			}
		}

		public unsafe Quaternion rotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = quaternion;
			}
		}

		static Frame()
		{
			Il2CppClassPointerStore<Frame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "Frame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Frame>.NativeClassPtr);
			NativeFieldInfoPtr_inputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Frame>.NativeClassPtr, "inputData");
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Frame>.NativeClassPtr, "position");
			NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Frame>.NativeClassPtr, "rotation");
		}

		public Frame(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe Frame()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Frame>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Frame>.NativeClassPtr))
		{
		}
	}

	public enum PlaybackDirection
	{
		Forward,
		Reverse,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PlaybackDirection>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static PlaybackDirection()
		{
			Il2CppClassPointerStore<PlaybackDirection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "PlaybackDirection");
		}

	}

	public enum RecordMode
	{
		New,
		Append,
		Restart,
		FromCurrentPos,
		PlayToEndThenAppend,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RecordMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static RecordMode()
		{
			Il2CppClassPointerStore<RecordMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "RecordMode");
		}

	}

	public enum PlayMode
	{
		FromBegin,
		FromEnd,
		FromCurrentPos,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PlayMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static PlayMode()
		{
			Il2CppClassPointerStore<PlayMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "PlayMode");
		}

	}

	public enum PauseMode
	{
		AtCurrentPos,
		AtBegin,
		AtEnd,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PauseMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static PauseMode()
		{
			Il2CppClassPointerStore<PauseMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "PauseMode");
		}

	}

	public enum QuitMode
	{
		AtCurrentPos,
		AtBegin,
		AtEnd,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<QuitMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static QuitMode()
		{
			Il2CppClassPointerStore<QuitMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "QuitMode");
		}

	}

	public enum TrimMode
	{
		FromBegin,
		ToEnd,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TrimMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static TrimMode()
		{
			Il2CppClassPointerStore<TrimMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "TrimMode");
		}

	}

	public enum VehicleMode
	{
		Normal,
		Playback,
		Paused,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VehicleMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static VehicleMode()
		{
			Il2CppClassPointerStore<VehicleMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "VehicleMode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_playbackMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_endOfPlayback;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoClearGroundMarks;

	private static readonly System.IntPtr NativeFieldInfoPtr_onEnableAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoLoadReplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_showGui;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_smallStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bigStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bigText;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_forceRecordOnEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_angularVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_recordedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_playbackDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_groundMarksRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_deviceInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_headMotions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_gearbox;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentFrame_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalFrames_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playbackDirection_Public_get_PlaybackDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playbackDirection_Public_set_Void_PlaybackDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Record_Public_Void_RecordMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_PlayMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_PauseMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Quit_Public_Void_QuitMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Jump_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_Void_TrimMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Drop_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveReplayToAsset_Public_VPReplayAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadReplayFromAsset_Public_Void_VPReplayAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveReplayToAssetFile_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadReplayFromAssetFile_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveReplayToFile_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadReplayFromFile_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadReplay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeToFrames_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FramesToTime_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatTime_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatFrames_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatTimeAndFrames_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginNewRecord_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueRecord_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContinueRecordFromReplay_Private_Void_RecordMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareNextFrame_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginPlayback_Private_Void_PlayMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginPlaybackInPause_Private_Void_PauseMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterPause_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuitReplay_Private_Void_QuitMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopReplay_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessInputHook_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessVisualUpdateHook_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVehicleMode_Private_Void_VehicleMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRigidbodyVelocity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreRigidbodyVelocity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RepositionRigidbody_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOtherBodiesVelocity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreOtherBodiesVelocity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiscardReplayFrom_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DiscardReplayTo_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordVehicleData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaybackVehicleData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaybackVehicleVelocity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaybackVisualUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInputEvent_Private_Void_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeAngularVelocity_Private_Vector3_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPReplay>.NativeClassPtr));

	public unsafe PlaybackMode playbackMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playbackMode);
			return *(PlaybackMode*)num;
		}
		set
		{
			*(PlaybackMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playbackMode)) = playbackMode;
		}
	}

	public unsafe EndOfPlayback endOfPlayback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endOfPlayback);
			return *(EndOfPlayback*)num;
		}
		set
		{
			*(EndOfPlayback*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endOfPlayback)) = endOfPlayback;
		}
	}

	public unsafe bool autoClearGroundMarks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClearGroundMarks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClearGroundMarks)) = flag;
		}
	}

	public unsafe OnEnableAction onEnableAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnableAction);
			return *(OnEnableAction*)num;
		}
		set
		{
			*(OnEnableAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnableAction)) = onEnableAction;
		}
	}

	public unsafe VPReplayAsset autoLoadReplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLoadReplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPReplayAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLoadReplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool showGui
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGui);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showGui)) = flag;
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

	public unsafe GUIStyle m_smallStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smallStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_smallStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe string m_text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string m_bigText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bigText), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe State m_state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state)) = state;
		}
	}

	public unsafe bool m_forceRecordOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_forceRecordOnEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_forceRecordOnEnd)) = flag;
		}
	}

	public unsafe Vector3 m_velocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_velocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_velocity)) = vector;
		}
	}

	public unsafe Vector3 m_angularVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angularVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_angularVelocity)) = vector;
		}
	}

	public unsafe Il2CppStructArray<int> m_currentInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_currentPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentPosition)) = vector;
		}
	}

	public unsafe Quaternion m_currentRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentRotation)) = quaternion;
		}
	}

	public unsafe List<Frame> m_recordedData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_recordedData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Frame>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_recordedData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_currentFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentFrame)) = num;
		}
	}

	public unsafe PlaybackDirection m_playbackDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_playbackDirection);
			return *(PlaybackDirection*)num;
		}
		set
		{
			*(PlaybackDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_playbackDirection)) = playbackDirection;
		}
	}

	public unsafe Il2CppReferenceArray<VPGroundMarksRenderer> m_groundMarksRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_groundMarksRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<VPGroundMarksRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_groundMarksRenderers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPDeviceInput m_deviceInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_deviceInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPDeviceInput(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_deviceInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<VPHeadMotion> m_headMotions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_headMotions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<VPHeadMotion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_headMotions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Gearbox m_gearbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gearbox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Gearbox(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_gearbox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe State state
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(State*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int currentFrame
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentFrame_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int totalFrames
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111805, RefRangeEnd = 111809, XrefRangeStart = 111804, XrefRangeEnd = 111805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalFrames_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe PlaybackDirection playbackDirection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playbackDirection_Public_get_PlaybackDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(PlaybackDirection*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 111813, RefRangeEnd = 111819, XrefRangeStart = 111809, XrefRangeEnd = 111813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playbackDirection_Public_set_Void_PlaybackDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111819, XrefRangeEnd = 111826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111826, XrefRangeEnd = 111827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111827, XrefRangeEnd = 111875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111875, XrefRangeEnd = 111894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111894, XrefRangeEnd = 111969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111969, XrefRangeEnd = 111982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 111984, RefRangeEnd = 111991, XrefRangeStart = 111982, XrefRangeEnd = 111984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Record([Optional] RecordMode recordMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&recordMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Record_Public_Void_RecordMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111991, XrefRangeEnd = 111992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play([Optional] PlayMode playMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111992, XrefRangeEnd = 111997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause([Optional] PauseMode pauseMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pauseMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_PauseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111999, RefRangeEnd = 112001, XrefRangeStart = 111997, XrefRangeEnd = 111999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Quit([Optional] QuitMode quitMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quitMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Quit_Public_Void_QuitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 112009, RefRangeEnd = 112025, XrefRangeStart = 112001, XrefRangeEnd = 112009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Jump(int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frame);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Jump_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112025, XrefRangeEnd = 112026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Skip(int frames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Skip_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112028, RefRangeEnd = 112030, XrefRangeStart = 112026, XrefRangeEnd = 112028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Trim(TrimMode trimMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&trimMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_Void_TrimMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112030, XrefRangeEnd = 112032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Drop(int dropFrames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dropFrames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Drop_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112052, RefRangeEnd = 112053, XrefRangeStart = 112032, XrefRangeEnd = 112052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPReplayAsset SaveReplayToAsset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveReplayToAsset_Public_VPReplayAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new VPReplayAsset(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 112076, RefRangeEnd = 112079, XrefRangeStart = 112053, XrefRangeEnd = 112076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadReplayFromAsset(VPReplayAsset replayAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(replayAsset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadReplayFromAsset_Public_Void_VPReplayAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SaveReplayToAssetFile(string assetFileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assetFileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveReplayToAssetFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void LoadReplayFromAssetFile(string assetFileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assetFileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadReplayFromAssetFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112079, XrefRangeEnd = 112082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveReplayToFile(string fileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveReplayToFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112082, XrefRangeEnd = 112087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadReplayFromFile(string fileName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadReplayFromFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112087, XrefRangeEnd = 112097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadReplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadReplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112099, RefRangeEnd = 112101, XrefRangeStart = 112097, XrefRangeEnd = 112099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TimeToFrames(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeToFrames_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112101, XrefRangeEnd = 112103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FramesToTime(int frames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FramesToTime_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112124, RefRangeEnd = 112125, XrefRangeStart = 112103, XrefRangeEnd = 112124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatTime(int frames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatTime_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112125, XrefRangeEnd = 112134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatFrames(int frames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatFrames_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112152, RefRangeEnd = 112154, XrefRangeStart = 112134, XrefRangeEnd = 112152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatTimeAndFrames(int frames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatTimeAndFrames_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112154, XrefRangeEnd = 112161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginNewRecord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginNewRecord_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112161, XrefRangeEnd = 112162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueRecord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueRecord_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112180, RefRangeEnd = 112181, XrefRangeStart = 112162, XrefRangeEnd = 112180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ContinueRecordFromReplay(RecordMode recordMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&recordMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContinueRecordFromReplay_Private_Void_RecordMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112181, XrefRangeEnd = 112182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareNextFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareNextFrame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 112192, RefRangeEnd = 112196, XrefRangeStart = 112182, XrefRangeEnd = 112192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginPlayback(PlayMode playMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginPlayback_Private_Void_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112196, XrefRangeEnd = 112204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginPlaybackInPause(PauseMode pauseMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pauseMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginPlaybackInPause_Private_Void_PauseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112204, XrefRangeEnd = 112206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112212, RefRangeEnd = 112213, XrefRangeStart = 112206, XrefRangeEnd = 112212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QuitReplay(QuitMode quitMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quitMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuitReplay_Private_Void_QuitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112213, XrefRangeEnd = 112214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopReplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopReplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112214, XrefRangeEnd = 112215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessInputHook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessInputHook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112215, XrefRangeEnd = 112216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessVisualUpdateHook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessVisualUpdateHook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 112235, RefRangeEnd = 112258, XrefRangeStart = 112216, XrefRangeEnd = 112235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVehicleMode(VehicleMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVehicleMode_Private_Void_VehicleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112258, XrefRangeEnd = 112262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveRigidbodyVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRigidbodyVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 112271, RefRangeEnd = 112288, XrefRangeStart = 112262, XrefRangeEnd = 112271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreRigidbodyVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreRigidbodyVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 112305, RefRangeEnd = 112321, XrefRangeStart = 112288, XrefRangeEnd = 112305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RepositionRigidbody(bool allowClearMarks = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&allowClearMarks);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RepositionRigidbody_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 112345, RefRangeEnd = 112353, XrefRangeStart = 112321, XrefRangeEnd = 112345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOtherBodiesVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveOtherBodiesVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 112381, RefRangeEnd = 112392, XrefRangeStart = 112353, XrefRangeEnd = 112381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreOtherBodiesVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreOtherBodiesVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112395, RefRangeEnd = 112397, XrefRangeStart = 112392, XrefRangeEnd = 112395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DiscardReplayFrom(int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frame);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscardReplayFrom_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 112406, RefRangeEnd = 112409, XrefRangeStart = 112397, XrefRangeEnd = 112406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DiscardReplayTo(int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frame);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DiscardReplayTo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112420, RefRangeEnd = 112421, XrefRangeStart = 112409, XrefRangeEnd = 112420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordVehicleData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordVehicleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112421, XrefRangeEnd = 112426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaybackVehicleData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaybackVehicleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112426, XrefRangeEnd = 112427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaybackVehicleVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaybackVehicleVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112443, RefRangeEnd = 112444, XrefRangeStart = 112427, XrefRangeEnd = 112443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaybackVisualUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaybackVisualUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112444, RefRangeEnd = 112445, XrefRangeStart = 112444, XrefRangeEnd = 112444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyInputEvent(Il2CppStructArray<int> eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyInputEvent_Private_Void_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 112448, RefRangeEnd = 112451, XrefRangeStart = 112445, XrefRangeEnd = 112448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ComputeAngularVelocity(Quaternion q0, Quaternion q1, float dt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&q0);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &q1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeAngularVelocity_Private_Vector3_Quaternion_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112465, RefRangeEnd = 112467, XrefRangeStart = 112451, XrefRangeEnd = 112465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112467, XrefRangeEnd = 112490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPReplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPReplay>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPReplay()
	{
		Il2CppClassPointerStore<VPReplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPReplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPReplay>.NativeClassPtr);
		NativeFieldInfoPtr_playbackMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "playbackMode");
		NativeFieldInfoPtr_endOfPlayback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "endOfPlayback");
		NativeFieldInfoPtr_autoClearGroundMarks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "autoClearGroundMarks");
		NativeFieldInfoPtr_onEnableAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "onEnableAction");
		NativeFieldInfoPtr_autoLoadReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "autoLoadReplay");
		NativeFieldInfoPtr_showGui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "showGui");
		NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "screenPosition");
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "font");
		NativeFieldInfoPtr_m_smallStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_smallStyle");
		NativeFieldInfoPtr_m_bigStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_bigStyle");
		NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_text");
		NativeFieldInfoPtr_m_bigText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_bigText");
		NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_state");
		NativeFieldInfoPtr_m_forceRecordOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_forceRecordOnEnd");
		NativeFieldInfoPtr_m_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_velocity");
		NativeFieldInfoPtr_m_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_angularVelocity");
		NativeFieldInfoPtr_m_currentInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_currentInput");
		NativeFieldInfoPtr_m_currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_currentPosition");
		NativeFieldInfoPtr_m_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_currentRotation");
		NativeFieldInfoPtr_m_recordedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_recordedData");
		NativeFieldInfoPtr_m_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_currentFrame");
		NativeFieldInfoPtr_m_playbackDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_playbackDirection");
		NativeFieldInfoPtr_m_groundMarksRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_groundMarksRenderers");
		NativeFieldInfoPtr_m_deviceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_deviceInput");
		NativeFieldInfoPtr_m_headMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_headMotions");
		NativeFieldInfoPtr_m_gearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, "m_gearbox");
		NativeMethodInfoPtr_get_state_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670366);
		NativeMethodInfoPtr_get_currentFrame_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670367);
		NativeMethodInfoPtr_get_totalFrames_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670368);
		NativeMethodInfoPtr_get_playbackDirection_Public_get_PlaybackDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670369);
		NativeMethodInfoPtr_set_playbackDirection_Public_set_Void_PlaybackDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670370);
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670371);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670372);
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670373);
		NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670374);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670375);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670376);
		NativeMethodInfoPtr_Record_Public_Void_RecordMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670377);
		NativeMethodInfoPtr_Play_Public_Void_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670378);
		NativeMethodInfoPtr_Pause_Public_Void_PauseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670379);
		NativeMethodInfoPtr_Quit_Public_Void_QuitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670380);
		NativeMethodInfoPtr_Jump_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670381);
		NativeMethodInfoPtr_Skip_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670382);
		NativeMethodInfoPtr_Trim_Public_Void_TrimMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670383);
		NativeMethodInfoPtr_Drop_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670384);
		NativeMethodInfoPtr_SaveReplayToAsset_Public_VPReplayAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670385);
		NativeMethodInfoPtr_LoadReplayFromAsset_Public_Void_VPReplayAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670386);
		NativeMethodInfoPtr_SaveReplayToAssetFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670387);
		NativeMethodInfoPtr_LoadReplayFromAssetFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670388);
		NativeMethodInfoPtr_SaveReplayToFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670389);
		NativeMethodInfoPtr_LoadReplayFromFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670390);
		NativeMethodInfoPtr_UnloadReplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670391);
		NativeMethodInfoPtr_TimeToFrames_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670392);
		NativeMethodInfoPtr_FramesToTime_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670393);
		NativeMethodInfoPtr_FormatTime_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670394);
		NativeMethodInfoPtr_FormatFrames_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670395);
		NativeMethodInfoPtr_FormatTimeAndFrames_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670396);
		NativeMethodInfoPtr_BeginNewRecord_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670397);
		NativeMethodInfoPtr_ContinueRecord_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670398);
		NativeMethodInfoPtr_ContinueRecordFromReplay_Private_Void_RecordMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670399);
		NativeMethodInfoPtr_PrepareNextFrame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670400);
		NativeMethodInfoPtr_BeginPlayback_Private_Void_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670401);
		NativeMethodInfoPtr_BeginPlaybackInPause_Private_Void_PauseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670402);
		NativeMethodInfoPtr_EnterPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670403);
		NativeMethodInfoPtr_QuitReplay_Private_Void_QuitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670404);
		NativeMethodInfoPtr_StopReplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670405);
		NativeMethodInfoPtr_ProcessInputHook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670406);
		NativeMethodInfoPtr_ProcessVisualUpdateHook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670407);
		NativeMethodInfoPtr_SetVehicleMode_Private_Void_VehicleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670408);
		NativeMethodInfoPtr_SaveRigidbodyVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670409);
		NativeMethodInfoPtr_RestoreRigidbodyVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670410);
		NativeMethodInfoPtr_RepositionRigidbody_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670411);
		NativeMethodInfoPtr_RemoveOtherBodiesVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670412);
		NativeMethodInfoPtr_RestoreOtherBodiesVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670413);
		NativeMethodInfoPtr_DiscardReplayFrom_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670414);
		NativeMethodInfoPtr_DiscardReplayTo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670415);
		NativeMethodInfoPtr_RecordVehicleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670416);
		NativeMethodInfoPtr_PlaybackVehicleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670417);
		NativeMethodInfoPtr_PlaybackVehicleVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670418);
		NativeMethodInfoPtr_PlaybackVisualUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670419);
		NativeMethodInfoPtr_ApplyInputEvent_Private_Void_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670420);
		NativeMethodInfoPtr_ComputeAngularVelocity_Private_Vector3_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670421);
		NativeMethodInfoPtr_UpdateTextProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670422);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPReplay>.NativeClassPtr, 100670423);
	}

	public VPReplay(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
