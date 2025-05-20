namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Navigation)]
public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent where T : NavigationEventBase<T>, new()
{
	public EventModifiers modifiers { get; protected set; }

	public bool shiftKey => false;

	public bool altKey => false;

	internal NavigationDeviceType deviceType { get; private set; }

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}

	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
	{
		return null;
	}
}
