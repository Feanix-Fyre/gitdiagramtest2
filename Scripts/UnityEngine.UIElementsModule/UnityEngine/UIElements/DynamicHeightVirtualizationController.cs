using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
{
	private readonly struct ContentHeightCacheInfo
	{
		public readonly float sum;

		public readonly int count;

		public ContentHeightCacheInfo(float sum, int count)
		{
			this.sum = 0f;
			this.count = 0;
		}
	}

	private enum VirtualizationChange
	{
		None = 0,
		Resize = 1,
		Scroll = 2,
		ForcedScroll = 3
	}

	private enum ScrollDirection
	{
		Idle = 0,
		Up = 1,
		Down = 2
	}

	private int m_HighestCachedIndex;

	private readonly Dictionary<int, float> m_ItemHeightCache;

	private readonly Dictionary<int, ContentHeightCacheInfo> m_ContentHeightCache;

	private readonly HashSet<int> m_WaitingCache;

	private int m_ForcedFirstVisibleItem;

	private int m_ForcedLastVisibleItem;

	private bool m_StickToBottom;

	private VirtualizationChange m_LastChange;

	private ScrollDirection m_ScrollDirection;

	private Vector2 m_DelayedScrollOffset;

	private float m_AccumulatedHeight;

	private float m_MinimumItemHeight;

	private Action m_FillCallback;

	private Action m_ScrollCallback;

	private Action m_ScrollResetCallback;

	private Action<ReusableCollectionItem> m_GeometryChangedCallback;

	private IVisualElementScheduledItem m_ScheduledItem;

	private IVisualElementScheduledItem m_ScrollScheduledItem;

	private IVisualElementScheduledItem m_ScrollResetScheduledItem;

	private Predicate<int> m_IndexOutOfBoundsPredicate;

	private float defaultExpectedHeight => 0f;

	private float contentPadding
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float contentHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private int anchoredIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private float anchorOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float viewportMaxOffset => 0f;

	protected override bool alwaysRebindOnRefresh => false;

	public DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView)
		: base((BaseVerticalCollectionView)null)
	{
	}

	public override void Refresh(bool rebuild)
	{
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

	private void OnScrollUpdate()
	{
	}

	private void CycleItems(int firstIndex)
	{
	}

	private bool NeedsFill()
	{
		return false;
	}

	private void Fill()
	{
	}

	private void UpdateScrollViewContainer(float previousHeight, float newHeight)
	{
	}

	private void ApplyScrollViewUpdate(bool dimensionsOnly = false)
	{
	}

	private void UpdateAnchor()
	{
	}

	private void ScheduleFill()
	{
	}

	private void ScheduleScroll()
	{
	}

	private void ScheduleScrollDirectionReset()
	{
	}

	private void ResetScroll()
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

	private int GetFirstVisibleItem(float offset)
	{
		return 0;
	}

	public override float GetExpectedContentHeight()
	{
		return 0f;
	}

	private float GetContentHeightForIndex(int lastIndex)
	{
		return 0f;
	}

	private ContentHeightCacheInfo GetCachedContentHeight(int index)
	{
		return default(ContentHeightCacheInfo);
	}

	private void RegisterItemHeight(int index, float height)
	{
	}

	private void UnregisterItemHeight(int index)
	{
	}

	private void CleanItemHeightCache()
	{
	}

	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item)
	{
	}

	private bool UpdateRegisteredHeight(ReusableCollectionItem item)
	{
		return false;
	}

	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
	{
		return null;
	}

	internal override void ReleaseItem(int activeItemsIndex)
	{
	}

	internal override void StartDragItem(ReusableCollectionItem item)
	{
	}

	internal override void EndDrag(int dropIndex)
	{
	}

	private void HideItem(int activeItemsIndex)
	{
	}

	private void MarkWaitingForLayout(T item)
	{
	}

	private bool IsIndexOutOfBounds(int i)
	{
		return false;
	}
}
