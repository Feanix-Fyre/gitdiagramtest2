using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

public struct StylePropertyName : IEquatable<StylePropertyName>
{
	internal StylePropertyId id { get; }

	private string name { get; }

	internal static StylePropertyId StylePropertyIdFromString(string name)
	{
		return default(StylePropertyId);
	}

	internal StylePropertyName(StylePropertyId stylePropertyId)
	{
		id = default(StylePropertyId);
		name = null;
	}

	public StylePropertyName(string name)
	{
		id = default(StylePropertyId);
		this.name = null;
	}

	public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs)
	{
		return false;
	}

	public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs)
	{
		return false;
	}

	public static implicit operator StylePropertyName(string name)
	{
		return default(StylePropertyName);
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(StylePropertyName other)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
