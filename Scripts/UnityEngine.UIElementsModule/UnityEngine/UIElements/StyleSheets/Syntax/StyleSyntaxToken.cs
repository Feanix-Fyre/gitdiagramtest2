namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal struct StyleSyntaxToken
{
	public StyleSyntaxTokenType type;

	public string text;

	public int number;

	public StyleSyntaxToken(StyleSyntaxTokenType t)
	{
		type = default(StyleSyntaxTokenType);
		text = null;
		number = 0;
	}

	public StyleSyntaxToken(StyleSyntaxTokenType type, string text)
	{
		this.type = default(StyleSyntaxTokenType);
		this.text = null;
		number = 0;
	}

	public StyleSyntaxToken(StyleSyntaxTokenType type, int number)
	{
		this.type = default(StyleSyntaxTokenType);
		text = null;
		this.number = 0;
	}
}
