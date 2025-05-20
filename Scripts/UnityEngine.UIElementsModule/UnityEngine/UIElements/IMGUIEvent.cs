namespace UnityEngine.UIElements;

[EventCategory(EventCategory.IMGUI)]
public class IMGUIEvent : EventBase<IMGUIEvent>
{
	static IMGUIEvent()
	{
	}

	public static IMGUIEvent GetPooled(Event systemEvent)
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
