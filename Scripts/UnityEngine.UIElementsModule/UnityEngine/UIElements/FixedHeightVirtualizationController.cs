namespace UnityEngine.UIElements;

internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
{
	private float resolvedItemHeight => 0f;

	protected override bool VisibleItemPredicate(T i)
	{
		return false;
	}

	public FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView)
		: base((BaseVerticalCollectionView)null)
	{
	}

	public override int GetIndexFromPosition(Vector2 position)
	{
		return 0;
	}

	public override float GetExpectedItemHeight(int index)
	{
		return 0f;
	}

	public override float GetExpectedContentHeight()
	{
		return 0f;
	}

	public override void ScrollToItem(int index)
	{
	}

	public override void Resize(Vector2 size)
	{
	}

	public override void OnScroll(Vector2 scrollOffset)
	{
	}

	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
	{
		return null;
	}

	internal override void EndDrag(int dropIndex)
	{
	}
}
