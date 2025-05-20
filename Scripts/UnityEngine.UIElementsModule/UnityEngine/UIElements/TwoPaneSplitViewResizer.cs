namespace UnityEngine.UIElements;

internal class TwoPaneSplitViewResizer : PointerManipulator
{
	private Vector3 m_Start;

	protected bool m_Active;

	private TwoPaneSplitView m_SplitView;

	private int m_Direction;

	private TwoPaneSplitViewOrientation orientation => default(TwoPaneSplitViewOrientation);

	private VisualElement fixedPane => null;

	private VisualElement flexedPane => null;

	private float fixedPaneMinDimension => 0f;

	private float fixedPaneMargins => 0f;

	private float flexedPaneMinDimension => 0f;

	private float flexedPaneMargin => 0f;

	public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir)
	{
	}

	protected override void RegisterCallbacksOnTarget()
	{
	}

	protected override void UnregisterCallbacksFromTarget()
	{
	}

	public void ApplyDelta(float delta)
	{
	}

	protected void OnPointerDown(PointerDownEvent e)
	{
	}

	protected void OnPointerMove(PointerMoveEvent e)
	{
	}

	protected void OnPointerUp(PointerUpEvent e)
	{
	}
}
