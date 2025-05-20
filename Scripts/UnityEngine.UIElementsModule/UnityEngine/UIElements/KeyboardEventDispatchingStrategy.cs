namespace UnityEngine.UIElements;

internal class KeyboardEventDispatchingStrategy : IEventDispatchingStrategy
{
	public bool CanDispatchEvent(EventBase evt)
	{
		return false;
	}

	public void DispatchEvent(EventBase evt, IPanel panel)
	{
	}
}
