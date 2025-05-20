namespace UnityEngine.UIElements;

public class PopupWindow : TextElement
{
	public new class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextElement.UxmlTraits
	{
	}

	private VisualElement m_ContentContainer;

	public new static readonly string ussClassName;

	public static readonly string contentUssClassName;

	public override VisualElement contentContainer => null;
}
