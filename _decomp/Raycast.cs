using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Raycast : MonoBehaviour
{
	[ObfuscatedName("Raycast/<Init>d__34")]
	public sealed class _Init_d__34 : Il2CppSystem.Object
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
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr));

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

		public unsafe Raycast __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Raycast(intPtr) : null;
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
		public unsafe _Init_d__34(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80563, XrefRangeEnd = 80647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80647, XrefRangeEnd = 80652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Init_d__34()
		{
			Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "<Init>d__34");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, 100667983);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, 100667984);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, 100667985);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, 100667986);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, 100667987);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__34>.NativeClassPtr, 100667988);
		}

		public _Init_d__34(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONST_IO_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageRaycastLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONST_SPHARECAST_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONST_SPHARECAST_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ray;

	private static readonly System.IntPtr NativeFieldInfoPtr_hit;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageRaycastMaskTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageAssembleRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_bonusAssembleRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_interiorDisassembleRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_carColliderMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_examineGarageRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_examineRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_partSelectRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_partSelectMountRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_mountObjectsRaycastMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_pS;

	private static readonly System.IntPtr NativeFieldInfoPtr_iO;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevIO;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevMO;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenFader;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameScript;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursor3D;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameModeManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_ready;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevCarLoader;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Garage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExamineGarage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InteriorDisassemble_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InteriorAssemble_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GarageAssemble_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PartSelect_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrainTool_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExamineCondition_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PartSelectMount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PartUnMountPartMount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsOtherCarLoader_Private_Boolean_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BonusDisassemble_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BonusAssemble_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPrevIO_Private_Void_InteractiveObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPrevIO_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Raycast>.NativeClassPtr));

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

	public unsafe static float CONST_IO_DISTANCE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONST_IO_DISTANCE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONST_IO_DISTANCE, &num);
		}
	}

	public unsafe static float garageRaycastLength
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_garageRaycastLength, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_garageRaycastLength, &num);
		}
	}

	public unsafe static float CONST_SPHARECAST_SIZE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONST_SPHARECAST_SIZE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONST_SPHARECAST_SIZE, &num);
		}
	}

	public unsafe static float CONST_SPHARECAST_DISTANCE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONST_SPHARECAST_DISTANCE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONST_SPHARECAST_DISTANCE, &num);
		}
	}

	public unsafe Ray ray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ray);
			return *(Ray*)num;
		}
		set
		{
			*(Ray*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ray)) = ray;
		}
	}

	public unsafe RaycastHit hit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hit);
			return *(RaycastHit*)num;
		}
		set
		{
			*(RaycastHit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hit)) = raycastHit;
		}
	}

	public unsafe Transform prevTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LayerMask garageRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask garageRaycastMaskTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageRaycastMaskTutorial);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageRaycastMaskTutorial)) = layerMask;
		}
	}

	public unsafe LayerMask garageAssembleRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageAssembleRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageAssembleRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask bonusAssembleRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusAssembleRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusAssembleRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask interiorDisassembleRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorDisassembleRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorDisassembleRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask carColliderMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carColliderMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carColliderMask)) = layerMask;
		}
	}

	public unsafe LayerMask examineGarageRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_examineGarageRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_examineGarageRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask examineRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_examineRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_examineRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask partSelectRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partSelectRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partSelectRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask partSelectMountRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partSelectMountRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partSelectMountRaycastMask)) = layerMask;
		}
	}

	public unsafe LayerMask mountObjectsRaycastMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountObjectsRaycastMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountObjectsRaycastMask)) = layerMask;
		}
	}

	public unsafe PartScript pS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pS), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InteractiveObject iO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InteractiveObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iO), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InteractiveObject prevIO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevIO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InteractiveObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevIO), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MountObject PrevMO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrevMO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MountObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrevMO), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScreenFader screenFader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenFader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScreenFader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenFader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameScript gameScript
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameScript);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameScript(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameScript), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIManager uiManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Cursor3D cursor3D
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursor3D);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Cursor3D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursor3D), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameMode gameModeManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameModeManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameMode(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameModeManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundManager soundManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SoundManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameInventory gameInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameInventory(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputManager inputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTutorial)) = flag;
		}
	}

	public unsafe bool ready
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ready);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ready)) = flag;
		}
	}

	public unsafe CarLoader prevCarLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevCarLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevCarLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80652, XrefRangeEnd = 80656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80656, XrefRangeEnd = 80659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80659, XrefRangeEnd = 80664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80664, XrefRangeEnd = 80697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Garage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Garage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80697, XrefRangeEnd = 80805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExamineGarage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExamineGarage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80805, XrefRangeEnd = 80892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InteriorDisassemble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InteriorDisassemble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80892, XrefRangeEnd = 80970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InteriorAssemble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InteriorAssemble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80970, XrefRangeEnd = 80991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GarageAssemble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GarageAssemble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80991, XrefRangeEnd = 81002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PartSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PartSelect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81002, XrefRangeEnd = 81014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrainTool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrainTool_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81014, XrefRangeEnd = 81023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExamineCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExamineCondition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81023, XrefRangeEnd = 81035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PartSelectMount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PartSelectMount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81035, XrefRangeEnd = 81138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PartUnMountPartMount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PartUnMountPartMount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81138, XrefRangeEnd = 81183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIsOtherCarLoader(CarLoader newCarLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newCarLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsOtherCarLoader_Private_Boolean_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81183, XrefRangeEnd = 81210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BonusDisassemble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BonusDisassemble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 81288, RefRangeEnd = 81289, XrefRangeStart = 81210, XrefRangeEnd = 81288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BonusAssemble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BonusAssemble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81289, XrefRangeEnd = 81290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 81313, RefRangeEnd = 81317, XrefRangeStart = 81290, XrefRangeEnd = 81313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPrevIO(InteractiveObject iO)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(iO);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPrevIO_Private_Void_InteractiveObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 81328, RefRangeEnd = 81337, XrefRangeStart = 81317, XrefRangeEnd = 81328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPrevIO()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPrevIO_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81337, XrefRangeEnd = 81340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Raycast()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Raycast>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Raycast()
	{
		Il2CppClassPointerStore<Raycast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Raycast");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Raycast>.NativeClassPtr);
		NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "mainCamera");
		NativeFieldInfoPtr_CONST_IO_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "CONST_IO_DISTANCE");
		NativeFieldInfoPtr_garageRaycastLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "garageRaycastLength");
		NativeFieldInfoPtr_CONST_SPHARECAST_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "CONST_SPHARECAST_SIZE");
		NativeFieldInfoPtr_CONST_SPHARECAST_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "CONST_SPHARECAST_DISTANCE");
		NativeFieldInfoPtr_ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "ray");
		NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "hit");
		NativeFieldInfoPtr_prevTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "prevTransform");
		NativeFieldInfoPtr_garageRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "garageRaycastMask");
		NativeFieldInfoPtr_garageRaycastMaskTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "garageRaycastMaskTutorial");
		NativeFieldInfoPtr_garageAssembleRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "garageAssembleRaycastMask");
		NativeFieldInfoPtr_bonusAssembleRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "bonusAssembleRaycastMask");
		NativeFieldInfoPtr_interiorDisassembleRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "interiorDisassembleRaycastMask");
		NativeFieldInfoPtr_carColliderMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "carColliderMask");
		NativeFieldInfoPtr_examineGarageRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "examineGarageRaycastMask");
		NativeFieldInfoPtr_examineRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "examineRaycastMask");
		NativeFieldInfoPtr_partSelectRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "partSelectRaycastMask");
		NativeFieldInfoPtr_partSelectMountRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "partSelectMountRaycastMask");
		NativeFieldInfoPtr_mountObjectsRaycastMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "mountObjectsRaycastMask");
		NativeFieldInfoPtr_pS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "pS");
		NativeFieldInfoPtr_iO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "iO");
		NativeFieldInfoPtr_prevIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "prevIO");
		NativeFieldInfoPtr_PrevMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "PrevMO");
		NativeFieldInfoPtr_screenFader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "screenFader");
		NativeFieldInfoPtr_gameScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "gameScript");
		NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "uiManager");
		NativeFieldInfoPtr_cursor3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "cursor3D");
		NativeFieldInfoPtr_gameModeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "gameModeManager");
		NativeFieldInfoPtr_soundManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "soundManager");
		NativeFieldInfoPtr_gameInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "gameInventory");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "inputManager");
		NativeFieldInfoPtr_isTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "isTutorial");
		NativeFieldInfoPtr_ready = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "ready");
		NativeFieldInfoPtr_prevCarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Raycast>.NativeClassPtr, "prevCarLoader");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667963);
		NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667964);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667965);
		NativeMethodInfoPtr_Garage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667966);
		NativeMethodInfoPtr_ExamineGarage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667967);
		NativeMethodInfoPtr_InteriorDisassemble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667968);
		NativeMethodInfoPtr_InteriorAssemble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667969);
		NativeMethodInfoPtr_GarageAssemble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667970);
		NativeMethodInfoPtr_PartSelect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667971);
		NativeMethodInfoPtr_DrainTool_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667972);
		NativeMethodInfoPtr_ExamineCondition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667973);
		NativeMethodInfoPtr_PartSelectMount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667974);
		NativeMethodInfoPtr_PartUnMountPartMount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667975);
		NativeMethodInfoPtr_CheckIsOtherCarLoader_Private_Boolean_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667976);
		NativeMethodInfoPtr_BonusDisassemble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667977);
		NativeMethodInfoPtr_BonusAssemble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667978);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667979);
		NativeMethodInfoPtr_SetPrevIO_Private_Void_InteractiveObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667980);
		NativeMethodInfoPtr_ResetPrevIO_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667981);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Raycast>.NativeClassPtr, 100667982);
	}

	public Raycast(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
