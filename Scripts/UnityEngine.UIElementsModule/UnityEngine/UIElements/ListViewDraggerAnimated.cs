namespace UnityEngine.UIElements;

internal class ListViewDraggerAnimated : ListViewDragger
{
	private int m_DragStartIndex;

	private int m_CurrentIndex;

	private float m_SelectionHeight;

	private float m_LocalOffsetOnStart;

	private Vector3 m_CurrentPointerPosition;

	private ReusableCollectionItem m_Item;

	private ReusableCollectionItem m_OffsetItem;

	public bool isDragging { get; private set; }

	public ReusableCollectionItem draggedItem => null;

	protected override bool supportsDragEvents => false;

	public ListViewDraggerAnimated(BaseVerticalCollectionView listView)
		: base(null)
	{
	}

	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition)
	{
		return default(StartDragArgs);
	}

	protected internal override void UpdateDrag(Vector3 pointerPosition)
	{
	}

	private void Animate(ReusableCollectionItem element, float paddingTop)
	{
	}

	protected internal override void OnDrop(Vector3 pointerPosition)
	{
	}

	protected override void ClearDragAndDropUI(bool dragCancelled)
	{
	}

	protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition)
	{
		return false;
	}
}
