using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace Cpp2ILInjected;

public sealed class TokenAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Token;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TokenAttribute>.NativeClassPtr));

	public unsafe string Token
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Token);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static TokenAttribute()
	{
		Il2CppClassPointerStore<TokenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Cpp2ILInjected", "TokenAttribute");
		NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenAttribute>.NativeClassPtr, "Token");
	}

	public TokenAttribute(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
