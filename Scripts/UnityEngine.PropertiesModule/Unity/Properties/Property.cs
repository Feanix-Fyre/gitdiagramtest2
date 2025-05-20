using System;
using System.Collections.Generic;
using Unity.Properties.Internal;

namespace Unity.Properties;

public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes
{
	private List<Attribute> m_Attributes;

	public abstract string Name { get; }

	public Type DeclaredValueType()
	{
		return null;
	}

	protected void AddAttribute(Attribute attribute)
	{
	}

	protected void AddAttributes(IEnumerable<Attribute> attributes)
	{
	}

	void IAttributes.AddAttribute(Attribute attribute)
	{
	}

	void IAttributes.AddAttributes(IEnumerable<Attribute> attributes)
	{
	}

	public bool HasAttribute<TAttribute>() where TAttribute : Attribute
	{
		return false;
	}
}
