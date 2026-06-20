using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace OrbCreationExtensions;

public static class MeshExtensions : Il2CppSystem.Object
{
	[ObfuscatedName("OrbCreationExtensions.MeshExtensions/<MakeLODMeshInBackground>d__5")]
	public sealed class _MakeLODMeshInBackground_d__5 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxWeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_removeSmallParts;

		private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

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
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr));

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

		public unsafe Mesh mesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _MakeLODMeshInBackground_d__5(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232819, XrefRangeEnd = 232968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232968, XrefRangeEnd = 232973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _MakeLODMeshInBackground_d__5()
		{
			Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, "<MakeLODMeshInBackground>d__5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_maxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "maxWeight");
			NativeFieldInfoPtr_removeSmallParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "removeSmallParts");
			NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "mesh");
			NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "result");
			NativeFieldInfoPtr_recalcNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "recalcNormals");
			NativeFieldInfoPtr__lodInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, "<lodInfo>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, 100680847);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, 100680848);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, 100680849);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, 100680850);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, 100680851);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_MakeLODMeshInBackground_d__5>.NativeClassPtr, 100680852);
		}

		public _MakeLODMeshInBackground_d__5(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateTangents_Public_Static_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaledRotatedTranslatedMesh_Public_Static_Mesh_Mesh_Vector3_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSkinnedMesh_Public_Static_Boolean_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriangleCount_Public_Static_Int32_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Boolean_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMeshInBackground_Public_Static_IEnumerator_Mesh_Single_Boolean_Single_Action_1_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMeshes_Public_Static_ArrayOf_Mesh_Mesh_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUvRange_Public_Static_Vector4_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckUvsWithin01Range_Public_Static_Boolean_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampUvs_Public_Static_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WrapUvs_Public_Static_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAtlasRectForSubmesh_Public_Static_Void_Mesh_Rect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeSubmeshInto_Public_Static_Void_Mesh_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAndRemoveSubmeshes_Public_Static_Mesh_Mesh_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAndRemoveHiddenTriangles_Public_Static_Mesh_Mesh_Int32_Matrix4x4_ArrayOf_Mesh_ArrayOf_Int32_ArrayOf_Matrix4x4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTriangleHidden_Private_Static_Boolean_Vector3_Vector3_Vector3_Single_List_1_Vector3_List_1_Vector3_List_1_Vector3_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHidden_Private_Static_Boolean_Vector3_Vector3_Single_List_1_Vector3_List_1_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTrianglesWithinRange_Private_Static_List_1_Int32_Vector3_Vector3_Vector3_Single_List_1_Vector3_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceToPlane_Public_Static_Single_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormal_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232998, RefRangeEnd = 233000, XrefRangeStart = 232973, XrefRangeEnd = 232998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecalculateTangents(this Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateTangents_Public_Static_Void_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233000, XrefRangeEnd = 233023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh ScaledRotatedTranslatedMesh(this Mesh mesh, Vector3 scale, Quaternion rotate, Vector3 translate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotate;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &translate;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaledRotatedTranslatedMesh_Public_Static_Mesh_Mesh_Vector3_Quaternion_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233023, XrefRangeEnd = 233025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSkinnedMesh(this Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSkinnedMesh_Public_Static_Boolean_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233025, XrefRangeEnd = 233026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriangleCount(this Mesh orig)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriangleCount_Public_Static_Int32_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233026, XrefRangeEnd = 233027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh MakeLODMesh(this Mesh orig, float aMaxWeight, bool recalcNormals, [Optional] float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aMaxWeight;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Boolean_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233027, XrefRangeEnd = 233030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator MakeLODMeshInBackground(this Mesh mesh, float maxWeight, bool recalcNormals, float removeSmallParts, Il2CppSystem.Action<Mesh> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMeshInBackground_Public_Static_IEnumerator_Mesh_Single_Boolean_Single_Action_1_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233039, RefRangeEnd = 233041, XrefRangeStart = 233030, XrefRangeEnd = 233039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Mesh> MakeLODMeshes(this Mesh mesh, Il2CppStructArray<float> maxWeights, bool recalcNormals, [Optional] float removeSmallParts, [Optional] float protectNormals, [Optional] float protectUvs, [Optional] float protectSubMeshesAndSharpEdges, [Optional] float smallTrianglesFirst, [Optional] int nrOfSteps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(maxWeights);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &nrOfSteps;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMeshes_Public_Static_ArrayOf_Mesh_Mesh_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233041, XrefRangeEnd = 233044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetUvRange(this Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUvRange_Public_Static_Vector4_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233044, XrefRangeEnd = 233047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckUvsWithin01Range(this Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckUvsWithin01Range_Public_Static_Boolean_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233047, XrefRangeEnd = 233055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClampUvs(this Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampUvs_Public_Static_Void_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233055, XrefRangeEnd = 233061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WrapUvs(this Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WrapUvs_Public_Static_Void_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233061, XrefRangeEnd = 233085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAtlasRectForSubmesh(this Mesh mesh, Rect atlasRect, int submeshIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasRect;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &submeshIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAtlasRectForSubmesh_Public_Static_Void_Mesh_Rect_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233085, XrefRangeEnd = 233148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MergeSubmeshInto(this Mesh mesh, int from, int to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeSubmeshInto_Public_Static_Void_Mesh_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233148, XrefRangeEnd = 233298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CopyAndRemoveSubmeshes(this Mesh orig, Il2CppStructArray<int> submeshesToRemove)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(submeshesToRemove);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAndRemoveSubmeshes_Public_Static_Mesh_Mesh_ArrayOf_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233298, XrefRangeEnd = 233521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CopyAndRemoveHiddenTriangles(this Mesh orig, int subMeshIdx, Matrix4x4 localToWorldMatrix, Il2CppReferenceArray<Mesh> hidingMeshes, Il2CppStructArray<int> hidingSubMeshes, Il2CppStructArray<Matrix4x4> hidingLocalToWorldMatrices, [Optional] float maxRemoveDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subMeshIdx;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localToWorldMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingMeshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingSubMeshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingLocalToWorldMatrices);
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRemoveDistance;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAndRemoveHiddenTriangles_Public_Static_Mesh_Mesh_Int32_Matrix4x4_ArrayOf_Mesh_ArrayOf_Int32_ArrayOf_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233528, RefRangeEnd = 233529, XrefRangeStart = 233521, XrefRangeEnd = 233528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsTriangleHidden(Vector3 v0, Vector3 v1, Vector3 v2, float maxDistance, List<Vector3> triMinCorners, List<Vector3> triMaxCorners, List<Vector3> hidingVs, List<int> hidingTs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&v0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triMinCorners);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triMaxCorners);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingTs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTriangleHidden_Private_Static_Boolean_Vector3_Vector3_Vector3_Single_List_1_Vector3_List_1_Vector3_List_1_Vector3_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 233537, RefRangeEnd = 233541, XrefRangeStart = 233529, XrefRangeEnd = 233537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHidden(Vector3 v, Vector3 n, float maxDistance, List<Vector3> hidingVs, List<int> hidingTs, List<int> trianglesToCheck)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&v);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hidingTs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trianglesToCheck);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHidden_Private_Static_Boolean_Vector3_Vector3_Single_List_1_Vector3_List_1_Int32_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233553, RefRangeEnd = 233554, XrefRangeStart = 233541, XrefRangeEnd = 233553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> GetTrianglesWithinRange(Vector3 v0, Vector3 v1, Vector3 v2, float maxDistance, List<Vector3> triMinCorners, List<Vector3> triMaxCorners)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&v0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triMinCorners);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triMaxCorners);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTrianglesWithinRange_Private_Static_List_1_Int32_Vector3_Vector3_Vector3_Single_List_1_Vector3_List_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<int>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe static float DistanceToPlane(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fromPos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointOnPlane;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalPlane;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceToPlane_Public_Static_Single_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233558, RefRangeEnd = 233560, XrefRangeStart = 233554, XrefRangeEnd = 233558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetNormal(Vector3 v0, Vector3 v1, Vector3 v2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&v0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &v2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormal_Public_Static_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static MeshExtensions()
	{
		Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "MeshExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_RecalculateTangents_Public_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680827);
		NativeMethodInfoPtr_ScaledRotatedTranslatedMesh_Public_Static_Mesh_Mesh_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680828);
		NativeMethodInfoPtr_IsSkinnedMesh_Public_Static_Boolean_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680829);
		NativeMethodInfoPtr_GetTriangleCount_Public_Static_Int32_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680830);
		NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Boolean_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680831);
		NativeMethodInfoPtr_MakeLODMeshInBackground_Public_Static_IEnumerator_Mesh_Single_Boolean_Single_Action_1_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680832);
		NativeMethodInfoPtr_MakeLODMeshes_Public_Static_ArrayOf_Mesh_Mesh_ArrayOf_Single_Boolean_Single_Single_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680833);
		NativeMethodInfoPtr_GetUvRange_Public_Static_Vector4_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680834);
		NativeMethodInfoPtr_CheckUvsWithin01Range_Public_Static_Boolean_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680835);
		NativeMethodInfoPtr_ClampUvs_Public_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680836);
		NativeMethodInfoPtr_WrapUvs_Public_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680837);
		NativeMethodInfoPtr_SetAtlasRectForSubmesh_Public_Static_Void_Mesh_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680838);
		NativeMethodInfoPtr_MergeSubmeshInto_Public_Static_Void_Mesh_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680839);
		NativeMethodInfoPtr_CopyAndRemoveSubmeshes_Public_Static_Mesh_Mesh_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680840);
		NativeMethodInfoPtr_CopyAndRemoveHiddenTriangles_Public_Static_Mesh_Mesh_Int32_Matrix4x4_ArrayOf_Mesh_ArrayOf_Int32_ArrayOf_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680841);
		NativeMethodInfoPtr_IsTriangleHidden_Private_Static_Boolean_Vector3_Vector3_Vector3_Single_List_1_Vector3_List_1_Vector3_List_1_Vector3_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680842);
		NativeMethodInfoPtr_IsHidden_Private_Static_Boolean_Vector3_Vector3_Single_List_1_Vector3_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680843);
		NativeMethodInfoPtr_GetTrianglesWithinRange_Private_Static_List_1_Int32_Vector3_Vector3_Vector3_Single_List_1_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680844);
		NativeMethodInfoPtr_DistanceToPlane_Public_Static_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680845);
		NativeMethodInfoPtr_GetNormal_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshExtensions>.NativeClassPtr, 100680846);
	}

	public MeshExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
