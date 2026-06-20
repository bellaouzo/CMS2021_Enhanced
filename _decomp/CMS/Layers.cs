using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS;

public static class Layers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Default;

	private static readonly System.IntPtr NativeFieldInfoPtr_Car;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_NewHighlighterActiveObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_HighlighterActiveObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteriorUnactive;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Layers>.NativeClassPtr));

	public unsafe static int Default
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, &num);
		}
	}

	public unsafe static int Car
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Car, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Car, &num);
		}
	}

	public unsafe static int Mounts
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Mounts, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Mounts, &num);
		}
	}

	public unsafe static int NewHighlighterActiveObjects
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NewHighlighterActiveObjects, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NewHighlighterActiveObjects, &num);
		}
	}

	public unsafe static int HighlighterActiveObjects
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HighlighterActiveObjects, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HighlighterActiveObjects, &num);
		}
	}

	public unsafe static int InteriorUnactive
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InteriorUnactive, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InteriorUnactive, &num);
		}
	}

	static Layers()
	{
		Il2CppClassPointerStore<Layers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS", "Layers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Layers>.NativeClassPtr);
		NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Default");
		NativeFieldInfoPtr_Car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Car");
		NativeFieldInfoPtr_Mounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "Mounts");
		NativeFieldInfoPtr_NewHighlighterActiveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "NewHighlighterActiveObjects");
		NativeFieldInfoPtr_HighlighterActiveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "HighlighterActiveObjects");
		NativeFieldInfoPtr_InteriorUnactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Layers>.NativeClassPtr, "InteriorUnactive");
	}

	public Layers(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
