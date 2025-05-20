namespace UnityEngine.UIElements;

internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy
{
	public bool CanDispatchEvent(EventBase evt)
	{
		return false;
	}

	public void DispatchEvent(EventBase evt, IPanel iPanel)
	{
	}

	private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel)
	{
		return false;
	}

	private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel)
	{
		return false;
	}

	private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel)
	{
		return false;
	}

	private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel)
	{
	}

	private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse)
	{
		elementUnderMouse = null;
	}

	private static bool IsDone(EventBase evt)
	{
		return false;
	}
}
