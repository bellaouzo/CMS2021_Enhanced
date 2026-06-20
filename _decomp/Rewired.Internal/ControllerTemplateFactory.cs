using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Rewired.Internal;

public static class ControllerTemplateFactory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateInterfaceTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr__userTemplateTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr__userTemplateInterfaceTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_templateTypes_Public_Static_get_ArrayOf_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_ArrayOf_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUser_Private_Static_IControllerTemplate_Guid_Object_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr));

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateTypes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultTemplateTypes, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultTemplateTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateInterfaceTypes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultTemplateInterfaceTypes, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> _userTemplateTypes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__userTemplateTypes, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__userTemplateTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> _userTemplateInterfaceTypes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__userTemplateInterfaceTypes, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__userTemplateInterfaceTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> templateTypes
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131189, XrefRangeEnd = 131193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_templateTypes_Public_Static_get_ArrayOf_Type_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Type>(intPtr) : null;
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> templateInterfaceTypes
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131193, XrefRangeEnd = 131197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_ArrayOf_Type_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Type>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131197, XrefRangeEnd = 131209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IControllerTemplate Create(Il2CppSystem.Guid typeGuid, Il2CppSystem.Object payload)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typeGuid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(payload);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr == (System.IntPtr)0) ? ((IControllerTemplate)null) : new IControllerTemplate(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131209, XrefRangeEnd = 131218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IControllerTemplate CreateUser(Il2CppSystem.Guid typeGuid, Il2CppSystem.Object payload)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typeGuid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(payload);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUser_Private_Static_IControllerTemplate_Guid_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr == (System.IntPtr)0) ? ((IControllerTemplate)null) : new IControllerTemplate(intPtr);
	}

	static ControllerTemplateFactory()
	{
		Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Rewired.Internal", "ControllerTemplateFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr);
		NativeFieldInfoPtr__defaultTemplateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_defaultTemplateTypes");
		NativeFieldInfoPtr__defaultTemplateInterfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_defaultTemplateInterfaceTypes");
		NativeFieldInfoPtr__userTemplateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_userTemplateTypes");
		NativeFieldInfoPtr__userTemplateInterfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_userTemplateInterfaceTypes");
		NativeMethodInfoPtr_get_templateTypes_Public_Static_get_ArrayOf_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100672061);
		NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_ArrayOf_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100672062);
		NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100672063);
		NativeMethodInfoPtr_CreateUser_Private_Static_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100672064);
	}

	public ControllerTemplateFactory(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
