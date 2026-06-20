using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Shop;

public class ShopBackgroundsContainer : MonoBehaviour
{
	[System.Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Backgrounds : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Background;

		private static readonly System.IntPtr NativeFieldInfoPtr_ShopType;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Backgrounds>.NativeClassPtr));

		public unsafe Sprite Background
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Background);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe ShopType ShopType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopType);
				return *(ShopType*)num;
			}
			set
			{
				*(ShopType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopType)) = shopType;
			}
		}

		static Backgrounds()
		{
			Il2CppClassPointerStore<Backgrounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr, "Backgrounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Backgrounds>.NativeClassPtr);
			NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Backgrounds>.NativeClassPtr, "Background");
			NativeFieldInfoPtr_ShopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Backgrounds>.NativeClassPtr, "ShopType");
		}

		public Backgrounds(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe Backgrounds()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Backgrounds>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Backgrounds>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_backgrounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_background;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBackgroundForShop_Public_Void_ShopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Backgrounds> backgrounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgrounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Backgrounds>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgrounds), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image background
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 189370, RefRangeEnd = 189373, XrefRangeStart = 189354, XrefRangeEnd = 189370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBackgroundForShop(ShopType shopType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shopType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBackgroundForShop_Public_Void_ShopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ShopBackgroundsContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShopBackgroundsContainer()
	{
		Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Shop", "ShopBackgroundsContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr);
		NativeFieldInfoPtr_backgrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr, "backgrounds");
		NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr, "background");
		NativeMethodInfoPtr_SetBackgroundForShop_Public_Void_ShopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr, 100677264);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopBackgroundsContainer>.NativeClassPtr, 100677265);
	}

	public ShopBackgroundsContainer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
