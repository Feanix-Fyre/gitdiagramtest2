using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName>
{
	internal int id;

	public PropertyName(string name)
	{
		id = 0;
	}

	public PropertyName(PropertyName other)
	{
		id = 0;
	}

	public static bool IsNullOrEmpty(PropertyName prop)
	{
		return false;
	}

	public static bool operator ==(PropertyName lhs, PropertyName rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public bool Equals(PropertyName other)
	{
		return false;
	}

	public static implicit operator PropertyName(string name)
	{
		return default(PropertyName);
	}

	public override string ToString()
	{
		return null;
	}
}
