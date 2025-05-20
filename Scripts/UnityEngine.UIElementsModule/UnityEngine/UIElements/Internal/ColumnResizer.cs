namespace UnityEngine.UIElements.Internal;

internal class ColumnResizer : PointerManipulator
{
	private Vector2 m_Start;

	protected bool m_Active;

	private bool m_Resizing;

	private MultiColumnCollectionHeader m_Header;

	private Column m_Column;

	private VisualElement m_PreviewElement;

	public ColumnLayout columnLayout { get; set; }

	public bool preview { get; set; }

	public ColumnResizer(Column column)
	{
	}

	protected override void RegisterCallbacksOnTarget()
	{
	}

	protected override void UnregisterCallbacksFromTarget()
	{
	}

	private void OnKeyDown(KeyDownEvent e)
	{
	}

	private void OnPointerDown(PointerDownEvent e)
	{
	}

	private void OnPointerMove(PointerMoveEvent e)
	{
	}

	private void OnPointerUp(PointerUpEvent e)
	{
	}

	private void BeginDragResize(float pos)
	{
	}

	private void DragResize(float pos)
	{
	}

	private void UpdatePreviewPosition()
	{
	}

	private void EndDragResize(float pos, bool cancelled)
	{
	}
}
