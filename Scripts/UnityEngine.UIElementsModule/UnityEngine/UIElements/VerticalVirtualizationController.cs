using System;
using System.Collections.Generic;
using UnityEngine.Pool;

namespace UnityEngine.UIElements;

internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController where T : ReusableCollectionItem, new()
{
	private readonly UnityEngine.Pool.ObjectPool<T> m_Pool;

	protected BaseVerticalCollectionView m_CollectionView;

	protected List<T> m_ActiveItems;

	protected T m_DraggedItem;

	private int m_LastFocusedElementIndex;

	private List<int> m_LastFocusedElementTreeChildIndexes;

	protected readonly Func<T, bool> m_VisibleItemPredicateDelegate;

	protected List<T> m_ScrollInsertionList;

	private VisualElement m_EmptyRows;

	public override IEnumerable<ReusableCollectionItem> activeItems => null;

	internal int itemsCount => 0;

	internal T firstVisibleItem => null;

	internal T lastVisibleItem => null;

	public override int visibleItemCount => 0;

	protected SerializedVirtualizationData serializedData => null;

	public override int firstVisibleIndex
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	protected float lastHeight => 0f;

	protected virtual bool alwaysRebindOnRefresh => false;

	protected virtual bool VisibleItemPredicate(T i)
	{
		return false;
	}

	protected VerticalVirtualizationController(BaseVerticalCollectionView collectionView)
		: base(null)
	{
	}

	public override void Refresh(bool rebuild)
	{
	}

	protected void Setup(T recycledItem, int newIndex)
	{
	}

	public override void OnFocus(VisualElement leafTarget)
	{
	}

	public override void OnBlur(VisualElement willFocus)
	{
	}

	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex)
	{
	}

	public override void UpdateBackground()
	{
	}

	internal override void StartDragItem(ReusableCollectionItem item)
	{
	}

	internal override void EndDrag(int dropIndex)
	{
	}

	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
	{
		return null;
	}

	internal virtual void ReleaseItem(int activeItemsIndex)
	{
	}

	private void OnDestroyItem(ReusableCollectionItem item)
	{
	}

	protected int GetDraggedIndex()
	{
		return 0;
	}
}
