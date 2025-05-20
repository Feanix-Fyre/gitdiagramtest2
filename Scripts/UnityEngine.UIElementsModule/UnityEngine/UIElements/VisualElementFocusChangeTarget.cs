namespace UnityEngine.UIElements;

internal class VisualElementFocusChangeTarget : FocusChangeDirection
{
	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool;

	public Focusable target { get; private set; }

	public static VisualElementFocusChangeTarget GetPooled(Focusable target)
	{
		return null;
	}

	protected override void Dispose()
	{
	}

	internal override void ApplyTo(FocusController focusController, Focusable f)
	{
	}

	public VisualElementFocusChangeTarget()
		: base(0)
	{
	}
}
