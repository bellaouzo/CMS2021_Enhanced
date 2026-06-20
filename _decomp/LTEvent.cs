using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class LTEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTEvent>.NativeClassPtr));

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe Il2CppSystem.Object data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9827, RefRangeEnd = 9830, XrefRangeStart = 9827, XrefRangeEnd = 9827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTEvent(int id, Il2CppSystem.Object data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LTEvent()
	{
		Il2CppClassPointerStore<LTEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTEvent>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, "id");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, "data");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, 100664142);
	}

	public LTEvent(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
