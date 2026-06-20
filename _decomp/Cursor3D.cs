using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class Cursor3D : MonoBehaviour
{
	[ObfuscatedName("Cursor3D/<RefreshCursorPosition>d__46")]
	public sealed class _RefreshCursorPosition_d__46 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Cursor3D __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Cursor3D(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _RefreshCursorPosition_d__46(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42911, XrefRangeEnd = 42920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42920, XrefRangeEnd = 42925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _RefreshCursorPosition_d__46()
		{
			Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "<RefreshCursorPosition>d__46");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, 100665905);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, 100665906);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, 100665907);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, 100665908);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, 100665909);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RefreshCursorPosition_d__46>.NativeClassPtr, 100665910);
		}

		public _RefreshCursorPosition_d__46(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_fillTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_NormalCursorSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICursorSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseBlockRangeXY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorTimerImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdID;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenCenterPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_snapPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCursorEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_canCountTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCursorHolden;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCursorBlocked;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUICursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHoldInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_isControllerUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_framesAmountAfterClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookSmoothSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookSmoothWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookAccelerationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseLookInvert;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseLookSmoothMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseLookSmoothBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastMouseLookFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentMouseLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFillSpeed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsButtonClick_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIsButtonHold_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCursor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetButton_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCountTime_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPos_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorIsEnable_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorEnabled_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHolden_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHold_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHoldID_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUICursor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockCursor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorSnap_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorOnPosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCursorPosition_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForConsoleMode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseMove_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseMove_Private_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeCount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveCursorToOtherTransform_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalCursorLock_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Cursor3D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr));

	public unsafe float fillTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fillTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fillTime)) = num;
		}
	}

	public unsafe float holdTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdTime)) = num;
		}
	}

	public unsafe Texture2D NormalCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalCursor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalCursor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Texture2D UICursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UICursor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UICursor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite NormalCursorSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalCursorSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalCursorSprite), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Sprite UICursorSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UICursorSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UICursorSprite), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2 mouseBlockRangeXY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseBlockRangeXY);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseBlockRangeXY)) = vector;
		}
	}

	public unsafe Transform cursorTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image cursorTimerImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTimerImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTimerImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image cursorImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int holdID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdID)) = num;
		}
	}

	public unsafe Vector2 screenCenterPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenCenterPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenCenterPosition)) = vector;
		}
	}

	public unsafe Camera mainCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2 lastPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPosition)) = vector;
		}
	}

	public unsafe Vector2 mouseMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseMove);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseMove)) = vector;
		}
	}

	public unsafe Vector3 snapPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snapPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snapPos)) = vector;
		}
	}

	public unsafe bool isCursorEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCursorEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCursorEnabled)) = flag;
		}
	}

	public unsafe bool cursorMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorMove)) = flag;
		}
	}

	public unsafe bool canCountTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canCountTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canCountTime)) = flag;
		}
	}

	public unsafe bool isCursorHolden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCursorHolden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCursorHolden)) = flag;
		}
	}

	public unsafe bool isCursorBlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCursorBlocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCursorBlocked)) = flag;
		}
	}

	public unsafe bool isUICursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUICursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUICursor)) = flag;
		}
	}

	public unsafe Vector2 cursorPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorPosition)) = vector;
		}
	}

	public unsafe bool isHoldInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHoldInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHoldInProgress)) = flag;
		}
	}

	public unsafe bool isControllerUsed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isControllerUsed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isControllerUsed)) = flag;
		}
	}

	public unsafe int framesAmountAfterClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_framesAmountAfterClick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_framesAmountAfterClick)) = num;
		}
	}

	public unsafe GameMode GameMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameMode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameMode(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameMode), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputManager InputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ProMouse ProMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProMouse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ProMouse(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProMouse), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2 MouseLookSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSensitivity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSensitivity)) = vector;
		}
	}

	public unsafe int MouseLookSmoothSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothSteps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothSteps)) = num;
		}
	}

	public unsafe float MouseLookSmoothWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookSmoothWeight)) = num;
		}
	}

	public unsafe bool MouseLookAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAcceleration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAcceleration)) = flag;
		}
	}

	public unsafe float MouseLookAccelerationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAccelerationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookAccelerationThreshold)) = num;
		}
	}

	public unsafe bool MouseLookInvert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookInvert);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseLookInvert)) = flag;
		}
	}

	public unsafe Vector2 m_MouseLookSmoothMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothMove);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothMove)) = vector;
		}
	}

	public unsafe List<Vector2> m_MouseLookSmoothBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector2>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLookSmoothBuffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_LastMouseLookFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastMouseLookFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastMouseLookFrame)) = num;
		}
	}

	public unsafe Vector2 m_CurrentMouseLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMouseLook);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentMouseLook)) = vector;
		}
	}

	public unsafe static Cursor3D instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Cursor3D(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe void SetFillSpeed(float newFillTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newFillTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFillSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42925, RefRangeEnd = 42926, XrefRangeStart = 42925, XrefRangeEnd = 42925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsButtonClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsButtonClick_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool GetIsButtonHold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIsButtonHold_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 42935, RefRangeEnd = 42975, XrefRangeStart = 42926, XrefRangeEnd = 42935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowCursor(bool show)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&show);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCursor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 42996, RefRangeEnd = 43018, XrefRangeStart = 42975, XrefRangeEnd = 42996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetButton(bool setCountTime = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setCountTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetButton_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCountTime(bool canCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&canCount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCountTime_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43018, XrefRangeEnd = 43020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetCursorPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPos_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43020, XrefRangeEnd = 43021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursorIsEnable(bool enable, bool setCursorOnPosition = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&enable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setCursorOnPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorIsEnable_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43025, RefRangeEnd = 43026, XrefRangeStart = 43021, XrefRangeEnd = 43025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursorEnabled(bool enable, bool setLastPosition = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&enable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setLastPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorEnabled_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Vector2 GetPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosition_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsHolden()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHolden_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetHold(bool hold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hold);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHold_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 43027, RefRangeEnd = 43033, XrefRangeStart = 43026, XrefRangeEnd = 43027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHoldID(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHoldID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 43039, RefRangeEnd = 43044, XrefRangeStart = 43033, XrefRangeEnd = 43039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUICursor(bool isUICursor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isUICursor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUICursor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 43051, RefRangeEnd = 43059, XrefRangeStart = 43044, XrefRangeEnd = 43051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlockCursor(bool block)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&block);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockCursor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCursorSnap(Vector3 pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorSnap_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 43066, RefRangeEnd = 43091, XrefRangeStart = 43059, XrefRangeEnd = 43066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursorOnPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorOnPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43094, RefRangeEnd = 43096, XrefRangeStart = 43091, XrefRangeEnd = 43094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RefreshCursorPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCursorPosition_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43096, XrefRangeEnd = 43103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForConsoleMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForConsoleMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43103, XrefRangeEnd = 43181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43181, XrefRangeEnd = 43201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43201, XrefRangeEnd = 43204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43204, XrefRangeEnd = 43211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MouseMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43211, XrefRangeEnd = 43260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetMouseMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseMove_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43271, RefRangeEnd = 43273, XrefRangeStart = 43261, XrefRangeEnd = 43271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43273, XrefRangeEnd = 43278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 NaNSafeVector2(Vector2 vector, Vector2 prevVector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vector);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prevVector;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43278, XrefRangeEnd = 43283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TimeCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43307, RefRangeEnd = 43308, XrefRangeStart = 43283, XrefRangeEnd = 43307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveCursorToOtherTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveCursorToOtherTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43308, XrefRangeEnd = 43316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NormalCursorLock(bool isLocked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isLocked);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalCursorLock_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43316, XrefRangeEnd = 43320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Cursor3D Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_Cursor3D_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Cursor3D(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43320, XrefRangeEnd = 43343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43343, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cursor3D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Cursor3D()
	{
		Il2CppClassPointerStore<Cursor3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Cursor3D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr);
		NativeFieldInfoPtr_fillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "fillTime");
		NativeFieldInfoPtr_holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "holdTime");
		NativeFieldInfoPtr_NormalCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "NormalCursor");
		NativeFieldInfoPtr_UICursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "UICursor");
		NativeFieldInfoPtr_NormalCursorSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "NormalCursorSprite");
		NativeFieldInfoPtr_UICursorSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "UICursorSprite");
		NativeFieldInfoPtr_mouseBlockRangeXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "mouseBlockRangeXY");
		NativeFieldInfoPtr_cursorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "cursorTransform");
		NativeFieldInfoPtr_cursorTimerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "cursorTimerImage");
		NativeFieldInfoPtr_cursorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "cursorImage");
		NativeFieldInfoPtr_holdID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "holdID");
		NativeFieldInfoPtr_screenCenterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "screenCenterPosition");
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "lastPosition");
		NativeFieldInfoPtr_mouseMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "mouseMove");
		NativeFieldInfoPtr_snapPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "snapPos");
		NativeFieldInfoPtr_isCursorEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "isCursorEnabled");
		NativeFieldInfoPtr_cursorMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "cursorMove");
		NativeFieldInfoPtr_canCountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "canCountTime");
		NativeFieldInfoPtr_isCursorHolden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "isCursorHolden");
		NativeFieldInfoPtr_isCursorBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "isCursorBlocked");
		NativeFieldInfoPtr_isUICursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "isUICursor");
		NativeFieldInfoPtr_cursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "cursorPosition");
		NativeFieldInfoPtr_isHoldInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "isHoldInProgress");
		NativeFieldInfoPtr_isControllerUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "isControllerUsed");
		NativeFieldInfoPtr_framesAmountAfterClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "framesAmountAfterClick");
		NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "GameMode");
		NativeFieldInfoPtr_InputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "InputManager");
		NativeFieldInfoPtr_ProMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "ProMouse");
		NativeFieldInfoPtr_MouseLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "MouseLookSensitivity");
		NativeFieldInfoPtr_MouseLookSmoothSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "MouseLookSmoothSteps");
		NativeFieldInfoPtr_MouseLookSmoothWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "MouseLookSmoothWeight");
		NativeFieldInfoPtr_MouseLookAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "MouseLookAcceleration");
		NativeFieldInfoPtr_MouseLookAccelerationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "MouseLookAccelerationThreshold");
		NativeFieldInfoPtr_MouseLookInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "MouseLookInvert");
		NativeFieldInfoPtr_m_MouseLookSmoothMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "m_MouseLookSmoothMove");
		NativeFieldInfoPtr_m_MouseLookSmoothBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "m_MouseLookSmoothBuffer");
		NativeFieldInfoPtr_m_LastMouseLookFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "m_LastMouseLookFrame");
		NativeFieldInfoPtr_m_CurrentMouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "m_CurrentMouseLook");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, "instance");
		NativeMethodInfoPtr_SetFillSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665872);
		NativeMethodInfoPtr_GetIsButtonClick_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665873);
		NativeMethodInfoPtr_GetIsButtonHold_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665874);
		NativeMethodInfoPtr_ShowCursor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665875);
		NativeMethodInfoPtr_ResetButton_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665876);
		NativeMethodInfoPtr_SetCountTime_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665877);
		NativeMethodInfoPtr_GetCursorPos_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665878);
		NativeMethodInfoPtr_SetCursorIsEnable_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665879);
		NativeMethodInfoPtr_SetCursorEnabled_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665880);
		NativeMethodInfoPtr_GetPosition_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665881);
		NativeMethodInfoPtr_IsHolden_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665882);
		NativeMethodInfoPtr_SetHold_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665883);
		NativeMethodInfoPtr_SetHoldID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665884);
		NativeMethodInfoPtr_SetUICursor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665885);
		NativeMethodInfoPtr_BlockCursor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665886);
		NativeMethodInfoPtr_SetCursorSnap_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665887);
		NativeMethodInfoPtr_SetCursorOnPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665888);
		NativeMethodInfoPtr_RefreshCursorPosition_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665889);
		NativeMethodInfoPtr_SetupForConsoleMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665890);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665891);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665892);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665893);
		NativeMethodInfoPtr_MouseMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665894);
		NativeMethodInfoPtr_GetMouseMove_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665895);
		NativeMethodInfoPtr_LoadData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665896);
		NativeMethodInfoPtr_NaNSafeVector2_Private_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665897);
		NativeMethodInfoPtr_TimeCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665898);
		NativeMethodInfoPtr_MoveCursorToOtherTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665899);
		NativeMethodInfoPtr_NormalCursorLock_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665900);
		NativeMethodInfoPtr_Get_Public_Static_Cursor3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665901);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665902);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor3D>.NativeClassPtr, 100665903);
	}

	public Cursor3D(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
