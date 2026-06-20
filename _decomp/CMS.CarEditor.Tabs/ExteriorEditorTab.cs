using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.CarEditor.Tabs;

public class ExteriorEditorTab : BaseTab
{
	[ObfuscatedName("CMS.CarEditor.Tabs.ExteriorEditorTab/<>c__DisplayClass1_0")]
	public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__1_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__5_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__8_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__14_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__15_Internal_Void_String_0;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222724, XrefRangeEnd = 222729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222729, XrefRangeEnd = 222740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__1(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222740, XrefRangeEnd = 222751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__2(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222751, XrefRangeEnd = 222762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__3(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222762, XrefRangeEnd = 222773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__4(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222773, XrefRangeEnd = 222784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__5(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__5_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222784, XrefRangeEnd = 222795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222795, XrefRangeEnd = 222806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222806, XrefRangeEnd = 222811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__8(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__8_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222811, XrefRangeEnd = 222822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222822, XrefRangeEnd = 222833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222833, XrefRangeEnd = 222844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222844, XrefRangeEnd = 222855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222855, XrefRangeEnd = 222866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222866, XrefRangeEnd = 222877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__14(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__14_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222877, XrefRangeEnd = 222888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__15(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__15_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass1_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr, "<>c__DisplayClass1_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr);
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "carLoader");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680104);
			NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680105);
			NativeMethodInfoPtr__Generate_b__1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680106);
			NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680107);
			NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680108);
			NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680109);
			NativeMethodInfoPtr__Generate_b__5_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680110);
			NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680111);
			NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680112);
			NativeMethodInfoPtr__Generate_b__8_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680113);
			NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680114);
			NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680115);
			NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680116);
			NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680117);
			NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680118);
			NativeMethodInfoPtr__Generate_b__14_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680119);
			NativeMethodInfoPtr__Generate_b__15_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680120);
		}

		public __c__DisplayClass1_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr));

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ExteriorEditorTab(CarEditorUI carEditorUI)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carEditorUI);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222888, XrefRangeEnd = 223179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Generate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Generate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ExteriorEditorTab()
	{
		Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.CarEditor.Tabs", "ExteriorEditorTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr, 100680102);
		NativeMethodInfoPtr_Generate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExteriorEditorTab>.NativeClassPtr, 100680103);
	}

	public ExteriorEditorTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
