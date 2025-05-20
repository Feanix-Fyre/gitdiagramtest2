namespace UnityEngine.UIElements;

public class Label : TextElement
{
	public new class UxmlFactory : UxmlFactory<Label, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextElement.UxmlTraits
	{
	}

	public new static readonly string ussClassName;

	public Label()
	{
	}

	public Label(string text)
	{
	}
}
