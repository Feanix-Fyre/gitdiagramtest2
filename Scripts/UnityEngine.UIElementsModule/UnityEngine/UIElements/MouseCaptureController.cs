namespace UnityEngine.UIElements;

public static class MouseCaptureController
{
	public static bool HasMouseCapture(this IEventHandler handler)
	{
		return false;
	}

	public static void CaptureMouse(this IEventHandler handler)
	{
	}

	public static void ReleaseMouse(this IEventHandler handler)
	{
	}
}
