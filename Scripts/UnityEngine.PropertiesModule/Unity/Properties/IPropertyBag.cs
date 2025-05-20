namespace Unity.Properties;

public interface IPropertyBag
{
	void Accept(ITypeVisitor visitor);
}
public interface IPropertyBag<TContainer> : IPropertyBag
{
}
