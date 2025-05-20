namespace UnityEngine.UIElements;

public class WheelEvent : MouseEventBase<WheelEvent>
{
	public Vector3 delta { get; private set; }

	static WheelEvent()
	{
	}

	public new static WheelEvent GetPooled(Event systemEvent)
	{
		return null;
	}

	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent)
	{
		return null;
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}
}
