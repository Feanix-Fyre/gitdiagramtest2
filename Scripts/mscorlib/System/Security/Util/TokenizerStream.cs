namespace System.Security.Util;

internal sealed class TokenizerStream
{
	private int m_countTokens;

	private TokenizerShortBlock m_headTokens;

	private TokenizerShortBlock m_lastTokens;

	private TokenizerShortBlock m_currentTokens;

	private int m_indexTokens;

	private TokenizerStringBlock m_headStrings;

	private TokenizerStringBlock m_currentStrings;

	private int m_indexStrings;

	internal TokenizerStream()
	{
	}

	internal void AddToken(short token)
	{
	}

	internal void AddString(string str)
	{
	}

	internal void Reset()
	{
	}

	internal short GetNextFullToken()
	{
		return 0;
	}

	internal short GetNextToken()
	{
		return 0;
	}

	internal string GetNextString()
	{
		return null;
	}

	internal void ThrowAwayNextString()
	{
	}

	internal void TagLastToken(short tag)
	{
	}

	internal int GetTokenCount()
	{
		return 0;
	}

	internal void GoToPosition(int position)
	{
	}
}
