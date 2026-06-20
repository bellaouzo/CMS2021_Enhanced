using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.CarEditor.Tabs;

public class OtherEditorTab : BaseTab
{
	[ObfuscatedName("CMS.CarEditor.Tabs.OtherEditorTab/<>c__DisplayClass1_0")]
	public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__0_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__5_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__14_Internal_Void_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__15_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__16_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__17_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__18_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__19_Internal_Void_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__20_Internal_Void_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__21_Internal_Void_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__22_Internal_Void_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__23_Internal_Void_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__24_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__25_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__26_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__27_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__28_Internal_Void_String_0;

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

		public unsafe OtherEditorTab __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new OtherEditorTab(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224758, XrefRangeEnd = 224762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__0(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224762, XrefRangeEnd = 224763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224763, XrefRangeEnd = 224767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224767, XrefRangeEnd = 224771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224771, XrefRangeEnd = 224775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224775, XrefRangeEnd = 224784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224784, XrefRangeEnd = 224793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224793, XrefRangeEnd = 224802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224802, XrefRangeEnd = 224811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224811, XrefRangeEnd = 224820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224820, XrefRangeEnd = 224829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224829, XrefRangeEnd = 224838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224838, XrefRangeEnd = 224847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		public unsafe void _Generate_b__14(Toggle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__14_Internal_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224847, XrefRangeEnd = 224851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__15(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__15_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224851, XrefRangeEnd = 224860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__16(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__16_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224860, XrefRangeEnd = 224864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__17(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__17_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224864, XrefRangeEnd = 224868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__18(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__18_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe void _Generate_b__19(Toggle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__19_Internal_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224868, XrefRangeEnd = 224872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__20(Toggle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__20_Internal_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224872, XrefRangeEnd = 224876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__21(Toggle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__21_Internal_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224876, XrefRangeEnd = 224880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__22(Toggle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__22_Internal_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224880, XrefRangeEnd = 224884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__23(Toggle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__23_Internal_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224884, XrefRangeEnd = 224916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__24(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__24_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224916, XrefRangeEnd = 224918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__25(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__25_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224918, XrefRangeEnd = 224922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__26(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__26_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224922, XrefRangeEnd = 224926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__27(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__27_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224926, XrefRangeEnd = 224930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Generate_b__28(string m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(m);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Generate_b__28_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass1_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr, "<>c__DisplayClass1_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr);
			NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "carLoader");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680193);
			NativeMethodInfoPtr__Generate_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680194);
			NativeMethodInfoPtr__Generate_b__1_Internal_Void_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680195);
			NativeMethodInfoPtr__Generate_b__2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680196);
			NativeMethodInfoPtr__Generate_b__3_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680197);
			NativeMethodInfoPtr__Generate_b__4_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680198);
			NativeMethodInfoPtr__Generate_b__5_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680199);
			NativeMethodInfoPtr__Generate_b__6_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680200);
			NativeMethodInfoPtr__Generate_b__7_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680201);
			NativeMethodInfoPtr__Generate_b__8_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680202);
			NativeMethodInfoPtr__Generate_b__9_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680203);
			NativeMethodInfoPtr__Generate_b__10_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680204);
			NativeMethodInfoPtr__Generate_b__11_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680205);
			NativeMethodInfoPtr__Generate_b__12_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680206);
			NativeMethodInfoPtr__Generate_b__13_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680207);
			NativeMethodInfoPtr__Generate_b__14_Internal_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680208);
			NativeMethodInfoPtr__Generate_b__15_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680209);
			NativeMethodInfoPtr__Generate_b__16_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680210);
			NativeMethodInfoPtr__Generate_b__17_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680211);
			NativeMethodInfoPtr__Generate_b__18_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680212);
			NativeMethodInfoPtr__Generate_b__19_Internal_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680213);
			NativeMethodInfoPtr__Generate_b__20_Internal_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680214);
			NativeMethodInfoPtr__Generate_b__21_Internal_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680215);
			NativeMethodInfoPtr__Generate_b__22_Internal_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680216);
			NativeMethodInfoPtr__Generate_b__23_Internal_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680217);
			NativeMethodInfoPtr__Generate_b__24_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680218);
			NativeMethodInfoPtr__Generate_b__25_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680219);
			NativeMethodInfoPtr__Generate_b__26_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680220);
			NativeMethodInfoPtr__Generate_b__27_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680221);
			NativeMethodInfoPtr__Generate_b__28_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass1_0>.NativeClassPtr, 100680222);
		}

		public __c__DisplayClass1_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr));

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe OtherEditorTab(CarEditorUI carEditorUI)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carEditorUI);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224930, XrefRangeEnd = 225607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Generate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Generate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OtherEditorTab()
	{
		Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.CarEditor.Tabs", "OtherEditorTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_CarEditorUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr, 100680191);
		NativeMethodInfoPtr_Generate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OtherEditorTab>.NativeClassPtr, 100680192);
	}

	public OtherEditorTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
