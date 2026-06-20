using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class LeanTest : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_expected;

	private static readonly System.IntPtr NativeFieldInfoPtr_tests;

	private static readonly System.IntPtr NativeFieldInfoPtr_passes;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeoutStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_testsFinished;

	private static readonly System.IntPtr NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_formatB_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_overview_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanTest>.NativeClassPtr));

	public unsafe static int expected
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_expected, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_expected, &num);
		}
	}

	public unsafe static int tests
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tests, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tests, &num);
		}
	}

	public unsafe static int passes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_passes, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_passes, &num);
		}
	}

	public unsafe static float timeout
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeout, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeout, &num);
		}
	}

	public unsafe static bool timeoutStarted
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeoutStarted, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeoutStarted, &flag);
		}
	}

	public unsafe static bool testsFinished
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_testsFinished, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_testsFinished, &flag);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6216, XrefRangeEnd = 6220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void debug(string name, bool didPass, string failExplaination = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &didPass;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(failExplaination);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 6337, RefRangeEnd = 6390, XrefRangeStart = 6220, XrefRangeEnd = 6337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void expect(bool didPass, string definition, string failExplaination = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&didPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(definition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(failExplaination);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6390, XrefRangeEnd = 6401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string padRight(int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&len);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6409, RefRangeEnd = 6410, XrefRangeStart = 6401, XrefRangeEnd = 6409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float printOutLength(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6419, RefRangeEnd = 6421, XrefRangeStart = 6410, XrefRangeEnd = 6419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string formatBC(string str, string color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6421, XrefRangeEnd = 6426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string formatB(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_formatB_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6460, RefRangeEnd = 6462, XrefRangeStart = 6426, XrefRangeEnd = 6460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string formatC(string str, string color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6545, RefRangeEnd = 6546, XrefRangeStart = 6462, XrefRangeEnd = 6545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void overview()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_overview_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LeanTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LeanTest()
	{
		Il2CppClassPointerStore<LeanTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTest>.NativeClassPtr);
		NativeFieldInfoPtr_expected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "expected");
		NativeFieldInfoPtr_tests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "tests");
		NativeFieldInfoPtr_passes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "passes");
		NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "timeout");
		NativeFieldInfoPtr_timeoutStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "timeoutStarted");
		NativeFieldInfoPtr_testsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "testsFinished");
		NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_formatB_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_overview_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663908);
	}

	public LeanTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
