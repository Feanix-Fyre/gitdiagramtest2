using System;

namespace UnityEngine.UIElements;

public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
{
	private TransformOrigin m_Value;

	private StyleKeyword m_Keyword;

	public TransformOrigin value => default(TransformOrigin);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleTransformOrigin(StyleKeyword keyword)
	{
		m_Value = default(TransformOrigin);
		m_Keyword = default(StyleKeyword);
	}

	internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword)
	{
		m_Value = default(TransformOrigin);
		m_Keyword = default(StyleKeyword);
	}

	public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
	{
		return false;
	}

	public static implicit operator StyleTransformOrigin(StyleKeyword keyword)
	{
		return default(StyleTransformOrigin);
	}

	public bool Equals(StyleTransformOrigin other)
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
