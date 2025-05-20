namespace UnityEngine.UIElements;

public class GroupBox : BindableElement, IGroupBox
{
	public new class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits>
	{
	}

	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public static readonly string ussClassName;

	public static readonly string labelUssClassName;

	private Label m_TitleLabel;

	public string text
	{
		set
		{
		}
	}

	public GroupBox()
	{
	}

	public GroupBox(string text)
	{
	}

	void IGroupBox.OnOptionAdded(IGroupBoxOption option)
	{
	}

	void IGroupBox.OnOptionRemoved(IGroupBoxOption option)
	{
	}
}
