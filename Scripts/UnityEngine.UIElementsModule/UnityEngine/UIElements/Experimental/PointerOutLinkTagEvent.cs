namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory.EnterLeave)]
public class PointerOutLinkTagEvent : PointerEventBase<PointerOutLinkTagEvent>
{
	static PointerOutLinkTagEvent()
	{
	}

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID)
	{
		return null;
	}
}
