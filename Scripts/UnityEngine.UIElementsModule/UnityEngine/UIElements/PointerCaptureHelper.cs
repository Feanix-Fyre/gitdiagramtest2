namespace UnityEngine.UIElements;

public static class PointerCaptureHelper
{
	private static PointerDispatchState GetStateFor(IEventHandler handler)
	{
		return null;
	}

	public static bool HasPointerCapture(this IEventHandler handler, int pointerId)
	{
		return false;
	}

	public static void CapturePointer(this IEventHandler handler, int pointerId)
	{
	}

	public static void ReleasePointer(this IEventHandler handler, int pointerId)
	{
	}

	public static IEventHandler GetCapturingElement(this IPanel panel, int pointerId)
	{
		return null;
	}

	public static void ReleasePointer(this IPanel panel, int pointerId)
	{
	}

	internal static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId)
	{
	}

	internal static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId)
	{
	}

	internal static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt)
	{
		return false;
	}

	internal static void ProcessPointerCapture(this IPanel panel, int pointerId)
	{
	}
}
