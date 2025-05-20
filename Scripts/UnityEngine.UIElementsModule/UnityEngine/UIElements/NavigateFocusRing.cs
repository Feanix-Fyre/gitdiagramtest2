namespace UnityEngine.UIElements;

internal class NavigateFocusRing : IFocusRing
{
	public class ChangeDirection : FocusChangeDirection
	{
		public ChangeDirection(int i)
			: base(0)
		{
		}
	}

	private struct FocusableHierarchyTraversal
	{
		public VisualElement currentFocusable;

		public Rect validRect;

		public bool firstPass;

		public ChangeDirection direction;

		private bool ValidateHierarchyTraversal(VisualElement v)
		{
			return false;
		}

		private bool ValidateElement(VisualElement v)
		{
			return false;
		}

		private int Order(VisualElement a, VisualElement b)
		{
			return 0;
		}

		private int StrictOrder(VisualElement a, VisualElement b)
		{
			return 0;
		}

		private int StrictOrder(Rect ra, Rect rb)
		{
			return 0;
		}

		private int TieBreaker(Rect ra, Rect rb)
		{
			return 0;
		}

		public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null)
		{
			return null;
		}
	}

	public static readonly ChangeDirection Left;

	public static readonly ChangeDirection Right;

	public static readonly ChangeDirection Up;

	public static readonly ChangeDirection Down;

	public static readonly FocusChangeDirection Next;

	public static readonly FocusChangeDirection Previous;

	private readonly VisualElement m_Root;

	private readonly VisualElementFocusRing m_Ring;

	private FocusController focusController => null;

	public NavigateFocusRing(VisualElement root)
	{
	}

	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
	{
		return null;
	}

	public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
	{
		return null;
	}

	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction)
	{
		return null;
	}

	private static bool IsActive(VisualElement v)
	{
		return false;
	}

	private static bool IsNavigable(Focusable focusable)
	{
		return false;
	}
}
