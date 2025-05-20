namespace UnityEngine.UIElements;

public class KeyDownEvent : KeyboardEventBase<KeyDownEvent>
{
	static KeyDownEvent()
	{
	}

	internal void GetEquivalentImguiEvent(Event outImguiEvent)
	{
	}

	protected internal override void PostDispatch(IPanel panel)
	{
	}

	private void SendEquivalentNavigationEventIfAny(IPanel panel)
	{
	}
}
