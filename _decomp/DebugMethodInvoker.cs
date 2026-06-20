using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class DebugMethodInvoker : Il2CppSystem.Object
{
	[ObfuscatedName("DebugMethodInvoker/<>c__DisplayClass2_0")]
	public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_methodName;

		private static readonly System.IntPtr NativeFieldInfoPtr_paramsCount;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetMethodInfoFromType_b__0_Internal_Boolean_MethodInfo_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr));

		public unsafe string methodName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe int paramsCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramsCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramsCount)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _GetMethodInfoFromType_b__0(MethodInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetMethodInfoFromType_b__0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr, "<>c__DisplayClass2_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr);
			NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "methodName");
			NativeFieldInfoPtr_paramsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "paramsCount");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100668830);
			NativeMethodInfoPtr__GetMethodInfoFromType_b__0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100668831);
		}

		public __c__DisplayClass2_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeFromString_Public_Static_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoFromType_Public_Static_MethodInfo_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoFromType_Public_Static_MethodInfo_Type_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMethod_Public_Static_Void_MethodInfo_Object_ArrayOf_Object_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95324, RefRangeEnd = 95326, XrefRangeStart = 95310, XrefRangeEnd = 95324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetTypeFromString(string typeName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeFromString_Public_Static_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Type(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static MethodInfo GetMethodInfoFromType(Il2CppSystem.Type type, string methodName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodInfoFromType_Public_Static_MethodInfo_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new MethodInfo(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95326, XrefRangeEnd = 95339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MethodInfo GetMethodInfoFromType(Il2CppSystem.Type type, string methodName, int paramsCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &paramsCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodInfoFromType_Public_Static_MethodInfo_Type_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new MethodInfo(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static void InvokeMethod(MethodInfo methodInfo, Il2CppSystem.Object instance, Il2CppReferenceArray<Il2CppSystem.Object> param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(instance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(param);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeMethod_Public_Static_Void_MethodInfo_Object_ArrayOf_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DebugMethodInvoker()
	{
		Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DebugMethodInvoker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr);
		NativeMethodInfoPtr_GetTypeFromString_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr, 100668826);
		NativeMethodInfoPtr_GetMethodInfoFromType_Public_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr, 100668827);
		NativeMethodInfoPtr_GetMethodInfoFromType_Public_Static_MethodInfo_Type_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr, 100668828);
		NativeMethodInfoPtr_InvokeMethod_Public_Static_Void_MethodInfo_Object_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMethodInvoker>.NativeClassPtr, 100668829);
	}

	public DebugMethodInvoker(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
