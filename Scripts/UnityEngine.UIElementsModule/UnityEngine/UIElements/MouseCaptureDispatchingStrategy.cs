using System;

namespace UnityEngine.UIElements;

internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy
{
	[Flags]
	private enum EventBehavior
	{
		None = 0,
		IsCapturable = 1,
		IsSentExclusivelyToCapturingElement = 2
	}

	public bool CanDispatchEvent(EventBase evt)
	{
		return false;
	}

	public void DispatchEvent(EventBase evt, IPanel panel)
	{
	}
}
