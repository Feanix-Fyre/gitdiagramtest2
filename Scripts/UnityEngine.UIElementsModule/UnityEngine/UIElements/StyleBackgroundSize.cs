using System;

namespace UnityEngine.UIElements;

public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize>
{
	private BackgroundSize m_Value;

	private StyleKeyword m_Keyword;

	public BackgroundSize value => default(BackgroundSize);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleBackgroundSize(StyleKeyword keyword)
	{
		m_Value = default(BackgroundSize);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleBackgroundSize(BackgroundSize v, StyleKeyword keyword)
	{
		m_Value = default(BackgroundSize);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleBackgroundSize lhs, StyleBackgroundSize rhs)
	{
		return false;
	}

	public static implicit operator StyleBackgroundSize(StyleKeyword keyword)
	{
		return default(StyleBackgroundSize);
	}

	public bool Equals(StyleBackgroundSize other)
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
