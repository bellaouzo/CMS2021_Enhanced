using System;
using System.Runtime.CompilerServices;
using CMS.Garage.Customization;
using CMS.UI.Logic.Upgrades;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class GarageLevelManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectsToHighlightInDemo;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageAndToolsTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_garageLookManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareGarage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTexturePackManager_Public_TexturePackManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupGarageLookManager_Public_GarageLookManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGarageAndToolsTab_Public_GarageAndToolsTab_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr));

	public unsafe bool IsReady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<InteractiveObject> objectsToHighlightInDemo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToHighlightInDemo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<InteractiveObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToHighlightInDemo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GarageAndToolsTab garageAndToolsTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageAndToolsTab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GarageAndToolsTab(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageAndToolsTab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TexturePackManager textureManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TexturePackManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GarageLookManager garageLookManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageLookManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GarageLookManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_garageLookManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51351, RefRangeEnd = 51352, XrefRangeStart = 51349, XrefRangeEnd = 51351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareGarage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareGarage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51352, XrefRangeEnd = 51354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TexturePackManager SetupTexturePackManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTexturePackManager_Public_TexturePackManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new TexturePackManager(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51354, XrefRangeEnd = 51356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GarageLookManager SetupGarageLookManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupGarageLookManager_Public_GarageLookManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GarageLookManager(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51356, RefRangeEnd = 51360, XrefRangeStart = 51356, XrefRangeEnd = 51356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GarageAndToolsTab GetGarageAndToolsTab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGarageAndToolsTab_Public_GarageAndToolsTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GarageAndToolsTab(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe GarageLevelManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GarageLevelManager()
	{
		Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GarageLevelManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr);
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, "IsReady");
		NativeFieldInfoPtr_objectsToHighlightInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, "objectsToHighlightInDemo");
		NativeFieldInfoPtr_garageAndToolsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, "garageAndToolsTab");
		NativeFieldInfoPtr_textureManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, "textureManager");
		NativeFieldInfoPtr_garageLookManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, "garageLookManager");
		NativeMethodInfoPtr_PrepareGarage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, 100666308);
		NativeMethodInfoPtr_SetupTexturePackManager_Public_TexturePackManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, 100666309);
		NativeMethodInfoPtr_SetupGarageLookManager_Public_GarageLookManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, 100666310);
		NativeMethodInfoPtr_GetGarageAndToolsTab_Public_GarageAndToolsTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, 100666311);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageLevelManager>.NativeClassPtr, 100666312);
	}

	public GarageLevelManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
