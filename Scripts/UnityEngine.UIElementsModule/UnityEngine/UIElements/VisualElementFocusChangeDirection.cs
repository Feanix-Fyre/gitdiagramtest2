namespace UnityEngine.UIElements;

public class VisualElementFocusChangeDirection : FocusChangeDirection
{
	private static readonly VisualElementFocusChangeDirection s_Left;

	private static readonly VisualElementFocusChangeDirection s_Right;

	public static FocusChangeDirection left => null;

	public static FocusChangeDirection right => null;

	protected VisualElementFocusChangeDirection(int value)
		: base(0)
	{
	}
}
