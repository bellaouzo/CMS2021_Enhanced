using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPDamage : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_colliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_minVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDisplacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVertexFracture;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeDamageRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxNodeRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeRotationRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexRepairRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableRepairKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_repairKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalNodePositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalNodeRotations;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_repairing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_meshDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_colliderDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_nodeDamage;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRepairing_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_meshDamage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colliderDamage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nodeDamage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Repair_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessImpact_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeformMesh_Private_Single_Mesh_ArrayOf_Vector3_Transform_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeformNode_Private_Single_Transform_Vector3_Quaternion_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnglesToVector_Private_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeformColliders_Private_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRepair_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RepairMesh_Private_Boolean_Mesh_ArrayOf_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RepairNode_Private_Boolean_Transform_Vector3_Quaternion_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreMeshes_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreNodes_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreColliders_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPDamage>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<MeshFilter> meshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<MeshFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<MeshCollider> colliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<MeshCollider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float minVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVelocity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minVelocity)) = num;
		}
	}

	public unsafe float multiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplier)) = num;
		}
	}

	public unsafe float damageRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageRadius)) = num;
		}
	}

	public unsafe float maxDisplacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDisplacement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDisplacement)) = num;
		}
	}

	public unsafe float maxVertexFracture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVertexFracture);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVertexFracture)) = num;
		}
	}

	public unsafe float nodeDamageRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeDamageRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeDamageRadius)) = num;
		}
	}

	public unsafe float maxNodeRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNodeRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNodeRotation)) = num;
		}
	}

	public unsafe float nodeRotationRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeRotationRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeRotationRate)) = num;
		}
	}

	public unsafe float vertexRepairRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexRepairRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexRepairRate)) = num;
		}
	}

	public unsafe bool enableRepairKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRepairKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRepairKey)) = flag;
		}
	}

	public unsafe KeyCode repairKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairKey)) = keyCode;
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<Vector3>> m_originalMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalMeshes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<Vector3>> m_originalColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalColliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalColliders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector3> m_originalNodePositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalNodePositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalNodePositions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Quaternion> m_originalNodeRotations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalNodeRotations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Quaternion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalNodeRotations), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_repairing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_repairing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_repairing)) = flag;
		}
	}

	public unsafe float m_meshDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_meshDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_meshDamage)) = num;
		}
	}

	public unsafe float m_colliderDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colliderDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colliderDamage)) = num;
		}
	}

	public unsafe float m_nodeDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nodeDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nodeDamage)) = num;
		}
	}

	public unsafe bool isRepairing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRepairing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float meshDamage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_meshDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float colliderDamage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colliderDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float nodeDamage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nodeDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115231, XrefRangeEnd = 115281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115281, XrefRangeEnd = 115291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115291, XrefRangeEnd = 115296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Repair()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Repair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115296, XrefRangeEnd = 115311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessImpact()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessImpact_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115329, RefRangeEnd = 115330, XrefRangeStart = 115311, XrefRangeEnd = 115329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float DeformMesh(Mesh mesh, Il2CppStructArray<Vector3> originalMesh, Transform localTransform, Vector3 contactPoint, Vector3 contactVelocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(originalMesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(localTransform);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactPoint;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactVelocity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeformMesh_Private_Single_Mesh_ArrayOf_Vector3_Transform_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115359, RefRangeEnd = 115360, XrefRangeStart = 115330, XrefRangeEnd = 115359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float DeformNode(Transform T, Vector3 originalLocalPos, Quaternion originalLocalRot, Vector3 contactPoint, Vector3 contactVelocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalLocalPos;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalLocalRot;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactPoint;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactVelocity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeformNode_Private_Single_Transform_Vector3_Quaternion_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector3 AnglesToVector(Vector3 Angles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Angles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnglesToVector_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115361, RefRangeEnd = 115362, XrefRangeStart = 115360, XrefRangeEnd = 115361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float DeformColliders(Vector3 contactPoint, Vector3 impactVelocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&contactPoint);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &impactVelocity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeformColliders_Private_Single_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115368, RefRangeEnd = 115369, XrefRangeStart = 115362, XrefRangeEnd = 115368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessRepair()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRepair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115379, RefRangeEnd = 115380, XrefRangeStart = 115369, XrefRangeEnd = 115379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RepairMesh(Mesh mesh, Il2CppStructArray<Vector3> originalMesh, float repairRate, float repairedThreshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(originalMesh);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &repairRate;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &repairedThreshold;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RepairMesh_Private_Boolean_Mesh_ArrayOf_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115397, RefRangeEnd = 115398, XrefRangeStart = 115380, XrefRangeEnd = 115397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RepairNode(Transform T, Vector3 originalLocalPosition, Quaternion originalLocalRotation, float repairRate, float repairedThreshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalLocalPosition;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &originalLocalRotation;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &repairRate;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &repairedThreshold;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RepairNode_Private_Boolean_Transform_Vector3_Quaternion_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115398, XrefRangeEnd = 115406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreMeshes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreMeshes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115410, RefRangeEnd = 115412, XrefRangeStart = 115406, XrefRangeEnd = 115410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreNodes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreNodes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115436, RefRangeEnd = 115438, XrefRangeStart = 115412, XrefRangeEnd = 115436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreColliders()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreColliders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115438, XrefRangeEnd = 115441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPDamage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPDamage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPDamage()
	{
		Il2CppClassPointerStore<VPDamage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPDamage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPDamage>.NativeClassPtr);
		NativeFieldInfoPtr_meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "meshes");
		NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "colliders");
		NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "nodes");
		NativeFieldInfoPtr_minVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "minVelocity");
		NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "multiplier");
		NativeFieldInfoPtr_damageRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "damageRadius");
		NativeFieldInfoPtr_maxDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "maxDisplacement");
		NativeFieldInfoPtr_maxVertexFracture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "maxVertexFracture");
		NativeFieldInfoPtr_nodeDamageRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "nodeDamageRadius");
		NativeFieldInfoPtr_maxNodeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "maxNodeRotation");
		NativeFieldInfoPtr_nodeRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "nodeRotationRate");
		NativeFieldInfoPtr_vertexRepairRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "vertexRepairRate");
		NativeFieldInfoPtr_enableRepairKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "enableRepairKey");
		NativeFieldInfoPtr_repairKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "repairKey");
		NativeFieldInfoPtr_m_originalMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_originalMeshes");
		NativeFieldInfoPtr_m_originalColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_originalColliders");
		NativeFieldInfoPtr_m_originalNodePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_originalNodePositions");
		NativeFieldInfoPtr_m_originalNodeRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_originalNodeRotations");
		NativeFieldInfoPtr_m_repairing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_repairing");
		NativeFieldInfoPtr_m_meshDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_meshDamage");
		NativeFieldInfoPtr_m_colliderDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_colliderDamage");
		NativeFieldInfoPtr_m_nodeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, "m_nodeDamage");
		NativeMethodInfoPtr_get_isRepairing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670552);
		NativeMethodInfoPtr_get_meshDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670553);
		NativeMethodInfoPtr_get_colliderDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670554);
		NativeMethodInfoPtr_get_nodeDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670555);
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670556);
		NativeMethodInfoPtr_OnDisableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670557);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670558);
		NativeMethodInfoPtr_Repair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670559);
		NativeMethodInfoPtr_ProcessImpact_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670560);
		NativeMethodInfoPtr_DeformMesh_Private_Single_Mesh_ArrayOf_Vector3_Transform_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670561);
		NativeMethodInfoPtr_DeformNode_Private_Single_Transform_Vector3_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670562);
		NativeMethodInfoPtr_AnglesToVector_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670563);
		NativeMethodInfoPtr_DeformColliders_Private_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670564);
		NativeMethodInfoPtr_ProcessRepair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670565);
		NativeMethodInfoPtr_RepairMesh_Private_Boolean_Mesh_ArrayOf_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670566);
		NativeMethodInfoPtr_RepairNode_Private_Boolean_Transform_Vector3_Quaternion_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670567);
		NativeMethodInfoPtr_RestoreMeshes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670568);
		NativeMethodInfoPtr_RestoreNodes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670569);
		NativeMethodInfoPtr_RestoreColliders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670570);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDamage>.NativeClassPtr, 100670571);
	}

	public VPDamage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
