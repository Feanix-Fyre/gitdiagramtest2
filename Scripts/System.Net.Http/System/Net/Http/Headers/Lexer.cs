namespace System.Net.Http.Headers;

internal class Lexer
{
	private static readonly bool[] token_chars;

	private static readonly int last_token_char;

	private static readonly string[] dt_formats;

	private readonly string s;

	private int pos;

	public int Position
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Lexer(string stream)
	{
	}

	public string GetStringValue(Token token)
	{
		return null;
	}

	public string GetStringValue(Token start, Token end)
	{
		return null;
	}

	public string GetQuotedStringValue(Token start)
	{
		return null;
	}

	public string GetRemainingStringValue(int position)
	{
		return null;
	}

	public bool IsStarStringValue(Token token)
	{
		return false;
	}

	public bool TryGetNumericValue(Token token, out int value)
	{
		value = default(int);
		return false;
	}

	public bool TryGetNumericValue(Token token, out long value)
	{
		value = default(long);
		return false;
	}

	public TimeSpan? TryGetTimeSpanValue(Token token)
	{
		return null;
	}

	public bool TryGetDateValue(Token token, out DateTimeOffset value)
	{
		value = default(DateTimeOffset);
		return false;
	}

	public static bool TryGetDateValue(string text, out DateTimeOffset value)
	{
		value = default(DateTimeOffset);
		return false;
	}

	public bool TryGetDoubleValue(Token token, out double value)
	{
		value = default(double);
		return false;
	}

	public static bool IsValidToken(string input)
	{
		return false;
	}

	public static bool IsValidCharacter(char input)
	{
		return false;
	}

	public void EatChar()
	{
	}

	public int PeekChar()
	{
		return 0;
	}

	public bool ScanCommentOptional(out string value, out Token readToken)
	{
		value = null;
		readToken = default(Token);
		return false;
	}

	public Token Scan(bool recognizeDash = false)
	{
		return default(Token);
	}
}
