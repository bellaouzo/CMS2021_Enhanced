using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Auction;

public class BiddingConsole : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_textRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLines;

	private static readonly System.IntPtr NativeFieldInfoPtr_lines;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearConsole_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLine_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLine_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConsole_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToListAndRemoveOverflow_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddText_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr));

	public unsafe Text textLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textLeft);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textLeft), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text textRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textRight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textRight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int MaxLines
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxLines, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxLines, &num);
		}
	}

	public unsafe List<string> lines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 203292, RefRangeEnd = 203293, XrefRangeStart = 203287, XrefRangeEnd = 203292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearConsole(bool clearList = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&clearList);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearConsole_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 203303, RefRangeEnd = 203307, XrefRangeStart = 203293, XrefRangeEnd = 203303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLine(string text, int price)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &price;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLine_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203307, XrefRangeEnd = 203311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLine(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 203333, RefRangeEnd = 203336, XrefRangeStart = 203311, XrefRangeEnd = 203333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateConsole(bool oneLine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&oneLine);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateConsole_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 203344, RefRangeEnd = 203347, XrefRangeStart = 203336, XrefRangeEnd = 203344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToListAndRemoveOverflow(string line)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToListAndRemoveOverflow_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 203353, RefRangeEnd = 203355, XrefRangeStart = 203347, XrefRangeEnd = 203353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddText(string left, string right)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(left);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(right);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddText_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203355, XrefRangeEnd = 203366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BiddingConsole()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BiddingConsole()
	{
		Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Auction", "BiddingConsole");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr);
		NativeFieldInfoPtr_textLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, "textLeft");
		NativeFieldInfoPtr_textRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, "textRight");
		NativeFieldInfoPtr_MaxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, "MaxLines");
		NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, "lines");
		NativeMethodInfoPtr_ClearConsole_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678666);
		NativeMethodInfoPtr_AddLine_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678667);
		NativeMethodInfoPtr_AddLine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678668);
		NativeMethodInfoPtr_UpdateConsole_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678669);
		NativeMethodInfoPtr_AddToListAndRemoveOverflow_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678670);
		NativeMethodInfoPtr_AddText_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678671);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiddingConsole>.NativeClassPtr, 100678672);
	}

	public BiddingConsole(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
