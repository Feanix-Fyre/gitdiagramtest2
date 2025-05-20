using System.Collections.Generic;

namespace UnityEngine.UIElements;

public abstract class MouseManipulator : Manipulator
{
	private ManipulatorActivationFilter m_currentActivator;

	public List<ManipulatorActivationFilter> activators { get; private set; }

	protected bool CanStartManipulation(IMouseEvent e)
	{
		return false;
	}

	protected bool CanStopManipulation(IMouseEvent e)
	{
		return false;
	}
}
