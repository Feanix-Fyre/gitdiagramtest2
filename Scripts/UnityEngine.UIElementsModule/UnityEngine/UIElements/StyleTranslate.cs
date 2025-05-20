using System;

namespace UnityEngine.UIElements;

public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
{
	private Translate m_Value;

	private StyleKeyword m_Keyword;

	public Translate value => default(Translate);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleTranslate(Translate v)
	{
		m_Value = default(Translate);
		m_Keyword = default(StyleKeyword);
	}

	public StyleTranslate(StyleKeyword keyword)
	{
		m_Value = default(Translate);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleTranslate(Translate v, StyleKeyword keyword)
	{
		m_Value = default(Translate);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs)
	{
		return false;
	}

	public static implicit operator StyleTranslate(StyleKeyword keyword)
	{
		return default(StyleTranslate);
	}

	public static implicit operator StyleTranslate(Translate v)
	{
		return default(StyleTranslate);
	}

	public bool Equals(StyleTranslate other)
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
