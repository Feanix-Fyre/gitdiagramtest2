using System;

namespace UnityEngine.UIElements;

public class KeyboardNavigationManipulator : Manipulator
{
	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action;

	public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action)
	{
	}

	protected override void RegisterCallbacksOnTarget()
	{
	}

	protected override void UnregisterCallbacksFromTarget()
	{
	}

	internal void OnKeyDown(KeyDownEvent evt)
	{
	}

	private void OnNavigationCancel(NavigationCancelEvent evt)
	{
	}

	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	private void OnNavigationMove(NavigationMoveEvent evt)
	{
	}

	private void Invoke(KeyboardNavigationOperation operation, EventBase evt)
	{
	}
}
