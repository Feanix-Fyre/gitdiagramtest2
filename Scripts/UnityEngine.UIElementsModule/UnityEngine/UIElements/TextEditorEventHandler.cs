namespace UnityEngine.UIElements;

internal class TextEditorEventHandler
{
	protected TextElement textElement;

	protected TextEditingUtilities editingUtilities;

	protected TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
	{
	}

	public virtual void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}
}
