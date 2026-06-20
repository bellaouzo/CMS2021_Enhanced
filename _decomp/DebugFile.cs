using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[StructLayout(LayoutKind.Sequential)]
public sealed class DebugFile : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ScriptName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DrawName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameObjectName;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_Methods;

	private static readonly System.IntPtr NativeFieldInfoPtr_MethodActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_MethodToggles;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_FillFor;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAction_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MethodHasCustomAction_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MethodIsToggle_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetToggle_Public_DebugToggle_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DebugFile>.NativeClassPtr));

	public unsafe string ScriptName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScriptName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScriptName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string DrawName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string GameObjectName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameObjectName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GameObjectName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppStructArray<SceneType> SceneTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<SceneType>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneTypes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray Methods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Methods);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Methods), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray MethodActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MethodActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MethodActions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<DebugToggle> MethodToggles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MethodToggles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DebugToggle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MethodToggles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool AutoFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoFill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AutoFill)) = flag;
		}
	}

	public unsafe string FillFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FillFor);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FillFor), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94688, XrefRangeEnd = 94696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAction(string method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAction_Public_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94696, XrefRangeEnd = 94706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MethodHasCustomAction(string method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MethodHasCustomAction_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94706, XrefRangeEnd = 94707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool MethodIsToggle(string method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MethodIsToggle_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94707, XrefRangeEnd = 94708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugToggle GetToggle(string method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetToggle_Public_DebugToggle_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new DebugToggle(intPtr);
	}

	static DebugFile()
	{
		Il2CppClassPointerStore<DebugFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DebugFile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugFile>.NativeClassPtr);
		NativeFieldInfoPtr_ScriptName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "ScriptName");
		NativeFieldInfoPtr_DrawName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "DrawName");
		NativeFieldInfoPtr_GameObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "GameObjectName");
		NativeFieldInfoPtr_SceneTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "SceneTypes");
		NativeFieldInfoPtr_Methods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "Methods");
		NativeFieldInfoPtr_MethodActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "MethodActions");
		NativeFieldInfoPtr_MethodToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "MethodToggles");
		NativeFieldInfoPtr_AutoFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "AutoFill");
		NativeFieldInfoPtr_FillFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, "FillFor");
		NativeMethodInfoPtr_GetAction_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, 100668793);
		NativeMethodInfoPtr_MethodHasCustomAction_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, 100668794);
		NativeMethodInfoPtr_MethodIsToggle_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, 100668795);
		NativeMethodInfoPtr_GetToggle_Public_DebugToggle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, 100668796);
	}

	public DebugFile(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DebugFile()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugFile>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DebugFile>.NativeClassPtr))
	{
	}
}
