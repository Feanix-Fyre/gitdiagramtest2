namespace UnityEngine.UIElements;

public class TemplateContainer : BindableElement
{
	public new class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
	{
		public override string uxmlName => null;

		public override string uxmlQualifiedName => null;
	}

	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_Template;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private VisualElement m_ContentContainer;

	private VisualTreeAsset m_TemplateSource;

	public string templateId { get; private set; }

	internal VisualTreeAsset templateSource
	{
		set
		{
		}
	}

	public override VisualElement contentContainer => null;

	public TemplateContainer()
	{
	}

	public TemplateContainer(string templateId)
	{
	}

	internal void SetContentContainer(VisualElement content)
	{
	}
}
