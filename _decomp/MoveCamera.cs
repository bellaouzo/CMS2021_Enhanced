using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MoveComplete;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Void_Vector3_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopMove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Move_b__2_0_Private_Void_Object_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr));

	public unsafe bool MoveComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveComplete)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18064, XrefRangeEnd = 18100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Move(Vector3 from, Vector3 to, Vector3 rot, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&from);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Move_Public_Void_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18100, XrefRangeEnd = 18110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MoveCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18110, XrefRangeEnd = 18116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Move_b__2_0(Il2CppSystem.Object x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Move_b__2_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MoveCamera()
	{
		Il2CppClassPointerStore<MoveCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MoveCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr);
		NativeFieldInfoPtr_MoveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr, "MoveComplete");
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_Move_Public_Void_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_StopMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr__Move_b__2_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveCamera>.NativeClassPtr, 100664628);
	}

	public MoveCamera(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
