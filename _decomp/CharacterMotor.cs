using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
	[System.Serializable]
	public class CharacterMotorMovement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_maxForwardSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSidewaysSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxBackwardsSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_slopeSpeedMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxGroundAcceleration;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxAirAcceleration;

		private static readonly System.IntPtr NativeFieldInfoPtr_gravity;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxFallSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_collisionFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_frameVelocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_hitPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastHitPoint;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr));

		public unsafe float maxForwardSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxForwardSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxForwardSpeed)) = num;
			}
		}

		public unsafe float maxSidewaysSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSidewaysSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSidewaysSpeed)) = num;
			}
		}

		public unsafe float maxBackwardsSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBackwardsSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBackwardsSpeed)) = num;
			}
		}

		public unsafe AnimationCurve slopeSpeedMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeSpeedMultiplier);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AnimationCurve(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeSpeedMultiplier), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float maxGroundAcceleration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxGroundAcceleration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxGroundAcceleration)) = num;
			}
		}

		public unsafe float maxAirAcceleration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAirAcceleration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAirAcceleration)) = num;
			}
		}

		public unsafe float gravity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity)) = num;
			}
		}

		public unsafe float maxFallSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFallSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFallSpeed)) = num;
			}
		}

		public unsafe CollisionFlags collisionFlags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionFlags);
				return *(CollisionFlags*)num;
			}
			set
			{
				*(CollisionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionFlags)) = collisionFlags;
			}
		}

		public unsafe Vector3 velocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = vector;
			}
		}

		public unsafe Vector3 frameVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameVelocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameVelocity)) = vector;
			}
		}

		public unsafe Vector3 hitPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitPoint);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitPoint)) = vector;
			}
		}

		public unsafe Vector3 lastHitPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHitPoint);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHitPoint)) = vector;
			}
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42366, RefRangeEnd = 42367, XrefRangeStart = 42354, XrefRangeEnd = 42366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterMotorMovement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CharacterMotorMovement()
		{
			Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "CharacterMotorMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr);
			NativeFieldInfoPtr_maxForwardSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "maxForwardSpeed");
			NativeFieldInfoPtr_maxSidewaysSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "maxSidewaysSpeed");
			NativeFieldInfoPtr_maxBackwardsSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "maxBackwardsSpeed");
			NativeFieldInfoPtr_slopeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "slopeSpeedMultiplier");
			NativeFieldInfoPtr_maxGroundAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "maxGroundAcceleration");
			NativeFieldInfoPtr_maxAirAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "maxAirAcceleration");
			NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "gravity");
			NativeFieldInfoPtr_maxFallSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "maxFallSpeed");
			NativeFieldInfoPtr_collisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "collisionFlags");
			NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "velocity");
			NativeFieldInfoPtr_frameVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "frameVelocity");
			NativeFieldInfoPtr_hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "hitPoint");
			NativeFieldInfoPtr_lastHitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, "lastHitPoint");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotorMovement>.NativeClassPtr, 100665826);
		}

		public CharacterMotorMovement(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public enum MovementTransferOnJump
	{
		None,
		InitTransfer,
		PermaTransfer,
		PermaLocked,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MovementTransferOnJump>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static MovementTransferOnJump()
		{
			Il2CppClassPointerStore<MovementTransferOnJump>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "MovementTransferOnJump");
		}

	}

	[System.Serializable]
	public class CharacterMotorJumping : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_extraHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_perpAmount;

		private static readonly System.IntPtr NativeFieldInfoPtr_steepPerpAmount;

		private static readonly System.IntPtr NativeFieldInfoPtr_jumping;

		private static readonly System.IntPtr NativeFieldInfoPtr_holdingJumpButton;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastStartTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastButtonDownTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_jumpDir;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr));

		public unsafe bool enabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
			}
		}

		public unsafe float baseHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseHeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseHeight)) = num;
			}
		}

		public unsafe float extraHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraHeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraHeight)) = num;
			}
		}

		public unsafe float perpAmount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perpAmount);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perpAmount)) = num;
			}
		}

		public unsafe float steepPerpAmount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steepPerpAmount);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steepPerpAmount)) = num;
			}
		}

		public unsafe bool jumping
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumping);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumping)) = flag;
			}
		}

		public unsafe bool holdingJumpButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdingJumpButton);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdingJumpButton)) = flag;
			}
		}

		public unsafe float lastStartTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStartTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastStartTime)) = num;
			}
		}

		public unsafe float lastButtonDownTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastButtonDownTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastButtonDownTime)) = num;
			}
		}

		public unsafe Vector3 jumpDir
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpDir);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpDir)) = vector;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42367, XrefRangeEnd = 42369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterMotorJumping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CharacterMotorJumping()
		{
			Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "CharacterMotorJumping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr);
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_baseHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "baseHeight");
			NativeFieldInfoPtr_extraHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "extraHeight");
			NativeFieldInfoPtr_perpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "perpAmount");
			NativeFieldInfoPtr_steepPerpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "steepPerpAmount");
			NativeFieldInfoPtr_jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "jumping");
			NativeFieldInfoPtr_holdingJumpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "holdingJumpButton");
			NativeFieldInfoPtr_lastStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "lastStartTime");
			NativeFieldInfoPtr_lastButtonDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "lastButtonDownTime");
			NativeFieldInfoPtr_jumpDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, "jumpDir");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotorJumping>.NativeClassPtr, 100665827);
		}

		public CharacterMotorJumping(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class CharacterMotorMovingPlatform : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_movementTransfer;

		private static readonly System.IntPtr NativeFieldInfoPtr_hitPlatform;

		private static readonly System.IntPtr NativeFieldInfoPtr_activePlatform;

		private static readonly System.IntPtr NativeFieldInfoPtr_activeLocalPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_activeGlobalPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_activeLocalRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_activeGlobalRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastMatrix;

		private static readonly System.IntPtr NativeFieldInfoPtr_platformVelocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_newPlatform;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr));

		public unsafe bool enabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
			}
		}

		public unsafe MovementTransferOnJump movementTransfer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementTransfer);
				return *(MovementTransferOnJump*)num;
			}
			set
			{
				*(MovementTransferOnJump*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementTransfer)) = movementTransferOnJump;
			}
		}

		public unsafe Transform hitPlatform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitPlatform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitPlatform), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Transform activePlatform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activePlatform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activePlatform), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector3 activeLocalPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeLocalPoint);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeLocalPoint)) = vector;
			}
		}

		public unsafe Vector3 activeGlobalPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeGlobalPoint);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeGlobalPoint)) = vector;
			}
		}

		public unsafe Quaternion activeLocalRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeLocalRotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeLocalRotation)) = quaternion;
			}
		}

		public unsafe Quaternion activeGlobalRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeGlobalRotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeGlobalRotation)) = quaternion;
			}
		}

		public unsafe Matrix4x4 lastMatrix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMatrix);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMatrix)) = matrix4x;
			}
		}

		public unsafe Vector3 platformVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformVelocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_platformVelocity)) = vector;
			}
		}

		public unsafe bool newPlatform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newPlatform);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newPlatform)) = flag;
			}
		}

		[CallerCount(0)]
		public unsafe CharacterMotorMovingPlatform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CharacterMotorMovingPlatform()
		{
			Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "CharacterMotorMovingPlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr);
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_movementTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "movementTransfer");
			NativeFieldInfoPtr_hitPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "hitPlatform");
			NativeFieldInfoPtr_activePlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "activePlatform");
			NativeFieldInfoPtr_activeLocalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "activeLocalPoint");
			NativeFieldInfoPtr_activeGlobalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "activeGlobalPoint");
			NativeFieldInfoPtr_activeLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "activeLocalRotation");
			NativeFieldInfoPtr_activeGlobalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "activeGlobalRotation");
			NativeFieldInfoPtr_lastMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "lastMatrix");
			NativeFieldInfoPtr_platformVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "platformVelocity");
			NativeFieldInfoPtr_newPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, "newPlatform");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotorMovingPlatform>.NativeClassPtr, 100665828);
		}

		public CharacterMotorMovingPlatform(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class CharacterMotorSliding : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_slidingSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_sidewaysControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_speedControl;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr));

		public unsafe bool enabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
			}
		}

		public unsafe float slidingSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slidingSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slidingSpeed)) = num;
			}
		}

		public unsafe float sidewaysControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sidewaysControl);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sidewaysControl)) = num;
			}
		}

		public unsafe float speedControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedControl);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedControl)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe CharacterMotorSliding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CharacterMotorSliding()
		{
			Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "CharacterMotorSliding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr);
			NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr, "enabled");
			NativeFieldInfoPtr_slidingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr, "slidingSpeed");
			NativeFieldInfoPtr_sidewaysControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr, "sidewaysControl");
			NativeFieldInfoPtr_speedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr, "speedControl");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotorSliding>.NativeClassPtr, 100665829);
		}

		public CharacterMotorSliding(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CharacterMotor/<SubtractNewPlatformVelocity>d__27")]
	public sealed class _SubtractNewPlatformVelocity_d__27 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__platform_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr));

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

		public unsafe CharacterMotor __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CharacterMotor(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Transform _platform_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__platform_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__platform_5__2), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _SubtractNewPlatformVelocity_d__27(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42369, XrefRangeEnd = 42393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42393, XrefRangeEnd = 42398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _SubtractNewPlatformVelocity_d__27()
		{
			Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "<SubtractNewPlatformVelocity>d__27");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__platform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, "<platform>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, 100665830);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, 100665831);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, 100665832);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, 100665833);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, 100665834);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SubtractNewPlatformVelocity_d__27>.NativeClassPtr, 100665835);
		}

		public _SubtractNewPlatformVelocity_d__27(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_canControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_useFixedUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMoveDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_movement;

	private static readonly System.IntPtr NativeFieldInfoPtr_jumping;

	private static readonly System.IntPtr NativeFieldInfoPtr_movingPlatform;

	private static readonly System.IntPtr NativeFieldInfoPtr_sliding;

	private static readonly System.IntPtr NativeFieldInfoPtr_grounded;

	private static readonly System.IntPtr NativeFieldInfoPtr_groundNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_groundType;

	private static readonly System.IntPtr NativeFieldInfoPtr_tr;

	private static readonly System.IntPtr NativeFieldInfoPtr_controller;

	private static readonly System.IntPtr NativeFieldInfoPtr_ray;

	private static readonly System.IntPtr NativeFieldInfoPtr_results;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFunction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInputVelocityChange_Private_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyGravityAndJumping_Private_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubtractNewPlatformVelocity_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveWithPlatform_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDesiredHorizontalVelocity_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustGroundVelocityToNormal_Private_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGroundedTest_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxAcceleration_Private_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateJumpVerticalSpeed_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsJumping_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSliding_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTouchingCeiling_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGrounded_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TooSteep_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirection_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControllable_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxSpeedInDirection_Private_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr));

	public unsafe bool canControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canControl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canControl)) = flag;
		}
	}

	public unsafe bool useFixedUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFixedUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFixedUpdate)) = flag;
		}
	}

	public unsafe Vector3 inputMoveDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMoveDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMoveDirection)) = vector;
		}
	}

	public unsafe bool inputJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputJump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputJump)) = flag;
		}
	}

	public unsafe CharacterMotorMovement movement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterMotorMovement(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterMotorJumping jumping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumping);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterMotorJumping(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumping), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterMotorMovingPlatform movingPlatform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movingPlatform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterMotorMovingPlatform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movingPlatform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterMotorSliding sliding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sliding);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterMotorSliding(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sliding), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool grounded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grounded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grounded)) = flag;
		}
	}

	public unsafe Vector3 groundNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundNormal)) = vector;
		}
	}

	public unsafe GroundType groundType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundType);
			return *(GroundType*)num;
		}
		set
		{
			*(GroundType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundType)) = groundType;
		}
	}

	public unsafe Transform tr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tr), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterController controller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CharacterController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Il2CppStructArray<RaycastHit> results
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_results);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<RaycastHit>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42398, XrefRangeEnd = 42403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42519, RefRangeEnd = 42521, XrefRangeStart = 42403, XrefRangeEnd = 42519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFunction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFunction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42521, XrefRangeEnd = 42543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42543, XrefRangeEnd = 42544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42563, RefRangeEnd = 42564, XrefRangeStart = 42544, XrefRangeEnd = 42563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&velocity);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyInputVelocityChange_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42591, RefRangeEnd = 42592, XrefRangeStart = 42564, XrefRangeEnd = 42591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&velocity);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyGravityAndJumping_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42609, RefRangeEnd = 42610, XrefRangeStart = 42592, XrefRangeEnd = 42609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42610, XrefRangeEnd = 42613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator SubtractNewPlatformVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubtractNewPlatformVelocity_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42625, RefRangeEnd = 42627, XrefRangeStart = 42613, XrefRangeEnd = 42625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MoveWithPlatform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveWithPlatform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42635, RefRangeEnd = 42636, XrefRangeStart = 42627, XrefRangeEnd = 42635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetDesiredHorizontalVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDesiredHorizontalVelocity_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42643, RefRangeEnd = 42644, XrefRangeStart = 42636, XrefRangeEnd = 42643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hVelocity);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &groundNormal;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustGroundVelocityToNormal_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsGroundedTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGroundedTest_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetMaxAcceleration(bool grounded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&grounded);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxAcceleration_Private_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42644, RefRangeEnd = 42645, XrefRangeStart = 42644, XrefRangeEnd = 42644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetJumpHeight);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateJumpVerticalSpeed_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsJumping()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsJumping_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42645, XrefRangeEnd = 42646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSliding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSliding_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsTouchingCeiling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTouchingCeiling_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsGrounded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 42649, RefRangeEnd = 42652, XrefRangeStart = 42646, XrefRangeEnd = 42649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TooSteep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TooSteep_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector3 GetDirection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetControllable(bool controllable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controllable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControllable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42660, RefRangeEnd = 42661, XrefRangeStart = 42652, XrefRangeEnd = 42660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&desiredMovementDirection);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxSpeedInDirection_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42661, XrefRangeEnd = 42666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVelocity(Vector3 velocity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&velocity);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42666, XrefRangeEnd = 42691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterMotor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CharacterMotor()
	{
		Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CharacterMotor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr);
		NativeFieldInfoPtr_canControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "canControl");
		NativeFieldInfoPtr_useFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "useFixedUpdate");
		NativeFieldInfoPtr_inputMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "inputMoveDirection");
		NativeFieldInfoPtr_inputJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "inputJump");
		NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "movement");
		NativeFieldInfoPtr_jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "jumping");
		NativeFieldInfoPtr_movingPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "movingPlatform");
		NativeFieldInfoPtr_sliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "sliding");
		NativeFieldInfoPtr_grounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "grounded");
		NativeFieldInfoPtr_groundNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "groundNormal");
		NativeFieldInfoPtr_groundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "groundType");
		NativeFieldInfoPtr_tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "tr");
		NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "controller");
		NativeFieldInfoPtr_ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "ray");
		NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, "results");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665802);
		NativeMethodInfoPtr_UpdateFunction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665803);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665804);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665805);
		NativeMethodInfoPtr_ApplyInputVelocityChange_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665806);
		NativeMethodInfoPtr_ApplyGravityAndJumping_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665807);
		NativeMethodInfoPtr_UpdateSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665808);
		NativeMethodInfoPtr_SubtractNewPlatformVelocity_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665809);
		NativeMethodInfoPtr_MoveWithPlatform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665810);
		NativeMethodInfoPtr_GetDesiredHorizontalVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665811);
		NativeMethodInfoPtr_AdjustGroundVelocityToNormal_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_IsGroundedTest_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_GetMaxAcceleration_Private_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_CalculateJumpVerticalSpeed_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_IsJumping_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_IsSliding_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_IsTouchingCeiling_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_IsGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_TooSteep_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_GetDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_SetControllable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_MaxSpeedInDirection_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_SetVelocity_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMotor>.NativeClassPtr, 100665825);
	}

	public CharacterMotor(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
