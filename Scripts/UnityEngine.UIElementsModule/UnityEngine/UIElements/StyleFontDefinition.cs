using System;

namespace UnityEngine.UIElements;

public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
{
	private StyleKeyword m_Keyword;

	private FontDefinition m_Value;

	public FontDefinition value => default(FontDefinition);

	public StyleKeyword keyword => default(StyleKeyword);

	public StyleFontDefinition(FontDefinition f)
	{
		m_Keyword = default(StyleKeyword);
		m_Value = default(FontDefinition);
	}

	internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword)
	{
		m_Keyword = default(StyleKeyword);
		m_Value = default(FontDefinition);
	}

	public static implicit operator StyleFontDefinition(FontDefinition f)
	{
		return default(StyleFontDefinition);
	}

	public bool Equals(StyleFontDefinition other)
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
}
