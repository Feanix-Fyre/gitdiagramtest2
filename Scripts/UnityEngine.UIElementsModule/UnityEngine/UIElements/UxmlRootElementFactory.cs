namespace UnityEngine.UIElements;

public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
{
	public override string uxmlName => null;

	public override string uxmlQualifiedName => null;

	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}
}
