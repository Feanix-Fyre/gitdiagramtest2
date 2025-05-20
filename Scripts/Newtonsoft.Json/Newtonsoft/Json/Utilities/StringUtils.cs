using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Newtonsoft.Json.Utilities;

internal static class StringUtils
{
	private enum SeparatedCaseState
	{
		Start = 0,
		Lower = 1,
		Upper = 2,
		NewWord = 3
	}

	public const string CarriageReturnLineFeed = "\r\n";

	public const string Empty = "";

	public const char CarriageReturn = '\r';

	public const char LineFeed = '\n';

	public const char Tab = '\t';

	public static bool IsNullOrEmpty([NotNullWhen(false)] string? value)
	{
		return false;
	}

	public static string FormatWith(this string format, IFormatProvider provider, object? arg0)
	{
		return null;
	}

	public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1)
	{
		return null;
	}

	public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1, object? arg2)
	{
		return null;
	}

	public static string? FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1, object? arg2, object? arg3)
	{
		return null;
	}

	private static string FormatWith(this string format, IFormatProvider provider, params object?[] args)
	{
		return null;
	}

	public static bool IsWhiteSpace(string s)
	{
		return false;
	}

	public static StringWriter CreateStringWriter(int capacity)
	{
		return null;
	}

	public static void ToCharAsUnicode(char c, char[] buffer)
	{
	}

	public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) where TSource : notnull
	{
		return default(TSource);
	}

	public static string ToCamelCase(string s)
	{
		return null;
	}

	private static char ToLower(char c)
	{
		return '\0';
	}

	public static string ToSnakeCase(string s)
	{
		return null;
	}

	public static string ToKebabCase(string s)
	{
		return null;
	}

	private static string ToSeparatedCase(string s, char separator)
	{
		return null;
	}

	public static bool IsHighSurrogate(char c)
	{
		return false;
	}

	public static bool IsLowSurrogate(char c)
	{
		return false;
	}

	public static int IndexOf(string s, char c)
	{
		return 0;
	}

	public static string Replace(string s, string oldValue, string newValue)
	{
		return null;
	}

	public static bool StartsWith(this string source, char value)
	{
		return false;
	}

	public static bool EndsWith(this string source, char value)
	{
		return false;
	}

	public static string Trim(this string s, int start, int length)
	{
		return null;
	}
}
