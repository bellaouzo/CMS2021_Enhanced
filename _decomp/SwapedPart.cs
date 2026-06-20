using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class SwapedPart : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pathToItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_newPartName;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewPartName_Public_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr));

	public unsafe string pathToItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathToItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathToItem), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string newPartName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newPartName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newPartName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 93336, RefRangeEnd = 93418, XrefRangeStart = 93336, XrefRangeEnd = 93336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SwapedPart(string _pathToItem, string _newPartName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_pathToItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_newPartName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe string GetPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe string GetNewPartName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewPartName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static SwapedPart()
	{
		Il2CppClassPointerStore<SwapedPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SwapedPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr);
		NativeFieldInfoPtr_pathToItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr, "pathToItem");
		NativeFieldInfoPtr_newPartName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr, "newPartName");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr, 100668685);
		NativeMethodInfoPtr_GetPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr, 100668686);
		NativeMethodInfoPtr_GetNewPartName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapedPart>.NativeClassPtr, 100668687);
	}

	public SwapedPart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
