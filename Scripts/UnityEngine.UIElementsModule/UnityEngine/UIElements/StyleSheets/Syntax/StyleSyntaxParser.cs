using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal class StyleSyntaxParser
{
	private List<Expression> m_ProcessExpressionList;

	private Stack<Expression> m_ExpressionStack;

	private Stack<ExpressionCombinator> m_CombinatorStack;

	private Dictionary<string, Expression> m_ParsedExpressionCache;

	public Expression Parse(string syntax)
	{
		return null;
	}

	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	private void ProcessCombinatorStack()
	{
	}

	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer)
	{
		return default(ExpressionCombinator);
	}

	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	private Expression ParseNonTerminalValue(string syntax)
	{
		return null;
	}

	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier)
	{
	}

	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max)
	{
		min = default(int);
		max = default(int);
	}

	private static void EatSpace(StyleSyntaxTokenizer tokenizer)
	{
	}

	private static bool IsExpressionEnd(StyleSyntaxToken token)
	{
		return false;
	}

	private static bool IsCombinator(StyleSyntaxToken token)
	{
		return false;
	}

	private static bool IsMultiplier(StyleSyntaxToken token)
	{
		return false;
	}
}
