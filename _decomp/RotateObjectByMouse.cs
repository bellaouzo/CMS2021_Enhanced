using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class RotateObjectByMouse : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rotateGlobal;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRotateX;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRotateY;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRotateZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_xtargetRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_ytargetRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_ztargetRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ySensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_zSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothing;

	private static readonly System.IntPtr NativeFieldInfoPtr_srX;

	private static readonly System.IntPtr NativeFieldInfoPtr_srY;

	private static readonly System.IntPtr NativeFieldInfoPtr_srZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxYdeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxXdeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxZdeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxXdegCalc;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxYdegCalc;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxZdegCalc;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr));

	public unsafe bool rotateGlobal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateGlobal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateGlobal)) = flag;
		}
	}

	public unsafe bool canRotateX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRotateX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRotateX)) = flag;
		}
	}

	public unsafe bool canRotateY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRotateY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRotateY)) = flag;
		}
	}

	public unsafe bool canRotateZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRotateZ);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRotateZ)) = flag;
		}
	}

	public unsafe float xtargetRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xtargetRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xtargetRotation)) = num;
		}
	}

	public unsafe float ytargetRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ytargetRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ytargetRotation)) = num;
		}
	}

	public unsafe float ztargetRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ztargetRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ztargetRotation)) = num;
		}
	}

	public unsafe float xSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSensitivity)) = num;
		}
	}

	public unsafe float ySensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySensitivity)) = num;
		}
	}

	public unsafe float zSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zSensitivity)) = num;
		}
	}

	public unsafe float smoothing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothing)) = num;
		}
	}

	public unsafe float srX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srX)) = num;
		}
	}

	public unsafe float srY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srY)) = num;
		}
	}

	public unsafe float srZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srZ)) = num;
		}
	}

	public unsafe Vector2 maxYdeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxYdeg);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxYdeg)) = vector;
		}
	}

	public unsafe Vector2 maxXdeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxXdeg);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxXdeg)) = vector;
		}
	}

	public unsafe Vector2 maxZdeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxZdeg);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxZdeg)) = vector;
		}
	}

	public unsafe float noiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseScale)) = num;
		}
	}

	public unsafe Vector2 maxXdegCalc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxXdegCalc);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxXdegCalc)) = vector;
		}
	}

	public unsafe Vector2 maxYdegCalc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxYdegCalc);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxYdegCalc)) = vector;
		}
	}

	public unsafe Vector2 maxZdegCalc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxZdegCalc);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxZdegCalc)) = vector;
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 86483, RefRangeEnd = 86489, XrefRangeStart = 86446, XrefRangeEnd = 86483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86489, XrefRangeEnd = 86547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86547, XrefRangeEnd = 86550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RotateObjectByMouse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RotateObjectByMouse()
	{
		Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RotateObjectByMouse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr);
		NativeFieldInfoPtr_rotateGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "rotateGlobal");
		NativeFieldInfoPtr_canRotateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "canRotateX");
		NativeFieldInfoPtr_canRotateY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "canRotateY");
		NativeFieldInfoPtr_canRotateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "canRotateZ");
		NativeFieldInfoPtr_xtargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "xtargetRotation");
		NativeFieldInfoPtr_ytargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "ytargetRotation");
		NativeFieldInfoPtr_ztargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "ztargetRotation");
		NativeFieldInfoPtr_xSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "xSensitivity");
		NativeFieldInfoPtr_ySensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "ySensitivity");
		NativeFieldInfoPtr_zSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "zSensitivity");
		NativeFieldInfoPtr_smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "smoothing");
		NativeFieldInfoPtr_srX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "srX");
		NativeFieldInfoPtr_srY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "srY");
		NativeFieldInfoPtr_srZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "srZ");
		NativeFieldInfoPtr_maxYdeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "maxYdeg");
		NativeFieldInfoPtr_maxXdeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "maxXdeg");
		NativeFieldInfoPtr_maxZdeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "maxZdeg");
		NativeFieldInfoPtr_noiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "noiseScale");
		NativeFieldInfoPtr_maxXdegCalc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "maxXdegCalc");
		NativeFieldInfoPtr_maxYdegCalc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "maxYdegCalc");
		NativeFieldInfoPtr_maxZdegCalc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, "maxZdegCalc");
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, 100668246);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, 100668247);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateObjectByMouse>.NativeClassPtr, 100668248);
	}

	public RotateObjectByMouse(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
