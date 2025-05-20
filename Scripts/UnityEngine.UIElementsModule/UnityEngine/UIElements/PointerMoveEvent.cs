namespace UnityEngine.UIElements;

[EventCategory(EventCategory.PointerMove)]
public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
{
	internal bool isHandledByDraggable { get; set; }

	static PointerMoveEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	protected internal override void PostDispatch(IPanel panel)
	{
	}
}
