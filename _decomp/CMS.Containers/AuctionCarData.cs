using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

public class AuctionCarData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Car;

	private static readonly System.IntPtr NativeFieldInfoPtr_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rating;

	private static readonly System.IntPtr NativeFieldInfoPtr_Seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartingPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_Sold;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr));

	public unsafe string Car
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Car);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Car), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int Version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Version)) = num;
		}
	}

	public unsafe int Rating
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rating);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rating)) = num;
		}
	}

	public unsafe int Seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Seed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Seed)) = num;
		}
	}

	public unsafe int Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value)) = num;
		}
	}

	public unsafe int StartingPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartingPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartingPrice)) = num;
		}
	}

	public unsafe bool Sold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sold);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Sold)) = flag;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe AuctionCarData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AuctionCarData()
	{
		Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "AuctionCarData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr);
		NativeFieldInfoPtr_Car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "Car");
		NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "Version");
		NativeFieldInfoPtr_Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "Rating");
		NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "Seed");
		NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "Value");
		NativeFieldInfoPtr_StartingPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "StartingPrice");
		NativeFieldInfoPtr_Sold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, "Sold");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuctionCarData>.NativeClassPtr, 100679746);
	}

	public AuctionCarData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
