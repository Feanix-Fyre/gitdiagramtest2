using System;

namespace UnityEngine.UIElements;

public class ScrollView : VisualElement
{
	public new class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{
	}

	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode;

		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind;

		private UxmlBoolAttributeDescription m_ShowHorizontal;

		private UxmlBoolAttributeDescription m_ShowVertical;

		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility;

		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility;

		private UxmlFloatAttributeDescription m_HorizontalPageSize;

		private UxmlFloatAttributeDescription m_VerticalPageSize;

		private UxmlFloatAttributeDescription m_MouseWheelScrollSize;

		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior;

		private UxmlFloatAttributeDescription m_ScrollDecelerationRate;

		private UxmlFloatAttributeDescription m_Elasticity;

		private UxmlLongAttributeDescription m_ElasticAnimationIntervalMs;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public enum TouchScrollBehavior
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2
	}

	public enum NestedInteractionKind
	{
		Default = 0,
		StopScrolling = 1,
		ForwardScrolling = 2
	}

	internal enum TouchScrollingResult
	{
		Apply = 0,
		Forward = 1,
		Block = 2
	}

	private int m_FirstLayoutPass;

	private ScrollerVisibility m_HorizontalScrollerVisibility;

	private ScrollerVisibility m_VerticalScrollerVisibility;

	private VisualElement m_AttachedRootVisualContainer;

	private float m_SingleLineHeight;

	internal bool m_MouseWheelScrollSizeIsInline;

	private float m_HorizontalPageSize;

	private float m_VerticalPageSize;

	private float m_MouseWheelScrollSize;

	private static readonly float k_DefaultScrollDecelerationRate;

	private float m_ScrollDecelerationRate;

	private float k_ScaledPixelsPerPointMultiplier;

	private float k_TouchScrollInertiaBaseTimeInterval;

	private static readonly float k_DefaultElasticity;

	private float m_Elasticity;

	private TouchScrollBehavior m_TouchScrollBehavior;

	private NestedInteractionKind m_NestedInteractionKind;

	private static readonly long k_DefaultElasticAnimationInterval;

	private long m_ElasticAnimationIntervalMs;

	private VisualElement m_ContentContainer;

	private VisualElement m_ContentAndVerticalScrollContainer;

	private float previousVerticalTouchScrollTimeStamp;

	private float previousHorizontalTouchScrollTimeStamp;

	private float elapsedTimeSinceLastVerticalTouchScroll;

	private float elapsedTimeSinceLastHorizontalTouchScroll;

	public static readonly string ussClassName;

	public static readonly string viewportUssClassName;

	public static readonly string horizontalVariantViewportUssClassName;

	public static readonly string verticalVariantViewportUssClassName;

	public static readonly string verticalHorizontalVariantViewportUssClassName;

	public static readonly string contentAndVerticalScrollUssClassName;

	public static readonly string contentUssClassName;

	public static readonly string horizontalVariantContentUssClassName;

	public static readonly string verticalVariantContentUssClassName;

	public static readonly string verticalHorizontalVariantContentUssClassName;

	public static readonly string hScrollerUssClassName;

	public static readonly string vScrollerUssClassName;

	public static readonly string horizontalVariantUssClassName;

	public static readonly string verticalVariantUssClassName;

	public static readonly string verticalHorizontalVariantUssClassName;

	public static readonly string scrollVariantUssClassName;

	private ScrollViewMode m_Mode;

	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem;

	private Vector2 m_StartPosition;

	private Vector2 m_PointerStartPosition;

	private Vector2 m_Velocity;

	private Vector2 m_SpringBackVelocity;

	private Vector2 m_LowBounds;

	private Vector2 m_HighBounds;

	private float m_LastVelocityLerpTime;

	private bool m_StartedMoving;

	private bool m_TouchPointerMoveAllowed;

	private bool m_TouchStoppedVelocity;

	private VisualElement m_CapturedTarget;

	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback;

	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback;

	internal IVisualElementScheduledItem m_PostPointerUpAnimation;

	public ScrollerVisibility horizontalScrollerVisibility
	{
		get
		{
			return default(ScrollerVisibility);
		}
		set
		{
		}
	}

	public ScrollerVisibility verticalScrollerVisibility
	{
		get
		{
			return default(ScrollerVisibility);
		}
		set
		{
		}
	}

	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	public bool showHorizontal
	{
		set
		{
		}
	}

	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	public bool showVertical
	{
		set
		{
		}
	}

	internal bool needsHorizontal => false;

	internal bool needsVertical => false;

	internal bool isVerticalScrollDisplayed => false;

	internal bool isHorizontalScrollDisplayed => false;

	public Vector2 scrollOffset
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public float horizontalPageSize
	{
		set
		{
		}
	}

	public float verticalPageSize
	{
		set
		{
		}
	}

	public float mouseWheelScrollSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal float scrollableWidth => 0f;

	internal float scrollableHeight => 0f;

	private bool hasInertia => false;

	public float scrollDecelerationRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float elasticity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public TouchScrollBehavior touchScrollBehavior
	{
		get
		{
			return default(TouchScrollBehavior);
		}
		set
		{
		}
	}

	public NestedInteractionKind nestedInteractionKind
	{
		get
		{
			return default(NestedInteractionKind);
		}
		set
		{
		}
	}

	public long elasticAnimationIntervalMs
	{
		set
		{
		}
	}

	public VisualElement contentViewport { get; }

	public Scroller horizontalScroller { get; }

	public Scroller verticalScroller { get; }

	public override VisualElement contentContainer => null;

	public ScrollViewMode mode
	{
		get
		{
			return default(ScrollViewMode);
		}
		set
		{
		}
	}

	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt)
	{
	}

	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt)
	{
	}

	private void UpdateHorizontalSliderPageSize()
	{
	}

	private void UpdateVerticalSliderPageSize()
	{
	}

	internal void UpdateContentViewTransform()
	{
	}

	public void ScrollTo(VisualElement child)
	{
	}

	private float GetXDeltaOffset(VisualElement child)
	{
		return 0f;
	}

	private float GetYDeltaOffset(VisualElement child)
	{
		return 0f;
	}

	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax)
	{
		return 0f;
	}

	public ScrollView()
	{
	}

	public ScrollView(ScrollViewMode scrollViewMode)
	{
	}

	private void SetScrollViewMode(ScrollViewMode mode)
	{
	}

	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}

	private void OnDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	private void OnPointerCapture(PointerCaptureEvent evt)
	{
	}

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
	{
	}

	private void OnGeometryChanged(GeometryChangedEvent evt)
	{
	}

	private void ScheduleResetLayoutPass()
	{
	}

	private void ResetLayoutPass()
	{
	}

	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit)
	{
		return 0f;
	}

	private void ComputeInitialSpringBackVelocity()
	{
	}

	private void SpringBack()
	{
	}

	internal void ApplyScrollInertia()
	{
	}

	private void PostPointerUpAnimation()
	{
	}

	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	internal void InitTouchScrolling(Vector2 position)
	{
	}

	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position)
	{
		return default(TouchScrollingResult);
	}

	private bool ApplyTouchScrolling(Vector2 newScrollOffset)
	{
		return false;
	}

	private bool ReleaseScrolling(int pointerId, IEventHandler target)
	{
		return false;
	}

	private void ExecuteElasticSpringAnimation()
	{
	}

	private void AdjustScrollers()
	{
	}

	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical)
	{
	}

	private void OnScrollersGeometryChanged(GeometryChangedEvent evt)
	{
	}

	private void OnScrollWheel(WheelEvent evt)
	{
	}

	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt)
	{
	}

	private void OnRootPointerUp(PointerUpEvent evt)
	{
	}

	private void ReadSingleLineHeight()
	{
	}

	private void UpdateElasticBehaviour()
	{
	}
}
