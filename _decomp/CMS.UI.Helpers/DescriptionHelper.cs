using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Logic;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Events;

namespace CMS.UI.Helpers;

public static class DescriptionHelper : Il2CppSystem.Object
{
	[ObfuscatedName("CMS.UI.Helpers.DescriptionHelper/<EnableDescriptionInput>d__1")]
	public sealed class _EnableDescriptionInput_d__1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe UIDescription uiDescription
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe InputManager inputManager
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _EnableDescriptionInput_d__1(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204021, XrefRangeEnd = 204034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204034, XrefRangeEnd = 204039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _EnableDescriptionInput_d__1()
		{
			Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, "<EnableDescriptionInput>d__1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, "uiDescription");
			NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, "inputManager");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, 100678745);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, 100678746);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, 100678747);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, 100678748);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, 100678749);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableDescriptionInput_d__1>.NativeClassPtr, 100678750);
		}

		public _EnableDescriptionInput_d__1(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDescriptionInput_Public_Static_Void_Window_InputManager_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableDescriptionInput_Private_Static_IEnumerator_InputManager_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssignedButton_Public_Static_List_1_String_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssignedButtonsToController_Private_Static_Void_ControllerType_String_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCategoryForAction_Private_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAction_Public_Static_Void_UIDescription_DescriptionVariant_String_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterAction_Public_Static_Void_UIDescription_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterFillAction_Public_Static_Void_UIDescription_DescriptionVariant_String_UnityAction_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterFillAction_Public_Static_Void_UIDescription_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowIfNotActive_Public_Static_Void_UIDescription_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideIfActive_Public_Static_Void_UIDescription_DescriptionVariant_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowDescription_Public_Static_Boolean_WindowID_byref_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowDescription_Public_Static_Boolean_AlternativeDescriptionID_byref_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideDescription_Public_Static_Void_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideDescription_Public_Static_Void_AlternativeDescriptionID_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr));

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 204067, RefRangeEnd = 204104, XrefRangeStart = 204039, XrefRangeEnd = 204067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableDescriptionInput(Window window, InputManager inputManager, UIDescription uiDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(window);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inputManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDescriptionInput_Public_Static_Void_Window_InputManager_UIDescription_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204104, XrefRangeEnd = 204107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator EnableDescriptionInput(InputManager inputManager, UIDescription uiDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableDescriptionInput_Private_Static_IEnumerator_InputManager_UIDescription_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 204228, RefRangeEnd = 204229, XrefRangeStart = 204107, XrefRangeEnd = 204228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<string> GetAssignedButton(string actionName, bool isControllerConnected, bool isPlaystationController)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isControllerConnected;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPlaystationController;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssignedButton_Public_Static_List_1_String_String_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 204370, RefRangeEnd = 204372, XrefRangeStart = 204229, XrefRangeEnd = 204370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAssignedButtonsToController(ControllerType ct, string actionName, ref List<string> listOfAssignedButtons)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ct);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(listOfAssignedButtons);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssignedButtonsToController_Private_Static_Void_ControllerType_String_byref_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		listOfAssignedButtons = (List<string>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 204384, RefRangeEnd = 204387, XrefRangeStart = 204372, XrefRangeEnd = 204384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCategoryForAction(string actionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCategoryForAction_Private_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(253)]
	[CachedScanResults(RefRangeStart = 204405, RefRangeEnd = 204658, XrefRangeStart = 204387, XrefRangeEnd = 204405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterAction(UIDescription uiDescription, DescriptionVariant variant, string actionName, UnityAction action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterAction_Public_Static_Void_UIDescription_DescriptionVariant_String_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(382)]
	[CachedScanResults(RefRangeStart = 204675, RefRangeEnd = 205057, XrefRangeStart = 204658, XrefRangeEnd = 204675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterAction(UIDescription uiDescription, DescriptionVariant variant, string actionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterAction_Public_Static_Void_UIDescription_DescriptionVariant_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 205076, RefRangeEnd = 205079, XrefRangeStart = 205057, XrefRangeEnd = 205076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterFillAction(UIDescription uiDescription, DescriptionVariant variant, string actionName, UnityAction<float> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterFillAction_Public_Static_Void_UIDescription_DescriptionVariant_String_UnityAction_1_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 205096, RefRangeEnd = 205100, XrefRangeStart = 205079, XrefRangeEnd = 205096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterFillAction(UIDescription uiDescription, DescriptionVariant variant, string actionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterFillAction_Public_Static_Void_UIDescription_DescriptionVariant_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205100, XrefRangeEnd = 205102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowIfNotActive(UIDescription uiDescription, DescriptionVariant variant, string actionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowIfNotActive_Public_Static_Void_UIDescription_DescriptionVariant_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205102, XrefRangeEnd = 205104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideIfActive(UIDescription uiDescription, DescriptionVariant variant, string actionName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(DescriptionVariant**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variant;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideIfActive_Public_Static_Void_UIDescription_DescriptionVariant_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(74)]
	[CachedScanResults(RefRangeStart = 205131, RefRangeEnd = 205205, XrefRangeStart = 205104, XrefRangeEnd = 205131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShowDescription(WindowID windowID, out UIDescription uiDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowDescription_Public_Static_Boolean_WindowID_byref_UIDescription_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		uiDescription = ((intPtr2 == (System.IntPtr)0) ? null : new UIDescription(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 205221, RefRangeEnd = 205225, XrefRangeStart = 205205, XrefRangeEnd = 205221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShowDescription(AlternativeDescriptionID alternativeID, out UIDescription uiDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&alternativeID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(uiDescription);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowDescription_Public_Static_Boolean_AlternativeDescriptionID_byref_UIDescription_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		uiDescription = ((intPtr2 == (System.IntPtr)0) ? null : new UIDescription(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(70)]
	[CachedScanResults(RefRangeStart = 205240, RefRangeEnd = 205310, XrefRangeStart = 205225, XrefRangeEnd = 205240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideDescription(WindowID windowID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideDescription_Public_Static_Void_WindowID_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 205325, RefRangeEnd = 205327, XrefRangeStart = 205310, XrefRangeEnd = 205325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideDescription(AlternativeDescriptionID alternativeID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&alternativeID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideDescription_Public_Static_Void_AlternativeDescriptionID_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DescriptionHelper()
	{
		Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "DescriptionHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr);
		NativeMethodInfoPtr_EnableDescriptionInput_Public_Static_Void_Window_InputManager_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678730);
		NativeMethodInfoPtr_EnableDescriptionInput_Private_Static_IEnumerator_InputManager_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678731);
		NativeMethodInfoPtr_GetAssignedButton_Public_Static_List_1_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678732);
		NativeMethodInfoPtr_GetAssignedButtonsToController_Private_Static_Void_ControllerType_String_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678733);
		NativeMethodInfoPtr_GetCategoryForAction_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678734);
		NativeMethodInfoPtr_RegisterAction_Public_Static_Void_UIDescription_DescriptionVariant_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678735);
		NativeMethodInfoPtr_UnregisterAction_Public_Static_Void_UIDescription_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678736);
		NativeMethodInfoPtr_RegisterFillAction_Public_Static_Void_UIDescription_DescriptionVariant_String_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678737);
		NativeMethodInfoPtr_UnregisterFillAction_Public_Static_Void_UIDescription_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678738);
		NativeMethodInfoPtr_ShowIfNotActive_Public_Static_Void_UIDescription_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678739);
		NativeMethodInfoPtr_HideIfActive_Public_Static_Void_UIDescription_DescriptionVariant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678740);
		NativeMethodInfoPtr_ShowDescription_Public_Static_Boolean_WindowID_byref_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678741);
		NativeMethodInfoPtr_ShowDescription_Public_Static_Boolean_AlternativeDescriptionID_byref_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678742);
		NativeMethodInfoPtr_HideDescription_Public_Static_Void_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678743);
		NativeMethodInfoPtr_HideDescription_Public_Static_Void_AlternativeDescriptionID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescriptionHelper>.NativeClassPtr, 100678744);
	}

	public DescriptionHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
