namespace UnityEngine.UIElements;

public class MouseDownEvent : MouseEventBase<MouseDownEvent>
{
	static MouseDownEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
	{
		return null;
	}

	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent)
	{
		return null;
	}

	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent)
	{
		return null;
	}
}
