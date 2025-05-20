namespace UnityEngine.UIElements;

public abstract class ContextualMenuManager
{
	internal bool displayMenuHandledOSX { get; set; }

	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);

	public void DisplayMenu(EventBase triggerEvent, IEventHandler target)
	{
	}

	protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
}
