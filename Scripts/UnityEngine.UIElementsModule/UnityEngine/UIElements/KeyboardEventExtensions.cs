namespace UnityEngine.UIElements;

internal static class KeyboardEventExtensions
{
	internal static bool ShouldSendNavigationMoveEvent(this KeyDownEvent e)
	{
		return false;
	}

	internal static bool ShouldSendNavigationMoveEventRuntime(this Event e)
	{
		return false;
	}
}
