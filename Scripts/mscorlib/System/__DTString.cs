using System.Globalization;
using System.Runtime.CompilerServices;

namespace System;

internal ref struct __DTString
{
	internal ReadOnlySpan<char> Value;

	internal int Index;

	internal char m_current;

	private CompareInfo m_info;

	private bool m_checkDigitToken;

	private static readonly char[] WhiteSpaceChecks;

	internal int Length => 0;

	internal CompareInfo CompareInfo => null;

	internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken)
	{
		Value = default(ReadOnlySpan<char>);
		Index = 0;
		m_current = '\0';
		m_info = null;
		m_checkDigitToken = false;
	}

	internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi)
	{
		Value = default(ReadOnlySpan<char>);
		Index = 0;
		m_current = '\0';
		m_info = null;
		m_checkDigitToken = false;
	}

	internal bool GetNext()
	{
		return false;
	}

	internal bool AtEnd()
	{
		return false;
	}

	internal bool Advance(int count)
	{
		return false;
	}

	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
	{
		tokenType = default(TokenType);
		tokenValue = default(int);
	}

	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
	{
		indexBeforeSeparator = default(int);
		charBeforeSeparator = default(char);
		return default(TokenType);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal bool MatchSpecifiedWord(string target)
	{
		return false;
	}

	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
	{
		return false;
	}

	internal bool Match(string str)
	{
		return false;
	}

	internal bool Match(char ch)
	{
		return false;
	}

	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen)
	{
		return 0;
	}

	internal int GetRepeatCount()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal bool GetNextDigit()
	{
		return false;
	}

	internal char GetChar()
	{
		return '\0';
	}

	internal int GetDigit()
	{
		return 0;
	}

	internal void SkipWhiteSpaces()
	{
	}

	internal bool SkipWhiteSpaceCurrent()
	{
		return false;
	}

	internal void TrimTail()
	{
	}

	internal void RemoveTrailingInQuoteSpaces()
	{
	}

	internal void RemoveLeadingInQuoteSpaces()
	{
	}

	internal DTSubString GetSubString()
	{
		return default(DTSubString);
	}

	internal void ConsumeSubString(DTSubString sub)
	{
	}
}
