using Unity.Properties.Internal;

namespace Unity.Properties;

public static class PropertyBag
{
	public static void Register<TContainer>(PropertyBag<TContainer> propertyBag)
	{
	}
}
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
{
	InstantiationKind IConstructor.InstantiationKind => default(InstantiationKind);

	protected virtual InstantiationKind InstantiationKind { get; }

	static PropertyBag()
	{
	}

	void IPropertyBagRegister.Register()
	{
	}

	public void Accept(ITypeVisitor visitor)
	{
	}

	TContainer IConstructor<TContainer>.Instantiate()
	{
		return default(TContainer);
	}

	protected virtual TContainer Instantiate()
	{
		return default(TContainer);
	}
}
