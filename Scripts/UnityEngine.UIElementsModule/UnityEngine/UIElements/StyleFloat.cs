using System;

namespace UnityEngine.UIElements;

public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat>
{
	private float m_Value;

	private StyleKeyword m_Keyword;

	public float value => 0f;

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleFloat(float v)
	{
		m_Value = 0f;
		m_Keyword = default(StyleKeyword);
	}

	public StyleFloat(StyleKeyword keyword)
	{
		m_Value = 0f;
		m_Keyword = default(StyleKeyword);
	}

	internal StyleFloat(float v, StyleKeyword keyword)
	{
		m_Value = 0f;
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleFloat lhs, StyleFloat rhs)
	{
		return false;
	}

	public static implicit operator StyleFloat(StyleKeyword keyword)
	{
		return default(StyleFloat);
	}

	public static implicit operator StyleFloat(float v)
	{
		return default(StyleFloat);
	}

	public bool Equals(StyleFloat other)
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
