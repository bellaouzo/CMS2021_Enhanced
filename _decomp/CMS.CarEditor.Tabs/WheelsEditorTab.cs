using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.CarEditor.Tabs;

public class WheelsEditorTab : BaseTab
{
	[ObfuscatedName("CMS.CarEditor.Tabs.WheelsEditorTab/<>c__DisplayClass1_0")]
	public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rims;

		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeFieldInfoPtr_tires;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__5_Internal_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__6_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__7_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__11_Internal_Void_Boolean_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr));

		public unsafe List<string> rims
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rims);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rims), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

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

		public unsafe List<string> tires
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tires);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tires), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226641, XrefRangeEnd = 226654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226654, XrefRangeEnd = 226667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226667, XrefRangeEnd = 226682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226682, XrefRangeEnd = 226697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226697, XrefRangeEnd = 226712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226712, XrefRangeEnd = 226714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__5(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__5_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226714, XrefRangeEnd = 226726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__6(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__6_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226726, XrefRangeEnd = 226738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__7(Dropdown d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__7_Internal_Void_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226738, XrefRangeEnd = 226753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226753, XrefRangeEnd = 226768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226768, XrefRangeEnd = 226783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226783, XrefRangeEnd = 226785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__11(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__11_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass1_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr, "<>c__DisplayClass1_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr);
			NativeFieldInfoPtr_rims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "rims");
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "carLoader");
			NativeFieldInfoPtr_tires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "tires");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680266);
			NativeMethodInfoPtr__Generate_b__0_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680267);
			NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680268);
			NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680269);
			NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680270);
			NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680271);
			NativeMethodInfoPtr__Generate_b__5_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680272);
			NativeMethodInfoPtr__Generate_b__6_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680273);
			NativeMethodInfoPtr__Generate_b__7_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680274);
			NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680275);
			NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680276);
			NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680277);
			NativeMethodInfoPtr__Generate_b__11_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680278);
		}

		public __c__DisplayClass1_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr));

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe WheelsEditorTab(CarEditorUI _carEditorUI)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(_carEditorUI);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226785, XrefRangeEnd = 227110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Generate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Generate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WheelsEditorTab()
	{
		Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.CarEditor.Tabs", "WheelsEditorTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr, 100680264);
		NativeMethodInfoPtr_Generate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsEditorTab>.NativeClassPtr, 100680265);
	}

	public WheelsEditorTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
