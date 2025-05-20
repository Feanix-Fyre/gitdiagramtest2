namespace UnityEngine.UIElements;

internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
{
	private readonly Event m_ImguiEvent;

	internal bool m_Changed;

	public KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
		: base(null, null)
	{
	}

	public override void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	private void OnFocus(FocusEvent _)
	{
	}

	private void OnBlur(BlurEvent _)
	{
	}

	private void OnKeyDown(KeyDownEvent evt)
	{
	}

	private void UpdateLabel()
	{
	}

	private void OnValidateCommandEvent(ValidateCommandEvent evt)
	{
	}

	private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
	{
	}

	private void OnNavigationEvent<TEvent>(NavigationEventBase<TEvent> evt) where TEvent : NavigationEventBase<TEvent>, new()
	{
	}
}
