using System;

namespace UnityEngine.UIElements;

public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	private Length m_Value;

	private StyleKeyword m_Keyword;

	public Length value => default(Length);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleLength(float v)
	{
		m_Value = default(Length);
		m_Keyword = default(StyleKeyword);
	}

	public StyleLength(Length v)
	{
		m_Value = default(Length);
		m_Keyword = default(StyleKeyword);
	}

	public StyleLength(StyleKeyword keyword)
	{
		m_Value = default(Length);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleLength(Length v, StyleKeyword keyword)
	{
		m_Value = default(Length);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleLength lhs, StyleLength rhs)
	{
		return false;
	}

	public static implicit operator StyleLength(StyleKeyword keyword)
	{
		return default(StyleLength);
	}

	public static implicit operator StyleLength(float v)
	{
		return default(StyleLength);
	}

	public static implicit operator StyleLength(Length v)
	{
		return default(StyleLength);
	}

	public bool Equals(StyleLength other)
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
