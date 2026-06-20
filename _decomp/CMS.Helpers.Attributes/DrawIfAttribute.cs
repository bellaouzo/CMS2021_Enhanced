using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Helpers.Attributes;

public class DrawIfAttribute : PropertyAttribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__ComparedPropertyName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ComparedValue_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DisablingType_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ComparedPropertyName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ComparedValue_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DisablingType_Public_get_DisablingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_DisablingType_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr));

	public unsafe string _ComparedPropertyName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ComparedPropertyName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ComparedPropertyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool _ComparedValue_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ComparedValue_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ComparedValue_k__BackingField)) = flag;
		}
	}

	public unsafe DisablingType _DisablingType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisablingType_k__BackingField);
			return *(DisablingType*)num;
		}
		set
		{
			*(DisablingType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisablingType_k__BackingField)) = disablingType;
		}
	}

	public unsafe string ComparedPropertyName
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ComparedPropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	public unsafe bool ComparedValue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ComparedValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe DisablingType DisablingType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisablingType_Public_get_DisablingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(DisablingType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	public unsafe DrawIfAttribute(string comparedPropertyName, bool comparedValue, [Optional] DisablingType disablingType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(comparedPropertyName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &comparedValue;
		*(DisablingType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &disablingType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_DisablingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DrawIfAttribute()
	{
		Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers.Attributes", "DrawIfAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__ComparedPropertyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, "<ComparedPropertyName>k__BackingField");
		NativeFieldInfoPtr__ComparedValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, "<ComparedValue>k__BackingField");
		NativeFieldInfoPtr__DisablingType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, "<DisablingType>k__BackingField");
		NativeMethodInfoPtr_get_ComparedPropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, 100679483);
		NativeMethodInfoPtr_get_ComparedValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, 100679484);
		NativeMethodInfoPtr_get_DisablingType_Public_get_DisablingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, 100679485);
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_DisablingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawIfAttribute>.NativeClassPtr, 100679486);
	}

	public DrawIfAttribute(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
