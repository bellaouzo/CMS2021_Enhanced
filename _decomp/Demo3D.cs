using System;
using System.Runtime.CompilerServices;
using CP.ProChart;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Demo3D : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_charts;

	private static readonly System.IntPtr NativeFieldInfoPtr_bar;

	private static readonly System.IntPtr NativeFieldInfoPtr_line;

	private static readonly System.IntPtr NativeFieldInfoPtr_curve;

	private static readonly System.IntPtr NativeFieldInfoPtr_pie;

	private static readonly System.IntPtr NativeFieldInfoPtr_doughnut;

	private static readonly System.IntPtr NativeFieldInfoPtr_halfDoughnut;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSet2;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClick_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Demo3D>.NativeClassPtr));

	public unsafe GameObject charts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BarChartMesh bar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BarChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChartMesh line
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LineChartMesh curve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LineChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh pie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pie), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh doughnut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doughnut);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doughnut), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PieChartMesh halfDoughnut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfDoughnut);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PieChartMesh(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfDoughnut), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChartData1D dataSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData1D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChartData2D dataSet2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChartData2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSet2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float velocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_velocity)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724, XrefRangeEnd = 773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773, XrefRangeEnd = 808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808, XrefRangeEnd = 834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834, XrefRangeEnd = 872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick(string button)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClick_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Demo3D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Demo3D>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Demo3D()
	{
		Il2CppClassPointerStore<Demo3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Demo3D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Demo3D>.NativeClassPtr);
		NativeFieldInfoPtr_charts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "charts");
		NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "bar");
		NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "line");
		NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "curve");
		NativeFieldInfoPtr_pie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "pie");
		NativeFieldInfoPtr_doughnut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "doughnut");
		NativeFieldInfoPtr_halfDoughnut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "halfDoughnut");
		NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "dataSet");
		NativeFieldInfoPtr_dataSet2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "dataSet2");
		NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, "velocity");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_OnClick_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo3D>.NativeClassPtr, 100663326);
	}

	public Demo3D(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
