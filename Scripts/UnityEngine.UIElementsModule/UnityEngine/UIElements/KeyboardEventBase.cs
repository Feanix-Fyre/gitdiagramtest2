namespace UnityEngine.UIElements;

[EventCategory(EventCategory.Keyboard)]
public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent where T : KeyboardEventBase<T>, new()
{
	public EventModifiers modifiers { get; protected set; }

	public char character { get; protected set; }

	public KeyCode keyCode { get; protected set; }

	public bool shiftKey => false;

	public bool ctrlKey => false;

	public bool commandKey => false;

	public bool altKey => false;

	internal bool functionKey => false;

	public bool actionKey => false;

	protected override void Init()
	{
	}

	private void LocalInit()
	{
	}

	public static T GetPooled(Event systemEvent)
	{
		return null;
	}
}
