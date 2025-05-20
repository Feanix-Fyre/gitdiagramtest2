using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets;

internal class StylePropertyValueMatcher : BaseStyleMatcher
{
	private List<StylePropertyValue> m_Values;

	private StylePropertyValue current => default(StylePropertyValue);

	public override int valueCount => 0;

	public override bool isCurrentVariable => false;

	public override bool isCurrentComma => false;

	public MatchResult Match(Expression exp, List<StylePropertyValue> values)
	{
		return default(MatchResult);
	}

	protected override bool MatchKeyword(string keyword)
	{
		return false;
	}

	protected override bool MatchNumber()
	{
		return false;
	}

	protected override bool MatchInteger()
	{
		return false;
	}

	protected override bool MatchLength()
	{
		return false;
	}

	protected override bool MatchPercentage()
	{
		return false;
	}

	protected override bool MatchColor()
	{
		return false;
	}

	protected override bool MatchResource()
	{
		return false;
	}

	protected override bool MatchUrl()
	{
		return false;
	}

	protected override bool MatchTime()
	{
		return false;
	}

	protected override bool MatchCustomIdent()
	{
		return false;
	}

	protected override bool MatchAngle()
	{
		return false;
	}
}
