using System;

namespace UnityEngine.UIElements;

public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
{
	private Color m_Value;

	private StyleKeyword m_Keyword;

	public Color value => default(Color);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleColor(Color v)
	{
		m_Value = default(Color);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleColor(Color v, StyleKeyword keyword)
	{
		m_Value = default(Color);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleColor lhs, StyleColor rhs)
	{
		return false;
	}

	public static implicit operator StyleColor(Color v)
	{
		return default(StyleColor);
	}

	public bool Equals(StyleColor other)
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
