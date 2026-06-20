using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class GravityModifier : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_g;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr));

	public unsafe float g
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g)) = num;
		}
	}

	public unsafe Vector3 direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = vector;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117146, XrefRangeEnd = 117158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117158, XrefRangeEnd = 117163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GravityModifier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GravityModifier()
	{
		Il2CppClassPointerStore<GravityModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GravityModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr);
		NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr, "g");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr, "direction");
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr, 100670703);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GravityModifier>.NativeClassPtr, 100670704);
	}

	public GravityModifier(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
