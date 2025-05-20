using System.Collections.Generic;

namespace UnityEngine.UIElements;

public class VisualElementFocusRing : IFocusRing
{
	public enum DefaultFocusOrder
	{
		ChildOrder = 0,
		PositionXY = 1,
		PositionYX = 2
	}

	private class FocusRingRecord
	{
		public int m_AutoIndex;

		public Focusable m_Focusable;

		public bool m_IsSlot;

		public List<FocusRingRecord> m_ScopeNavigationOrder;
	}

	private readonly VisualElement root;

	private List<FocusRingRecord> m_FocusRing;

	private FocusController focusController => null;

	public DefaultFocusOrder defaultFocusOrder { get; set; }

	public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = DefaultFocusOrder.ChildOrder)
	{
	}

	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b)
	{
		return 0;
	}

	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b)
	{
		return 0;
	}

	private void DoUpdate()
	{
	}

	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList)
	{
	}

	private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList)
	{
	}

	private int GetFocusableInternalIndex(Focusable f)
	{
		return 0;
	}

	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
	{
		return null;
	}

	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
	{
		return null;
	}

	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable)
	{
		return null;
	}

	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable)
	{
		return null;
	}
}
