using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;

namespace CP.ProChart;

public class ChartData : Il2CppSystem.Object
{
	public sealed class OnDataChangeDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe OnDataChangeDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(217)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static OnDataChangeDelegate()
		{
			Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "OnDataChangeDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr, 100681185);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr, 100681186);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr, 100681187);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDataChangeDelegate>.NativeClassPtr, 100681188);
		}

		public OnDataChangeDelegate(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator OnDataChangeDelegate(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnDataChangeDelegate>(P_0);
		}

		public static OnDataChangeDelegate operator +(OnDataChangeDelegate P_0, OnDataChangeDelegate P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<OnDataChangeDelegate>();
		}

		public static OnDataChangeDelegate operator -(OnDataChangeDelegate P_0, OnDataChangeDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnDataChangeDelegate>();
			}
			return (OnDataChangeDelegate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_onDataChangeDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_values;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeX;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rows_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Columns_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInternal_Protected_Void_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInternal_Protected_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChartData>.NativeClassPtr));

	public unsafe OnDataChangeDelegate onDataChangeDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onDataChangeDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OnDataChangeDelegate(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onDataChangeDelegate), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<List<float>> values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_values);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int sizeY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeY)) = num;
		}
	}

	public unsafe int sizeX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeX)) = num;
		}
	}

	public unsafe bool isEmpty
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int Rows
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Rows_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int Columns
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Columns_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237810, XrefRangeEnd = 237812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237830, RefRangeEnd = 237831, XrefRangeStart = 237812, XrefRangeEnd = 237830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resize(int rows, int columns)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rows);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &columns;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(141)]
	[CachedScanResults(RefRangeStart = 237835, RefRangeEnd = 237976, XrefRangeStart = 237831, XrefRangeEnd = 237835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInternal(int row, int column, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInternal_Protected_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 237980, RefRangeEnd = 238034, XrefRangeStart = 237976, XrefRangeEnd = 237980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetInternal(int row, int column)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInternal_Protected_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 238040, RefRangeEnd = 238060, XrefRangeStart = 238034, XrefRangeEnd = 238040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChartData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChartData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChartData()
	{
		Il2CppClassPointerStore<ChartData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CP.ProChart", "ChartData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChartData>.NativeClassPtr);
		NativeFieldInfoPtr_onDataChangeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "onDataChangeDelegate");
		NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "values");
		NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "sizeY");
		NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChartData>.NativeClassPtr, "sizeX");
		NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681177);
		NativeMethodInfoPtr_get_Rows_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681178);
		NativeMethodInfoPtr_get_Columns_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681179);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681180);
		NativeMethodInfoPtr_Resize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681181);
		NativeMethodInfoPtr_SetInternal_Protected_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681182);
		NativeMethodInfoPtr_GetInternal_Protected_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681183);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChartData>.NativeClassPtr, 100681184);
	}

	public ChartData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
