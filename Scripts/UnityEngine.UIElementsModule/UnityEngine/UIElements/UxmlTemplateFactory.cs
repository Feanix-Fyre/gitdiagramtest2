namespace UnityEngine.UIElements;

public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
{
	public override string uxmlName => null;

	public override string uxmlQualifiedName => null;

	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}
}
