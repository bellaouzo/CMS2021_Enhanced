using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.CarEditor.Tabs;

public class SuspensionEditorTab : BaseTab
{
	[ObfuscatedName("CMS.CarEditor.Tabs.SuspensionEditorTab/<>c__DisplayClass1_0")]
	public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__2_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__3_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__4_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__5_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__14_Internal_Void_String_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr));

		public unsafe CarLoaderExtended carLoader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarLoaderExtended(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass1_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225990, XrefRangeEnd = 225997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__0(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225997, XrefRangeEnd = 226010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__1(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226010, XrefRangeEnd = 226023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__2(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__2_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226023, XrefRangeEnd = 226030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__3(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__3_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226030, XrefRangeEnd = 226037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__4(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__4_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226037, XrefRangeEnd = 226044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__5(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__5_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226044, XrefRangeEnd = 226057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__6(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226057, XrefRangeEnd = 226070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__7(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226070, XrefRangeEnd = 226083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__8(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226083, XrefRangeEnd = 226096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__9(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226096, XrefRangeEnd = 226109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__10(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226109, XrefRangeEnd = 226122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__11(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226122, XrefRangeEnd = 226135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__12(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226135, XrefRangeEnd = 226148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__13(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226148, XrefRangeEnd = 226161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__14(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__14_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass1_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr, "<>c__DisplayClass1_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr);
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "carLoader");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680241);
			NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680242);
			NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680243);
			NativeMethodInfoPtr__Generate_b__2_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680244);
			NativeMethodInfoPtr__Generate_b__3_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680245);
			NativeMethodInfoPtr__Generate_b__4_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680246);
			NativeMethodInfoPtr__Generate_b__5_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680247);
			NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680248);
			NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680249);
			NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680250);
			NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680251);
			NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680252);
			NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680253);
			NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680254);
			NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680255);
			NativeMethodInfoPtr__Generate_b__14_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680256);
		}

		public __c__DisplayClass1_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr));

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SuspensionEditorTab(CarEditorUI carEditorUI)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carEditorUI);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226161, XrefRangeEnd = 226486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Generate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Generate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SuspensionEditorTab()
	{
		Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.CarEditor.Tabs", "SuspensionEditorTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr, 100680239);
		NativeMethodInfoPtr_Generate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspensionEditorTab>.NativeClassPtr, 100680240);
	}

	public SuspensionEditorTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
