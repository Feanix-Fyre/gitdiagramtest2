namespace UnityEngine.UIElements;

public abstract class PointerManipulator : MouseManipulator
{
	private int m_CurrentPointerId;

	protected bool CanStartManipulation(IPointerEvent e)
	{
		return false;
	}

	protected bool CanStopManipulation(IPointerEvent e)
	{
		return false;
	}
}
