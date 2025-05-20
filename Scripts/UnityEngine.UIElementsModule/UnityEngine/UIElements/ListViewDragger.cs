using System;

namespace UnityEngine.UIElements;

internal class ListViewDragger : DragEventsProcessor
{
	internal struct DragPosition : IEquatable<DragPosition>
	{
		public int insertAtIndex;

		public int parentId;

		public int childIndex;

		public ReusableCollectionItem recycledItem;

		public DragAndDropPosition dropPosition;

		public bool Equals(DragPosition other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private DragPosition m_LastDragPosition;

	private VisualElement m_DragHoverBar;

	private VisualElement m_DragHoverItemMarker;

	private VisualElement m_DragHoverSiblingMarker;

	private float m_LeftIndentation;

	private float m_SiblingBottom;

	protected BaseVerticalCollectionView targetView => null;

	protected ScrollView targetScrollView => null;

	public ICollectionDragAndDropController dragAndDropController { get; set; }

	public ListViewDragger(BaseVerticalCollectionView listView)
		: base(null)
	{
	}

	protected override bool CanStartDrag(Vector3 pointerPosition)
	{
		return false;
	}

	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition)
	{
		return default(StartDragArgs);
	}

	protected internal override void UpdateDrag(Vector3 pointerPosition)
	{
	}

	private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition)
	{
		return default(DragVisualMode);
	}

	protected internal override void OnDrop(Vector3 pointerPosition)
	{
	}

	internal void HandleDragAndScroll(Vector2 pointerPosition)
	{
	}

	private void HandleAutoExpansion(Vector2 pointerPosition)
	{
	}

	private void ApplyDragAndDropUI(DragPosition dragPosition)
	{
	}

	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition)
	{
		return false;
	}

	private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition)
	{
	}

	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition)
	{
	}

	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId)
	{
		previousItemId = default(int);
		nextItemId = default(int);
	}

	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition)
	{
		return default(DragAndDropArgs);
	}

	private float GetHoverBarTopPosition(ReusableCollectionItem item)
	{
		return 0f;
	}

	private void PlaceHoverBarAtElement(ReusableCollectionItem item)
	{
	}

	private void PlaceHoverBarAt(float top, float indentationPadding = -1f, float siblingBottom = -1f)
	{
	}

	protected override void ClearDragAndDropUI(bool dragCancelled)
	{
	}

	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition)
	{
		return null;
	}
}
