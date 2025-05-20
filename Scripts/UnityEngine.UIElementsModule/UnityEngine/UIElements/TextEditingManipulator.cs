namespace UnityEngine.UIElements;

internal class TextEditingManipulator
{
	private TextElement m_TextElement;

	internal TextEditorEventHandler editingEventHandler;

	internal TextEditingUtilities editingUtilities;

	private bool m_TouchScreenTextFieldInitialized;

	private IVisualElementScheduledItem m_HardwareKeyboardPoller;

	private bool touchScreenTextFieldChanged => false;

	public TextEditingManipulator(TextElement textElement)
	{
	}

	private void InitTextEditorEventHandler()
	{
	}

	internal void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	private void OnFocusInEvent(FocusInEvent _)
	{
	}

	private void OnFocusOutEvent(FocusOutEvent _)
	{
	}
}
