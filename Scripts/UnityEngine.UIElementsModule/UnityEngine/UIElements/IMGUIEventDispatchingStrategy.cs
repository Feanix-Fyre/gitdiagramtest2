namespace UnityEngine.UIElements;

internal class IMGUIEventDispatchingStrategy : IEventDispatchingStrategy
{
	public bool CanDispatchEvent(EventBase evt)
	{
		return false;
	}

	public void DispatchEvent(EventBase evt, IPanel panel)
	{
	}
}
