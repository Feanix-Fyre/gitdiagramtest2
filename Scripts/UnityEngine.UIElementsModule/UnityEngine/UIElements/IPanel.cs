using System;

namespace UnityEngine.UIElements;

public interface IPanel : IDisposable
{
	VisualElement visualTree { get; }

	EventDispatcher dispatcher { get; }

	ContextType contextType { get; }

	FocusController focusController { get; }

	VisualElement Pick(Vector2 point);
}
