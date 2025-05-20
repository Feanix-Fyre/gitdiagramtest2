using System;

namespace UnityEngine.UIElements;

public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt>
{
	private int m_Value;

	private StyleKeyword m_Keyword;

	public int value => 0;

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleInt(StyleKeyword keyword)
	{
		m_Value = 0;
		m_Keyword = default(StyleKeyword);
	}

	internal StyleInt(int v, StyleKeyword keyword)
	{
		m_Value = 0;
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleInt lhs, StyleInt rhs)
	{
		return false;
	}

	public static implicit operator StyleInt(StyleKeyword keyword)
	{
		return default(StyleInt);
	}

	public bool Equals(StyleInt other)
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
