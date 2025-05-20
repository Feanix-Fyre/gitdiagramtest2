namespace UnityEngine.UIElements;

[EventCategory(EventCategory.EnterLeaveWindow)]
public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
{
	static MouseLeaveWindowEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public new static MouseLeaveWindowEvent GetPooled(Event systemEvent)
	{
		return null;
	}

	protected internal override void PostDispatch(IPanel panel)
	{
	}
}
