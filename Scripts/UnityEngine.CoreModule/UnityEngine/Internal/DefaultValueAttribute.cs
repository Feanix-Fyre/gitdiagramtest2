using System;

namespace UnityEngine.Internal;

[Serializable]
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public class DefaultValueAttribute : Attribute
{
	private object DefaultValue;

	public object Value => null;

	public DefaultValueAttribute(string value)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
