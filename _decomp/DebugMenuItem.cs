using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class DebugMenuItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_DrawName;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameObjectName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_ValueChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_Toggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreviousPage;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsToggle_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr));

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(str));
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

	public unsafe string ItemLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemLocation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemLocation), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool ValueChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueChanged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ValueChanged)) = flag;
		}
	}

	public unsafe bool LastValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastValue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastValue)) = flag;
		}
	}

	public unsafe DebugToggle Toggle
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Toggle);
			return new DebugToggle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Toggle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugToggle>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe DebugItemType ItemType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemType);
			return *(DebugItemType*)num;
		}
		set
		{
			*(DebugItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemType)) = debugItemType;
		}
	}

	public unsafe MenuPage NextPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextPage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MenuPage(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextPage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MenuPage PreviousPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousPage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MenuPage(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousPage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94958, RefRangeEnd = 94959, XrefRangeStart = 94899, XrefRangeEnd = 94958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsToggle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsToggle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95000, RefRangeEnd = 95002, XrefRangeStart = 94959, XrefRangeEnd = 95000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DebugMenuItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DebugMenuItem()
	{
		Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DebugMenuItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_DrawName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "DrawName");
		NativeFieldInfoPtr_GameObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "GameObjectName");
		NativeFieldInfoPtr_ItemLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "ItemLocation");
		NativeFieldInfoPtr_ValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "ValueChanged");
		NativeFieldInfoPtr_LastValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "LastValue");
		NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "Toggle");
		NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "ItemType");
		NativeFieldInfoPtr_NextPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "NextPage");
		NativeFieldInfoPtr_PreviousPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, "PreviousPage");
		NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100668807);
		NativeMethodInfoPtr_IsToggle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100668808);
		NativeMethodInfoPtr_GetValue_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100668809);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100668810);
	}

	public DebugMenuItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
