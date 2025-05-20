namespace UnityEngine.UIElements;

internal class PointerDispatchState
{
	private IEventHandler[] m_PendingPointerCapture;

	private IEventHandler[] m_PointerCapture;

	private bool[] m_ShouldSendCompatibilityMouseEvents;

	internal void Reset()
	{
	}

	public IEventHandler GetCapturingElement(int pointerId)
	{
		return null;
	}

	public bool HasPointerCapture(IEventHandler handler, int pointerId)
	{
		return false;
	}

	public void CapturePointer(IEventHandler handler, int pointerId)
	{
	}

	public void ReleasePointer(int pointerId)
	{
	}

	public void ReleasePointer(IEventHandler handler, int pointerId)
	{
	}

	public void ProcessPointerCapture(int pointerId)
	{
	}

	public void ActivateCompatibilityMouseEvents(int pointerId)
	{
	}

	public void PreventCompatibilityMouseEvents(int pointerId)
	{
	}

	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt)
	{
		return false;
	}
}
