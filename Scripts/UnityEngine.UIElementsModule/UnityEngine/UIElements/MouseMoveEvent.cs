namespace UnityEngine.UIElements;

[EventCategory(EventCategory.PointerMove)]
public class MouseMoveEvent : MouseEventBase<MouseMoveEvent>
{
	static MouseMoveEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent)
	{
		return null;
	}
}
