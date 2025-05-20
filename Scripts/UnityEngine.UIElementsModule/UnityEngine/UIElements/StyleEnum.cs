using System;

namespace UnityEngine.UIElements;

public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> where T : struct, IConvertible
{
	private T m_Value;

	private StyleKeyword m_Keyword;

	public T value => default(T);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleEnum(T v)
	{
		m_Value = default(T);
		m_Keyword = default(StyleKeyword);
	}

	public StyleEnum(StyleKeyword keyword)
	{
		m_Value = default(T);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleEnum(T v, StyleKeyword keyword)
	{
		m_Value = default(T);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs)
	{
		return false;
	}

	public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs)
	{
		return false;
	}

	public static implicit operator StyleEnum<T>(StyleKeyword keyword)
	{
		return default(StyleEnum<T>);
	}

	public static implicit operator StyleEnum<T>(T v)
	{
		return default(StyleEnum<T>);
	}

	public bool Equals(StyleEnum<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
