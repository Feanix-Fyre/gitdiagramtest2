using System.Collections.Generic;

namespace Unity.Properties;

public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer>
{
	private readonly List<IProperty<TContainer>> m_PropertiesList;

	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash;

	static ContainerPropertyBag()
	{
	}

	protected void AddProperty<TValue>(Property<TContainer, TValue> property)
	{
	}

	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property)
	{
		property = null;
		return false;
	}
}
