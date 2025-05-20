namespace UnityEngine.UIElements;

internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
{
	private IVisualElementScheduledItem m_TouchKeyboardPoller;

	private bool m_TouchKeyboardAllowsInPlaceEditing;

	private bool m_IsClicking;

	public TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
		: base(null, null)
	{
	}

	private void PollTouchScreenKeyboard()
	{
	}

	private void DoPollTouchScreenKeyboard()
	{
	}

	private void UpdateStringPositionFromKeyboard()
	{
	}

	private void CloseTouchScreenKeyboard()
	{
	}

	private void OpenTouchScreenKeyboard()
	{
	}

	public override void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	private void OnPointerDownEvent()
	{
	}

	private void OnPointerUpEvent(PointerUpEvent evt)
	{
	}

	private void OnFocusInEvent()
	{
	}

	private void OnFocusOutEvent(FocusOutEvent evt)
	{
	}
}
