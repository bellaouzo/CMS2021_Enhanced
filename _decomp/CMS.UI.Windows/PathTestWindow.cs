using System;
using System.Runtime.CompilerServices;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Windows;

public class PathTestWindow : Window
{
	[ObfuscatedName("CMS.UI.Windows.PathTestWindow/<>c__DisplayClass31_0")]
	public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_image;

		private static readonly System.IntPtr NativeFieldInfoPtr_textValue;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TweenImage_b__0_Internal_Void_Single_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr));

		public unsafe Image image
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Text textValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textValue);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass31_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167854, XrefRangeEnd = 167865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TweenImage_b__0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TweenImage_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass31_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "<>c__DisplayClass31_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr);
			NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr, "image");
			NativeFieldInfoPtr_textValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr, "textValue");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr, 100675253);
			NativeMethodInfoPtr__TweenImage_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass31_0>.NativeClassPtr, 100675254);
		}

		public __c__DisplayClass31_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_commandValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRearLeftFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeFrontLeftFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRearRightFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeFrontRightFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspRearLeftFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspFrontLeftFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspRearRightFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspFrontRightFill;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRearLeftValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeFrontLeftValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRearRightValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeFrontRightValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspRearLeftValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspFrontLeftValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspRearRightValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspFrontRightValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRearLeftHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeFrontLeftHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeRearRightHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_brakeFrontRightHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspRearLeftHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspFrontLeftHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspRearRightHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspFrontRightHighlight;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateValue_Public_Void_PathTestType_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TweenImage_Private_Void_Image_Text_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFillColor_Public_Void_PathTestType_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillImage_Public_Void_PathTestType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCommand_Public_Void_PathTestDescType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Highlight_Public_Void_PathTestType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr));

	public unsafe Text commandValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeRearLeftFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearLeftFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearLeftFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeFrontLeftFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontLeftFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontLeftFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeRearRightFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearRightFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearRightFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeFrontRightFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontRightFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontRightFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspRearLeftFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearLeftFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearLeftFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspFrontLeftFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontLeftFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontLeftFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspRearRightFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearRightFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearRightFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspFrontRightFill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontRightFill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontRightFill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text brakeRearLeftValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearLeftValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearLeftValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text brakeFrontLeftValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontLeftValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontLeftValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text brakeRearRightValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearRightValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearRightValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text brakeFrontRightValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontRightValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontRightValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text suspRearLeftValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearLeftValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearLeftValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text suspFrontLeftValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontLeftValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontLeftValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text suspRearRightValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearRightValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearRightValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text suspFrontRightValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontRightValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontRightValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeRearLeftHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearLeftHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearLeftHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeFrontLeftHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontLeftHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontLeftHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeRearRightHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearRightHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeRearRightHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image brakeFrontRightHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontRightHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeFrontRightHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspRearLeftHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearLeftHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearLeftHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspFrontLeftHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontLeftHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontLeftHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspRearRightHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearRightHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspRearRightHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image suspFrontRightHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontRightHighlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspFrontRightHighlight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167865, XrefRangeEnd = 167871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167871, XrefRangeEnd = 167879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167879, XrefRangeEnd = 167883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167883, XrefRangeEnd = 167887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Hide(bool hiddenFromOutside)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hiddenFromOutside);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(55)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void EnableUI(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 167891, RefRangeEnd = 167896, XrefRangeStart = 167887, XrefRangeEnd = 167891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateValue(PathTestType testType, float leftVal, float rightVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&testType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &leftVal;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightVal;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateValue_Public_Void_PathTestType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167916, RefRangeEnd = 167918, XrefRangeStart = 167896, XrefRangeEnd = 167916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TweenImage(Image image, Text textValue, float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(textValue);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TweenImage_Private_Void_Image_Text_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetupFillColor(PathTestType testType, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&testType);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFillColor_Public_Void_PathTestType_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167918, XrefRangeEnd = 167920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillImage(PathTestType testType, float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&testType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillImage_Public_Void_PathTestType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167928, RefRangeEnd = 167930, XrefRangeStart = 167920, XrefRangeEnd = 167928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCommand(PathTestDescType descType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&descType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCommand_Public_Void_PathTestDescType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167930, XrefRangeEnd = 167934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Highlight(PathTestType testType, bool highlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&testType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &highlight;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Highlight_Public_Void_PathTestType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 167944, RefRangeEnd = 167945, XrefRangeStart = 167934, XrefRangeEnd = 167944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PathTestWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PathTestWindow()
	{
		Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "PathTestWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr);
		NativeFieldInfoPtr_commandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "commandValue");
		NativeFieldInfoPtr_brakeRearLeftFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeRearLeftFill");
		NativeFieldInfoPtr_brakeFrontLeftFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeFrontLeftFill");
		NativeFieldInfoPtr_brakeRearRightFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeRearRightFill");
		NativeFieldInfoPtr_brakeFrontRightFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeFrontRightFill");
		NativeFieldInfoPtr_suspRearLeftFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspRearLeftFill");
		NativeFieldInfoPtr_suspFrontLeftFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspFrontLeftFill");
		NativeFieldInfoPtr_suspRearRightFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspRearRightFill");
		NativeFieldInfoPtr_suspFrontRightFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspFrontRightFill");
		NativeFieldInfoPtr_brakeRearLeftValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeRearLeftValue");
		NativeFieldInfoPtr_brakeFrontLeftValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeFrontLeftValue");
		NativeFieldInfoPtr_brakeRearRightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeRearRightValue");
		NativeFieldInfoPtr_brakeFrontRightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeFrontRightValue");
		NativeFieldInfoPtr_suspRearLeftValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspRearLeftValue");
		NativeFieldInfoPtr_suspFrontLeftValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspFrontLeftValue");
		NativeFieldInfoPtr_suspRearRightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspRearRightValue");
		NativeFieldInfoPtr_suspFrontRightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspFrontRightValue");
		NativeFieldInfoPtr_brakeRearLeftHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeRearLeftHighlight");
		NativeFieldInfoPtr_brakeFrontLeftHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeFrontLeftHighlight");
		NativeFieldInfoPtr_brakeRearRightHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeRearRightHighlight");
		NativeFieldInfoPtr_brakeFrontRightHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "brakeFrontRightHighlight");
		NativeFieldInfoPtr_suspRearLeftHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspRearLeftHighlight");
		NativeFieldInfoPtr_suspFrontLeftHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspFrontLeftHighlight");
		NativeFieldInfoPtr_suspRearRightHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspRearRightHighlight");
		NativeFieldInfoPtr_suspFrontRightHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, "suspFrontRightHighlight");
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675240);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675241);
		NativeMethodInfoPtr_Show_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675242);
		NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675243);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675244);
		NativeMethodInfoPtr_UpdateValue_Public_Void_PathTestType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675245);
		NativeMethodInfoPtr_TweenImage_Private_Void_Image_Text_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675246);
		NativeMethodInfoPtr_SetupFillColor_Public_Void_PathTestType_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675247);
		NativeMethodInfoPtr_FillImage_Public_Void_PathTestType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675248);
		NativeMethodInfoPtr_UpdateCommand_Public_Void_PathTestDescType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675249);
		NativeMethodInfoPtr_Highlight_Public_Void_PathTestType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675250);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675251);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTestWindow>.NativeClassPtr, 100675252);
	}

	public PathTestWindow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
