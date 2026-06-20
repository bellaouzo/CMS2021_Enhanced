using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions;

public class UIVerticalScroller : MonoBehaviour
{
	[ObfuscatedName("UnityEngine.UI.Extensions.UIVerticalScroller/<>c__DisplayClass17_0")]
	public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddListener_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr));

		public unsafe UIVerticalScroller __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UIVerticalScroller(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass17_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119757, XrefRangeEnd = 119760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddListener_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddListener_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass17_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "<>c__DisplayClass17_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr, "index");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr, 100670924);
			NativeMethodInfoPtr__AddListener_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass17_0>.NativeClassPtr, 100670925);
		}

		public __c__DisplayClass17_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__scrollingPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr__arrayOfElements;

	private static readonly System.IntPtr NativeFieldInfoPtr__center;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartingIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScrollUpButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScrollDownButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonClicked;

	private static readonly System.IntPtr NativeFieldInfoPtr_distReposition;

	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_minElementsNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaY;

	private static readonly System.IntPtr NativeFieldInfoPtr_result;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectTransform_ArrayOf_GameObject_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Private_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoSomething_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollingElements_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResults_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnapToElement_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__16_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__16_1_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr));

	public unsafe RectTransform _scrollingPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrollingPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrollingPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> _arrayOfElements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arrayOfElements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arrayOfElements), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform _center
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__center);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__center), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int StartingIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartingIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartingIndex)) = num;
		}
	}

	public unsafe GameObject ScrollUpButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScrollUpButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScrollUpButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject ScrollDownButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScrollDownButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScrollDownButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UnityEvent<int> ButtonClicked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonClicked);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UnityEvent<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonClicked), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> distReposition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distReposition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distReposition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> distance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int minElementsNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minElementsNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minElementsNum)) = num;
		}
	}

	public unsafe int elementLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementLength)) = num;
		}
	}

	public unsafe float deltaY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaY)) = num;
		}
	}

	public unsafe string result
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_result), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119760, XrefRangeEnd = 119763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIVerticalScroller()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 119766, RefRangeEnd = 119769, XrefRangeStart = 119763, XrefRangeEnd = 119766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIVerticalScroller(RectTransform scrollingPanel, Il2CppReferenceArray<GameObject> arrayOfElements, RectTransform center)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollingPanel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(arrayOfElements);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(center);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RectTransform_ArrayOf_GameObject_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119769, XrefRangeEnd = 119799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 119869, RefRangeEnd = 119872, XrefRangeStart = 119799, XrefRangeEnd = 119869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119872, XrefRangeEnd = 119885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddListener(GameObject button, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddListener_Private_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119885, XrefRangeEnd = 119888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoSomething(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoSomething_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 119920, RefRangeEnd = 119923, XrefRangeStart = 119888, XrefRangeEnd = 119920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119932, RefRangeEnd = 119933, XrefRangeStart = 119923, XrefRangeEnd = 119932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollingElements(float position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollingElements_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(30)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe string GetResults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResults_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 119942, RefRangeEnd = 119946, XrefRangeStart = 119933, XrefRangeEnd = 119942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SnapToElement(int element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&element);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnapToElement_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 119960, RefRangeEnd = 119964, XrefRangeStart = 119946, XrefRangeEnd = 119960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 119975, RefRangeEnd = 119979, XrefRangeStart = 119964, XrefRangeEnd = 119975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119979, XrefRangeEnd = 119980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__16_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119980, XrefRangeEnd = 119981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__16_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__16_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UIVerticalScroller()
	{
		Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "UIVerticalScroller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr);
		NativeFieldInfoPtr__scrollingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "_scrollingPanel");
		NativeFieldInfoPtr__arrayOfElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "_arrayOfElements");
		NativeFieldInfoPtr__center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "_center");
		NativeFieldInfoPtr_StartingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "StartingIndex");
		NativeFieldInfoPtr_ScrollUpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "ScrollUpButton");
		NativeFieldInfoPtr_ScrollDownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "ScrollDownButton");
		NativeFieldInfoPtr_ButtonClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "ButtonClicked");
		NativeFieldInfoPtr_distReposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "distReposition");
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_minElementsNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "minElementsNum");
		NativeFieldInfoPtr_elementLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "elementLength");
		NativeFieldInfoPtr_deltaY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "deltaY");
		NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, "result");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670910);
		NativeMethodInfoPtr__ctor_Public_Void_RectTransform_ArrayOf_GameObject_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670911);
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670912);
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670913);
		NativeMethodInfoPtr_AddListener_Private_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670914);
		NativeMethodInfoPtr_DoSomething_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670915);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670916);
		NativeMethodInfoPtr_ScrollingElements_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670917);
		NativeMethodInfoPtr_GetResults_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670918);
		NativeMethodInfoPtr_SnapToElement_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670919);
		NativeMethodInfoPtr_ScrollUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670920);
		NativeMethodInfoPtr_ScrollDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670921);
		NativeMethodInfoPtr__Start_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670922);
		NativeMethodInfoPtr__Start_b__16_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalScroller>.NativeClassPtr, 100670923);
	}

	public UIVerticalScroller(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
