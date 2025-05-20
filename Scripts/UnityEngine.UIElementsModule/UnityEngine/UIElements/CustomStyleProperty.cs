using System;

namespace UnityEngine.UIElements;

public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>>
{
	public string name { get; private set; }

	public CustomStyleProperty(string propertyName)
	{
		name = null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(CustomStyleProperty<T> other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
