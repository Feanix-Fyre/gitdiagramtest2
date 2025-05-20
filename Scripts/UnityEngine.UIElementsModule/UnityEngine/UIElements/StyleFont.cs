using System;

namespace UnityEngine.UIElements;

public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	private Font m_Value;

	private StyleKeyword m_Keyword;

	public Font value => null;

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleFont(Font v)
	{
		m_Value = null;
		m_Keyword = default(StyleKeyword);
	}

	internal StyleFont(Font v, StyleKeyword keyword)
	{
		m_Value = null;
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleFont lhs, StyleFont rhs)
	{
		return false;
	}

	public static implicit operator StyleFont(Font v)
	{
		return default(StyleFont);
	}

	public bool Equals(StyleFont other)
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
