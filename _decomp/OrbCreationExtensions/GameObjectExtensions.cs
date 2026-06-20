using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class GameObjectExtensions : Il2CppSystem.Object
{
	[ObfuscatedName("OrbCreationExtensions.GameObjectExtensions/<SetUpLODLevelsWithLODSwitcherInBackground>d__32")]
	public sealed class _SetUpLODLevelsWithLODSwitcherInBackground_d__32 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_go;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr_removeSmallParts;

		private static readonly System.IntPtr NativeFieldInfoPtr_recalcNormals;

		private static readonly System.IntPtr NativeFieldInfoPtr_lodScreenSizes;

		private static readonly System.IntPtr NativeFieldInfoPtr__mesh_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__lodSwitcher_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr__mesh0_5__4;

		private static readonly System.IntPtr NativeFieldInfoPtr__lodMeshes_5__5;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__6;

		private static readonly System.IntPtr NativeFieldInfoPtr__lodInfo_5__7;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr));

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

		public unsafe GameObject go
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppStructArray<float> maxWeights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeights);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeights), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float removeSmallParts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeSmallParts);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeSmallParts)) = num;
			}
		}

		public unsafe bool recalcNormals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalcNormals);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalcNormals)) = flag;
			}
		}

		public unsafe Il2CppStructArray<float> lodScreenSizes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodScreenSizes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodScreenSizes), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Mesh _mesh_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mesh_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mesh_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe LODSwitcher _lodSwitcher_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodSwitcher_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new LODSwitcher(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodSwitcher_5__3), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Mesh _mesh0_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mesh0_5__4);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mesh0_5__4), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppReferenceArray<Mesh> _lodMeshes_5__5
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodMeshes_5__5);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodMeshes_5__5), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int _i_5__6
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__6);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__6)) = num;
			}
		}

		public unsafe Hashtable _lodInfo_5__7
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodInfo_5__7);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Hashtable(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodInfo_5__7), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _SetUpLODLevelsWithLODSwitcherInBackground_d__32(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230443, XrefRangeEnd = 230588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230588, XrefRangeEnd = 230593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _SetUpLODLevelsWithLODSwitcherInBackground_d__32()
		{
			Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, "<SetUpLODLevelsWithLODSwitcherInBackground>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "go");
			NativeFieldInfoPtr_maxWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "maxWeights");
			NativeFieldInfoPtr_removeSmallParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "removeSmallParts");
			NativeFieldInfoPtr_recalcNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "recalcNormals");
			NativeFieldInfoPtr_lodScreenSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "lodScreenSizes");
			NativeFieldInfoPtr__mesh_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<mesh>5__2");
			NativeFieldInfoPtr__lodSwitcher_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<lodSwitcher>5__3");
			NativeFieldInfoPtr__mesh0_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<mesh0>5__4");
			NativeFieldInfoPtr__lodMeshes_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<lodMeshes>5__5");
			NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<i>5__6");
			NativeFieldInfoPtr__lodInfo_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, "<lodInfo>5__7");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, 100680815);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, 100680816);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, 100680817);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, 100680818);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, 100680819);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SetUpLODLevelsWithLODSwitcherInBackground_d__32>.NativeClassPtr, 100680820);
		}

		public _SetUpLODLevelsWithLODSwitcherInBackground_d__32(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("OrbCreationExtensions.GameObjectExtensions/<GetSimplifiedMeshInBackground>d__36")]
	public sealed class _GetSimplifiedMeshInBackground_d__36 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_go;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxWeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_removeSmallParts;

		private static readonly System.IntPtr NativeFieldInfoPtr_result;

		private static readonly System.IntPtr NativeFieldInfoPtr_recalcNormals;

		private static readonly System.IntPtr NativeFieldInfoPtr__lodInfo_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr));

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

		public unsafe GameObject go
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float maxWeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWeight)) = num;
			}
		}

		public unsafe float removeSmallParts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeSmallParts);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeSmallParts)) = num;
			}
		}

		public unsafe Il2CppSystem.Action<Mesh> result
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe bool recalcNormals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalcNormals);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalcNormals)) = flag;
			}
		}

		public unsafe Hashtable _lodInfo_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodInfo_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Hashtable(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lodInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _GetSimplifiedMeshInBackground_d__36(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230593, XrefRangeEnd = 230812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230812, XrefRangeEnd = 230817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _GetSimplifiedMeshInBackground_d__36()
		{
			Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, "<GetSimplifiedMeshInBackground>d__36");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "go");
			NativeFieldInfoPtr_maxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "maxWeight");
			NativeFieldInfoPtr_removeSmallParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "removeSmallParts");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "result");
			NativeFieldInfoPtr_recalcNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "recalcNormals");
			NativeFieldInfoPtr__lodInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, "<lodInfo>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, 100680821);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, 100680822);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, 100680823);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, 100680824);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, 100680825);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetSimplifiedMeshInBackground_d__36>.NativeClassPtr, 100680826);
		}

		public _GetSimplifiedMeshInBackground_d__36(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetFirstComponentInParents_Public_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetFirstComponentInParents_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetFirstComponentInChildren_Public_Static_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetFirstComponentInChildren_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldBounds_Public_Static_Bounds_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundsCorners_Public_Static_ArrayOf_Vector3_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundsCenterAndCorners_Public_Static_ArrayOf_Vector3_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldBoundsCorners_Public_Static_ArrayOf_Vector3_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldBoundsCenterAndCorners_Public_Static_ArrayOf_Vector3_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetModelComplexity_Public_Static_Single_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetModelInfoString_Public_Static_String_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TopParent_Public_Static_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindParentWithName_Public_Static_GameObject_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMutualParent_Public_Static_GameObject_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstChildWithName_Public_Static_GameObject_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChildWithNameUnique_Public_Static_Boolean_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountChildrenWithName_Public_Static_Void_GameObject_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObjectNamed_Public_Static_GameObject_GameObject_String_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstComponentInParents_Public_Static_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstComponentInChildren_Public_Static_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshes_Public_Static_ArrayOf_Mesh_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshes_Public_Static_ArrayOf_Mesh_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalVertexCount_Public_Static_Int32_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get1stSharedMesh_Public_Static_Mesh_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterials_Public_Static_ArrayOf_Material_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_ArrayOf_Mesh_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveUniqueNameIfNeeded_Private_Static_Int32_GameObject_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_ArrayOf_Single_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevelsWithLODSwitcher_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevelsWithLODSwitcherInBackground_Public_Static_IEnumerator_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevelsAndChildrenWithLODSwitcher_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpLODLevelsAndChildrenWithLODGroup_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSimplifiedMesh_Public_Static_Mesh_GameObject_Single_Boolean_Single_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSimplifiedMeshInBackground_Public_Static_IEnumerator_GameObject_Single_Boolean_Single_Action_1_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeMeshInto_Private_Static_Boolean_Mesh_ArrayOf_Transform_ArrayOf_Material_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_Transform_List_1_Matrix4x4_Dictionary_2_Material_List_1_Int32_Boolean_Vector4_Transform_Transform_String_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBindPose_Private_Static_Vector3_Vector3_Transform_Matrix4x4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnApplyBindPose_Private_Static_Vector3_Vector3_Transform_Matrix4x4_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr));

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 230848, RefRangeEnd = 230899, XrefRangeStart = 230817, XrefRangeEnd = 230848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds GetWorldBounds(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldBounds_Public_Static_Bounds_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230902, RefRangeEnd = 230903, XrefRangeStart = 230899, XrefRangeEnd = 230902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetBoundsCorners(this Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoundsCorners_Public_Static_ArrayOf_Vector3_Bounds_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230906, RefRangeEnd = 230907, XrefRangeStart = 230903, XrefRangeEnd = 230906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetBoundsCenterAndCorners(this Bounds bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bounds);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoundsCenterAndCorners_Public_Static_ArrayOf_Vector3_Bounds_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230907, XrefRangeEnd = 230909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetWorldBoundsCorners(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldBoundsCorners_Public_Static_ArrayOf_Vector3_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230909, XrefRangeEnd = 230911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetWorldBoundsCenterAndCorners(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldBoundsCenterAndCorners_Public_Static_ArrayOf_Vector3_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230911, XrefRangeEnd = 230920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetModelComplexity(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetModelComplexity_Public_Static_Single_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230920, XrefRangeEnd = 230965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetModelInfoString(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetModelInfoString_Public_Static_String_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230984, RefRangeEnd = 230985, XrefRangeStart = 230965, XrefRangeEnd = 230984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject TopParent(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TopParent_Public_Static_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231005, RefRangeEnd = 231006, XrefRangeStart = 230985, XrefRangeEnd = 231005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindParentWithName(this GameObject go, string parentName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parentName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindParentWithName_Public_Static_GameObject_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231080, RefRangeEnd = 231081, XrefRangeStart = 231006, XrefRangeEnd = 231080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindMutualParent(this GameObject go1, GameObject go2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(go2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMutualParent_Public_Static_GameObject_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231081, XrefRangeEnd = 231090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindFirstChildWithName(this GameObject go, string childName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(childName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstChildWithName_Public_Static_GameObject_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231090, XrefRangeEnd = 231091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsChildWithNameUnique(this GameObject go, string childName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(childName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChildWithNameUnique_Public_Static_Boolean_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231117, RefRangeEnd = 231120, XrefRangeStart = 231091, XrefRangeEnd = 231117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CountChildrenWithName(this GameObject go, string childName, ref int total)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(childName);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref total);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountChildrenWithName_Public_Static_Void_GameObject_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231120, XrefRangeEnd = 231128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetGameObjectNamed(this GameObject go, string aStr, GameObject parentGO)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(aStr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parentGO);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameObjectNamed_Public_Static_GameObject_GameObject_String_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231128, XrefRangeEnd = 231172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyChildren(this GameObject go, bool disabledOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &disabledOnly;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231172, XrefRangeEnd = 231184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetFirstComponentInParents<T>(this GameObject go) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetFirstComponentInParents_Public_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe static T GetFirstComponentInChildren<T>(this GameObject go) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetFirstComponentInChildren_Public_Static_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231184, XrefRangeEnd = 231185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> GetMeshes(this GameObject aGo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshes_Public_Static_ArrayOf_Mesh_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 231208, RefRangeEnd = 231210, XrefRangeStart = 231185, XrefRangeEnd = 231208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> GetMeshes(this GameObject aGo, bool includeDisabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDisabled;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshes_Public_Static_ArrayOf_Mesh_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231210, XrefRangeEnd = 231247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTotalVertexCount(this GameObject aGo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalVertexCount_Public_Static_Int32_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231247, XrefRangeEnd = 231267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh Get1stSharedMesh(this GameObject aGo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get1stSharedMesh_Public_Static_Mesh_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231267, XrefRangeEnd = 231268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMeshes(this GameObject aGo, Il2CppReferenceArray<Mesh> meshes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(meshes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231268, XrefRangeEnd = 231269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMeshes(this GameObject aGo, Il2CppReferenceArray<Mesh> meshes, int lodLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(meshes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lodLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231378, RefRangeEnd = 231381, XrefRangeStart = 231269, XrefRangeEnd = 231378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMeshes(this GameObject aGo, Il2CppReferenceArray<Mesh> meshes, bool includeDisabled, int lodLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(meshes);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDisabled;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lodLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231381, XrefRangeEnd = 231407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Material> GetMaterials(this GameObject aGo, bool includeDisabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDisabled;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterials_Public_Static_ArrayOf_Material_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231407, XrefRangeEnd = 231411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> CombineMeshes(this GameObject aGO)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGO);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_ArrayOf_Mesh_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231944, RefRangeEnd = 231945, XrefRangeStart = 231411, XrefRangeEnd = 231944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> CombineMeshes(this GameObject aGO, Il2CppStringArray skipSubmeshNames)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGO);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(skipSubmeshNames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231945, XrefRangeEnd = 231954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GiveUniqueNameIfNeeded(GameObject aGo, GameObject topGO, int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aGo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(topGO);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveUniqueNameIfNeeded_Private_Static_Int32_GameObject_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231954, XrefRangeEnd = 231955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUpLODLevels(this GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231970, RefRangeEnd = 231971, XrefRangeStart = 231955, XrefRangeEnd = 231970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUpLODLevels(this GameObject go, float maxWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231971, XrefRangeEnd = 231978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUpLODLevels(this GameObject go, Il2CppStructArray<float> lodScreenSizes, Il2CppStructArray<float> maxWeights)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(lodScreenSizes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxWeights);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_ArrayOf_Single_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232065, RefRangeEnd = 232067, XrefRangeStart = 231978, XrefRangeEnd = 232065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> SetUpLODLevelsWithLODSwitcher(this GameObject go, Il2CppStructArray<float> lodScreenSizes, Il2CppStructArray<float> maxWeights, bool recalcNormals, [Optional] float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst, [Optional] int nrOfSteps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(lodScreenSizes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxWeights);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &nrOfSteps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevelsWithLODSwitcher_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232067, XrefRangeEnd = 232070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator SetUpLODLevelsWithLODSwitcherInBackground(this GameObject go, Il2CppStructArray<float> lodScreenSizes, Il2CppStructArray<float> maxWeights, bool recalcNormals, [Optional] float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(lodScreenSizes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxWeights);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevelsWithLODSwitcherInBackground_Public_Static_IEnumerator_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232070, XrefRangeEnd = 232278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> SetUpLODLevelsAndChildrenWithLODSwitcher(this GameObject go, Il2CppStructArray<float> lodScreenSizes, Il2CppStructArray<float> maxWeights, bool recalcNormals, float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst, [Optional] int nrOfSteps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(lodScreenSizes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxWeights);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &nrOfSteps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevelsAndChildrenWithLODSwitcher_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232278, XrefRangeEnd = 232453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> SetUpLODLevelsAndChildrenWithLODGroup(this GameObject go, Il2CppStructArray<float> relativeTransitionHeights, Il2CppStructArray<float> maxWeights, bool recalcNormals, float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst, [Optional] int nrOfSteps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(relativeTransitionHeights);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxWeights);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &nrOfSteps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpLODLevelsAndChildrenWithLODGroup_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232453, XrefRangeEnd = 232545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh GetSimplifiedMesh(this GameObject go, float maxWeight, bool recalcNormals, float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst, [Optional] int nrOfSteps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &nrOfSteps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimplifiedMesh_Public_Static_Mesh_GameObject_Single_Boolean_Single_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232545, XrefRangeEnd = 232548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator GetSimplifiedMeshInBackground(this GameObject go, float maxWeight, bool recalcNormals, float removeSmallParts, Il2CppSystem.Action<Mesh> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimplifiedMeshInBackground_Public_Static_IEnumerator_GameObject_Single_Boolean_Single_Action_1_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 232795, RefRangeEnd = 232799, XrefRangeStart = 232548, XrefRangeEnd = 232795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MergeMeshInto(Mesh fromMesh, Il2CppReferenceArray<Transform> fromBones, Il2CppReferenceArray<Material> fromMaterials, List<Vector3> vertices, List<Vector3> normals, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> boneWeights, List<Transform> bones, List<Matrix4x4> bindposes, Dictionary<Material, List<int>> subMeshes, bool usesNegativeScale, Vector4 lightmapScaleOffset, Transform fromTransform, Transform topTransform, string submeshName, Il2CppStringArray skipSubmeshNames)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[20];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromMesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fromBones);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fromMaterials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(normals);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(boneWeights);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bones);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bindposes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshes);
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &usesNegativeScale;
		*(Vector4**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightmapScaleOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fromTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(topTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(submeshName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(skipSubmeshNames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeMeshInto_Private_Static_Boolean_Mesh_ArrayOf_Transform_ArrayOf_Material_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_Transform_List_1_Matrix4x4_Dictionary_2_Material_List_1_Int32_Boolean_Vector4_Transform_Transform_String_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 232804, RefRangeEnd = 232808, XrefRangeStart = 232799, XrefRangeEnd = 232804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 ApplyBindPose(Vector3 vertex, Transform bone, Matrix4x4 bindpose, float boneWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&vertex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bone);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindpose;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneWeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBindPose_Private_Static_Vector3_Vector3_Transform_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 232815, RefRangeEnd = 232819, XrefRangeStart = 232808, XrefRangeEnd = 232815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 UnApplyBindPose(Vector3 vertex, Transform bone, Matrix4x4 bindpose, float boneWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&vertex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bone);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindpose;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneWeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnApplyBindPose_Private_Static_Vector3_Vector3_Transform_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static GameObjectExtensions()
	{
		Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "GameObjectExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetWorldBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680775);
		NativeMethodInfoPtr_GetBoundsCorners_Public_Static_ArrayOf_Vector3_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680776);
		NativeMethodInfoPtr_GetBoundsCenterAndCorners_Public_Static_ArrayOf_Vector3_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680777);
		NativeMethodInfoPtr_GetWorldBoundsCorners_Public_Static_ArrayOf_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680778);
		NativeMethodInfoPtr_GetWorldBoundsCenterAndCorners_Public_Static_ArrayOf_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680779);
		NativeMethodInfoPtr_GetModelComplexity_Public_Static_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680780);
		NativeMethodInfoPtr_GetModelInfoString_Public_Static_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680781);
		NativeMethodInfoPtr_TopParent_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680782);
		NativeMethodInfoPtr_FindParentWithName_Public_Static_GameObject_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680783);
		NativeMethodInfoPtr_FindMutualParent_Public_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680784);
		NativeMethodInfoPtr_FindFirstChildWithName_Public_Static_GameObject_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680785);
		NativeMethodInfoPtr_IsChildWithNameUnique_Public_Static_Boolean_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680786);
		NativeMethodInfoPtr_CountChildrenWithName_Public_Static_Void_GameObject_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680787);
		NativeMethodInfoPtr_GetGameObjectNamed_Public_Static_GameObject_GameObject_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680788);
		NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680789);
		NativeMethodInfoPtr_GetFirstComponentInParents_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680790);
		NativeMethodInfoPtr_GetFirstComponentInChildren_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680791);
		NativeMethodInfoPtr_GetMeshes_Public_Static_ArrayOf_Mesh_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680792);
		NativeMethodInfoPtr_GetMeshes_Public_Static_ArrayOf_Mesh_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680793);
		NativeMethodInfoPtr_GetTotalVertexCount_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680794);
		NativeMethodInfoPtr_Get1stSharedMesh_Public_Static_Mesh_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680795);
		NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680796);
		NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680797);
		NativeMethodInfoPtr_SetMeshes_Public_Static_Void_GameObject_ArrayOf_Mesh_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680798);
		NativeMethodInfoPtr_GetMaterials_Public_Static_ArrayOf_Material_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680799);
		NativeMethodInfoPtr_CombineMeshes_Public_Static_ArrayOf_Mesh_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680800);
		NativeMethodInfoPtr_CombineMeshes_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680801);
		NativeMethodInfoPtr_GiveUniqueNameIfNeeded_Private_Static_Int32_GameObject_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680802);
		NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680803);
		NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680804);
		NativeMethodInfoPtr_SetUpLODLevels_Public_Static_Void_GameObject_ArrayOf_Single_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680805);
		NativeMethodInfoPtr_SetUpLODLevelsWithLODSwitcher_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680806);
		NativeMethodInfoPtr_SetUpLODLevelsWithLODSwitcherInBackground_Public_Static_IEnumerator_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680807);
		NativeMethodInfoPtr_SetUpLODLevelsAndChildrenWithLODSwitcher_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680808);
		NativeMethodInfoPtr_SetUpLODLevelsAndChildrenWithLODGroup_Public_Static_ArrayOf_Mesh_GameObject_ArrayOf_Single_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680809);
		NativeMethodInfoPtr_GetSimplifiedMesh_Public_Static_Mesh_GameObject_Single_Boolean_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680810);
		NativeMethodInfoPtr_GetSimplifiedMeshInBackground_Public_Static_IEnumerator_GameObject_Single_Boolean_Single_Action_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680811);
		NativeMethodInfoPtr_MergeMeshInto_Private_Static_Boolean_Mesh_ArrayOf_Transform_ArrayOf_Material_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_Transform_List_1_Matrix4x4_Dictionary_2_Material_List_1_Int32_Boolean_Vector4_Transform_Transform_String_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680812);
		NativeMethodInfoPtr_ApplyBindPose_Private_Static_Vector3_Vector3_Transform_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680813);
		NativeMethodInfoPtr_UnApplyBindPose_Private_Static_Vector3_Vector3_Transform_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectExtensions>.NativeClassPtr, 100680814);
	}

	public GameObjectExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
