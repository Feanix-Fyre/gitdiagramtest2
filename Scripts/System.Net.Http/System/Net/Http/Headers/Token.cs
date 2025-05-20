namespace System.Net.Http.Headers;

internal struct Token
{
	public enum Type
	{
		Error = 0,
		End = 1,
		Token = 2,
		QuotedString = 3,
		SeparatorEqual = 4,
		SeparatorSemicolon = 5,
		SeparatorSlash = 6,
		SeparatorDash = 7,
		SeparatorComma = 8,
		OpenParens = 9
	}

	public static readonly Token Empty;

	private readonly Type type;

	public int StartPosition { get; private set; }

	public int EndPosition { get; private set; }

	public Type Kind => default(Type);

	public Token(Type type, int startPosition, int endPosition)
	{
		this.type = default(Type);
		StartPosition = 0;
		EndPosition = 0;
	}

	public static implicit operator Type(Token token)
	{
		return default(Type);
	}

	public override string ToString()
	{
		return null;
	}
}
