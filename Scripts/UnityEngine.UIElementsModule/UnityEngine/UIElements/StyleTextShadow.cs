using System;

namespace UnityEngine.UIElements;

public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
{
	private StyleKeyword m_Keyword;

	private TextShadow m_Value;

	public TextShadow value => default(TextShadow);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleTextShadow(StyleKeyword keyword)
	{
		m_Keyword = default(StyleKeyword);
		m_Value = default(TextShadow);
	}

	internal StyleTextShadow(TextShadow v, StyleKeyword keyword)
	{
		m_Keyword = default(StyleKeyword);
		m_Value = default(TextShadow);
	}

	public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
	{
		return false;
	}

	public static implicit operator StyleTextShadow(StyleKeyword keyword)
	{
		return default(StyleTextShadow);
	}

	public bool Equals(StyleTextShadow other)
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
