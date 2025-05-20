namespace UnityEngine.UIElements;

public class HelpBox : VisualElement
{
	public new class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits>
	{
	}

	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text;

		private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public static readonly string ussClassName;

	public static readonly string labelUssClassName;

	public static readonly string iconUssClassName;

	public static readonly string iconInfoUssClassName;

	public static readonly string iconwarningUssClassName;

	public static readonly string iconErrorUssClassName;

	private HelpBoxMessageType m_HelpBoxMessageType;

	private VisualElement m_Icon;

	private string m_IconClass;

	private Label m_Label;

	public string text
	{
		set
		{
		}
	}

	public HelpBoxMessageType messageType
	{
		set
		{
		}
	}

	public HelpBox()
	{
	}

	public HelpBox(string text, HelpBoxMessageType messageType)
	{
	}

	private string GetIconClass(HelpBoxMessageType messageType)
	{
		return null;
	}

	private void UpdateIcon(HelpBoxMessageType messageType)
	{
	}
}
