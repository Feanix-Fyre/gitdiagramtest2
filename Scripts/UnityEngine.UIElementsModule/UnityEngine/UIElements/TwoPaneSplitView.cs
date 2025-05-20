namespace UnityEngine.UIElements;

public class TwoPaneSplitView : VisualElement
{
	public new class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
	{
	}

	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		private UxmlIntAttributeDescription m_FixedPaneIndex;

		private UxmlIntAttributeDescription m_FixedPaneInitialDimension;

		private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private static readonly string s_UssClassName;

	private static readonly string s_ContentContainerClassName;

	private static readonly string s_HandleDragLineClassName;

	private static readonly string s_HandleDragLineVerticalClassName;

	private static readonly string s_HandleDragLineHorizontalClassName;

	private static readonly string s_HandleDragLineAnchorClassName;

	private static readonly string s_HandleDragLineAnchorVerticalClassName;

	private static readonly string s_HandleDragLineAnchorHorizontalClassName;

	private static readonly string s_VerticalClassName;

	private static readonly string s_HorizontalClassName;

	private VisualElement m_LeftPane;

	private VisualElement m_RightPane;

	private VisualElement m_FixedPane;

	private VisualElement m_FlexedPane;

	[SerializeField]
	private float m_FixedPaneDimension;

	private VisualElement m_DragLine;

	private VisualElement m_DragLineAnchor;

	private bool m_CollapseMode;

	private VisualElement m_Content;

	private TwoPaneSplitViewOrientation m_Orientation;

	private int m_FixedPaneIndex;

	private float m_FixedPaneInitialDimension;

	internal TwoPaneSplitViewResizer m_Resizer;

	public VisualElement fixedPane => null;

	public VisualElement flexedPane => null;

	public int fixedPaneIndex => 0;

	public TwoPaneSplitViewOrientation orientation => default(TwoPaneSplitViewOrientation);

	internal float fixedPaneDimension
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override VisualElement contentContainer => null;

	internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation)
	{
	}

	private void OnPostDisplaySetup(GeometryChangedEvent evt)
	{
	}

	private void PostDisplaySetup()
	{
	}

	private void OnSizeChange(GeometryChangedEvent evt)
	{
	}

	private void UpdateLayout(bool updateFixedPane, bool updateDragLine)
	{
	}

	internal override void OnViewDataReady()
	{
	}

	private void SetDragLineOffset(float offset)
	{
	}

	private void SetFixedPaneDimension(float dimension)
	{
	}
}
