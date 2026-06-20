using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPLiquidCargo : MonoBehaviour
{
	public enum TankerShape
	{
		Sphere,
		Cylinder,
		Box,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TankerShape>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static TankerShape()
		{
			Il2CppClassPointerStore<TankerShape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "TankerShape");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tankerShape;

	private static readonly System.IntPtr NativeFieldInfoPtr_tankerSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCargoMass;

	private static readonly System.IntPtr NativeFieldInfoPtr_viscosityFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_fillLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_parentRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_anchorPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_joint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_limit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_drive;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureJointAndBody_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainerRadius_Public_Static_Single_TankerShape_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EllipseRadius_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EllipseHorizontalSemiChord_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectangleRadius_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EllipsoidRadius_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BoxRadius_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CylinderRadius_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr));

	public unsafe TankerShape tankerShape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tankerShape);
			return *(TankerShape*)num;
		}
		set
		{
			*(TankerShape*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tankerShape)) = tankerShape;
		}
	}

	public unsafe Vector3 tankerSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tankerSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tankerSize)) = vector;
		}
	}

	public unsafe float maxCargoMass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCargoMass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCargoMass)) = num;
		}
	}

	public unsafe float viscosityFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viscosityFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viscosityFactor)) = num;
		}
	}

	public unsafe float fillLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fillLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fillLevel)) = num;
		}
	}

	public unsafe Rigidbody m_rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rigidbody m_parentRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parentRigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parentRigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_anchorPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_anchorPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_anchorPosition)) = vector;
		}
	}

	public unsafe Vector3 m_originalPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalPosition)) = vector;
		}
	}

	public unsafe Quaternion m_originalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRotation)) = quaternion;
		}
	}

	public unsafe ConfigurableJoint m_joint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_joint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ConfigurableJoint(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_joint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoftJointLimit m_limit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_limit);
			return *(SoftJointLimit*)num;
		}
		set
		{
			*(SoftJointLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_limit)) = softJointLimit;
		}
	}

	public unsafe JointDrive m_drive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_drive);
			return *(JointDrive*)num;
		}
		set
		{
			*(JointDrive*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_drive)) = jointDrive;
		}
	}

	public unsafe Vector3 localPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110022, XrefRangeEnd = 110054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110054, XrefRangeEnd = 110106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110106, XrefRangeEnd = 110149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110149, XrefRangeEnd = 110192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110192, XrefRangeEnd = 110287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 110331, RefRangeEnd = 110334, XrefRangeStart = 110287, XrefRangeEnd = 110331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureJointAndBody()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureJointAndBody_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 110356, RefRangeEnd = 110358, XrefRangeStart = 110334, XrefRangeEnd = 110356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ContainerRadius(TankerShape tankerShape, Vector3 semiAxes, Vector3 direction, float fillLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&tankerShape);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &semiAxes;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fillLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainerRadius_Public_Static_Single_TankerShape_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110358, XrefRangeEnd = 110362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float EllipseRadius(float a, float b, float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EllipseRadius_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110362, XrefRangeEnd = 110364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float EllipseHorizontalSemiChord(float a, float b, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EllipseHorizontalSemiChord_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110372, RefRangeEnd = 110377, XrefRangeStart = 110364, XrefRangeEnd = 110372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RectangleRadius(float a, float b, float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectangleRadius_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110377, XrefRangeEnd = 110380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float EllipsoidRadius(Vector3 semiAxes, Vector3 dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&semiAxes);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EllipsoidRadius_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110380, XrefRangeEnd = 110384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float BoxRadius(Vector3 semiAxes, Vector3 dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&semiAxes);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BoxRadius_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110384, XrefRangeEnd = 110391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CylinderRadius(Vector3 semiAxes, Vector3 dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&semiAxes);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CylinderRadius_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110391, XrefRangeEnd = 110394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPLiquidCargo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPLiquidCargo()
	{
		Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPLiquidCargo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr);
		NativeFieldInfoPtr_tankerShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "tankerShape");
		NativeFieldInfoPtr_tankerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "tankerSize");
		NativeFieldInfoPtr_maxCargoMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "maxCargoMass");
		NativeFieldInfoPtr_viscosityFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "viscosityFactor");
		NativeFieldInfoPtr_fillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "fillLevel");
		NativeFieldInfoPtr_m_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_rigidbody");
		NativeFieldInfoPtr_m_parentRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_parentRigidbody");
		NativeFieldInfoPtr_m_anchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_anchorPosition");
		NativeFieldInfoPtr_m_originalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_originalPosition");
		NativeFieldInfoPtr_m_originalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_originalRotation");
		NativeFieldInfoPtr_m_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_joint");
		NativeFieldInfoPtr_m_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_limit");
		NativeFieldInfoPtr_m_drive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, "m_drive");
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670255);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670256);
		NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670257);
		NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670258);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670259);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670260);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670261);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670262);
		NativeMethodInfoPtr_ConfigureJointAndBody_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670263);
		NativeMethodInfoPtr_ContainerRadius_Public_Static_Single_TankerShape_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670264);
		NativeMethodInfoPtr_EllipseRadius_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670265);
		NativeMethodInfoPtr_EllipseHorizontalSemiChord_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670266);
		NativeMethodInfoPtr_RectangleRadius_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670267);
		NativeMethodInfoPtr_EllipsoidRadius_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670268);
		NativeMethodInfoPtr_BoxRadius_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670269);
		NativeMethodInfoPtr_CylinderRadius_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670270);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPLiquidCargo>.NativeClassPtr, 100670271);
	}

	public VPLiquidCargo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
