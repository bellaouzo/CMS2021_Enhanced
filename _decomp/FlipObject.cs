using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class FlipObject : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_parentNegativeX;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentParentNegativeX;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentNegativeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentNegativeZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_X;

	private static readonly System.IntPtr NativeFieldInfoPtr_Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z;

	private static readonly System.IntPtr NativeMethodInfoPtr_Flip_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Check_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FlipObject>.NativeClassPtr));

	public unsafe bool parentNegativeX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentNegativeX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentNegativeX)) = flag;
		}
	}

	public unsafe bool parentParentNegativeX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentParentNegativeX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentParentNegativeX)) = flag;
		}
	}

	public unsafe bool parentNegativeY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentNegativeY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentNegativeY)) = flag;
		}
	}

	public unsafe bool parentNegativeZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentNegativeZ);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentNegativeZ)) = flag;
		}
	}

	public unsafe bool X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_X);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_X)) = flag;
		}
	}

	public unsafe bool Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Y);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Y)) = flag;
		}
	}

	public unsafe bool Z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Z);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Z)) = flag;
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 44119, RefRangeEnd = 44123, XrefRangeStart = 44083, XrefRangeEnd = 44119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Flip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Flip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44174, RefRangeEnd = 44175, XrefRangeStart = 44123, XrefRangeEnd = 44174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Check()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44175, XrefRangeEnd = 44176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe FlipObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlipObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FlipObject()
	{
		Il2CppClassPointerStore<FlipObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FlipObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlipObject>.NativeClassPtr);
		NativeFieldInfoPtr_parentNegativeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "parentNegativeX");
		NativeFieldInfoPtr_parentParentNegativeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "parentParentNegativeX");
		NativeFieldInfoPtr_parentNegativeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "parentNegativeY");
		NativeFieldInfoPtr_parentNegativeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "parentNegativeZ");
		NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "X");
		NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "Y");
		NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, "Z");
		NativeMethodInfoPtr_Flip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, 100665984);
		NativeMethodInfoPtr_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, 100665985);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, 100665986);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlipObject>.NativeClassPtr, 100665987);
	}

	public FlipObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
