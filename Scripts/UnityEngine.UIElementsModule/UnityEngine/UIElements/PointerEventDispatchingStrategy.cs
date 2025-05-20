namespace UnityEngine.UIElements;

internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy
{
	public bool CanDispatchEvent(EventBase evt)
	{
		return false;
	}

	public virtual void DispatchEvent(EventBase evt, IPanel panel)
	{
	}

	private static void SendEventToTarget(EventBase evt, IPanel panel)
	{
	}

	private static void SetBestTargetForEvent(EventBase evt, IPanel panel)
	{
	}

	private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer)
	{
		elementUnderPointer = null;
	}
}
