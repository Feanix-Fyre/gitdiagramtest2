namespace UnityEngine.UIElements;

public interface IKeyboardEvent
{
	EventModifiers modifiers { get; }

	char character { get; }

	KeyCode keyCode { get; }
}
