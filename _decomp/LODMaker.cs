using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class LODMaker : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Boolean_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Single_Single_Single_Single_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeights_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMeshInBackground_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMesh_Private_Static_Mesh_Mesh_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeLODMesh_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_byref_ArrayOf_Matrix4x4_ArrayOf_BoneWeight_byref_ArrayOf_Int32_Bounds_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_byref_List_1_Vector3_byref_List_1_Vector3_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Color32_byref_List_1_Int32_byref_List_1_BoneWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnyWeightOK_Private_Static_Boolean_ArrayOf_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdjacentTriangles_Private_Static_ArrayOf_Int32_ArrayOf_Int32_Int32_List_1_List_1_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTriangleGroup_Private_Static_Void_Int32_Int32_ArrayOf_Int32_List_1_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalAngleAndCenterDistanceForCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_Int32_ArrayOf_Vector3_byref_Single_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalAngleAndCenterDistanceForNewCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Int32_Int32_Int32_ArrayOf_Vector3_Single_byref_Single_byref_Vector3_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUVStretchAndAreaForCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Vector2_Int32_Int32_byref_Single_byref_Single_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalDiffForCorners_Private_Static_Single_ArrayOf_Vector3_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeVertices_Private_Static_Void_byref_Int32_Int32_ArrayOf_Boolean_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Boolean_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_List_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveVertex_Private_Static_Void_Int32_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillNewMeshArray_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Boolean_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillNewMeshTriangles_Private_Static_Void_ArrayOf_Int32_ArrayOf_Int32_List_1_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_Dictionary_2_Material_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEmptyTriangles_Private_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_Int32_List_1_BoneWeight_ArrayOf_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMiniTriangleGroups_Private_Static_Void_Single_Vector3_Single_List_1_Vector3_List_1_Int32_ArrayOf_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewMesh_Public_Static_Mesh_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_ArrayOf_Matrix4x4_ArrayOf_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillMesh_Public_Static_Void_Mesh_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_ArrayOf_Matrix4x4_ArrayOf_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AngleCornerDiff_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AngleDiff_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Area_Private_Static_Single_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexEqualTo_Private_Static_Int32_Vector3_List_1_Int32_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVerticesEqualTo_Private_Static_List_1_Int32_Vector3_List_1_Int32_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVerticesWithinBox_Private_Static_List_1_Int32_Vector3_Vector3_List_1_Int32_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastVertexWithYSmaller_Private_Static_Int32_Single_List_1_Int32_ArrayOf_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVertexObscured_Private_Static_Boolean_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Boolean_ArrayOf_Int32_Vector3_List_1_Int32_List_1_List_1_Int32_ArrayOf_Int32_Single_Boolean_Vector3_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindCollision_Public_Static_Single_Vector3_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Private_Static_Void_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LODMaker>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15087, XrefRangeEnd = 15088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, [Optional][DefaultParameterValue(true)] bool recalcNormals, [Optional] float removeSmallParts, bool reuseOldMesh = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aMaxWeight;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &reuseOldMesh;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Boolean_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 15093, RefRangeEnd = 15098, XrefRangeStart = 15088, XrefRangeEnd = 15093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, bool recalcNormals, bool reuseOldMesh = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aMaxWeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &reuseOldMesh;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Single_Single_Single_Single_Single_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static void GetWeights(float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, out float sideLengthWeight, out float oldAngleWeight, out float newAngleWeight, out float uvWeight, out float areaDiffWeight, out float normalWeight, out float vertexWeight, out float centerDistanceWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[14];
		*ptr = (nint)(&aMaxWeight);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectNormals;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectUvs;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &smallTrianglesFirst;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &protectSubMeshesAndSharpEdges;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref sideLengthWeight);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref oldAngleWeight);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref newAngleWeight);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref uvWeight);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref areaDiffWeight);
		*(void**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref normalWeight);
		*(void**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref vertexWeight);
		*(void**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref centerDistanceWeight);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeights_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15098, XrefRangeEnd = 15349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MakeLODMeshInBackground(Il2CppSystem.Object data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMeshInBackground_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15515, RefRangeEnd = 15516, XrefRangeStart = 15349, XrefRangeEnd = 15515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh MakeLODMesh(Mesh orig, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, bool recalcNormals, bool reuseOldMesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(orig);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sideLengthWeight;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldAngleWeight;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newAngleWeight;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &uvWeight;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &areaDiffWeight;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalWeight;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexWeight;
		*(float**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerDistanceWeight;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &reuseOldMesh;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMesh_Private_Static_Mesh_Mesh_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15832, RefRangeEnd = 15834, XrefRangeStart = 15516, XrefRangeEnd = 15832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MakeLODMesh(Il2CppStructArray<Vector3> vs, Il2CppStructArray<Vector3> ns, Il2CppStructArray<Vector2> uv1s, Il2CppStructArray<Vector2> uv2s, Il2CppStructArray<Vector2> uv3s, Il2CppStructArray<Vector2> uv4s, Il2CppStructArray<Color32> colors32, Il2CppStructArray<int> ts, ref Il2CppStructArray<Matrix4x4> bindposes, Il2CppStructArray<BoneWeight> bws, ref Il2CppStructArray<int> subMeshOffsets, Bounds meshBounds, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, out List<Vector3> newVs, out List<Vector3> newNs, out List<Vector2> newUv1s, out List<Vector2> newUv2s, out List<Vector2> newUv3s, out List<Vector2> newUv4s, out List<Color32> newColors32, out List<int> newTs, out List<BoneWeight> newBws)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[31];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(bindposes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(subMeshOffsets);
		*(Bounds**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshBounds;
		*(float**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		*(float**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSmallParts;
		*(float**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &sideLengthWeight;
		*(float**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldAngleWeight;
		*(float**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &newAngleWeight;
		*(float**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &uvWeight;
		*(float**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &areaDiffWeight;
		*(float**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalWeight;
		*(float**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexWeight;
		*(float**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerDistanceWeight;
		byte* num = (byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(newVs);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(newNs);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)24u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(newUv1s);
		*(System.IntPtr**)num3 = &intPtr3;
		byte* num4 = (byte*)ptr + checked((nuint)25u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(newUv2s);
		*(System.IntPtr**)num4 = &intPtr4;
		byte* num5 = (byte*)ptr + checked((nuint)26u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(newUv3s);
		*(System.IntPtr**)num5 = &intPtr5;
		byte* num6 = (byte*)ptr + checked((nuint)27u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr6 = IL2CPP.Il2CppObjectBaseToPtr(newUv4s);
		*(System.IntPtr**)num6 = &intPtr6;
		byte* num7 = (byte*)ptr + checked((nuint)28u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr7 = IL2CPP.Il2CppObjectBaseToPtr(newColors32);
		*(System.IntPtr**)num7 = &intPtr7;
		byte* num8 = (byte*)ptr + checked((nuint)29u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr8 = IL2CPP.Il2CppObjectBaseToPtr(newTs);
		*(System.IntPtr**)num8 = &intPtr8;
		byte* num9 = (byte*)ptr + checked((nuint)30u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr9 = IL2CPP.Il2CppObjectBaseToPtr(newBws);
		*(System.IntPtr**)num9 = &intPtr9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr10 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeLODMesh_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_byref_ArrayOf_Matrix4x4_ArrayOf_BoneWeight_byref_ArrayOf_Int32_Bounds_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_byref_List_1_Vector3_byref_List_1_Vector3_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Color32_byref_List_1_Int32_byref_List_1_BoneWeight_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr11 = intPtr;
		newVs = (List<Vector3>)(object)((intPtr11 == (System.IntPtr)0) ? null : new List<T>(intPtr11));
		System.IntPtr intPtr12 = intPtr2;
		newNs = (List<Vector3>)(object)((intPtr12 == (System.IntPtr)0) ? null : new List<T>(intPtr12));
		System.IntPtr intPtr13 = intPtr3;
		newUv1s = (List<Vector2>)(object)((intPtr13 == (System.IntPtr)0) ? null : new List<T>(intPtr13));
		System.IntPtr intPtr14 = intPtr4;
		newUv2s = (List<Vector2>)(object)((intPtr14 == (System.IntPtr)0) ? null : new List<T>(intPtr14));
		System.IntPtr intPtr15 = intPtr5;
		newUv3s = (List<Vector2>)(object)((intPtr15 == (System.IntPtr)0) ? null : new List<T>(intPtr15));
		System.IntPtr intPtr16 = intPtr6;
		newUv4s = (List<Vector2>)(object)((intPtr16 == (System.IntPtr)0) ? null : new List<T>(intPtr16));
		System.IntPtr intPtr17 = intPtr7;
		newColors32 = (List<Color32>)(object)((intPtr17 == (System.IntPtr)0) ? null : new List<T>(intPtr17));
		System.IntPtr intPtr18 = intPtr8;
		newTs = (List<int>)(object)((intPtr18 == (System.IntPtr)0) ? null : new List<T>(intPtr18));
		System.IntPtr intPtr19 = intPtr9;
		newBws = (List<BoneWeight>)(object)((intPtr19 == (System.IntPtr)0) ? null : new List<T>(intPtr19));
	}

	[CallerCount(0)]
	public unsafe static bool AnyWeightOK(Il2CppStructArray<float> weights, float aMaxWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(weights);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aMaxWeight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnyWeightOK_Private_Static_Boolean_ArrayOf_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15916, RefRangeEnd = 15917, XrefRangeStart = 15834, XrefRangeEnd = 15916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetAdjacentTriangles(Il2CppStructArray<int> ts, int tIdx, List<List<int>> trianglesPerVertex, Il2CppStructArray<int> uniqueVs, Il2CppStructArray<int> triangleGroups, List<List<int>> trianglesPerGroup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tIdx;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trianglesPerVertex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uniqueVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triangleGroups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trianglesPerGroup);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdjacentTriangles_Private_Static_ArrayOf_Int32_ArrayOf_Int32_Int32_List_1_List_1_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 15929, RefRangeEnd = 15932, XrefRangeStart = 15917, XrefRangeEnd = 15929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTriangleGroup(int tIdx0, int tIdx1, Il2CppStructArray<int> triangleGroups, List<List<int>> trianglesPerGroup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&tIdx0);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tIdx1;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triangleGroups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trianglesPerGroup);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTriangleGroup_Private_Static_Void_Int32_Int32_ArrayOf_Int32_List_1_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15937, RefRangeEnd = 15938, XrefRangeStart = 15932, XrefRangeEnd = 15937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTotalAngleAndCenterDistanceForCorner(Il2CppStructArray<int> ts, Il2CppStructArray<Vector3> vs, Il2CppStructArray<int> movedVs, int vertexIdx, Il2CppStructArray<Vector3> centerDistances, ref float totalAngle, ref Vector3 totalCenterDist)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedVs);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexIdx;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(centerDistances);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalAngle);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalCenterDist);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalAngleAndCenterDistanceForCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_Int32_ArrayOf_Vector3_byref_Single_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15948, RefRangeEnd = 15949, XrefRangeStart = 15938, XrefRangeEnd = 15948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTotalAngleAndCenterDistanceForNewCorner(Il2CppStructArray<int> ts, Il2CppStructArray<Vector3> vs, Il2CppStructArray<int> movedVs, Il2CppStructArray<int> uniqueVs, int vertexIdx, int newIdx, Il2CppStructArray<Vector3> centerDistances, float maxWeight, ref float totalAngle, ref Vector3 totalCenterDist, ref bool flipsTriangles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uniqueVs);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexIdx;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newIdx;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(centerDistances);
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWeight;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalAngle);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalCenterDist);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref flipsTriangles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalAngleAndCenterDistanceForNewCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Int32_Int32_Int32_ArrayOf_Vector3_Single_byref_Single_byref_Vector3_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15959, RefRangeEnd = 15960, XrefRangeStart = 15949, XrefRangeEnd = 15959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetUVStretchAndAreaForCorner(Il2CppStructArray<int> ts, Il2CppStructArray<Vector3> vs, Il2CppStructArray<int> movedVs, Il2CppStructArray<int> uniqueVs, Il2CppStructArray<Vector2> uvs, int cFrom, int cTo, ref float affectedUvAreaDiff, ref float affectedAreaDiff, ref float totalUvAreaDiff, ref float totalAreaDiff)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uniqueVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uvs);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cFrom;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &cTo;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref affectedUvAreaDiff);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref affectedAreaDiff);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalUvAreaDiff);
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref totalAreaDiff);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUVStretchAndAreaForCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Vector2_Int32_Int32_byref_Single_byref_Single_byref_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15961, RefRangeEnd = 15962, XrefRangeStart = 15960, XrefRangeEnd = 15961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetNormalDiffForCorners(Il2CppStructArray<Vector3> ns, int corner1, int corner2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &corner1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &corner2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormalDiffForCorners_Private_Static_Single_ArrayOf_Vector3_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15974, RefRangeEnd = 15975, XrefRangeStart = 15962, XrefRangeEnd = 15974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MergeVertices(ref int oldV, int newV, Il2CppStructArray<bool> hasTwinVS, Il2CppStructArray<Vector3> vs, Il2CppStructArray<int> triangles, Il2CppStructArray<Vector2> uv1s, Il2CppStructArray<Vector2> uv2s, Il2CppStructArray<Vector2> uv3s, Il2CppStructArray<Vector2> uv4s, Il2CppStructArray<Color32> colors32, Il2CppStructArray<bool> deletedVertices, Il2CppStructArray<int> movedVs, Il2CppStructArray<int> uniqueVs, Il2CppStructArray<int> movedUv1s, Il2CppStructArray<int> movedUv2s, Il2CppStructArray<int> movedUv3s, Il2CppStructArray<int> movedUv4s, Il2CppStructArray<int> movedColors, List<List<int>> trianglesPerVertex, bool logYN)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[20];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref oldV);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newV;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(hasTwinVS);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triangles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(deletedVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uniqueVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedColors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trianglesPerVertex);
		*(bool**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &logYN;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeVertices_Private_Static_Void_byref_Int32_Int32_ArrayOf_Boolean_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Boolean_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_List_1_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15975, XrefRangeEnd = 15976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveVertex(int oldV, int newV, Il2CppStructArray<int> movedVs, Il2CppStructArray<int> uniqueVs, Il2CppStructArray<int> movedUv1s, Il2CppStructArray<int> movedUv2s, Il2CppStructArray<int> movedUv3s, Il2CppStructArray<int> movedUv4s, Il2CppStructArray<int> movedColors)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&oldV);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newV;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uniqueVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedColors);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveVertex_Private_Static_Void_Int32_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15997, RefRangeEnd = 15998, XrefRangeStart = 15976, XrefRangeEnd = 15997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillNewMeshArray(Il2CppStructArray<Vector3> vs, Il2CppStructArray<bool> vdel, Il2CppStructArray<int> movedVs, Il2CppStructArray<Vector3> ns, Il2CppStructArray<Vector2> uv1s, Il2CppStructArray<int> movedUv1s, Il2CppStructArray<Vector2> uv2s, Il2CppStructArray<int> movedUv2s, Il2CppStructArray<Vector2> uv3s, Il2CppStructArray<int> movedUv3s, Il2CppStructArray<Vector2> uv4s, Il2CppStructArray<int> movedUv4s, Il2CppStructArray<Color32> colors32, Il2CppStructArray<int> movedColors, Il2CppStructArray<BoneWeight> bws, List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<BoneWeight> newBws, Il2CppStructArray<int> o2n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[24];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vdel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedUv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(movedColors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newNs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newColors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newBws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(o2n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillNewMeshArray_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Boolean_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_ArrayOf_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16011, RefRangeEnd = 16012, XrefRangeStart = 15998, XrefRangeEnd = 16011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillNewMeshTriangles(Il2CppStructArray<int> oldTriangles, Il2CppStructArray<int> o2n, List<int> newTriangles, Il2CppStructArray<int> subMeshOffsets, Il2CppStructArray<int> triangleGroups, List<int> newTGrps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldTriangles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(o2n);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newTriangles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshOffsets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triangleGroups);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newTGrps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillNewMeshTriangles_Private_Static_Void_ArrayOf_Int32_ArrayOf_Int32_List_1_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16069, RefRangeEnd = 16070, XrefRangeStart = 16012, XrefRangeEnd = 16069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<int> ts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ts);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16148, RefRangeEnd = 16150, XrefRangeStart = 16070, XrefRangeEnd = 16148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<List<int>> subMeshes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16247, RefRangeEnd = 16248, XrefRangeStart = 16150, XrefRangeEnd = 16247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, Dictionary<Material, List<int>> subMeshes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_Dictionary_2_Material_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16296, RefRangeEnd = 16297, XrefRangeStart = 16248, XrefRangeEnd = 16296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveEmptyTriangles(List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<int> newTs, List<BoneWeight> newBws, Il2CppStructArray<int> subMeshOffsets, List<int> newTGrps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newNs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newUv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newColors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newTs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newBws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshOffsets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newTGrps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEmptyTriangles_Private_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_Int32_List_1_BoneWeight_ArrayOf_Int32_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16339, RefRangeEnd = 16340, XrefRangeStart = 16297, XrefRangeEnd = 16339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveMiniTriangleGroups(float removeSmallParts, Vector3 sizeMultiplier, float aMaxWeight, List<Vector3> newVs, List<int> newTs, Il2CppStructArray<int> subMeshOffsets, List<int> newTGrps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&removeSmallParts);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeMultiplier;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &aMaxWeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newVs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newTs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshOffsets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newTGrps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMiniTriangleGroups_Private_Static_Void_Single_Vector3_Single_List_1_Vector3_List_1_Int32_ArrayOf_Int32_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 16345, RefRangeEnd = 16348, XrefRangeStart = 16340, XrefRangeEnd = 16345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CreateNewMesh(Il2CppStructArray<Vector3> vs, Il2CppStructArray<Vector3> ns, Il2CppStructArray<Vector2> uv1s, Il2CppStructArray<Vector2> uv2s, Il2CppStructArray<Vector2> uv3s, Il2CppStructArray<Vector2> uv4s, Il2CppStructArray<Color32> colors32, Il2CppStructArray<int> ts, Il2CppStructArray<BoneWeight> bws, Il2CppStructArray<Matrix4x4> bindposes, Il2CppStructArray<int> subMeshOffsets, bool recalcNormals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bindposes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshOffsets);
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewMesh_Public_Static_Mesh_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_ArrayOf_Matrix4x4_ArrayOf_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Mesh(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16406, RefRangeEnd = 16408, XrefRangeStart = 16348, XrefRangeEnd = 16406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FillMesh(Mesh mesh, Il2CppStructArray<Vector3> vs, Il2CppStructArray<Vector3> ns, Il2CppStructArray<Vector2> uv1s, Il2CppStructArray<Vector2> uv2s, Il2CppStructArray<Vector2> uv3s, Il2CppStructArray<Vector2> uv4s, Il2CppStructArray<Color32> colors32, Il2CppStructArray<int> ts, Il2CppStructArray<BoneWeight> bws, Il2CppStructArray<Matrix4x4> bindposes, Il2CppStructArray<int> subMeshOffsets, bool recalcNormals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv1s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colors32);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bws);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bindposes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshOffsets);
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &recalcNormals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillMesh_Public_Static_Void_Mesh_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_ArrayOf_Matrix4x4_ArrayOf_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16408, RefRangeEnd = 16409, XrefRangeStart = 16408, XrefRangeEnd = 16408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float AngleCornerDiff(float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleCornerDiff_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16409, RefRangeEnd = 16410, XrefRangeStart = 16409, XrefRangeEnd = 16409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float AngleDiff(float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleDiff_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 16414, RefRangeEnd = 16423, XrefRangeStart = 16410, XrefRangeEnd = 16414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Area(Vector3 p0, Vector3 p1, Vector3 p2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Area_Private_Static_Single_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16427, RefRangeEnd = 16428, XrefRangeStart = 16423, XrefRangeEnd = 16427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetVertexEqualTo(Vector3 v, List<int> orderedVertices, Il2CppStructArray<Vector3> vs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&v);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(orderedVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexEqualTo_Private_Static_Int32_Vector3_List_1_Int32_ArrayOf_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16438, RefRangeEnd = 16439, XrefRangeStart = 16428, XrefRangeEnd = 16438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> GetVerticesEqualTo(Vector3 v, List<int> orderedVertices, Il2CppStructArray<Vector3> vs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&v);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(orderedVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVerticesEqualTo_Private_Static_List_1_Int32_Vector3_List_1_Int32_ArrayOf_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<int>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16452, XrefRangeStart = 16439, XrefRangeEnd = 16451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> GetVerticesWithinBox(Vector3 from, Vector3 to, List<int> orderedVertices, Il2CppStructArray<Vector3> vs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&from);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(orderedVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVerticesWithinBox_Private_Static_List_1_Int32_Vector3_Vector3_List_1_Int32_ArrayOf_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<int>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16456, RefRangeEnd = 16458, XrefRangeStart = 16452, XrefRangeEnd = 16456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLastVertexWithYSmaller(float y, List<int> orderedVertices, Il2CppStructArray<Vector3> vs, int limitSearchRange)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&y);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(orderedVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &limitSearchRange;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastVertexWithYSmaller_Private_Static_Int32_Single_List_1_Int32_ArrayOf_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16458, XrefRangeEnd = 16471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVertexObscured(Il2CppStructArray<Vector3> vs, Il2CppStructArray<Vector3> ns, Il2CppStructArray<int> ts, Il2CppStructArray<bool> vObscured, Il2CppStructArray<int> uniqueVs, Vector3 vertexBoxSize, List<int> orderedVertices, List<List<int>> trianglesPerVertex, Il2CppStructArray<int> subMeshIdxPerVertex, float maxObscureDist, bool hiddenByOtherSubmesh, Vector3 vertex, Vector3 normal, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[14];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vObscured);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uniqueVs);
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexBoxSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(orderedVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trianglesPerVertex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(subMeshIdxPerVertex);
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxObscureDist;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &hiddenByOtherSubmesh;
		*(Vector3**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertex;
		*(Vector3**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(int**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVertexObscured_Private_Static_Boolean_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Boolean_ArrayOf_Int32_Vector3_List_1_Int32_List_1_List_1_Int32_ArrayOf_Int32_Single_Boolean_Vector3_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 16471, RefRangeEnd = 16473, XrefRangeStart = 16471, XrefRangeEnd = 16471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float FindCollision(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fromPos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointOnPlane;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalPlane;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCollision_Public_Static_Single_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16473, XrefRangeEnd = 16491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(string msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LODMaker()
	{
		Il2CppClassPointerStore<LODMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LODMaker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODMaker>.NativeClassPtr);
		NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664449);
		NativeMethodInfoPtr_MakeLODMesh_Public_Static_Mesh_Mesh_Single_Single_Single_Single_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664450);
		NativeMethodInfoPtr_GetWeights_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_MakeLODMeshInBackground_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_MakeLODMesh_Private_Static_Mesh_Mesh_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_MakeLODMesh_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_byref_ArrayOf_Matrix4x4_ArrayOf_BoneWeight_byref_ArrayOf_Int32_Bounds_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_byref_List_1_Vector3_byref_List_1_Vector3_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Vector2_byref_List_1_Color32_byref_List_1_Int32_byref_List_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664454);
		NativeMethodInfoPtr_AnyWeightOK_Private_Static_Boolean_ArrayOf_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_GetAdjacentTriangles_Private_Static_ArrayOf_Int32_ArrayOf_Int32_Int32_List_1_List_1_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr_SetTriangleGroup_Private_Static_Void_Int32_Int32_ArrayOf_Int32_List_1_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_GetTotalAngleAndCenterDistanceForCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_Int32_ArrayOf_Vector3_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_GetTotalAngleAndCenterDistanceForNewCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Int32_Int32_Int32_ArrayOf_Vector3_Single_byref_Single_byref_Vector3_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664459);
		NativeMethodInfoPtr_GetUVStretchAndAreaForCorner_Private_Static_Void_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Vector2_Int32_Int32_byref_Single_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664460);
		NativeMethodInfoPtr_GetNormalDiffForCorners_Private_Static_Single_ArrayOf_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664461);
		NativeMethodInfoPtr_MergeVertices_Private_Static_Void_byref_Int32_Int32_ArrayOf_Boolean_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Boolean_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_List_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664462);
		NativeMethodInfoPtr_MoveVertex_Private_Static_Void_Int32_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664463);
		NativeMethodInfoPtr_FillNewMeshArray_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Boolean_ArrayOf_Int32_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Vector2_ArrayOf_Int32_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664464);
		NativeMethodInfoPtr_FillNewMeshTriangles_Private_Static_Void_ArrayOf_Int32_ArrayOf_Int32_List_1_Int32_ArrayOf_Int32_ArrayOf_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664465);
		NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664466);
		NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_List_1_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664467);
		NativeMethodInfoPtr_RemoveUnusedVertices_Public_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_BoneWeight_Dictionary_2_Material_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664468);
		NativeMethodInfoPtr_RemoveEmptyTriangles_Private_Static_Void_List_1_Vector3_List_1_Vector3_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Vector2_List_1_Color32_List_1_Int32_List_1_BoneWeight_ArrayOf_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664469);
		NativeMethodInfoPtr_RemoveMiniTriangleGroups_Private_Static_Void_Single_Vector3_Single_List_1_Vector3_List_1_Int32_ArrayOf_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664470);
		NativeMethodInfoPtr_CreateNewMesh_Public_Static_Mesh_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_ArrayOf_Matrix4x4_ArrayOf_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664471);
		NativeMethodInfoPtr_FillMesh_Public_Static_Void_Mesh_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Vector2_ArrayOf_Color32_ArrayOf_Int32_ArrayOf_BoneWeight_ArrayOf_Matrix4x4_ArrayOf_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664472);
		NativeMethodInfoPtr_AngleCornerDiff_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664473);
		NativeMethodInfoPtr_AngleDiff_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664474);
		NativeMethodInfoPtr_Area_Private_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664475);
		NativeMethodInfoPtr_GetVertexEqualTo_Private_Static_Int32_Vector3_List_1_Int32_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664476);
		NativeMethodInfoPtr_GetVerticesEqualTo_Private_Static_List_1_Int32_Vector3_List_1_Int32_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664477);
		NativeMethodInfoPtr_GetVerticesWithinBox_Private_Static_List_1_Int32_Vector3_Vector3_List_1_Int32_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664478);
		NativeMethodInfoPtr_GetLastVertexWithYSmaller_Private_Static_Int32_Single_List_1_Int32_ArrayOf_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664479);
		NativeMethodInfoPtr_IsVertexObscured_Private_Static_Boolean_ArrayOf_Vector3_ArrayOf_Vector3_ArrayOf_Int32_ArrayOf_Boolean_ArrayOf_Int32_Vector3_List_1_Int32_List_1_List_1_Int32_ArrayOf_Int32_Single_Boolean_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664480);
		NativeMethodInfoPtr_FindCollision_Public_Static_Single_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664481);
		NativeMethodInfoPtr_Log_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODMaker>.NativeClassPtr, 100664482);
	}

	public LODMaker(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
