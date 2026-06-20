using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Rewired;

public sealed class GamepadTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftShoulder1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftBumper;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftShoulder2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightShoulder1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightBumper;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightShoulder2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_back;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_guide;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPad;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr));

	public unsafe static Il2CppSystem.Guid typeGuid
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppSystem.Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeGuid, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeGuid, &guid);
		}
	}

	public unsafe static int elementId_leftStickX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStickX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStickX, &num);
		}
	}

	public unsafe static int elementId_leftStickY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStickY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStickY, &num);
		}
	}

	public unsafe static int elementId_rightStickX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStickX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStickX, &num);
		}
	}

	public unsafe static int elementId_rightStickY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStickY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStickY, &num);
		}
	}

	public unsafe static int elementId_actionBottomRow1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionBottomRow1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionBottomRow1, &num);
		}
	}

	public unsafe static int elementId_a
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_a, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_a, &num);
		}
	}

	public unsafe static int elementId_actionBottomRow2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionBottomRow2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionBottomRow2, &num);
		}
	}

	public unsafe static int elementId_b
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_b, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_b, &num);
		}
	}

	public unsafe static int elementId_actionBottomRow3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionBottomRow3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionBottomRow3, &num);
		}
	}

	public unsafe static int elementId_c
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_c, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_c, &num);
		}
	}

	public unsafe static int elementId_actionTopRow1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionTopRow1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionTopRow1, &num);
		}
	}

	public unsafe static int elementId_x
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_x, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_x, &num);
		}
	}

	public unsafe static int elementId_actionTopRow2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionTopRow2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionTopRow2, &num);
		}
	}

	public unsafe static int elementId_y
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_y, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_y, &num);
		}
	}

	public unsafe static int elementId_actionTopRow3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionTopRow3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionTopRow3, &num);
		}
	}

	public unsafe static int elementId_z
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_z, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_z, &num);
		}
	}

	public unsafe static int elementId_leftShoulder1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftShoulder1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftShoulder1, &num);
		}
	}

	public unsafe static int elementId_leftBumper
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftBumper, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftBumper, &num);
		}
	}

	public unsafe static int elementId_leftShoulder2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftShoulder2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftShoulder2, &num);
		}
	}

	public unsafe static int elementId_leftTrigger
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftTrigger, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftTrigger, &num);
		}
	}

	public unsafe static int elementId_rightShoulder1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightShoulder1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightShoulder1, &num);
		}
	}

	public unsafe static int elementId_rightBumper
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightBumper, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightBumper, &num);
		}
	}

	public unsafe static int elementId_rightShoulder2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightShoulder2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightShoulder2, &num);
		}
	}

	public unsafe static int elementId_rightTrigger
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightTrigger, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightTrigger, &num);
		}
	}

	public unsafe static int elementId_center1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_center1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_center1, &num);
		}
	}

	public unsafe static int elementId_back
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_back, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_back, &num);
		}
	}

	public unsafe static int elementId_center2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_center2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_center2, &num);
		}
	}

	public unsafe static int elementId_start
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_start, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_start, &num);
		}
	}

	public unsafe static int elementId_center3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_center3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_center3, &num);
		}
	}

	public unsafe static int elementId_guide
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_guide, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_guide, &num);
		}
	}

	public unsafe static int elementId_leftStickButton
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStickButton, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStickButton, &num);
		}
	}

	public unsafe static int elementId_rightStickButton
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStickButton, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStickButton, &num);
		}
	}

	public unsafe static int elementId_dPadUp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadUp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadUp, &num);
		}
	}

	public unsafe static int elementId_dPadRight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadRight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadRight, &num);
		}
	}

	public unsafe static int elementId_dPadDown
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadDown, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadDown, &num);
		}
	}

	public unsafe static int elementId_dPadLeft
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadLeft, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadLeft, &num);
		}
	}

	public unsafe static int elementId_leftStick
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStick, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStick, &num);
		}
	}

	public unsafe static int elementId_rightStick
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStick, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStick, &num);
		}
	}

	public unsafe static int elementId_dPad
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPad, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPad, &num);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131091, XrefRangeEnd = 131094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ea
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131094, XrefRangeEnd = 131097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131097, XrefRangeEnd = 131100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eb
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131100, XrefRangeEnd = 131103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131103, XrefRangeEnd = 131106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ec
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131106, XrefRangeEnd = 131109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131109, XrefRangeEnd = 131112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ex
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131112, XrefRangeEnd = 131115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131115, XrefRangeEnd = 131118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131118, XrefRangeEnd = 131121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131121, XrefRangeEnd = 131124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ez
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131124, XrefRangeEnd = 131127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftShoulder1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131127, XrefRangeEnd = 131130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftBumper
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131130, XrefRangeEnd = 131133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftShoulder2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131133, XrefRangeEnd = 131136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateAxis)null) : new IControllerTemplateAxis(intPtr);
		}
	}

	public unsafe IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131136, XrefRangeEnd = 131139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateAxis)null) : new IControllerTemplateAxis(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightShoulder1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131139, XrefRangeEnd = 131142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightBumper
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131142, XrefRangeEnd = 131145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightShoulder2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131145, XrefRangeEnd = 131148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateAxis)null) : new IControllerTemplateAxis(intPtr);
		}
	}

	public unsafe IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131148, XrefRangeEnd = 131151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateAxis)null) : new IControllerTemplateAxis(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131151, XrefRangeEnd = 131154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eback
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131154, XrefRangeEnd = 131157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131157, XrefRangeEnd = 131160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Estart
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131160, XrefRangeEnd = 131163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131163, XrefRangeEnd = 131166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eguide
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131166, XrefRangeEnd = 131169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateButton)null) : new IControllerTemplateButton(intPtr);
		}
	}

	public unsafe IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002EleftStick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131169, XrefRangeEnd = 131172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateThumbStick)null) : new IControllerTemplateThumbStick(intPtr);
		}
	}

	public unsafe IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002ErightStick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131172, XrefRangeEnd = 131175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateThumbStick)null) : new IControllerTemplateThumbStick(intPtr);
		}
	}

	public unsafe IControllerTemplateDPad Rewired_002EIGamepadTemplate_002EdPad
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131175, XrefRangeEnd = 131178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((IControllerTemplateDPad)null) : new IControllerTemplateDPad(intPtr);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131178, XrefRangeEnd = 131189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamepadTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GamepadTemplate()
	{
		Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Rewired", "GamepadTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickX");
		NativeFieldInfoPtr_elementId_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickY");
		NativeFieldInfoPtr_elementId_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickX");
		NativeFieldInfoPtr_elementId_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickY");
		NativeFieldInfoPtr_elementId_actionBottomRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow1");
		NativeFieldInfoPtr_elementId_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_a");
		NativeFieldInfoPtr_elementId_actionBottomRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow2");
		NativeFieldInfoPtr_elementId_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_b");
		NativeFieldInfoPtr_elementId_actionBottomRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow3");
		NativeFieldInfoPtr_elementId_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_c");
		NativeFieldInfoPtr_elementId_actionTopRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow1");
		NativeFieldInfoPtr_elementId_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_x");
		NativeFieldInfoPtr_elementId_actionTopRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow2");
		NativeFieldInfoPtr_elementId_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_y");
		NativeFieldInfoPtr_elementId_actionTopRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow3");
		NativeFieldInfoPtr_elementId_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_z");
		NativeFieldInfoPtr_elementId_leftShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftShoulder1");
		NativeFieldInfoPtr_elementId_leftBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftBumper");
		NativeFieldInfoPtr_elementId_leftShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftShoulder2");
		NativeFieldInfoPtr_elementId_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftTrigger");
		NativeFieldInfoPtr_elementId_rightShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightShoulder1");
		NativeFieldInfoPtr_elementId_rightBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightBumper");
		NativeFieldInfoPtr_elementId_rightShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightShoulder2");
		NativeFieldInfoPtr_elementId_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightTrigger");
		NativeFieldInfoPtr_elementId_center1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center1");
		NativeFieldInfoPtr_elementId_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_back");
		NativeFieldInfoPtr_elementId_center2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center2");
		NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_start");
		NativeFieldInfoPtr_elementId_center3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center3");
		NativeFieldInfoPtr_elementId_guide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_guide");
		NativeFieldInfoPtr_elementId_leftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickButton");
		NativeFieldInfoPtr_elementId_rightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickButton");
		NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadUp");
		NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadRight");
		NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadDown");
		NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadLeft");
		NativeFieldInfoPtr_elementId_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStick");
		NativeFieldInfoPtr_elementId_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStick");
		NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPad");
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672030);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672031);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672032);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672033);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672034);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672035);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672036);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672037);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672038);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672039);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672040);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672041);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672042);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672043);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672044);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672045);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672046);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672047);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672048);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672049);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672050);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672051);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672052);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672053);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672054);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672055);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672056);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672057);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672058);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100672059);
	}

	public GamepadTemplate(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
