using System;

namespace UnityEngine.UIElements;

public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
{
	private Rotate m_Value;

	private StyleKeyword m_Keyword;

	public Rotate value => default(Rotate);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleRotate(StyleKeyword keyword)
	{
		m_Value = default(Rotate);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleRotate(Rotate v, StyleKeyword keyword)
	{
		m_Value = default(Rotate);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleRotate lhs, StyleRotate rhs)
	{
		return false;
	}

	public static implicit operator StyleRotate(StyleKeyword keyword)
	{
		return default(StyleRotate);
	}

	public bool Equals(StyleRotate other)
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
