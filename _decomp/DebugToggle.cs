using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[StructLayout(LayoutKind.Sequential)]
public sealed class DebugToggle : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Method;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScriptName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Value;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr));

	public unsafe string Method
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Method);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Method), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

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

	public unsafe string Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static DebugToggle()
	{
		Il2CppClassPointerStore<DebugToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DebugToggle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr);
		NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr, "Method");
		NativeFieldInfoPtr_ScriptName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr, "ScriptName");
		NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr, "Value");
	}

	public DebugToggle(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DebugToggle()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DebugToggle>.NativeClassPtr))
	{
	}
}
