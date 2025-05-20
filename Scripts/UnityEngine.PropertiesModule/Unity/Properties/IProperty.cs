using System;

namespace Unity.Properties;

public interface IProperty
{
	Type DeclaredValueType();
}
public interface IProperty<TContainer> : IProperty
{
}
