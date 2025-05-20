using System;

namespace UnityEngine.UIElements;

public class UxmlTypeAttributeDescription<TBase> : TypedUxmlAttributeDescription<Type>
{
	public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	private Type ConvertValueToType(string v, Type defaultValue)
	{
		return null;
	}
}
