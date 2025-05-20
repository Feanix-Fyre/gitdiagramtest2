using System;

namespace UnityEngine.UIElements;

public class ContextualMenuManipulator : MouseManipulator
{
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder;

	public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder)
	{
	}

	protected override void RegisterCallbacksOnTarget()
	{
	}

	protected override void UnregisterCallbacksFromTarget()
	{
	}

	private void OnMouseUpDownEvent(IMouseEvent evt)
	{
	}

	private void OnMouseDownEventOSX(MouseDownEvent evt)
	{
	}

	private void OnMouseUpEventOSX(MouseUpEvent evt)
	{
	}

	private void OnKeyUpEvent(KeyUpEvent evt)
	{
	}

	private void DoDisplayMenu(EventBase evt)
	{
	}

	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt)
	{
	}
}
