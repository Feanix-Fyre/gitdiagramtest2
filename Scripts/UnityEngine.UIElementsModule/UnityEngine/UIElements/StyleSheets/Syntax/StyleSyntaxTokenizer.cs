using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal class StyleSyntaxTokenizer
{
	private List<StyleSyntaxToken> m_Tokens;

	private int m_CurrentTokenIndex;

	public StyleSyntaxToken current => default(StyleSyntaxToken);

	public StyleSyntaxToken MoveNext()
	{
		return default(StyleSyntaxToken);
	}

	public StyleSyntaxToken PeekNext()
	{
		return default(StyleSyntaxToken);
	}

	public void Tokenize(string syntax)
	{
	}

	private static bool IsNextCharacter(string s, int index, char c)
	{
		return false;
	}

	private static bool IsNextLetterOrDash(string s, int index)
	{
		return false;
	}

	private static bool IsNextNumber(string s, int index)
	{
		return false;
	}

	private static int GlobCharacter(string s, int index, char c)
	{
		return 0;
	}
}
