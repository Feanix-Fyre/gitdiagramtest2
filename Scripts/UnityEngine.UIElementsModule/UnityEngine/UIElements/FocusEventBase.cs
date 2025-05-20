namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Focus)]
public abstract class FocusEventBase<T> : EventBase<T> where T : FocusEventBase<T>, new()
{
	public Focusable relatedTarget { get; private set; }

	public FocusChangeDirection direction { get; private set; }

	protected FocusController focusController { get; private set; }

	internal bool IsFocusDelegated { get; private set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false)
	{
		return null;
	}
}
